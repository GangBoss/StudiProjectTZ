using System;
using System.Collections.Generic;
using System.Text;
using AmazingApp.PinCodeVer;
using NUnit.Framework;

namespace AmazingTests
{
    public class PinTests
    {
        private IPinCodeVerificator verificator;
        [SetUp]
        public void Setup()
        {
            verificator=new PinCodeVerificator();
            
        }

        [Test, Description("Длинна кода либо 4 либо 6")]
        public void LengthTest()
        {
            Assert.AreEqual(false, verificator.VerifyPin("1"), "Ответ не верен для кода \"1\"");
            Assert.AreEqual(false, verificator.VerifyPin("12"), "Ответ не верен для кода \"12\"");
            Assert.AreEqual(false, verificator.VerifyPin("123"), "Ответ не верен для кода \"123\"");
            Assert.AreEqual(false, verificator.VerifyPin("12345"), "Ответ не верен для кода \"12345\"");
            Assert.AreEqual(false, verificator.VerifyPin("1234567"), "Ответ не верен для кода \"1234567\"");
            Assert.AreEqual(false, verificator.VerifyPin("-1234"), "Ответ не верен для кода \"-1234\"");
            Assert.AreEqual(false, verificator.VerifyPin("1.234"), "Ответ не верен для кода \"1.234\"");
            Assert.AreEqual(false, verificator.VerifyPin("-1.234"), "Ответ не верен для кода \"-1.234\"");
            Assert.AreEqual(false, verificator.VerifyPin("00000000"), "Ответ не верен для кода \"00000000\"");
        }

        [Test, Description("Букв и знаков быть не должно")]
        public void NonDigitTest()
        {
            Assert.AreEqual(false, verificator.VerifyPin("a234"), "Ответ не верен для кода \"a234\"");
            Assert.AreEqual(false, verificator.VerifyPin(".234"), "Ответ не верен для кода \".234\"");
        }

        [Test, Description("Проверка валидных кодов")]
        public void ValidTest()
        {
            Assert.AreEqual(true, verificator.VerifyPin("1234"), "Ответ не верен для кода \"1234\"");
            Assert.AreEqual(true, verificator.VerifyPin("0000"), "Ответ не верен для кода \"0000\"");
            Assert.AreEqual(true, verificator.VerifyPin("1111"), "Ответ не верен для кода \"1111\"");
            Assert.AreEqual(true, verificator.VerifyPin("123456"), "Ответ не верен для кода \"123456\"");
            Assert.AreEqual(true, verificator.VerifyPin("098765"), "Ответ не верен для кода \"098765\"");
            Assert.AreEqual(true, verificator.VerifyPin("000000"), "Ответ не верен для кода \"000000\"");
            Assert.AreEqual(true, verificator.VerifyPin("090909"), "Ответ не верен для кода \"090909\"");
        }
    }
}
