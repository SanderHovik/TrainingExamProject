namespace Ny_projekt
{
    public partial class Form1 : Form
    {
       //Declaration af variabler
        private int value = 0;
        private int turn = 1;
        private int i = 4;
        //Array til PictureBoxes
        PictureBox[,] PB;

        //Array til spilbrættet 
        public int[,] boardArray = new int[5, 6] { 
            { 0, 0, 0, 0, 0, 0 }, 
            { 0, 0, 0, 0, 0, 0 }, 
            { 0, 0, 0, 0, 0, 0 }, 
            { 0, 0, 0, 0, 0, 0 }, 
            { 0, 0, 0, 0, 0, 0 } 
        };

        //Hovedkoden
    public Form1(string p1, string p2)
        {
           //Komponenterne fra det visuelle vindue bliver intialisz
            InitializeComponent();
            label1.Text = p1;
            label2.Text = p2;
            label1.BackColor = Color.Red;
            PB = new PictureBox[5, 6] { 
                { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 },
                { pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12},
                { pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17, pictureBox18},
                { pictureBox19, pictureBox20, pictureBox21, pictureBox22, pictureBox23, pictureBox24},
                { pictureBox25, pictureBox26, pictureBox27, pictureBox28, pictureBox29, pictureBox30}
            };
            /*
            PB[4, 1] = pictureBox1;
            PB[3, 1] = pictureBox2;
            PB[2, 1] = pictureBox1;
            PB[1, 1] = pictureBox1;
            PB[0, 1] = pictureBox1;*/
        }

        public void playerTurn()
        {
            value++;
            if (value % 2 != 0)
            {
                label2.BackColor = Color.Green;
                label1.BackColor = Color.Gray;
                turn = 2;
            }
            else
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.Gray;
                turn = 1;
            }
        }
        public void updateBoard()
        {

        }
        public void changeColor(int i, int button)
        {
            if (boardArray[i, button] == 1)
            {
                PB[i, button].BackColor = Color.Green;
            }
            else if (boardArray[i, button] == 2)
            {
                Console.WriteLine(""+i+ button);
                PB[i, button].BackColor = Color.Red;
            }
        }
        public void decideColor(int i, int button)
        {
            if (turn == 1)
            {
                boardArray[i, button] = 1;
            }
            else
            {
                boardArray[i, button] = 2;
            }
        }
        public void placeBrick(int button)
        {

            while (i >= 0) 
            {
                if (boardArray[i, button] == 0)
                {
                    decideColor(i,button);
                    changeColor(i,button);
                    i = -1;
                }
                else
                {
                    i--;
                }
            }
            i = 4;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(0);
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(1);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(2);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(3);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(4);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            playerTurn();
            placeBrick(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}