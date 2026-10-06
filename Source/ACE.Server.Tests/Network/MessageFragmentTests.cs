using System;
using System.Reflection;

using ACE.Server.Network;
using ACE.Server.Network.GameMessages;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACE.Server.Tests.Network
{
    [TestClass]
    public class MessageFragmentTests
    {
        [DataTestMethod]
        [DataRow(PacketFragment.MaxFragmentDataSize)]
        [DataRow(PacketFragment.MaxFragmentDataSize * 2)]
        public void TailSize_ExactMultipleOfMaxFragmentDataSize_UsesFullFragment(
            int payloadLength)
        {
            var message = new TestGameMessage(payloadLength);

            Type messageFragmentType =
                typeof(ServerPacketFragment).Assembly.GetType(
                    "ACE.Server.Network.MessageFragment");

            Assert.IsNotNull(messageFragmentType);

            object fragment = Activator.CreateInstance(
                messageFragmentType,
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                binder: null,
                args: new object[] { message, (uint)1 },
                culture: null);

            Assert.IsNotNull(fragment);

            PropertyInfo dataLengthProperty =
                messageFragmentType.GetProperty("DataLength");

            PropertyInfo tailSizeProperty =
                messageFragmentType.GetProperty("TailSize");

            Assert.IsNotNull(dataLengthProperty);
            Assert.IsNotNull(tailSizeProperty);

            int dataLength =
                (int)dataLengthProperty.GetValue(fragment);

            int tailSize =
                (int)tailSizeProperty.GetValue(fragment);

            Assert.AreEqual(
                payloadLength,
                dataLength);

            Assert.AreEqual(
                PacketFragmentHeader.HeaderSize
                    + PacketFragment.MaxFragmentDataSize,
                tailSize);
        }

        private class TestGameMessage : GameMessage
        {
            public TestGameMessage(int payloadLength)
                : base(
                    GameMessageOpcode.None,
                    GameMessageGroup.UIQueue)
            {
                Writer.Write(new byte[payloadLength]);
            }
        }
    }
}
