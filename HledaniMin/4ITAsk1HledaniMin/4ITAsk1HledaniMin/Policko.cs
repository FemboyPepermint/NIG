using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4ITAsk1HledaniMin
{
    public partial class Policko : UserControl
    {
        private bool maMinu;

        public bool JeZeleny = false;

        public bool MaMinu => maMinu;

        private int pocetMinOkolo;
        public int PocetMinOkolo => pocetMinOkolo;
        public bool JePrazdny => !maMinu && pocetMinOkolo == 0;

        private bool jeOdhaleny;

        public bool JeOdhaleny => jeOdhaleny;

        private int x;
        public int X => x;

        private int y;
        public int Y => y;

        public event Action<Policko> OnPolickoKliknuto;
        public event Action<Policko> OnPolickoKliknutoR;
        private Policko()
        {
            InitializeComponent();
        }
        public Policko(int x, int y) : this()
        {
            this.x = x;
            this.y = y;
            this.jeOdhaleny = false;
            pictureBox1.Hide();

        }
        public void NastavMinovost()
        {
            this.maMinu = true;
            //this.BackColor = Color.Red;
        }
        public void NastavPocetMinVOkoli(int pocet)
        {
            this.pocetMinOkolo = pocet;
            switch (pocetMinOkolo)
            {
                case 0:
                    this.pictureBox1.Image = Image.FromFile("0.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 1:
                     this.pictureBox1.Image = Image.FromFile("1.png"); 
                     this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 2:
                     this.pictureBox1.Image = Image.FromFile("2.png"); 
                     this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    this.pictureBox1.Image = Image.FromFile("3.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 4:
                    this.pictureBox1.Image = Image.FromFile("4.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 5:
                    this.pictureBox1.Image = Image.FromFile("5.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 6:
                    this.pictureBox1.Image = Image.FromFile("6.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 7:
                    this.pictureBox1.Image = Image.FromFile("7.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 8:
                    this.pictureBox1.Image = Image.FromFile("8.png");
                    this.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                    break;


            }
           // this.label1.Text = pocetMinOkolo.ToString();
        }

        private void Policko_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                OnPolickoKliknuto?.Invoke(this);
            }
            else if (e.Button == MouseButtons.Right)
            {
                OnPolickoKliknutoR?.Invoke(this);
                if (!jeOdhaleny)
                {
                    if (!JeZeleny)
                    {
                        this.BackgroundImage = Image.FromFile("flag.png"); 
                        this.BackgroundImageLayout = ImageLayout.Stretch; // natahlý jak guma přez moje péro
                        JeZeleny = true;
                        Form1 form = new Form1();
                        form.pocetMin--;



                    }
                    else
                    {
                        this.BackColor = Color.White;
                        this.BackgroundImage = null;
                        JeZeleny = false;
                    }
                }
            }

            
        }
        //mina nuds ( °)( °)
        public void OdhalSe()
        {
            jeOdhaleny = true;
            pictureBox1.Show();
        }
    }
}
