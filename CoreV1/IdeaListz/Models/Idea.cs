using System;

namespace IdeaListz.Models
{
  public class Idea
  {
    public Guid Id { get; set; }
    public Guid IdeaListId { get; set; }
    public Guid AuthorId { get; set; }
    public string CreatorId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsPublic { get; set; }
    public DateTimeOffset CreateTime { get; set; }
    public DateTimeOffset UpdateTime { get; set; }
  }
}