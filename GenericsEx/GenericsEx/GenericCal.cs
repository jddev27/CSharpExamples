namespace GenericsEx
{
    public class GenericCal<T> 
    {
        private T _value1;
        private T _value2;

        public GenericCal(T val1, T val2)
        {
            _value1 = val1;
            _value2 = val2;

        }

        public T Add(T val1, T val2)
        {
            dynamic a = val2;
            dynamic b = val2;
            return a + b;
        }
    }
}