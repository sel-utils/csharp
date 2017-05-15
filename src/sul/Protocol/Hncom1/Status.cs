/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/hncom1.xml
 */
using Types = sul.Hncom1.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Hncom1
{

    public class AddNode : Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;
        public string name;
        public bool main;
        public Types.Game[] acceptedGames;

        public AddNode() {}

        public AddNode(uint hubId, string name, bool main, Types.Game[] acceptedGames)
        {
            this.hubId = hubId;
            this.name = name;
            this.main = main;
            this.acceptedGames = acceptedGames;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteBool(main);
            _buffer.WriteVaruint(acceptedGames.Length); foreach(Types.Game acceptedGamesChild in acceptedGames){ acceptedGamesChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static AddNode FromBuffer(byte[] buffer)
        {
            var ret = new AddNode();
            ret.decode(buffer);
            return ret;
        }

    }

    public class RemoveNode : Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;

        public RemoveNode() {}

        public RemoveNode(uint hubId)
        {
            this.hubId = hubId;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static RemoveNode FromBuffer(byte[] buffer)
        {
            var ret = new RemoveNode();
            ret.decode(buffer);
            return ret;
        }

    }

    public class MessageServerbound : Packet
    {

        public const byte Id = 7;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint[] addressees;
        public byte[] payload;

        public MessageServerbound() {}

        public MessageServerbound(uint[] addressees, byte[] payload)
        {
            this.addressees = addressees;
            this.payload = payload;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(addressees.Length); foreach(uint addresseesChild in addressees){ _buffer.WriteVaruint(addresseesChild); }
            _buffer.WriteVaruint(payload.Length); _buffer.WriteBytes(payload);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static MessageServerbound FromBuffer(byte[] buffer)
        {
            var ret = new MessageServerbound();
            ret.decode(buffer);
            return ret;
        }

    }

    public class MessageClientbound : Packet
    {

        public const byte Id = 8;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint sender;
        public byte[] payload;

        public MessageClientbound() {}

        public MessageClientbound(uint sender, byte[] payload)
        {
            this.sender = sender;
            this.payload = payload;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(sender);
            _buffer.WriteVaruint(payload.Length); _buffer.WriteBytes(payload);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static MessageClientbound FromBuffer(byte[] buffer)
        {
            var ret = new MessageClientbound();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Players : Packet
    {

        public const byte Id = 9;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // max
        public const int Unlimited = -1;

        public uint online;
        public int max;

        public Players() {}

        public Players(uint online, int max)
        {
            this.online = online;
            this.max = max;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(online);
            _buffer.WriteVarint(max);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static Players FromBuffer(byte[] buffer)
        {
            var ret = new Players();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ResourcesUsage : Packet
    {

        public const byte Id = 10;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public float tps;
        public ulong ram;
        public float cpu;

        public ResourcesUsage() {}

        public ResourcesUsage(float tps, ulong ram, float cpu)
        {
            this.tps = tps;
            this.ram = ram;
            this.cpu = cpu;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteBigEndianFloat(tps);
            _buffer.WriteVarulong(ram);
            _buffer.WriteBigEndianFloat(cpu);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {



        }

        public static ResourcesUsage FromBuffer(byte[] buffer)
        {
            var ret = new ResourcesUsage();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Log : Packet
    {

        public const byte Id = 11;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public ulong timestamp;
        public string logger;
        public string message;
        public int commandId;

        public Log() {}

        public Log(ulong timestamp, string logger, string message, int commandId)
        {
            this.timestamp = timestamp;
            this.logger = logger;
            this.message = message;
            this.commandId = commandId;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVarulong(timestamp);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(logger)); _buffer.WriteString(logger);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(message)); _buffer.WriteString(message);
            _buffer.WriteVarint(commandId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static Log FromBuffer(byte[] buffer)
        {
            var ret = new Log();
            ret.decode(buffer);
            return ret;
        }

    }

    public class RemoteCommand : Packet
    {

        public const byte Id = 12;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // origin
        public const byte Hub = 0;
        public const byte ExternalConsole = 1;
        public const byte Rcon = 2;

        public byte origin;
        public Types.Address sender;
        public string command;
        public int commandId;

        public RemoteCommand() {}

        public RemoteCommand(byte origin, Types.Address sender, string command, int commandId)
        {
            this.origin = origin;
            this.sender = sender;
            this.command = command;
            this.commandId = commandId;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteUbyte(origin);
            if(origin!=0){ sender.EncodeBody(_buffer); }
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(command)); _buffer.WriteString(command);
            _buffer.WriteVarint(commandId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

            if(origin!=0){  }


        }

        public static RemoteCommand FromBuffer(byte[] buffer)
        {
            var ret = new RemoteCommand();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateList : Packet
    {

        public const byte Id = 13;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // list
        public const byte Whitelist = 0;
        public const byte Blacklist = 1;

        // action
        public const byte Add = 0;
        public const byte Remove = 1;

        public byte list;
        public byte action;
        public byte type;

        public UpdateList() {}

        public UpdateList(byte list, byte action, byte type)
        {
            this.list = list;
            this.action = action;
            this.type = type;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteUbyte(list);
            _buffer.WriteUbyte(action);
            _buffer.WriteUbyte(type);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {



        }

        public static UpdateList FromBuffer(byte[] buffer)
        {
            var ret = new UpdateList();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Reload : Packet
    {

        public const byte Id = 14;

        public const bool Clientbound = true;
        public const bool Serverbound = false;



        public Reload() {}

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {

        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Reload FromBuffer(byte[] buffer)
        {
            var ret = new Reload();
            ret.decode(buffer);
            return ret;
        }

    }

}
