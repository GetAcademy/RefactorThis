var vowels = "AEIOUYÆØÅ";
var consonants = "BCDFGHJKLMNPQRSTVWXZ";
var pattern = args[0].ToUpper();
var characters = pattern.Select(c => c == 'V' ? 'A' : 'B').ToArray();
while (true)
{
    Console.WriteLine(characters);
    var index = characters.Length - 1;
    var continueToNextCharacter = true;
    while (continueToNextCharacter)
    {
        if (pattern[index] == 'V')
        {
            if (characters[index] == 'Å')
            {
                if (index == 0) return;
                characters[index] = 'A';
            }
            else
            {
                var i = vowels.IndexOf(characters[index]);
                characters[index] = vowels[i + 1];
                continueToNextCharacter = false;
            }
        }
        else if (pattern[index] == 'K')
        {
            if (characters[index] == 'Z')
            {
                if (index == 0) return;
                characters[index] = 'B';
            }
            else
            {
                var i = consonants.IndexOf(characters[index]);
                characters[index] = consonants[i + 1];
                continueToNextCharacter = false;
            }
        }

        index--;
    }
}
