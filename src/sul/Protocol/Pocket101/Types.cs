/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/pocket101.xml
 */
using Utils.Buffer;
using Utils.LengthPrefixedType;
using Utils.Stream;

namespace sul.Pocket101.Types
{

    public class PackWithSize : Stream
    {

        public string id;
        public string version;
        public ulong size;

        public PackWithSize() {}

        public PackWithSize(string id, string version, ulong size)
        {
            this.id = id;
            this.version = version;
            this.size = size;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(id)); _buffer.WriteString(id);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(version)); _buffer.WriteString(version);
            _buffer.WriteLittleEndianUlong(size);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class Pack : Stream
    {

        public string id;
        public string version;

        public Pack() {}

        public Pack(string id, string version)
        {
            this.id = id;
            this.version = version;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(id)); _buffer.WriteString(id);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(version)); _buffer.WriteString(version);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class Slot : Stream
    {

        public int id;
        public int metaAndCount;
        public byte[] nbt;

        public Slot() {}

        public Slot(int id, int metaAndCount, byte[] nbt)
        {
            this.id = id;
            this.metaAndCount = metaAndCount;
            this.nbt = nbt;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVarint(id);
            if(id>0){ _buffer.WriteVarint(metaAndCount); }
            if(id>0){ _buffer.WriteLittleEndianUshort(nbt.Length); _buffer.WriteBytes(nbt); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {

            if(id>0){  }
            if(id>0){  }
        }

    }

    public class Attribute : Stream
    {

        public float min;
        public float max;
        public float @value;
        public float @default;
        public string name;

        public Attribute() {}

        public Attribute(float min, float max, float @value, float @default, string name)
        {
            this.min = min;
            this.max = max;
            this.@value = @value;
            this.@default = @default;
            this.name = name;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteLittleEndianFloat(min);
            _buffer.WriteLittleEndianFloat(max);
            _buffer.WriteLittleEndianFloat(@value);
            _buffer.WriteLittleEndianFloat(@default);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
        }

        protected override void DecodeImpl(Buffer buffer)
        {





        }

    }

    public class BlockPosition : Stream
    {

        public int x;
        public uint y;
        public int z;

        public BlockPosition() {}

        public BlockPosition(int x, uint y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVarint(x);
            _buffer.WriteVaruint(y);
            _buffer.WriteVarint(z);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class Skin : Stream
    {

        public string name;
        public byte[] data;

        public Skin() {}

        public Skin(string name, byte[] data)
        {
            this.name = name;
            this.data = data;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteVaruint(data.Length); _buffer.WriteBytes(data);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class PlayerList : Stream
    {

        public Guid uuid;
        public long entityId;
        public string displayName;
        public Types.Skin skin;

        public PlayerList() {}

        public PlayerList(Guid uuid, long entityId, string displayName, Types.Skin skin)
        {
            this.uuid = uuid;
            this.entityId = entityId;
            this.displayName = displayName;
            this.skin = skin;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUuid(uuid);
            _buffer.WriteVarlong(entityId);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(displayName)); _buffer.WriteString(displayName);
            skin.EncodeBody(_buffer);
        }

        protected override void DecodeImpl(Buffer buffer)
        {




        }

    }

    public class Link : Stream
    {

        // action
        public const byte Add = 0;
        public const byte Ride = 1;
        public const byte Remove = 2;

        public long from;
        public long to;
        public byte action;

        public Link() {}

        public Link(long from, long to, byte action)
        {
            this.from = from;
            this.to = to;
            this.action = action;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVarlong(from);
            _buffer.WriteVarlong(to);
            _buffer.WriteUbyte(action);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

    public class Recipe : Stream
    {

        // type
        public const int Shapeless = 0;
        public const int Shaped = 1;
        public const int Furnace = 2;
        public const int FurnaceData = 3;
        public const int Multi = 4;

        public int type;
        public byte[] data;

        public Recipe() {}

        public Recipe(int type, byte[] data)
        {
            this.type = type;
            this.data = data;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVarint(type);
            _buffer.WriteBytes(data);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class ChunkData : LengthPrefixedType
    {

        public Types.Section[] sections;
        public ushort[256] heights;
        public byte[256] biomes;
        public byte[] borders;
        public Types.ExtraData[] extraData;
        public byte[] blockEntities;

        public ChunkData() {}

        public ChunkData(Types.Section[] sections, ushort[256] heights, byte[256] biomes, byte[] borders, Types.ExtraData[] extraData, byte[] blockEntities)
        {
            this.sections = sections;
            this.heights = heights;
            this.biomes = biomes;
            this.borders = borders;
            this.extraData = extraData;
            this.blockEntities = blockEntities;
        }

        protected override void EncodeLength(int length, Buffer buffer)
        {
            _buffer.WriteVaruint(length);
        }

        protected override int DecodeLength(Buffer buffer)
        {

        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(sections.Length); foreach(Types.Section sectionsChild in sections){ sectionsChild.EncodeBody(_buffer); }
            foreach(ushort heightsChild in heights){ _buffer.WriteBigEndianUshort(heightsChild); }
            foreach(byte biomesChild in biomes){ _buffer.WriteUbyte(biomesChild); }
            _buffer.WriteVaruint(borders.Length); _buffer.WriteBytes(borders);
            _buffer.WriteVaruint(extraData.Length); foreach(Types.ExtraData extraDataChild in extraData){ extraDataChild.EncodeBody(_buffer); }
            _buffer.WriteBytes(blockEntities);
        }

        protected override void DecodeImpl(Buffer buffer)
        {






        }

    }

    public class Section : Stream
    {

        public byte storageVersion = 0;
        public byte[4096] blockIds;
        public byte[2048] blockMetas;
        public byte[2048] skyLight;
        public byte[2048] blockLight;

        public Section() {}

        public Section(byte storageVersion, byte[4096] blockIds, byte[2048] blockMetas, byte[2048] skyLight, byte[2048] blockLight)
        {
            this.storageVersion = storageVersion;
            this.blockIds = blockIds;
            this.blockMetas = blockMetas;
            this.skyLight = skyLight;
            this.blockLight = blockLight;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteUbyte(storageVersion);
            foreach(byte blockIdsChild in blockIds){ _buffer.WriteUbyte(blockIdsChild); }
            foreach(byte blockMetasChild in blockMetas){ _buffer.WriteUbyte(blockMetasChild); }
            foreach(byte skyLightChild in skyLight){ _buffer.WriteUbyte(skyLightChild); }
            foreach(byte blockLightChild in blockLight){ _buffer.WriteUbyte(blockLightChild); }
        }

        protected override void DecodeImpl(Buffer buffer)
        {





        }

    }

    public class ExtraData : Stream
    {

        public uint key;
        public ushort @value;

        public ExtraData() {}

        public ExtraData(uint key, ushort @value)
        {
            this.key = key;
            this.@value = @value;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(key);
            _buffer.WriteLittleEndianUshort(@value);
        }

        protected override void DecodeImpl(Buffer buffer)
        {


        }

    }

    public class Decoration : Stream
    {

        public int rotationAndIcon;
        public Tuple<byte, byte> position;
        public string label;
        public uint color;

        public Decoration() {}

        public Decoration(int rotationAndIcon, Tuple<byte, byte> position, string label, uint color)
        {
            this.rotationAndIcon = rotationAndIcon;
            this.position = position;
            this.label = label;
            this.color = color;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVarint(rotationAndIcon);
            _buffer.WriteUbyte(position[0]); _buffer.WriteUbyte(position[1]);
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(label)); _buffer.WriteString(label);
            _buffer.WriteLittleEndianUint(color);
        }

        protected override void DecodeImpl(Buffer buffer)
        {




        }

    }

    public class Rule : Stream
    {

        // name
        public const string DrowningDamage = "drowningdamage";
        public const string FallDamage = "falldamage";
        public const string FireDamage = "firedamage";
        public const string ImmutableWorld = "immutableworld";
        public const string Pvp = "pvp";

        public string name;
        public bool @value;
        public bool unknown2;

        public Rule() {}

        public Rule(string name, bool @value, bool unknown2)
        {
            this.name = name;
            this.@value = @value;
            this.unknown2 = unknown2;
        }

        protected override void EncodeImpl(Buffer buffer)
        {
            _buffer.WriteVaruint(Encoding.UTF8.GetByteCount(name)); _buffer.WriteString(name);
            _buffer.WriteBool(@value);
            _buffer.WriteBool(unknown2);
        }

        protected override void DecodeImpl(Buffer buffer)
        {



        }

    }

}
