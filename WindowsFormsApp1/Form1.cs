using System.Windows.Forms;
using ClassLibrary_NetStandard20;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Text = Class1.GetData();
        }
    }
}
