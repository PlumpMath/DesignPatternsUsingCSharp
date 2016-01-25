using System;

namespace DesignPatterns.AbstractPattern {
    class AbstractFactoryPatternClient : IDesignPattern {
        public void Run() {
            Console.WriteLine("\n------------------Abstract Factory Pattern------------------");
            ComputerFactory factory = new ConcreteComputerFactory();

            new ComputerAssembler().AssembleComputer(factory);
        }
    }
}
