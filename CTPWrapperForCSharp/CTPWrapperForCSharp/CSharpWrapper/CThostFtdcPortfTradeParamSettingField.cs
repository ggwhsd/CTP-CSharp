//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcPortfTradeParamSettingField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcPortfTradeParamSettingField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcPortfTradeParamSettingField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcPortfTradeParamSettingField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcPortfTradeParamSettingField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char Portfolio {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_Portfolio_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_Portfolio_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActionVerify {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_IsActionVerify_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_IsActionVerify_get(swigCPtr);
      return ret;
    } 
  }

  public int IsCloseVerify {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_IsCloseVerify_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcPortfTradeParamSettingField_IsCloseVerify_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcPortfTradeParamSettingField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcPortfTradeParamSettingField(), true) {
  }

}
