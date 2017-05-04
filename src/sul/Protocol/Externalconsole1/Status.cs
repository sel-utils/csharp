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

    public class KeepAlive : Packet
    {

        public const byte Id = 0;

        public const bool Clientbound = true;
        public const bool Serverbound = true;

        public uint count;

        public KeepAlive() {}

        public KeepAlive(uint count)
        {
            this.count = count;
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
            _buffer.WriteBigEndianUint(count);
        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static KeepAlive FromBuffer(byte[] buffer)
        {
            var ret = new KeepAlive();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateNodes : Packet
    {

        public const byte Id = 1;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        // action
        public const byte Add = 0;
        public const byte Remove = 1;

        public byte action;
        public string node;

        public UpdateNodes() {}

        public UpdateNodes(byte action, string node)
        {
            this.action = action;
            this.node = node;
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
            _buffer.WriteUbyte(action);
            _buffer.WriteString(node);
        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static UpdateNodes FromBuffer(byte[] buffer)
        {
            var ret = new UpdateNodes();
            ret.decode(buffer);
            return ret;
        }

    }

    public class RequestStats : Packet
    {

        public const byte Id = 2;

        public const bool Clientbound = false;
        public const bool Serverbound = true;



        public RequestStats() {}

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

        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static RequestStats FromBuffer(byte[] buffer)
        {
            var ret = new RequestStats();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateStats : Packet
    {

        public const byte Id = 3;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public uint onlinePlayers;
        public uint maxPlayers;
        public uint uptime;
        public uint upload;
        public uint download;
        public Types.NodeStats[] nodes;

        public UpdateStats() {}

        public UpdateStats(uint onlinePlayers, uint maxPlayers, uint uptime, uint upload, uint download, Types.NodeStats[] nodes)
        {
            this.onlinePlayers = onlinePlayers;
            this.maxPlayers = maxPlayers;
            this.uptime = uptime;
            this.upload = upload;
            this.download = download;
            this.nodes = nodes;
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
            _buffer.WriteBigEndianUint(onlinePlayers);
            _buffer.WriteBigEndianUint(maxPlayers);
            _buffer.WriteBigEndianUint(uptime);
            _buffer.WriteBigEndianUint(upload);
            _buffer.WriteBigEndianUint(download);
            foreach(Types.NodeStats nodesChild in nodes){ nodesChild.EncodeImpl(_buffer); }
        }

        public override void DecodeImpl(Buffer _buffer)
        {

        }

        public static UpdateStats FromBuffer(byte[] buffer)
        {
            var ret = new UpdateStats();
            ret.decode(buffer);
            return ret;
        }

    }

}
