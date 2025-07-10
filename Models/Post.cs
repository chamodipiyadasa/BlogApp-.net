namespace BlogApp.Models
{
  public class Post
  {
    public int Id { get; set; }//auto-increment ID
    public string Title { get; set; } = "";
    public String Content { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
  }
}