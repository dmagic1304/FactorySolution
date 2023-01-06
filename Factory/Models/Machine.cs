using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }

        [Required(ErrorMessage = "The machine's name can't be empty!")]
        public string Name { get; set; }
        public List<EngineerMachine> JointEntities { get; }
    }
}