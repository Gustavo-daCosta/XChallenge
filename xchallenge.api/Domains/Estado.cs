﻿using System;
using System.Collections.Generic;

namespace xchallenge.api.Domains;

public partial class Estado
{
    public string Sigla { get; set; } = null!;

    public string? Estado1 { get; set; }

    public virtual ICollection<Competidor> Competidors { get; set; } = new List<Competidor>();
}
