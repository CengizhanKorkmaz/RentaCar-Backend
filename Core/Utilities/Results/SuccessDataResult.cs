﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {

        public SuccessDataResult(T data,string message):base(data,true,message)
        {
                
        }
        public SuccessDataResult(T data,bool success):base(data,true)
        {

        }
        public SuccessDataResult(IDataResult<User> userToCheck, string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
