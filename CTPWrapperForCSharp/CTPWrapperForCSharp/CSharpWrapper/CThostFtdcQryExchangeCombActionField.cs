//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryExchangeCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryExchangeCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryExchangeCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryExchangeCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcQryExchangeCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ParticipantID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQryExchangeCombActionField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryExchangeCombActionField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcQryExchangeCombActionField(), true) {
  }

}
