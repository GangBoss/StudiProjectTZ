using System;
using System.Linq;

namespace AmazingApp.PinCodeVer
{
    public class PinCodeVerificator : IPinCodeVerificator
    {
        public bool VerifyPin(string pinCode)
        {
            if (pinCode.Any(pinCharacter => !char.IsDigit(pinCharacter)))
            {
                return false;
            }

            return pinCode.Length == 4 || pinCode.Length == 6;
        }
    }
}