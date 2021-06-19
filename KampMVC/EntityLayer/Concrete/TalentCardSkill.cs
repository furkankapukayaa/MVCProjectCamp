using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TalentCardSkill
    {
        [Key]
        public int SkillId { get; set; }
        [StringLength(20)]
        public string Skill { get; set; }
        [StringLength(3)]
        public string SkillPoint { get; set; }
    }
}
