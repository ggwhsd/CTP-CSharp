//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDeltaRULEIntraParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDeltaRULEIntraParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDeltaRULEIntraParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDeltaRULEIntraParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncDeltaRULEIntraParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string StdInstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_StdInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_StdInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public double StdInstrMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_StdInstrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_StdInstrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UsualIntraRate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_UsualIntraRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_UsualIntraRate_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryIntraRate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_DeliveryIntraRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_DeliveryIntraRate_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionDirection {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ActionDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_ActionDirection_get(swigCPtr);
      return ret;
    } 
  }

  public int SyncDeltaSequenceNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_SyncDeltaSequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaRULEIntraParameterField_SyncDeltaSequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDeltaRULEIntraParameterField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncDeltaRULEIntraParameterField(), true) {
  }

}
