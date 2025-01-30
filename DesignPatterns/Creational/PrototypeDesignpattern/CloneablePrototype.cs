using Newtonsoft.Json;

namespace DesignPatterns.Creational.PrototypeDesignpattern
{
    public abstract class CloneablePrototype<T>
    {
        // shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // deep copy
        public T? DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}
