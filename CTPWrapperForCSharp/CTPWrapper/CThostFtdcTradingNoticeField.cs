//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTradingNoticeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradingNoticeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradingNoticeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradingNoticeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthostmdapiPINVOKE.delete_CThostFtdcTradingNoticeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public short SequenceSeries {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SequenceSeries_set(swigCPtr, value);
    } 
    get {
      short ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SequenceSeries_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string SendTime {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SendTime_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SendTime_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public string FieldContent {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_FieldContent_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_FieldContent_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthostmdapiPINVOKE.CThostFtdcTradingNoticeField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradingNoticeField() : this(ctpthostmdapiPINVOKE.new_CThostFtdcTradingNoticeField(), true) {
  }

}
