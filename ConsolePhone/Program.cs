using System;

namespace ConsolePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone(99099099, "MS240", 23);
            Phone phone2= new Phone(99099099, "MS240", 23);
            Phone phone3 = new Phone(99099099, "MS240", 23);
            Phone phone4 = new Phone(99099099, "MS240", 23);
            phone1.ReceiveCall("Jack");
            phone1.SendMessage(011545676);
            Phone phone = new Phone(011343333, "Iphone");
            phone.SendMessage(010222333);
        }
    }
}
