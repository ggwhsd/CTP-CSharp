//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcBrokerField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerAbbr {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerAbbr_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerAbbr_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerName {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_BrokerName_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcBrokerField(), true) {
  }

}
