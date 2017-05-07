/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 */
using Utils.Buffer;

namespace Utils
{

    public abstract class Stream
    {

        public byte[] Encode()
        {
            var buffer = Buffer.Writer();
            EncodeImpl(buffer);
            return buffer.buffer;
        }

        public Stream Decode(byte[] _buffer)
        {
            var buffer = Buffer.Reader(_buffer);
            DecodeImpl(buffer);
            return this;
        }

        public void EncodeBody(Buffer buffer)
        {
            EncodeImpl(buffer);
        }

        public void DecodeBody(Buffer buffer)
        {
            DecodeImpl(buffer);
        }

        protected abstract void EncodeImpl(Buffer buffer);

        protected abstract void DecodeImpl(Buffer buffer);

    }

}
