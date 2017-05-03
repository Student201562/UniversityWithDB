using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaUniversityWithDB {
    public partial class fMain : Form {
        public fAccrueSalary accrueSalary = new fAccrueSalary();
        public fMain() {
            InitializeComponent();
        }

        private void butAccureSalary_Click(object sender, EventArgs e) {
            accrueSalary.ShowDialog();
        }
    }
}
