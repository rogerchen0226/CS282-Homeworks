using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PokemonLibrary;

namespace Example03
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemons;

        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
        }

        private void createPokemonButton_Click(object sender, EventArgs e)
        {
            PokemonPanel panel = new PokemonPanel();
            Pokemon pokemon = PokemonFactory.Create("Bulbasaur");

            pokemons.Add(pokemon);

            int count = pokemons.Count;
            panel.Location = new Point(14 + 270 * (count - 1), 93);
            panel.Render(pokemon);
            this.Controls.Add(panel);
        }
    }
}