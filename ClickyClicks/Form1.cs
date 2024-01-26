using Gma.System.MouseKeyHook;



namespace ClickyClicks
{
    public partial class Form1 : Form
    {
        public bool click = false;
        public Form1()
        {
            InitializeComponent();

        }

        mouseListener listener = new mouseListener();
        private autoclicker ac;
        public int minCpsVal, maxCpsVal, randVal;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            minCpsTb.Text = trackBar1.Value.ToString();
            minCpsVal = trackBar1.Value;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ac = new autoclicker();
            Random.Start();
            await ac.Clicker();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            maxCpsTb.Text = trackBar2.Value.ToString();
            maxCpsVal = trackBar2.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Contains("Start"))
            {
                button1.Text = "Stop";
            }
            else if (button1.Text.Contains("Stop"))
            {
                button1.Text = "Start";
            }
        }

        private async void button1_TextChanged(object sender, EventArgs e)
        {
            if (button1.Text.Contains("Stop"))
            {
                listener.subscribe();
            }
            else
            {
                listener.unsubscribe();
            }
        }

        private void Random_Tick(object sender, EventArgs e)
        {
            if (button1.Text.Contains("Stop"))
            {
                ac = new autoclicker();
                Random rand = new Random();
                int dagis = rand.Next(minCpsVal, maxCpsVal);
                ac.clicker_interval = dagis;
                randLabel.Text = " " + ac.Click;
                
            }
        }
    }
}
