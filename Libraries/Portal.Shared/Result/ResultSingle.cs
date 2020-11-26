using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Shared.Result
{
    public class ResultSingle<T> : Result
    {
        public T Value { get; set; }

        public ResultSingle(T value, bool success, string message) : base(success, message)
        {
            Value = value;
        }
    }
}