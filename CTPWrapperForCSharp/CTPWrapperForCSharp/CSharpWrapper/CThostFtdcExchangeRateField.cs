//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcExchangeRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcExchangeRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string FromCurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_FromCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_FromCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FromCurrencyUnit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_FromCurrencyUnit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_FromCurrencyUnit_get(swigCPtr);
      return ret;
    } 
  }

  public string ToCurrencyID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_ToCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_ToCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchangeRate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_ExchangeRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcExchangeRateField_ExchangeRate_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeRateField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcExchangeRateField(), true) {
  }

}
