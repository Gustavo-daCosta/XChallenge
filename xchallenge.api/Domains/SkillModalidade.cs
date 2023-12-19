﻿using System;
using System.Collections.Generic;

namespace xchallenge.api.Domains;

public partial class SkillModalidade
{
    public int Id { get; set; }

    public int? Idskill { get; set; }

    public string? Idmodalidade { get; set; }

    public virtual Modalidade? IdmodalidadeNavigation { get; set; }

    public virtual Skill? IdskillNavigation { get; set; }
}
