//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRULEIntraParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRULEIntraParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRULEIntraParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRULEIntraParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcRULEIntraParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProdFamilyCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string StdInstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_StdInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_StdInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public double StdInstrMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_StdInstrMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_StdInstrMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double UsualIntraRate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_UsualIntraRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_UsualIntraRate_get(swigCPtr);
      return ret;
    } 
  }

  public double DeliveryIntraRate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_DeliveryIntraRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcRULEIntraParameterField_DeliveryIntraRate_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRULEIntraParameterField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcRULEIntraParameterField(), true) {
  }

}
