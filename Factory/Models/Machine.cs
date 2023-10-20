using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine's description can't be empty!")]
    public string Description { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "You must add your machine to an engineer. Have you created an engineer yet?")]
    public string Name { get; set; }

    public int EngineerId { get; set; }
    public Engineer Engineer { get; set; }
    public List<EngineerMachine> JoinEntities { get;}
  }
}