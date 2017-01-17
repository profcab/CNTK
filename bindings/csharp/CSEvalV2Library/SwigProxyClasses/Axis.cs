//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CNTK {

public class Axis : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Axis(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Axis obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Axis() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CNTKLibPINVOKE.delete_Axis(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


    public string Name
    {
        get 
        {
            return GetName();
        }
    }

    public bool IsStatic
    {
        get 
        {
            return IsStaticAxis();
        }
    }

    public bool IsDynamic
    {
        get 
        {
            return IsDynamicAxis();
        }
    }

    public bool IsOrdered
    {
        get 
        {
            return IsOrderedAxis();
        }
    }

    public override bool Equals(System.Object obj)
    {
        // If parameter is null return false.
        if (obj == null)
        {
            return false;
        }

        // If parameter cannot be cast to Point return false.
        Axis p = obj as Axis;
        if ((System.Object)p == null)
        {
            return false;
        }

        // Return true if the fields match:
        return CNTKLib.AreEqualAxis(this, p);
    }

    public bool Equals(Axis p)
    {
        // If parameter is null return false:
        if ((object)p == null)
        {
            return false;
        }

        // Return true if the fields match:
        return CNTKLib.AreEqualAxis(this, p);
    }

    public static bool operator ==(Axis first, Axis second)
    {
        // If both are null, or both are same instance, return true.
        if (System.Object.ReferenceEquals(first, second))
        {
            return true;
        }

        // If one is null, but not both, return false.
        if (((object)first == null) || ((object)second == null))
        {
            return false;
        }

        // Return true if the fields match:
        return CNTKLib.AreEqualAxis(first, second);
    }

    public static bool operator !=(Axis first, Axis second)
    {
        return !(first == second);
    }

    public override int GetHashCode()
    {
        if (this.IsDynamicAxis())
        {
            return this.GetName().GetHashCode();
        }
        else
        {
            return this.StaticAxisIndex().GetHashCode();
        }
    }

  public static AxisVector DefaultInputVariableDynamicAxes() {
    AxisVector ret = new AxisVector(CNTKLibPINVOKE.Axis_DefaultInputVariableDynamicAxes(), false);
    return ret;
  }

  public static AxisVector UnknownDynamicAxes() {
    AxisVector ret = new AxisVector(CNTKLibPINVOKE.Axis_UnknownDynamicAxes(), false);
    return ret;
  }

  public Axis(int staticAxisIdx) : this(CNTKLibPINVOKE.new_Axis__SWIG_0(staticAxisIdx), true) {
  }

  public Axis(string name, bool isOrderedDynamicAxis) : this(CNTKLibPINVOKE.new_Axis__SWIG_1(name, isOrderedDynamicAxis), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public Axis(string name) : this(CNTKLibPINVOKE.new_Axis__SWIG_2(name), true) {
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsStaticAxis() {
    bool ret = CNTKLibPINVOKE.Axis_IsStaticAxis(swigCPtr);
    return ret;
  }

  public bool IsDynamicAxis() {
    bool ret = CNTKLibPINVOKE.Axis_IsDynamicAxis(swigCPtr);
    return ret;
  }

  public bool IsOrderedAxis() {
    bool ret = CNTKLibPINVOKE.Axis_IsOrderedAxis(swigCPtr);
    return ret;
  }

  public int StaticAxisIndex(bool arg0) {
    int ret = CNTKLibPINVOKE.Axis_StaticAxisIndex__SWIG_0(swigCPtr, arg0);
    return ret;
  }

  public int StaticAxisIndex() {
    int ret = CNTKLibPINVOKE.Axis_StaticAxisIndex__SWIG_1(swigCPtr);
    return ret;
  }

  public static Axis DefaultDynamicAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_DefaultDynamicAxis(), false);
    return ret;
  }

  public static Axis DefaultBatchAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_DefaultBatchAxis(), false);
    return ret;
  }

  public static Axis AllStaticAxes() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_AllStaticAxes(), false);
    return ret;
  }

  public static Axis NewUniqueDynamicAxis(string axisNamePrefix, bool isOrderedDynamicAxis) {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_NewUniqueDynamicAxis__SWIG_0(axisNamePrefix, isOrderedDynamicAxis), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis NewUniqueDynamicAxis(string axisNamePrefix) {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_NewUniqueDynamicAxis__SWIG_1(axisNamePrefix), true);
    if (CNTKLibPINVOKE.SWIGPendingException.Pending) throw CNTKLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Axis EndStaticAxis() {
    Axis ret = new Axis(CNTKLibPINVOKE.Axis_EndStaticAxis(), true);
    return ret;
  }

  public string GetName() {
    string ret = CNTKLibPINVOKE.Axis_GetName(swigCPtr);
    return ret;
  }

  public Axis() : this(CNTKLibPINVOKE.new_Axis__SWIG_3(), true) {
  }

}

}