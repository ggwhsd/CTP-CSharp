//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQrySPBMFutureParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQrySPBMFutureParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQrySPBMFutureParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQrySPBMFutureParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcQrySPBMFutureParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProdFamilyCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQrySPBMFutureParameterField_ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQrySPBMFutureParameterField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcQrySPBMFutureParameterField(), true) {
  }

}
