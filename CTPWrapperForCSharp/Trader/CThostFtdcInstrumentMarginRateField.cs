//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInstrumentMarginRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentMarginRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentMarginRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInstrumentMarginRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcInstrumentMarginRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInstrumentMarginRateField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentMarginRateField() : this(thosttradeapiPINVOKE.new_CThostFtdcInstrumentMarginRateField(), true) {
  }

}