using System;
using System.ComponentModel.DataAnnotations;

namespace IdeaListz.Models
{
  public class NewIdea
  {
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
  }
}