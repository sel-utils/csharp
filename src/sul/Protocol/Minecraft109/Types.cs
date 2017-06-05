/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft109.xml
 */
using System.Text;

namespace sul.Protocol.Minecraft109.Types
{

    public class Statistic : sul.Utils.Stream
    {

        public string name;
        public uint @value;

        public Statistic() : this("", 0) {}

        public Statistic(string name, uint @value)
        {
            this.name = name;
            this.@value = @value;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(@value);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadVaruint()
        }

    }

    public class BlockChange : sul.Utils.Stream
    {

        public byte xz;
        public byte y;
        public uint block;

        public BlockChange() : this(0, 0, 0) {}

        public BlockChange(byte xz, byte y, uint block)
        {
            this.xz = xz;
            this.y = y;
            this.block = block;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(xz);
            _buffer.WriteUbyte(y);
            _buffer.WriteVaruint(block);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte()
            //_buffer.ReadUbyte()
            //_buffer.ReadVaruint()
        }

    }

    public class Slot : sul.Utils.Stream
    {

        public short id;
        public byte count;
        public ushort damage;
        public byte[] nbt;

        public Slot() : this(0, 0, 0, new byte[]{}) {}

        public Slot(short id, byte count, ushort damage, byte[] nbt)
        {
            this.id = id;
            this.count = count;
            this.damage = damage;
            this.nbt = nbt;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteBigEndianShort(id);
            if(id>0){ _buffer.WriteUbyte(count); }
            if(id>0){ _buffer.WriteBigEndianUshort(damage); }
            if(id>0){ _buffer.WriteBytes(nbt); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadBigEndianShort()
            //if(id>0){ _buffer.ReadUbyte() }
            //if(id>0){ _buffer.ReadBigEndianUshort() }
            //if(id>0){ _buffer.ReadBytes() }
        }

    }

    public class Icon : sul.Utils.Stream
    {

        // direction and type
        public const byte WHITE_ARROW = 0;
        public const byte GREEN_ARROW = 1;
        public const byte RED_ARROW = 2;
        public const byte BLUE_ARROW = 3;
        public const byte WHITE_CROSS = 4;
        public const byte RED_POINTER = 5;
        public const byte WHITE_CIRCLE = 6;

        public byte directionAndType;
        public System.Tuple<byte, byte> position;

        public Icon() : this(0, null) {}

        public Icon(byte directionAndType, System.Tuple<byte, byte> position)
        {
            this.directionAndType = directionAndType;
            this.position = position;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(directionAndType);
            _buffer.WriteUbyte(position.Item1); _buffer.WriteUbyte(position.Item2);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte()
            //_buffer.ReadUbyte() _buffer.ReadUbyte()
        }

    }

    public class Property : sul.Utils.Stream
    {

        public string name;
        public string @value;
        public bool signed;
        public string signature;

        public Property() : this("", "", false, "") {}

        public Property(string name, string @value, bool signed, string signature)
        {
            this.name = name;
            this.@value = @value;
            this.signed = signed;
            this.signature = signature;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(@value)); _buffer.WriteString(@value);
            _buffer.WriteBool(signed);
            if(signed==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(signature)); _buffer.WriteString(signature); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadString()
            //_buffer.ReadBool()
            //if(signed==true){ _buffer.ReadString() }
        }

    }

    public class ListAddPlayer : sul.Utils.Stream
    {

        // gamemode
        public const uint SURVIVAL = 0;
        public const uint CREATIVE = 1;
        public const uint ADVENTURE = 2;
        public const uint SPECTATOR = 3;

        public System.Guid uuid;
        public string name;
        public Property[] properties;
        public uint gamemode;
        public uint latency;
        public bool hasDisplayName;
        public string displayName;

        public ListAddPlayer() : this(System.Guid.Empty, "", new Property[]{}, 0, 0, false, "") {}

        public ListAddPlayer(System.Guid uuid, string name, Property[] properties, uint gamemode, uint latency, bool hasDisplayName, string displayName)
        {
            this.uuid = uuid;
            this.name = name;
            this.properties = properties;
            this.gamemode = gamemode;
            this.latency = latency;
            this.hasDisplayName = hasDisplayName;
            this.displayName = displayName;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(properties.Length); foreach (Property propertiesChild in properties){ propertiesChild.EncodeBody(_buffer); }
            _buffer.WriteVaruint(gamemode);
            _buffer.WriteVaruint(latency);
            _buffer.WriteBool(hasDisplayName);
            if(hasDisplayName==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUuid()
            //_buffer.ReadString()
            //properties.DecodeBody(_buffer);
            //_buffer.ReadVaruint()
            //_buffer.ReadVaruint()
            //_buffer.ReadBool()
            //if(hasDisplayName==true){ _buffer.ReadString() }
        }

    }

