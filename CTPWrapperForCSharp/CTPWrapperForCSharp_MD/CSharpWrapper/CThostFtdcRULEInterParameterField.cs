//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRULEInterParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRULEInterParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRULEInterParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRULEInterParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcRULEInterParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public int SpreadId {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_SpreadId_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_SpreadId_get(swigCPtr);
      return ret;
    } 
  }

  public double InterRate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_InterRate_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_InterRate_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg1ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg1ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg1ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg2ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg2ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg2ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public int Leg1PropFactor {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg1PropFactor_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg1PropFactor_get(swigCPtr);
      return ret;
    } 
  }

  public int Leg2PropFactor {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg2PropFactor_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_Leg2PropFactor_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityGroupID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_CommodityGroupID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_CommodityGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityGroupName {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_CommodityGroupName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcRULEInterParameterField_CommodityGroupName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRULEInterParameterField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcRULEInterParameterField(), true) {
  }

}
