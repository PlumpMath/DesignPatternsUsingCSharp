using DesignPatterns.AbstractPattern;
using DesignPatterns.PrototypePattern;

namespace DesignPatterns {
    class DesignPatternFactory {

        public IDesignPattern PrototypePattern() {
            return new PrototypeClient();
        }

        public IDesignPattern AbstractPattern() {
            return new AbstractFactoryPatternClient();
        } 
    }
}
