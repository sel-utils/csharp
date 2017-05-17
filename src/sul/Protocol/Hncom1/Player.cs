/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/hncom1.xml
 */
using System.Text;

using sul.Utils;
using sul.Hncom1.Types;

namespace sul.Hncom1.Player
{

    public class Add : sul.Utils.Packet
    {

        public const byte Id = 15;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // reason
        public const byte FIRST_JOIN = 0;
        public const byte TRANSFERRED = 1;
        public const byte FORCIBLY_TRANSFERRED = 2;

        // input mode
        public const byte KEYBOARD = 0;
        public const byte TOUCH = 1;
        public const byte CONTROLLER = 2;

        public uint hubId;
        public byte reason;
        public byte type;
        public uint protocol;
        public string version;
        public string username;
        public string displayName;
        public sbyte dimension;
        public uint viewDistance;
        public Address clientAddress;
        public string serverAddress;
        public ushort serverPort;
        public System.Guid uuid;
        public Skin skin;
        public string language;
        public byte inputMode;
        public uint latency;

        public Add() : this(0, 0, 0, 0, "", "", "", 0, 0, new Address(), "", 0, System.Guid.Empty, new Skin(), "", 0, 0) {}

        public Add(uint hubId, byte reason, byte type, uint protocol, string version, string username, string displayName, sbyte dimension, uint viewDistance, Address clientAddress, string serverAddress, ushort serverPort, System.Guid uuid, Skin skin, string language, byte inputMode, uint latency)
        {
            this.hubId = hubId;
            this.reason = reason;
            this.type = type;
            this.protocol = protocol;
            this.version = version;
            this.username = username;
            this.displayName = displayName;
            this.dimension = dimension;
            this.viewDistance = viewDistance;
            this.clientAddress = clientAddress;
            this.serverAddress = serverAddress;
            this.serverPort = serverPort;
            this.uuid = uuid;
            this.skin = skin;
            this.language = language;
            this.inputMode = inputMode;
            this.latency = latency;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteUbyte(reason);
            _buffer.WriteUbyte(type);
            _buffer.WriteVaruint(protocol);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(version)); _buffer.WriteString(version);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(username)); _buffer.WriteString(username);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName);
            if(reason!=0){ _buffer.WriteByte(dimension); }
            if(reason!=0){ _buffer.WriteVaruint(viewDistance); }
            clientAddress.EncodeBody(_buffer);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(serverAddress)); _buffer.WriteString(serverAddress);
            _buffer.WriteBigEndianUshort(serverPort);
            _buffer.WriteUuid(uuid);
            skin.EncodeBody(_buffer);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(language)); _buffer.WriteString(language);
            _buffer.WriteUbyte(inputMode);
            _buffer.WriteVaruint(latency);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //reason = _buffer.ReadUbyte();
            //type = _buffer.ReadUbyte();
            //protocol = _buffer.ReadVaruint();
            //version = _buffer.ReadString();
            //username = _buffer.ReadString();
            //displayName = _buffer.ReadString();
            //if(reason!=0){ dimension = _buffer.ReadByte(); }
            //if(reason!=0){ viewDistance = _buffer.ReadVaruint(); }
            //clientAddress.DecodeBody(_buffer);
            //serverAddress = _buffer.ReadString();
            //serverPort = _buffer.ReadBigEndianUshort();
            //uuid = _buffer.ReadUuid();
            //skin.DecodeBody(_buffer);
            //language = _buffer.ReadString();
            //inputMode = _buffer.ReadUbyte();
            //latency = _buffer.ReadVaruint();
        }

        public static Add FromBuffer(byte[] buffer)
        {
            var ret = new Add();
            ret.Decode(buffer);
            return ret;
        }

        public PocketVariant Pocket(long xuid, bool edu, float packetLoss, byte deviceOs, string deviceModel)
        {
            var _variant = new PocketVariant(this);
            _variant.xuid = xuid;
            _variant.edu = edu;
            _variant.packetLoss = packetLoss;
            _variant.deviceOs = deviceOs;
            _variant.deviceModel = deviceModel;
            return _variant;
        }

        public sealed class PocketVariant : sul.Utils.Variant
        {

            private Add _parent;

            public long xuid;
            public bool edu;
            public float packetLoss;
            public byte deviceOs;
            public string deviceModel;

            public PocketVariant(Add parent) : base(parent)
            {
                this._parent = parent;
                this._parent.type = 1;
            }

            protected override void EncodeImpl(sul.Utils.Buffer _buffer)
            {
                _parent.EncodeImpl(_buffer);
                _buffer.WriteVarlong(xuid);
                _buffer.WriteBool(edu);
                _buffer.WriteBigEndianFloat(packetLoss);
                _buffer.WriteUbyte(deviceOs);
                _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(deviceModel)); _buffer.WriteString(deviceModel);
            }

            protected override void DecodeImpl(sul.Utils.Buffer _buffer)
            {
                //TODO
            }

        }

        public MinecraftVariant Minecraft()
        {
            var _variant = new MinecraftVariant(this);

            return _variant;
        }

        public sealed class MinecraftVariant : sul.Utils.Variant
        {

            private Add _parent;



            public MinecraftVariant(Add parent) : base(parent)
            {
                this._parent = parent;
                this._parent.type = 2;
            }

            protected override void EncodeImpl(sul.Utils.Buffer _buffer)
            {
                _parent.EncodeImpl(_buffer);

            }

            protected override void DecodeImpl(sul.Utils.Buffer _buffer)
            {
                //TODO
            }

        }

        public ConsoleVariant Console()
        {
            var _variant = new ConsoleVariant(this);

            return _variant;
        }

        public sealed class ConsoleVariant : sul.Utils.Variant
        {

            private Add _parent;



            public ConsoleVariant(Add parent) : base(parent)
            {
                this._parent = parent;
                this._parent.type = 3;
            }

            protected override void EncodeImpl(sul.Utils.Buffer _buffer)
            {
                _parent.EncodeImpl(_buffer);

            }

            protected override void DecodeImpl(sul.Utils.Buffer _buffer)
            {
                //TODO
            }

        }



    }

    public class Remove : sul.Utils.Packet
    {

        public const byte Id = 16;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // reason
        public const byte LEFT = 0;
        public const byte TIMED_OUT = 1;
        public const byte KICKED = 2;
        public const byte TRANSFERRED = 3;

        public uint hubId;
        public byte reason;

        public Remove() : this(0, 0) {}

        public Remove(uint hubId, byte reason)
        {
            this.hubId = hubId;
            this.reason = reason;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteUbyte(reason);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //reason = _buffer.ReadUbyte();
        }

        public static Remove FromBuffer(byte[] buffer)
        {
            var ret = new Remove();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Kick : sul.Utils.Packet
    {

        public const byte Id = 17;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public string reason;
        public bool translation;
        public string[] parameters;

        public Kick() : this(0, "", false, new string[]{}) {}

        public Kick(uint hubId, string reason, bool translation, string[] parameters)
        {
            this.hubId = hubId;
            this.reason = reason;
            this.translation = translation;
            this.parameters = parameters;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(reason)); _buffer.WriteString(reason);
            _buffer.WriteBool(translation);
            if(translation==true){ _buffer.WriteVaruint(parameters.Length); foreach (string parametersChild in parameters){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(parametersChild)); _buffer.WriteString(parametersChild); } }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //reason = _buffer.ReadString();
            //translation = _buffer.ReadBool();
            //if(translation==true){ parameters.DecodeBody(_buffer); }
        }

        public static Kick FromBuffer(byte[] buffer)
        {
            var ret = new Kick();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Transfer : sul.Utils.Packet
    {

        public const byte Id = 18;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // on fail
        public const byte DISCONNECT = 0;
        public const byte AUTO = 1;
        public const byte RECONNECT = 2;

        public uint hubId;
        public uint node;
        public byte onFail;

        public Transfer() : this(0, 0, 0) {}

        public Transfer(uint hubId, uint node, byte onFail)
        {
            this.hubId = hubId;
            this.node = node;
            this.onFail = onFail;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(node);
            _buffer.WriteUbyte(onFail);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //node = _buffer.ReadVaruint();
            //onFail = _buffer.ReadUbyte();
        }

        public static Transfer FromBuffer(byte[] buffer)
        {
            var ret = new Transfer();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateDisplayName : sul.Utils.Packet
    {

        public const byte Id = 19;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public string displayName;

        public UpdateDisplayName() : this(0, "") {}

        public UpdateDisplayName(uint hubId, string displayName)
        {
            this.hubId = hubId;
            this.displayName = displayName;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //displayName = _buffer.ReadString();
        }

        public static UpdateDisplayName FromBuffer(byte[] buffer)
        {
            var ret = new UpdateDisplayName();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateWorld : sul.Utils.Packet
    {

        public const byte Id = 20;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public string world;
        public sbyte dimension;

        public UpdateWorld() : this(0, "", 0) {}

        public UpdateWorld(uint hubId, string world, sbyte dimension)
        {
            this.hubId = hubId;
            this.world = world;
            this.dimension = dimension;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(world)); _buffer.WriteString(world);
            _buffer.WriteByte(dimension);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //world = _buffer.ReadString();
            //dimension = _buffer.ReadByte();
        }

        public static UpdateWorld FromBuffer(byte[] buffer)
        {
            var ret = new UpdateWorld();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateViewDistance : sul.Utils.Packet
    {

        public const byte Id = 21;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public uint viewDistance;

        public UpdateViewDistance() : this(0, 0) {}

        public UpdateViewDistance(uint hubId, uint viewDistance)
        {
            this.hubId = hubId;
            this.viewDistance = viewDistance;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(viewDistance);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //viewDistance = _buffer.ReadVaruint();
        }

        public static UpdateViewDistance FromBuffer(byte[] buffer)
        {
            var ret = new UpdateViewDistance();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateLanguage : sul.Utils.Packet
    {

        public const byte Id = 22;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public string language;

        public UpdateLanguage() : this(0, "") {}

        public UpdateLanguage(uint hubId, string language)
        {
            this.hubId = hubId;
            this.language = language;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(language)); _buffer.WriteString(language);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //language = _buffer.ReadString();
        }

        public static UpdateLanguage FromBuffer(byte[] buffer)
        {
            var ret = new UpdateLanguage();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateInputMode : sul.Utils.Packet
    {

        public const byte Id = 23;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // input mode
        public const byte KEYBOARD = 0;
        public const byte TOUCH = 1;
        public const byte CONTROLLER = 2;

        public uint hubId;
        public byte inputMode;

        public UpdateInputMode() : this(0, 0) {}

        public UpdateInputMode(uint hubId, byte inputMode)
        {
            this.hubId = hubId;
            this.inputMode = inputMode;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteUbyte(inputMode);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //inputMode = _buffer.ReadUbyte();
        }

        public static UpdateInputMode FromBuffer(byte[] buffer)
        {
            var ret = new UpdateInputMode();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateLatency : sul.Utils.Packet
    {

        public const byte Id = 24;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;
        public uint latency;

        public UpdateLatency() : this(0, 0) {}

        public UpdateLatency(uint hubId, uint latency)
        {
            this.hubId = hubId;
            this.latency = latency;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(latency);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //latency = _buffer.ReadVaruint();
        }

        public static UpdateLatency FromBuffer(byte[] buffer)
        {
            var ret = new UpdateLatency();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdatePacketLoss : sul.Utils.Packet
    {

        public const byte Id = 25;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;
        public float packetLoss;

        public UpdatePacketLoss() : this(0, 0) {}

        public UpdatePacketLoss(uint hubId, float packetLoss)
        {
            this.hubId = hubId;
            this.packetLoss = packetLoss;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteBigEndianFloat(packetLoss);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //packetLoss = _buffer.ReadBigEndianFloat();
        }

        public static UpdatePacketLoss FromBuffer(byte[] buffer)
        {
            var ret = new UpdatePacketLoss();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class GamePacket : sul.Utils.Packet
    {

        public const byte Id = 26;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public uint hubId;
        public byte[] packet;

        public GamePacket() : this(0, new byte[]{}) {}

        public GamePacket(uint hubId, byte[] packet)
        {
            this.hubId = hubId;
            this.packet = packet;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteBytes(packet);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //packet = _buffer.ReadBytes();
        }

        public static GamePacket FromBuffer(byte[] buffer)
        {
            var ret = new GamePacket();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class OrderedGamePacket : sul.Utils.Packet
    {

        public const byte Id = 27;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint hubId;
        public uint order;
        public byte[] packet;

        public OrderedGamePacket() : this(0, 0, new byte[]{}) {}

        public OrderedGamePacket(uint hubId, uint order, byte[] packet)
        {
            this.hubId = hubId;
            this.order = order;
            this.packet = packet;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(order);
            _buffer.WriteBytes(packet);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //order = _buffer.ReadVaruint();
            //packet = _buffer.ReadBytes();
        }

        public static OrderedGamePacket FromBuffer(byte[] buffer)
        {
            var ret = new OrderedGamePacket();
            ret.Decode(buffer);
            return ret;
        }

    }

}
