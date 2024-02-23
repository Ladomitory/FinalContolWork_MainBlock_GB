const int ARRAY_SIZE = 10;
const int STRING_MAX_SIZE = 10;
Random _rand = new Random();

String[] originArray = GenerateStringArray(ARRAY_SIZE);
Console.WriteLine("Origin Array");
PrintArray(originArray);
String[] resultArray = SplittingArrayElements(originArray);
Console.WriteLine("Result Array");
PrintArray(resultArray);

String[] SplittingArrayElements(String[] origArray)
{
    String[] tempArray = new String[origArray.Length * (STRING_MAX_SIZE / 3)];
    String newString;
    int newElementIndex = 0;
    for (int origElementIndex = 0; origElementIndex < origArray.Length; origElementIndex++)
    {
        newString = "";
        for (int charIndex = 0; charIndex < origArray[origElementIndex].Length; charIndex++)
        {
            newString += originArray[origElementIndex][charIndex];
            if (newString.Length == 3 || charIndex + 1 == origArray[origElementIndex].Length)
            {
                tempArray[newElementIndex] = newString;
                newElementIndex++;
                newString = "";
            }
        }
    }
    String[] resArray = new String[newElementIndex];
    for (int elementIndex = 0; elementIndex < resArray.Length; elementIndex++)
    {
        resArray[elementIndex] = tempArray[elementIndex];
    } 
    return resArray;
}

String[] GenerateStringArray(int size)
{
    String[] newArray = new String[size];
    String newString;
    int newStringSize;
    for (int elementIndex = 0; elementIndex < size; elementIndex++)
    {
        newString = "";
        newStringSize = _rand.Next(1, STRING_MAX_SIZE + 1);
        for (int charIndex = 0; charIndex < newStringSize; charIndex++)
        {
            newString += (char) _rand.Next(32, 127);
        }
        newArray[elementIndex] = newString;        
    }
    return newArray;
}

void PrintArray(String[] array)
{
    Console.WriteLine("[");
    for (int elementIndex = 0; elementIndex < array.Length; elementIndex++)
    {
        Console.WriteLine($"<< {array[elementIndex]} >>");
    }
    Console.WriteLine("]");
}