/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 */
using System.IO;
using System.Text;

namespace sul.Utils
{

    public class Buffer
    {

        private BinaryWriter writer;
        private BinaryReader reader;

        public Buffer(BinaryWriter writer)
        {
            this.writer = writer;
        }

        public Buffer(BinaryReader reader)
        {
            this.reader = reader;
        }

        public byte[] ToArray()
        {
            return ((MemoryStream)writer.BaseStream).ToArray();
        }

        // writing

        public void WriteBytes(byte[] value)
        {
            this.writer.Write(value);
        }

        public void WriteString(string value)
        {
            WriteBytes(Encoding.UTF8.GetBytes(value));
        }

        public void WriteBool(bool value)
        {
            this.writer.Write(value);
        }

        public void WriteByte(sbyte value)
        {
            this.writer.Write(value);
        }

        public void WriteUbyte(byte value)
        {
            this.writer.Write(value);
        }

        public void WriteBigEndianShort(short value) {

        }

        public void WriteLittleEndianShort(short value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianUshort(ushort value) {}

        public void WriteLittleEndianUshort(ushort value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianUshort(int value)
        {
            WriteBigEndianUshort((ushort)value);
        }

        public void WriteLittleEndianUshort(int value)
        {
            WriteLittleEndianUshort((ushort)value);
        }

        public void WriteBigEndianTriad(int value) {}

        public void WriteLittleEndianTriad(int value) {

        }

        public void WriteBigEndianInt(int value) {}

        public void WriteLittleEndianInt(int value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianUint(uint value) {}

        public void WriteLittleEndianUint(uint value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianUint(int value)
        {
            WriteBigEndianUint((uint)value);
        }

        public void WriteLittleEndianUint(int value)
        {
            WriteLittleEndianUint((uint)value);
        }

        public void WriteBigEndianLong(long value) {}

        public void WriteLittleEndianLong(long value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianUlong(ulong value) {}

        public void WriteLittleEndianUlong(ulong value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianFloat(float value) {}

        public void WriteLittleEndianFloat(float value) {
            this.writer.Write(value);
        }

        public void WriteBigEndianDouble(double value) {}

        public void WriteLittleEndianDouble(double value) {
            this.writer.Write(value);
        }

        public void WriteVarshort(short value) {}

        public void WriteVarushort(ushort value) {}

        public void WriteVarint(int value) {}

        public void WriteVaruint(uint value) {}

        public void WriteVaruint(int value)
        {
            WriteVaruint((uint)value);
        }

        public void WriteVarlong(long value) {}

        public void WriteVarulong(ulong value) {}

        public void WriteUuid(System.Guid value) {
            WriteBytes(value.ToByteArray());
        }

        // reading

        public byte[] ReadBytes(int length)
        {
            return reader.ReadBytes(length);
        }

        public bool ReadBool()
        {
            return reader.ReadBoolean();
        }

        public sbyte ReadByte()
        {
            return reader.ReadSByte();
        }

        public byte ReadUbyte()
        {
            return reader.ReadByte();
        }

        public uint ReadVaruint()
        {
            return 0; //TODO
        }

        public System.Guid readUuid()
        {
            return new System.Guid(ReadBytes(16));
        }

        //

        public static Buffer Writer()
        {
            return new Buffer(new BinaryWriter(new MemoryStream()));
        }

        public static Buffer Reader(byte[] _buffer)
        {
            return new Buffer(new BinaryReader(new MemoryStream(_buffer)));
        }

    }

}
