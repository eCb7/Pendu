using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pendu
{
    public partial class Form1 : Form
    {
        // Tableau pour stocker les boutons de lettres
        private Button[] letterButtons;

        public Form1()
        {
            InitializeComponent();
            InitializeLetterButtons();
        }

        // Initialiser les boutons de lettres
        private void InitializeLetterButtons()
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            letterButtons = new Button[alphabet.Length];

            // Définir les dimensions pour positionner les boutons
            int buttonWidth = 30;
            int buttonHeight = 30;
            int padding = 19; // Espacement des lettres (entre elles et avec la marge)
            int columns = 6; // Nombre de boutons par ligne
            int currentColumn = 0;
            int currentRow = 0;

            for (int i = 0; i < alphabet.Length; i++)
            {
                Button btnLetter = new Button();
                btnLetter.Text = alphabet[i].ToString();
                btnLetter.Width = buttonWidth;
                btnLetter.Height = buttonHeight;

                // Calculer les coordonnées pour le bouton
                int x = padding + (buttonWidth + padding) * currentColumn;
                int y = padding + (buttonHeight + padding) * currentRow;

                btnLetter.Location = new Point(x, y);

                // Gérer les colonnes et les lignes
                currentColumn++;
                if (currentColumn >= columns)
                {
                    currentColumn = 0;
                    currentRow++;
                }

                btnLetter.Click += BtnLetter_Click;
                groupBox5.Controls.Add(btnLetter);
                letterButtons[i] = btnLetter;
            }
        }

        // Gestionnaire d'événement pour le clic sur un bouton de lettre
        private void BtnLetter_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false; // Désactive le bouton
            clickedButton.BackColor = System.Drawing.Color.Gray; // Change la couleur du bouton
        }

        // Gestionnaire d'événement pour le clic sur le bouton de réinitialisation
        private void button1_Click(object sender, EventArgs e)
        {
            ResetLetterButtons();
        }

        // Réinitialiser tous les boutons de lettres
        private void ResetLetterButtons()
        {
            foreach (Button btnLetter in letterButtons)
            {
                btnLetter.Enabled = true;
                btnLetter.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
