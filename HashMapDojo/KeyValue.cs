namespace HashMapDojo
{
    public class KeyValue
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public KeyValue(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
