int count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0;
int number = 4566;
string numberToString = number.ToString();
char[] letters = numberToString.ToCharArray();
char[] letters2 = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

for (int i = 0; i < letters.Length; i++)
{
    for (int j = 0; j < letters2.Length; j++)
    {
        if (letters[i] == '0' && letters2[j] == '0')
        {
            count0++;
        }
        if (letters[i] == '1' && letters2[j] == '1')
        {
            count1++;
        }
        if (letters[i] == '2' && letters2[j] == '2')
        {
            count2++;
        }
        if (letters[i] == '3' && letters2[j] == '3')
        {
            count3++;
        }
        if (letters[i] == '4' && letters2[j] == '4')
        {
            count4++;
        }
        if (letters[i] == '5' && letters2[j] == '5')
        {
            count5++;
        }
        if (letters[i] == '6' && letters2[j] == '6')
        {
            count6++;
        }
        if (letters[i] == '7' && letters2[j] == '7')
        {
            count7++;
        }
        if (letters[i] == '8' && letters2[j] == '8')
        {
            count8++;
        }
        if (letters[i] == '9' && letters2[j] == '9')
        {
            count9++;
        }
    }
}

Console.WriteLine("Wyniki dla liczby 4566 ");
Console.Write("0 => ");
Console.WriteLine(count0);
Console.Write("1 => ");
Console.WriteLine(count1);
Console.Write("2 => ");
Console.WriteLine(count2);
Console.Write("3 => ");
Console.WriteLine(count3);
Console.Write("4 => ");
Console.WriteLine(count4);
Console.Write("5 => ");
Console.WriteLine(count5);
Console.Write("6 => ");
Console.WriteLine(count6);
Console.Write("7 => ");
Console.WriteLine(count7);
Console.Write("8 => ");
Console.WriteLine(count8);
Console.Write("9 => ");
Console.WriteLine(count9);