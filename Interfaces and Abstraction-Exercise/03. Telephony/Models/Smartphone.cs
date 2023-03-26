using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.Models
{
    using Interfaces;
    public class Smartphone : ICallable, IBrowsable
    {
        public void Browse(string url)
        {
            if (ValidateUrl(url))
            {
                Console.WriteLine($"Browsing: {url}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }

        public void Call(string number)
        {
            if (ValidateNumber(number))
            {
                Console.WriteLine($"Calling... {number}");
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
        private bool ValidateUrl(string url)
        {
            foreach (char ch in url)
            {
                if (char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
