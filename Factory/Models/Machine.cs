using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine's description can't be empty!")]
    public string Description { get; set; }
     [Required(ErrorMessage = "The machine's name can't be empty!")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}