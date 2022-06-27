
using Flipper.Database;
using Flipper.Models;
using Microsoft.AspNetCore.Mvc;

namespace Flipper.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileDatabase profileDatabase;

        public ProfileController(IProfileDatabase profileDatabase)
        {
            this.profileDatabase = profileDatabase;
        }

        public IActionResult Index()
        {
            var vm = profileDatabase.GetProfiles().Select(x => new ProfileListViewModel
            {
                Id = x.Id,
                ProfileName = x.ProfileName
            });
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
