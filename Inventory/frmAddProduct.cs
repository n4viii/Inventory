using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        private int _Quantity;
        private double _SellPrice;

        BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            string[] ListOfProductCategory = {
                "Beverages",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
            };

            foreach (string category in ListOfProductCategory)
            {
                cbCategory.Items.Add(category);
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z ]+$"))
                throw new StringFormatException("Invalid format. Product Name must only contain letters.");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^[0-9 ]"))
                throw new NumberFormatException("Invalid format. Quantity must be a valid integer.");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            string cleanPrice = price.Trim();

            if (!Regex.IsMatch(cleanPrice, @"^(\d*\.)?\d+$"))
                throw new CurrencyFormatException("Invalid format. Selling Price must be a valid currency value.");
            return Convert.ToDouble(cleanPrice);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                

                if (cbCategory.Text == "")
                {
                    MessageBox.Show("Please select a Category", "Category Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtPickerMfgDate.Value > dtPickerExpDate.Value)
                {
                    MessageBox.Show("Manufacturing date cannot be later than expiration date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch (StringFormatException sfe)
            {
                MessageBox.Show(sfe.Message, "String Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show(nfe.Message, "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show(cfe.Message, "Currency Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }
    }

    class NumberFormatException : Exception
    {
        public NumberFormatException(string varName) : base(varName) { }
    }

    class StringFormatException : Exception
    {
        public StringFormatException(string varName) : base(varName) { }
    }

    class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string varName) : base(varName) { }
    }
}