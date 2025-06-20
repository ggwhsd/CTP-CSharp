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
          ctpthostmdapiPINVOKE.delete_CThostFtdcInputOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderPriceType {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int UserForceClose {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_UserForceClose_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_UserForceClose_get(swigCPtr);
      return ret;
    } 
  }

  public int IsSwapOrder {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderMemo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderMemo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_OrderMemo_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionReqSeq {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_SessionReqSeq_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInputOrderField_SessionReqSeq_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputOrderField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcInputOrderField(), true) {
  }

}
