//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcExchangeCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public char CombDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_CombDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_CombDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ComTradeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ComTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ComTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeCombActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeCombActionField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcExchangeCombActionField(), true) {
  }

}
