namespace TelephoneExchangeLibrary
{
    public class CallData
    {
        public int FromNumber { get; set; }
        public int ToNumber { get; set; }

        public CallData(int from, int to)
        {
            FromNumber = from;
            ToNumber = to;
        }
    }
}
