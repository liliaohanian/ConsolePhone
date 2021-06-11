using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhone
{
    public class Phone
    {
        private int _number;
        private string _model;
        private int _weight;

        public int Number { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public Phone(int number, string model, int weight ): this(number, model)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }
        public Phone(int number, string model)
        {
            Number = number;
            Model = model;
        }
        
        public void ReceiveCall(string callerName)
        {
            Console.WriteLine($"{callerName} - {Number} is calling.");
        }
        public void SendMessage(int phoneNmubers)
        {
            Console.WriteLine($"Phone number: {phoneNmubers}");
        }

    }
}
