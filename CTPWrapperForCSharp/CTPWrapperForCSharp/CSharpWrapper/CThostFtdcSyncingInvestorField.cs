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
          ctpthosttradeapiPINVOKE.delete_CThostFtdcSyncingInvestorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorGroupID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorName {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string Mobile {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_get(swigCPtr);
      return ret;
    } 
  }

  public string CommModelID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_get(swigCPtr);
      return ret;
    } 
  }

  public string MarginModelID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_get(swigCPtr);
      return ret;
    } 
  }

  public char IsOrderFreq {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsOrderFreq_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsOrderFreq_get(swigCPtr);
      return ret;
    } 
  }

  public char IsOpenVolLimit {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsOpenVolLimit_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcSyncingInvestorField_IsOpenVolLimit_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInvestorField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcSyncingInvestorField(), true) {
  }

}
