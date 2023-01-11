namespace Fundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //AQUI ESCRIBIREMOS NUESTRAS ACCIONES AL PULSAR EL BOTON
            //TENEMOS PROPIEDADES DE TIPO PRIMITIVO
            this.txtNombre.Width = 150;
            this.btnPulsar.Text = "Botón pulsado!!!";
            //TENEMOS PROPIEDADES QUE SON DE TIPO OBJETO
            this.txtNombre.Location = new Point(70, 100);
            //TENEMOS PROPIEDADES DE TIPO ENUMERADAS
            //UNA ENUMERACION SON UNA SERIE DE VALORES QUE 
            //SE REPRESENTAN DE FORMA GRAFICA Y AYUDAN AL 
            //PROGRAMADOR
            this.txtNombre.TextAlign = HorizontalAlignment.Center;
            this.BackColor = Color.Beige;
        }
    }
}