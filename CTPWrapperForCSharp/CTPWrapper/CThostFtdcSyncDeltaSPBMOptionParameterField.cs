//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDeltaSPBMOptionParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDeltaSPBMOptionParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDeltaSPBMOptionParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDeltaSPBMOptionParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncDeltaSPBMOptionParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public int Cvf {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_Cvf_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_Cvf_get(swigCPtr);
      return ret;
    } 
  }

  public double DownPrice {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_DownPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_DownPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double Delta {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_Delta_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_Delta_get(swigCPtr);
      return ret;
    } 
  }

  public double SlimiDelta {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_SlimiDelta_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_SlimiDelta_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionDirection {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ActionDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_ActionDirection_get(swigCPtr);
      return ret;
    } 
  }

  public int SyncDeltaSequenceNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_SyncDeltaSequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaSPBMOptionParameterField_SyncDeltaSequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDeltaSPBMOptionParameterField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncDeltaSPBMOptionParameterField(), true) {
  }

}
