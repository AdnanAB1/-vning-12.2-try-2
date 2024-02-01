using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_12._2_try_2
{
    public partial class Form1 : Form

    {
        int[] tal = new int[200];
        Random generator = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tal.Length; i++)
            {
                tal[i] = generator.Next(1, 101); //Generera ett slumpmässigt heltal mellan 1 och 100 och lagra det på positionen i [i] arrayen tal. 
            }
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BubbelSortera(tal);
            Invalidate();
        }

      

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Point origo = new Point(40, 150);
            e.Graphics.DrawLine(Pens.Black, origo.X, origo.Y, origo.X, origo.Y - 100);
            e.Graphics.DrawLine(Pens.Black, origo.X, origo.Y, origo.X + 200, origo.Y);

            for (int i = 0; i < tal.Length; i++) //Loopen börjar med att initialisera en variabel i till 0 och fortsätter så länge värdet av i är mindre än längden på arrayen tal. Efter varje iteration ökar värdet av i med 1.
            {
                e.Graphics.FillEllipse(Brushes.Blue, origo.X + i, origo.Y - tal[i], 2, 2);  
            }
        }


        public void BubbelSortera(int[] lista)
        {
            for (int m = lista.Length - 1; m > 0; m--)//Det går till med att ge värdet m som är lika med längden på arrayen lista minus 1 och sedan minskar m med 1 varje gång. Loopen fortsätter så länge m är större än 0. 
            {
                for (int n = 0; n < m; n++)
                {
                    if (lista[n] > lista[n + 1])
                    {
                        int temp = lista[n];
                        lista[n] = lista[n + 1];
                        lista[n + 1] = temp;
                    }
                }
            }
        }
    }
}
