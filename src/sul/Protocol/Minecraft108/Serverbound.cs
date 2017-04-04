/*
 * This file was automatically generated by sel-utils and
 * released under the GNU General Public License version 3.
 * 
 * License: https://github.com/sel-project/sel-utils/blob/master/LICENSE
 * Repository: https://github.com/sel-project/sel-utils
 * Generated from https://github.com/sel-project/sel-utils/blob/master/xml/protocol/minecraft108.xml
 */
using Types = sul.Minecraft108.Types;

namespace sul.Minecraft108
{

    public class TeleportConfirm : Packet
    {

        public const uint Id = 0;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint teleportId;

        public TeleportConfirm() {}

        public TeleportConfirm(uint teleportId)
        {
            this.teleportId = teleportId;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static TeleportConfirm FromBuffer(byte[] buffer)
        {
            var ret = new TeleportConfirm();
            ret.decode(buffer);
            return ret;
        }

    }

    public class TabComplete : Packet
    {

        public const uint Id = 1;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string text;
        public bool command;
        public bool hasPosition;
        public ulong block;

        public TabComplete() {}

        public TabComplete(string text, bool command, bool hasPosition, ulong block)
        {
            this.text = text;
            this.command = command;
            this.hasPosition = hasPosition;
            this.block = block;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static TabComplete FromBuffer(byte[] buffer)
        {
            var ret = new TabComplete();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ChatMessage : Packet
    {

        public const uint Id = 2;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string text;

        public ChatMessage() {}

        public ChatMessage(string text)
        {
            this.text = text;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ChatMessage FromBuffer(byte[] buffer)
        {
            var ret = new ChatMessage();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ClientStatus : Packet
    {

        public const uint Id = 3;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // action
        public const uint Respawn = 0;
        public const uint RequestStats = 1;
        public const uint OpenInventory = 2;

        public uint action;

        public ClientStatus() {}

        public ClientStatus(uint action)
        {
            this.action = action;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ClientStatus FromBuffer(byte[] buffer)
        {
            var ret = new ClientStatus();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ClientSettings : Packet
    {

        public const uint Id = 4;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // chat mode
        public const uint Enabled = 0;
        public const uint CommandsOnly = 1;
        public const uint Disabled = 2;

        // displayed skin parts
        public const byte Cape = 1;
        public const byte Jacket = 2;
        public const byte LeftSleeve = 4;
        public const byte RightSleeve = 8;
        public const byte LeftPants = 16;
        public const byte RightPants = 32;
        public const byte Hat = 64;

        // main hand
        public const byte Right = 0;
        public const byte Left = 1;

        public string language;
        public byte viewDistance;
        public uint chatMode;
        public bool chatColors;
        public byte displayedSkinParts;
        public byte mainHand;

        public ClientSettings() {}

        public ClientSettings(string language, byte viewDistance, uint chatMode, bool chatColors, byte displayedSkinParts, byte mainHand)
        {
            this.language = language;
            this.viewDistance = viewDistance;
            this.chatMode = chatMode;
            this.chatColors = chatColors;
            this.displayedSkinParts = displayedSkinParts;
            this.mainHand = mainHand;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ClientSettings FromBuffer(byte[] buffer)
        {
            var ret = new ClientSettings();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ConfirmTransaction : Packet
    {

        public const uint Id = 5;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte window;
        public ushort action;
        public bool accepted;

        public ConfirmTransaction() {}

        public ConfirmTransaction(byte window, ushort action, bool accepted)
        {
            this.window = window;
            this.action = action;
            this.accepted = accepted;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ConfirmTransaction FromBuffer(byte[] buffer)
        {
            var ret = new ConfirmTransaction();
            ret.decode(buffer);
            return ret;
        }

    }

    public class EnchantItem : Packet
    {

        public const uint Id = 6;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte window;
        public byte enchantment;

        public EnchantItem() {}

        public EnchantItem(byte window, byte enchantment)
        {
            this.window = window;
            this.enchantment = enchantment;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static EnchantItem FromBuffer(byte[] buffer)
        {
            var ret = new EnchantItem();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ClickWindow : Packet
    {

        public const uint Id = 7;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte window;
        public ushort slot;
        public byte button;
        public ushort action;
        public uint mode;
        public Types.Slot clickedItem;

        public ClickWindow() {}

        public ClickWindow(byte window, ushort slot, byte button, ushort action, uint mode, Types.Slot clickedItem)
        {
            this.window = window;
            this.slot = slot;
            this.button = button;
            this.action = action;
            this.mode = mode;
            this.clickedItem = clickedItem;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ClickWindow FromBuffer(byte[] buffer)
        {
            var ret = new ClickWindow();
            ret.decode(buffer);
            return ret;
        }

    }

    public class CloseWindow : Packet
    {

        public const uint Id = 8;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public byte window;

        public CloseWindow() {}

        public CloseWindow(byte window)
        {
            this.window = window;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static CloseWindow FromBuffer(byte[] buffer)
        {
            var ret = new CloseWindow();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PluginMessage : Packet
    {

        public const uint Id = 9;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public string channel;
        public byte[] data;

        public PluginMessage() {}

        public PluginMessage(string channel, byte[] data)
        {
            this.channel = channel;
            this.data = data;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PluginMessage FromBuffer(byte[] buffer)
        {
            var ret = new PluginMessage();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UseEntity : Packet
    {

        public const uint Id = 10;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // type
        public const uint Interact = 0;
        public const uint Attack = 1;
        public const uint InteractAt = 2;

        // hand
        public const uint MainHand = 0;
        public const uint OffHand = 1;

        public uint target;
        public uint type;
        public Tuple<float, float, float> targetPosition;
        public uint hand;

        public UseEntity() {}

        public UseEntity(uint target, uint type, Tuple<float, float, float> targetPosition, uint hand)
        {
            this.target = target;
            this.type = type;
            this.targetPosition = targetPosition;
            this.hand = hand;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static UseEntity FromBuffer(byte[] buffer)
        {
            var ret = new UseEntity();
            ret.decode(buffer);
            return ret;
        }

    }

    public class KeepAlive : Packet
    {

        public const uint Id = 11;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public uint id;

        public KeepAlive() {}

        public KeepAlive(uint id)
        {
            this.id = id;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static KeepAlive FromBuffer(byte[] buffer)
        {
            var ret = new KeepAlive();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerPosition : Packet
    {

        public const uint Id = 12;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public Tuple<double, double, double> position;
        public bool onGround;

        public PlayerPosition() {}

        public PlayerPosition(Tuple<double, double, double> position, bool onGround)
        {
            this.position = position;
            this.onGround = onGround;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerPosition FromBuffer(byte[] buffer)
        {
            var ret = new PlayerPosition();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerPositionAndLook : Packet
    {

        public const uint Id = 13;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public Tuple<double, double, double> position;
        public float yaw;
        public float pitch;
        public bool onGround;

        public PlayerPositionAndLook() {}

        public PlayerPositionAndLook(Tuple<double, double, double> position, float yaw, float pitch, bool onGround)
        {
            this.position = position;
            this.yaw = yaw;
            this.pitch = pitch;
            this.onGround = onGround;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerPositionAndLook FromBuffer(byte[] buffer)
        {
            var ret = new PlayerPositionAndLook();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerLook : Packet
    {

        public const uint Id = 14;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public float yaw;
        public float pitch;
        public bool onGround;

        public PlayerLook() {}

        public PlayerLook(float yaw, float pitch, bool onGround)
        {
            this.yaw = yaw;
            this.pitch = pitch;
            this.onGround = onGround;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerLook FromBuffer(byte[] buffer)
        {
            var ret = new PlayerLook();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Player : Packet
    {

        public const uint Id = 15;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public bool onGround;

        public Player() {}

        public Player(bool onGround)
        {
            this.onGround = onGround;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static Player FromBuffer(byte[] buffer)
        {
            var ret = new Player();
            ret.decode(buffer);
            return ret;
        }

    }

    public class VehicleMove : Packet
    {

        public const uint Id = 16;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public Tuple<double, double, double> position;
        public float yaw;
        public float pitch;

        public VehicleMove() {}

        public VehicleMove(Tuple<double, double, double> position, float yaw, float pitch)
        {
            this.position = position;
            this.yaw = yaw;
            this.pitch = pitch;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static VehicleMove FromBuffer(byte[] buffer)
        {
            var ret = new VehicleMove();
            ret.decode(buffer);
            return ret;
        }

    }

    public class SteerBoat : Packet
    {

        public const uint Id = 17;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public bool rightPaddleTurning;
        public bool leftPaddleTurning;

        public SteerBoat() {}

        public SteerBoat(bool rightPaddleTurning, bool leftPaddleTurning)
        {
            this.rightPaddleTurning = rightPaddleTurning;
            this.leftPaddleTurning = leftPaddleTurning;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static SteerBoat FromBuffer(byte[] buffer)
        {
            var ret = new SteerBoat();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerAbilities : Packet
    {

        public const uint Id = 18;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // flags
        public const byte CreativeMode = 1;
        public const byte Flying = 2;
        public const byte AllowFlying = 4;
        public const byte Invincible = 8;

        public byte flags;
        public float flyingSpeed;
        public float walkingSpeed;

        public PlayerAbilities() {}

        public PlayerAbilities(byte flags, float flyingSpeed, float walkingSpeed)
        {
            this.flags = flags;
            this.flyingSpeed = flyingSpeed;
            this.walkingSpeed = walkingSpeed;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerAbilities FromBuffer(byte[] buffer)
        {
            var ret = new PlayerAbilities();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerDigging : Packet
    {

        public const uint Id = 19;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // status
        public const uint StartDigging = 0;
        public const uint CancelDigging = 1;
        public const uint FinishDigging = 2;
        public const uint DropItemStack = 3;
        public const uint DropItem = 4;
        public const uint ShootArrow = 5;
        public const uint FinishEating = 5;
        public const uint SwapItemInHand = 6;

        public uint status;
        public ulong position;
        public byte face;

        public PlayerDigging() {}

        public PlayerDigging(uint status, ulong position, byte face)
        {
            this.status = status;
            this.position = position;
            this.face = face;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerDigging FromBuffer(byte[] buffer)
        {
            var ret = new PlayerDigging();
            ret.decode(buffer);
            return ret;
        }

    }

    public class EntityAction : Packet
    {

        public const uint Id = 20;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // action
        public const uint StartSneaking = 0;
        public const uint StopSneaking = 1;
        public const uint LeaveBed = 2;
        public const uint StartSprinting = 3;
        public const uint StopSprinting = 4;
        public const uint StartHorseJump = 5;
        public const uint StopHorseJump = 6;
        public const uint OpenHorseInventory = 7;
        public const uint StartElytraFlying = 8;

        public uint entityId;
        public uint action;
        public uint jumpBoost;

        public EntityAction() {}

        public EntityAction(uint entityId, uint action, uint jumpBoost)
        {
            this.entityId = entityId;
            this.action = action;
            this.jumpBoost = jumpBoost;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static EntityAction FromBuffer(byte[] buffer)
        {
            var ret = new EntityAction();
            ret.decode(buffer);
            return ret;
        }

    }

    public class SteerVehicle : Packet
    {

        public const uint Id = 21;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // flags
        public const byte Jump = 1;
        public const byte Unmount = 2;

        public float sideways;
        public float forward;
        public byte flags;

        public SteerVehicle() {}

        public SteerVehicle(float sideways, float forward, byte flags)
        {
            this.sideways = sideways;
            this.forward = forward;
            this.flags = flags;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static SteerVehicle FromBuffer(byte[] buffer)
        {
            var ret = new SteerVehicle();
            ret.decode(buffer);
            return ret;
        }

    }

    public class ResourcePackStatus : Packet
    {

        public const uint Id = 22;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // result
        public const uint Loaded = 0;
        public const uint Declined = 1;
        public const uint Failed = 2;
        public const uint Accepted = 3;

        public string hash;
        public uint result;

        public ResourcePackStatus() {}

        public ResourcePackStatus(string hash, uint result)
        {
            this.hash = hash;
            this.result = result;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static ResourcePackStatus FromBuffer(byte[] buffer)
        {
            var ret = new ResourcePackStatus();
            ret.decode(buffer);
            return ret;
        }

    }

    public class HeldItemChange : Packet
    {

        public const uint Id = 23;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public ushort slot;

        public HeldItemChange() {}

        public HeldItemChange(ushort slot)
        {
            this.slot = slot;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static HeldItemChange FromBuffer(byte[] buffer)
        {
            var ret = new HeldItemChange();
            ret.decode(buffer);
            return ret;
        }

    }

    public class CreativeInventoryAction : Packet
    {

        public const uint Id = 24;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public ushort slot;
        public Types.Slot clickedItem;

        public CreativeInventoryAction() {}

        public CreativeInventoryAction(ushort slot, Types.Slot clickedItem)
        {
            this.slot = slot;
            this.clickedItem = clickedItem;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static CreativeInventoryAction FromBuffer(byte[] buffer)
        {
            var ret = new CreativeInventoryAction();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UpdateSign : Packet
    {

        public const uint Id = 25;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public ulong position;
        public string[4] lines;

        public UpdateSign() {}

        public UpdateSign(ulong position, string[4] lines)
        {
            this.position = position;
            this.lines = lines;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static UpdateSign FromBuffer(byte[] buffer)
        {
            var ret = new UpdateSign();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Animation : Packet
    {

        public const uint Id = 26;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // hand
        public const uint MainHand = 0;
        public const uint OffHand = 1;

        public uint hand;

        public Animation() {}

        public Animation(uint hand)
        {
            this.hand = hand;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static Animation FromBuffer(byte[] buffer)
        {
            var ret = new Animation();
            ret.decode(buffer);
            return ret;
        }

    }

    public class Spectate : Packet
    {

        public const uint Id = 27;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        public Guid player;

        public Spectate() {}

        public Spectate(Guid player)
        {
            this.player = player;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static Spectate FromBuffer(byte[] buffer)
        {
            var ret = new Spectate();
            ret.decode(buffer);
            return ret;
        }

    }

    public class PlayerBlockPlacement : Packet
    {

        public const uint Id = 28;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // hand
        public const uint MainHand = 0;
        public const uint OffHand = 1;

        public ulong position;
        public uint face;
        public uint hand;
        public Tuple<byte, byte, byte> cursorPosition;

        public PlayerBlockPlacement() {}

        public PlayerBlockPlacement(ulong position, uint face, uint hand, Tuple<byte, byte, byte> cursorPosition)
        {
            this.position = position;
            this.face = face;
            this.hand = hand;
            this.cursorPosition = cursorPosition;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static PlayerBlockPlacement FromBuffer(byte[] buffer)
        {
            var ret = new PlayerBlockPlacement();
            ret.decode(buffer);
            return ret;
        }

    }

    public class UseItem : Packet
    {

        public const uint Id = 29;

        public const bool Clientbound = false;
        public const bool Serverbound = true;

        // hand
        public const uint MainHand = 0;
        public const uint OffHand = 1;

        public uint hand;

        public UseItem() {}

        public UseItem(uint hand)
        {
            this.hand = hand;
        }

        public override int GetId()
        {
            return Id;
        }

        public override byte[] Encode()
        {
            return this._buffer;
        }

        public override void Decode(byte[] buffer)
        {
            this._buffer = buffer;
        }

        public static UseItem FromBuffer(byte[] buffer)
        {
            var ret = new UseItem();
            ret.decode(buffer);
            return ret;
        }

    }

}
