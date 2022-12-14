// // Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых <= 3 символа. 

Console.WriteLine("Создадим массив из нескольких значений");
Console.WriteLine("Какое колличество значений будем вводить?");
int countArray = int.Parse(Console.ReadLine() ?? "0");

string [] startArray = new string [countArray];
 
 string [] FillArray (string [] array)
 {
	for (int i = 0; i < countArray; i++)
	{
		Console.WriteLine($"Введите {i} значение:");
		array[i] = Console.ReadLine() ?? "0";
	}
	return array;
}
string [] SortArray (string [] array)
{
	int countNecessaryValue = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) countNecessaryValue++;
	}

	string [] endArray = new string [countNecessaryValue];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			endArray[index] = array[i];
			index++;
		}
	}
	return endArray;
}

void PrintArray (string [] array)
{
	if (array.Length == 0) Console.WriteLine("Массив не имеет значений!");
		for (int i = 0; i < array.Length; i++)
		{
			Console.Write($" [{array[i]}]");
		}
}

FillArray(startArray);
string [] endArray = SortArray(startArray);
Console.WriteLine("Первоначальный массив: ");
PrintArray(startArray);
Console.WriteLine();
Console.WriteLine("Новый массив из значений <= 3 символам: ");
PrintArray(endArray);