/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace XTools {

public class ProfileThread : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProfileThread(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ProfileThread obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProfileThread() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          XToolsProfilerPINVOKE.delete_ProfileThread(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ProfileThread(ulong threadID, uint reserveSamples) : this(XToolsProfilerPINVOKE.new_ProfileThread(threadID, reserveSamples), true) {
  }

  public ulong GetThreadID() {
    ulong ret = XToolsProfilerPINVOKE.ProfileThread_GetThreadID(swigCPtr);
    return ret;
  }

  public int GetSampleCount() {
    int ret = XToolsProfilerPINVOKE.ProfileThread_GetSampleCount(swigCPtr);
    return ret;
  }

  public ProfileSample GetSample(int sampleIndex) {
    global::System.IntPtr cPtr = XToolsProfilerPINVOKE.ProfileThread_GetSample(swigCPtr, sampleIndex);
    ProfileSample ret = (cPtr == global::System.IntPtr.Zero) ? null : new ProfileSample(cPtr, true);
    return ret; 
  }

  public void AddSample(ProfileSample newSample) {
    XToolsProfilerPINVOKE.ProfileThread_AddSample(swigCPtr, ProfileSample.getCPtr(newSample));
  }

}

}