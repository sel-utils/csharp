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
using sul.Protocol.Externalconsole2.Types;

namespace sul.Protocol.Externalconsole2.Connected
{

    public class ConsoleMessage : sul.Utils.Packet
    {

        public const byte Id = 4;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string node;
        public ulong timestamp;
        public string logger;
        public string message;
        public int commandId;

        public ConsoleMessage() : this("", 0, "", "", 0) {}

        public ConsoleMessage(string node, ulong timestamp, string logger, string message, int commandId)
        {
            this.node = node;
            this.timestamp = timestamp;
            this.logger = logger;
            this.message = message;
            this.commandId = commandId;
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
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(node)); _buffer.WriteString(node);
            _buffer.WriteBigEndianUlong(timestamp);
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(logger)); _buffer.WriteString(logger);
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(message)); _buffer.WriteString(message);
            _buffer.WriteBigEndianInt(commandId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadBigEndianUlong()
            //_buffer.ReadString()
            //_buffer.ReadString()
            //_buffer.ReadBigEndianInt()
        }

        public static ConsoleMessage FromBuffer(byte[] buffer)
        {
            var ret = new ConsoleMessage();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class Command : sul.Utils.Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string command;
        public uint commandId;

        public Command() : this("", 0) {}

        public Command(string command, uint commandId)
        {
            this.command = command;
            this.commandId = commandId;
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
            _buffer.WriteBigEndianUshort(Encoding.UTF8.GetByteCount(command)); _buffer.WriteString(command);
            _buffer.WriteBigEndianUint(commandId);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadBigEndianUint()
        }

        public static Command FromBuffer(byte[] buffer)
        {
            var ret = new Command();
            ret.Decode(buffer);
            return ret;
        }

    }

    public class PermissionDenied : sul.Utils.Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;



        public PermissionDenied()
        {

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

        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {

        }

        public static PermissionDenied FromBuffer(byte[] buffer)
        {
            var ret = new PermissionDenied();
            ret.Decode(buffer);
            return ret;
        }

    }

}
