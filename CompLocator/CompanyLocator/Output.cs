using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignment
{
    public partial class OutputScreen : Form
    {
        public OutputScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method gives the result set in a seperate form
        /// </summary>
        /// <param name="companies"></param>
        public void SetCompanies(List<string> companies)
        {
            foreach (string CompNameAddress in companies)
            {
                lstCompanies.Items.Add(CompNameAddress);
            }
        }
    }
}
