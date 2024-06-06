namespace CoffeeMachine
{
    public partial class Form1 : Form
    {
        bool powerState = false;
        int coffeType = 0;
        double coffeSize = 0;
        public static bool condensation = false;

        public Form1()
        {
            InitializeComponent();
            Display.Text = "-";
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            powerState = !powerState;


            if (powerState)
            {

                Display.Text = "Uruchomiono";
            }
            else
            {
                Display.Text = "-";
            }


        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }



        private void BlackCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 1;
                Display.Text = $"Rodzaj kawy: {coffeType} : Czarna";
            }

            else
            {
                Display.Text = "Brak zasilania!!!";
            }
        }

        private void CappuccinoCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 2;
                Display.Text = $"Rodzaj kawy: {coffeType} : Cappuccino";
            }

            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void EspressoCoffe_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                coffeType = 3;
                Display.Text = $"Rodzaj kawy: {coffeType} : Espresso";
            }


            else
            {
                Display.Text = "Brak zasilania!!!";
            }
        }


        private void HalfCupCoffe_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                if (coffeType != 0)
                {
                    coffeSize = 0.5;
                    Display.Text = $"Rozmiar kawy: Ma³a";
                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }

            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void FullCupCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                if (coffeType != 0)
                {
                    if (coffeType != 3)
                    {
                        coffeSize = 1.0;
                        Display.Text = $"Rozmiar kawy: Du¿a";
                    }
                    else
                    {
                        Display.Text = "Espresso tylko w ma³ych fili¿ankach!!!";
                    }

                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }


            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void AddSugar_Click(object sender, EventArgs e)
        {
            SugarLevel.Maximum = 6;
            SugarLevel.Minimum = 0;
            SugarLevel.Step = 1;


            if (SugarLevel.Value < SugarLevel.Maximum)
            {
                SugarLevel.Value = SugarLevel.Value + 1;

            }
            else
            {
                SugarLevel.Value = SugarLevel.Maximum;
            }
        }

        private void SubSugar_Click(object sender, EventArgs e)
        {
            SugarLevel.Maximum = 6;
            SugarLevel.Minimum = 0;
            SugarLevel.Step = 1;

            if (SugarLevel.Value > SugarLevel.Minimum)
            {
                SugarLevel.Value = SugarLevel.Value - 1;

            }
            else
            {
                SugarLevel.Value = SugarLevel.Minimum;
            }

        }

        private void RunCoffee_Click(object sender, EventArgs e)
        {
            if (powerState)
            {
                if (coffeSize != 0)
                {
                    Random random = new Random();
                    int service = random.Next(1, 6);

                    if (service == 3)
                    {
                        condensation = true;
                        Display.Text = "Czynnoœci serwisowe obowi¹zkowe.";
                    }
                    else
                    { 
                        CoffeBox.Image = Image.FromFile(@"..\..\..\Images\coffeecup.png");

                        string coffe = $"Poziom cukru: {SugarLevel.Value}/6 \n";

                        switch (coffeType)
                        {
                            case 1:
                                coffe = coffe + "Rodzaj kawy: Czarna\n";
                                break;
                            case 2:
                                coffe = coffe + "Rodzaj kawy: Cappuccino\n";
                                break;
                            case 3:
                                coffe = coffe + "Rodzaj kawy: Espresso\n";
                                break;

                        }

                        switch (coffeSize)
                        {
                            case 0.5:
                                coffe = coffe + "Wielkoœæ: Ma³a\n";
                                break;
                            case 1.0:
                                coffe = coffe + "Wielkoœæ: Du¿a\n";
                                break;

                        }

                        Display.Text = coffe;
                    }
                }
                else
                {
                    Display.Text = "Podaj rozmiar kawy!!!";
                }
            }
            else
            {
                Display.Text = "Brak zasilania!!!";
            }

        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            if (condensation)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                Display.Text = "Pojemnik na skropliny nie wymaga opró¿nienia";
            }


        }

    }   
}
