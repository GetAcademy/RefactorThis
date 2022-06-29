namespace RefactorThis
{
    internal class WordGenerator
    {
        public static List<string> Run(string pattern)
        {
            var characters = pattern
                .ToUpper()
                .Replace('V', 'A')
                .Replace('K', 'B')
                .ToCharArray();
            var words = new List<string>();
            while (true)
            {
                words.Add(new string(characters));
                var index = 0;
                for (index = characters.Length - 1; index >= 0; index--)
                {
                    var isVowel = pattern[index] == 'V';
                    var listOfCharacters = isVowel ? "AEIOUYÆØÅ" : "BCDFGHJKLMNPQRSTVWXZ";
                    var hasRestarted = GoToNextCharacter(index, listOfCharacters, characters);
                    if (!hasRestarted) break;
                }
                var isLastWord = index == -1;
                if (isLastWord) return words;
            }
        }

        private static bool GoToNextCharacter(int index, string listOfCharacters, char[] characters)
        {
            var i = listOfCharacters.IndexOf(characters[index]);
            var isLastCharacter = i == listOfCharacters.Length - 1;
            var newIndex = isLastCharacter ? 0 : i + 1;
            characters[index] = listOfCharacters[newIndex];
            return isLastCharacter;
        }
    }
}
