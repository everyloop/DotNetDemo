using System;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("Anna");
            Subscriber sub1 = new Subscriber("Fredrik");
            Subscriber sub2 = new Subscriber("Kalle");
            Subscriber sub3 = new Subscriber("Pelle");

            publisher.sendMessage += sub1.OnMessageRecieved;
            publisher.sendMessage += sub2.OnMessageRecieved;
            publisher.sendMessage += sub3.OnMessageRecieved;

            publisher.RaiseEvent("Meddelande A");

            publisher.sendMessage -= sub2.OnMessageRecieved;
            Console.WriteLine("Kalle unsubscribed from the event");

            publisher.RaiseEvent("Meddelande B");
        }
    }
}
