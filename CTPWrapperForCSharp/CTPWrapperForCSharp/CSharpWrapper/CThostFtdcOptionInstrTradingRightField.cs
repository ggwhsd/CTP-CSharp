//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOptionInstrTradingRightField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionInstrTradingRightField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionInstrTradingRightField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOptionInstrTradingRightField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcOptionInstrTradingRightField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingRight {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_TradingRight_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_TradingRight_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcOptionInstrTradingRightField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionInstrTradingRightField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcOptionInstrTradingRightField(), true) {
  }

}
