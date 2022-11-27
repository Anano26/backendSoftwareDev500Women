using System.Linq;

string myString = "Let's count characters";

var countPerElement = myString.GroupBy(x => x)
                            .ToDictionary(x => x.Key, x => x.Count())
                            .ToList();

countPerElement.ForEach(x => Console.WriteLine(x.Key.ToString() + ": " + x.Value.ToString() + " times"));
