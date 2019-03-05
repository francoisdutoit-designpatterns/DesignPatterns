using AttackExample;
using Common.Interfaces;
using Proxy;
using Strategy;
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
            programToExecute = new StrategyProgram();
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
        //static void BridgeUi() { }
        //static void BuilderUi() { }
        //static void ChainOfResponsibilityUi() { }
        //static void CommandUi() { }
        //static void CompositeUi() { }
        //static void DecoratorUi() { }
        //static void EventAggregatorUi() { }
        //static void FacadeUi() { }
        //static void FactoryUi() { }
        //static void FlyweightUi() { }
        //static void InterpreterUi() { }
        //static void IteratorUi() { }
        //static void LazyLoadUi() { }
        //static void MediatorUi() { }
        //static void MementoUi() { }
        //static void ModelViewPresenterUi() { }
        //static void ModelViewViewModelUi() { }
        //static void NullObjectUi() { }
        //static void ObserverUi() { }
        //static void PrototypeUi() { }
        //static void Proxy()
        //{

        //    ////ATMMachine atmMachine = new ATMMachine();

        //    ////atmMachine.insertCard();

        //    ////atmMachine.ejectCard();

        //    ////atmMachine.insertCard();

        //    ////atmMachine.insertPin(1234);

        //    ////atmMachine.requestCash(2000);

        //    ////atmMachine.insertCard();

        //    ////atmMachine.insertPin(1234);

        //    ////// NEW STUFF : Proxy Design Pattern Code
        //    ////// The interface limits access to just the methods you want
        //    ////// made accessible

        //    ////IGetATMData realATMMachine = new ATMMachine();

        //    ////IGetATMData atmProxy = new ATMProxy();

        //    ////Console.WriteLine("\nCurrent ATM State " + atmProxy.getATMState());

        //    ////Console.WriteLine("\nCash in ATM Machine $" + atmProxy.getCashInMachine());

        //    // The user can't perform this action because ATMProxy doesn't
        //    // have access to that potentially harmful method
        //    // atmProxy.setCashInMachine(10000);
        //}
        //static void RepositoryUi() { }
        //static void RulesUi() { }
        //static void ServiceLocatorUi() { }
        //static void SingletonUi() { }
        //static void SpecificationUi() { }
        //static void StateUi() { }
        //static void Strategy()
        //{

        //}
        //static void TemplateMethodUi() { }
        //static void UnitOfWorkUi() { }
        //static void VisitorUi() { }

    }
}
