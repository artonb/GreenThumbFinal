using System.ComponentModel.DataAnnotations;

namespace GreenThumbFinal.Models
{
    public class Instructions
    {
        [Key]
        public int InstructionId { get; set; }
        public string Info { get; set; } = null!;
        public int PlantsId { get; set; }
        public Plants? Plants { get; set; }

    }
}
