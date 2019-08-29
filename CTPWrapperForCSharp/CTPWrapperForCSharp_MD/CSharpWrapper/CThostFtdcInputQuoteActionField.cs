//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputQuoteActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputQuoteActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputQuoteActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputQuoteActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcInputQuoteActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int QuoteActionRef {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcInputQuoteActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputQuoteActionField() : this(thostmdapiPINVOKE.new_CThostFtdcInputQuoteActionField(), true) {
  }

}