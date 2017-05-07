/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/externalconsole2.xml
 */
using Types = sul.Externalconsole2.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Externalconsole2
{

    public class ConsoleMessage : Packet
    {

        public const byte Id = 4;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string node;
        public ulong timestamp;
        public string logger;
        public string message;
        public int commandId;

        public ConsoleMessage() {}

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
            _buffer.WriteString(node);
            _buffer.WriteBigEndianUlong(timestamp);
            _buffer.WriteString(logger);
            _buffer.WriteString(message);
            _buffer.WriteBigEndianInt(commandId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {





        }

        public static ConsoleMessage FromBuffer(byte[] buffer)
        {
            var ret = new ConsoleMessage();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Command : Packet
    {

        public const byte Id = 5;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string command;
        public uint commandId;

        public Command() {}

        public Command(string command, uint commandId)
        {
            this.command = command;
            this.commandId = commandId;
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
            _buffer.WriteString(command);
            _buffer.WriteBigEndianUint(commandId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static Command FromBuffer(byte[] buffer)
        {
            var ret = new Command();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PermissionDenied : Packet
    {

        public const byte Id = 6;

        public const bool Clientbound = true;
        public const bool Serverbound = false;



        public PermissionDenied() {}

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

        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static PermissionDenied FromBuffer(byte[] buffer)
        {
            var ret = new PermissionDenied();
            ret.decode(buffer);
            return ret;
        }

    }

}
