//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqSyncKeyField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqSyncKeyField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqSyncKeyField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqSyncKeyField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcReqSyncKeyField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqSyncKeyField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqSyncKeyField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcReqSyncKeyField(), true) {
  }

}
