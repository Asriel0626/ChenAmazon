namespace ChenAmazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Product ID", 100);
            listView1.Columns.Add("Product Name", 150);
            listView1.Columns.Add("Product Description", 250);
            listView1.Columns.Add("Source", 100);
            listView1.Columns.Add("Tracking / Status", 180);
            this.Text = Product.MarketplaceName + " Product Comparison";
        }

        private void buttonAdd_Click(object sender, EventArgs e) { 
        
         
            if (string.IsNullOrWhiteSpace(textBoxPID.Text))
            {
                MessageBox.Show("Please enter a product id.");
                textBoxPID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPD.Text))
            {
                MessageBox.Show("Please enter a product description.");
                textBoxPD.Focus();
                return;
            }

            Product product = new Product()
            {
                ProductID = textBoxPID.Text,
                ProductName = textBoxPN.Text,
                ProductDescription = textBoxPD.Text,
                TrackingNumber = textBoxTracking.Text
            };

            ListViewItem item = new ListViewItem(product.ProductID);
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductDescription);
            item.SubItems.Add(product.Source);
            item.SubItems.Add(product.TrackingDisplay);

            listView1.Items.Add(item);

            textBoxPID.Clear();
            textBoxPN.Clear();
            textBoxPD.Clear();
            textBoxTracking.Clear();

            textBoxPID.Focus();
        }
        

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPID.Clear();
            textBoxPN.Clear();
            textBoxPD.Clear();
            textBoxTracking.Clear();

            textBoxPID.Focus();

        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Product Count : " + listView1.Items.Count.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPartial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPID.Text))
            {
                MessageBox.Show("Please enter a product id.");
                textBoxPID.Focus();
                return;
            }

            Product product = new Product(
                textBoxPID.Text,
                textBoxPN.Text
            );

            ListViewItem item = new ListViewItem(product.ProductID);
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductDescription);
            item.SubItems.Add(product.Source);
            item.SubItems.Add(product.TrackingDisplay);

            listView1.Items.Add(item);

            textBoxPID.Clear();
            textBoxPN.Clear();
            textBoxPD.Clear();
            textBoxTracking.Clear();

            textBoxPID.Focus();
        }

        private void buttonFull_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPID.Text))
            {
                MessageBox.Show("Please enter a product id.");
                textBoxPID.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPD.Text))
            {
                MessageBox.Show("Please enter a product description.");
                textBoxPD.Focus();
                return;
            }

            Product product = new Product(
                textBoxPID.Text,
                textBoxPN.Text,
                textBoxPD.Text,
                textBoxTracking.Text
            );

            ListViewItem item = new ListViewItem(product.ProductID);
            item.SubItems.Add(product.ProductName);
            item.SubItems.Add(product.ProductDescription);
            item.SubItems.Add(product.Source);
            item.SubItems.Add(product.TrackingDisplay);

            listView1.Items.Add(item);

            textBoxPID.Clear();
            textBoxPN.Clear();
            textBoxPD.Clear();
            textBoxTracking.Clear();

            textBoxPID.Focus();
        }
    }
}
