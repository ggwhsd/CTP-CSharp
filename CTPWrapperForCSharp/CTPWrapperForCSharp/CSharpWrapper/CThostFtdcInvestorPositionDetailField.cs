//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorPositionDetailField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorPositionDetailField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorPositionDetailField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorPositionDetailField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInvestorPositionDetailField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public char TradeType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeType_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByTrade {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double LastSettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_LastSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_LastSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int TimeFirstVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TimeFirstVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_TimeFirstVolume_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public char SpecPosiType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SpecPosiType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_SpecPosiType_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombInstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorPositionDetailField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorPositionDetailField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInvestorPositionDetailField(), true) {
  }

}
