using System;


namespace Averager
{
	class Program
	{
		static void Main()
		{
			var counter = 0;
			var runningTotal = 0.0;
			var average = 0.0;

			while (true)
			{
				// repetedly prompt the user for numbers
				Console.Write("Please enter a number or enter \"done\" to see average: ");

				var input = Console.ReadLine();

				// on imediate exit of the program, counter is 1 to make average 0
				if (input.ToLower() == "done" && counter == 0)
				{
					counter = 1;
					break;
				}
				else if (input.ToLower() == "done")
				{
					break;
				}

				try
				{
					// convert the input to a double
					var number = double.Parse(input);

					// add together the numbers entered
					runningTotal += number;
					counter += 1;
				}
				catch (FormatException)
				{
					Console.WriteLine("Invalid Input");
					continue;
				}
			}

			// get average of numbers entered
			average = runningTotal / counter;

			while (true)
			{
				// show the average and prompt user to quit
				Console.Write("Thre average of the numbers entered is " + average + ". Enter \"quit\" to exit: ");
				var exitInput = Console.ReadLine();
				if (exitInput.ToLower() == "quit")
				{
					break;
				}
			}
		}
	}
}
