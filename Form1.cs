using System;
using System.Drawing;
using System.Windows.Forms;

namespace RULTZ //RULTZ - Rozwiązywanie Układów Logicznych Za pomocą Tableau
{    /*Temat: Aplikacja wspomagająca dowodzenie formuł rachunku zdań metodą Tableau
     * Zadanka:
     * Dowodzenie formuł
     * Rysowanie wykresu
     */
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }
        void InitializeControls()
        {
            //Label
            label1.Text = "Formula";
            label1.Font = new Font("Arial", 24, FontStyle.Bold);

            //richTextBox1
            richTextBox1.Tag = "Write your formula here....";
            richTextBox1.Text = richTextBox1.Tag.ToString();
            richTextBox1.ForeColor = Color.Silver;

            //ImageBox.Image = new Bitmap("D:\\Nude\\02-Kim-Kardashian-Nude-Leaked-Ass.jpg");

        }
        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == richTextBox1.Tag.ToString())
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.Black;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim() == "")
            {
                richTextBox1.Text = richTextBox1.Tag.ToString();
                richTextBox1.ForeColor = Color.Silver;
            }
        }
        String conditions(String Text)
        {
            if (Text.Length == 1)
            {
                return Text;
            }
            else if (Text.Contains("∧"))
            {
                int Index = Text.IndexOf("∧");
                String Left = "";
                String Right = "";

                for (int i = 0; i < Index; i++)
                {
                    Left += Text[i];
                }
                for (int i = Index; i < Text.Length-1; i++)
                {
                    Right += Text[i];
                }
                
            }

            return "Error in checking conditions";
        }
        void Tableu()
        {
            //Charge the provided text 
            String Logic_expresion = richTextBox1.Text.ToString();
            //Step 1: Remove the whitespaces
            Logic_expresion = Logic_expresion.Replace(" ", "");
            //Step 2: *nawiasy
            //Step 3: Show the results
            richTextBox2.Text = conditions(Logic_expresion);


        }

        private void label2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "→";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "¬";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "∨";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "∧";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tableu();
        }
    }
}
