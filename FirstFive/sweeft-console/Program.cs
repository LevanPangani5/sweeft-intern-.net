// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

#region testing Console 
Console.WriteLine(isPalindrome("arra"));
Console.WriteLine("---------------------------------------");
Console.WriteLine(MinSplit(120));
Console.WriteLine("---------------------------------------");
int[] arr = new int[] { 1, 4, 5, 8, 3, 45, 77, 54, 33, 12,2 };
Console.WriteLine(NotContains(arr));
Console.WriteLine("---------------------------------------");
Console.WriteLine(isProperly("(())())"));
Console.WriteLine("---------------------------------------");
Console.WriteLine(CountVariants(10));
Console.WriteLine("---------------------------------------");
Console.WriteLine("End");
#endregion

#region isPalindrome

static bool isPalindrome(string txt)
 {
    int start = 0;
    int end = txt.Length-1;
    while (start < txt.Length / 2)
    {
       if (txt[start] != txt[end])
        return false;
        start++;
        end--;
    }
    return true;
 }
#endregion

#region MinSplit
static int MinSplit(int amount)
{  //just for the demonstration purposes :)
    Dictionary<decimal, decimal> results = new();
    //Floor method was getting decimal and returning decimal too so i am using it too dd
    decimal[] tools = new decimal[] { 50, 20, 10, 5, 1 };
    int fResult=0;
    decimal amountd = amount;

    for(int i = 0; i < tools.Length; i++)
    {  //if its greater than 1 it means i can subtract it from amount if not find smaller one to subtract it
       //from amount
        if ( amountd/ Math.Floor(tools[i]) >=1)
        {
            results.Add(tools[i], Math.Floor(amountd / tools[i]));
            amountd -= Math.Floor(amountd / tools[i]) * tools[i];
        }
    }
    //displaying which coins where used and how many times 
    foreach(var result in results)
    {
        Console.WriteLine(result.Key + " - " + result.Value);
    }
    //counting total amount of coins
    foreach (var result in results)
    {
        fResult += Decimal.ToInt32(result.Value);
    }

    return fResult;
}
#endregion

#region MinSplit
static int NotContains(int[] array)
{
    int value = 1;
    //while loop does not stop until it finds smallest intiger that does not exist in array 
    while (true)
    {
        if (!array.Contains(value))
        {
            return value;
        }
        value++;
    }
}
#endregion

#region isProperly
static bool isProperly(string sequence)
{
    int level = 0;

    for(int i = 0; i < sequence.Length; i++)
    {
        if (sequence[i] == ')' && level == 0)
        {
            return false;
        }
        if (sequence[i] == '(')
            level++;

        if (sequence[i] ==')')
            level--;
    }

    if (level != 0)
        return false;
    else 
    return true;
}
#endregion

#region CountVariants
// to be honest i just googled it and found the algorithm so yeah thats it :)
static int CountVariants(int stairCount)
{
    int first = 0;
    int second = 1;
    int temp;
 
    for(int i = 1; i < stairCount; i++)
    {
        temp = second;
        second += first;
        first = temp;
       
    }
    return first + second;
}

#endregion