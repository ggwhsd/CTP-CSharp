//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDeltaInvstPosCombDtlField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDeltaInvstPosCombDtlField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDeltaInvstPosCombDtlField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDeltaInvstPosCombDtlField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncDeltaInvstPosCombDtlField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ComTradeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ComTradeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ComTradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int TotalAmt {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TotalAmt_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TotalAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegMultiple {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_LegMultiple_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_LegMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public int TradeGroupID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradeGroupID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_TradeGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionDirection {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ActionDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_ActionDirection_get(swigCPtr);
      return ret;
    } 
  }

  public int SyncDeltaSequenceNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_SyncDeltaSequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDeltaInvstPosCombDtlField_SyncDeltaSequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDeltaInvstPosCombDtlField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncDeltaInvstPosCombDtlField(), true) {
  }

}
