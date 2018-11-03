using System.Collections.Generic;
using System.Linq;
using Torchbearer.Models;

namespace Torchbearer.ViewModels
{
    public class SkillViewModel
    {
        public Skill Skill { get; set; }
        public IEnumerable<string> SuggestedHelpSkills { get; set; }

        public SkillViewModel(IList<Skill> allSkills, IEnumerable<SuggestedHelp> suggestedHelpSkills)
        {
            SuggestedHelpSkills = from skill in allSkills
                                  join suggestedHelpSkill in suggestedHelpSkills on skill.Id equals suggestedHelpSkill.SkillId
                                  join skill2 in allSkills on suggestedHelpSkill.SuggestedHelpSkillId equals skill2.Id
                                  where skill.Id == Skill.Id
                                  select skill2.Name;
        }
    }
}
