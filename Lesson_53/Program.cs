


/*
string str = null;

Console.WriteLine(str ?? "noy data");
*/

int[] myArray = new int[1];

myArray ??= new int[0];

Console.WriteLine(myArray.Length);