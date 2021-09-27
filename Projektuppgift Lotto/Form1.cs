using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektuppgift_Lotto
{
    public partial class Form1 : Form
    {
        int femrätt = 0;        //skapar varje variabel utanför alla program så att de kan användas om nödvändigt
        int sexrätt = 0;        //Alla variabler kanske inte måste sitta här ute men det skadar inte att definiera dem här
        int sjurätt = 0;

        int siffra1;
        int siffra2;
        int siffra3;
        int siffra4;
        int siffra5;
        int siffra6;
        int siffra7;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnkör_Click(object sender, EventArgs e)                   
        {
            femrätt = 0; 
            sexrätt = 0;
            sjurätt = 0; //Nollställer värdena innan körning så att de inte adderas kontinuerligt.

            if (!int.TryParse(tbxsiffra1.Text, out int result1))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den första rutan");
            }

            else
            {
                if (result1 <= 35 && result1 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra1 = result1;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra2.Text, out int result2))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den andra rutan");
            }

            else
            {
                if (result2 <= 35 && result2 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra2 = result2;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra3.Text, out int result3))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den tredje rutan");
            }

            else
            {
                if (result3 <= 35 && result3 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra3 = result3;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra4.Text, out int result4))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den fjärde rutan");
            }

            else
            {
                if (result4 <= 35 && result4 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra4 = result4;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra5.Text, out int result5))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den femte rutan");
            }

            else
            {
                if (result5 <= 35 && result5 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra5 = result5;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra6.Text, out int result6))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den sjätte rutan");
            }

            else
            {
                if (result6 <= 35 && result6 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra6 = result6;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            if (!int.TryParse(tbxsiffra7.Text, out int result7))// koden kan bara köras om stringen kan bli en int
            {
                MessageBox.Show("Du har skrivit in något som inte är en siffra i den sjunde rutan");
            }

            else
            {
                if (result7 <= 35 && result7 >= 1)                                // blocket kollar om
                {                                                               // talet ligger inom
                    siffra7 = result7;                                          // talen 1-35
                }                                                               // och sedan sätter in
                else                                                            // det i variabeln som 
                {                                                               // används i loopen
                    MessageBox.Show("Talet ligger inte inom rätt parametrar");
                }
            }

            int[] sorteradesiffror = new int[] { siffra1, siffra2, siffra3, siffra4, siffra5, siffra6, siffra7 };

            int repetitioner = 0; // antal repetitioner sätts till 0 så att while loopen ska fungera

            int upprep = 0;

            if (!int.TryParse(tbxupprep.Text, out int upprepsiffra))
            {
                MessageBox.Show("Du måste skriva in en siffra i antal drag rutan. Nu sätts den till 1");
                upprep = 1;
            }

            else
            {
                upprep = upprepsiffra;
            }

            while (repetitioner < upprep)
            {
                int[] resultat = Enumerable.Range(1, 35).OrderBy(g => Guid.NewGuid()).Take(8).ToArray(); //Den genererar tal mellan 1-35 och sedan tar 7 av dem och sätter dem i en array

                repetitioner++; //För varje repetition så höjs värdet med 1. När repetitioner har nått samma värde som upprep så slutar loopen. Alla siffror sätts dessutom i en multiline textbox och en ny rad skrivs varje gång koden upprepas
                tbxresultat.AppendText(resultat[1] + " " + resultat[2] + " " + resultat[3] + " " + resultat[4] + " " + resultat[5] + " " + resultat[6] + " " + resultat[7] + "\r\n");

                int jämförelsetal = 0; //skapar en variabel som bestämmer vilket tal det är som jämförs från den första arrayen med den andra
                int träffar = 0; //Skapar en variabel som ökar med 1 varje gång ett tal från den första arrayen matchar den andra

                for (int i=0;i<7;i++) //Den kollar nästa tal i arrayen efter varje repetition
                {
                    jämförelsetal = sorteradesiffror[i];
                    for (int j=0; j<7;j++) //Den kollar nästa tal i andra arrayen efter varje repetition.
                    {
                        if(jämförelsetal==resultat[j]) //Om de matchar så ökar antalet träffar med 1
                        {
                            träffar++;
                        }
                    }
                    if (träffar == 5) //Om träffarna når 5 efter att loopen är slut så ökar antalet fem rätt med 1
                    {
                        femrätt++;
                    }
                    if (träffar == 6)
                    {
                        sexrätt++;
                    }
                    if (träffar == 7)
                    {
                        sjurätt++;
                    }
                }
            }
            tbx5rätt.Text = femrätt + "";
            tbx6rätt.Text = sexrätt + "";
            tbx7rätt.Text = sjurätt + ""; //den skriver ut hur många gånger allting förekom
        }

        private void btngenerera_Click(object sender, EventArgs e)
        {
            int[] siffror = Enumerable.Range(1, 35).OrderBy( g => Guid.NewGuid()).Take (8).ToArray(); //Den genererar tal mellan 1-35 och sedan tar 7 av dem och sätter dem i en array

            int siffra1 = siffror[1];           //Den sätter in det slumpmässiga talet i en integer och sedan i en textbox
            tbxsiffra1.Text = siffra1 + "";

            int siffra2 = siffror[2];
            tbxsiffra2.Text = siffra2 + "";

            int siffra3 = siffror[3];
            tbxsiffra3.Text = siffra3 + "";

            int siffra4 = siffror[4];
            tbxsiffra4.Text = siffra4 + "";

            int siffra5 = siffror[5];
            tbxsiffra5.Text = siffra5 + "";

            int siffra6 = siffror[6];
            tbxsiffra6.Text = siffra6 + "";

            int siffra7 = siffror[7];
            tbxsiffra7.Text = siffra7 + "";
        }

        private void btntömm_Click(object sender, EventArgs e)
        {
            tbx5rätt.Text = "";
            tbx6rätt.Text = "";
            tbx7rätt.Text = "";
            tbxresultat.Text = "";
            tbxsiffra1.Text = "";
            tbxsiffra2.Text = "";
            tbxsiffra3.Text = "";
            tbxsiffra4.Text = "";
            tbxsiffra5.Text = "";
            tbxsiffra6.Text = "";
            tbxsiffra7.Text = "";
            tbxupprep.Text = "";
            //Detta blocket tömmer alla textboxes
        }

        private void btnstarta_Click(object sender, EventArgs e)
        {
            
        }

        private class siffra
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
