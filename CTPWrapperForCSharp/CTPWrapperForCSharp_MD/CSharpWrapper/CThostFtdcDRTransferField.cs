//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcDRTransferField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcDRTransferField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcDRTransferField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcDRTransferField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcDRTransferField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int OrigDRIdentityID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_OrigDRIdentityID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_OrigDRIdentityID_get(swigCPtr);
      return ret;
    } 
  }

  public int DestDRIdentityID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_DestDRIdentityID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_DestDRIdentityID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrigBrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_OrigBrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_OrigBrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string DestBrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_DestBrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDRTransferField_DestBrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcDRTransferField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcDRTransferField(), true) {
  }

}
