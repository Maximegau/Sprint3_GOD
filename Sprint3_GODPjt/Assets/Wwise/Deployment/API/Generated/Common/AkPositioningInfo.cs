#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkPositioningInfo : IDisposable {
  private IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPositioningInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static IntPtr getCPtr(AkPositioningInfo obj) {
    return (obj == null) ? IntPtr.Zero : obj.swigCPtr;
  }

  ~AkPositioningInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkPositioningInfo(swigCPtr);
        }
        swigCPtr = IntPtr.Zero;
      }
      GC.SuppressFinalize(this);
    }
  }

  public float fCenterPct {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_get(swigCPtr);

      return ret;
    } 
  }

  public AkPannerType pannerType {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_set(swigCPtr, (int)value);

    } 
    get {
      AkPannerType ret = (AkPannerType)AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_get(swigCPtr);

      return ret;
    } 
  }

  public AkPositionSourceType posSourceType {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_posSourceType_set(swigCPtr, (int)value);

    } 
    get {
      AkPositionSourceType ret = (AkPositionSourceType)AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_posSourceType_get(swigCPtr);

      return ret;
    } 
  }

  public bool bUpdateEachFrame {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUpdateEachFrame_set(swigCPtr, value);

    } 
    get {
      bool ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUpdateEachFrame_get(swigCPtr);

      return ret;
    } 
  }

  public bool bUseSpatialization {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseSpatialization_set(swigCPtr, value);

    } 
    get {
      bool ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseSpatialization_get(swigCPtr);

      return ret;
    } 
  }

  public bool bUseAttenuation {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseAttenuation_set(swigCPtr, value);

    } 
    get {
      bool ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseAttenuation_get(swigCPtr);

      return ret;
    } 
  }

  public bool bUseConeAttenuation {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_set(swigCPtr, value);

    } 
    get {
      bool ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_get(swigCPtr);

      return ret;
    } 
  }

  public float fInnerAngle {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_get(swigCPtr);

      return ret;
    } 
  }

  public float fOuterAngle {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_get(swigCPtr);

      return ret;
    } 
  }

  public float fConeMaxAttenuation {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_get(swigCPtr);

      return ret;
    } 
  }

  public float LPFCone {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_get(swigCPtr);

      return ret;
    } 
  }

  public float HPFCone {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_get(swigCPtr);

      return ret;
    } 
  }

  public float fMaxDistance {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_get(swigCPtr);

      return ret;
    } 
  }

  public float fVolDryAtMaxDist {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(swigCPtr);

      return ret;
    } 
  }

  public float fVolAuxGameDefAtMaxDist {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(swigCPtr);

      return ret;
    } 
  }

  public float fVolAuxUserDefAtMaxDist {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(swigCPtr);

      return ret;
    } 
  }

  public float LPFValueAtMaxDist {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(swigCPtr);

      return ret;
    } 
  }

  public float HPFValueAtMaxDist {
    set {
      AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(swigCPtr, value);

    } 
    get {
      float ret = AkSoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(swigCPtr);

      return ret;
    } 
  }

  public AkPositioningInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkPositioningInfo(), true) {

  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.