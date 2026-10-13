namespace P01;

internal static class Program
{
  internal static void Main()
  {
    PracticeTask userSelect = PracticeTask.PrintEnumValueToConsole;

    switch (userSelect)
    {
      case PracticeTask.PrintEnumValueToConsole:

        Console.WriteLine(Season.Spring);
        break;

      default:
        break;
    }
  }
}

enum PracticeTask
{
  PrintEnumValueToConsole,
  Ëx2,
}

enum Season
{
  Spring,
  Summer,
  Autumn,
  Winter,
}
