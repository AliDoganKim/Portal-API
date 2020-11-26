using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Shared.Result
{
    public class Result
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public Result(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public static Result<T> Ok<T>(IQueryable<T> value, string message)
        {
            return new Result<T>(value, true, message);
        }

        public static ResultSingle<T> Ok<T>(T value, string message)
        {
            return new ResultSingle<T>(value, true, message);
        }

        public static Result<T> Fail<T>(string message)
        {
            return new Result<T>(null, false, message);
        }
    }
}