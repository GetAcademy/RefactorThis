if (args.Length < 1)
{
    Console.WriteLine("RefactorThis <pattern> - pattern kan for eksempel være KVK");
    return;
}

var vowels = "AEIOUYÆØÅ";
var consonants = "BCDFGHJKLMNPQRSTVWXZ";
var pattern = args[0].ToUpper();
var counters = pattern.Select(c => c == 'V' ? 'A' : 'B').ToArray();
var lastWord = pattern.Select(c => c == 'V' ? 'Å' : 'Z').ToArray();
while (new string(counters) != new string(lastWord))
{
    Console.WriteLine(counters);
    var index = counters.Length - 1;
    while (index >= 0 && counters[index] < 'Y') index--;
    if (index == -1) return;
    if (pattern[index] == 'V')
    {
        var i = vowels.IndexOf(counters[index]);
        counters[index] = vowels[i + 1];
    }
    else if (pattern[index] == 'K')
    {
        var i = consonants.IndexOf(counters[index]);
        counters[index] = consonants[i + 1];
    }
}
