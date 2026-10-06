using ACE.Server.Network.GameMessages;
using System.Collections.Generic;

namespace ACE.Server.Network
{
    internal class NetworkBundle
    {
        private bool propChanged;

        public bool NeedsSending => propChanged || messages.Count > 0;

        public bool HasMoreMessages => messages.Count > 0;

        private readonly Queue<GameMessage> messages = new Queue<GameMessage>();

        private float clientTime = -1f;
        public float ClientTime
        {
            get => clientTime;
            set
            {
                clientTime = value;
                propChanged = true;
            }
        }

        private bool timeSync;
        public bool TimeSync
        {
            get => timeSync;
            set
            {
                timeSync = value;
                propChanged = true;
            }
        }

        private bool ackSeq;
        public bool SendAck
        {
            get => ackSeq;
            set
            {
                ackSeq = value;
                propChanged = true;
            }
        }

        public bool EncryptedChecksum { get; set; }

        // long prevents accounting overflow if a session ever accumulates
        // an unusually large amount of queued outbound data
        public long CurrentSize { get; private set; }

        public void Enqueue(GameMessage message)
        {
            // Freezes exactly once even if this same message is subsequently
            // queued for thousands of sessions.
            var frozenData = message.GetFrozenData();
            
            CurrentSize += frozenData.Length;
            messages.Enqueue(message);
        }

        public GameMessage Dequeue()
        {
            var message = messages.Dequeue();

            CurrentSize -= message.FrozenDataLength;

            return message;
        }
    }
}
