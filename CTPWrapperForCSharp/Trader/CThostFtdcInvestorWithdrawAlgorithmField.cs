//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcInvestorWithdrawAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorWithdrawAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorWithdrawAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInvestorWithdrawAlgorithmField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          thosttradeapiPINVOKE.delete_CThostFtdcInvestorWithdrawAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double UsingRatio {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageRatio {
    set {
      thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_set(swigCPtr, value);
    } 
    get {
      double ret = thosttradeapiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorWithdrawAlgorithmField() : this(thosttradeapiPINVOKE.new_CThostFtdcInvestorWithdrawAlgorithmField(), true) {
  }

}