public class Comment
{
  string _author;
  string _content;

  public Comment(string author, string content)
  {
    _author = author;
    _content = content;
  }

  public string GetAuthor()
  {
    return _author;
  }

}

