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
  }
}