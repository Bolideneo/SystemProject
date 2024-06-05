using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace ITP4519M
{
    public partial class SupplierContactForm : Form
    {
        private OperationMode _mode;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        public SupplierContactForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierContactForm_Load(object sender, EventArgs e)
        {
            switch (_mode) {
                case OperationMode.Edit:
                    createSupplierBtn.Visible = false;
                    break;
                case OperationMode.New:
                    editSupplierbtn.Visible = false;
                    break;
            }
        }
    }
}
