using System.Linq;

string myString = "Let's print all Words with Upper caseS";

var output = myString   .Split(' ')
                        .Where(x => x.Any(y => Char.IsUpper(y)))
                        .ToList();

output.ForEach(x => Console.WriteLine(x));