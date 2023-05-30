using System;
using System.Collections.Generic;

namespace api_server.Models;

public partial class Platform
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
