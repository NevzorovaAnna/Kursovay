using System;
using System.Collections.Generic;

namespace тренажер;

public partial class progress
{
    public int id { get; set; }

    public string urov { get; set; } = null!;

    public int time { get; set; }

    public int mistakes { get; set; }
}
