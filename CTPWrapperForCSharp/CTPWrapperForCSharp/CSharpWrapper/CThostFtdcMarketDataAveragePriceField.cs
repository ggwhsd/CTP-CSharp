//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataAveragePriceField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataAveragePriceField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataAveragePriceField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataAveragePriceField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcMarketDataAveragePriceField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double AveragePrice {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataAveragePriceField_AveragePrice_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataAveragePriceField_AveragePrice_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataAveragePriceField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcMarketDataAveragePriceField(), true) {
  }

}