    public class ListUpdateGamemode : sul.Utils.Stream
    {

        // gamemode
        public const uint SURVIVAL = 0;
        public const uint CREATIVE = 1;
        public const uint ADVENTURE = 2;
        public const uint SPECTATOR = 3;

        public System.Guid uuid;
        public uint gamemode;

        public ListUpdateGamemode() : this(System.Guid.Empty, 0) {}

        public ListUpdateGamemode(System.Guid uuid, uint gamemode)
        {
            this.uuid = uuid;
            this.gamemode = gamemode;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(gamemode);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUuid()
            //_buffer.ReadVaruint()
        }

    }

    public class ListUpdateLatency : sul.Utils.Stream
    {

        public System.Guid uuid;
        public uint latency;

        public ListUpdateLatency() : this(System.Guid.Empty, 0) {}

        public ListUpdateLatency(System.Guid uuid, uint latency)
        {
            this.uuid = uuid;
            this.latency = latency;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVaruint(latency);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUuid()
            //_buffer.ReadVaruint()
        }

    }

    public class ListUpdateDisplayName : sul.Utils.Stream
    {

        public System.Guid uuid;
        public bool hasDisplayName;
        public string displayName;

        public ListUpdateDisplayName() : this(System.Guid.Empty, false, "") {}

        public ListUpdateDisplayName(System.Guid uuid, bool hasDisplayName, string displayName)
        {
            this.uuid = uuid;
            this.hasDisplayName = hasDisplayName;
            this.displayName = displayName;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteBool(hasDisplayName);
            if(hasDisplayName==true){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUuid()
            //_buffer.ReadBool()
            //if(hasDisplayName==true){ _buffer.ReadString() }
        }

    }

    public class Modifier : sul.Utils.Stream
    {

        // operation
        public const byte ADD_SUBSTRACT_AMOUNT = 0;
        public const byte ADD_SUBSTRACT_AMOUNT_PERCENTAGE = 1;
        public const byte MULTIPLY_AMOUNT_PERCENTAGE = 2;

        public System.Guid uuid;
        public double amount;
        public byte operation;

        public Modifier() : this(System.Guid.Empty, 0, 0) {}

        public Modifier(System.Guid uuid, double amount, byte operation)
        {
            this.uuid = uuid;
            this.amount = amount;
            this.operation = operation;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteBigEndianDouble(amount);
            _buffer.WriteUbyte(operation);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUuid()
            //_buffer.ReadBigEndianDouble()
            //_buffer.ReadUbyte()
        }

    }

    public class Attribute : sul.Utils.Stream
    {

        public string key;
        public double @value;
        public Modifier[] modifiers;

        public Attribute() : this("", 0, new Modifier[]{}) {}

        public Attribute(string key, double @value, Modifier[] modifiers)
        {
            this.key = key;
            this.@value = @value;
            this.modifiers = modifiers;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(key)); _buffer.WriteString(key);
            _buffer.WriteBigEndianDouble(@value);
            _buffer.WriteVaruint(modifiers.Length); foreach (Modifier modifiersChild in modifiers){ modifiersChild.EncodeBody(_buffer); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadBigEndianDouble()
            //modifiers.DecodeBody(_buffer);
        }

    }

    public class OptionalPosition : sul.Utils.Stream
    {

        public bool hasPosition;
        public ulong position;

        public OptionalPosition() : this(false, 0) {}

        public OptionalPosition(bool hasPosition, ulong position)
        {
            this.hasPosition = hasPosition;
            this.position = position;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteBool(hasPosition);
            if(hasPosition==true){ _buffer.WriteBigEndianUlong(position); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadBool()
            //if(hasPosition==true){ _buffer.ReadBigEndianUlong() }
        }

    }

    public class OptionalUuid : sul.Utils.Stream
    {

        public bool hasUuid;
        public System.Guid uuid;

        public OptionalUuid() : this(false, System.Guid.Empty) {}

        public OptionalUuid(bool hasUuid, System.Guid uuid)
        {
            this.hasUuid = hasUuid;
            this.uuid = uuid;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteBool(hasUuid);
            _buffer.WriteUuid(uuid);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadBool()
            //_buffer.ReadUuid()
        }

    }

}
