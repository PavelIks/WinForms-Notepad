using System.Windows.Forms;

namespace Notebook
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string LocalFontFamily { get; private set; }
        public float LocalFontSize { get; private set; }
        public int LocalFontStyle { get; private set; }
    }
}