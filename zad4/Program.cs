string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
int number = int.Parse(inputLineN);

string lineN = " ";
string lineNN = string.Empty;
string s = 1;
while (s <= numberN)
{
lineN = lineN + s + " ";
lineNN = linen + (s * s).ToString() + "";
s++;
}
Console.WriteLine(lineN);
Console.WriteLine(lineNN);
}
