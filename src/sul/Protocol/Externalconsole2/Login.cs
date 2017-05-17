/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/externalconsole2.xml
 */
using System.Text;

using sul.Utils;
using sul.Externalconsole2.Types;

namespace sul.Externalconsole2.Login
{

    public class AuthCredentials : sul.Utils.Packet
    {

        public const byte Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte protocol;
        public bool hash;
        public string hashAlgorithm;
        public byte[] payload;

        public AuthCredentials() : this(0, false, "", new byte[]{}) {}

        public AuthCredentials(byte protocol, bool hash, string hashAlgorithm, byte[] payload)
        {
            this.protocol = protocol;
            this.hash = hash;
            this.hashAlgorithm = hashAlgorithm;
            this.payload = payload;
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
            _buffer.WriteUbyte(protocol);
            _buffer.WriteBool(hash);
            if(hash==true){ _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(hashAlgorithm)); _buffer.WriteString(hashAlgorithm); }
            if(hash==true){ _buffer.WriteBigEndianUshort(payload.Length); _buffer.WriteBytes(payload); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //protocol = _buffer.ReadUbyte();
            //hash = _buffer.ReadBool();
            //if(hash==true){ hashAlgorithm = _buffer.ReadString(); }
            //if(hash==true){ payload.DecodeBody(_buffer); }
        }

        public static AuthCredentials FromBuffer(byte[] buffer)
        {
            var ret = new AuthCredentials();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Auth : sul.Utils.Packet
    {

        public const byte Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] hash;

        public Auth() : this(new byte[]{}) {}

        public Auth(byte[] hash)
        {
            this.hash = hash;
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
            _buffer.WriteBigEndianUshort(hash.Length); _buffer.WriteBytes(hash);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hash.DecodeBody(_buffer);
        }

        public static Auth FromBuffer(byte[] buffer)
        {
            var ret = new Auth();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Welcome : sul.Utils.Packet
    {

        public const byte Id = 2;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte status;

        public Welcome() : this(0) {}

        public Welcome(byte status)
        {
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
            _buffer.WriteUbyte(status);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //status = _buffer.ReadUbyte();
        }

        public static Welcome FromBuffer(byte[] buffer)
        {
            var ret = new Welcome();
            ret.Decode(buffer);
            return ret;
        }

        public AcceptedVariant Accepted(bool remoteCommands, string software, byte[] versions, string displayName, Game[] games, string[] connectedNodes)
        {
            var _variant = new AcceptedVariant(this);
            _variant.remoteCommands = remoteCommands;
            _variant.software = software;
            _variant.versions = versions;
            _variant.displayName = displayName;
            _variant.games = games;
            _variant.connectedNodes = connectedNodes;
            return _variant;
        }

        public sealed class AcceptedVariant : sul.Utils.Variant
        {

            private Welcome _parent;

            public bool remoteCommands;
            public string software;
            public byte[] versions;
            public string displayName;
            public Game[] games;
            public string[] connectedNodes;

            public AcceptedVariant(Welcome parent) : base(parent)
            {
                this._parent = parent;
                this._parent.status = 0;
            }

            protected override void EncodeImpl(sul.Utils.Buffer _buffer)
            {
                _parent.EncodeImpl(_buffer);
                _buffer.WriteBool(remoteCommands);
                _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(software)); _buffer.WriteString(software);
                foreach (byte versionsChild in versions){ _buffer.WriteUbyte(versionsChild); }
                _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName);
                _buffer.WriteBigEndianUshort(games.Length); foreach (Game gamesChild in games){ gamesChild.EncodeBody(_buffer); }
                _buffer.WriteBigEndianUshort(connectedNodes.Length); foreach (string connectedNodesChild in connectedNodes){ _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(connectedNodesChild)); _buffer.WriteString(connectedNodesChild); }
            }

            protected override void DecodeImpl(sul.Utils.Buffer _buffer)
            {
                //TODO
            }

        }

        public WrongHashVariant WrongHash()
        {
            var _variant = new WrongHashVariant(this);

            return _variant;
        }

        public sealed class WrongHashVariant : sul.Utils.Variant
        {

            private Welcome _parent;



            public WrongHashVariant(Welcome parent) : base(parent)
            {
                this._parent = parent;
                this._parent.status = 1;
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

        public TimedOutVariant TimedOut()
        {
            var _variant = new TimedOutVariant(this);

            return _variant;
        }

        public sealed class TimedOutVariant : sul.Utils.Variant
        {

            private Welcome _parent;



            public TimedOutVariant(Welcome parent) : base(parent)
            {
                this._parent = parent;
                this._parent.status = 2;
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

}
