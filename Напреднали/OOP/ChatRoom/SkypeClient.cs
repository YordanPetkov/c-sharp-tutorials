using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class SkypeClient
    {
        public string User { get; private set; }

        public SkypeClient(string User)
        {
            this.User = User;
        }

        public void JoinChatRoom(ChatRoom room)
        {
            room.MessageSend += this.OnMessageReceived;
        }

        public void SendMessage(ChatRoom room, string content)
        {
            room.PublishMessage(this.User, content);
        }

        protected void OnMessageReceived(object sender, ChatMessage args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine($@"{this.User} just reveived the message :
{args.Author} - {args.SentOn}: {args.Content}");

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
