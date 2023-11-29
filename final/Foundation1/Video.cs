public class Video
{
  private string _title;
  private string _author;
  private int _length;
  List<Comment> _comments = new List<Comment>();
  
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  public void DisplayNumberComments()
  {
    Console.WriteLine($"The video has {_comments.Count} comments");
  }

  public void AddComment(Comment comment)
  {
    _comments.Add(comment);
    // Console.WriteLine.WriteLine($"Your comment by {comment.GetAuthor()} was successfully posted on the {_title} video!");
    // Console.WriteLine.WriteLine();
  }

  public void DisplayInformation()
  {
    Console.WriteLine($"Title of the video: {_title}");
    Console.WriteLine($"Author of the video: {_author}");
    Console.WriteLine($"Length of the video: {_length}");
    Console.WriteLine($"Number of comments on the video: {_comments.Count}");
  }

}
