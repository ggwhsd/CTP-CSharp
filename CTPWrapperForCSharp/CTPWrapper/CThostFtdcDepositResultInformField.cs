//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcDepositResultInformField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcDepositResultInformField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcDepositResultInformField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcDepositResultInformField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcDepositResultInformField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string DepositSeqNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_DepositSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_DepositSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string ReturnCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_ReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_ReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public string DescrInfoForReturnCode {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_DescrInfoForReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcDepositResultInformField_DescrInfoForReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcDepositResultInformField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcDepositResultInformField(), true) {
  }

}
