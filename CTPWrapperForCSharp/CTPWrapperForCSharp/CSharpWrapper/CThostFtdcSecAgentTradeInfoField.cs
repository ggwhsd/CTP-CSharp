//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSecAgentTradeInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSecAgentTradeInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSecAgentTradeInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSecAgentTradeInfoField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcSecAgentTradeInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerSecAgentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_BrokerSecAgentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_BrokerSecAgentID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSecAgentTradeInfoField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSecAgentTradeInfoField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcSecAgentTradeInfoField(), true) {
  }

}
