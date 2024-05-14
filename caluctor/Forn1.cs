namespace Caluctor
{
    public partial class Forn1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = " ";
        public Forn1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {



        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }

        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains(" , "))
            {
                TextBox.Text = ",";
            }
        }



        private void OneBtn_Click(object sender, EventArgs e)
        {

            TextBox.Text += OneBtn.Text;


        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }

        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }

        }

        private void ForeBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }

        }

        private void Fivebtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }

        }

        private void SixsBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }

        }

        private void SevinBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }

        }

        private void EightBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }

        }

        private void NineBtn_Click(object sender, EventArgs e)
        {

            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }

        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains(" , "))
            {
                TextBox.Text = TextBox.Text.Trim(',');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void DevideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "*";
        }

        private void ModuleBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "%";
        }
        private void EqulBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst / valueSecond;
                    TextBox.Text = Result.ToString();
                    break;

                case "%":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst % valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClaerBtn_Click(object sender, EventArgs e)
        {

            TextBox.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}