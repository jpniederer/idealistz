using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdeaListz.Models;

namespace IdeaListz.Services
{
  public class FakeIdeaItemService : IIdeaItemService
  {
    public Task<IEnumerable<Idea>> GetIdeasAsync()
    {
      IEnumerable<Idea> ideas = new[]
      {
        new Idea
        {
          Title = "Learn ASP.NET Core",
          Description = "I should really learn ASP.NET Core in depth.",
          IsPublic = true,
          UpdateTime = DateTimeOffset.Now,
          CreateTime = DateTimeOffset.Now
        },
        new Idea
        {
          Title = "Build IdeaListz Web App",
          Description = "Build the IdeaListz web app and users will flock to it.",
          IsPublic = true,
          UpdateTime = DateTimeOffset.Now,
          CreateTime = DateTimeOffset.Now
        }
      };
      
      return Task.FromResult(ideas);
    }
  }
}