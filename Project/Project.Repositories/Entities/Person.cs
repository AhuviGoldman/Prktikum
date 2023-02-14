using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories.Entities
{
    public enum EGender { male, female }
    public enum EHMO { macabi, meuchedet, leumit, klalit }
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
        public List<Child> Children { get; set; }

    }
}
