/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ably.Protocol
{

#if !SILVERLIGHT
    [Serializable]
#endif
    internal partial class SRequestCount : TBase
    {
        private double _succeeded;
        private double _failed;
        private double _refused;

        public double Succeeded
        {
            get
            {
                return _succeeded;
            }
            set
            {
                __isset.succeeded = true;
                this._succeeded = value;
            }
        }

        public double Failed
        {
            get
            {
                return _failed;
            }
            set
            {
                __isset.failed = true;
                this._failed = value;
            }
        }

        public double Refused
        {
            get
            {
                return _refused;
            }
            set
            {
                __isset.refused = true;
                this._refused = value;
            }
        }


        public Isset __isset;
#if !SILVERLIGHT
        [Serializable]
#endif
        public struct Isset
        {
            public bool succeeded;
            public bool failed;
            public bool refused;
        }

        public SRequestCount()
        {
        }

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == Thrift.Protocol.TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == Thrift.Protocol.TType.Double)
                        {
                            Succeeded = iprot.ReadDouble();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == Thrift.Protocol.TType.Double)
                        {
                            Failed = iprot.ReadDouble();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == Thrift.Protocol.TType.Double)
                        {
                            Refused = iprot.ReadDouble();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            TStruct struc = new TStruct("SRequestCount");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (__isset.succeeded)
            {
                field.Name = "succeeded";
                field.Type = Thrift.Protocol.TType.Double;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteDouble(Succeeded);
                oprot.WriteFieldEnd();
            }
            if (__isset.failed)
            {
                field.Name = "failed";
                field.Type = Thrift.Protocol.TType.Double;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteDouble(Failed);
                oprot.WriteFieldEnd();
            }
            if (__isset.refused)
            {
                field.Name = "refused";
                field.Type = Thrift.Protocol.TType.Double;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteDouble(Refused);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("SRequestCount(");
            sb.Append("Succeeded: ");
            sb.Append(Succeeded);
            sb.Append(",Failed: ");
            sb.Append(Failed);
            sb.Append(",Refused: ");
            sb.Append(Refused);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
