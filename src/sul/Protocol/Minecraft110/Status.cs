/*
 * This file was automatically generated by sel-utils and
 * released under the GNU General Public License version 3.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft110.xml
 */
using Types = sul.Minecraft110.Types;

namespace sul.Minecraft110
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

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
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

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
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

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
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

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static Latency FromBuffer(byte[] buffer)
        {
            var ret = new Latency();
            ret.decode(buffer);
            return ret;
        }

    }

}
