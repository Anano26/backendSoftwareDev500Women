using System.Linq;

int[] ints = new int[10] { 1, 5, 5, 2, 3, 5, 4, 2, 28, 3};

var countPerElement = ints  .GroupBy(x => x)
                            .ToDictionary(x => x.Key, x=>x.Count())
                            .ToList();

countPerElement.ForEach(x => Console.WriteLine(x.Key.ToString() + ": " + x.Value.ToString() + " times"));
