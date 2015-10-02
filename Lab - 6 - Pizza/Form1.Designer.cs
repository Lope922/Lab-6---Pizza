namespace Lab___6___Pizza
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoThickCrust = new System.Windows.Forms.RadioButton();
            this.rdoThinCrust = new System.Windows.Forms.RadioButton();
            this.rdoStuffedCrust = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.checkBoxGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkBoxBlackOlive = new System.Windows.Forms.CheckBox();
            this.chkBoxSausage = new System.Windows.Forms.CheckBox();
            this.chkBoxPepperoni = new System.Windows.Forms.CheckBox();
            this.chkBoxCheese = new System.Windows.Forms.CheckBox();
            this.listBoxOrderBuilder = new System.Windows.Forms.ListBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Picture of Pizza";
            // 
            // rdoThickCrust
            // 
            this.rdoThickCrust.AutoSize = true;
            this.rdoThickCrust.Location = new System.Drawing.Point(28, 19);
            this.rdoThickCrust.Name = "rdoThickCrust";
            this.rdoThickCrust.Size = new System.Drawing.Size(79, 17);
            this.rdoThickCrust.TabIndex = 2;
            this.rdoThickCrust.TabStop = true;
            this.rdoThickCrust.Text = "Thick Crust";
            this.rdoThickCrust.UseVisualStyleBackColor = true;
            // 
            // rdoThinCrust
            // 
            this.rdoThinCrust.AutoSize = true;
            this.rdoThinCrust.Location = new System.Drawing.Point(28, 50);
            this.rdoThinCrust.Name = "rdoThinCrust";
            this.rdoThinCrust.Size = new System.Drawing.Size(73, 17);
            this.rdoThinCrust.TabIndex = 3;
            this.rdoThinCrust.TabStop = true;
            this.rdoThinCrust.Text = "Thin Crust";
            this.rdoThinCrust.UseVisualStyleBackColor = true;
            // 
            // rdoStuffedCrust
            // 
            this.rdoStuffedCrust.AutoSize = true;
            this.rdoStuffedCrust.Location = new System.Drawing.Point(28, 86);
            this.rdoStuffedCrust.Name = "rdoStuffedCrust";
            this.rdoStuffedCrust.Size = new System.Drawing.Size(86, 17);
            this.rdoStuffedCrust.TabIndex = 4;
            this.rdoStuffedCrust.TabStop = true;
            this.rdoStuffedCrust.Text = "Stuffed Crust";
            this.rdoStuffedCrust.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoThickCrust);
            this.groupBox1.Controls.Add(this.rdoStuffedCrust);
            this.groupBox1.Controls.Add(this.rdoThinCrust);
            this.groupBox1.Location = new System.Drawing.Point(40, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.Controls.Add(this.checkBoxGreenPepper);
            this.groupBoxToppings.Controls.Add(this.chkBoxBlackOlive);
            this.groupBoxToppings.Controls.Add(this.chkBoxSausage);
            this.groupBoxToppings.Controls.Add(this.chkBoxPepperoni);
            this.groupBoxToppings.Controls.Add(this.chkBoxCheese);
            this.groupBoxToppings.Location = new System.Drawing.Point(262, 280);
            this.groupBoxToppings.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxToppings.Size = new System.Drawing.Size(208, 120);
            this.groupBoxToppings.TabIndex = 6;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "Choose your toppings";
            // 
            // checkBoxGreenPepper
            // 
            this.checkBoxGreenPepper.AutoSize = true;
            this.checkBoxGreenPepper.Location = new System.Drawing.Point(88, 43);
            this.checkBoxGreenPepper.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGreenPepper.Name = "checkBoxGreenPepper";
            this.checkBoxGreenPepper.Size = new System.Drawing.Size(92, 17);
            this.checkBoxGreenPepper.TabIndex = 4;
            this.checkBoxGreenPepper.Text = "Green Pepper";
            this.checkBoxGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkBoxBlackOlive
            // 
            this.chkBoxBlackOlive.AutoSize = true;
            this.chkBoxBlackOlive.Location = new System.Drawing.Point(88, 18);
            this.chkBoxBlackOlive.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxBlackOlive.Name = "chkBoxBlackOlive";
            this.chkBoxBlackOlive.Size = new System.Drawing.Size(80, 17);
            this.chkBoxBlackOlive.TabIndex = 3;
            this.chkBoxBlackOlive.Text = "Black Olive";
            this.chkBoxBlackOlive.UseVisualStyleBackColor = true;
            // 
            // chkBoxSausage
            // 
            this.chkBoxSausage.AutoSize = true;
            this.chkBoxSausage.Location = new System.Drawing.Point(5, 65);
            this.chkBoxSausage.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxSausage.Name = "chkBoxSausage";
            this.chkBoxSausage.Size = new System.Drawing.Size(68, 17);
            this.chkBoxSausage.TabIndex = 2;
            this.chkBoxSausage.Text = "Sausage";
            this.chkBoxSausage.UseVisualStyleBackColor = true;
            // 
            // chkBoxPepperoni
            // 
            this.chkBoxPepperoni.AutoSize = true;
            this.chkBoxPepperoni.Location = new System.Drawing.Point(5, 42);
            this.chkBoxPepperoni.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxPepperoni.Name = "chkBoxPepperoni";
            this.chkBoxPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkBoxPepperoni.TabIndex = 1;
            this.chkBoxPepperoni.Text = "Pepperoni";
            this.chkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkBoxCheese
            // 
            this.chkBoxCheese.AutoSize = true;
            this.chkBoxCheese.Location = new System.Drawing.Point(5, 18);
            this.chkBoxCheese.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxCheese.Name = "chkBoxCheese";
            this.chkBoxCheese.Size = new System.Drawing.Size(62, 17);
            this.chkBoxCheese.TabIndex = 0;
            this.chkBoxCheese.Text = "Cheese";
            this.chkBoxCheese.UseVisualStyleBackColor = true;
            
            // 
            // listBoxOrderBuilder
            // 
            this.listBoxOrderBuilder.FormattingEnabled = true;
            this.listBoxOrderBuilder.Location = new System.Drawing.Point(444, 72);
            this.listBoxOrderBuilder.Name = "listBoxOrderBuilder";
            this.listBoxOrderBuilder.Size = new System.Drawing.Size(271, 95);
            this.listBoxOrderBuilder.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(475, 316);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 452);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.listBoxOrderBuilder);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoThickCrust;
        private System.Windows.Forms.RadioButton rdoThinCrust;
        private System.Windows.Forms.RadioButton rdoStuffedCrust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox chkBoxSausage;
        private System.Windows.Forms.CheckBox chkBoxPepperoni;
        private System.Windows.Forms.CheckBox chkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxGreenPepper;
        private System.Windows.Forms.CheckBox chkBoxBlackOlive;
        private System.Windows.Forms.ListBox listBoxOrderBuilder;
        private System.Windows.Forms.Button btnConfirm;
    }
}

