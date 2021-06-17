using System;

namespace lap5Ex2
{
    public class AmountException : Exception
    {
        private string _personName;
        private string _message;

        public AmountException()
        {
        }

        public AmountException(string message, string personName)
        {
            this._message = message;
            this._personName = personName;
            PrintError();
        }

        private void PrintError()
        {
            Console.Error.WriteLine($"Amount exception with person {_personName}, {_message}");
        }
    }
}