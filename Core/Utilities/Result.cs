﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
        public Result(bool success,string message)
        {
            Success = success;
            Message = message;
        }
    }
}
