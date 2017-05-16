/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft315.xml
 */
using Types = sul.Minecraft315.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Minecraft315.Login
{

    public class Disconnect : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string reason;

        public Disconnect() {}

        public Disconnect(string reason)
        {
            this.reason = reason;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(reason)); _buffer.WriteString(reason);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Disconnect FromBuffer(byte[] buffer)
        {
            var ret = new Disconnect();
            ret.decode(buffer);
            return ret;
        }

    }

    public class LoginStart : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string username;

        public LoginStart() {}

        public LoginStart(string username)
        {
            this.username = username;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(username)); _buffer.WriteString(username);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static LoginStart FromBuffer(byte[] buffer)
        {
            var ret = new LoginStart();
            ret.decode(buffer);
            return ret;
        }

    }

    public class EncryptionRequest : Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string serverId;
        public byte[] publicKey;
        public byte[] verifyToken;

        public EncryptionRequest() {}

        public EncryptionRequest(string serverId, byte[] publicKey, byte[] verifyToken)
        {
            this.serverId = serverId;
            this.publicKey = publicKey;
            this.verifyToken = verifyToken;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(serverId)); _buffer.WriteString(serverId);
            _buffer.WriteVaruint(publicKey.Length); _buffer.WriteBytes(publicKey);
            _buffer.WriteVaruint(verifyToken.Length); _buffer.WriteBytes(verifyToken);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {



        }

        public static EncryptionRequest FromBuffer(byte[] buffer)
        {
            var ret = new EncryptionRequest();
            ret.decode(buffer);
            return ret;
        }

    }

    public class EncryptionResponse : Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte[] sharedSecret;
        public byte[] verifyToken;

        public EncryptionResponse() {}

        public EncryptionResponse(byte[] sharedSecret, byte[] verifyToken)
        {
            this.sharedSecret = sharedSecret;
            this.verifyToken = verifyToken;
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
            _buffer.WriteVaruint(sharedSecret.Length); _buffer.WriteBytes(sharedSecret);
            _buffer.WriteVaruint(verifyToken.Length); _buffer.WriteBytes(verifyToken);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static EncryptionResponse FromBuffer(byte[] buffer)
        {
            var ret = new EncryptionResponse();
            ret.decode(buffer);
            return ret;
        }

    }

    public class LoginSuccess : Packet
    {

        public const uint Id = 2;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string uuid;
        public string username;

        public LoginSuccess() {}

        public LoginSuccess(string uuid, string username)
        {
            this.uuid = uuid;
            this.username = username;
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
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(uuid)); _buffer.WriteString(uuid);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(username)); _buffer.WriteString(username);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static LoginSuccess FromBuffer(byte[] buffer)
        {
            var ret = new LoginSuccess();
            ret.decode(buffer);
            return ret;
        }

    }

    public class SetCompression : Packet
    {

        public const uint Id = 3;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint thresold;

        public SetCompression() {}

        public SetCompression(uint thresold)
        {
            this.thresold = thresold;
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
            _buffer.WriteVaruint(thresold);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static SetCompression FromBuffer(byte[] buffer)
        {
            var ret = new SetCompression();
            ret.decode(buffer);
            return ret;
        }

    }

}
