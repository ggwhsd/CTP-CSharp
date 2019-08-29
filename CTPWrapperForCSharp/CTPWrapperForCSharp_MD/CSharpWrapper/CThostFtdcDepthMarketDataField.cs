//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcDepthMarketDataField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcDepthMarketDataField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcDepthMarketDataField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcDepthMarketDataField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcDepthMarketDataField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public double LastPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LastPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LastPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreClosePrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreOpenInterest {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreOpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreOpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double HighestPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_HighestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_HighestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowestPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LowestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LowestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenInterest {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_OpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_OpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperLimitPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpperLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpperLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowerLimitPrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LowerLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_LowerLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDelta {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreDelta_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_PreDelta_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrDelta {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_CurrDelta_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_CurrDelta_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public int UpdateMillisec {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpdateMillisec_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_UpdateMillisec_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice1 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice1_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice1_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume1 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume1_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume1_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice1 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice1_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice1_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume1 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume1_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume1_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice2 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume2 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume2_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice2 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume2 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume2_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice3 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume3 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume3_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice3 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume3 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume3_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice4 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume4 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume4_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice4 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume4 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume4_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice5 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume5 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume5_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_BidVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice5 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume5 {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume5_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AskVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public double AveragePrice {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AveragePrice_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_AveragePrice_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDay {
    set {
      thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ActionDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcDepthMarketDataField_ActionDay_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcDepthMarketDataField() : this(thostmdapiPINVOKE.new_CThostFtdcDepthMarketDataField(), true) {
  }

}