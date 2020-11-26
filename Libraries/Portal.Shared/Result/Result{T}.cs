using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portal.Shared.Result
{
    public class Result<T> : Result
    {
        public IQueryable<T> Value { get; set; }

        public Result(IQueryable<T> value, bool success, string message)
                : base(success, message)
        {
            Value = value;
        }
    }
}