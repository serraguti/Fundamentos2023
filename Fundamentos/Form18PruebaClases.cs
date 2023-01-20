using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form18PruebaClases : Form
    {
        public Form18PruebaClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Domicilio = new Direccion("Calle Pez", "Madrid", 28050);

            this.lstDatos.Items.Add("Nombre: " + persona.Nombre.ToUpper());
            this.lstDatos.Items.Add("Direccion: " + persona.Domicilio.Calle);

            this.lstDatos.Items.Add
                ("Direccion Vacaciones: " + persona.DomicilioVacaciones.Calle);


            persona.Apellidos = "Net Core";
            persona.Edad = 29;
            persona.Nacionalidad = Paises.Italia;
            persona.Genero = TipoGenero.Femenino;

            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(88, 99);
            persona.MetodoParametrosOpcionales(1, 2, 3);
            //SOLO QUIERO ENVIAR EL PARAMETRO 1 Y EL 2
            persona.MetodoParametrosOpcionales(1, numero2: 2);

            

            this.lstDatos.Items.Add(persona.Nombre + " "
                + persona.Apellidos + ", Edad: " + persona.Edad);
            this.lstDatos.Items.Add(persona.Genero + ", "
                + persona.Nacionalidad);
            this.lstDatos.Items.Add(persona.GetNombreCompleto());
            this.lstDatos.Items.Add(persona.GetNombreCompleto(true));
        }
    }
}
