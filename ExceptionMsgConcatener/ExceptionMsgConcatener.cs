using System;

namespace ExceptionMsgConcatener
{
    public static class ExceptionMsgConcatener
    {
        public static string ExceptionToString(Exception exception)
        {
            var newException = ExceptionToException(exception);

            return GetExceptionMessage(newException);
        }

        public static Exception ExceptionToException(Exception exception)
        {
            var messages = GetExceptionMessage(exception);

            var baseException = exception;
            while (baseException.InnerException != null)
            {
                baseException = baseException.InnerException;
                messages += $", {GetExceptionMessage(baseException)}";
            }

            exception = new Exception(messages);

            return exception;
        }

        private static string GetExceptionMessage(Exception exception)
        {
            return exception.Message;
        }
    }
}
