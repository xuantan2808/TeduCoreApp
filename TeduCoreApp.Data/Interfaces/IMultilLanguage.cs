﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Interfaces
{
    public interface IMultilLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
