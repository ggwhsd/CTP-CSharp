//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqFutureSignOutField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqFutureSignOutField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqFutureSignOutField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqFutureSignOutField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcReqFutureSignOutField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcReqFutureSignOutField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqFutureSignOutField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcReqFutureSignOutField(), true) {
  }

}
