﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrakApiTask.BL;

public class ProductCreateDTO
{
    public required string Name { get; set; } = string.Empty;
    public required string? Description { get; set; }
    public required int OrderId { get; set; }

}
