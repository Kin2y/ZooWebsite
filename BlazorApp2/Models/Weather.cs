using System;
using System.Collections.Generic;

namespace BlazorApp2.Models;

public partial class Weather
{
    public int WeatherId { get; set; }

    public string Location { get; set; } = null!;

    public float TempC { get; set; }

    public float TempF { get; set; }

    public string Climate { get; set; } = null!;
}
