using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class ApuestaModel
    {
        public int Id { get; set; }
        public string Jornada { get; set; }
        public bool Finalizada { get; set; }
        public double Puntuacion { get; set; }
        public string Descripcion { get; set; }
        public bool Ganador { get; set; }
        public ObservableCollection<EquipoModel> LstApuestaEquipos { get; set; }
        public ObservableCollection<EquipoModel> LstApuestaResultado { get; set; }
    }
}