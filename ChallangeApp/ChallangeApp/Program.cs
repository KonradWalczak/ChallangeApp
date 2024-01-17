int number = 2143432137;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

for (int i = 0; i < 10; i++)
{
    var counter = 0;

    foreach (char letter in letters)
    {
        if (i == letter - '0')
        {
            counter++;
        }
        
    }
    Console.WriteLine(i + " => " + counter);
}