//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryBulletinField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryBulletinField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryBulletinField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryBulletinField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcQryBulletinField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int BulletinID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_BulletinID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_BulletinID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string NewsType {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_NewsType_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_NewsType_get(swigCPtr);
      return ret;
    } 
  }

  public char NewsUrgency {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_NewsUrgency_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcQryBulletinField_NewsUrgency_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryBulletinField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcQryBulletinField(), true) {
  }

}
