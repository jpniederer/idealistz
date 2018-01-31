using System.Collections.Generic;
using IdeaListz.Models;

namespace IdeaListz
{
  public class ManageUsersViewModel
  {
    public IEnumerable<ApplicationUser> Administrators { get; set; }
    public IEnumerable<ApplicationUser> Everyone { get; set; }
  }
}