using System.Linq;

int[] ints = new int[10] { 3, 5, 5, 2, 3, 5, 4, 2, 28, 3 };

var countPerElement = ints.GroupBy(x => x)
                            .ToDictionary(x => x.Key, x => x.Count());

countPerElement .Where(x => x.Value == countPerElement.Values.Max())
                .Select(x => x.Key)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

