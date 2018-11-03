using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Torchbearer.Models;
using Torchbearer.ViewModels;

namespace Torchbearer.Controllers
{
    public class SkillsController : Controller
    {
        private readonly UnionLarpContext _unionLarpContext;

        public SkillsController(UnionLarpContext unionLarpContext)
        {
            _unionLarpContext = unionLarpContext;
        }

        public IActionResult Index()
        {
            var skills = _unionLarpContext.Skills.ToList();
            var suggestedHelpSkills = _unionLarpContext.SuggestedHelp.ToList();

            var viewModel = new SkillsViewModel(skills, suggestedHelpSkills);

            return View(viewModel);
        }
    }
}
