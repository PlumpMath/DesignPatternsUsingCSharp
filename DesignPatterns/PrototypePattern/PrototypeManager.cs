using System.Collections.Generic;

namespace DesignPatterns.PrototypePattern {
    public class PrototypeManager {
        public Dictionary<string, Prototype> prototypes
       = new Dictionary<string, Prototype> {
        {"Germany",
         new Prototype("Germany", "Berlin", "German")},
        {"Italy",
         new Prototype("Italy", "Rome", "Italian")},
        {"Australia",
         new Prototype("Australia", "Canberra", "English")}
     };
    }
}
