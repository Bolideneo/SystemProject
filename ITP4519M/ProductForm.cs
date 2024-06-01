using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using ProgramMethod;
using MySql.Data.MySqlClient;

namespace ITP4519M
{
    public partial class ProductForm : Form
    {
        ProgramMethod.ProgramMethod programMethod;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void productForm_Load(object sender, EventArgs e)
        {
            programMethod = new ProgramMethod.ProgramMethod();
//Tim add
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void productClosebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stockAddProductbtn_Click(object sender, EventArgs e)
        {
            string selected = this.productCategorybox.GetItemText(this.productCategorybox.SelectedItem);
            if (programMethod.createProductinfo(productNamebox.Text.Trim(), selected, productWarehousebox.Text.Trim(), productserialbox.Text.Trim(), productUnitpricebox.Text.Trim(), productCostbox.Text.Trim(), productWeightbox.Text.Trim(), productAutoOrderbox.Text.Trim(), productInStockbox.Text.Trim(), productReOrderbox.Text.Trim(), productDangerbox.Text.Trim(), productdemandbox.Text.Trim(), productDescriptionbox.Text.Trim(), productStatusbox.GetItemText(this.productStatusbox.SelectedItem)))
            {

                productNamebox.Text = "";
                productCategorybox.SelectedItem = null;
                productWarehousebox.Text = "";
                productserialbox.Text = "";
                productUnitpricebox.Text = "";
                productCostbox.Text = "";
                productWeightbox.Text = "";
                productAutoOrderbox.Text = "";
                productInStockbox.Text = "";
                productReOrderbox.Text = "";
                productDangerbox.Text = "";
                productdemandbox.Text = "";
                productdemandbox.Text = "";
                productStatusbox.SelectedItem = null;
            }
        }

        }

    }
     

