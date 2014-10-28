using System.Text.RegularExpressions;

namespace TextParser.SentenceParts
{
    public class Word : ISentencePart
	{
	
		public string Value
		{
			get;
			private set;
		}

        public Word(string value)
        {
			Value = value;
        }

        public int Page
        {
            get;
            set;
        }

        public int Lenght()
        {
            return Value.Length;
        }

        public bool IsVowel()
        {
            var match = Regex.Match(Value, @"^(A|E|I|O|U|Y)", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}

