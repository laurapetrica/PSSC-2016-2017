﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StudentModel.Behavior
{
    interface IAssign<T>
    {
        void assign(T type);
    }
}