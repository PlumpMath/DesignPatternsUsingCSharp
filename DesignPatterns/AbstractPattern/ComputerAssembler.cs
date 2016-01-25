using System;

namespace DesignPatterns.AbstractPattern {
    class ComputerAssembler {
        public void AssembleComputer(ComputerFactory factory) {

            Computer computer = factory.GetComputer();
            Console.WriteLine("Assembled a {0} running at {1} MHz",
               computer.GetType().FullName, computer.Mhz);

        }//AssembleComputer
    }
}
