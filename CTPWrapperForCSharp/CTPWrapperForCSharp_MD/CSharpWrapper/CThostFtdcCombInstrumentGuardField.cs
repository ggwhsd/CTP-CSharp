//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCombInstrumentGuardField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCombInstrumentGuardField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCombInstrumentGuardField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCombInstrumentGuardField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcCombInstrumentGuardField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public double GuarantRatio {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_GuarantRatio_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_GuarantRatio_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcCombInstrumentGuardField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCombInstrumentGuardField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcCombInstrumentGuardField(), true) {
  }

}
