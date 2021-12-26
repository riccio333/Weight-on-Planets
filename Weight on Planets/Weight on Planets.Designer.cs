namespace Weight_on_Planets
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbx_planets = new System.Windows.Forms.ComboBox();
            this.txt_earth_weight = new System.Windows.Forms.TextBox();
            this.lab_weight_earth = new System.Windows.Forms.Label();
            this.lab_select = new System.Windows.Forms.Label();
            this.lab_calculated_weight = new System.Windows.Forms.Label();
            this.txt_calculated_weight = new System.Windows.Forms.TextBox();
            this.lab_kg_earth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_pounds = new System.Windows.Forms.Label();
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.uguale = new System.Windows.Forms.Label();
            this.lab_kg_planets = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pounds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_kg = new System.Windows.Forms.Label();
            this.lab_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cbx_planets
            // 
            this.cbx_planets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_planets.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbx_planets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_planets.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_planets.FormattingEnabled = true;
            this.cbx_planets.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx_planets.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Moon",
            "Mars",
            "Phobos",
            "Deimos",
            "Jupiter",
            "Io",
            "Europa",
            "Ganymede",
            "Callisto",
            "Saturn",
            "Titan",
            "Rhea",
            "Iapetus",
            "Mimas",
            "Uranus",
            "Titania",
            "Neptune",
            "Triton",
            "Pluto"});
            this.cbx_planets.Location = new System.Drawing.Point(411, 132);
            this.cbx_planets.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_planets.Name = "cbx_planets";
            this.cbx_planets.Size = new System.Drawing.Size(132, 26);
            this.cbx_planets.TabIndex = 0;
            this.cbx_planets.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_earth_weight
            // 
            this.txt_earth_weight.Location = new System.Drawing.Point(411, 176);
            this.txt_earth_weight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_earth_weight.Name = "txt_earth_weight";
            this.txt_earth_weight.Size = new System.Drawing.Size(132, 22);
            this.txt_earth_weight.TabIndex = 1;
            this.txt_earth_weight.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // lab_weight_earth
            // 
            this.lab_weight_earth.AutoSize = true;
            this.lab_weight_earth.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_weight_earth.ForeColor = System.Drawing.Color.Orange;
            this.lab_weight_earth.Location = new System.Drawing.Point(267, 177);
            this.lab_weight_earth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_weight_earth.Name = "lab_weight_earth";
            this.lab_weight_earth.Size = new System.Drawing.Size(139, 18);
            this.lab_weight_earth.TabIndex = 2;
            this.lab_weight_earth.Text = "Your weight on Earth:";
            this.lab_weight_earth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_select
            // 
            this.lab_select.AutoSize = true;
            this.lab_select.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_select.ForeColor = System.Drawing.Color.Orange;
            this.lab_select.Location = new System.Drawing.Point(232, 135);
            this.lab_select.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_select.Name = "lab_select";
            this.lab_select.Size = new System.Drawing.Size(174, 18);
            this.lab_select.TabIndex = 3;
            this.lab_select.Text = "Select a Planet or Satellite:";
            this.lab_select.Click += new System.EventHandler(this.label2_Click);
            // 
            // lab_calculated_weight
            // 
            this.lab_calculated_weight.AutoSize = true;
            this.lab_calculated_weight.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_calculated_weight.ForeColor = System.Drawing.Color.Orange;
            this.lab_calculated_weight.Location = new System.Drawing.Point(241, 217);
            this.lab_calculated_weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_calculated_weight.Name = "lab_calculated_weight";
            this.lab_calculated_weight.Size = new System.Drawing.Size(163, 18);
            this.lab_calculated_weight.TabIndex = 4;
            this.lab_calculated_weight.Text = "Your weight on     .      .      .";
            this.lab_calculated_weight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_calculated_weight.Click += new System.EventHandler(this.lab_calculated_weight_Click);
            // 
            // txt_calculated_weight
            // 
            this.txt_calculated_weight.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_calculated_weight.Location = new System.Drawing.Point(411, 215);
            this.txt_calculated_weight.Margin = new System.Windows.Forms.Padding(4);
            this.txt_calculated_weight.Name = "txt_calculated_weight";
            this.txt_calculated_weight.ReadOnly = true;
            this.txt_calculated_weight.Size = new System.Drawing.Size(132, 22);
            this.txt_calculated_weight.TabIndex = 5;
            this.txt_calculated_weight.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // lab_kg_earth
            // 
            this.lab_kg_earth.AutoSize = true;
            this.lab_kg_earth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_kg_earth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_kg_earth.Location = new System.Drawing.Point(552, 179);
            this.lab_kg_earth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_kg_earth.Name = "lab_kg_earth";
            this.lab_kg_earth.Size = new System.Drawing.Size(19, 15);
            this.lab_kg_earth.TabIndex = 6;
            this.lab_kg_earth.Text = "kg";
            this.lab_kg_earth.Click += new System.EventHandler(this.lbl_nit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(376, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "kg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lab_pounds
            // 
            this.lab_pounds.AutoSize = true;
            this.lab_pounds.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pounds.ForeColor = System.Drawing.Color.Orange;
            this.lab_pounds.Location = new System.Drawing.Point(468, 293);
            this.lab_pounds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pounds.Name = "lab_pounds";
            this.lab_pounds.Size = new System.Drawing.Size(118, 26);
            this.lab_pounds.TabIndex = 8;
            this.lab_pounds.Text = "0,00 pounds";
            this.lab_pounds.Click += new System.EventHandler(this.lab_pounds_Click);
            // 
            // txt_kg
            // 
            this.txt_kg.Location = new System.Drawing.Point(235, 294);
            this.txt_kg.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(132, 22);
            this.txt_kg.TabIndex = 9;
            this.txt_kg.TextChanged += new System.EventHandler(this.Conversion);
            // 
            // uguale
            // 
            this.uguale.AutoSize = true;
            this.uguale.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uguale.ForeColor = System.Drawing.Color.Orange;
            this.uguale.Location = new System.Drawing.Point(423, 287);
            this.uguale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uguale.Name = "uguale";
            this.uguale.Size = new System.Drawing.Size(28, 33);
            this.uguale.TabIndex = 11;
            this.uguale.Text = "=";
            this.uguale.Click += new System.EventHandler(this.label5_Click);
            // 
            // lab_kg_planets
            // 
            this.lab_kg_planets.AutoSize = true;
            this.lab_kg_planets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lab_kg_planets.Location = new System.Drawing.Point(552, 219);
            this.lab_kg_planets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_kg_planets.Name = "lab_kg_planets";
            this.lab_kg_planets.Size = new System.Drawing.Size(22, 16);
            this.lab_kg_planets.TabIndex = 12;
            this.lab_kg_planets.Text = "kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your weight on different planets";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_pounds
            // 
            this.txt_pounds.Location = new System.Drawing.Point(235, 338);
            this.txt_pounds.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pounds.Name = "txt_pounds";
            this.txt_pounds.Size = new System.Drawing.Size(132, 22);
            this.txt_pounds.TabIndex = 14;
            this.txt_pounds.TextChanged += new System.EventHandler(this.Conversion);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(367, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "pounds";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(423, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "=";
            // 
            // lab_kg
            // 
            this.lab_kg.AutoSize = true;
            this.lab_kg.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_kg.ForeColor = System.Drawing.Color.Orange;
            this.lab_kg.Location = new System.Drawing.Point(468, 336);
            this.lab_kg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_kg.Name = "lab_kg";
            this.lab_kg.Size = new System.Drawing.Size(75, 26);
            this.lab_kg.TabIndex = 17;
            this.lab_kg.Text = "0,00 kg";
            this.lab_kg.TextChanged += new System.EventHandler(this.Conversion);
            this.lab_kg.Click += new System.EventHandler(this.lab_kg_Click);
            // 
            // lab_link
            // 
            this.lab_link.AutoSize = true;
            this.lab_link.LinkColor = System.Drawing.Color.Orange;
            this.lab_link.Location = new System.Drawing.Point(338, 421);
            this.lab_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_link.Name = "lab_link";
            this.lab_link.Size = new System.Drawing.Size(165, 16);
            this.lab_link.TabIndex = 18;
            this.lab_link.TabStop = true;
            this.lab_link.Text = "Copyright © 2021, riccio333";
            this.lab_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(794, 437);
            this.Controls.Add(this.lab_link);
            this.Controls.Add(this.lab_kg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pounds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_kg_planets);
            this.Controls.Add(this.uguale);
            this.Controls.Add(this.txt_kg);
            this.Controls.Add(this.lab_pounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_kg_earth);
            this.Controls.Add(this.txt_calculated_weight);
            this.Controls.Add(this.lab_calculated_weight);
            this.Controls.Add(this.lab_select);
            this.Controls.Add(this.lab_weight_earth);
            this.Controls.Add(this.txt_earth_weight);
            this.Controls.Add(this.cbx_planets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(814, 480);
            this.MinimumSize = new System.Drawing.Size(814, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weight on Planets";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_planets;
        private System.Windows.Forms.TextBox txt_earth_weight;
        private System.Windows.Forms.Label lab_weight_earth;
        private System.Windows.Forms.Label lab_select;
        private System.Windows.Forms.Label lab_calculated_weight;
        private System.Windows.Forms.TextBox txt_calculated_weight;
        private System.Windows.Forms.Label lab_kg_earth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_pounds;
        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.Label uguale;
        private System.Windows.Forms.Label lab_kg_planets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_kg;
        private System.Windows.Forms.LinkLabel lab_link;
    }
}

