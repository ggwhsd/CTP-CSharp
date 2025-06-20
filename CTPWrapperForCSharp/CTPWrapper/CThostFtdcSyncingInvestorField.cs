//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncingInvestorField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncingInvestorField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncingInvestorField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncingInvestorField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncingInvestorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorGroupID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorName {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string Mobile {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_get(swigCPtr);
      return ret;
    } 
  }

  public string CommModelID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_get(swigCPtr);
      return ret;
    } 
  }

  public string MarginModelID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_get(swigCPtr);
      return ret;
    } 
  }

  public char IsOrderFreq {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsOrderFreq_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsOrderFreq_get(swigCPtr);
      return ret;
    } 
  }

  public char IsOpenVolLimit {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsOpenVolLimit_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsOpenVolLimit_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInvestorField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncingInvestorField(), true) {
  }

}
