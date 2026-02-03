using KaperkarNumberTest;
// Mohamadreza Panahandeh


for (int i = 1000; i < 9999; i++)
{
    Console.WriteLine($"\vresult of Kaperkar number for {i} :");
    CalculateIterations calculate = new CalculateIterations();
    string result = calculate.KaperkarNumber(i);
    Console.WriteLine($"\v{result}");
}