//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRspAuthenticateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspAuthenticateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspAuthenticateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRspAuthenticateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcRspAuthenticateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string AppID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_AppID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_AppID_get(swigCPtr);
      return ret;
    } 
  }

  public char AppType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_AppType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcRspAuthenticateField_AppType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspAuthenticateField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcRspAuthenticateField(), true) {
  }

}
