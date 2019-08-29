//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOptionSelfCloseActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionSelfCloseActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionSelfCloseActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOptionSelfCloseActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcOptionSelfCloseActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int OptionSelfCloseActionRef {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseRef {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseLocalID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OptionSelfCloseLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionSelfCloseActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionSelfCloseActionField() : this(thostmdapiPINVOKE.new_CThostFtdcOptionSelfCloseActionField(), true) {
  }

}