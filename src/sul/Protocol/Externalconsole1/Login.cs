/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/externalconsole1.xml
 */
using Types = sul.Externalconsole1.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Externalconsole1
{

    public class AuthCredentials : Packet
    {

        public const byte Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte protocol;
        public bool hash;
        public string hashAlgorithm;
        public byte[] payload;

        public AuthCredentials() {}

        public AuthCredentials(byte protocol, bool hash, string hashAlgorithm, byte[] payload)
        {
            this.protocol = protocol;
            this.hash = hash;
            this.hashAlgorithm = hashAlgorithm;
            this.payload = payload;
        }

        public override int GetId()
        {
            return Id;
        }

        public override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        public override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteUbyte(protocol);
            _buffer.WriteBool(hash);
            if(hash==true){ _buffer.WriteString(hashAlgorithm); }
            if(hash==true){ foreach(byte payloadChild in payload){ _buffer.WriteUbyte(payloadChild); } }
        }

        public override void DecodeImpl(Buffer _buffer)
        {


            if(hash==true){  }
            if(hash==true){  }
        }

        public static AuthCredentials FromBuffer(byte[] buffer)
        {
            var ret = new AuthCredentials();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Auth : Packet
    {

        public const byte Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] hash;

        public Auth() {}

        public Auth(byte[] hash)
        {
            this.hash = hash;
        }

        public override int GetId()
        {
            return Id;
        }

        public override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        public override void EncodeImpl(Buffer _buffer)
        {
            foreach(byte hashChild in hash){ _buffer.WriteUbyte(hashChild); }
        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Auth FromBuffer(byte[] buffer)
        {
            var ret = new Auth();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Welcome : Packet
    {

        public const byte Id = 2;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte status;

        public Welcome() {}

        public Welcome(byte status)
        {
            this.status = status;
        }

        public override int GetId()
        {
            return Id;
        }

        public override void EncodeId(Buffer _buffer)
        {
            _buffer.WriteUbyte(Id);
        }

        public override void DecodeId(Buffer _buffer)
        {
            _buffer.ReadUbyte();
        }

        public override void EncodeImpl(Buffer _buffer)
        {
            _buffer.WriteUbyte(status);
        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Welcome FromBuffer(byte[] buffer)
        {
            var ret = new Welcome();
            ret.decode(buffer);
            return ret;
        }

    }

}
