using System.Windows.Forms;

namespace AWI_Toolkit.Controls
{
    public partial class Cleanup : UserControl
    {
        public Cleanup()
        {
            InitializeComponent();

            lblControlName.Text = "Cleanup";
            lblControlDescription.Text = "Clean the leftover files after Windows Installation.";


        }
    }
}
