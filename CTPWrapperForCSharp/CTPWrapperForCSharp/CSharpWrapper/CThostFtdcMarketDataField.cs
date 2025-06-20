//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcMarketDataField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public double LastPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LastPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LastPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreClosePrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreOpenInterest {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreOpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreOpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double HighestPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_HighestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_HighestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowestPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LowestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LowestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public double Turnover {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_Turnover_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_Turnover_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenInterest {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_OpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_OpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperLimitPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpperLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpperLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowerLimitPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LowerLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_LowerLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDelta {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreDelta_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_PreDelta_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrDelta {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_CurrDelta_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_CurrDelta_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public int UpdateMillisec {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpdateMillisec_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_UpdateMillisec_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ActionDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ActionDay_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcMarketDataField(), true) {
  }

}
