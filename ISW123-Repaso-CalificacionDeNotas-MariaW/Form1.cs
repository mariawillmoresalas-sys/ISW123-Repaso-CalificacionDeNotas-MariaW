namespace ISW123_Repaso_CalificacionDeNotas_MariaW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {

            int nota = (int)nudNotas.Value;
            string letra;

            if (nota >= 90)
                letra = "A";
            else if (nota >= 80)
                letra = "B";
            else if (nota >= 70)
                letra = "C";
            else
                letra = "F";

            lblLetras.Text = $"{nota} → {letra}";
        }
    }
}
