//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteLocalID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char QuoteStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderSysID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderSysID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerQuoteSeq {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve3 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve3_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_reserve3_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ReplaceSysID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ReplaceSysID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_ReplaceSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderMemo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_OrderMemo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_OrderMemo_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionReqSeq {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SessionReqSeq_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcQuoteField_SessionReqSeq_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQuoteField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcQuoteField(), true) {
  }

}
