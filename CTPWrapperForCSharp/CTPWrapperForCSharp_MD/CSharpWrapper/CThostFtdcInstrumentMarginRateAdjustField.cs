//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInstrumentMarginRateAdjustField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentMarginRateAdjustField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentMarginRateAdjustField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInstrumentMarginRateAdjustField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcInstrumentMarginRateAdjustField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string reserve1 {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentMarginRateAdjustField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcInstrumentMarginRateAdjustField(), true) {
  }

}
