using System.Xml.Linq;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private ProductDataManager dataManager = new ProductDataManager();
        private ProductAnalyzer analyzer = new ProductAnalyzer();
        private List<Product> products;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            products = dataManager.LoadProducts();
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            var sortedProducts = analyzer.MergeSort(products);
            lstProducts.Items.Clear();
            foreach (var product in sortedProducts)
            {
                lstProducts.Items.Add($"{product.Name} - {product.Manufacturer} - {product.ImportingCountry} - {product.Volume} - {product.NumberOfSales} - {product.DeliveryDate:yyyy-MM-dd}");
            }
        }

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            dataManager.CreateNewFile();
            LoadData();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int volume;
            int numberOfSales;
            if (int.TryParse(txtVolume.Text, out volume) && int.TryParse(txtNumberOfSales.Text, out numberOfSales))
            {
                var newProduct = new Product
                {
                    Name = txtName.Text,
                    Manufacturer = txtManufacturer.Text,
                    ImportingCountry = txtImportingCountry.Text,
                    Volume = volume,
                    NumberOfSales = numberOfSales,
                    DeliveryDate = dtpDeliveryDate.Value
                };

                try
                {
                    dataManager.AddProduct(newProduct);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Volume and number of sales can only contain integer values");
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProduct = lstProducts.SelectedItem.ToString().Split('-')[0].Trim();
                var updatedProduct = new Product
                {
                    Name = txtName.Text,
                    Manufacturer = txtManufacturer.Text,
                    ImportingCountry = txtImportingCountry.Text,
                    Volume = int.Parse(txtVolume.Text),
                    DeliveryDate = dtpDeliveryDate.Value
                };

                dataManager.EditProduct(selectedProduct, updatedProduct);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = lstProducts.SelectedItem.ToString().Split('-')[0].Trim();

            try
            {
                dataManager.DeleteProduct(selectedProduct);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchCountries_Click(object sender, EventArgs e)
        {
            var productName = txtProductName.Text;
            var countries = analyzer.FindImportingCountries(products, productName);
            var volume = analyzer.GetTotalExportVolume(products, productName);

            MessageBox.Show($"Country: {string.Join(", ", countries)}\nTotal volume export: {volume}");
        }

        private void btnTopProducts_Click(object sender, EventArgs e)
        {
            var startDate = dtpStartDate.Value;
            var endDate = dtpEndDate.Value;
            var topProducts = analyzer.FindTopProducts(products, startDate, endDate);

            lstTopProducts.Items.Clear();
            foreach (var product in topProducts)
            {
                lstTopProducts.Items.Add($"{product.Name} - {product.NumberOfSales}");
            }
        }

        private void btnUnsoldProducts_Click(object sender, EventArgs e)
        {
            var sinceDate = dtpSinceDate.Value;
            var unsoldProducts = analyzer.FindUnsoldProducts(products, sinceDate);

            lstUnsoldProducts.Items.Clear();
            foreach (var product in unsoldProducts)
            {
                lstUnsoldProducts.Items.Add($"{product.Name} - {product.NumberOfSales}");
            }
        }

        private void btnBinarySearch_Click(object sender, EventArgs e)
        {
            var productName = txtSearchProductName.Text;
            var sortedProducts = analyzer.MergeSort(products);
            var index = analyzer.BinarySearch(sortedProducts, productName);

            if (index >= 0)
            {
                MessageBox.Show($"Product found: {sortedProducts[index].Name} - {sortedProducts[index].Manufacturer}");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
    }

    public class ProductDataManager
    {
        private const string FilePath = "products.xml";

        public List<Product> LoadProducts()
        {
            if (!File.Exists(FilePath))
                return new List<Product>();

            var doc = XDocument.Load(FilePath);
            var products = doc.Root.Elements("Product").Select(e => new Product
            {
                Name = e.Element("Name").Value,
                Manufacturer = e.Element("Manufacturer").Value,
                ImportingCountry = e.Element("ImportingCountry").Value,
                Volume = int.Parse(e.Element("Volume").Value),
                NumberOfSales = int.Parse(e.Element("NumberOfSales").Value),
                DeliveryDate = DateTime.Parse(e.Element("DeliveryDate").Value)
            }).ToList();

            return products;
        }

        public void SaveProducts(List<Product> products)
        {
            var doc = new XDocument(new XElement("Products",
                products.Select(p => new XElement("Product",
                    new XElement("Name", p.Name),
                    new XElement("Manufacturer", p.Manufacturer),
                    new XElement("ImportingCountry", p.ImportingCountry),
                    new XElement("Volume", p.Volume),
                    new XElement("NumberOfSales", p.NumberOfSales),
                    new XElement("DeliveryDate", p.DeliveryDate)
                ))));

            doc.Save(FilePath);
        }

        public void CreateNewFile()
        {
            if (File.Exists(FilePath))
                File.Delete(FilePath);

            SaveProducts(new List<Product>());
        }

        public void AddProduct(Product product)
        {
            var products = LoadProducts();
            if (!products.Any(p => p.Name == product.Name && p.Manufacturer == product.Manufacturer))
            {
                products.Add(product);
                SaveProducts(products);
            }
            else
            {
                throw new Exception("The record already exists.");
            }
        }

        public void EditProduct(string originalName, Product updatedProduct)
        {
            var products = LoadProducts();
            var product = products.FirstOrDefault(p => p.Name == originalName);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Manufacturer = updatedProduct.Manufacturer;
                product.ImportingCountry = updatedProduct.ImportingCountry;
                product.Volume = updatedProduct.Volume;
                product.DeliveryDate = updatedProduct.DeliveryDate;
                SaveProducts(products);
            }
            else
            {
                throw new Exception("No record found.");
            }
        }

        public void DeleteProduct(string productName)
        {
            var products = LoadProducts();
            var product = products.FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                products.Remove(product);
                SaveProducts(products);
            }
            else
            {
                throw new Exception("No record found.");
            }
        }
    }
    public class ProductAnalyzer
    {
        public List<string> FindImportingCountries(List<Product> products, string productName)
        {
            return products
                .Where(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                .Select(p => p.ImportingCountry)
                .Distinct()
                .ToList();
        }

        public int GetTotalExportVolume(List<Product> products, string productName)
        {
            return products
                .Where(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase))
                .Sum(p => p.Volume);
        }

        public List<Product> FindTopProducts(List<Product> products, DateTime startDate, DateTime endDate)
        {
            return products
                .Where(p => p.DeliveryDate >= startDate && p.DeliveryDate <= endDate)
                .OrderByDescending(p => p.NumberOfSales)
                .ThenBy(p => p.Name)
                .Take(5)
                .ToList();
        }

        public List<Product> FindUnsoldProducts(List<Product> products, DateTime sinceDate)
        {
            return products
                .Where(p => p.DeliveryDate <= sinceDate && p.NumberOfSales < 50)
                .OrderBy(p => p.Name)
                .ToList();
        }

        public List<Product> MergeSort(List<Product> products)
        {
            if (products.Count <= 1)
                return products;

            var left = products.Take(products.Count / 2).ToList();
            var right = products.Skip(products.Count / 2).ToList();

            return Merge(MergeSort(left), MergeSort(right));
        }

        private List<Product> Merge(List<Product> left, List<Product> right)
        {
            var result = new List<Product>();
            int leftPointer = 0, rightPointer = 0;

            while (leftPointer < left.Count && rightPointer < right.Count)
            {
                if (string.Compare(left[leftPointer].Name, right[rightPointer].Name, StringComparison.Ordinal) <= 0)
                {
                    result.Add(left[leftPointer]);
                    leftPointer++;
                }
                else
                {
                    result.Add(right[rightPointer]);
                    rightPointer++;
                }
            }

            result.AddRange(left.Skip(leftPointer));
            result.AddRange(right.Skip(rightPointer));

            return result;
        }

        public int BinarySearch(List<Product> products, string productName)
        {
            int left = 0, right = products.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].Name, productName, StringComparison.Ordinal);

                if (comparison == 0)
                    return mid;

                if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string ImportingCountry { get; set; }
        public int Volume { get; set; }
        public int NumberOfSales { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}