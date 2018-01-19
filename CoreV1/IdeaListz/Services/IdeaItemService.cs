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
  }
}