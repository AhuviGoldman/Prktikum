using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.DTOs
{
    public enum EGenderDTO { male, female }
    public enum EHMODTO { macabi, meuchedet, leumit, klalit }
    public class PersonDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EGenderDTO Gender { get; set; }
        public EHMODTO HMO { get; set; }
        public List<ChildDTO> Children { get; set; }

    }
}
