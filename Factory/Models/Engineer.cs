using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }
        [Required(ErrorMessage = "The engineer's Name can't be empty!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The engineer's description can't be empty!")]
        public string Description { get; set; }
        public List<EngineerMachine> JoinEntities { get; }
    }
}