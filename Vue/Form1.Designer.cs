namespace mission2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ajouter = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.listboxLiaison = new System.Windows.Forms.ListBox();
            this.listboxSecteur = new System.Windows.Forms.ListBox();
            this.modifbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxSecteurs = new System.Windows.Forms.ListBox();
            this.sicilylines = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.Highlight;
            this.ajouter.Location = new System.Drawing.Point(37, 161);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(75, 23);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Yellow;
            this.modifier.Location = new System.Drawing.Point(187, 88);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(75, 23);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Location = new System.Drawing.Point(340, 88);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(75, 23);
            this.supprimer.TabIndex = 2;
            this.supprimer.Text = "supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // listboxLiaison
            // 
            this.listboxLiaison.FormattingEnabled = true;
            this.listboxLiaison.Location = new System.Drawing.Point(430, 86);
            this.listboxLiaison.Name = "listboxLiaison";
            this.listboxLiaison.Size = new System.Drawing.Size(118, 82);
            this.listboxLiaison.TabIndex = 4;
            this.listboxLiaison.SelectedIndexChanged += new System.EventHandler(this.liaison_SelectedIndexChanged);
            // 
            // listboxSecteur
            // 
            this.listboxSecteur.FormattingEnabled = true;
            this.listboxSecteur.Location = new System.Drawing.Point(203, 86);
            this.listboxSecteur.Name = "listboxSecteur";
            this.listboxSecteur.Size = new System.Drawing.Size(124, 82);
            this.listboxSecteur.TabIndex = 5;
            this.listboxSecteur.SelectedIndexChanged += new System.EventHandler(this.secteur_SelectedIndexChanged);
            // 
            // modifbox
            // 
            this.modifbox.Location = new System.Drawing.Point(173, 52);
            this.modifbox.Name = "modifbox";
            this.modifbox.Size = new System.Drawing.Size(105, 20);
            this.modifbox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxSecteurs);
            this.groupBox1.Controls.Add(this.modifier);
            this.groupBox1.Controls.Add(this.modifbox);
            this.groupBox1.Controls.Add(this.ajouter);
            this.groupBox1.Controls.Add(this.supprimer);
            this.groupBox1.Location = new System.Drawing.Point(166, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 218);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBoxSecteurs
            // 
            this.listBoxSecteurs.FormattingEnabled = true;
            this.listBoxSecteurs.Location = new System.Drawing.Point(35, 52);
            this.listBoxSecteurs.Name = "listBoxSecteurs";
            this.listBoxSecteurs.Size = new System.Drawing.Size(77, 95);
            this.listBoxSecteurs.TabIndex = 7;
            this.listBoxSecteurs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // sicilylines
            // 
            this.sicilylines.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sicilylines.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicilylines.ForeColor = System.Drawing.Color.Aqua;
            this.sicilylines.Location = new System.Drawing.Point(203, 20);
            this.sicilylines.Name = "sicilylines";
            this.sicilylines.Size = new System.Drawing.Size(314, 45);
            this.sicilylines.TabIndex = 9;
            this.sicilylines.Text = "Sicilylines";
            this.sicilylines.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mission2.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sicilylines);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listboxSecteur);
            this.Controls.Add(this.listboxLiaison);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.ListBox listboxLiaison;
        private System.Windows.Forms.TextBox modifbox;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox sicilylines;
        private System.Windows.Forms.ListBox listBoxSecteurs;
        private System.Windows.Forms.ListBox listboxSecteur;
    }
}

