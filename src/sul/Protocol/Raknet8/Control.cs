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
using sul.Protocol.Raknet8.Types;

namespace sul.Protocol.Raknet8.Control
{

    public class Ack : sul.Utils.Packet
    {

        public const byte Id = 192;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public Acknowledge[] packets;

        public Ack() : this(new Acknowledge[]{}) {}

        public Ack(Acknowledge[] packets)
        {
            this.packets = packets;
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
            _buffer.WriteBigEndianUshort(packets.Length); foreach (Acknowledge packetsChild in packets){ packetsChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //packets.DecodeBody(_buffer);
        }

        public static Ack FromBuffer(byte[] buffer)
        {
            var ret = new Ack();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Nack : sul.Utils.Packet
    {

        public const byte Id = 160;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public Acknowledge[] packets;

        public Nack() : this(new Acknowledge[]{}) {}

        public Nack(Acknowledge[] packets)
        {
            this.packets = packets;
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
            _buffer.WriteBigEndianUshort(packets.Length); foreach (Acknowledge packetsChild in packets){ packetsChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //packets.DecodeBody(_buffer);
        }

        public static Nack FromBuffer(byte[] buffer)
        {
            var ret = new Nack();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Encapsulated : sul.Utils.Packet
    {

        public const byte Id = 132;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public int count;
        public Encapsulation encapsulation;

        public Encapsulated() : this(0, new Encapsulation()) {}

        public Encapsulated(int count, Encapsulation encapsulation)
        {
            this.count = count;
            this.encapsulation = encapsulation;
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
            _buffer.WriteLittleEndianTriad(count);
            encapsulation.EncodeBody(_buffer);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadLittleEndianTriad()
            //encapsulation.DecodeBody(_buffer);
        }

        public static Encapsulated FromBuffer(byte[] buffer)
        {
            var ret = new Encapsulated();
            ret.Decode(buffer);
            return ret;
        }

    }

}
