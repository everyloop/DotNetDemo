using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class MessageEvents : EventArgs
    {
        public string Message { get; set; }
        public MessageEvents(string messsage)
        {
            Message = messsage;
        }
    }

    class Publisher
    {
        public string Name { get; }

        //public delegate void SendMessage(object sender, EventArgs args);
        //public event EventHandler sendMessage;

        //public delegate void SendMessage(object sender, MessageEvents args);
        public event EventHandler<MessageEvents> sendMessage;

        public Publisher(string name)
        {
            Name = name;
        }

        public void RaiseEvent(string message)
        {
            sendMessage.Invoke(this, new MessageEvents(message));
        }
    }
}
