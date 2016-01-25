using System;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {
            var designPattern = new DesignPatternFactory();
            designPattern.PrototypePattern().Run();
            designPattern.AbstractPattern().Run();
            Console.ReadKey();
        }
    }
}
