//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInstrumentMarginRateULField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentMarginRateULField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentMarginRateULField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInstrumentMarginRateULField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInstrumentMarginRateULField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string reserve1 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateULField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentMarginRateULField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInstrumentMarginRateULField(), true) {
  }

}
