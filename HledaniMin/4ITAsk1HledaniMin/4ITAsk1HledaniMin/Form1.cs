using System.Linq;

namespace _4ITAsk1HledaniMin
{
    public partial class Form1 : Form
    {
        Policko[,] herniPole;
        public int pocetMin = 20;
        public Form1()
        {
            InitializeComponent();
            VytvorHerniPole();
            ZaminujPole();
            NastavCiselniky();
            AktualizujZobrazenyPocetMin();
        }
        private void AktualizujZobrazenyPocetMin()
        {
            label1.Text = "Počet min: " + pocetMin;
        }
        private void Policko_OnPolickoKliknuto(Policko policko)
        {
            if (policko.MaMinu)
                Prohra();
            if (policko.JeZeleny)
            {
                return;
            }
             

            OdhalPolicko(policko.Y, policko.X);
            ZkontrolujVyhru();
            AktualizujZobrazenyPocetMin();
        }
        private void NastavCiselniky()
        {
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    int pocetMin = ZkontrolujSousedy(j, i);
                    herniPole[i, j].NastavPocetMinVOkoli(pocetMin);
                }
            }
        }

        private int ZkontrolujSousedy(int x, int y)
        {
            int pocetMin = 0;

            for (int i = y - 1; i <= y + 1; i++)
            {
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (i < 0 || j < 0 || i > herniPole.GetLength(0) - 1 || j > herniPole.GetLength(1) - 1)
                        continue;


                    if (herniPole[i, j].MaMinu)
                        pocetMin++;
                }
            }
            return pocetMin;
        }

        private void ZaminujPole()
        {
            Random rnd = new Random();
            int x;
            int y;
            Policko policko;


            for (int i = 0; i < 20; i++)
            {
                x = rnd.Next(herniPole.GetLength(1));
                y = rnd.Next(herniPole.GetLength(0));

                policko = herniPole[y, x];
                if (policko.MaMinu)
                {
                    i--;
                    continue;
                }

                policko.NastavMinovost();
            }
        }


        private void VytvorHerniPole()
        {
            herniPole = new Policko[12, 12];
            Policko policko;
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    policko = new Policko(j, i);
                    herniPole[i, j] = policko;
                    herniPanel.Controls.Add(policko);
                    policko.OnPolickoKliknuto += Policko_OnPolickoKliknuto;
                }
            }
        }

        private void ZkontrolujVyhru()
        {
            bool vyhral = herniPole.Cast<Policko>().All(policko => policko.JeOdhaleny || policko.MaMinu);
            if (vyhral)
            {
                MessageBox.Show("GG EZ");
                Application.Restart();
            }
        }

        private void OdhalPolicko(int y, int x)
        {
            Policko policko = herniPole[y, x];
            policko.OdhalSe();


            if (!policko.JePrazdny)
                return;

            for (int i = y - 1; i <= y + 1; i++)
            {
                for (int j = x - 1; j <= x + 1; j++)
                {
                    if (i < 0 || j < 0 || i > herniPole.GetLength(0) - 1 || j > herniPole.GetLength(1) - 1)
                        continue;

                    policko = herniPole[i, j];

                    if (!policko.JeOdhaleny)
                    {
                        OdhalPolicko(i, j);
                    }

                }
            }
        }

        private void Prohra()
        {
            MessageBox.Show("Prohrál jsi");
            Application.Restart();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}