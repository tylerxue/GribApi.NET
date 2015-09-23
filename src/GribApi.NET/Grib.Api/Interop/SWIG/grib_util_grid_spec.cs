/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Grib.Api.Interop.SWIG {

public class grib_util_grid_spec : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal grib_util_grid_spec(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(grib_util_grid_spec obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~grib_util_grid_spec() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          GribApiProxyPINVOKE.delete_grib_util_grid_spec(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int grid_type {
	set
	{
		GribApiProxyPINVOKE.grib_util_grid_spec_grid_type_set(swigCPtr, value);
	} 
	get
	{
		return GribApiProxyPINVOKE.grib_util_grid_spec_grid_type_get(swigCPtr);
	} 
  }

  public int Ni {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_Ni_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_Ni_get(swigCPtr);
      return ret;
    } 
  }

  public int Nj {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_Nj_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_Nj_get(swigCPtr);
      return ret;
    } 
  }

  public double iDirectionIncrementInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_iDirectionIncrementInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_iDirectionIncrementInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double jDirectionIncrementInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_jDirectionIncrementInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_jDirectionIncrementInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double longitudeOfFirstGridPointInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfFirstGridPointInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfFirstGridPointInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double longitudeOfLastGridPointInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfLastGridPointInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfLastGridPointInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double latitudeOfFirstGridPointInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfFirstGridPointInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfFirstGridPointInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double latitudeOfLastGridPointInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfLastGridPointInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfLastGridPointInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public int uvRelativeToGrid {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_uvRelativeToGrid_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_uvRelativeToGrid_get(swigCPtr);
      return ret;
    } 
  }

  public double latitudeOfSouthernPoleInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfSouthernPoleInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_latitudeOfSouthernPoleInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public double longitudeOfSouthernPoleInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfSouthernPoleInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_longitudeOfSouthernPoleInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public int iScansNegatively {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_iScansNegatively_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_iScansNegatively_get(swigCPtr);
      return ret;
    } 
  }

  public int jScansPositively {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_jScansPositively_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_jScansPositively_get(swigCPtr);
      return ret;
    } 
  }

  public int N {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_N_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_N_get(swigCPtr);
      return ret;
    } 
  }

  public int bitmapPresent {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_bitmapPresent_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_bitmapPresent_get(swigCPtr);
      return ret;
    } 
  }

  public double missingValue {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_missingValue_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_missingValue_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_long pl {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_pl_set(swigCPtr, SWIGTYPE_p_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = GribApiProxyPINVOKE.grib_util_grid_spec_pl_get(swigCPtr);
      SWIGTYPE_p_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_long(cPtr, false);
      return ret;
    } 
  }

  public int pl_size {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_pl_size_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_pl_size_get(swigCPtr);
      return ret;
    } 
  }

  public int truncation {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_truncation_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_truncation_get(swigCPtr);
      return ret;
    } 
  }

  public double orientationOfTheGridInDegrees {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_orientationOfTheGridInDegrees_set(swigCPtr, value);
    } 
    get {
      double ret = GribApiProxyPINVOKE.grib_util_grid_spec_orientationOfTheGridInDegrees_get(swigCPtr);
      return ret;
    } 
  }

  public int DyInMetres {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_DyInMetres_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_DyInMetres_get(swigCPtr);
      return ret;
    } 
  }

  public int DxInMetres {
    set {
      GribApiProxyPINVOKE.grib_util_grid_spec_DxInMetres_set(swigCPtr, value);
    } 
    get {
      int ret = GribApiProxyPINVOKE.grib_util_grid_spec_DxInMetres_get(swigCPtr);
      return ret;
    } 
  }

  public grib_util_grid_spec() : this(GribApiProxyPINVOKE.new_grib_util_grid_spec(), true) {
  }

}

}