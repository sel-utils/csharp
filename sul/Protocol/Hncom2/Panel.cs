/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/hncom2.xml
 */
using System.Text;

using sul.Utils;
using sul.Protocol.Hncom2.Types;

namespace sul.Protocol.Hncom2.Panel
{

    public class Connection : sul.Utils.Packet
    {

        public const byte Id = 36;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public byte[] hash;
        public byte[] address;
        public uint worldId;

        public Connection() : this(new byte[64], new byte[]{}, 0) {}

        public Connection(byte[] hash, byte[] address, uint worldId)
        {
            this.hash = hash;
            this.address = address;
            this.worldId = worldId;
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
            foreach (byte hashChild in hash){ _buffer.WriteUbyte(hashChild); }
            _buffer.WriteVaruint(address.Length); _buffer.WriteBytes(address);
            _buffer.WriteVaruint(worldId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //hash.DecodeBody(_buffer);
            //address.DecodeBody(_buffer);
            //_buffer.ReadVaruint()
        }

        public static Connection FromBuffer(byte[] buffer)
        {
            var ret = new Connection();
            ret.Decode(buffer);
            return ret;
        }

    }

}
