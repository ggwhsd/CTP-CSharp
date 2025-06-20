//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcSyncDelaySwapField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDelaySwapField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDelaySwapField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcSyncDelaySwapField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcSyncDelaySwapField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string DelaySwapSeqNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_DelaySwapSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_DelaySwapSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string FromCurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FromAmount {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double FromFrozenSwap {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromFrozenSwap_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromFrozenSwap_get(swigCPtr);
      return ret;
    } 
  }

  public double FromRemainSwap {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromRemainSwap_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_FromRemainSwap_get(swigCPtr);
      return ret;
    } 
  }

  public string ToCurrencyID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_ToCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_ToCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double ToAmount {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_ToAmount_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_ToAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int IsManualSwap {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_IsManualSwap_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_IsManualSwap_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAllRemainSetZero {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_IsAllRemainSetZero_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcSyncDelaySwapField_IsAllRemainSetZero_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDelaySwapField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcSyncDelaySwapField(), true) {
  }

}
