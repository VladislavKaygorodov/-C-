int[] array = {19,28,73,49,53,56,16,72,38,49};

int n = array.Length;
int find = 49;

int index = 0;
while (index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}

