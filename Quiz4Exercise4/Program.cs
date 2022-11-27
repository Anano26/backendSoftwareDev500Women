
using System.Linq;

int[] myArray = new int[10] {2, 1, 4, 11, 2, 1, 45, 2, 3, 7 };

int min = 2;
int max = 15;

myArray .Where(x => x >= min && x <= max)
        .OrderBy(x => x)
        .ToList()
        .ForEach(x => Console.WriteLine(x));