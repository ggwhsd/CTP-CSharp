//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryRULEInterParameterField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryRULEInterParameterField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryRULEInterParameterField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryRULEInterParameterField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcQryRULEInterParameterField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg1ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_Leg1ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_Leg1ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public string Leg2ProdFamilyCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_Leg2ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_Leg2ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityGroupID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_CommodityGroupID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcQryRULEInterParameterField_CommodityGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryRULEInterParameterField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcQryRULEInterParameterField(), true) {
  }

}
