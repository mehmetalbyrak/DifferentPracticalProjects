using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EntityFrameworkDBFirstProduct
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        Entities dbEntities = new Entities();

        void CategoryList()
        {
            dataGridView1.DataSource = dbEntities.TblCategories.ToList();
            
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblCategory tblCategory = new TblCategory();
            tblCategory.CategoryName = txtCategoryName.Text;
            dbEntities.TblCategories.Add(tblCategory);
            dbEntities.SaveChanges();
            CategoryList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = dbEntities.TblCategories.Find(id);
            dbEntities.TblCategories.Remove(value);
            dbEntities.SaveChanges();
            CategoryList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((string)txtCategoryId.Text);
            var value = dbEntities.TblCategories.Find(id);
            value.CategoryName = txtCategoryName.Text;
            dbEntities.SaveChanges();
            CategoryList();
        }
    }
}
