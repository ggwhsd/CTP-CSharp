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
          thostmdapiPINVOKE.delete_CThostFtdcSyncingInvestorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorGroupID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorName {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_InvestorName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string Mobile {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_Mobile_get(swigCPtr);
      return ret;
    } 
  }

  public string CommModelID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_CommModelID_get(swigCPtr);
      return ret;
    } 
  }

  public string MarginModelID {
    set {
      thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcSyncingInvestorField_MarginModelID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncingInvestorField() : this(thostmdapiPINVOKE.new_CThostFtdcSyncingInvestorField(), true) {
  }

}