//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputOptionSelfCloseField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputOptionSelfCloseField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputOptionSelfCloseField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputOptionSelfCloseField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInputOptionSelfCloseField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string OptionSelfCloseRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_OptionSelfCloseRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_OptionSelfCloseRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char OptSelfCloseFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_OptSelfCloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_OptSelfCloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputOptionSelfCloseField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputOptionSelfCloseField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInputOptionSelfCloseField(), true) {
  }

}
