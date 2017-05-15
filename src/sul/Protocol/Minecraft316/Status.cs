/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft316.xml
 */
using Types = sul.Minecraft316.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Minecraft316
{

    public class Handshake : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // next
        public const uint Status = 1;
        public const uint Login = 2;

        public uint protocol;
        public string serverAddress;
        public ushort serverPort;
        public uint next;

        public Handshake() {}

        public Handshake(uint protocol, string serverAddress, ushort serverPort, uint next)
        {
            this.protocol = protocol;
            this.serverAddress = serverAddress;
            this.serverPort = serverPort;
            this.next = next;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadVaruint();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(protocol);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(serverAddress)); _buffer.WriteString(serverAddress);
            _buffer.WriteBigEndianUshort(serverPort);
            _buffer.WriteVaruint(next);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {




        }

        public static Handshake FromBuffer(byte[] buffer)
        {
            var ret = new Handshake();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Request : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;



        public Request() {}

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadVaruint();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {

        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Request FromBuffer(byte[] buffer)
        {
            var ret = new Request();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Response : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string json;

        public Response() {}

        public Response(string json)
        {
            this.json = json;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadVaruint();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(json)); _buffer.WriteString(json);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Response FromBuffer(byte[] buffer)
        {
            var ret = new Response();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Latency : Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public long id;

        public Latency() {}

        public Latency(long id)
        {
            this.id = id;
        }

        public override int GetId()
        {
            return Id;
        }

        protected override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteVaruint(Id);
        }

        protected override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadVaruint();
        }

        protected override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteBigEndianLong(id);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Latency FromBuffer(byte[] buffer)
        {
            var ret = new Latency();
            ret.decode(buffer);
            return ret;
        }

    }

}
