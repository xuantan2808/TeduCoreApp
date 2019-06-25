using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Interfaces
{
    public interface IHasSoftDeletecs
    {
        bool IsDeleted { set; get; }
    }
}
