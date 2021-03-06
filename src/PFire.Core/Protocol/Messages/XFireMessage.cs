﻿using System;
using PFire.Core.Session;

namespace PFire.Core.Protocol.Messages
{
    public abstract class XFireMessage : IMessage
    {
        protected XFireMessageType MessageType;

        public XFireMessageType MessageTypeId { get; protected set; }

        protected XFireMessage(XFireMessageType typeId)
        {
            MessageTypeId = typeId;
        }

        public virtual void Process(XFireClient client)
        {
            // base implementation is to do nothing
            Console.WriteLine($" *** Unimplemented processing for message type {MessageTypeId}");
        }
    }
}
