using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdeaListz.Services;
using IdeaListz.Models;

namespace IdeaListz.Controllers
{
  public class IdeaController : Controller
  {
    private readonly IIdeaItemService _ideaItemService;

    public IdeaController(IIdeaItemService ideaItemService)
    {
      _ideaItemService = ideaItemService;
    }

    public async Task<IActionResult> Index()
    {
      var ideas = await _ideaItemService.GetIdeasAsync();

      var model = new IdeaViewModel()
      {
        Ideas = ideas
      };

      return View(model);
    }

    public async Task<IActionResult> AddIdea(NewIdea newIdea)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var successful = await _ideaItemService.AddIdeaAsync(newIdea);

      if (!successful)
      {
        return BadRequest(new { error = "Unable to add idea." });
      }

      return Ok();
    }
  }
}