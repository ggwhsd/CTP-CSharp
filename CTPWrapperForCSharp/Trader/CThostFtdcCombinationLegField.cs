//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcCombinationLegField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcCombinationLegField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcCombinationLegField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcCombinationLegField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcCombinationLegField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string CombInstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public int LegID {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegID_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegID_get(swigCPtr);
      return ret;
    } 
  }

  public string LegInstrumentID {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public int LegMultiple {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegMultiple_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_LegMultiple_get(swigCPtr);
      return ret;
    } 
  }

  public int ImplyLevel {
    set {
      thosttradeapiPINVOKE.CThostFtdcCombinationLegField_ImplyLevel_set(swigCPtr, value);
    } 
    get {
      int ret = thosttradeapiPINVOKE.CThostFtdcCombinationLegField_ImplyLevel_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcCombinationLegField() : this(thosttradeapiPINVOKE.new_CThostFtdcCombinationLegField(), true) {
  }

}