//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorProdRULEMarginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorProdRULEMarginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorProdRULEMarginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorProdRULEMarginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ctpthosttradeapiPINVOKE.delete_CThostFtdcInvestorProdRULEMarginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProdFamilyCode {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ProdFamilyCode_set(swigCPtr, value);
    } 
    get {
      string ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ProdFamilyCode_get(swigCPtr);
      return ret;
    } 
  }

  public char InstrumentClass {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InstrumentClass_set(swigCPtr, value);
    } 
    get {
      char ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InstrumentClass_get(swigCPtr);
      return ret;
    } 
  }

  public int CommodityGroupID {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_CommodityGroupID_set(swigCPtr, value);
    } 
    get {
      int ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_CommodityGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public double BStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double SStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double BStdOpenFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdOpenFrozen_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdOpenFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double SStdOpenFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdOpenFrozen_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdOpenFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double BStdCloseFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdCloseFrozen_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_BStdCloseFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double SStdCloseFrozen {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdCloseFrozen_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SStdCloseFrozen_get(swigCPtr);
      return ret;
    } 
  }

  public double IntraProdStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_IntraProdStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_IntraProdStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double NetStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_NetStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_NetStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double InterProdStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InterProdStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InterProdStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double SingleStdPosition {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SingleStdPosition_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SingleStdPosition_get(swigCPtr);
      return ret;
    } 
  }

  public double IntraProdMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_IntraProdMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_IntraProdMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double InterProdMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InterProdMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_InterProdMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SingleMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SingleMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_SingleMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double NonCombMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_NonCombMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_NonCombMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AddOnMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_AddOnMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_AddOnMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double AddOnFrozenMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_AddOnFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_AddOnFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenFrozenMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_OpenFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_OpenFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseFrozenMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_CloseFrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_CloseFrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double FrozenMargin {
    set {
      ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_FrozenMargin_set(swigCPtr, value);
    } 
    get {
      double ret = ctpthosttradeapiPINVOKE.CThostFtdcInvestorProdRULEMarginField_FrozenMargin_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorProdRULEMarginField() : this(ctpthosttradeapiPINVOKE.new_CThostFtdcInvestorProdRULEMarginField(), true) {
  }

}
