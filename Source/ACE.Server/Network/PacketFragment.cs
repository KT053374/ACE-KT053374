namespace ACE.Server.Network
{
    public abstract class PacketFragment
    {
        public const int MaxFragementSize = 464;
        public const int MaxFragmentDataSize = 448;

        public PacketFragmentHeader Header { get; } = new PacketFragmentHeader();

        //Still used by inbound ClientPacketFragment.
        public byte[] Data { get; protected set; }

        public virtual int Length => 
            PacketFragmentHeader.HeaderSize + Data.Length;
    }
}
