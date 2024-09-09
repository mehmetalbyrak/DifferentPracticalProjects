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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        Entities db = new Entities();

        void ProductList()
        {
            dataGridViewProduct.DataSource = db.TblProducts.ToList();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProduct tblProduct = new TblProduct();
            tblProduct.ProductPrice = Convert.ToDecimal(txtProductPrice.Text);
            tblProduct.ProductStock = Convert.ToInt32(txtProductStock.Text);
            tblProduct.ProductName = txtProductName.Text;
            tblProduct.CategoryId = Convert.ToInt32(cmbProductCategory.SelectedValue.ToString());

            db.TblProducts.Add(tblProduct);
            db.SaveChanges();
            ProductList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var value = db.TblProducts.Find(Convert.ToInt32(txtProductId.Text));
            db.TblProducts.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProducts.Find(Convert.ToInt32(txtProductId.Text));
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductStock = int.Parse(txtProductStock.Text);
            value.ProductName = txtProductName.Text;
            value.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            var values = db.TblCategories.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = values;
        }

        private void btnListWithCategory_Click(object sender, EventArgs e)
        {
            var query = from product in db.TblProducts
                        join category in db.TblCategories
                        on product.CategoryId equals category.CategoryId
                        select new
                        {
                            ProductId = product.ProductId,
                            ProductName = product.ProductName,
                            ProductPrice = product.ProductPrice,
                            ProductStock = product.ProductStock,
                            CategoryId = category.CategoryId,
                            CategoryName = category.CategoryName
                        };

            var values = query.ToList();

            dataGridViewProduct.DataSource = values;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = db.TblProducts.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridViewProduct.DataSource = values;
        }
    }
}
