//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcMarketDataBid45Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataBid45Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataBid45Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataBid45Field() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcMarketDataBid45Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double BidPrice4 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidPrice4_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidPrice4_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume4 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidVolume4_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidVolume4_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice5 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidPrice5_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidPrice5_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume5 {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidVolume5_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcMarketDataBid45Field_BidVolume5_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataBid45Field() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcMarketDataBid45Field(), true) {
  }

}
