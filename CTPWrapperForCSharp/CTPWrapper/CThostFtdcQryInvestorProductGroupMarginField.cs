//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcQryInvestorProductGroupMarginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryInvestorProductGroupMarginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryInvestorProductGroupMarginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcQryInvestorProductGroupMarginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcQryInvestorProductGroupMarginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductGroupID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_ProductGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcQryInvestorProductGroupMarginField_ProductGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryInvestorProductGroupMarginField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcQryInvestorProductGroupMarginField(), true) {
  }

}
