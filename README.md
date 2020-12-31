# CSharp的CTP使用方法：

Release文件夹中有Release版本的CTP接口，命名空间是CTPWrapper。
所有接口名称都和C++的CTP api版本文档描述中的一致。

2020-12-31 更新了CTP 6.5.1 Api版本。

# 项目构建描述

如果不想看可以忽略。

* CTPWrapperForCSharp_MD负责封装行情DLL

* CTPWrapperForCSharp负责封装交易DLL

* 先建立一个C#的工程名为CSharpCTP

* 将debug目录下的Dll文件都拷贝到CSharpCTP的工程目录下。

* 将CTPWrapperForCSharp.dll改名为thosttradeapi.dll 

* 将CTPWrapperForCSharp_MD.dll改名为thostmdapi.dll

* 将thostmduserapi_se.dll和thosttraderapi_se.dll拷贝到CSharpCTP工程的debug目录下

* 将CSharpLibraryCS中的所有文件拷贝到CSharpCTP的目录中，并通过VS2017添加现有项目，将这些文件添加到工程中。

# 代码演示

* 接下来，就可以使用如下代码来调用CTP的类和方法，如下是创建行情回调类示例

```
using CTPWrapper;

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

        public void CreateMDApi()
        {
            if (mdApi == null)
            {
                mdApi = CThostFtdcMdApi.CreateFtdcMdApi("MD_",true); 
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
        }

        ///询价通知
        public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {

        }

        private bool isNoError(CThostFtdcRspInfoField pRspInfo)
        {
            if (pRspInfo != null && pRspInfo.ErrorID == 0)
                return true;
            else if (pRspInfo==null)
                return true;
            else
                return false;
        }

    }
```

* 创建行情并注册

```
...
 CustomMD CTPMD = null;
 private void 连接行情ToolStripMenuItem_Click(object sender, EventArgs e)
{
	if (CTPMD == null)
	{
		CTPMD = new CustomMD();
	}
	if (cfgAccountInfo == null)
	{
		cfgAccountInfo = new CTPAccount();  //这个类自己开发，主要功能就是从文件中读取ctp账号配置信息
	}
	CTPMD.broker = cfgAccountInfo.Brokerid;
	CTPMD.userName = cfgAccountInfo.Investor;
	CTPMD.password = cfgAccountInfo.Passwd;
	CTPMD.CreateMDApi();

	if (CTPMD != null && CTPMD.IsLogin == false)
	{
		CTPMD.Init(cfgAccountInfo.MDAdress1);
		//ShowMsg("[ING]ctp md connecting");
	}
	else
	{
		//ShowMsg("[ERROR]create ctp md instance error");
	}
}

private void 断开行情ToolStripMenuItem_Click(object sender, EventArgs e)
{
	if (CTPMD.IsLogin == true)
	{
		CTPMD.Release();
	}
}
...
```