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

namespace sul.Hncom1.Status
{

    public class AddNode : sul.Utils.Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;
        public string name;
        public bool main;
        public Game[] acceptedGames;

        public AddNode() : this(0, "", false, new Game[]{}) {}

        public AddNode(uint hubId, string name, bool main, Game[] acceptedGames)
        {
            this.hubId = hubId;
            this.name = name;
            this.main = main;
            this.acceptedGames = acceptedGames;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteBool(main);
            _buffer.WriteVaruint(acceptedGames.Length); foreach (Game acceptedGamesChild in acceptedGames){ acceptedGamesChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
            //name = _buffer.ReadString();
            //main = _buffer.ReadBool();
            //acceptedGames.DecodeBody(_buffer);
        }

        public static AddNode FromBuffer(byte[] buffer)
        {
            var ret = new AddNode();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class RemoveNode : sul.Utils.Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint hubId;

        public RemoveNode() : this(0) {}

        public RemoveNode(uint hubId)
        {
            this.hubId = hubId;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(hubId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hubId = _buffer.ReadVaruint();
        }

        public static RemoveNode FromBuffer(byte[] buffer)
        {
            var ret = new RemoveNode();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class MessageServerbound : sul.Utils.Packet
    {

        public const byte Id = 7;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint[] addressees;
        public byte[] payload;

        public MessageServerbound() : this(new uint[]{}, new byte[]{}) {}

        public MessageServerbound(uint[] addressees, byte[] payload)
        {
            this.addressees = addressees;
            this.payload = payload;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(addressees.Length); foreach (uint addresseesChild in addressees){ _buffer.WriteVaruint(addresseesChild); }
            _buffer.WriteVaruint(payload.Length); _buffer.WriteBytes(payload);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //addressees.DecodeBody(_buffer);
            //payload.DecodeBody(_buffer);
        }

        public static MessageServerbound FromBuffer(byte[] buffer)
        {
            var ret = new MessageServerbound();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class MessageClientbound : sul.Utils.Packet
    {

        public const byte Id = 8;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint sender;
        public byte[] payload;

        public MessageClientbound() : this(0, new byte[]{}) {}

        public MessageClientbound(uint sender, byte[] payload)
        {
            this.sender = sender;
            this.payload = payload;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(sender);
            _buffer.WriteVaruint(payload.Length); _buffer.WriteBytes(payload);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //sender = _buffer.ReadVaruint();
            //payload.DecodeBody(_buffer);
        }

        public static MessageClientbound FromBuffer(byte[] buffer)
        {
            var ret = new MessageClientbound();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Players : sul.Utils.Packet
    {

        public const byte Id = 9;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // max
        public const int UNLIMITED = -1;

        public uint online;
        public int max;

        public Players() : this(0, 0) {}

        public Players(uint online, int max)
        {
            this.online = online;
            this.max = max;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(online);
            _buffer.WriteVarint(max);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //online = _buffer.ReadVaruint();
            //max = _buffer.ReadVarint();
        }

        public static Players FromBuffer(byte[] buffer)
        {
            var ret = new Players();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class ResourcesUsage : sul.Utils.Packet
    {

        public const byte Id = 10;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public float tps;
        public ulong ram;
        public float cpu;

        public ResourcesUsage() : this(0, 0, 0) {}

        public ResourcesUsage(float tps, ulong ram, float cpu)
        {
            this.tps = tps;
            this.ram = ram;
            this.cpu = cpu;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteBigEndianFloat(tps);
            _buffer.WriteVarulong(ram);
            _buffer.WriteBigEndianFloat(cpu);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //tps = _buffer.ReadBigEndianFloat();
            //ram = _buffer.ReadVarulong();
            //cpu = _buffer.ReadBigEndianFloat();
        }

        public static ResourcesUsage FromBuffer(byte[] buffer)
        {
            var ret = new ResourcesUsage();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Log : sul.Utils.Packet
    {

        public const byte Id = 11;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public ulong timestamp;
        public string logger;
        public string message;
        public int commandId;

        public Log() : this(0, "", "", 0) {}

        public Log(ulong timestamp, string logger, string message, int commandId)
        {
            this.timestamp = timestamp;
            this.logger = logger;
            this.message = message;
            this.commandId = commandId;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarulong(timestamp);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(logger)); _buffer.WriteString(logger);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(message)); _buffer.WriteString(message);
            _buffer.WriteVarint(commandId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //timestamp = _buffer.ReadVarulong();
            //logger = _buffer.ReadString();
            //message = _buffer.ReadString();
            //commandId = _buffer.ReadVarint();
        }

        public static Log FromBuffer(byte[] buffer)
        {
            var ret = new Log();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class RemoteCommand : sul.Utils.Packet
    {

        public const byte Id = 12;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // origin
        public const byte HUB = 0;
        public const byte EXTERNAL_CONSOLE = 1;
        public const byte RCON = 2;

        public byte origin;
        public Address sender;
        public string command;
        public int commandId;

        public RemoteCommand() : this(0, new Address(), "", 0) {}

        public RemoteCommand(byte origin, Address sender, string command, int commandId)
        {
            this.origin = origin;
            this.sender = sender;
            this.command = command;
            this.commandId = commandId;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(origin);
            if(origin!=0){ sender.EncodeBody(_buffer); }
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(command)); _buffer.WriteString(command);
            _buffer.WriteVarint(commandId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //origin = _buffer.ReadUbyte();
            //if(origin!=0){ sender.DecodeBody(_buffer); }
            //command = _buffer.ReadString();
            //commandId = _buffer.ReadVarint();
        }

        public static RemoteCommand FromBuffer(byte[] buffer)
        {
            var ret = new RemoteCommand();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class UpdateList : sul.Utils.Packet
    {

        public const byte Id = 13;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // list
        public const byte WHITELIST = 0;
        public const byte BLACKLIST = 1;

        // action
        public const byte ADD = 0;
        public const byte REMOVE = 1;

        public byte list;
        public byte action;
        public byte type;

        public UpdateList() : this(0, 0, 0) {}

        public UpdateList(byte list, byte action, byte type)
        {
            this.list = list;
            this.action = action;
            this.type = type;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(list);
            _buffer.WriteUbyte(action);
            _buffer.WriteUbyte(type);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //list = _buffer.ReadUbyte();
            //action = _buffer.ReadUbyte();
            //type = _buffer.ReadUbyte();
        }

        public static UpdateList FromBuffer(byte[] buffer)
        {
            var ret = new UpdateList();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Reload : sul.Utils.Packet
    {

        public const byte Id = 14;

        public const bool Clientbound = true;
        public const bool Serverbound = false;



        public Reload()
        {

        }

        public override int GetId()
        {
            return (int)Id;
        }

        protected override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        protected override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {

        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {

        }

        public static Reload FromBuffer(byte[] buffer)
        {
            var ret = new Reload();
            ret.Decode(buffer);
            return ret;
        }

    }

}
