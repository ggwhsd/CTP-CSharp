//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRspFutureSignInField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspFutureSignInField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspFutureSignInField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspFutureSignInField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcRspFutureSignInField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string PinKey {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_PinKey_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_PinKey_get(swigCPtr);
      return ret;
    } 
  }

  public string MacKey {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_MacKey_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspFutureSignInField_MacKey_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspFutureSignInField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcRspFutureSignInField(), true) {
  }

}
