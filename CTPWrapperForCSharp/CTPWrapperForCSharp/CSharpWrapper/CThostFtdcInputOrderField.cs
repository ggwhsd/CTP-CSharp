//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInputOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderPriceType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int UserForceClose {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_UserForceClose_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_UserForceClose_get(swigCPtr);
      return ret;
    } 
  }

  public int IsSwapOrder {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderMemo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderMemo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_OrderMemo_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionReqSeq {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_SessionReqSeq_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOrderField_SessionReqSeq_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputOrderField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInputOrderField(), true) {
  }

}
