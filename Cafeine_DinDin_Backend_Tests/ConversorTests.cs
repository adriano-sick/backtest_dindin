using Cafeine_DinDin_Backend.Utils;
using NUnit.Framework;
using System;

namespace Cafeine_DinDin_Backend_Tests
{
    public class ConversorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("String test", ExpectedResult = true)]
        [TestCase("String", ExpectedResult = false)]
        public bool MustConvertStringToBase64(string text)
        {
            var encoded = Conversor.EncodeToBase64(text);
            return encoded == "U3RyaW5nIHRlc3Q=";
        }

        [Test]
        [TestCase("U3RyaW5nIHRlc3Q=", ExpectedResult = true)]
        [TestCase("U5EfsQ3mASWed4R=", ExpectedResult = false)]
        public bool MustConvertBase64ToString(string data)
        {
            var decoded = Conversor.DecodeFrom64(data);
            return decoded == "String test";
        }

        [Test]
        [TestCase("Not a data string")]
        public void NotAValidDataTextInput(string text)
        {
            Assert.That(
                () => Conversor.DecodeFrom64ToBytes(text),
                Throws.TypeOf<FormatException>()
                .With.Message.EqualTo(
                    "The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters."));
        }

        [Test]
        [TestCase("U3RyaW5nIHRlc3Q=", ExpectedResult = true)]
        public bool MustReturnAByteCode(string text)
        {
            var byteCode = Conversor.DecodeFrom64ToBytes(text);
            return byteCode.ToString() == "System.Byte[]";
        }
    }
}