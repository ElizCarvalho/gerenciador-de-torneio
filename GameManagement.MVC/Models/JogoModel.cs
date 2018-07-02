using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameManagement.MVC.Models
{
    public class JogoModel
    {
        public int Id { get; set; }
        public TimeModel TimeA { get; set; }
        public int PlacarTimeA { get; set; }
        public TimeModel TimeB { get; set; }
        public int PlacarTimeB { get; set; }
    }
}