int[] array = { 1, 2, 3, 54, 56, 7, 8, 54, };

int n = array.Length;
int find = 54;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        //break;
    }
    index++;
}