namespace Practica13
{
    public partial class Form1 : Form
    {

        private Form activrforms = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void openChildform(Form childForm)
        {
            if (activrforms != null)
            {
                activrforms.Close();
            }

            activrforms = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contexpanel.Controls.Add(childForm);
            contexpanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void conversor1_Click(object sender, EventArgs e)
        {
            openChildform(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildform(new Form3());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildform(new Form4());

        }
    }
}