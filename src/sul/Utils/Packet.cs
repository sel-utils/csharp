/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 */
namespace sul.Utils
{

    public abstract class Packet : Stream
    {

        public abstract int GetId();

        public byte[] EncodeWithoutId()
        {
            return base.Encode();
        }

        public Stream DecodeWithoutId(byte[] _buffer)
        {
            return base.Decode(_buffer);
        }

        public override byte[] Encode()
        {
            var buffer = Buffer.Writer();
            EncodeId(buffer);
            EncodeBody(buffer);
            return buffer.ToArray();
        }

        public override Stream Decode(byte[] _buffer)
        {
            var buffer = Buffer.Reader(_buffer);
            DecodeId(buffer);
            DecodeBody(buffer);
            return this;
        }

        protected abstract void EncodeId(Buffer buffer);

        protected abstract void DecodeId(Buffer buffer);

    }

}
