﻿namespace EdrakApiTask.BL;

public class OrderCreateDTO
{
    public required string Name { get; set; } = string.Empty;
    public required int InStock { get; set; }
}
