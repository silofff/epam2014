namespace TextParser.SentenceParts
{
    class Punctuation : ISentencePart
    {
		public string Value
		{
			get;
			private set;
		}

        public Punctuation(string value)
        {
			Value = value;
        }
    }
}
