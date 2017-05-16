/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/hncom2.xml
 */
using Types = sul.Hncom2.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Hncom2.Panel
{

    public class Connection : Packet
    {

        public const byte Id = 36;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[64] hash;
        public byte[] address;
        public uint worldId;

        public Connection() {}

        public Connection(byte[64] hash, byte[] address, uint worldId)
        {
            this.hash = hash;
            this.address = address;
            this.worldId = worldId;
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
            foreach(byte hashChild in hash){ _buffer.WriteUbyte(hashChild); }
            _buffer.WriteVaruint(address.Length); _buffer.WriteBytes(address);
            _buffer.WriteVaruint(worldId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {



        }

        public static Connection FromBuffer(byte[] buffer)
        {
            var ret = new Connection();
            ret.decode(buffer);
            return ret;
        }

    }

}
