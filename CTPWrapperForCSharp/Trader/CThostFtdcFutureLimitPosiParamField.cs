//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcFutureLimitPosiParamField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcFutureLimitPosiParamField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcFutureLimitPosiParamField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcFutureLimitPosiParamField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcFutureLimitPosiParamField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public char InvestorRange {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductID {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_ProductID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_ProductID_get(swigCPtr);
      return ret;
    } 
  }

  public int SpecOpenVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_SpecOpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_SpecOpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int ArbiOpenVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_ArbiOpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_ArbiOpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcFutureLimitPosiParamField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcFutureLimitPosiParamField() : this(thosttradeapiPINVOKE.new_CThostFtdcFutureLimitPosiParamField(), true) {
  }

}