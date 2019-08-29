//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcOptionInstrCommRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionInstrCommRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionInstrCommRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOptionInstrCommRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thostmdapiPINVOKE.delete_CThostFtdcOptionInstrCommRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InstrumentID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_OpenRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseTodayRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_CloseTodayRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeRatioByMoney {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double StrikeRatioByVolume {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_StrikeRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = thostmdapiPINVOKE.CThostFtdcOptionInstrCommRateField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionInstrCommRateField() : this(thostmdapiPINVOKE.new_CThostFtdcOptionInstrCommRateField(), true) {
  }

}