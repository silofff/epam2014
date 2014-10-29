using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TextParser.Converters;
using TextParser.SentenceParts;

namespace TextParser
{
	public class Concordance
	{
		private IDictionary<string, Position> _concordance;
		private readonly IConverter<string, IDictionary<string, Position>> _converter = new ConvertConcordanceToString ();
		private readonly IList<Word> _words = new List<Word> ();
		private readonly FileReader _fileReader = new FileReader ();
		private readonly Regex _regexWord = new Regex (@"\w+", RegexOptions.IgnoreCase);
		private IList<string> _text;

		public void Create (string fileName, int pagePerRows)
		{
			_text = _fileReader.ReadRows (fileName);
			foreach (var row in _text) {
				var match = _regexWord.Match (row);
				while (match.Success) {
					if (pagePerRows <= 0) return;
                    _words.Add (new Word (match.Value.ToLower ()){ Page = ((_text.IndexOf (row)) / pagePerRows) + 1 });
					match = match.NextMatch ();
				}
			}
		}

		public void GetConcordance ()
		{
			var p = _words.GroupBy(x => x.Value).OrderBy(z => z.Key)
						.Select (z => new {	Word = z.Key, Count = z.Count (), Positions = z.Select(g => g.Page).Distinct().OrderBy(g => g).ToList() });

			_concordance = p.ToDictionary (x => x.Word, x => new Position { NumberOfUse = x.Count, Pages = x.Positions });
		}

		public override string ToString ()
		{
			return _converter.Convert (_concordance);
		}
	}


}
