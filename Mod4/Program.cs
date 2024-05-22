using EncoderMorseAlphabet;
using DecoderMorseAlphabet;

namespace Mod4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____TASK 1_____\n");
            Game game = new Game();
            game.Start();

            Console.WriteLine("\n_____TASK 2_____\n");
            var encoder = new MorseEncoder();
            var decoder = new MorseDecoder();

            Console.WriteLine("Enter the text to be translated into Morse code:");
            var inputText = Console.ReadLine();
            var encodedText = encoder.Encode(inputText);
            Console.WriteLine("Text in Morse code:");
            Console.WriteLine(encodedText);

            Console.WriteLine("Enter text in Morse code to be translated into plain text:");
            var inputMorse = Console.ReadLine();
            var decodedText = decoder.Decode(inputMorse);
            Console.WriteLine("Translated text:");
            Console.WriteLine(decodedText);

        }
    }
}