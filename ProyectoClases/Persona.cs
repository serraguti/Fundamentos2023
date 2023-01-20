using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Italia, Francia, Brasil }

    public class Persona
    {

        public Persona()
        {
            this.DomicilioVacaciones = new Direccion("AA", "Miami");
        }

        #region CAMPOS DE PROPIEDAD

        private TipoGenero _Genero;
        private int _Edad;

        #endregion

        #region PROPIEDADES 

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino &&
                    value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor no disponible en enumeración");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }

        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public int Edad
        {
            get
            {
                return this._Edad;
            }
            set
            {
                //AQUI DESEAMOS COMPROBAR EL DATO QUE VIENE
                //DENTRO DE value
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        //QUEREMOS DEVOLVER EL NOMBRE COMPLETO EN ORDEN INVERSO
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }

        public void GetNombreCompleto(string dato) { }
        public void GetNombreCompleto(int numero) { }
        public void GetNombreCompleto(int num1, int num2) { }
        public void GetNombreCompleto(int num1, int num2, int num3) { }
        public void GetNombreCompleto(int num1, string dato) { }

        public void MetodoParametrosOpcionales(int numero1
            , int numero2 = 11, int numero3 = 0)
        {}


        #endregion

    }
}
