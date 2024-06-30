using System.DirectoryServices.ActiveDirectory;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operationPerfomed = "";
        bool isOperationClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationClicked))
                textBox1.Clear();


            isOperationClicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                switch (operationPerfomed)
                {
                    case "+":
                        textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "X":
                        textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }

            }
            operationPerfomed = button.Text;
            result = double.Parse(textBox1.Text);
            isOperationClicked = true;
            labelCurrentOperation.Text = result.ToString() + " " + operationPerfomed;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            labelCurrentOperation.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operationPerfomed)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;
                case "X":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(textBox1.Text);
            labelCurrentOperation.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}