namespace DecoderMorseAlphabet
{
    internal class MorseDecoder
    {
        private static readonly Dictionary<string, char> TextCode = new Dictionary<string, char>
        {
            { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' }, { ".", 'E' },
            { "..-.", 'F' }, { "--.", 'G' }, { "....", 'H' }, { "..", 'I' }, { ".---", 'J' },
            { "-.-", 'K' }, { ".-..", 'L' }, { "--", 'M' }, { "-.", 'N' }, { "---", 'O' },
            { ".--.", 'P' }, { "--.-", 'Q' }, { ".-.", 'R' }, { "...", 'S' }, { "-", 'T' },
            { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' }, { "-.--", 'Y' },
            { "--..", 'Z' }, { ".----", '1' }, { "..---", '2' }, { "...--", '3' }, { "....-", '4' },
            { ".....", '5' }, { "-....", '6' }, { "--...", '7' }, { "---..", '8' }, { "----.", '9' },
            { "-----", '0' }, { "/", ' ' }
        };

        public string Decode(string input)
        {
            var decoded = new List<char>();
            var words = input.Split(' ');
            foreach (var word in words)
            {
                if (TextCode.ContainsKey(word))
                {
                    decoded.Add(TextCode[word]);
                }
            }
            return new string(decoded.ToArray());
        }
    }
}
