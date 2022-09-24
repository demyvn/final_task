string[] old = {"hello", "3", "bold","tr"};
int count = 0;
for (int i = 0; i < old.Length; i++)
{
    if (old[i].Length <= 3)
    {
        count++ ;      
    }
}