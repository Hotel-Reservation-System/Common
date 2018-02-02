using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models
{
    // This interface will help EF Core track if entities (objects that are to be database records)
    // have been modified in some way. It uses the ObjectState enum.
    public interface IObjectWithState
    {
        ObjectState State { get; set; }
    }


    public enum ObjectState
    {
        Unchanged,
        Added,
        Modified,
        Deleted
    }
}
