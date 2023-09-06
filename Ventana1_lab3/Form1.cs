namespace Ventana1_lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fruta;
            float pago, pagot, km;
            int cajas;
            
            fruta = txtFruta.Text;
            cajas = int.Parse(txtCajas.Text);
            km = float.Parse(txtDistancia.Text);
            pago = 0f;

            switch (fruta.ToLower())
            {
                case "naranja":
                    if (km < 30)
                    {
                        pago = 2f;
                    }
                    else
                    {
                        pago = 4f;
                    }
                    break;
                case "fresa":
                    if (km < 30)
                    {
                        pago = 6f;
                    }
                    else
                    {
                        pago = 9f;
                    }
                    break;
                case "mango":
                    if (km < 30)
                    {
                        pago = 3f;
                    }
                    else
                    {
                        pago = 5f;
                    }
                    break;
            }
            pagot = pago * cajas;

            txtPagot.Text = Convert.ToString(pagot);
        }
    }
}