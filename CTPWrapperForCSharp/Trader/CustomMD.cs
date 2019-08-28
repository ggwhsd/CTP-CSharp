using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader
{
    class CustomTD : CThostFtdcTraderSpi
    {

        public CustomTD()
        { }

        ~CustomTD()
        { }

        private CThostFtdcTraderApi tradeApi  = null;
        private bool isConnected = false;
        private bool isLogin = false;
        public string userName = "";
        public string password = "";
        public string broker = "";
        public string appCode = "8HS44W7NFW0L9SDB";
        public string appID = "client_orcgtw_1.0.0";
        public int nRequest = 0;

        public int sessionId = 0;
        public int frondId = 0;
        public string orderRef = "";

        public void CreateTDApi()
        {
            if(tradeApi==null)
            {
                tradeApi = CThostFtdcTraderApi.CreateFtdcTraderApi("TRADER-"); // 创建交易实例
            }
        }
        public void SetTDSpi()
        {
            tradeApi.RegisterSpi(this);
        }

        public void Init(string TDAddress)
        {
            tradeApi.SubscribePublicTopic(THOST_TE_RESUME_TYPE.THOST_TERT_RESTART);    // 订阅公共流
            tradeApi.SubscribePrivateTopic(THOST_TE_RESUME_TYPE.THOST_TERT_RESTART);   // 订阅私有流
            tradeApi.RegisterFront(TDAddress);              // 设置交易前置地址
            tradeApi.Init();                                      // 连接运行
        }

        public override void OnFrontConnected()
        {
            Console.WriteLine("[network connected]");
            isConnected = true;
            // 开始认证

           string version = CThostFtdcTraderApi.GetApiVersion();
            Console.WriteLine("当前版本号 ：{0}",version);

            CThostFtdcReqAuthenticateField field = new CThostFtdcReqAuthenticateField();

            field.BrokerID = broker;
            field.UserID= userName;

            int rt = tradeApi.ReqAuthenticate(field, nRequest++);
            if ( rt == 0)
                Console.WriteLine(" [SUCCESS] ");
            else
                Console.WriteLine(" [FAILED] ");
        }


        public override void OnRspAuthenticate(CThostFtdcRspAuthenticateField pRspAuthenticateField, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (pRspInfo!=null)
            {
                Console.WriteLine("Authenticated [SUCCESS]");
                reqUserLogin();
            }
            else
            {
                Console.WriteLine("{0},{1}", pRspInfo.ErrorID, pRspInfo.ErrorMsg);
            }


        }


        public override void  OnRspUserLogin(
            CThostFtdcRspUserLoginField pRspUserLogin,
            CThostFtdcRspInfoField pRspInfo,
            int nRequestID,
            bool bIsLast)
        {
            if (pRspInfo!=null)
            {

                isLogin = true;
                Console.WriteLine("[SUCCESS]  TradingDay：{0}", pRspUserLogin.TradingDay);
                Console.WriteLine("[SUCCESS]  LoginTime：{0}", pRspUserLogin.LoginTime);
                Console.WriteLine("[SUCCESS]  BrokerID：{0}", pRspUserLogin.BrokerID);
                Console.WriteLine("[SUCCESS]  UserID：{0}", pRspUserLogin.UserID);
                Console.WriteLine("[SUCCESS]  FrontID：{0}", pRspUserLogin.FrontID);
                Console.WriteLine("[SUCCESS]  SessionID：{0:d}", pRspUserLogin.SessionID);
                Console.WriteLine("[SUCCESS]  MaxOrderRef：{0}", pRspUserLogin.MaxOrderRef);
                

                // 投资者结算结果确认
                //reqSettlementInfoConfirm();
            }
            else
            {
                Console.WriteLine("{0},{1}", pRspInfo.ErrorID, pRspInfo.ErrorMsg);
                Console.WriteLine(" OnRspUserLogin [FAILED] ");

            }
        }


        public void reqUserLogin()
        {
            CThostFtdcReqUserLoginField loginReq = new CThostFtdcReqUserLoginField();

            loginReq.BrokerID = broker;
            loginReq.UserID = userName;
            loginReq.Password = password;
            
            int rt = tradeApi.ReqUserLogin(loginReq, nRequest++);
            if (rt == 0)
                Console.WriteLine(" ReqUserLogin [SUCCESS] ");
            else
                Console.WriteLine(" ReqUserLogin [FAILED] ");
        }


    }
}
