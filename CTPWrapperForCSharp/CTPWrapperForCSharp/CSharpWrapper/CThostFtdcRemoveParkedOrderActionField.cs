//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcRemoveParkedOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRemoveParkedOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRemoveParkedOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcRemoveParkedOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcRemoveParkedOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParkedOrderActionID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_ParkedOrderActionID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_ParkedOrderActionID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcRemoveParkedOrderActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRemoveParkedOrderActionField() : this(thosttradeapiPINVOKE.new_CThostFtdcRemoveParkedOrderActionField(), true) {
  }

}