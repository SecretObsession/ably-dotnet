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
    internal partial class TPresence : TBase
    {
        private TPresenceState _state;
        private string _clientId;
        private TData _clientData;
        private string _memberId;
        private string _inheritMemberId;
        private string _connectionId;
        private string _instanceId;

        /// <summary>
        /// 
        /// <seealso cref="TPresenceState"/>
        /// </summary>
        public TPresenceState State
        {
            get
            {
                return _state;
            }
            set
            {
                __isset.state = true;
                this._state = value;
            }
        }

        public string ClientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                __isset.clientId = true;
                this._clientId = value;
            }
        }

        public TData ClientData
        {
            get
            {
                return _clientData;
            }
            set
            {
                __isset.clientData = true;
                this._clientData = value;
            }
        }

        public string MemberId
        {
            get
            {
                return _memberId;
            }
            set
            {
                __isset.memberId = true;
                this._memberId = value;
            }
        }

        public string InheritMemberId
        {
            get
            {
                return _inheritMemberId;
            }
            set
            {
                __isset.inheritMemberId = true;
                this._inheritMemberId = value;
            }
        }

        public string ConnectionId
        {
            get
            {
                return _connectionId;
            }
            set
            {
                __isset.connectionId = true;
                this._connectionId = value;
            }
        }

        public string InstanceId
        {
            get
            {
                return _instanceId;
            }
            set
            {
                __isset.instanceId = true;
                this._instanceId = value;
            }
        }


        public Isset __isset;
#if !SILVERLIGHT
        [Serializable]
#endif
        public struct Isset
        {
            public bool state;
            public bool clientId;
            public bool clientData;
            public bool memberId;
            public bool inheritMemberId;
            public bool connectionId;
            public bool instanceId;
        }

        public TPresence()
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
                        if (field.Type == Thrift.Protocol.TType.I32)
                        {
                            State = (TPresenceState)iprot.ReadI32();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == Thrift.Protocol.TType.String)
                        {
                            ClientId = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == Thrift.Protocol.TType.Struct)
                        {
                            ClientData = new TData();
                            ClientData.Read(iprot);
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 4:
                        if (field.Type == Thrift.Protocol.TType.String)
                        {
                            MemberId = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 5:
                        if (field.Type == Thrift.Protocol.TType.String)
                        {
                            InheritMemberId = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 6:
                        if (field.Type == Thrift.Protocol.TType.String)
                        {
                            ConnectionId = iprot.ReadString();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 7:
                        if (field.Type == Thrift.Protocol.TType.String)
                        {
                            InstanceId = iprot.ReadString();
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
            TStruct struc = new TStruct("TPresence");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            if (__isset.state)
            {
                field.Name = "state";
                field.Type = Thrift.Protocol.TType.I32;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteI32((int)State);
                oprot.WriteFieldEnd();
            }
            if (ClientId != null && __isset.clientId)
            {
                field.Name = "clientId";
                field.Type = Thrift.Protocol.TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(ClientId);
                oprot.WriteFieldEnd();
            }
            if (ClientData != null && __isset.clientData)
            {
                field.Name = "clientData";
                field.Type = Thrift.Protocol.TType.Struct;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                ClientData.Write(oprot);
                oprot.WriteFieldEnd();
            }
            if (MemberId != null && __isset.memberId)
            {
                field.Name = "memberId";
                field.Type = Thrift.Protocol.TType.String;
                field.ID = 4;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(MemberId);
                oprot.WriteFieldEnd();
            }
            if (InheritMemberId != null && __isset.inheritMemberId)
            {
                field.Name = "inheritMemberId";
                field.Type = Thrift.Protocol.TType.String;
                field.ID = 5;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(InheritMemberId);
                oprot.WriteFieldEnd();
            }
            if (ConnectionId != null && __isset.connectionId)
            {
                field.Name = "connectionId";
                field.Type = Thrift.Protocol.TType.String;
                field.ID = 6;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(ConnectionId);
                oprot.WriteFieldEnd();
            }
            if (InstanceId != null && __isset.instanceId)
            {
                field.Name = "instanceId";
                field.Type = Thrift.Protocol.TType.String;
                field.ID = 7;
                oprot.WriteFieldBegin(field);
                oprot.WriteString(InstanceId);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("TPresence(");
            sb.Append("State: ");
            sb.Append(State);
            sb.Append(",ClientId: ");
            sb.Append(ClientId);
            sb.Append(",ClientData: ");
            sb.Append(ClientData == null ? "<null>" : ClientData.ToString());
            sb.Append(",MemberId: ");
            sb.Append(MemberId);
            sb.Append(",InheritMemberId: ");
            sb.Append(InheritMemberId);
            sb.Append(",ConnectionId: ");
            sb.Append(ConnectionId);
            sb.Append(",InstanceId: ");
            sb.Append(InstanceId);
            sb.Append(")");
            return sb.ToString();
        }

    }

}
