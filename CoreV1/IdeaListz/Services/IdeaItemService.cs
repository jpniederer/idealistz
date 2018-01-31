using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdeaListz.Data;
using IdeaListz.Models;
using Microsoft.EntityFrameworkCore;

namespace IdeaListz.Services
{
  public class IdeaItemService : IIdeaItemService
  {
    private readonly ApplicationDbContext _context;

    public IdeaItemService(ApplicationDbContext context)
    {
      _context = context;
    }

    public async Task<IEnumerable<Idea>> GetIdeasAsync()
    {
      return await _context.Ideas.ToArrayAsync();
    }

    public async Task<bool> AddIdeaAsync(NewIdea newIdea, ApplicationUser user)
    {
      var idea = new Idea
      {
        Id = Guid.NewGuid(),
        AuthorId = Guid.NewGuid(),
        IdeaListId = Guid.NewGuid(),
        CreatorId = user.Id,
        IsPublic = true,
        Title = newIdea.Title,
        Description = newIdea.Description,
        CreateTime = DateTimeOffset.Now,
        UpdateTime = DateTimeOffset.Now
      };

      _context.Ideas.Add(idea);

      var saveResult = await _context.SaveChangesAsync();
      return saveResult == 1;
    }
  }
}