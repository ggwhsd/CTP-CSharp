//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReserveOpenAccountField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReserveOpenAccountField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReserveOpenAccountField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReserveOpenAccountField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcReserveOpenAccountField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradeCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char Gender {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Gender_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Gender_get(swigCPtr);
      return ret;
    } 
  }

  public string CountryCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CountryCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CountryCode_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string MobilePhone {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_MobilePhone_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_MobilePhone_get(swigCPtr);
      return ret;
    } 
  }

  public string Fax {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Fax_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Fax_get(swigCPtr);
      return ret;
    } 
  }

  public string EMail {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_EMail_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_EMail_get(swigCPtr);
      return ret;
    } 
  }

  public char MoneyAccountStatus {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_MoneyAccountStatus_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_MoneyAccountStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char ReserveOpenAccStas {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ReserveOpenAccStas_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ReserveOpenAccStas_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcReserveOpenAccountField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReserveOpenAccountField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcReserveOpenAccountField(), true) {
  }

}
