//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSettlementInfoConfirmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSettlementInfoConfirmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSettlementInfoConfirmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSettlementInfoConfirmField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcSettlementInfoConfirmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ConfirmDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_ConfirmDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_ConfirmDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ConfirmTime {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_ConfirmTime_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_ConfirmTime_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcSettlementInfoConfirmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSettlementInfoConfirmField() : this(thosttradeapiPINVOKE.new_CThostFtdcSettlementInfoConfirmField(), true) {
  }

}