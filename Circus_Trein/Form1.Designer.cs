namespace Circus_Trein
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
            this.addAnimalBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.animalNameTxtbox = new System.Windows.Forms.TextBox();
            this.AnimalDiet = new System.Windows.Forms.GroupBox();
            this.typeHerbivoreBtn = new System.Windows.Forms.RadioButton();
            this.typeCarnivoreBtn = new System.Windows.Forms.RadioButton();
            this.AnimalSize = new System.Windows.Forms.GroupBox();
            this.sizeLargeBtn = new System.Windows.Forms.RadioButton();
            this.sizeMediumBtn = new System.Windows.Forms.RadioButton();
            this.sizeSmallBtn = new System.Windows.Forms.RadioButton();
            this.animalListTxtbox = new System.Windows.Forms.TextBox();
            this.wagonsTxtbox = new System.Windows.Forms.TextBox();
            this.calcWagonsBtn = new System.Windows.Forms.Button();
            this.AnimalDiet.SuspendLayout();
            this.AnimalSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // addAnimalBtn
            // 
            this.addAnimalBtn.Location = new System.Drawing.Point(17, 230);
            this.addAnimalBtn.Name = "addAnimalBtn";
            this.addAnimalBtn.Size = new System.Drawing.Size(139, 23);
            this.addAnimalBtn.TabIndex = 9;
            this.addAnimalBtn.Text = "Add Animal";
            this.addAnimalBtn.UseVisualStyleBackColor = true;
            this.addAnimalBtn.Click += new System.EventHandler(this.addAnimalBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // animalNameTxtbox
            // 
            this.animalNameTxtbox.Location = new System.Drawing.Point(56, 6);
            this.animalNameTxtbox.Name = "animalNameTxtbox";
            this.animalNameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.animalNameTxtbox.TabIndex = 7;
            // 
            // AnimalDiet
            // 
            this.AnimalDiet.Controls.Add(this.typeHerbivoreBtn);
            this.AnimalDiet.Controls.Add(this.typeCarnivoreBtn);
            this.AnimalDiet.Location = new System.Drawing.Point(15, 150);
            this.AnimalDiet.Name = "AnimalDiet";
            this.AnimalDiet.Size = new System.Drawing.Size(105, 72);
            this.AnimalDiet.TabIndex = 6;
            this.AnimalDiet.TabStop = false;
            this.AnimalDiet.Text = "AnimalDiet";
            // 
            // typeHerbivoreBtn
            // 
            this.typeHerbivoreBtn.AutoSize = true;
            this.typeHerbivoreBtn.Location = new System.Drawing.Point(15, 42);
            this.typeHerbivoreBtn.Name = "typeHerbivoreBtn";
            this.typeHerbivoreBtn.Size = new System.Drawing.Size(71, 17);
            this.typeHerbivoreBtn.TabIndex = 5;
            this.typeHerbivoreBtn.TabStop = true;
            this.typeHerbivoreBtn.Text = "Herbivore";
            this.typeHerbivoreBtn.UseVisualStyleBackColor = true;
            // 
            // typeCarnivoreBtn
            // 
            this.typeCarnivoreBtn.AutoSize = true;
            this.typeCarnivoreBtn.Checked = true;
            this.typeCarnivoreBtn.Location = new System.Drawing.Point(15, 19);
            this.typeCarnivoreBtn.Name = "typeCarnivoreBtn";
            this.typeCarnivoreBtn.Size = new System.Drawing.Size(70, 17);
            this.typeCarnivoreBtn.TabIndex = 4;
            this.typeCarnivoreBtn.TabStop = true;
            this.typeCarnivoreBtn.Text = "Carnivore";
            this.typeCarnivoreBtn.UseVisualStyleBackColor = true;
            // 
            // AnimalSize
            // 
            this.AnimalSize.Controls.Add(this.sizeLargeBtn);
            this.AnimalSize.Controls.Add(this.sizeMediumBtn);
            this.AnimalSize.Controls.Add(this.sizeSmallBtn);
            this.AnimalSize.Location = new System.Drawing.Point(15, 44);
            this.AnimalSize.Name = "AnimalSize";
            this.AnimalSize.Size = new System.Drawing.Size(105, 90);
            this.AnimalSize.TabIndex = 5;
            this.AnimalSize.TabStop = false;
            this.AnimalSize.Text = "animalsize";
            // 
            // sizeLargeBtn
            // 
            this.sizeLargeBtn.AutoSize = true;
            this.sizeLargeBtn.Location = new System.Drawing.Point(15, 65);
            this.sizeLargeBtn.Name = "sizeLargeBtn";
            this.sizeLargeBtn.Size = new System.Drawing.Size(52, 17);
            this.sizeLargeBtn.TabIndex = 3;
            this.sizeLargeBtn.TabStop = true;
            this.sizeLargeBtn.Text = "Large";
            this.sizeLargeBtn.UseVisualStyleBackColor = true;
            // 
            // sizeMediumBtn
            // 
            this.sizeMediumBtn.AutoSize = true;
            this.sizeMediumBtn.Location = new System.Drawing.Point(15, 42);
            this.sizeMediumBtn.Name = "sizeMediumBtn";
            this.sizeMediumBtn.Size = new System.Drawing.Size(62, 17);
            this.sizeMediumBtn.TabIndex = 2;
            this.sizeMediumBtn.TabStop = true;
            this.sizeMediumBtn.Text = "Medium";
            this.sizeMediumBtn.UseVisualStyleBackColor = true;
            // 
            // sizeSmallBtn
            // 
            this.sizeSmallBtn.AutoSize = true;
            this.sizeSmallBtn.Checked = true;
            this.sizeSmallBtn.Location = new System.Drawing.Point(15, 19);
            this.sizeSmallBtn.Name = "sizeSmallBtn";
            this.sizeSmallBtn.Size = new System.Drawing.Size(50, 17);
            this.sizeSmallBtn.TabIndex = 1;
            this.sizeSmallBtn.TabStop = true;
            this.sizeSmallBtn.Text = "Small";
            this.sizeSmallBtn.UseVisualStyleBackColor = true;
            // 
            // animalListTxtbox
            // 
            this.animalListTxtbox.Location = new System.Drawing.Point(221, 6);
            this.animalListTxtbox.Multiline = true;
            this.animalListTxtbox.Name = "animalListTxtbox";
            this.animalListTxtbox.ReadOnly = true;
            this.animalListTxtbox.Size = new System.Drawing.Size(287, 275);
            this.animalListTxtbox.TabIndex = 10;
            // 
            // wagonsTxtbox
            // 
            this.wagonsTxtbox.Location = new System.Drawing.Point(514, 6);
            this.wagonsTxtbox.Multiline = true;
            this.wagonsTxtbox.Name = "wagonsTxtbox";
            this.wagonsTxtbox.ReadOnly = true;
            this.wagonsTxtbox.Size = new System.Drawing.Size(287, 275);
            this.wagonsTxtbox.TabIndex = 11;
            // 
            // calcWagonsBtn
            // 
            this.calcWagonsBtn.Location = new System.Drawing.Point(17, 258);
            this.calcWagonsBtn.Name = "calcWagonsBtn";
            this.calcWagonsBtn.Size = new System.Drawing.Size(139, 23);
            this.calcWagonsBtn.TabIndex = 12;
            this.calcWagonsBtn.Text = "Calculate Wagons";
            this.calcWagonsBtn.UseVisualStyleBackColor = true;
            this.calcWagonsBtn.Click += new System.EventHandler(this.calcWagonsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 293);
            this.Controls.Add(this.calcWagonsBtn);
            this.Controls.Add(this.wagonsTxtbox);
            this.Controls.Add(this.animalListTxtbox);
            this.Controls.Add(this.addAnimalBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.animalNameTxtbox);
            this.Controls.Add(this.AnimalDiet);
            this.Controls.Add(this.AnimalSize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AnimalDiet.ResumeLayout(false);
            this.AnimalDiet.PerformLayout();
            this.AnimalSize.ResumeLayout(false);
            this.AnimalSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addAnimalBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox animalNameTxtbox;
        private System.Windows.Forms.GroupBox AnimalDiet;
        private System.Windows.Forms.RadioButton typeHerbivoreBtn;
        private System.Windows.Forms.RadioButton typeCarnivoreBtn;
        private System.Windows.Forms.GroupBox AnimalSize;
        private System.Windows.Forms.RadioButton sizeLargeBtn;
        private System.Windows.Forms.RadioButton sizeMediumBtn;
        private System.Windows.Forms.RadioButton sizeSmallBtn;
        private System.Windows.Forms.TextBox animalListTxtbox;
        private System.Windows.Forms.TextBox wagonsTxtbox;
        private System.Windows.Forms.Button calcWagonsBtn;
    }
}

