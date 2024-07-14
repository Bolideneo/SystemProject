using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ITP4519M.DataBaseMethod;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ITP4519M
{
    public partial class SupplierContactForm : Form
    {
        private OperationMode _mode;
        ProgramMethod.ProgramMethod programMethod = new ProgramMethod.ProgramMethod();
        private string supplierID;
        public event EventHandler OperationCompleted;
        private string productID;
        private int stockindex = -1;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public bool IsOperationSuccessful { get; private set; }
        public SupplierContactForm(OperationMode mode)
        {
            InitializeComponent();
            _mode = mode;
            IsOperationSuccessful = false;
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = programMethod.overviewStockinfo();
            suppliedProductData.DataSource = products;
            suppliedProductData.Columns["SerialNumber"].Visible = false;
            //     suppliedProductData.Columns["ProductCategory"].Visible = false;
            suppliedProductData.Columns["BinLocation"].Visible = false;
            suppliedProductData.Columns["UnitPrice"].Visible = false;
       //     suppliedProductData.Columns["CostPrice"].Visible = false;
            suppliedProductData.Columns["QuantityInStock"].Visible = false;
            suppliedProductData.Columns["DemandStock"].Visible = false;
            suppliedProductData.Columns["Status"].Visible = false;
            contactPersonAlert.Visible = false;
            addressAlert.Visible = false;
            companyNameAlert.Visible = false;
            productSelectAlert.Visible = false;

        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
 (
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);

        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierContactForm_Load(object sender, EventArgs e)
        {
            IntPtr handle = CreateRoundRectRgn(0, 0, Width, Height, 40, 40);
            Region = System.Drawing.Region.FromHrgn(handle);

            switch (_mode)
            {
                case OperationMode.Edit:
                    createSupplierBtn.Visible = false;
                    break;
                case OperationMode.New:
                    editSupplierbtn.Visible = false;
                    break;
            }
        }



        private void editSupplierbtn_Click(object sender, EventArgs e)
        {
            var supplierDetails = programMethod.getSupplierDetails(supplierID);
            string supplierid = supplierDetails.SupplierID;
            string supplierCompanyName = suppliernameBox.Text.Trim();
            string supplierContactName = supplierContactBox.Text.Trim();
            string supplierMail = SupplierMailBox.Text.Trim();
            string supplierPhoneNum = SupplierPhoneNumBox.Text.Trim();
            string supplierAddress = supplierAddressBox.Text.Trim();
            List<string> selectedProductIDs = GetSelectedProductIDs();
            if (string.IsNullOrEmpty(supplierCompanyName))
            {
                companyNameAlert.Visible = true;
                suppliernameBox.Focus();
                return;
            }
            else
            {
                companyNameAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierContactName))
            {
                contactPersonAlert.Visible = true;
                contactPersonAlert.Focus();
                return;
            }
            else
            {
                contactPersonAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierMail) || !IsValidEmail(supplierMail))
            {
                mailAlert.ForeColor = Color.Red;
                SupplierMailBox.Focus();
                return;
            }
            else
            {
                mailAlert.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierPhoneNum) || !IsValidPhoneNumber(supplierPhoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                SupplierPhoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierAddress))
            {
                addressAlert.Visible = true;
                supplierAddressBox.Focus();
                return;
            }
            else
            {
                addressAlert.Visible = false;
                Refresh();
            }

            if (selectedProductIDs.Count == 0)
            {

                productSelectAlert.Visible = true;
                return;
            }
            else
            {
                productSelectAlert.Visible = false;
                Refresh();
            }

            DataTable products = programMethod.GetProducts(selectedProductIDs);
            if (products == null || products.Rows.Count == 0)
            {
                productSelectAlert.Visible = true;
                return;
            }
            else
            {
                productSelectAlert.Visible = false;
                Refresh();
            }
            if (programMethod.updateSupplierInfo(supplierid, supplierCompanyName, supplierContactName, supplierMail, supplierPhoneNum, supplierAddress, products))
            {

                MessageBox.Show("Saved");
                OperationCompleted?.Invoke(this, new EventArgs());
                IsOperationSuccessful = true;
            }
            else
            {

            }
        }
        public void supplierEdit(string supplierID)
        {

            this.supplierID = supplierID;

            try
            {

                var supplierDetails = programMethod.getSupplierDetails(supplierID);
                if (supplierDetails != null)
                {
                    this.suppliernameBox.Text = supplierDetails.SupplierCompanyName;
                    this.supplierContactBox.Text = supplierDetails.SupplierContactPerson;
                    this.SupplierMailBox.Text = supplierDetails.SupplierEmail;
                    this.SupplierPhoneNumBox.Text = supplierDetails.SupplierPhoneNum;
                    this.supplierAddressBox.Text = supplierDetails.SupplierAddress;

                }
                else
                {
                    MessageBox.Show("Product details not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void suppliedProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                bool currentValue = Convert.ToBoolean(this.suppliedProductData.Rows[e.RowIndex].Cells["stockcheckColumn"].Value);
                this.suppliedProductData.Rows[e.RowIndex].Cells["stockcheckColumn"].Value = !currentValue;
            }
        }

        private List<string> GetSelectedProductIDs()
        {
            List<string> selectedProductIDs = new List<string>();

            foreach (DataGridViewRow row in suppliedProductData.Rows)
            {
                if (Convert.ToBoolean(row.Cells["stockcheckColumn"].Value))
                {
                    string productID = row.Cells[1].Value.ToString();
                    selectedProductIDs.Add(productID);

  
                }
            }

            return selectedProductIDs;
        }

        private void createSupplierBtn_Click(object sender, EventArgs e)
        {
            string supplierCompanyName = suppliernameBox.Text.Trim();
            string supplierMail = SupplierMailBox.Text.Trim();
            string supplierPhoneNum = SupplierPhoneNumBox.Text.Trim();
            string supplierAddress = supplierAddressBox.Text.Trim();
            string supplierContactName = supplierContactBox.Text.Trim();
            List<string> selectedProductIDs = GetSelectedProductIDs();

            if (string.IsNullOrEmpty(supplierCompanyName))
            {
                companyNameAlert.Visible = true;
                suppliernameBox.Focus();
                return;
            }
            else
            {
                companyNameAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierContactName))
            {
                contactPersonAlert.Visible = true;
                contactPersonAlert.Focus();
                return;
            }
            else
            {
                contactPersonAlert.Visible = false;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierMail) || !IsValidEmail(supplierMail))
            {
                mailAlert.ForeColor = Color.Red;
                SupplierMailBox.Focus();
                return;
            }
            else
            {
                mailAlert.ForeColor = Color.SteelBlue;
                Refresh();
            }
            if (string.IsNullOrEmpty(supplierPhoneNum) || !IsValidPhoneNumber(supplierPhoneNum))
            {
                phoneAlertlbl.ForeColor = Color.Red;
                SupplierPhoneNumBox.Focus();
                return;
            }
            else
            {
                phoneAlertlbl.ForeColor = Color.SteelBlue;
                Refresh();
            }  
            if (string.IsNullOrEmpty(supplierAddress))
            {
                addressAlert.Visible = true;
                supplierAddressBox.Focus();
                return;
            }
            else
            {
                addressAlert.Visible = false;
                Refresh();
            }

            if (selectedProductIDs.Count == 0)
            {

                productSelectAlert.Visible = true;
                return;
            }
            else
            {
                productSelectAlert.Visible = false;
                Refresh();
            }

            DataTable products = programMethod.GetProducts(selectedProductIDs);
            if (products == null || products.Rows.Count == 0)
            {
                productSelectAlert.Visible = true;
                return;
            }
            else
            {
                productSelectAlert.Visible = false;
                Refresh();
            }
            if (programMethod.createSupplier(supplierCompanyName, supplierMail, supplierPhoneNum, supplierAddress, supplierContactName, products))
            {
                MessageBox.Show("Supplier Contacts Successfully Added");
                suppliernameBox.Text = "";
                SupplierMailBox.Text = "";
                SupplierPhoneNumBox.Text = "";
                supplierAddressBox.Text = "";
                OperationCompleted?.Invoke(this, new EventArgs());
                IsOperationSuccessful = true;
                
            }


        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phoneNum)
        {
            return phoneNum.Length >= 6 && phoneNum.Length <= 13;
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Control.MousePosition;
            dragFormPoint = this.Location;
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Control.MousePosition, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }


    }
}
