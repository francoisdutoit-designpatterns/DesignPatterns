using AttackExample;
using Common.Interfaces;
using Proxy;
using Strategy;
using Strategy_AttackGame;
using System;

namespace A_AllUi
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute();
        }

        public  static void Execute()
        {
            IProgram programToExecute;

            //programToExecute = new StrategyProgram();
            //programToExecute.Execute();

            programToExecute = new AttackGame();
            programToExecute.Execute();
            
        }

        //static void AdapterUi()
        //{

        //    EnemyRobot fredTheRobot = new EnemyRobot();

        //    IEnemyAttacker tank = new EnemyTank();
        //    IEnemyAttacker robotAdapter = new EnemyRobotAdapter(fredTheRobot);

        //    Console.WriteLine("The Enemy Tank");
        //    tank.assignDriver("Frank");
        //    tank.driveForward();
        //    tank.fireWeapon();

        //    Console.WriteLine("The Robot with Adapter");
        //    robotAdapter.assignDriver("Mark");
        //    robotAdapter.driveForward();
        //    robotAdapter.fireWeapon();

        //    Console.ReadKey();
        //}


    }
}
