//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcNotifyFutureSignOutField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcNotifyFutureSignOutField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcNotifyFutureSignOutField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcNotifyFutureSignOutField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcNotifyFutureSignOutField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcNotifyFutureSignOutField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcNotifyFutureSignOutField() : this(thostmdapiPINVOKE.new_CThostFtdcNotifyFutureSignOutField(), true) {
  }

}