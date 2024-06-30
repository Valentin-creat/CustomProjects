using System.Net.Http.Json;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;
using QuizzAppAPI;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom.Compiler;
using System.Text.Json;
using System.Net;
using System.Drawing.Design;

namespace QuizzApp
{
    public partial class Form1 : Form
    {
        private List<APIData> questions;
        int currentQuestion = 0;
        int correct = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Resize += new EventHandler(Form1_Resize);
            button2.Visible = false;
            button2.BackColor = Color.Yellow;
            button2.Text = "True";
            button3.Visible = false;
            button3.BackColor = Color.Yellow;
            button3.Text = "False";
            label3.Visible = false;
            button1.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLabel();
            CenterButtons();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            CenterButtons();
            CenterLabel();
            questions = await APIClass.APIMessage(21, "boolean");
            await Task.Delay(3500);
            button1.Visible = true;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 5;

            label1.Text = WebUtility.HtmlDecode(questions[currentQuestion].Question);
            currentQuestion++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {


        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
        private void CenterLabel()
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = 5;
        }
        private void CenterButtons()
        {
            button1.Left = (ClientSize.Width - button1.Width) / 2;
            button1.Top = (ClientSize.Height - button1.Height) / 2;
            button2.Left = 10;
            button2.Top = ClientSize.Height - button1.Height - 10;
            button3.Left = ClientSize.Width - button2.Width - 10;
            button3.Top = ClientSize.Height - button2.Height - 5;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            label1.Text = WebUtility.HtmlDecode(questions[currentQuestion].Question);
            if (button.Text == questions[currentQuestion].CorrectAnswer)
            {
                correct++;

            }
            if (currentQuestion == 20)
            {
                button2.Visible = false;
                button3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                MessageBox.Show("Congratulations!!!");
            }
            label2.Text = ($"Current question: {currentQuestion + 1}");
            label3.Visible = true;
            label3.Text = ($"Correct answers: {correct}!");
            currentQuestion++;
        }
    }
}