//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInputCombActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputCombActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputCombActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputCombActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInputCombActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string CombActionRef {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_CombActionRef_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_CombActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public char CombDirection {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_CombDirection_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_CombDirection_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInputCombActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputCombActionField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInputCombActionField(), true) {
  }

}
