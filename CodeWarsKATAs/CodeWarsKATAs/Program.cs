using CodeWarsKATAs.Solutions;


int[][] array =
       {
           new []{1, 2, 3},
           new []{4, 5, 6},
           new []{7, 8, 9}
       };

int[] result = SnailSort.SnailVariant2(array);

string s = String.Join(" ", result);
Console.WriteLine(s);

//