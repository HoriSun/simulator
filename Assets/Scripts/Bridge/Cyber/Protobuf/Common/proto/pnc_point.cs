// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: pnc_point.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SLPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SLPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        public double l
        {
            get { return __pbn__l.GetValueOrDefault(); }
            set { __pbn__l = value; }
        }
        public bool ShouldSerializel()
        {
            return __pbn__l != null;
        }
        public void Resetl()
        {
            __pbn__l = null;
        }
        private double? __pbn__l;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FrenetFramePoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FrenetFramePoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        public double l
        {
            get { return __pbn__l.GetValueOrDefault(); }
            set { __pbn__l = value; }
        }
        public bool ShouldSerializel()
        {
            return __pbn__l != null;
        }
        public void Resetl()
        {
            __pbn__l = null;
        }
        private double? __pbn__l;

        [global::ProtoBuf.ProtoMember(3)]
        public double dl
        {
            get { return __pbn__dl.GetValueOrDefault(); }
            set { __pbn__dl = value; }
        }
        public bool ShouldSerializedl()
        {
            return __pbn__dl != null;
        }
        public void Resetdl()
        {
            __pbn__dl = null;
        }
        private double? __pbn__dl;

        [global::ProtoBuf.ProtoMember(4)]
        public double ddl
        {
            get { return __pbn__ddl.GetValueOrDefault(); }
            set { __pbn__ddl = value; }
        }
        public bool ShouldSerializeddl()
        {
            return __pbn__ddl != null;
        }
        public void Resetddl()
        {
            __pbn__ddl = null;
        }
        private double? __pbn__ddl;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SpeedPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpeedPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        public double t
        {
            get { return __pbn__t.GetValueOrDefault(); }
            set { __pbn__t = value; }
        }
        public bool ShouldSerializet()
        {
            return __pbn__t != null;
        }
        public void Resett()
        {
            __pbn__t = null;
        }
        private double? __pbn__t;

        [global::ProtoBuf.ProtoMember(3)]
        public double v
        {
            get { return __pbn__v.GetValueOrDefault(); }
            set { __pbn__v = value; }
        }
        public bool ShouldSerializev()
        {
            return __pbn__v != null;
        }
        public void Resetv()
        {
            __pbn__v = null;
        }
        private double? __pbn__v;

        [global::ProtoBuf.ProtoMember(4)]
        public double a
        {
            get { return __pbn__a.GetValueOrDefault(); }
            set { __pbn__a = value; }
        }
        public bool ShouldSerializea()
        {
            return __pbn__a != null;
        }
        public void Reseta()
        {
            __pbn__a = null;
        }
        private double? __pbn__a;

        [global::ProtoBuf.ProtoMember(5)]
        public double da
        {
            get { return __pbn__da.GetValueOrDefault(); }
            set { __pbn__da = value; }
        }
        public bool ShouldSerializeda()
        {
            return __pbn__da != null;
        }
        public void Resetda()
        {
            __pbn__da = null;
        }
        private double? __pbn__da;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PathPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PathPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double x
        {
            get { return __pbn__x.GetValueOrDefault(); }
            set { __pbn__x = value; }
        }
        public bool ShouldSerializex()
        {
            return __pbn__x != null;
        }
        public void Resetx()
        {
            __pbn__x = null;
        }
        private double? __pbn__x;

        [global::ProtoBuf.ProtoMember(2)]
        public double y
        {
            get { return __pbn__y.GetValueOrDefault(); }
            set { __pbn__y = value; }
        }
        public bool ShouldSerializey()
        {
            return __pbn__y != null;
        }
        public void Resety()
        {
            __pbn__y = null;
        }
        private double? __pbn__y;

        [global::ProtoBuf.ProtoMember(3)]
        public double z
        {
            get { return __pbn__z.GetValueOrDefault(); }
            set { __pbn__z = value; }
        }
        public bool ShouldSerializez()
        {
            return __pbn__z != null;
        }
        public void Resetz()
        {
            __pbn__z = null;
        }
        private double? __pbn__z;

        [global::ProtoBuf.ProtoMember(4)]
        public double theta
        {
            get { return __pbn__theta.GetValueOrDefault(); }
            set { __pbn__theta = value; }
        }
        public bool ShouldSerializetheta()
        {
            return __pbn__theta != null;
        }
        public void Resettheta()
        {
            __pbn__theta = null;
        }
        private double? __pbn__theta;

        [global::ProtoBuf.ProtoMember(5)]
        public double kappa
        {
            get { return __pbn__kappa.GetValueOrDefault(); }
            set { __pbn__kappa = value; }
        }
        public bool ShouldSerializekappa()
        {
            return __pbn__kappa != null;
        }
        public void Resetkappa()
        {
            __pbn__kappa = null;
        }
        private double? __pbn__kappa;

        [global::ProtoBuf.ProtoMember(6)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(7)]
        public double dkappa
        {
            get { return __pbn__dkappa.GetValueOrDefault(); }
            set { __pbn__dkappa = value; }
        }
        public bool ShouldSerializedkappa()
        {
            return __pbn__dkappa != null;
        }
        public void Resetdkappa()
        {
            __pbn__dkappa = null;
        }
        private double? __pbn__dkappa;

        [global::ProtoBuf.ProtoMember(8)]
        public double ddkappa
        {
            get { return __pbn__ddkappa.GetValueOrDefault(); }
            set { __pbn__ddkappa = value; }
        }
        public bool ShouldSerializeddkappa()
        {
            return __pbn__ddkappa != null;
        }
        public void Resetddkappa()
        {
            __pbn__ddkappa = null;
        }
        private double? __pbn__ddkappa;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_id
        {
            get { return __pbn__lane_id ?? ""; }
            set { __pbn__lane_id = value; }
        }
        public bool ShouldSerializelane_id()
        {
            return __pbn__lane_id != null;
        }
        public void Resetlane_id()
        {
            __pbn__lane_id = null;
        }
        private string __pbn__lane_id;

        [global::ProtoBuf.ProtoMember(10)]
        public double x_derivative
        {
            get { return __pbn__x_derivative.GetValueOrDefault(); }
            set { __pbn__x_derivative = value; }
        }
        public bool ShouldSerializex_derivative()
        {
            return __pbn__x_derivative != null;
        }
        public void Resetx_derivative()
        {
            __pbn__x_derivative = null;
        }
        private double? __pbn__x_derivative;

        [global::ProtoBuf.ProtoMember(11)]
        public double y_derivative
        {
            get { return __pbn__y_derivative.GetValueOrDefault(); }
            set { __pbn__y_derivative = value; }
        }
        public bool ShouldSerializey_derivative()
        {
            return __pbn__y_derivative != null;
        }
        public void Resety_derivative()
        {
            __pbn__y_derivative = null;
        }
        private double? __pbn__y_derivative;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Path : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Path()
        {
            path_point = new global::System.Collections.Generic.List<PathPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<PathPoint> path_point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrajectoryPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrajectoryPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public PathPoint path_point { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double v
        {
            get { return __pbn__v.GetValueOrDefault(); }
            set { __pbn__v = value; }
        }
        public bool ShouldSerializev()
        {
            return __pbn__v != null;
        }
        public void Resetv()
        {
            __pbn__v = null;
        }
        private double? __pbn__v;

        [global::ProtoBuf.ProtoMember(3)]
        public double a
        {
            get { return __pbn__a.GetValueOrDefault(); }
            set { __pbn__a = value; }
        }
        public bool ShouldSerializea()
        {
            return __pbn__a != null;
        }
        public void Reseta()
        {
            __pbn__a = null;
        }
        private double? __pbn__a;

        [global::ProtoBuf.ProtoMember(4)]
        public double relative_time
        {
            get { return __pbn__relative_time.GetValueOrDefault(); }
            set { __pbn__relative_time = value; }
        }
        public bool ShouldSerializerelative_time()
        {
            return __pbn__relative_time != null;
        }
        public void Resetrelative_time()
        {
            __pbn__relative_time = null;
        }
        private double? __pbn__relative_time;

        [global::ProtoBuf.ProtoMember(5)]
        public double da
        {
            get { return __pbn__da.GetValueOrDefault(); }
            set { __pbn__da = value; }
        }
        public bool ShouldSerializeda()
        {
            return __pbn__da != null;
        }
        public void Resetda()
        {
            __pbn__da = null;
        }
        private double? __pbn__da;

        [global::ProtoBuf.ProtoMember(6)]
        public double steer
        {
            get { return __pbn__steer.GetValueOrDefault(); }
            set { __pbn__steer = value; }
        }
        public bool ShouldSerializesteer()
        {
            return __pbn__steer != null;
        }
        public void Resetsteer()
        {
            __pbn__steer = null;
        }
        private double? __pbn__steer;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Trajectory : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Trajectory()
        {
            trajectory_point = new global::System.Collections.Generic.List<TrajectoryPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<TrajectoryPoint> trajectory_point { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleMotionPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleMotionPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public TrajectoryPoint trajectory_point { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double steer
        {
            get { return __pbn__steer.GetValueOrDefault(); }
            set { __pbn__steer = value; }
        }
        public bool ShouldSerializesteer()
        {
            return __pbn__steer != null;
        }
        public void Resetsteer()
        {
            __pbn__steer = null;
        }
        private double? __pbn__steer;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleMotion : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleMotion()
        {
            vehicle_motion_point = new global::System.Collections.Generic.List<VehicleMotionPoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<VehicleMotionPoint> vehicle_motion_point { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021