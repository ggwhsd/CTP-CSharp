//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string CombActionRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_CombActionRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_CombActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public char CombDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_CombDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_CombDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve3 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve3_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_reserve3_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ComTradeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ComTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ComTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcCombActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCombActionField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcCombActionField(), true) {
  }

}
