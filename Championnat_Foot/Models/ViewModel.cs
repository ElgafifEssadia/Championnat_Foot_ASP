using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Championnat_Foot.Models
{
    public class ViewModel
    {
        public Entrainer entrainer { get; set; }
        public Entraineur entraineur { get; set; }
        public Equipe equipe { get; set; }
        public Equipe equipe1 { get; set; }
        public Saison saison { get; set; }
        public Match match { get; set; }
        public Stade stade { get; set; }
    }
}