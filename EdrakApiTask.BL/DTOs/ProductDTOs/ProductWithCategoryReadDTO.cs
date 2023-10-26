using EdrakApiTask.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdrakApiTask.BL;

public class ProductWithOrderReadDTO
{
    public required int Id { get; set; } 
    public required string Name { get; set; } = string.Empty;
    public required string? Description { get; set; }

    public OrderReadDTO ? Order { get; set; }

}
