using DeskSolution.Win.Pessoas;

namespace DeskSolution.Win.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PessoaConsultaForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}