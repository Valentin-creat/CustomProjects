namespace RandomJokesApp
{
    public partial class Form1 : Form
    {
        APIRequest jokes;
        int jokeCount;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ready for some jokes?";
            button1.Text = "Proceed";
            label2.Text = "";
            button2.Visible = false;
            button1.Visible = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            jokes = await APIClass.APIContent();
            await Task.Delay(3500);
            button1.Text = "Give it to me!";
            button1.Visible = true;
        }
        private async void button1_Click(object sender, EventArgs e)
        {

            label1.Text = jokes.Setup;
            button2.Visible = true;
            button2.Text = "Give me the punchline!";
            label2.Visible = false;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = jokes.Punchline;
            jokes = await APIClass.APIContent();
        }
    }
}