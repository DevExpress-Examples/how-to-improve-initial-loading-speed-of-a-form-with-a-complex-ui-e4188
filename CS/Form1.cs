using System;
using System.Windows.Forms;

namespace RichEditLoadingSpeed {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            System.Threading.Thread.Sleep(5000); // Emulate initialization delay
        }

        private void button1_Click(object sender, EventArgs e) {
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
        }
    }
}