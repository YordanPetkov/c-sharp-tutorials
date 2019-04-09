using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom("TelerikAcademyChat");

            var gosho = new SkypeClient("gosho");
            var pesho = new miRCkata("pesho");
            var stamatka = new miRCkata("stamatka");

            gosho.JoinChatRoom(chatRoom);
            pesho.JoinChatRoom(chatRoom);
            stamatka.JoinChatRoom(chatRoom);

            pesho.SendMessage(chatRoom, "Zdr kp haide na kopon");
            stamatka.SendMessage(chatRoom, "Pesho sozi zaeta sym imam da icha za izpit");
            gosho.SendMessage(chatRoom, "Haide v 33");

            Console.WriteLine(pesho.History);
        }
    }
}
