﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Core
{
    public interface IBussinessRule
    {
        bool IsValid();

        string Message { get; }
    }
}
