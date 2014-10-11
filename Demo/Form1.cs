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
    public partial class Form1 : Form
    {
        //Mao ni ang instance sa DAL Controller nga atong gamitun sa CRUD Operations
        IDALController db = null;

        public Form1()
        {
            InitializeComponent();

            this.db = DALFactory.CreateDALController();
        }

        private void buttonAddUserAccount_Click(object sender, EventArgs e)
        {
            //Set Data
            Category category = new Category();
            category.Name = this.textBoxUserName.Text;

            //Add new category to db
            db.CategoryRepo.Add(category);

            RefreshDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        void RefreshDataGrid()
        {
            this.dataGridView1.DataSource = this.db.CategoryRepo.GetAll();
        }
    }
}
