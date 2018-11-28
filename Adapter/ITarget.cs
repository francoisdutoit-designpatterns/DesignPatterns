using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }


}
