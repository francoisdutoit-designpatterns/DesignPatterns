using System;

namespace AttackExample
{
    //This is what the client expect to be working with -it is the adapters 
    //task to make new classes compatible with this interface
    public interface IEnemyAttacker
    {
        void fireWeapon();
        void driveForward();
        void assignDriver(string driverName);
    }
}
