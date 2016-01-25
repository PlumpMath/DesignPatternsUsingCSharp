namespace DesignPatterns.AbstractPattern {
    class ConcreteComputerFactory : ComputerFactory {

        public override Computer GetComputer() {

            return new ConcreteComputer();

        }//GetComputer

    }//ConcreteComputerFactory
}
