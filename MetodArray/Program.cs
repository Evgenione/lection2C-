int [] array = {11, 12, 23, 54, 45, 36, 27, 18, 91, 10};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index+1;
    index++;
}