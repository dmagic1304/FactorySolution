using System.Collections.Generic;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId { get; set; }

        [Required(ErrorMessage = "The engineer's name can't be empty!")]
        public string Name { get; set; }
        public List<EngineerMachine> JointEntities { get; }
    }
}