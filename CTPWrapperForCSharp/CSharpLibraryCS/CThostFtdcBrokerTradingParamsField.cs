//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcBrokerTradingParamsField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerTradingParamsField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerTradingParamsField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcBrokerTradingParamsField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcBrokerTradingParamsField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char MarginPriceType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_MarginPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_MarginPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Algorithm {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_Algorithm_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_Algorithm_get(swigCPtr);
      return ret;
    } 
  }

  public char AvailIncludeCloseProfit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_AvailIncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_AvailIncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public char OptionRoyaltyPriceType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_OptionRoyaltyPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_OptionRoyaltyPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcBrokerTradingParamsField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerTradingParamsField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcBrokerTradingParamsField(), true) {
  }

}
