using System;
using System.Collections.Generic;
using System.Text;

namespace AttackExample
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }

        public void driveForward()
        {
            theRobot.WalkForward();
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }
    }
}
