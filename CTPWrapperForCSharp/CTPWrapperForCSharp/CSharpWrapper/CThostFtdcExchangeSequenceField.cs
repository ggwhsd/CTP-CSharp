//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeSequenceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeSequenceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeSequenceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeSequenceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcExchangeSequenceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public char MarketStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_MarketStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeSequenceField_MarketStatus_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeSequenceField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcExchangeSequenceField(), true) {
  }

}
