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
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }

        MovieContext movieContext = new MovieContext();
        void CategoryList()
        {
            var values = movieContext.Categories.ToList();
            cmbMovieCategory.DisplayMember = "CategoryName";
            cmbMovieCategory.ValueMember = "CategoryId";
            cmbMovieCategory.DataSource = values;
        }
        private void FrmMovie_Load(object sender, EventArgs e)
        {
            CategoryList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtMovieTitle.Text;
            movie.Description = txtDescription.Text;
            movie.CreatedDate = DateTime.Parse(maskedTxtCreatedDate.Text);
            movie.CategoryId = int.Parse(cmbMovieCategory.SelectedValue.ToString());
            movie.MovieLength = int.Parse(txtMovieLength.Text);
            movieContext.Movies.Add(movie);
            movieContext.SaveChanges();

            MessageBox.Show(" done :d ");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = movieContext.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = movieContext.Movies.Find(id);

            movieContext.Movies.Remove(value);
            movieContext.SaveChanges();

            MessageBox.Show(" deleted :d ");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = movieContext.Movies
                .Where(x=>x.MovieTitle == txtMovieTitle.Text)
                .ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMovieId.Text);
            var value = movieContext.Movies.Find(id);
            value.MovieLength = Convert.ToInt32(txtMovieLength.Text);
            value.MovieTitle = txtMovieTitle.Text;
            value.Description = txtDescription.Text;
            value.CreatedDate = DateTime.Parse(maskedTxtCreatedDate.Text);
            value.CategoryId = Convert.ToInt32(cmbMovieCategory.SelectedValue.ToString());

            movieContext.SaveChanges();

            MessageBox.Show(" updated :d ");

        }

        private void btnListWithCategory_Click(object sender, EventArgs e)
        {
            
            var values = movieContext.Movies
                .Join(movieContext.Categories,
                    movie => movie.CategoryId,
                    category => category.CategoryId,
                    (movie, category) => new
                    {
                        MovieId = movie.MovieId,
                        MovieTitle = movie.MovieTitle,
                        Description = movie.Description,
                        MovieLength = movie.MovieLength,
                        CategoryName = category.CategoryName
                    })
                .ToList();

            
            dataGridView1.DataSource = values;

        }
    }
}
