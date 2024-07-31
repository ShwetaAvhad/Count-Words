using System;
public class CountWords
{
  public static int CountWordsNumber(string inputString)
  {
	int count=1;
	for (int iterate=0;iterate<inputString.Length;iterate++)
	{
		if(inputString[iterate]==' ')
			count++;
	}
	return count;
  }

  static void Main(String [] args)
  {
	Console.WriteLine("Enter Sentence : ");
	string inputString=Console.ReadLine();
	Console.WriteLine("Total words : "+CountWordsNumber(inputString));
  }
}