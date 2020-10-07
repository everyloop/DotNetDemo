using System;
using System.Collections.Generic;
using System.Text;

namespace EventDemo
{
    class Subscriber
    {
        private string name;

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void OnMessageRecieved(object sender, MessageEvents args)
        {
            Publisher publisher = (Publisher)sender;
            Console.WriteLine($"{name} got a message {publisher.Name}. The message is: {args.Message}");
        }
    }
}
