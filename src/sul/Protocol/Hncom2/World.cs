/*
 * This file was automatically generated by sel-utils and
 * released under the MIT License.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/hncom2.xml
 */
using Types = sul.Hncom2.Types;

using Utils.Buffer;
using Utils.Packet;

namespace sul.Hncom2
{

    public class Add : Packet
    {

        public const byte Id = 31;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // dimension
        public const byte Overworld = 0;
        public const byte Nether = 1;
        public const byte End = 2;

        // generator
        public const byte Default = 0;
        public const byte Flat = 1;

        // difficulty
        public const byte Peaceful = 0;
        public const byte Easy = 1;
        public const byte Normal = 2;
        public const byte Hard = 3;
        public const byte Hardcore = 4;

        // gamemode
        public const byte Survival = 0;
        public const byte Creative = 1;
        public const byte Adventure = 2;
        public const byte Spectator = 3;

        public uint worldId;
        public string name;
        public byte dimension;
        public byte generator;
        public byte difficulty;
        public byte gamemode;
        public Tuple<int, int> spawnPoint;
        public short time;
        public int seed;
        public int parent = -1;

        public Add() {}

        public Add(uint worldId, string name, byte dimension, byte generator, byte difficulty, byte gamemode, Tuple<int, int> spawnPoint, short time, int seed, int parent)
        {
            this.worldId = worldId;
            this.name = name;
            this.dimension = dimension;
            this.generator = generator;
            this.difficulty = difficulty;
            this.gamemode = gamemode;
            this.spawnPoint = spawnPoint;
            this.time = time;
            this.seed = seed;
            this.parent = parent;
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
            _buffer.WriteVaruint(worldId);
            _buffer.WriteString(name);
            _buffer.WriteUbyte(dimension);
            _buffer.WriteUbyte(generator);
            _buffer.WriteUbyte(difficulty);
            _buffer.WriteUbyte(gamemode);
            _buffer.WriteVarint<xz>(spawnPoint[0]); _buffer.WriteVarint<xz>(spawnPoint[1]);
            _buffer.WriteBigEndianShort(time);
            _buffer.WriteVarint(seed);
            _buffer.WriteVarint(parent);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {










        }

        public static Add FromBuffer(byte[] buffer)
        {
            var ret = new Add();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Remove : Packet
    {

        public const byte Id = 32;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint worldId;

        public Remove() {}

        public Remove(uint worldId)
        {
            this.worldId = worldId;
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
            _buffer.WriteVaruint(worldId);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {

        }

        public static Remove FromBuffer(byte[] buffer)
        {
            var ret = new Remove();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateDifficulty : Packet
    {

        public const byte Id = 33;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint worldId;
        public byte difficulty;

        public UpdateDifficulty() {}

        public UpdateDifficulty(uint worldId, byte difficulty)
        {
            this.worldId = worldId;
            this.difficulty = difficulty;
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
            _buffer.WriteVaruint(worldId);
            _buffer.WriteUbyte(difficulty);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static UpdateDifficulty FromBuffer(byte[] buffer)
        {
            var ret = new UpdateDifficulty();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateGamemode : Packet
    {

        public const byte Id = 34;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint worldId;
        public byte gamemode;

        public UpdateGamemode() {}

        public UpdateGamemode(uint worldId, byte gamemode)
        {
            this.worldId = worldId;
            this.gamemode = gamemode;
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
            _buffer.WriteVaruint(worldId);
            _buffer.WriteUbyte(gamemode);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {


        }

        public static UpdateGamemode FromBuffer(byte[] buffer)
        {
            var ret = new UpdateGamemode();
            ret.decode(buffer);
            return ret;
        }

    }

    public class RequestCreation : Packet
    {

        public const byte Id = 35;

        public const bool Clientbound = true;
        public const bool Serverbound = false;

        public string name;
        public byte dimension;
        public byte generator;
        public byte difficulty;
        public byte gamemode;
        public int seed;
        public int parent = -1;

        public RequestCreation() {}

        public RequestCreation(string name, byte dimension, byte generator, byte difficulty, byte gamemode, int seed, int parent)
        {
            this.name = name;
            this.dimension = dimension;
            this.generator = generator;
            this.difficulty = difficulty;
            this.gamemode = gamemode;
            this.seed = seed;
            this.parent = parent;
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
            _buffer.WriteString(name);
            _buffer.WriteUbyte(dimension);
            _buffer.WriteUbyte(generator);
            _buffer.WriteUbyte(difficulty);
            _buffer.WriteUbyte(gamemode);
            _buffer.WriteVarint(seed);
            _buffer.WriteVarint(parent);
        }

        protected override void DecodeImpl(Buffer _buffer)
        {







        }

        public static RequestCreation FromBuffer(byte[] buffer)
        {
            var ret = new RequestCreation();
            ret.decode(buffer);
            return ret;
        }

    }

}
