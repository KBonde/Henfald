using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Henfald
{
    public class atom
    {
        public int randomNum;
    }

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<atom> myAtoms = new List<atom>();
        int totalRuns = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runSim(textBox1.Text);
        }

        void runSim(string numberOfAtoms)
        {
            
            richTextBox1.Text += "Run number " + totalRuns.ToString() + ":\n";

            atom test = new atom();
            int totalAtoms = Int32.Parse(textBox1.Text);
            int userChance = Int32.Parse(textBox2.Text);
            int rounds = 0;

            for (int i = 0; i < totalAtoms; i++) //Add atoms acording to user number
            {
                myAtoms.Add(new atom());
            }

            while(myAtoms.Any()) {
                for (int i = 0; i < myAtoms.Count(); i++) //Calculate if should fall based on user chance
                {
                    myAtoms[i].randomNum = rnd.Next(1, userChance+1);
                    if(myAtoms[i].randomNum == userChance)
                    {
                        myAtoms.RemoveAt(i);
                    }
                    
                }

                rounds++;
            }

            richTextBox1.Text += "Rounds: " + rounds.ToString() + "\nStart Atoms:" + totalAtoms.ToString() + "\n\n\n";
            totalRuns++;
        }
    }
}
