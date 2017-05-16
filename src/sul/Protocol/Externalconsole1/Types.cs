/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/externalconsole1.xml
 */
using Utils.Buffer;
using Utils.LengthPrefixedType;
using Utils.Stream;

namespace sul.Externalconsole1.Types
{

    public class Game : Stream
    {

        // type
        public const byte Pocket = 1;
        public const byte Minecraft = 2;

        public byte type;
        public uint[] protocols;

        public Game() {}

        public Game(byte type, uint[] protocols)
        {
            this.type = type;
            this.protocols = protocols;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUbyte(type);
            _buffer.WriteBigEndianUshort(protocols.Length); foreach(uint protocolsChild in protocols){ _buffer.WriteBigEndianUint(protocolsChild); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class NodeStats : Stream
    {

        public string name;
        public float tps;
        public ulong ram;
        public float cpu;

        public NodeStats() {}

        public NodeStats(string name, float tps, ulong ram, float cpu)
        {
            this.name = name;
            this.tps = tps;
            this.ram = ram;
            this.cpu = cpu;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteBigEndianFloat(tps);
            _buffer.WriteBigEndianUlong(ram);
            _buffer.WriteBigEndianFloat(cpu);
        }

        protected override void DecodeImpl(Buffer buffer)
        {




        }

    }

}
