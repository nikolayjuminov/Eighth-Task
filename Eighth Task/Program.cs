internal class Program 
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Введите количество чисел");
		bool isParsed = int.TryParse(Console.ReadLine(), out int numberOfNumbers);
		if (isParsed == false)
		{
			Console.WriteLine("Введено некорректное значение, задача завершена... ");
		}
		else
		{
			if (numberOfNumbers > Math.Pow(10, 5))
			{
				Console.WriteLine("Число слишком большое, задача завершена...");
			}
			else
			{
				if (numberOfNumbers < 0)
				{
					Console.WriteLine("Число отрицательное, задача завершена...");
				}
				else
				{
					Console.Write("Введите последовательность чисел через пробел: ");
					int[] filledArray = FillingAnArray(numberOfNumbers);
					if (filledArray.Length <= 1 && filledArray[0] == 3000000)
					{

					}
					else
					{
						int result = NumbersDivisionByTen(filledArray);
						if (result == 0)
						{
							Console.WriteLine("Нет чисел оканчивающихся на 0");
						}
						else
						{
							Console.WriteLine("Количество чисел, которые оканчиваются на 0  " + result);
						}
					}

				}
			}
		}
	}
	private static int[] FillingAnArray(int numberOfNumbers)
	{
		int[] massInput = { 3000000 };
		string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

		if (elements.Length == 0)
		{
			Console.WriteLine("Недостаточно данных, задача завершена...");
		}
		else
		{
			if (elements.Length > numberOfNumbers)
			{
				Console.WriteLine("Слишком много данных, задача завершена...");
			}
			else
			{
				massInput = new int[elements.Length];
				for (int i = 0; i < elements.Length; i++)
				{
					bool isParsed = int.TryParse(elements[i], out massInput[i]);
					if (isParsed == false)
					{
						Console.WriteLine("Введено некорректное значение в элементе " + i + ". Он будет учтен как 0");
					}
					if (Math.Abs(massInput[i]) > 2 * Math.Pow(10, 6))
					{
						Console.WriteLine("Введенный элемент " + i + " за границей понимания. Он будет учтен как 0");
						massInput[i] = 0;
					}
				}
				return massInput;

			}
			return massInput;

		}
		return massInput;

	}
	private static int NumbersDivisionByTen(int[] filledArray)
	{
		int result = 0;
		for (int i = 0; i < filledArray.Length; i++)
		{
			if (Math.Abs(filledArray[i]) % 10 == 0)
			{
				result++;
			}
		}
		return result;
	}
}