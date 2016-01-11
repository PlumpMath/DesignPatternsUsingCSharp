using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.PrototypePattern {
    [Serializable]
    public abstract class PrototypeBase<T> {

        // Shallow clone
        public T Clone() {
            return (T)this.MemberwiseClone();
        }

        //Deep Clone
        public T DeepClone() {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}
