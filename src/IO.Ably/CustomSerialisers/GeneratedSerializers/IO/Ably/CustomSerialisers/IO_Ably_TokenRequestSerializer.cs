﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IO.Ably.CustomSerialisers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class IO_Ably_TokenRequestSerializer : MsgPack.Serialization.MessagePackSerializer<IO.Ably.TokenRequest> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<IO.Ably.Capability> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTimeOffset>> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.TimeSpan>> _serializer3;
        
        public IO_Ably_TokenRequestSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<IO.Ably.Capability>(schema1);
            MsgPack.Serialization.PolymorphismSchema schema2 = default(MsgPack.Serialization.PolymorphismSchema);
            schema2 = null;
            this._serializer2 = context.GetSerializer<System.Nullable<System.DateTimeOffset>>(schema2);
            MsgPack.Serialization.PolymorphismSchema schema3 = default(MsgPack.Serialization.PolymorphismSchema);
            schema3 = null;
            this._serializer3 = context.GetSerializer<System.Nullable<System.TimeSpan>>(schema3);
        }
        
        protected override void PackToCore(MsgPack.Packer packer, IO.Ably.TokenRequest objectTree) {
            packer.PackMapHeader(7);
            this._serializer0.PackTo(packer, "Capability");
            this._serializer1.PackTo(packer, objectTree.Capability);
            this._serializer0.PackTo(packer, "ClientId");
            this._serializer0.PackTo(packer, objectTree.ClientId);
            this._serializer0.PackTo(packer, "KeyName");
            this._serializer0.PackTo(packer, objectTree.KeyName);
            this._serializer0.PackTo(packer, "Mac");
            this._serializer0.PackTo(packer, objectTree.Mac);
            this._serializer0.PackTo(packer, "Nonce");
            this._serializer0.PackTo(packer, objectTree.Nonce);
            this._serializer0.PackTo(packer, "Timestamp");
            this._serializer2.PackTo(packer, objectTree.Timestamp);
            this._serializer0.PackTo(packer, "Ttl");
            this._serializer3.PackTo(packer, objectTree.Ttl);
        }
        
        protected override IO.Ably.TokenRequest UnpackFromCore(MsgPack.Unpacker unpacker) {
            IO.Ably.TokenRequest result = default(IO.Ably.TokenRequest);
            result = new IO.Ably.TokenRequest();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                IO.Ably.Capability nullable = default(IO.Ably.Capability);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    result.Capability = nullable;
                }
                unpacked = (unpacked + 1);
                string nullable0 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String ClientId");
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.ClientId = nullable0;
                }
                unpacked = (unpacked + 1);
                string nullable1 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String KeyName");
                }
                if (((nullable1 == null) 
                            == false)) {
                    result.KeyName = nullable1;
                }
                unpacked = (unpacked + 1);
                string nullable2 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String Mac");
                }
                if (((nullable2 == null) 
                            == false)) {
                    result.Mac = nullable2;
                }
                unpacked = (unpacked + 1);
                string nullable3 = default(string);
                if ((unpacked < itemsCount)) {
                    nullable3 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String Nonce");
                }
                if (((nullable3 == null) 
                            == false)) {
                    result.Nonce = nullable3;
                }
                unpacked = (unpacked + 1);
                System.Nullable<System.DateTimeOffset> nullable4 = default(System.Nullable<System.DateTimeOffset>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(5);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable4 = this._serializer2.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                        disposable0 = unpacker.ReadSubtree();
                        try {
                            nullable4 = this._serializer2.UnpackFrom(disposable0);
                        }
                        finally {
                            if (((disposable0 == null) 
                                        == false)) {
                                disposable0.Dispose();
                            }
                        }
                    }
                }
                if (nullable4.HasValue) {
                    result.Timestamp = nullable4;
                }
                unpacked = (unpacked + 1);
                System.Nullable<System.TimeSpan> nullable5 = default(System.Nullable<System.TimeSpan>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(6);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable5 = this._serializer3.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable1 = default(MsgPack.Unpacker);
                        disposable1 = unpacker.ReadSubtree();
                        try {
                            nullable5 = this._serializer3.UnpackFrom(disposable1);
                        }
                        finally {
                            if (((disposable1 == null) 
                                        == false)) {
                                disposable1.Dispose();
                            }
                        }
                    }
                }
                if (nullable5.HasValue) {
                    result.Ttl = nullable5;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable6 = default(string);
                    nullable6 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "MemberName");
                    if (((nullable6 == null) 
                                == false)) {
                        key = nullable6;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Ttl")) {
                        System.Nullable<System.TimeSpan> nullable13 = default(System.Nullable<System.TimeSpan>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable13 = this._serializer3.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable4 = default(MsgPack.Unpacker);
                            disposable4 = unpacker.ReadSubtree();
                            try {
                                nullable13 = this._serializer3.UnpackFrom(disposable4);
                            }
                            finally {
                                if (((disposable4 == null) 
                                            == false)) {
                                    disposable4.Dispose();
                                }
                            }
                        }
                        if (nullable13.HasValue) {
                            result.Ttl = nullable13;
                        }
                    }
                    else {
                        if ((key == "Timestamp")) {
                            System.Nullable<System.DateTimeOffset> nullable12 = default(System.Nullable<System.DateTimeOffset>);
                            if ((unpacker.Read() == false)) {
                                throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                            }
                            if (((unpacker.IsArrayHeader == false) 
                                        && (unpacker.IsMapHeader == false))) {
                                nullable12 = this._serializer2.UnpackFrom(unpacker);
                            }
                            else {
                                MsgPack.Unpacker disposable3 = default(MsgPack.Unpacker);
                                disposable3 = unpacker.ReadSubtree();
                                try {
                                    nullable12 = this._serializer2.UnpackFrom(disposable3);
                                }
                                finally {
                                    if (((disposable3 == null) 
                                                == false)) {
                                        disposable3.Dispose();
                                    }
                                }
                            }
                            if (nullable12.HasValue) {
                                result.Timestamp = nullable12;
                            }
                        }
                        else {
                            if ((key == "Nonce")) {
                                string nullable11 = default(string);
                                nullable11 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String Nonce");
                                if (((nullable11 == null) 
                                            == false)) {
                                    result.Nonce = nullable11;
                                }
                            }
                            else {
                                if ((key == "Mac")) {
                                    string nullable10 = default(string);
                                    nullable10 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String Mac");
                                    if (((nullable10 == null) 
                                                == false)) {
                                        result.Mac = nullable10;
                                    }
                                }
                                else {
                                    if ((key == "KeyName")) {
                                        string nullable9 = default(string);
                                        nullable9 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String KeyName");
                                        if (((nullable9 == null) 
                                                    == false)) {
                                            result.KeyName = nullable9;
                                        }
                                    }
                                    else {
                                        if ((key == "ClientId")) {
                                            string nullable8 = default(string);
                                            nullable8 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(IO.Ably.TokenRequest), "System.String ClientId");
                                            if (((nullable8 == null) 
                                                        == false)) {
                                                result.ClientId = nullable8;
                                            }
                                        }
                                        else {
                                            if ((key == "Capability")) {
                                                IO.Ably.Capability nullable7 = default(IO.Ably.Capability);
                                                if ((unpacker.Read() == false)) {
                                                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                                                }
                                                if (((unpacker.IsArrayHeader == false) 
                                                            && (unpacker.IsMapHeader == false))) {
                                                    nullable7 = this._serializer1.UnpackFrom(unpacker);
                                                }
                                                else {
                                                    MsgPack.Unpacker disposable2 = default(MsgPack.Unpacker);
                                                    disposable2 = unpacker.ReadSubtree();
                                                    try {
                                                        nullable7 = this._serializer1.UnpackFrom(disposable2);
                                                    }
                                                    finally {
                                                        if (((disposable2 == null) 
                                                                    == false)) {
                                                            disposable2.Dispose();
                                                        }
                                                    }
                                                }
                                                if (((nullable7 == null) 
                                                            == false)) {
                                                    result.Capability = nullable7;
                                                }
                                            }
                                            else {
                                                unpacker.Skip();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
