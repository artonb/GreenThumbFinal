using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GreenThumbFinal.Models
{
    public class Plants
    {
        [Key]
        public int PlantsId { get; set; }
        public string Name { get; set; } = null!;
        public List<Instructions>? Instructions { get; set; }
    }
}
