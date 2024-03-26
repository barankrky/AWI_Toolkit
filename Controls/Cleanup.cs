using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
