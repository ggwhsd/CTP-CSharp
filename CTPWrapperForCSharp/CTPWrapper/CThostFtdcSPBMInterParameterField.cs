//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSPBMInterParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSPBMInterParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSPBMInterParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSPBMInterParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSPBMInterParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SpreadId {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_SpreadId_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_SpreadId_get(swigCPtr);
      return ret;
    } 
  }

  public double InterRateZ {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_InterRateZ_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_InterRateZ_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg1ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_Leg1ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_Leg1ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg2ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_Leg2ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSPBMInterParameterField_Leg2ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSPBMInterParameterField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSPBMInterParameterField(), true) {
  }

}
