﻿using System;
using System.Collections.Generic;
using System.Text;
using TeduCoreApp.Data.Enum;

namespace TeduCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
