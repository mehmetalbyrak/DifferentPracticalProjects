using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameworkStatistics
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        ProjectStatisticsDBEntities db = new ProjectStatisticsDBEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Total Category Number
            int categoryCount = db.TblCategories.Count();
            lblCategoryCount.Text = categoryCount.ToString();

            // Total Product Number
            int productCount = db.TblProducts.Count();
            lblProductCount.Text = productCount.ToString();

            // Total Customer Number
            int customerCount = db.TblCustomers.Count();
            lblCustomerCount.Text = customerCount.ToString();
            

            // Total Order Number
            int orderCount = db.TblOrders.Count();
            lblOrderCount.Text = orderCount.ToString();

            // Total Product Stock Number
            int totalProductStockCount = Convert.ToInt32(db.TblProducts.Sum(x => x.ProductStock));
            lblTotalProductStock.Text = totalProductStockCount.ToString();

            // Average Product Price
            var avgProductPrice = db.TblProducts.Average(x => x.ProductPrice);
            lblAverageProductPrice.Text = avgProductPrice.ToString() + "₺";

            // Total Fruit Stock
            var totalProductCountByCategoryIsFruit = db.TblProducts.
                Where(x => x.CategoryId == 1).
                Sum(y => y.ProductStock);
            lblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFruit.ToString();


            // Total Gain of Cola
            var totalPriceByProductNameIsColaGetStock = db.TblProducts.
                Where(x=>x.ProductName == "Cola").
                Select(x => x.ProductStock).FirstOrDefault();

            var totalPriceByProductNameIsColaGetUnitPrice = db.TblProducts.
                Where(x=>x.ProductName == "Cola").
                Select(x=>x.ProductPrice).FirstOrDefault();

            var totalGainOfCola = totalPriceByProductNameIsColaGetStock * totalPriceByProductNameIsColaGetUnitPrice;
            lblTotalGainOfCola.Text = totalGainOfCola.ToString();



            // Total Number of Products Where (Stock Number is smaller than 100)
            var totalCountOfProductsWhereIsStockNumberSmallerThan100 = db.TblProducts.
                Where(x => x.ProductStock < 100).Count();
            lblProductStockSmallerThan100.Text = totalCountOfProductsWhereIsStockNumberSmallerThan100.ToString();


            // Count of Active Vegetable Stock

            var vegetableCategoryId = db.TblCategories
                .Where(c => c.CategoryName == "Vegetable")
                .Select(c => c.CategoryId)
                .FirstOrDefault();

            var productStockCountByCategoryNameIsVegetableAndStatusIsTrue = db.TblProducts
                .Where(p => p.CategoryId == vegetableCategoryId && p.ProductStatus == true)
                .Sum(p => p.ProductStock);


            lblActiveVegetableStockCount.Text = productStockCountByCategoryNameIsVegetableAndStatusIsTrue.ToString();

            // Count of Orders From France with SQL

            var orderCountFromFrance = db.Database.SqlQuery<int>("select count(*) from TblOrder where CustomerId In (\r\n  select CustomerId from TblCustomer Where CustomerCountry = 'France')").
                FirstOrDefault();

            lblOrderCountFromFrance.Text = orderCountFromFrance.ToString();


            // Count of Orders From France with EF

            var frenchCustomerId = db.TblCustomers
                .Where(x => x.CustomerCountry == "France")
                .Select(y => y.CustomerId)
                .ToList();

            var orderCountFromFranceWithEF = db.TblOrders
                .Count(z => frenchCustomerId.Contains(z.CustomerId.Value)) // contains works like "in" here
                .ToString();

            lblOrderCountFromFranceWithEF.Text = orderCountFromFranceWithEF.ToString();



            // The total sales price of products in orders that belong to the fruit category
            // with SQL Query

            var orderTotalPriceByCategoryIsFruit = db.Database.SqlQuery<decimal>("Select Sum(o.TotalPrice) as TotalSalesPrice from TblOrder o\r\n  join TblProduct p on o.ProductId = p.ProductId\r\n  join TblCategory c on p.CategoryId = c.CategoryId\r\n  where c.CategoryName = 'Fruit'")
                .FirstOrDefault();

            lblOrderTotalPriceByCategoryIsFruit.Text = orderTotalPriceByCategoryIsFruit.ToString();

            var orderTotalPriceByCategoryIsFruitEF =
                (from o in db.TblOrders
                 join p in db.TblProducts on o.ProductId equals p.ProductId
                 join c in db.TblCategories on p.CategoryId equals c.CategoryId
                 where c.CategoryName == "Fruit"
                 select o.TotalPrice).Sum();

            lblOrderTotalPriceByCategoryIsFruitVersionEF.Text = orderTotalPriceByCategoryIsFruitEF.ToString();


            // The name of the most recently added product

            var lastAddedProductName = db.TblProducts.OrderByDescending(x => x.ProductId)
                .Select(x => x.ProductName)
                .FirstOrDefault();

            lblLastProductName.Text = lastAddedProductName.ToString();

            // Category Name  which is the name of the most recently added product

            var lastProductCategoryId = db.TblProducts
                .OrderByDescending(x => x.ProductId)
                .Select(x => x.CategoryId)
                .FirstOrDefault();

            var lastProductCategoryName = db.TblCategories
                .Where(x=>x.CategoryId == lastProductCategoryId)
                .Select(x=>x.CategoryName)
                .FirstOrDefault();

            lblLastProductCategoryName.Text = lastProductCategoryName.ToString();



            // Number of Active Products

            var activeProductCount = db.TblProducts
                .Where(x=>x.ProductStatus == true)
                .Count();

            lblActiveProductCount.Text = activeProductCount.ToString();


            // Total Gain of Stock Sales From Oppo Reno 4

            var oppoReno4Stock = db.TblProducts
                .Where(x => x.ProductName == "Oppo Reno 4")
                .Select(x => x.ProductStock)
                .FirstOrDefault();

            var oppoReno4Price = db.TblProducts
                .Where(x=>x.ProductName == "Oppo Reno 4")
                .Select(x=>x.ProductPrice)
                .FirstOrDefault();
            var totalPriceWithStockByOppoReno4 = oppoReno4Price * oppoReno4Stock;

            lblTotalPriceWithStockByOppoReno4.Text = totalPriceWithStockByOppoReno4.ToString();



            // The name of the customer who placed the most recent order in the system

            var lastCustomerId = db.TblOrders
                .OrderByDescending(x=>x.OrderId)
                .Select(y=>y.CustomerId)
                .FirstOrDefault();

            var lastCustomerName = db.TblCustomers
                .Where(x => x.CustomerId == lastCustomerId)
                .Select(y => y.CustomerName)
                .FirstOrDefault();

            lblLastCustomerName.Text = lastCustomerName.ToString();



            // Count of Distinct Country

            // Count of Distinct Countries

            var countryDifferentCount = db.TblCustomers
                .Select(c => c.CustomerCountry)
                .Distinct()
                .Count();

            lblCountOfDifferentCountries.Text = countryDifferentCount.ToString();


        }


    }
}
