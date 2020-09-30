using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WCFConsumption.Models
{
    public class TipoServicioCLS
    {
        [Display(Name = "ID")]
        public int IdTipoServicio { get; set; }

        [Display(Name ="Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Tipo")]
        public Boolean Estado { get; set; }

    }
}