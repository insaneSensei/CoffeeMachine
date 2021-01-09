using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Media;
using System.Data.SqlTypes;

namespace Coffee
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        
        private float waterInput;
        private float water = 100f;
        int addMoney;
        int contPrice;
        float sugar;
        StreamReader reader;
        StreamWriter writer;
        SqlConnection connection;
        SqlCommand command;
        DirectoryInfo databasePath=new DirectoryInfo("db.mdf");

      



        private void Main_Load(object sender, EventArgs e)
        {

            startBtn.Enabled = false;
            SelectSql();

        }

        private void espressoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (espressoCheck.Checked == true)
            {
                startBtn.Enabled = true;
                coffeeCheck.Enabled = false;
                teaCheck.Enabled = false;
                contPrice = 70;
                priceLabel.Text = "Price: " + contPrice.ToString();
            }
            else
            {
                startBtn.Enabled = false;
                coffeeCheck.Enabled = true;
                teaCheck.Enabled = true;
                priceLabel.Text = "Price: ";

            }
        }

        private void coffeeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (coffeeCheck.Checked == true)
            {
                startBtn.Enabled = true;
                espressoCheck.Enabled = false;
                teaCheck.Enabled = false;
                contPrice = 60;
                priceLabel.Text = "Price: " + contPrice.ToString();
            }
            else
            {
                startBtn.Enabled = false;
                espressoCheck.Enabled = true;
                teaCheck.Enabled = true;
                priceLabel.Text = "Price: ";
            }
        }

        private void teaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCheck.Checked == true)
            {
                startBtn.Enabled = true;
                espressoCheck.Enabled = false;
                coffeeCheck.Enabled = false;
                contPrice = 50;
                priceLabel.Text = "Price: " + contPrice.ToString();

            }
            else
            {
                startBtn.Enabled = false;
                espressoCheck.Enabled = true;
                coffeeCheck.Enabled = true;
                priceLabel.Text = "Price: ";
            }
        }
        private void fiveFt_Click(object sender, EventArgs e)
        {
            addMoney += 5;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }
        private void tenFt_Click(object sender, EventArgs e)
        {
            addMoney += 10;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }
        private void twentyFt_Click(object sender, EventArgs e)
        {
            addMoney += 20;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }
        private void fiftyFt_Click(object sender, EventArgs e)
        {
            addMoney += 50;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }
        private void hundredFt_Click(object sender, EventArgs e)
        {
            addMoney += 100;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }

        private void twohundredFt_Click(object sender, EventArgs e)
        {
            addMoney += 200;
            moneyAdd.Text = "Money added: " + addMoney.ToString();
        }
        private async void startBtn_ClickAsync(object sender, EventArgs e)
        {
            if (contPrice <= addMoney)
            {
                loading.Visible = true;
                if (espressoCheck.Checked == true)
                {
                    MoreMoneyAdded();
                    await TimeSimAsync();
                    Water.UpdateDB(-0.1M);
                    MessageBox.Show("Espresso finished with " + sugar.ToString() + " sugar");
                }
                if (coffeeCheck.Checked == true)   
                {
                    MoreMoneyAdded();
                    await TimeSimAsync();
                    Water.UpdateDB(-0.2M);
                    MessageBox.Show("Coffee finished with " + sugar.ToString() + " sugar");
                }
                if (teaCheck.Checked == true)
                {
                    MoreMoneyAdded();
                    await TimeSimAsync();
                    Water.UpdateDB(-0.3M);
                    MessageBox.Show("Tea finished with " + sugar.ToString() + " sugar");
                }
            }
            SelectSql();
            priceLabel.Text = "Price: ";
            moneyAdd.Text = "Money added: ";
            addMoney = 0;
            loading.Visible = false;
        }
        void MoreMoneyAdded()
        {
            if (contPrice < addMoney)
            {
                MessageBox.Show("Your change is: " + (addMoney - contPrice).ToString());
            }
        }
        private async Task TimeSimAsync()
        {
            for (int i = 0; i <100; i++)
            {
                loading.Value = i;
                await Task.Delay(50);
            }
        }
        private void waterAdd_Click(object sender, EventArgs e)
        {
            SqlDecimal @decimal=new SqlDecimal(Convert.ToDecimal(inputMaterial.Text.Trim()));
            Water.UpdateDB(@decimal);
            SelectSql();
            inputMaterial.Text = "0";
        }
        private void inputWater_MouseClick(object sender, MouseEventArgs e)
        {
          inputMaterial.Text = string.Empty;
        }
        void SugarAdd()
        {
            switch (sugarScroll.Value)
            {
                case 1:
                    sugarAmount.Text = "Sugar: 0.5";
                    sugar = 0.5f;
                    break;
                case 2:
                    sugarAmount.Text = "Sugar: 1";
                    sugar = 1f;
                    break;
                case 3:
                    sugarAmount.Text = "Sugar: 1.5";
                    sugar = 1.5f;
                    break;
                case 4:
                    sugarAmount.Text = "Sugar: 2";
                    sugar = 2f;
                    break;
                case 5:
                    sugarAmount.Text = "Sugar: 2.5";
                    sugar = 2.5f;
                    break;
                case 6:
                    sugarAmount.Text = "Sugar: 3";
                    sugar = 3f;
                    break;
                case 7:
                    sugarAmount.Text = "Sugar: 3.5";
                    sugar = 3.5f;
                    break;
                case 8:
                    sugarAmount.Text = "Sugar: 4";
                    sugar = 4f;
                    break;
                case 9:
                    sugarAmount.Text = "Sugar: 4.5";
                    sugar = 4.5f;
                    break;
                case 10:
                    sugarAmount.Text = "Sugar: 5";
                    sugar = 5f;
                    break;
                default:
                    sugarAmount.Text = "Sugar: ";
                    sugar = 0f;
                    break;
            }
        }
        private void sugarScroll_Scroll(object sender, EventArgs e)
        {
            SugarAdd();
        }

        private void debug_Click(object sender, EventArgs e)
        {
            MessageBox.Show(databasePath.FullName);
        }
       
        void InsertSql()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + databasePath.FullName + "';Integrated Security=True";
            using (connection = new SqlConnection(connectionString))
            {
                string query = @"Insert into [Table]  VALUES(@Id,@Water)";
                connection.Open();
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", 1);
                command.Parameters.AddWithValue("@Water", Convert.ToInt32(inputMaterial.Text));
                command.ExecuteNonQuery();
            }
        }
        string SelectSql()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + databasePath.FullName + "';Integrated Security=True";
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT Water From [Table]";
                command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   waterLabel.Text = "Water: " + reader.GetValue(0).ToString() + " L";
                }
                return waterLabel.Text;
            }
        }
    }
}
