using System.Collections.Generic;
using Torchbearer.Models;

namespace Torchbearer.ViewModels
{
    public class SkillsViewModel
    {
        public IEnumerable<SkillViewModel> Skills { get; set; }

        public SkillsViewModel(IList<Skill> skills, IList<SuggestedHelp> suggestedHelp)
        {
            var skillViewModels = new List<SkillViewModel>();
            foreach (var skill in skills)
            {
                skillViewModels.Add(new SkillViewModel(skills, suggestedHelp){ Skill = skill });
            }

            Skills = skillViewModels;
        }
    }
}
