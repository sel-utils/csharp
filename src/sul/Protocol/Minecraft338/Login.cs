/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft338.xml
 */
using System.Text;

using sul.Utils;
using sul.Protocol.Minecraft338.Types;

namespace sul.Protocol.Minecraft338.Login
{

    public class Disconnect : sul.Utils.Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string reason;

        public Disconnect() : this("") {}

        public Disconnect(string reason)
        {
            this.reason = reason;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(reason)); _buffer.WriteString(reason);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
        }

        public static Disconnect FromBuffer(byte[] buffer)
        {
            var ret = new Disconnect();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class LoginStart : sul.Utils.Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string username;

        public LoginStart() : this("") {}

        public LoginStart(string username)
        {
            this.username = username;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(username)); _buffer.WriteString(username);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
        }

        public static LoginStart FromBuffer(byte[] buffer)
        {
            var ret = new LoginStart();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class EncryptionRequest : sul.Utils.Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string serverId;
        public byte[] publicKey;
        public byte[] verifyToken;

        public EncryptionRequest() : this("", new byte[]{}, new byte[]{}) {}

        public EncryptionRequest(string serverId, byte[] publicKey, byte[] verifyToken)
        {
            this.serverId = serverId;
            this.publicKey = publicKey;
            this.verifyToken = verifyToken;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(serverId)); _buffer.WriteString(serverId);
            _buffer.WriteVaruint(publicKey.Length); _buffer.WriteBytes(publicKey);
            _buffer.WriteVaruint(verifyToken.Length); _buffer.WriteBytes(verifyToken);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //publicKey.DecodeBody(_buffer);
            //verifyToken.DecodeBody(_buffer);
        }

        public static EncryptionRequest FromBuffer(byte[] buffer)
        {
            var ret = new EncryptionRequest();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class EncryptionResponse : sul.Utils.Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] sharedSecret;
        public byte[] verifyToken;

        public EncryptionResponse() : this(new byte[]{}, new byte[]{}) {}

        public EncryptionResponse(byte[] sharedSecret, byte[] verifyToken)
        {
            this.sharedSecret = sharedSecret;
            this.verifyToken = verifyToken;
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
            _buffer.WriteVaruint(sharedSecret.Length); _buffer.WriteBytes(sharedSecret);
            _buffer.WriteVaruint(verifyToken.Length); _buffer.WriteBytes(verifyToken);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //sharedSecret.DecodeBody(_buffer);
            //verifyToken.DecodeBody(_buffer);
        }

        public static EncryptionResponse FromBuffer(byte[] buffer)
        {
            var ret = new EncryptionResponse();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class LoginSuccess : sul.Utils.Packet
    {

        public const uint Id = 2;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string uuid;
        public string username;

        public LoginSuccess() : this("", "") {}

        public LoginSuccess(string uuid, string username)
        {
            this.uuid = uuid;
            this.username = username;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(uuid)); _buffer.WriteString(uuid);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(username)); _buffer.WriteString(username);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadString()
        }

        public static LoginSuccess FromBuffer(byte[] buffer)
        {
            var ret = new LoginSuccess();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class SetCompression : sul.Utils.Packet
    {

        public const uint Id = 3;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint thresold;

        public SetCompression() : this(0) {}

        public SetCompression(uint thresold)
        {
            this.thresold = thresold;
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
            _buffer.WriteVaruint(thresold);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint()
        }

        public static SetCompression FromBuffer(byte[] buffer)
        {
            var ret = new SetCompression();
            ret.Decode(buffer);
            return ret;
        }

    }

}
