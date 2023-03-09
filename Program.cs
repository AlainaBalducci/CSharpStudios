// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

//added notepad text file to use the text to run through my letter counting program
string text = System.IO.File.ReadAllText(@"C:\Users\student\desktop\help.txt");
//Console.WriteLine("Give me a sentence!!!!  ");

//string lorem = Console.ReadLine().ToLower();

//string lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> letterCount = new Dictionary<char, int>();

foreach (char c in text)
{
    if (Char.IsLetter(c))
    {


        if (letterCount.ContainsKey(c))
        {
            letterCount[c]++;
        }
        else
        {
            letterCount.Add(c, 1);
        }
    }
}

foreach (KeyValuePair<char, int> letter in letterCount)
{
    Console.WriteLine($"{letter.Key}: {letter.Value}");
}