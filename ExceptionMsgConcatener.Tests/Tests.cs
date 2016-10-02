using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExceptionMsgConcatener.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void ShouldRunExceptionToException()
        {
            var innerException = new Exception("There was another error");
            var exception = new Exception("There was an error", innerException);

            var newException = ExceptionMsgConcatener.ExceptionToException(exception);
            Assert.AreEqual(newException.Message, $"{exception.Message}, {innerException.Message}");
        }

        [TestMethod]
        public void ShouldRunExceptionToString()
        {
            var innerException = new Exception("There was another error");
            var exception = new Exception("There was an error", innerException);

            var newExceptionMessage = ExceptionMsgConcatener.ExceptionToString(exception);
            Assert.AreEqual(newExceptionMessage, $"{exception.Message}, {innerException.Message}");
        }
    }
}
