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
          thosttradeapiPINVOKE.delete_CThostFtdcQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteLocalID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public char QuoteStatus {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_QuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerQuoteSeq {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BrokerQuoteSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AskOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderRef {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BidOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQuoteField() : this(thosttradeapiPINVOKE.new_CThostFtdcQuoteField(), true) {
  }

}