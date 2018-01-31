using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using IdeaListz.Services;
using IdeaListz.Models;

namespace IdeaListz.Controllers
{
  [Authorize]
  public class IdeaController : Controller
  {
    private readonly IIdeaItemService _ideaItemService;
    private readonly UserManager<ApplicationUser> _userManager;

    public IdeaController(IIdeaItemService ideaItemService, UserManager<ApplicationUser> userManager)
    {
      _ideaItemService = ideaItemService;
      _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null) return Challenge();

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

      var currentUser = await _userManager.GetUserAsync(User);
      if (currentUser == null) return Unauthorized();

      var successful = await _ideaItemService.AddIdeaAsync(newIdea, currentUser);

      if (!successful)
      {
        return BadRequest(new { error = "Unable to add idea." });
      }

      return Ok();
    }
  }
}