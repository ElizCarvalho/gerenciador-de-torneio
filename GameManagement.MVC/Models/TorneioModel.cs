using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameManagement.MVC.Models
{
    public class TorneioModel
    {
        public int Id { get; set; }
        public List<JogoModel> inicioTorneio = new List<JogoModel>();
        public List<JogoModel> quartasFinal = new List<JogoModel>();
        public List<JogoModel> semiFinal = new List<JogoModel>();
        public List<JogoModel> final = new List<JogoModel>();

    }
}