//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRiskSettleInvstPositionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRiskSettleInvstPositionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRiskSettleInvstPositionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRiskSettleInvstPositionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcRiskSettleInvstPositionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PosiDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PosiDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PosiDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionDate_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionDate_get(swigCPtr);
      return ret;
    } 
  }

  public int YdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_YdPosition_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_YdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int Position {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_Position_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_Position_get(swigCPtr);
      return ret;
    } 
  }

  public int LongFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_LongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_LongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int ShortFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double LongFrozenAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_LongFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_LongFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortFrozenAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ShortFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ShortFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int OpenVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCost {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UseMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_UseMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_UseMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenCost {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenCost_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_OpenCost_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public int CombPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombPosition_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombPosition_get(swigCPtr);
      return ret;
    } 
  }

  public int CombLongFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombLongFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombLongFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public int CombShortFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombShortFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CombShortFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public int TodayPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TodayPosition_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TodayPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int StrikeFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_StrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_StrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeFrozenAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_StrikeFrozenAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_StrikeFrozenAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int AbandonFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_AbandonFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_AbandonFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int YdStrikeFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_YdStrikeFrozen_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_YdStrikeFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionCostOffset {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionCostOffset_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_PositionCostOffset_get(swigCPtr);
      return ret;
    } 
  }

  public int TasPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TasPosition_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TasPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double TasPositionCost {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TasPositionCost_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRiskSettleInvstPositionField_TasPositionCost_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRiskSettleInvstPositionField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcRiskSettleInvstPositionField(), true) {
  }

}
