namespace Ejercicio4ADSExamenPractico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            Aeromoza obj = new Aeromoza();
            obj.IdAeromoza = int.Parse(IDAER.Text);
            obj.NombreAeromoza = nombreAER.Text;
            obj.ApellidoAeromoza = ApellidoAER.Text;
            obj.Sueldo = double.Parse(SueldoAER.Text);

            string[] datos = { obj.IdAeromoza.ToString(), obj.NombreAeromoza.ToString(), obj.ApellidoAeromoza.ToString(), obj.Sueldo.ToString() };
            aeromozaRegistry.Rows.Add(datos);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}