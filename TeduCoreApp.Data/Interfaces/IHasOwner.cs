﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerID { get; set; }
    }
}
