using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.CSharp.Basic.Homework._6.Class
{
    public class Customer
    {
        public Customer(string firstname,string lastname,Card creditCard)
        {
            Firstname = firstname;
            Lastname = lastname;
            Card = creditCard;
        }
        public string Firstname { get; set; }   
        public string Lastname { get; set; }    
        public Card Card { get; set; }  
        public void GetCustomerInfo()
        {
            Console.WriteLine($"[{Firstname} {Lastname}]: Number: {Card.Number}: _pin: {Card.GetCardPin()}");
        }
    }
}
