//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMortgageParamField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMortgageParamField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMortgageParamField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMortgageParamField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcMortgageParamField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public double MortgageBalance {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_MortgageBalance_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_MortgageBalance_get(swigCPtr);
      return ret;
    } 
  }

  public int CheckMortgageRatio {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_CheckMortgageRatio_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcMortgageParamField_CheckMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMortgageParamField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcMortgageParamField(), true) {
  }

}
