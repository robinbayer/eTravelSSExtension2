using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TCH_ODC_BF_CDriver
{

    [ComVisible(true)]
    [Guid("F932FCBE-87DC-403F-B530-D042A5B3E7AD")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IInteropController
    {

        void BogusFunction();

    }
}
