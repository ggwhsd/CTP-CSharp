//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDeltaRCAMSInvstCombPosField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDeltaRCAMSInvstCombPosField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDeltaRCAMSInvstCombPosField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDeltaRCAMSInvstCombPosField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcSyncDeltaRCAMSInvstCombPosField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public string CombInstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public int TotalAmt {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_TotalAmt_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_TotalAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ActionDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_ActionDirection_get(swigCPtr);
      return ret;
    } 
  }

  public int SyncDeltaSequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_SyncDeltaSequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncDeltaRCAMSInvstCombPosField_SyncDeltaSequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDeltaRCAMSInvstCombPosField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcSyncDeltaRCAMSInvstCombPosField(), true) {
  }

}
