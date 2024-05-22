namespace EncoderMorseAlphabet
{
    internal class MorseEncoder
    {
        private static readonly Dictionary<char, string> MorseCode = new Dictionary<char, string>
        {
            { 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." }, { 'D', "-.." }, { 'E', "." },
            { 'F', "..-." }, { 'G', "--." }, { 'H', "...." }, { 'I', ".." }, { 'J', ".---" },
            { 'K', "-.-" }, { 'L', ".-.." }, { 'M', "--" }, { 'N', "-." }, { 'O', "---" },
            { 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." }, { 'S', "..." }, { 'T', "-" },
            { 'U', "..-" }, { 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" }, { 'Y', "-.--" },
            { 'Z', "--.." }, { '1', ".----" }, { '2', "..---" }, { '3', "...--" }, { '4', "....-" },
            { '5', "....." }, { '6', "-...." }, { '7', "--..." }, { '8', "---.." }, { '9', "----." },
            { '0', "-----" }, { ' ', "/" }
        };

        public string Encode(string input)
        {
            input = input.ToUpper();
            var encoded = new List<string>();
            foreach (var c in input)
            {
                if (MorseCode.ContainsKey(c))
                {
                    encoded.Add(MorseCode[c]);
                }
            }
            return string.Join(" ", encoded);
        }
    }
}
