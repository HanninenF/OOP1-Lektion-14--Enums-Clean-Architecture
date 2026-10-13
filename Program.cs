namespace P01;

internal static class Program
{
  internal static void Main()
  {
    PracticeTask userSelect = PracticeTask.ManagingObjectStateWithEnumsAndMethods;

    switch (userSelect)
    {
      case PracticeTask.PrintEnumValueToConsole:

        Console.WriteLine(Season.Spring);
        break;

      case PracticeTask.UsingEnumPropertiesAndInitializingObjectsWithConstructors:

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

      case PracticeTask.UsingEnumsAsMethodParametersToHandleMenuOptions:
        string userInput = Console.ReadLine() ?? "";
        int.TryParse(userInput, out int parsedInput);

        MenuOption menuOption = (MenuOption)parsedInput;

        HandleMenuOption(menuOption);
        break;

      case PracticeTask.ManagingObjectStateWithEnumsAndMethods:
        BlogPost blogPost = new("Idag var det lärorikt", "Har gjort.......");
        Present present = new(blogPost);
        present.PrintBlogPostToConsole();
        blogPost.Publish();
        present.PrintStateToConsole();
        blogPost.UnPublish();
        present.PrintStateToConsole();
        blogPost.EditContent("Har gjort massa sånt....");
        present.PrintBlogPostToConsole();
        blogPost.Publish();
        present.PrintStateToConsole();
        blogPost.Archive();
        present.PrintStateToConsole();

        break;
      default:
        break;
    }
  }

  private static void HandleMenuOption(MenuOption menuOption)
  {
    Console.WriteLine($"Du har valt {menuOption}");
  }
}

enum PracticeTask
{
  PrintEnumValueToConsole,
  UsingEnumPropertiesAndInitializingObjectsWithConstructors,
  UsingEnumsAsMethodParametersToHandleMenuOptions,
  ManagingObjectStateWithEnumsAndMethods,
}

public class Present(BlogPost blogPost)
{
  public void PrintBlogPostToConsole()
  {
    Console.WriteLine($"Title: {blogPost.Title}\nContent: {blogPost.Content}");
  }

  public void PrintStateToConsole()
  {
    Console.WriteLine(blogPost.State);
  }
}

public class BlogPost(string title, string content)
{
  public string Title { get; private set; } = title;
  public string Content { get; private set; } = content;
  public PostState State { get; private set; } = PostState.Draft;

  public void Publish()
  {
    State = PostState.Published;
  }

  public void UnPublish()
  {
    State = PostState.UnPublished;
  }

  public void Archive()
  {
    State = PostState.Archived;
  }

  public void EditContent(string content)
  {
    Content = content;
  }
}

public enum PostState
{
  Draft,
  Published,
  UnPublished,
  Archived,
}

public enum MenuOption
{
  StartGame,
  LoadGame,
  Settings,
  Exit,
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
