using System;
using System.Collections.Generic;

namespace xchallenge.api.Domains;

public partial class Notum
{
    public int IdNota { get; set; }

    public int? SeqNota { get; set; }

    public virtual ICollection<NotaCompetidor> NotaCompetidors { get; set; } = new List<NotaCompetidor>();
}
