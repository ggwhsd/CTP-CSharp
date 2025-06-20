//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncingTradingAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingTradingAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingTradingAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingTradingAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncingTradingAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMortgage {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreMortgage_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreMortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double PreCredit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreCredit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreCredit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDeposit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreDeposit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreDeposit_get(swigCPtr);
      return ret;
    } 
  }

  public double PreBalance {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreBalance_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreBalance_get(swigCPtr);
      return ret;
    } 
  }

  public double PreMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double InterestBase {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_InterestBase_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_InterestBase_get(swigCPtr);
      return ret;
    } 
  }

  public double Interest {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Interest_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Interest_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public double Withdraw {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Withdraw_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Withdraw_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCash {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCash_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCash_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenCommission {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CurrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CurrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CashIn {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CashIn_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CashIn_get(swigCPtr);
      return ret;
    } 
  }

  public double Commission {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Commission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Commission_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double Balance {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Balance_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Balance_get(swigCPtr);
      return ret;
    } 
  }

  public double Available {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Available_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Available_get(swigCPtr);
      return ret;
    } 
  }

  public double WithdrawQuota {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_WithdrawQuota_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_WithdrawQuota_get(swigCPtr);
      return ret;
    } 
  }

  public double Reserve {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Reserve_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Reserve_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public double Credit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Credit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Credit_get(swigCPtr);
      return ret;
    } 
  }

  public double Mortgage {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Mortgage_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_Mortgage_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_DeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_DeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeDeliveryMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeDeliveryMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ExchangeDeliveryMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ReserveBalance {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ReserveBalance_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_ReserveBalance_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageIn {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double PreFundMortgageOut {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_PreFundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageIn {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageIn_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageIn_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageOut {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageOut_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageOut_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageAvailable {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageAvailable_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FundMortgageAvailable_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageableFund {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_MortgageableFund_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_MortgageableFund_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCommission {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCommission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductFrozenCommission {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenCommission_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductFrozenCommission_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductCloseProfit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCloseProfit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductPositionProfitByAlg {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfitByAlg_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductPositionProfitByAlg_get(swigCPtr);
      return ret;
    } 
  }

  public double SpecProductExchangeMargin {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductExchangeMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_SpecProductExchangeMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenSwap {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenSwap_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_FrozenSwap_get(swigCPtr);
      return ret;
    } 
  }

  public double RemainSwap {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_RemainSwap_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingTradingAccountField_RemainSwap_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingTradingAccountField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncingTradingAccountField(), true) {
  }

}
