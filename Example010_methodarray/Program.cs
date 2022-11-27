int[] array = {89, 66, 3, 4, 150, 14, -12, 7, 150};

int n = array.Length;
int find = 150; 
int index = 0;

while(index < n)
{
    if(array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}