namespace TextParser.SentenceParts
{
    public class Whitespace : ISentencePart
    {
		public string Value
		{
			get;
			private set;
		}

        public Whitespace(string value)
        {
			Value = value;
        }
    }
}
