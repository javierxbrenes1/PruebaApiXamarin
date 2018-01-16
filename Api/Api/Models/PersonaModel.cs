using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class PersonaModel
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Contraseña { get; set; }
        public string FotoPerfil { get; set; }
        public ObservableCollection<ApuestaModel> LstApuestas { get; set; }
    }
}