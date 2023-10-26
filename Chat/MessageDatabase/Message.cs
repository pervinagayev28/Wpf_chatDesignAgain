using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.MessageDatabase
{
    public class Message
    {
        public List<Message>? user1 { get; set; }
        public List<Message>? user2 { get; set; }
        public string message { get; set; }
        public string time { get; set; }
        public Message()
        {
            user1fill();
            user2fill();

        }
        public Message(string Message, DateTime Time)
        {
            this.message = Message;
            this.time = Time.ToString("HH:mm");
        }

        public void user1fill()
        {
            user1 = new()
            {
                new("hello",DateTime.Now),
                new("how are you",DateTime.Now),
                new("I am fine",DateTime.Now),
                new("I am at home",DateTime.Now),
                new("let's meet",DateTime.Now),

            };
        }
        public void user2fill()
        {
            user2 = new()
            {
                new("hi",DateTime.Now),
                new("thanks,and you?",DateTime.Now),
                new("where are you",DateTime.Now),
                new("me too",DateTime.Now),
                new("okey,I am coming",DateTime.Now),
            };
        }
    }
}
