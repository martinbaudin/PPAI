using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallaImportarActualizacion.Entidades
{
    class TipoUva
    {
        private string nombre;
        private string descripcion;

        public TipoUva(string nombreTipo, string descripcionTipo)
        {
            nombre = nombreTipo;
            descripcion = descripcionTipo;
        }

        public string nombreTipo
        {
            get => nombre;
            set => nombre = value;
        }

        public string descripcionTipo
        {
            get => descripcion;
            set => descripcion = value;
        }

    }
}
