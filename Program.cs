namespace P01;

internal static class Program
{
  internal static void Main()
  {
    PracticeTask userSelect = PracticeTask.SeasonalActivities;

    switch (userSelect)
    {
      case PracticeTask.PrintEnumValueToConsole:

        Console.WriteLine(Season.Spring);
        break;

      case PracticeTask.SeasonalActivities:

        List<SeasonalActivity> seasonalActivities =
        [
          new(Season.Summer, "Warm"),
          new(Season.Spring, "Life"),
          new(Season.Autumn, "cold"),
          new(Season.Winter, "snow"),
        ];

        foreach (SeasonalActivity seasonalActivity in seasonalActivities)
        {
          Console.WriteLine($"Nu är det {seasonalActivity.Season}");
        }
        break;

      default:
        break;
    }
  }
}

enum PracticeTask
{
  PrintEnumValueToConsole,
  SeasonalActivities,
}

public enum Season
{
  Spring,
  Summer,
  Autumn,
  Winter,
}

public class SeasonalActivity(Season season, string activity)
{
  public Season Season { get; private set; } = season;
  public string Activity { get; private set; } = activity;
}
