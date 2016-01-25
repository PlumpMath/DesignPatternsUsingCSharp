namespace DesignPatterns.AbstractPattern {
    class ConcreteComputer : Computer {

        int _mhz = 500;

        public override int Mhz
        {

            get { return _mhz; }

        }//Mhz

    }//ConcreteComputer
}
