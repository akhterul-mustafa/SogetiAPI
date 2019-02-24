using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SogetiAPI.Model
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        private string _heroName;

        public string HeroName { get { return _heroName; } }

        public void SetHeroName()
        {
            _heroName = HeroGenerator.GetHeroName(this.FirstName, this.LastName);
        }
    }
}
