/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft110.xml
 */
using Utils.Buffer;
using Utils.LengthPrefixedType;
using Utils.Stream;

namespace sul.Minecraft110.Types
{

    public class Statistic : Stream
    {

        public string name;
        public uint @value;

        public Statistic() {}

        public Statistic(string name, uint @value)
        {
            this.name = name;
            this.@value = @value;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(@value);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class BlockChange : Stream
    {

        public byte xz;
        public byte y;
        public uint block;

        public BlockChange() {}

        public BlockChange(byte xz, byte y, uint block)
        {
            this.xz = xz;
            this.y = y;
            this.block = block;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUbyte(xz);
            _buffer.WriteUbyte(y);
            _buffer.WriteVaruint(block);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class Slot : Stream
    {

        public short id;
        public byte count;
        public ushort damage;
        public byte[] nbt;

        public Slot() {}

        public Slot(short id, byte count, ushort damage, byte[] nbt)
        {
            this.id = id;
            this.count = count;
            this.damage = damage;
            this.nbt = nbt;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteBigEndianShort(id);
            if(id>0){ _buffer.WriteUbyte(count); }
            if(id>0){ _buffer.WriteBigEndianUshort(damage); }
            if(id>0){ _buffer.WriteBytes(nbt); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {

            if(id>0){  }
            if(id>0){  }
            if(id>0){  }
        }

    }

    public class Icon : Stream
    {

        // direction and type
        public const byte WhiteArrow = 0;
        public const byte GreenArrow = 1;
        public const byte RedArrow = 2;
        public const byte BlueArrow = 3;
        public const byte WhiteCross = 4;
        public const byte RedPointer = 5;
        public const byte WhiteCircle = 6;

        public byte directionAndType;
        public Tuple<byte, byte> position;

        public Icon() {}

        public Icon(byte directionAndType, Tuple<byte, byte> position)
        {
            this.directionAndType = directionAndType;
            this.position = position;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUbyte(directionAndType);
            _buffer.WriteUbyte(position[0]); _buffer.WriteUbyte(position[1]);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class Property : Stream
    {

        public string name;
        public string @value;
        public bool signed;
        public string signature;

        public Property() {}

        public Property(string name, string @value, bool signed, string signature)
        {
            this.name = name;
            this.@value = @value;
            this.signed = signed;
            this.signature = signature;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(@value)); _buffer.WriteString(@value);
            _buffer.WriteBool(signed);
            if(signed==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(signature)); _buffer.WriteString(signature); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {



            if(signed==true){  }
        }

    }

    public class ListAddPlayer : Stream
    {

        // gamemode
        public const uint Survival = 0;
        public const uint Creative = 1;
        public const uint Adventure = 2;
        public const uint Spectator = 3;

        public Guid uuid;
        public string name;
        public Types.Property[] properties;
        public uint gamemode;
        public uint latency;
        public bool hasDisplayName;
        public string displayName;

        public ListAddPlayer() {}

        public ListAddPlayer(Guid uuid, string name, Types.Property[] properties, uint gamemode, uint latency, bool hasDisplayName, string displayName)
        {
            this.uuid = uuid;
            this.name = name;
            this.properties = properties;
            this.gamemode = gamemode;
            this.latency = latency;
            this.hasDisplayName = hasDisplayName;
            this.displayName = displayName;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(properties.Length); foreach(Types.Property propertiesChild in properties){ propertiesChild.EncodeBody(_buffer); }
            _buffer.WriteVaruint(gamemode);
            _buffer.WriteVaruint(latency);
            _buffer.WriteBool(hasDisplayName);
            if(hasDisplayName==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {






            if(hasDisplayName==true){  }
        }

    }

    public class ListUpdateGamemode : Stream
    {

        // gamemode
        public const uint Survival = 0;
        public const uint Creative = 1;
        public const uint Adventure = 2;
        public const uint Spectator = 3;

        public Guid uuid;
        public uint gamemode;

        public ListUpdateGamemode() {}

        public ListUpdateGamemode(Guid uuid, uint gamemode)
        {
            this.uuid = uuid;
            this.gamemode = gamemode;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(gamemode);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class ListUpdateLatency : Stream
    {

        public Guid uuid;
        public uint latency;

        public ListUpdateLatency() {}

        public ListUpdateLatency(Guid uuid, uint latency)
        {
            this.uuid = uuid;
            this.latency = latency;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(latency);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class ListUpdateDisplayName : Stream
    {

        public Guid uuid;
        public bool hasDisplayName;
        public string displayName;

        public ListUpdateDisplayName() {}

        public ListUpdateDisplayName(Guid uuid, bool hasDisplayName, string displayName)
        {
            this.uuid = uuid;
            this.hasDisplayName = hasDisplayName;
            this.displayName = displayName;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteBool(hasDisplayName);
            if(hasDisplayName==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {


            if(hasDisplayName==true){  }
        }

    }

    public class Modifier : Stream
    {

        // operation
        public const byte AddSubstractAmount = 0;
        public const byte AddSubstractAmountPercentage = 1;
        public const byte MultiplyAmountPercentage = 2;

        public Guid uuid;
        public double amount;
        public byte operation;

        public Modifier() {}

        public Modifier(Guid uuid, double amount, byte operation)
        {
            this.uuid = uuid;
            this.amount = amount;
            this.operation = operation;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteBigEndianDouble(amount);
            _buffer.WriteUbyte(operation);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class Attribute : Stream
    {

        public string key;
        public double @value;
        public Types.Modifier[] modifiers;

        public Attribute() {}

        public Attribute(string key, double @value, Types.Modifier[] modifiers)
        {
            this.key = key;
            this.@value = @value;
            this.modifiers = modifiers;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(key)); _buffer.WriteString(key);
            _buffer.WriteBigEndianDouble(@value);
            _buffer.WriteVaruint(modifiers.Length); foreach(Types.Modifier modifiersChild in modifiers){ modifiersChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class OptionalPosition : Stream
    {

        public bool hasPosition;
        public ulong position;

        public OptionalPosition() {}

        public OptionalPosition(bool hasPosition, ulong position)
        {
            this.hasPosition = hasPosition;
            this.position = position;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteBool(hasPosition);
            if(hasPosition==true){ _buffer.WriteBigEndianUlong(position); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {

            if(hasPosition==true){  }
        }

    }

    public class OptionalUuid : Stream
    {

        public bool hasUuid;
        public Guid uuid;

        public OptionalUuid() {}

        public OptionalUuid(bool hasUuid, Guid uuid)
        {
            this.hasUuid = hasUuid;
            this.uuid = uuid;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteBool(hasUuid);
            _buffer.WriteUuid(uuid);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

}
