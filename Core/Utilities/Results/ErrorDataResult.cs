using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>

    {
        public ErrorDataResult(T data, string message) : base(data, false, message) // Versiyon 1
        {

        }

        public ErrorDataResult(T data) : base(data, false) // Versiyon 2
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) // Versiyon 3
        {

        }

        public ErrorDataResult() : base(default, false) // Versiyon 4
        {

        }
    }
}
