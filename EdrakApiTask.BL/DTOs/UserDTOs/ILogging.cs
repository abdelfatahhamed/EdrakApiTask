﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrakApiTask.BL;

public interface ILogging
{
    public string Email { get; set; }
    public string Password { get; set; }
}
