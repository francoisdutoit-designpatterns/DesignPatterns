using AttackExample;
using System;

namespace A_AllUi
{
    class Program
    {
        static void Main(string[] args)
        {
            AdapterUi();
            BridgeUi();
            BuilderUi();
            ChainOfResponsibilityUi();
            CommandUi();
            CompositeUi();
            DecoratorUi();
            EventAggregatorUi();
            FacadeUi();
            FactoryUi();
            FlyweightUi();
            InterpreterUi();
            IteratorUi();
            LazyLoadUi();
            MediatorUi();
            MementoUi();
            ModelViewPresenterUi();
            ModelViewViewModelUi();
            NullObjectUi();
            ObserverUi();
            PrototypeUi();
            ProxyUi();
            RepositoryUi();
            RulesUi();
            ServiceLocatorUi();
            SingletonUi();
            SpecificationUi();
            StateUi();
            StrategyUi();
            TemplateMethodUi();
            UnitOfWorkUi();
            VisitorUi();
        }

        static void AdapterUi() {

            EnemyRobot fredTheRobot = new EnemyRobot();

            IEnemyAttacker tank = new EnemyTank();
            IEnemyAttacker robotAdapter = new EnemyRobotAdapter(fredTheRobot);

            Console.WriteLine("The Enemy Tank");
            tank.assignDriver("Frank");
            tank.driveForward();
            tank.fireWeapon();

            Console.WriteLine("The Robot with Adapter");
            robotAdapter.assignDriver("Mark");
            robotAdapter.driveForward();
            robotAdapter.fireWeapon();

            Console.ReadKey();
        }
        static void BridgeUi() { }
        static void BuilderUi() { }
        static void ChainOfResponsibilityUi() { }
        static void CommandUi() { }
        static void CompositeUi() { }
        static void DecoratorUi() { }
        static void EventAggregatorUi() { }
        static void FacadeUi() { }
        static void FactoryUi() { }
        static void FlyweightUi() { }
        static void InterpreterUi() { }
        static void IteratorUi() { }
        static void LazyLoadUi() { }
        static void MediatorUi() { }
        static void MementoUi() { }
        static void ModelViewPresenterUi() { }
        static void ModelViewViewModelUi() { }
        static void NullObjectUi() { }
        static void ObserverUi() { }
        static void PrototypeUi() { }
        static void ProxyUi() { }
        static void RepositoryUi() { }
        static void RulesUi() { }
        static void ServiceLocatorUi() { }
        static void SingletonUi() { }
        static void SpecificationUi() { }
        static void StateUi() { }
        static void StrategyUi() { }
        static void TemplateMethodUi() { }
        static void UnitOfWorkUi() { }
        static void VisitorUi() { }

    }
}
