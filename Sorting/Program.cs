using Sorting;

Work work = new Work();
//var createdArray= work.SetArray();
int[] a=new int[] {20,4,3,6,32,8,7,11,10,13,46};
var sortedArray= work.SortingArray(a);
foreach(var item in sortedArray)
{
    Console.WriteLine(item);
}