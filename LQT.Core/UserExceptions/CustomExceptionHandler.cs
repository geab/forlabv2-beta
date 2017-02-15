using System;

namespace LQT.Core.UserExceptions
{
    public struct ExceptionStatus
    {
        public Exception ex;
        public string message;
    }

    public class CustomExceptionHandler
    {
        public static ExceptionStatus ShowExceptionText(Exception ex)
        {
            ExceptionStatus exceptionStatus = new ExceptionStatus();

            exceptionStatus.ex = ex;
            exceptionStatus.message = ex is LQTUserException ?
                ex.ToString() : "Error while trying to read or write into the database, please contact your IT administrator";

            return exceptionStatus;
        }

        public static ExceptionStatus ShowExceptionText(string message, Exception ex)
        {
            ExceptionStatus exceptionStatus = new ExceptionStatus();

            exceptionStatus.ex = ex;
            exceptionStatus.message = message;

            return exceptionStatus;
        }
    }
}
