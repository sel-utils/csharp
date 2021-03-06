/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/pocket113.xml
 */
using System.Text;

namespace sul.Protocol.Pocket113.Types
{

    public class LoginBody : sul.Utils.LengthPrefixedType
    {

        public byte[] chain;
        public byte[] clientData;

        public LoginBody() : this(new byte[]{}, new byte[]{}) {}

        public LoginBody(byte[] chain, byte[] clientData)
        {
            this.chain = chain;
            this.clientData = clientData;
        }

        protected override void EncodeLength(int length, sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(length);
        }

        protected override int DecodeLength(sul.Utils.Buffer _buffer)
        {
            return (int)_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteLittleEndianUint(chain.Length); _buffer.WriteBytes(chain);
            _buffer.WriteLittleEndianUint(clientData.Length); _buffer.WriteBytes(clientData);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //chain.DecodeBody(_buffer);
            //clientData.DecodeBody(_buffer);
        }

    }

    public class PackWithSize : sul.Utils.Stream
    {

        public string id;
        public string version;
        public ulong size;

        public PackWithSize() : this("", "", 0) {}

        public PackWithSize(string id, string version, ulong size)
        {
            this.id = id;
            this.version = version;
            this.size = size;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(id)); _buffer.WriteString(id);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(version)); _buffer.WriteString(version);
            _buffer.WriteLittleEndianUlong(size);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadString()
            //_buffer.ReadLittleEndianUlong()
        }

    }

    public class Pack : sul.Utils.Stream
    {

        public string id;
        public string version;

        public Pack() : this("", "") {}

        public Pack(string id, string version)
        {
            this.id = id;
            this.version = version;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(id)); _buffer.WriteString(id);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(version)); _buffer.WriteString(version);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadString()
        }

    }

    public class Slot : sul.Utils.Stream
    {

        public int id;
        public int metaAndCount;
        public byte[] nbt;
        public string[] canPlaceOn;
        public string[] canDestroy;

        public Slot() : this(0, 0, new byte[]{}, new string[]{}, new string[]{}) {}

        public Slot(int id, int metaAndCount, byte[] nbt, string[] canPlaceOn, string[] canDestroy)
        {
            this.id = id;
            this.metaAndCount = metaAndCount;
            this.nbt = nbt;
            this.canPlaceOn = canPlaceOn;
            this.canDestroy = canDestroy;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarint(id);
            if(id>0){ _buffer.WriteVarint(metaAndCount); }
            if(id>0){ _buffer.WriteLittleEndianUshort(nbt.Length); _buffer.WriteBytes(nbt); }
            _buffer.WriteVaruint(canPlaceOn.Length); foreach (string canPlaceOnChild in canPlaceOn){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(canPlaceOnChild)); _buffer.WriteString(canPlaceOnChild); }
            _buffer.WriteVaruint(canDestroy.Length); foreach (string canDestroyChild in canDestroy){ _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(canDestroyChild)); _buffer.WriteString(canDestroyChild); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVarint()
            //if(id>0){ _buffer.ReadVarint() }
            //if(id>0){ nbt.DecodeBody(_buffer); }
            //canPlaceOn.DecodeBody(_buffer);
            //canDestroy.DecodeBody(_buffer);
        }

    }

    public class Attribute : sul.Utils.Stream
    {

        public float min;
        public float max;
        public float @value;
        public float @default;
        public string name;

        public Attribute() : this(0, 0, 0, 0, "") {}

        public Attribute(float min, float max, float @value, float @default, string name)
        {
            this.min = min;
            this.max = max;
            this.@value = @value;
            this.@default = @default;
            this.name = name;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteLittleEndianFloat(min);
            _buffer.WriteLittleEndianFloat(max);
            _buffer.WriteLittleEndianFloat(@value);
            _buffer.WriteLittleEndianFloat(@default);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadLittleEndianFloat()
            //_buffer.ReadLittleEndianFloat()
            //_buffer.ReadLittleEndianFloat()
            //_buffer.ReadLittleEndianFloat()
            //_buffer.ReadString()
        }

    }

    public class BlockPosition : sul.Utils.Stream
    {

        public int x;
        public uint y;
        public int z;

        public BlockPosition() : this(0, 0, 0) {}

        public BlockPosition(int x, uint y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarint(x);
            _buffer.WriteVaruint(y);
            _buffer.WriteVarint(z);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVarint()
            //_buffer.ReadVaruint()
            //_buffer.ReadVarint()
        }

    }

    public class McpeUuid : sul.Utils.Stream
    {

        public long mostSignificantBits;
        public long leastSignificantBits;

        public McpeUuid() : this(0, 0) {}

        public McpeUuid(long mostSignificantBits, long leastSignificantBits)
        {
            this.mostSignificantBits = mostSignificantBits;
            this.leastSignificantBits = leastSignificantBits;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteLittleEndianLong(mostSignificantBits);
            _buffer.WriteLittleEndianLong(leastSignificantBits);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadLittleEndianLong()
            //_buffer.ReadLittleEndianLong()
        }

    }

    public class Skin : sul.Utils.Stream
    {

        public string name;
        public byte[] data;

        public Skin() : this("", new byte[]{}) {}

        public Skin(string name, byte[] data)
        {
            this.name = name;
            this.data = data;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(data.Length); _buffer.WriteBytes(data);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //data.DecodeBody(_buffer);
        }

    }

    public class PlayerList : sul.Utils.Stream
    {

        public McpeUuid uuid;
        public long entityId;
        public string displayName;
        public Skin skin;

        public PlayerList() : this(new McpeUuid(), 0, "", new Skin()) {}

        public PlayerList(McpeUuid uuid, long entityId, string displayName, Skin skin)
        {
            this.uuid = uuid;
            this.entityId = entityId;
            this.displayName = displayName;
            this.skin = skin;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            uuid.EncodeBody(_buffer);
            _buffer.WriteVarlong(entityId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName);
            skin.EncodeBody(_buffer);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //uuid.DecodeBody(_buffer);
            //_buffer.ReadVarlong()
            //_buffer.ReadString()
            //skin.DecodeBody(_buffer);
        }

    }

    public class Link : sul.Utils.Stream
    {

        // action
        public const byte ADD = 0;
        public const byte RIDE = 1;
        public const byte REMOVE = 2;

        public long from;
        public long to;
        public byte action;

        public Link() : this(0, 0, 0) {}

        public Link(long from, long to, byte action)
        {
            this.from = from;
            this.to = to;
            this.action = action;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarlong(from);
            _buffer.WriteVarlong(to);
            _buffer.WriteUbyte(action);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVarlong()
            //_buffer.ReadVarlong()
            //_buffer.ReadUbyte()
        }

    }

    public class Recipe : sul.Utils.Stream
    {

        // type
        public const int SHAPELESS = 0;
        public const int SHAPED = 1;
        public const int FURNACE = 2;
        public const int FURNACE_DATA = 3;
        public const int MULTI = 4;

        public int type;
        public byte[] data;

        public Recipe() : this(0, new byte[]{}) {}

        public Recipe(int type, byte[] data)
        {
            this.type = type;
            this.data = data;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarint(type);
            _buffer.WriteBytes(data);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVarint()
            //_buffer.ReadBytes()
        }

    }

    public class ChunkData : sul.Utils.LengthPrefixedType
    {

        public Section[] sections;
        public ushort[] heights;
        public byte[] biomes;
        public byte[] borders;
        public ExtraData[] extraData;
        public byte[] blockEntities;

        public ChunkData() : this(new Section[]{}, new ushort[256], new byte[256], new byte[]{}, new ExtraData[]{}, new byte[]{}) {}

        public ChunkData(Section[] sections, ushort[] heights, byte[] biomes, byte[] borders, ExtraData[] extraData, byte[] blockEntities)
        {
            this.sections = sections;
            this.heights = heights;
            this.biomes = biomes;
            this.borders = borders;
            this.extraData = extraData;
            this.blockEntities = blockEntities;
        }

        protected override void EncodeLength(int length, sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(length);
        }

        protected override int DecodeLength(sul.Utils.Buffer _buffer)
        {
            return (int)_buffer.ReadVaruint();
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(sections.Length); foreach (Section sectionsChild in sections){ sectionsChild.EncodeBody(_buffer); }
            foreach (ushort heightsChild in heights){ _buffer.WriteBigEndianUshort(heightsChild); }
            foreach (byte biomesChild in biomes){ _buffer.WriteUbyte(biomesChild); }
            _buffer.WriteVaruint(borders.Length); _buffer.WriteBytes(borders);
            _buffer.WriteVaruint(extraData.Length); foreach (ExtraData extraDataChild in extraData){ extraDataChild.EncodeBody(_buffer); }
            _buffer.WriteBytes(blockEntities);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //sections.DecodeBody(_buffer);
            //heights.DecodeBody(_buffer);
            //biomes.DecodeBody(_buffer);
            //borders.DecodeBody(_buffer);
            //extraData.DecodeBody(_buffer);
            //_buffer.ReadBytes()
        }

    }

    public class Section : sul.Utils.Stream
    {

        public byte storageVersion;
        public byte[] blockIds;
        public byte[] blockMetas;
        public byte[] skyLight;
        public byte[] blockLight;

        public Section() : this(0, new byte[4096], new byte[2048], new byte[2048], new byte[2048]) {}

        public Section(byte storageVersion, byte[] blockIds, byte[] blockMetas, byte[] skyLight, byte[] blockLight)
        {
            this.storageVersion = storageVersion;
            this.blockIds = blockIds;
            this.blockMetas = blockMetas;
            this.skyLight = skyLight;
            this.blockLight = blockLight;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteUbyte(storageVersion);
            foreach (byte blockIdsChild in blockIds){ _buffer.WriteUbyte(blockIdsChild); }
            foreach (byte blockMetasChild in blockMetas){ _buffer.WriteUbyte(blockMetasChild); }
            foreach (byte skyLightChild in skyLight){ _buffer.WriteUbyte(skyLightChild); }
            foreach (byte blockLightChild in blockLight){ _buffer.WriteUbyte(blockLightChild); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadUbyte()
            //blockIds.DecodeBody(_buffer);
            //blockMetas.DecodeBody(_buffer);
            //skyLight.DecodeBody(_buffer);
            //blockLight.DecodeBody(_buffer);
        }

    }

    public class ExtraData : sul.Utils.Stream
    {

        public uint key;
        public ushort @value;

        public ExtraData() : this(0, 0) {}

        public ExtraData(uint key, ushort @value)
        {
            this.key = key;
            this.@value = @value;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(key);
            _buffer.WriteLittleEndianUshort(@value);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVaruint()
            //_buffer.ReadLittleEndianUshort()
        }

    }

    public class Decoration : sul.Utils.Stream
    {

        public int rotationAndIcon;
        public System.Tuple<byte, byte> position;
        public string label;
        public uint color;

        public Decoration() : this(0, null, "", 0) {}

        public Decoration(int rotationAndIcon, System.Tuple<byte, byte> position, string label, uint color)
        {
            this.rotationAndIcon = rotationAndIcon;
            this.position = position;
            this.label = label;
            this.color = color;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVarint(rotationAndIcon);
            _buffer.WriteUbyte(position.Item1); _buffer.WriteUbyte(position.Item2);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(label)); _buffer.WriteString(label);
            _buffer.WriteLittleEndianUint(color);
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadVarint()
            //_buffer.ReadUbyte() _buffer.ReadUbyte()
            //_buffer.ReadString()
            //_buffer.ReadLittleEndianUint()
        }

    }

    public class Rule : sul.Utils.Stream
    {

        // name
        public const string COMMAND_BLOCK_OUTPUT = "commandblockoutput";
        public const string DO_DAYLIGHT_CYCLE = "dodaylightcycle";
        public const string DO_ENTITY_DROPS = "doentitydrops";
        public const string DO_FIRE_TICK = "dofiretick";
        public const string DO_MOB_LOOT = "domobloot";
        public const string DO_MOB_SPAWNING = "domobspawning";
        public const string DO_TILE_DROPS = "dotiledrops";
        public const string DO_WEATHER_CYCLE = "doweathercycle";
        public const string DROWNING_DAMAGE = "drowningdamage";
        public const string FALL_DAMAGE = "falldamage";
        public const string FIRE_DAMAGE = "firedamage";
        public const string KEEP_INVENTORY = "keepinventory";
        public const string MOB_GRIEFING = "mobgriefing";
        public const string PVP = "pvp";
        public const string SEND_COMMAND_FEEDBACK = "sendcommandfeedback";

        // type
        public const byte BOOLEAN = 1;
        public const byte INTEGER = 2;
        public const byte FLOATING = 3;

        public string name;
        public byte type;
        public bool booleanValue;
        public int integerValue;
        public float floatingValue;

        public Rule() : this("", 0, false, 0, 0) {}

        public Rule(string name, byte type, bool booleanValue, int integerValue, float floatingValue)
        {
            this.name = name;
            this.type = type;
            this.booleanValue = booleanValue;
            this.integerValue = integerValue;
            this.floatingValue = floatingValue;
        }

        protected override void EncodeImpl(sul.Utils.Buffer _buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteUbyte(type);
            if(type==1){ _buffer.WriteBool(booleanValue); }
            if(type==2){ _buffer.WriteBigEndianInt(integerValue); }
            if(type==3){ _buffer.WriteLittleEndianFloat(floatingValue); }
        }

        protected override void DecodeImpl(sul.Utils.Buffer _buffer)
        {
            //_buffer.ReadString()
            //_buffer.ReadUbyte()
            //if(type==1){ _buffer.ReadBool() }
            //if(type==2){ _buffer.ReadBigEndianInt() }
            //if(type==3){ _buffer.ReadLittleEndianFloat() }
        }

    }

}
