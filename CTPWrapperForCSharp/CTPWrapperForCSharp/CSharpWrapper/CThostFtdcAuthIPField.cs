//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcAuthIPField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcAuthIPField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcAuthIPField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcAuthIPField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcAuthIPField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AppID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_AppID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_AppID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcAuthIPField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcAuthIPField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcAuthIPField(), true) {
  }

}
