/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/java315.xml
 */
using System.Text;

using sul.Utils;
using sul.Protocol.Java315.Types;

namespace sul.Protocol.Java315.Status
{

    public class Handshake : sul.Utils.Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // next
        public const uint STATUS = 1;
        public const uint LOGIN = 2;

        public uint protocol;
        public string serverAddress;
        public ushort serverPort;
        public uint next;

        public Handshake() : this(0, "", 0, 0) {}

        public Handshake(uint protocol, string serverAddress, ushort serverPort, uint next)
        {
            this.protocol = protocol;
            this.serverAddress = serverAddress;
            this.serverPort = serverPort;
            this.next = next;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(protocol);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(serverAddress)); _buffer.WriteString(serverAddress);
            _buffer.WriteBigEndianUshort(serverPort);
            _buffer.WriteVaruint(next);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint()
            //_buffer.ReadString()
            //_buffer.ReadBigEndianUshort()
            //_buffer.ReadVaruint()
        }

        public static Handshake FromBuffer(byte[] buffer)
        {
            var ret = new Handshake();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Request : sul.Utils.Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;



        public Request()
        {

        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {

        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {

        }

        public static Request FromBuffer(byte[] buffer)
        {
            var ret = new Request();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Response : sul.Utils.Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string json;

        public Response() : this("") {}

        public Response(string json)
        {
            this.json = json;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(json)); _buffer.WriteString(json);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
        }

        public static Response FromBuffer(byte[] buffer)
        {
            var ret = new Response();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Latency : sul.Utils.Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public long id;

        public Latency() : this(0) {}

        public Latency(long id)
        {
            this.id = id;
        }

        public override int GetId()
        {
            return (int)Id;
        }

        public override void EncodeId(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        public override void DecodeId(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteBigEndianLong(id);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadBigEndianLong()
        }

        public static Latency FromBuffer(byte[] buffer)
        {
            var ret = new Latency();
            ret.Decode(buffer);
            return ret;
        }

    }

}
