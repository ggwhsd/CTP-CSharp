//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcLinkManField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLinkManField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLinkManField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcLinkManField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcLinkManField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PersonType {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonType_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonName {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonName_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public int Priority {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_Priority_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_Priority_get(swigCPtr);
      return ret;
    } 
  }

  public string UOAZipCode {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_UOAZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_UOAZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonFullName {
    set {
      thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonFullName_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcLinkManField_PersonFullName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLinkManField() : this(thosttradeapiPINVOKE.new_CThostFtdcLinkManField(), true) {
  }

}