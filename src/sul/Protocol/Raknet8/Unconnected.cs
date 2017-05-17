/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/raknet8.xml
 */
using System.Text;

using sul.Utils;
using sul.Raknet8.Types;

namespace sul.Raknet8.Unconnected
{

    public class Ping : sul.Utils.Packet
    {

        public const byte Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public long pingId;
        public byte[] magic;

        public Ping() : this(0, new byte[16]) {}

        public Ping(long pingId, byte[] magic)
        {
            this.pingId = pingId;
            this.magic = magic;
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
            _buffer.WriteBigEndianLong(pingId);
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //pingId = _buffer.ReadBigEndianLong();
            //magic.DecodeBody(_buffer);
        }

        public static Ping FromBuffer(byte[] buffer)
        {
            var ret = new Ping();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Pong : sul.Utils.Packet
    {

        public const byte Id = 28;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public long pingId;
        public long serverId;
        public byte[] magic;
        public string status;

        public Pong() : this(0, 0, new byte[16], "") {}

        public Pong(long pingId, long serverId, byte[] magic, string status)
        {
            this.pingId = pingId;
            this.serverId = serverId;
            this.magic = magic;
            this.status = status;
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
            _buffer.WriteBigEndianLong(pingId);
            _buffer.WriteBigEndianLong(serverId);
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(status)); _buffer.WriteString(status);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //pingId = _buffer.ReadBigEndianLong();
            //serverId = _buffer.ReadBigEndianLong();
            //magic.DecodeBody(_buffer);
            //status = _buffer.ReadString();
        }

        public static Pong FromBuffer(byte[] buffer)
        {
            var ret = new Pong();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionRequest1 : sul.Utils.Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] magic;
        public byte protocol;
        public byte[] mtu;

        public OpenConnectionRequest1() : this(new byte[16], 0, new byte[]{}) {}

        public OpenConnectionRequest1(byte[] magic, byte protocol, byte[] mtu)
        {
            this.magic = magic;
            this.protocol = protocol;
            this.mtu = mtu;
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
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteUbyte(protocol);
            _buffer.WriteBytes(mtu);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //magic.DecodeBody(_buffer);
            //protocol = _buffer.ReadUbyte();
            //mtu = _buffer.ReadBytes();
        }

        public static OpenConnectionRequest1 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionRequest1();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionReply1 : sul.Utils.Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[] magic;
        public long serverId;
        public bool security;
        public ushort mtuLength;

        public OpenConnectionReply1() : this(new byte[16], 0, false, 0) {}

        public OpenConnectionReply1(byte[] magic, long serverId, bool security, ushort mtuLength)
        {
            this.magic = magic;
            this.serverId = serverId;
            this.security = security;
            this.mtuLength = mtuLength;
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
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteBigEndianLong(serverId);
            _buffer.WriteBool(security);
            _buffer.WriteBigEndianUshort(mtuLength);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //magic.DecodeBody(_buffer);
            //serverId = _buffer.ReadBigEndianLong();
            //security = _buffer.ReadBool();
            //mtuLength = _buffer.ReadBigEndianUshort();
        }

        public static OpenConnectionReply1 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionReply1();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionRequest2 : sul.Utils.Packet
    {

        public const byte Id = 7;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] magic;
        public Address serverAddress;
        public ushort mtuLength;
        public long clientId;

        public OpenConnectionRequest2() : this(new byte[16], new Address(), 0, 0) {}

        public OpenConnectionRequest2(byte[] magic, Address serverAddress, ushort mtuLength, long clientId)
        {
            this.magic = magic;
            this.serverAddress = serverAddress;
            this.mtuLength = mtuLength;
            this.clientId = clientId;
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
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            serverAddress.EncodeBody(_buffer);
            _buffer.WriteBigEndianUshort(mtuLength);
            _buffer.WriteBigEndianLong(clientId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //magic.DecodeBody(_buffer);
            //serverAddress.DecodeBody(_buffer);
            //mtuLength = _buffer.ReadBigEndianUshort();
            //clientId = _buffer.ReadBigEndianLong();
        }

        public static OpenConnectionRequest2 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionRequest2();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionReply2 : sul.Utils.Packet
    {

        public const byte Id = 8;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[] magic;
        public long serverId;
        public Address clientAddress;
        public ushort mtuLength;
        public bool security;

        public OpenConnectionReply2() : this(new byte[16], 0, new Address(), 0, false) {}

        public OpenConnectionReply2(byte[] magic, long serverId, Address clientAddress, ushort mtuLength, bool security)
        {
            this.magic = magic;
            this.serverId = serverId;
            this.clientAddress = clientAddress;
            this.mtuLength = mtuLength;
            this.security = security;
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
            foreach (byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteBigEndianLong(serverId);
            clientAddress.EncodeBody(_buffer);
            _buffer.WriteBigEndianUshort(mtuLength);
            _buffer.WriteBool(security);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //magic.DecodeBody(_buffer);
            //serverId = _buffer.ReadBigEndianLong();
            //clientAddress.DecodeBody(_buffer);
            //mtuLength = _buffer.ReadBigEndianUshort();
            //security = _buffer.ReadBool();
        }

        public static OpenConnectionReply2 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionReply2();
            ret.Decode(buffer);
            return ret;
        }

    }

}
