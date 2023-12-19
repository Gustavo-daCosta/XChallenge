using System;
using System.Collections.Generic;

namespace xchallenge.api.Domains;

public partial class Noticia
{
    public int Id { get; set; }

    public DateTime? Data { get; set; }

    public string? Titulo { get; set; }

    public string? noticia { get; set; }

    public string? Status { get; set; }
}
