//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcInvestorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorGroupID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorName {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_InvestorName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string Mobile {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_Mobile_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_Mobile_get(swigCPtr);
      return ret;
    } 
  }

  public string CommModelID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_CommModelID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_CommModelID_get(swigCPtr);
      return ret;
    } 
  }

  public string MarginModelID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorField_MarginModelID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorField_MarginModelID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorField() : this(thosttradeapiPINVOKE.new_CThostFtdcInvestorField(), true) {
  }

}