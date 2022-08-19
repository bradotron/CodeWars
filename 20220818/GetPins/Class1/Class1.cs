using System;
using System.Collections.Generic;

namespace Class1
{

	// https://www.codewars.com/kata/5263c6999e0f40dee200059d/train/csharp
	public class Kata
	{
		public static List<string> GetPINs(string observed)
		{
			List<string> possiblePins = new List<string>();

			List<Pin> pins = new List<Pin>();

			foreach (Char c in observed)
			{
				pins.Add(new Pin(c.ToString()));
			}

			PinCombinationAggregator(possiblePins, "", 0, pins);

			return possiblePins;
		}

		public static void PinCombinationAggregator(List<string> combinations, string currentCombination, int pinIndex, List<Pin> pins)
		{
			// if we are in the last possition, we add all possible values to the list
			if (pinIndex == (pins.Count - 1))
			{
				for (int pvi = 0; pvi < pins[pinIndex].PossibleValues.Count; pvi++)
				{
					combinations.Add(currentCombination + pins[pinIndex].PossibleValues[pvi]);
				}
			}
			else
			{
				// create branches for each possible value at this position
				for (int pvi = 0; pvi < pins[pinIndex].PossibleValues.Count; pvi++)
				{
					PinCombinationAggregator(
						combinations,
						currentCombination + pins[pinIndex].PossibleValues[pvi],
						pinIndex + 1,
						pins);
				}

			}
		}
	}



	public class Pin
	{
		public string Value { get; set; }
		public List<string> PossibleValues { get; set; }

		// ┌───┬───┬───┐
		// │ 1 │ 2 │ 3 │
		// ├───┼───┼───┤
		// │ 4 │ 5 │ 6 │
		// ├───┼───┼───┤
		// │ 7 │ 8 │ 9 │
		// └───┼───┼───┘
		//     │ 0 │
		//     └───┘

		public Pin(string value)
		{
			Value = value;

			switch (value)
			{
				case "0":
					PossibleValues = new List<string>() { "0", "8" };
					break;
				case "1":
					PossibleValues = new List<string>() { "1", "2", "4" };
					break;
				case "2":
					PossibleValues = new List<string>() { "1", "2", "3", "5" };
					break;
				case "3":
					PossibleValues = new List<string>() { "2", "3", "6" };
					break;
				case "4":
					PossibleValues = new List<string>() { "1", "4", "5", "7" };
					break;
				case "5":
					PossibleValues = new List<string>() { "2", "4", "5", "6", "8" };
					break;
				case "6":
					PossibleValues = new List<string>() { "3", "5", "6", "9" };
					break;
				case "7":
					PossibleValues = new List<string>() { "4", "7", "8" };
					break;
				case "8":
					PossibleValues = new List<string>() { "5", "7", "8", "9", "0" };
					break;
				case "9":
					PossibleValues = new List<string>() { "6", "8", "9" };
					break;
				default:
					throw new Exception("Invalid PIN");
			}
		}
	}
}