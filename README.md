# CSharp的CTP使用方法：

所有接口名称都和C++的CTP api版本文档描述中的一致。

2025-06-16 更新了CTP 6.7.9_P1_20250319的API版本，CTP-CSharp\Release 目录下。

2022-5-10  新增了示例项目Example目录下，在代码中填入ctp的登录信息，仿真就可以登录行情了。

2022-5-10  更新了工程的转换配置，解决行情接口无法调用订阅函数的问题。

2022-1-14  更新了Release目录，新增.NET 5环境下的x86平台的CTP 6.5.1 Api版本。

2020-12-31 更新了CTP 6.5.1 Api版本。.NET FrameWork 4.6.2 平台测试。




Release中的文件并非由最终由工程编译生成，这些工程只是给个转换的过程，用于学习，并不是一直更新的。

Release文件夹中有Release版本的CTP接口。

对于非开发环境部署，需要安装微软的运行库，参考网站：https://learn.microsoft.com/zh-cn/cpp/windows/latest-supported-vc-redist?view=msvc-170  。

# 项目构建描述

如果不想看可以忽略。CSharpLibraryCS目录下包含了所有转换为C#的代码。

在CTPWrapperForCSharp_MD和CTPWrapperForCSharp目录下，执行以下命令，转换c++为封装的c#代码文件，这个是第一步。
```swig.exe -c++ -csharp CTP2CSharp.idl```

* CTPWrapperForCSharp_MD负责封装行情DLL。将CTPWrapperForCSharp.dll改名为ctpthostmdapi.dll。

* CTPWrapperForCSharp负责封装交易DLL。将CTPWrapperForCSharp_MD.dll改名为ctpthosttradeapi.dll。

* 先建立一个存放cs代码的文件名为 CSharpLibraryCS。

* 建立c#库工程，CTPWrapper，右键添加项，添加以上文件夹下面的所有cs文件代码。生成一个C#的CTPWrapper项目的dll文件。

* 将Release目录下的Dll文件都拷贝到 CTP-CSharp\Release 的工程目录下。一共有 ctpthostmdapi.dll、ctpthosttradeapi.dll、thostmduserapi_se.dll、thosttraderapi_se.dll、CTPWrapper.dll。




# 代码演示

* 接下来，就可以使用如下代码来调用CTP的类和方法，如下是创建行情回调类示例

```
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
