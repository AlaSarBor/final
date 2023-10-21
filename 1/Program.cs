int count = 0;
int z = 0;
string[] userStrArray = new string[count];
string elementOfStrArray = "";
string[] userStrArrayCopy = new string[count];
string[] craeteStrArrayCopy = new string[z];
string[] craeteStrArray = new string[z];
Console.WriteLine("Введите элементы массива");
do
{
    elementOfStrArray = Console.ReadLine()!;
    if (elementOfStrArray != "")
    {
        count++;
        userStrArrayCopy = new string[count];

        for (int i = 0; i < userStrArrayCopy.Length - 1; i++)
            userStrArrayCopy[i] = userStrArray[i];

        userStrArrayCopy[count - 1] = elementOfStrArray;
        userStrArray = userStrArrayCopy;
    }
} while (elementOfStrArray != "");
for (int i = 0; i < count; i++)
{
    if (userStrArray[i].Length <= 3)
    {
        z++;
        craeteStrArrayCopy = new string[z];
        for (int j = 0; j < craeteStrArrayCopy.Length - 1; j++)
            craeteStrArrayCopy[j] = craeteStrArray[j];

        craeteStrArrayCopy[z - 1] = userStrArray[i];
        craeteStrArray = craeteStrArrayCopy;
    }
}
Console.Write("[\"{0}\"]", string.Join(" \",\"", userStrArray));
Console.Write("->");
Console.Write("[\"{0}\"]", string.Join(" \",\"", craeteStrArray));