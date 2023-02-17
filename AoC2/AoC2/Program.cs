
List<int> numbersList = new List<int>();
int currentNumber = 0;


using (StreamReader reader = new StreamReader("Text.txt"))
{
    string line;

    while ((line = reader.ReadLine()) != null)
    {
        if (int.TryParse(line, out int parsedNumber))
        {
            // Wenn eine Zahl gelesen wurde, füge sie zur aktuellen Summe hinzu
            currentNumber += parsedNumber;
        }
        else if (line.Trim() == "")
        {
            numbersList.Add(currentNumber);
            currentNumber = 0;
        }
    }
    if (((line = reader.ReadLine()) == null))
    {
        numbersList.Add(currentNumber);
        currentNumber = 0;
    }

    for (int i = 0; i < numbersList.Count(); i++)
    {
        Console.WriteLine(numbersList[i]);
    }
    
    Console.WriteLine();

    numbersList.Sort();
    numbersList.Reverse();

    for (int i = 0; i < numbersList.Count(); i++)
    {
        Console.WriteLine(numbersList[i]);
    }

    Console.WriteLine();
    int gesamtcal = 0;

    for (int i = 0; i < 3; i++)
    {
        gesamtcal += numbersList[i];
    }
    Console.WriteLine(gesamtcal);
};


