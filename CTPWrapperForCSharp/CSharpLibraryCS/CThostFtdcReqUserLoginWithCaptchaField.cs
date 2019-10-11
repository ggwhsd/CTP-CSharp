//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcReqUserLoginWithCaptchaField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqUserLoginWithCaptchaField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqUserLoginWithCaptchaField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqUserLoginWithCaptchaField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcReqUserLoginWithCaptchaField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIPAddress {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ClientIPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ClientIPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string LoginRemark {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_LoginRemark_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_LoginRemark_get(swigCPtr);
      return ret;
    } 
  }

  public string Captcha {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_Captcha_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_Captcha_get(swigCPtr);
      return ret;
    } 
  }

  public int ClientIPPort {
    set {
      thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ClientIPPort_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcReqUserLoginWithCaptchaField_ClientIPPort_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqUserLoginWithCaptchaField() : this(thosttradeapiPINVOKE.new_CThostFtdcReqUserLoginWithCaptchaField(), true) {
  }

}