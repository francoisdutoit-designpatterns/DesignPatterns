using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    // In this situation the proxy both creates and destroys
    // an ATMMachine Object

    public class ATMProxy : IGetATMData
    {
        // Allows the user to access getATMState in the 
        // Object ATMMachine

        //public IATMState getATMState()
        //{
        //    ATMMachine realATMMachine = new ATMMachine();
        //    return realATMMachine.getATMState();
        //}

        //// Allows the user to access getCashInMachine 
        //// in the Object ATMMachine

        //public int getCashInMachine()
        //{
        //    ATMMachine realATMMachine = new ATMMachine();
        //    return realATMMachine.getCashInMachine();

        //}

    }
}
