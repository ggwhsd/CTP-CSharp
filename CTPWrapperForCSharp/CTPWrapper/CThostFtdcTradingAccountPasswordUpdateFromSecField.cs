//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTradingAccountPasswordUpdateFromSecField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradingAccountPasswordUpdateFromSecField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradingAccountPasswordUpdateFromSecField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradingAccountPasswordUpdateFromSecField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcTradingAccountPasswordUpdateFromSecField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string OldPassword {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_OldPassword_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_OldPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string NewPassword {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_NewPassword_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_NewPassword_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public int FromSec {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_FromSec_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcTradingAccountPasswordUpdateFromSecField_FromSec_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradingAccountPasswordUpdateFromSecField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcTradingAccountPasswordUpdateFromSecField(), true) {
  }

}
