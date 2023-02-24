using System.Linq;

string [] array = {"Hello", "1234", "125", "World", "13", "0", "xx"};


void GetArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        char[] c = array[i].ToCharArray();
        for (int j = 0; j < c.Length;)
        {
            if(c.Length <= 3)
            {
                Console.WriteLine(c);
                break;
            }
            else break;
        }
    }
}

GetArray(array);
