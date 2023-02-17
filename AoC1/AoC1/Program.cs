
List<int> numbersList = new List<int>();
int currentNumber = 0;


using (StreamReader reader = new StreamReader("Text.txt"))
{
    string line;

    while ((line = reader.ReadLine()) != null)
    {
        if (int.TryParse(line, out int parsedNumber))
        {
            
            currentNumber += parsedNumber;
        }
        else if (line.Trim() == "")
        {
            numbersList.Add(currentNumber);
            currentNumber = 0;
        }
    }
    if(((line = reader.ReadLine()) == null))
    {
        numbersList.Add(currentNumber);
        currentNumber = 0;
    }
};


Console.WriteLine(numbersList.Max());

