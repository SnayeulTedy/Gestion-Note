namespace GestionNotes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTP1 = new System.Windows.Forms.TextBox();
            this.textBoxTP2 = new System.Windows.Forms.TextBox();
            this.textBoxTP3 = new System.Windows.Forms.TextBox();
            this.textBoxExamenPratique = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.textBoxExamenFinal = new System.Windows.Forms.TextBox();
            this.textBoxNoteGlobale = new System.Windows.Forms.Label();
            this.textBoxLettre = new System.Windows.Forms.Label();
            this.textBoxTotalTP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculer
            // 
            this.btnCalculer.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCalculer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculer.ForeColor = System.Drawing.Color.White;
            this.btnCalculer.Location = new System.Drawing.Point(127, 403);
            this.btnCalculer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(162, 47);
            this.btnCalculer.TabIndex = 0;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = false;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEffacer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Location = new System.Drawing.Point(335, 403);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(162, 47);
            this.btnEffacer.TabIndex = 0;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TP1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "TP2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "TP3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "EXAMEN PRATIQUE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "EXAMEN FINALE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "NOTE GLOBALE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "LETTRE A ATTRIBUER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "TOTAL TP";
            // 
            // textBoxTP1
            // 
            this.textBoxTP1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTP1.Location = new System.Drawing.Point(129, 67);
            this.textBoxTP1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTP1.Name = "textBoxTP1";
            this.textBoxTP1.Size = new System.Drawing.Size(112, 30);
            this.textBoxTP1.TabIndex = 2;
            this.textBoxTP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTP2
            // 
            this.textBoxTP2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTP2.Location = new System.Drawing.Point(129, 128);
            this.textBoxTP2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTP2.Name = "textBoxTP2";
            this.textBoxTP2.Size = new System.Drawing.Size(112, 30);
            this.textBoxTP2.TabIndex = 2;
            this.textBoxTP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTP3
            // 
            this.textBoxTP3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTP3.Location = new System.Drawing.Point(129, 194);
            this.textBoxTP3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTP3.Name = "textBoxTP3";
            this.textBoxTP3.Size = new System.Drawing.Size(112, 30);
            this.textBoxTP3.TabIndex = 2;
            this.textBoxTP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxExamenPratique
            // 
            this.textBoxExamenPratique.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamenPratique.Location = new System.Drawing.Point(607, 67);
            this.textBoxExamenPratique.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExamenPratique.Name = "textBoxExamenPratique";
            this.textBoxExamenPratique.Size = new System.Drawing.Size(112, 30);
            this.textBoxExamenPratique.TabIndex = 2;
            this.textBoxExamenPratique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Red;
            this.btnQuitter.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(557, 403);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(162, 47);
            this.btnQuitter.TabIndex = 0;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // textBoxExamenFinal
            // 
            this.textBoxExamenFinal.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExamenFinal.Location = new System.Drawing.Point(607, 128);
            this.textBoxExamenFinal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExamenFinal.Name = "textBoxExamenFinal";
            this.textBoxExamenFinal.Size = new System.Drawing.Size(112, 30);
            this.textBoxExamenFinal.TabIndex = 2;
            this.textBoxExamenFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNoteGlobale
            // 
            this.textBoxNoteGlobale.BackColor = System.Drawing.Color.Transparent;
            this.textBoxNoteGlobale.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNoteGlobale.ForeColor = System.Drawing.Color.Black;
            this.textBoxNoteGlobale.Location = new System.Drawing.Point(607, 184);
            this.textBoxNoteGlobale.Name = "textBoxNoteGlobale";
            this.textBoxNoteGlobale.Size = new System.Drawing.Size(112, 33);
            this.textBoxNoteGlobale.TabIndex = 3;
            this.textBoxNoteGlobale.Text = "...";
            this.textBoxNoteGlobale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLettre
            // 
            this.textBoxLettre.BackColor = System.Drawing.Color.Transparent;
            this.textBoxLettre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLettre.ForeColor = System.Drawing.Color.Black;
            this.textBoxLettre.Location = new System.Drawing.Point(539, 317);
            this.textBoxLettre.Name = "textBoxLettre";
            this.textBoxLettre.Size = new System.Drawing.Size(84, 29);
            this.textBoxLettre.TabIndex = 3;
            this.textBoxLettre.Text = "...";
            this.textBoxLettre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalTP
            // 
            this.textBoxTotalTP.BackColor = System.Drawing.Color.Transparent;
            this.textBoxTotalTP.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalTP.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotalTP.Location = new System.Drawing.Point(111, 317);
            this.textBoxTotalTP.Name = "textBoxTotalTP";
            this.textBoxTotalTP.Size = new System.Drawing.Size(84, 29);
            this.textBoxTotalTP.TabIndex = 3;
            this.textBoxTotalTP.Text = "...";
            this.textBoxTotalTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(801, 500);
            this.Controls.Add(this.textBoxTotalTP);
            this.Controls.Add(this.textBoxLettre);
            this.Controls.Add(this.textBoxNoteGlobale);
            this.Controls.Add(this.textBoxExamenFinal);
            this.Controls.Add(this.textBoxExamenPratique);
            this.Controls.Add(this.textBoxTP3);
            this.Controls.Add(this.textBoxTP2);
            this.Controls.Add(this.textBoxTP1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnCalculer);
            this.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTES MISTER~S TI-PAM1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTP1;
        private System.Windows.Forms.TextBox textBoxTP2;
        private System.Windows.Forms.TextBox textBoxTP3;
        private System.Windows.Forms.TextBox textBoxExamenPratique;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox textBoxExamenFinal;
        private System.Windows.Forms.Label textBoxNoteGlobale;
        private System.Windows.Forms.Label textBoxLettre;
        private System.Windows.Forms.Label textBoxTotalTP;
    }
}

