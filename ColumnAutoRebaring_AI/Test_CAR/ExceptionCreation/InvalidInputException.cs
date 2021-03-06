﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_CAR
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException():base(ConstantValue.InvalidInput)
        {
        }
    }
    public class InvalidDataException : Exception
    {
        public InvalidDataException() : base(ConstantValue.InvalidData)
        {
        }
    }
    public class InvalidIDException : Exception
    {
        public InvalidIDException() : base(ConstantValue.InvalidID)
        {
        }
    }
    public class NegativeLengthException : Exception
    {
        public NegativeLengthException() : base(ConstantValue.NegativeLength)
        {
        }
    }
    public class NotContainValue1Exception : Exception
    {
        public NotContainValue1Exception() : base(ConstantValue.NotContainValue1)
        {
        }
    }
}
