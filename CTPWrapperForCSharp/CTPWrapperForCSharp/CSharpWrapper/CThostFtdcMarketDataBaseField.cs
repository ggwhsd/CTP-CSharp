//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataBaseField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataBaseField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataBaseField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataBaseField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcMarketDataBaseField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public double PreSettlementPrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreClosePrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double PreOpenInterest {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreOpenInterest_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreOpenInterest_get(swigCPtr);
      return ret;
    } 
  }

  public double PreDelta {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreDelta_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBaseField_PreDelta_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataBaseField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcMarketDataBaseField(), true) {
  }

}
