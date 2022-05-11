using CTPWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTP6_5_1ReleaseDemo
{
    class CustomMD : CThostFtdcMdSpi
    {
        public CustomMD()
        { }

        ~CustomMD()
        { }

        private CThostFtdcMdApi mdApi = null;
        private bool isConnected = false;
        private bool isLogin = false;
        public string userName = "";
        public string password = "";
        public string broker = "";
        public int nRequest = 0;


        public bool IsConnected { get => isConnected; }
        public bool IsLogin { get => isLogin; }

        public Action<string> logMessageCallBack;

        public void CreateMDApi()
        {
            if (mdApi == null)
            {
                mdApi = CThostFtdcMdApi.CreateFtdcMdApi("spi/MD_", false,false);
                SetMDSpi();
            }
        }
        public void SetMDSpi()
        {
            mdApi.RegisterSpi(this);
        }
        public void Init(string MDAddress)
        {
            mdApi.RegisterFront(MDAddress);
            mdApi.Init();
        }
        public void Release()
        {
            if (isLogin == true && mdApi != null)
            {
                mdApi.Release();
                mdApi = null;
                isLogin = false;
            }
        }
        public override void OnFrontConnected()
        {
            isConnected = true;

            CThostFtdcReqUserLoginField loginReq = new CThostFtdcReqUserLoginField();
            loginReq.BrokerID = broker;
            loginReq.UserID = userName;
            loginReq.Password = password;
            int rt = mdApi.ReqUserLogin(loginReq, nRequest++);
            logMessageCallBack?.Invoke($"{userName}网络能够连通");

        }

        // 登录应答
        public override void OnRspUserLogin(
             CThostFtdcRspUserLoginField pRspUserLogin,
             CThostFtdcRspInfoField pRspInfo,
             int nRequestID,
             bool bIsLast)
        {
            if (isNoError(pRspInfo))
            {
                isLogin = true;
            }
            else
            {
            }
        }


        ///订阅行情应答
        public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            logMessageCallBack?.Invoke($"{pSpecificInstrument.InstrumentID} 订阅: {pRspInfo.ErrorMsg}");

        }

        ///取消订阅行情应答
        public override void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {

        }
        ///订阅询价应答
        public override void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        ///取消订阅询价应答
        public override void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
        }

        ///深度行情通知
        public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            logMessageCallBack?.Invoke($"{pDepthMarketData.UpdateTime} 收到行情: {pDepthMarketData.InstrumentID} {pDepthMarketData.LastPrice}");

        }

        ///询价通知
        public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {

        }

        private bool isNoError(CThostFtdcRspInfoField pRspInfo)
        {
            if (pRspInfo != null && pRspInfo.ErrorID == 0)
                return true;
            else if (pRspInfo == null)
                return true;
            else
                return false;
        }

        public void Subscribe(string instrId)
        {
            if (string.IsNullOrEmpty(instrId))
            {
                string[] instrIds = { instrId };
                mdApi.SubscribeMarketData(instrIds, 1);
            }
        }
        public void Subscribe(List<string> instrIds)
        {
           
            if(instrIds!=null && instrIds.Count>0)
                mdApi.SubscribeMarketData(instrIds.ToArray(), instrIds.Count);
        }


    }
}
