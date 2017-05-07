/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/raknet8.xml
 */
using Types = sul.Raknet8.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Raknet8
{

    public class Ping : Packet
    {

        public const byte Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public long pingId;
        public byte[16] magic;

        public Ping() {}

        public Ping(long pingId, byte[16] magic)
        {
            this.pingId = pingId;
            this.magic = magic;
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
            _buffer.WriteBigEndianLong(pingId);
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static Ping FromBuffer(byte[] buffer)
        {
            var ret = new Ping();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Pong : Packet
    {

        public const byte Id = 28;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public long pingId;
        public long serverId;
        public byte[16] magic;
        public string status;

        public Pong() {}

        public Pong(long pingId, long serverId, byte[16] magic, string status)
        {
            this.pingId = pingId;
            this.serverId = serverId;
            this.magic = magic;
            this.status = status;
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
            _buffer.WriteBigEndianLong(pingId);
            _buffer.WriteBigEndianLong(serverId);
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteString(status);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static Pong FromBuffer(byte[] buffer)
        {
            var ret = new Pong();
            ret.decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionRequest1 : Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[16] magic;
        public byte protocol;
        public byte[] mtu;

        public OpenConnectionRequest1() {}

        public OpenConnectionRequest1(byte[16] magic, byte protocol, byte[] mtu)
        {
            this.magic = magic;
            this.protocol = protocol;
            this.mtu = mtu;
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
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteUbyte(protocol);
            _buffer.WriteBytes(mtu);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {



        }

        public static OpenConnectionRequest1 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionRequest1();
            ret.decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionReply1 : Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[16] magic;
        public long serverId;
        public bool security;
        public ushort mtuLength;

        public OpenConnectionReply1() {}

        public OpenConnectionReply1(byte[16] magic, long serverId, bool security, ushort mtuLength)
        {
            this.magic = magic;
            this.serverId = serverId;
            this.security = security;
            this.mtuLength = mtuLength;
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
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteBigEndianLong(serverId);
            _buffer.WriteBool(security);
            _buffer.WriteBigEndianUshort(mtuLength);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static OpenConnectionReply1 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionReply1();
            ret.decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionRequest2 : Packet
    {

        public const byte Id = 7;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[16] magic;
        public Types.Address serverAddress;
        public ushort mtuLength;
        public long clientId;

        public OpenConnectionRequest2() {}

        public OpenConnectionRequest2(byte[16] magic, Types.Address serverAddress, ushort mtuLength, long clientId)
        {
            this.magic = magic;
            this.serverAddress = serverAddress;
            this.mtuLength = mtuLength;
            this.clientId = clientId;
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
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            serverAddress.EncodeBody(_buffer);
            _buffer.WriteBigEndianUshort(mtuLength);
            _buffer.WriteBigEndianLong(clientId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static OpenConnectionRequest2 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionRequest2();
            ret.decode(buffer);
            return ret;
        }

    }

    public class OpenConnectionReply2 : Packet
    {

        public const byte Id = 8;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[16] magic;
        public long serverId;
        public Types.Address clientAddress;
        public ushort mtuLength;
        public bool security;

        public OpenConnectionReply2() {}

        public OpenConnectionReply2(byte[16] magic, long serverId, Types.Address clientAddress, ushort mtuLength, bool security)
        {
            this.magic = magic;
            this.serverId = serverId;
            this.clientAddress = clientAddress;
            this.mtuLength = mtuLength;
            this.security = security;
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
            foreach(byte magicChild in magic){ _buffer.WriteUbyte(magicChild); }
            _buffer.WriteBigEndianLong(serverId);
            clientAddress.EncodeBody(_buffer);
            _buffer.WriteBigEndianUshort(mtuLength);
            _buffer.WriteBool(security);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {





        }

        public static OpenConnectionReply2 FromBuffer(byte[] buffer)
        {
            var ret = new OpenConnectionReply2();
            ret.decode(buffer);
            return ret;
        }

    }

}
