using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    using Interfaces;
    public class StationaryPhone : ICallable
    {
        public void Call(string number)
        {
            if (ValidateNumber(number))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine($"Invalid number!");
            }
        }
        private bool ValidateNumber(string number)
        {
            foreach (char digit in number)
            {
                if (!char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
