int[] array = {11, 16, 25, 3, 4, 53, 16, 7, 16, 28, 9};

int n = array.Length;
int find = 16;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index + 1;
}