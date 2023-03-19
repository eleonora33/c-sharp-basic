using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharp.Basic.Homework._6.Class
{
    public class Card
    {
        public Card(long cardNumber, int balance)
        {
            Number = cardNumber;
            Balance = balance;
            _pin = GeneratePin();
        }
        public long Number { get; set; }
        public int Balance { get; set; }
        private int _pin;

        private int GeneratePin()
        {
            return new Random().Next(1000, 9999);
        } 
        public int GetCardPin()
        {
            return _pin;
        }
        
    }
}
