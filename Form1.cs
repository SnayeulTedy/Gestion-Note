using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class Form1 : Form
    {
        double TP1;
        double TP2;
        double TP3;
        double ExamP;
        double ExamF;

        double noteTP1;
        double noteTP2;
        double noteTP3;
        double noteExamP;
        double noteExamF;
        double noteGlobale;
        double totalTP;
       


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxTP1.Text, out TP1))
            {
                if (TP1 < 0 || TP1 > 25)
                {
                    textBoxTP1.Text = string.Empty;
                    MessageBox.Show("Entrez une note de TP1 valide entre[0 - 25]");
                }
                else
                {
                    noteTP1 = (TP1 / 25) * 20;
                }
            }
            else
            {
                MessageBox.Show("Valeur de TP1 invalide");
            }
            if (double.TryParse(textBoxTP2.Text, out TP2))
            {
                if (TP2 < 0 || TP2 > 35)
                {
                    textBoxTP2.Text = string.Empty;
                    MessageBox.Show("Entrez une note de TP2 valide entre[0 - 35]");
                }
                else
                {
                    noteTP2 = (TP2 / 35) * 20;
                }
            }
            else
            {
                MessageBox.Show("Valeur de TP2 invalide");
            }
            if (double.TryParse(textBoxTP3.Text, out TP3))
            {
                if (TP3 < 0 || TP3 > 40)
                {
                    textBoxTP3.Text = string.Empty;
                    MessageBox.Show("Entrez une note de TP3 valide entre[0 - 40]");
                }
                else
                {
                    noteTP3 = (TP3 / 40) * 20;
                }
            }
            else
            {
                MessageBox.Show("Valeur de TP3 invalide");
            }
            if (double.TryParse(textBoxExamenPratique.Text, out ExamP))
            {
                if (ExamP < 0 || ExamP > 100)
                {
                    textBoxExamenPratique.Text = string.Empty;
                    MessageBox.Show("Entrez une note de Exam pratique valide entre[0 - 100]");
                }
                else
                {
                    noteExamP = (ExamP / 100) * 20;
                   
                }
            }
            else
            {
                MessageBox.Show("Valeurde l'examen pratique invalide");
            }


            if (double.TryParse(textBoxExamenFinal.Text, out ExamF))
            {
                if (ExamF < 0 || ExamF > 100)
                {
                    textBoxExamenFinal.Text = string.Empty;
                    MessageBox.Show("Entrez une note de Exam finale valide entre[0 - 100]");
                }
                else
                {
                    noteExamF = (ExamF / 100) * 20;
                   
                }
            }
            else
            {
                MessageBox.Show("Valeur de l'examen final invalide");
            }

           

            if (double.TryParse(textBoxNoteGlobale.Text, out noteGlobale))
            {
                totalTP = noteTP1 + noteTP2 + noteTP3;
                noteGlobale = ((totalTP / 3) * 0.4 + noteExamP * 0.2 + noteExamF * 0.4);
                textBoxNoteGlobale.Text = noteGlobale.ToString("F2");
                textBoxTotalTP.Text = totalTP.ToString("F2");

                if (noteGlobale >= 0 && noteGlobale < 10)
                {
                    textBoxLettre.Text = "E";
                }
                else if (noteGlobale >= 10 && noteGlobale < 14)
                {
                    textBoxLettre.Text = "D";
                }
                else if (noteGlobale >= 14 && noteGlobale < 16)
                {
                    textBoxLettre.Text = "C";
                }
                else if (noteGlobale >= 16 && noteGlobale < 18)
                {
                    textBoxLettre.Text = "B";
                }
                else
                {
                    textBoxLettre.Text = "A";
                }
            }
          
  
        }
            

        private void textBoxTotalTP_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Fermer l'application ?", "GestionNotes",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GestionNotes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult efface = MessageBox.Show("Effacer les donnees saisies ?", "Effacer les données", MessageBoxButtons.OKCancel);
                if (efface == DialogResult.OK)
                {
                    textBoxTP1.Text = "";
                    textBoxTP2.Text = "";
                    textBoxTP3.Text = "";
                    textBoxExamenPratique.Text = "";
                    textBoxExamenFinal.Text = "";
                    textBoxLettre.Text = "";
                    textBoxNoteGlobale.Text = "";
                    textBoxTotalTP.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GestionNotes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }


        private void textBoxLettre_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
