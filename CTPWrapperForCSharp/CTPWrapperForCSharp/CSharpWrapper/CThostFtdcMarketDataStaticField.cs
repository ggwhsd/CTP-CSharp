//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataStaticField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataStaticField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataStaticField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataStaticField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcMarketDataStaticField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double OpenPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double HighestPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_HighestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_HighestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowestPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_LowestPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_LowestPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double ClosePrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_ClosePrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_ClosePrice_get(swigCPtr);
      return ret;
    } 
  }

  public double UpperLimitPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_UpperLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_UpperLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double LowerLimitPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_LowerLimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_LowerLimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double CurrDelta {
    set {
      thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_CurrDelta_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcMarketDataStaticField_CurrDelta_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataStaticField() : this(thosttradeapiPINVOKE.new_CThostFtdcMarketDataStaticField(), true) {
  }

}