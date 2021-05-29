using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class UserInformation : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Tc_No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int City { get; set; }
    }
}
