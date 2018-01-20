using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IdeaListz.Models;

namespace IdeaListz.Services
{
  public interface IIdeaItemService
  {
    Task<IEnumerable<Idea>> GetIdeasAsync();

    Task<bool> AddIdeaAsync(NewIdea newIdea);
  }
}