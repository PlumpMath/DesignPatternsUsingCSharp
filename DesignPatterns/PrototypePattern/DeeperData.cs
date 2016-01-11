using System;

namespace DesignPatterns.PrototypePattern {
    [Serializable]
    public class DeeperData {
        public string Data { get; set; }
        public DeeperData(string s) {
            Data = s;
        }
        public override string ToString() {
            return Data;
        }
    }
}
