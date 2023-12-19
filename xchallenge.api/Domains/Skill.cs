using System;
using System.Collections.Generic;

namespace xchallenge.api.Domains;

public partial class Skill
{
    public int IdSkill { get; set; }

    public string? Descricao { get; set; }

    public virtual ICollection<SkillModalidade> SkillModalidades { get; set; } = new List<SkillModalidade>();
}
