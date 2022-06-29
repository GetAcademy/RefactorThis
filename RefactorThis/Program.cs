using RefactorThis;

var words = WordGenerator.Run("KVK");
foreach (var word in words)
{
    Console.WriteLine(word);
}