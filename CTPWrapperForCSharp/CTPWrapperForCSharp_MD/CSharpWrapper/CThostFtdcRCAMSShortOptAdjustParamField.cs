//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRCAMSShortOptAdjustParamField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRCAMSShortOptAdjustParamField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRCAMSShortOptAdjustParamField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRCAMSShortOptAdjustParamField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcRCAMSShortOptAdjustParamField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombProductID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_CombProductID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_CombProductID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double AdjustValue {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_AdjustValue_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcRCAMSShortOptAdjustParamField_AdjustValue_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRCAMSShortOptAdjustParamField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcRCAMSShortOptAdjustParamField(), true) {
  }

}
