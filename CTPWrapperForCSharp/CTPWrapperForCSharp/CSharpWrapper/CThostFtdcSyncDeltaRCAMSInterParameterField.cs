//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDeltaRCAMSInterParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDeltaRCAMSInterParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDeltaRCAMSInterParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDeltaRCAMSInterParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcSyncDeltaRCAMSInterParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductGroupID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ProductGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ProductGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public int Priority {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_Priority_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_Priority_get(swigCPtr);
      return ret;
    } 
  }

  public double CreditRate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CreditRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CreditRate_get(swigCPtr);
      return ret;
    } 
  }

  public string CombProduct1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CombProduct1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CombProduct1_get(swigCPtr);
      return ret;
    } 
  }

  public string CombProduct2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CombProduct2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_CombProduct2_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ActionDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_ActionDirection_get(swigCPtr);
      return ret;
    } 
  }

  public int SyncDeltaSequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_SyncDeltaSequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInterParameterField_SyncDeltaSequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDeltaRCAMSInterParameterField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcSyncDeltaRCAMSInterParameterField(), true) {
  }

}
