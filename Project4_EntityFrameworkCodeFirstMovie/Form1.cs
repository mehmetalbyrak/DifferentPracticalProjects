using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values = movieContext.Categories.Find(id);
            movieContext.Categories.Remove(values);
            movieContext.SaveChanges();

            MessageBox.Show("Process is done as successfully :d");
        }

        MovieContext movieContext = new MovieContext();  
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = movieContext.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            movieContext.Categories.Add(category);
            movieContext.SaveChanges();
            MessageBox.Show("Process is done as successfully :d");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCategoryId.Text);
            var value = movieContext.Categories.Find(id);
            value.CategoryName = txtCategoryName.Text;

            var values = movieContext.Categories.ToList();
            dataGridView1.DataSource = values;

            movieContext.SaveChanges();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = movieContext.Categories
                .Where(x => x.CategoryName.Contains(txtCategoryName.Text))
                .ToList();

            dataGridView1.DataSource= values;


        }
    }
}
