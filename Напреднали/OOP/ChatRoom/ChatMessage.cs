using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    public class ChatMessage : EventArgs
    {
        public string Content { get; private set; }

        public string Author { get; private set; }

        public DateTime SentOn { get;private set; }

        public ChatMessage(string content, string author)
        {
            this.Content = content;
            this.Author = author;
            this.SentOn = DateTime.Now;
        }
    }
}
