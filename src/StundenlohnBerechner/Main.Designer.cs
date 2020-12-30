namespace StundenlohnBerechner
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.numericUpDownWochenstunden = new System.Windows.Forms.NumericUpDown();
            this.labelWochenstunden = new System.Windows.Forms.Label();
            this.labelBruttomonatslohn = new System.Windows.Forms.Label();
            this.numericUpDownBruttomonatslohn = new System.Windows.Forms.NumericUpDown();
            this.buttonBerechne = new System.Windows.Forms.Button();
            this.textBoxErgebnis = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWochenstunden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruttomonatslohn)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownWochenstunden
            // 
            this.numericUpDownWochenstunden.DecimalPlaces = 2;
            this.numericUpDownWochenstunden.Location = new System.Drawing.Point(12, 43);
            this.numericUpDownWochenstunden.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownWochenstunden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownWochenstunden.Name = "numericUpDownWochenstunden";
            this.numericUpDownWochenstunden.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownWochenstunden.TabIndex = 0;
            this.numericUpDownWochenstunden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelWochenstunden
            // 
            this.labelWochenstunden.AutoSize = true;
            this.labelWochenstunden.Location = new System.Drawing.Point(9, 27);
            this.labelWochenstunden.Name = "labelWochenstunden";
            this.labelWochenstunden.Size = new System.Drawing.Size(89, 13);
            this.labelWochenstunden.TabIndex = 1;
            this.labelWochenstunden.Text = "Wochenstunden:";
            // 
            // labelBruttomonatslohn
            // 
            this.labelBruttomonatslohn.AutoSize = true;
            this.labelBruttomonatslohn.Location = new System.Drawing.Point(9, 66);
            this.labelBruttomonatslohn.Name = "labelBruttomonatslohn";
            this.labelBruttomonatslohn.Size = new System.Drawing.Size(92, 13);
            this.labelBruttomonatslohn.TabIndex = 3;
            this.labelBruttomonatslohn.Text = "Bruttomonatslohn:";
            // 
            // numericUpDownBruttomonatslohn
            // 
            this.numericUpDownBruttomonatslohn.DecimalPlaces = 2;
            this.numericUpDownBruttomonatslohn.Location = new System.Drawing.Point(12, 82);
            this.numericUpDownBruttomonatslohn.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownBruttomonatslohn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownBruttomonatslohn.Name = "numericUpDownBruttomonatslohn";
            this.numericUpDownBruttomonatslohn.Size = new System.Drawing.Size(148, 20);
            this.numericUpDownBruttomonatslohn.TabIndex = 2;
            this.numericUpDownBruttomonatslohn.ThousandsSeparator = true;
            this.numericUpDownBruttomonatslohn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonBerechne
            // 
            this.buttonBerechne.Location = new System.Drawing.Point(187, 42);
            this.buttonBerechne.Name = "buttonBerechne";
            this.buttonBerechne.Size = new System.Drawing.Size(148, 23);
            this.buttonBerechne.TabIndex = 4;
            this.buttonBerechne.Text = "Berechnen";
            this.buttonBerechne.UseVisualStyleBackColor = true;
            this.buttonBerechne.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // textBoxErgebnis
            // 
            this.textBoxErgebnis.Location = new System.Drawing.Point(187, 82);
            this.textBoxErgebnis.Name = "textBoxErgebnis";
            this.textBoxErgebnis.ReadOnly = true;
            this.textBoxErgebnis.Size = new System.Drawing.Size(148, 20);
            this.textBoxErgebnis.TabIndex = 5;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(187, 9);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(148, 21);
            this.comboBoxLanguage.TabIndex = 6;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguageSelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 116);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxErgebnis);
            this.Controls.Add(this.buttonBerechne);
            this.Controls.Add(this.labelBruttomonatslohn);
            this.Controls.Add(this.numericUpDownBruttomonatslohn);
            this.Controls.Add(this.labelWochenstunden);
            this.Controls.Add(this.numericUpDownWochenstunden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Stundenlohn Rechner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWochenstunden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBruttomonatslohn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownWochenstunden;
        private System.Windows.Forms.Label labelWochenstunden;
        private System.Windows.Forms.Label labelBruttomonatslohn;
        private System.Windows.Forms.NumericUpDown numericUpDownBruttomonatslohn;
        private System.Windows.Forms.Button buttonBerechne;
        private System.Windows.Forms.TextBox textBoxErgebnis;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
    }
}

