using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessObjects;

using DataAccessObjects.Models;
namespace Demo
{
    public partial class ProductDetailsForm : Form
    {
        //FIELDS
        IDALController db = null;
        Product product = null;

        public ProductDetailsForm()
            :this(new Product())
        {
        }

        public ProductDetailsForm(Product product)
        {
            InitializeComponent();
            //INITIALIZE sa db
            this.db = DALFactory.CreateDALController();
            //Set Product
            this.product = product;

            //MAP Model To View
            BindProductToControl();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            //load categories to comboBox
            this.comboBoxCategory.DataSource = this.db.CategoryRepo.GetAll();
            this.comboBoxCategory.ValueMember = "ID";
            this.comboBoxCategory.DisplayMember = "Name";
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //Set product data
                //MAP VIEW To Model
                this.product.Name = this.textBoxName.Text;
                this.product.Description = this.textBoxDescription.Text;
                this.product.CategoryID = Convert.ToInt32(this.comboBoxCategory.SelectedValue);

                //INSERT to DB
                this.db.ProductRepo.Add(this.product);
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        void BindProductToControl()
        {
            //Map model to view
            this.textBoxName.Text = this.product.Name;
            this.textBoxDescription.Text = this.product.Description;
            this.comboBoxCategory.SelectedValue = this.product.CategoryID;
        }

    }
}
