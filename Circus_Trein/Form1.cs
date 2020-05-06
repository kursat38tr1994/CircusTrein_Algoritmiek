using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Circus_Trein.Exception;

namespace Circus_Trein
{
    public partial class Form1 : Form
    {
        Train train = new Train();
        
        public Form1()
        {
            InitializeComponent();
       
        }

        List<Animal> animals = new List<Animal>();

        private AnimalSize GetSelectedSize()
        {
            if (sizeLargeBtn.Checked == true) return Circus_Trein.AnimalSize.Large;
            if (sizeMediumBtn.Checked == true) return Circus_Trein.AnimalSize.Medium;
            if (sizeSmallBtn.Checked == true) return Circus_Trein.AnimalSize.Small;

            return Circus_Trein.AnimalSize.Small;
        }

        private AnimalDiet GetSelectedDiet()
        {
            if (typeCarnivoreBtn.Checked == true) return Circus_Trein.AnimalDiet.Carnivore;
            if (typeHerbivoreBtn.Checked == true) return Circus_Trein.AnimalDiet.Herbivore;

            return Circus_Trein.AnimalDiet.Herbivore;
        }

        private void addAnimalBtn_Click(object sender, EventArgs e)
        {
            if (animalNameTxtbox.Text.Length <= 0)
            {
                MessageBox.Show("Vul een naam in");
                return;
            }
            if (sizeLargeBtn.Checked != true && sizeMediumBtn.Checked != true && sizeSmallBtn.Checked != true)
            {
                MessageBox.Show("Kies een grootte voor het dier");
                return;
            }
            if (typeCarnivoreBtn.Checked != true && typeHerbivoreBtn.Checked != true)
            {
                MessageBox.Show("Kies een diet type voor het dier");
                return;
            }

           
            
            //Animal animal = new Animal(animalNameTxtbox.Text, GetSelectedSize(), GetSelectedDiet());

            animals.Add(new Animal(animalNameTxtbox.Text, GetSelectedSize(), GetSelectedDiet()));

            // train.AddAnimalToQueue(animal);
            animalListTxtbox.Clear(); 
            
            foreach (var animal in animals)
            {
                animalListTxtbox.Text += animal + "\r\n";
            }

        
        }

        private void calcWagonsBtn_Click(object sender, EventArgs e)
        {

            wagonsTxtbox.Text = null;
            
            train.AddAnimalsToWagons(animals);
            
            var wagons = train.Getwagons();
            
            for (var i = 0; i < wagons.Count; i++)
            {
                wagonsTxtbox.Text += "Wagon " + (i + 1) + "\r\n";
                foreach (var animal in wagons[i].GetAnimalsList())
                {
                    wagonsTxtbox.Text += animal + "\r\n";
                }
               
                wagonsTxtbox.Text += "\r\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
