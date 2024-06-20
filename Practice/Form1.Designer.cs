namespace Practice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTest = new TextBox();
            add = new Button();
            minus = new Button();
            multiply = new Button();
            divide = new Button();
            button5 = new Button();
            lblTest = new Label();
            botThree = new Button();
            botTwo = new Button();
            botOne = new Button();
            botSix = new Button();
            botFive = new Button();
            botFour = new Button();
            botNine = new Button();
            botEight = new Button();
            botSeven = new Button();
            botZero = new Button();
            button16 = new Button();
            SuspendLayout();
            // 
            // txtTest
            // 
            txtTest.Font = new Font("Segoe UI", 20F);
            txtTest.Location = new Point(12, 12);
            txtTest.Name = "txtTest";
            txtTest.ReadOnly = true;
            txtTest.Size = new Size(244, 43);
            txtTest.TabIndex = 2;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 15F);
            add.ForeColor = Color.Red;
            add.ImageAlign = ContentAlignment.TopRight;
            add.Location = new Point(254, 100);
            add.Name = "add";
            add.Size = new Size(52, 44);
            add.TabIndex = 3;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 15F);
            minus.ForeColor = Color.Red;
            minus.Location = new Point(254, 150);
            minus.Name = "minus";
            minus.Size = new Size(52, 44);
            minus.TabIndex = 4;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 15F);
            multiply.ForeColor = Color.Red;
            multiply.Location = new Point(254, 200);
            multiply.Name = "multiply";
            multiply.Size = new Size(52, 44);
            multiply.TabIndex = 5;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 15F);
            divide.ForeColor = Color.Red;
            divide.Location = new Point(254, 250);
            divide.Name = "divide";
            divide.Size = new Size(52, 44);
            divide.TabIndex = 6;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(192, 250);
            button5.Name = "button5";
            button5.Size = new Size(56, 44);
            button5.TabIndex = 7;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += button5_MouseClick;
            // 
            // lblTest
            // 
            lblTest.BorderStyle = BorderStyle.Fixed3D;
            lblTest.Location = new Point(254, 12);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(117, 43);
            lblTest.TabIndex = 0;
            lblTest.Text = "..........";
            lblTest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botThree
            // 
            botThree.Font = new Font("Segoe UI", 15F);
            botThree.ForeColor = Color.Black;
            botThree.Location = new Point(192, 200);
            botThree.Name = "botThree";
            botThree.Size = new Size(56, 44);
            botThree.TabIndex = 8;
            botThree.Text = "3";
            botThree.UseVisualStyleBackColor = true;
            // 
            // botTwo
            // 
            botTwo.Font = new Font("Segoe UI", 15F);
            botTwo.ForeColor = Color.Black;
            botTwo.Location = new Point(130, 200);
            botTwo.Name = "botTwo";
            botTwo.Size = new Size(56, 44);
            botTwo.TabIndex = 9;
            botTwo.Text = "2";
            botTwo.UseVisualStyleBackColor = true;
            // 
            // botOne
            // 
            botOne.Font = new Font("Segoe UI", 15F);
            botOne.ForeColor = Color.Black;
            botOne.Location = new Point(68, 200);
            botOne.Name = "botOne";
            botOne.Size = new Size(56, 44);
            botOne.TabIndex = 10;
            botOne.Text = "1";
            botOne.UseVisualStyleBackColor = true;
            // 
            // botSix
            // 
            botSix.Font = new Font("Segoe UI", 15F);
            botSix.ForeColor = Color.Black;
            botSix.Location = new Point(192, 150);
            botSix.Name = "botSix";
            botSix.Size = new Size(56, 44);
            botSix.TabIndex = 11;
            botSix.Text = "6";
            botSix.UseVisualStyleBackColor = true;
            // 
            // botFive
            // 
            botFive.Font = new Font("Segoe UI", 15F);
            botFive.ForeColor = Color.Black;
            botFive.Location = new Point(130, 150);
            botFive.Name = "botFive";
            botFive.Size = new Size(56, 44);
            botFive.TabIndex = 12;
            botFive.Text = "5";
            botFive.UseVisualStyleBackColor = true;
            // 
            // botFour
            // 
            botFour.Font = new Font("Segoe UI", 15F);
            botFour.Location = new Point(68, 150);
            botFour.Name = "botFour";
            botFour.Size = new Size(56, 44);
            botFour.TabIndex = 13;
            botFour.Text = "4";
            botFour.UseVisualStyleBackColor = true;
            // 
            // botNine
            // 
            botNine.Font = new Font("Segoe UI", 15F);
            botNine.ForeColor = Color.Black;
            botNine.Location = new Point(192, 100);
            botNine.Name = "botNine";
            botNine.Size = new Size(56, 44);
            botNine.TabIndex = 14;
            botNine.Text = "9";
            botNine.UseVisualStyleBackColor = true;
            // 
            // botEight
            // 
            botEight.Font = new Font("Segoe UI", 15F);
            botEight.ForeColor = Color.Black;
            botEight.Location = new Point(130, 100);
            botEight.Name = "botEight";
            botEight.Size = new Size(56, 44);
            botEight.TabIndex = 15;
            botEight.Text = "8";
            botEight.UseVisualStyleBackColor = true;
            // 
            // botSeven
            // 
            botSeven.Font = new Font("Segoe UI", 15F);
            botSeven.ForeColor = Color.Black;
            botSeven.Location = new Point(68, 100);
            botSeven.Name = "botSeven";
            botSeven.Size = new Size(56, 44);
            botSeven.TabIndex = 16;
            botSeven.Text = "7";
            botSeven.UseVisualStyleBackColor = true;
            // 
            // botZero
            // 
            botZero.Font = new Font("Segoe UI", 15F);
            botZero.ForeColor = Color.Black;
            botZero.Location = new Point(130, 250);
            botZero.Name = "botZero";
            botZero.Size = new Size(56, 44);
            botZero.TabIndex = 17;
            botZero.Text = "0";
            botZero.UseVisualStyleBackColor = true;
            botZero.MouseClick += botZero_MouseClick;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 15F);
            button16.ForeColor = Color.Black;
            button16.Location = new Point(68, 250);
            button16.Name = "button16";
            button16.Size = new Size(56, 44);
            button16.TabIndex = 18;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = true;
            button16.MouseClick += button16_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 316);
            Controls.Add(button16);
            Controls.Add(botZero);
            Controls.Add(botSeven);
            Controls.Add(botEight);
            Controls.Add(botNine);
            Controls.Add(botFour);
            Controls.Add(botFive);
            Controls.Add(botSix);
            Controls.Add(botOne);
            Controls.Add(botTwo);
            Controls.Add(botThree);
            Controls.Add(button5);
            Controls.Add(divide);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(add);
            Controls.Add(lblTest);
            Controls.Add(txtTest);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTest;
        private Button add;
        private Button minus;
        private Button multiply;
        private Button divide;
        private Button button5;
        private Label lblTest;
        private Button botThree;
        private Button botTwo;
        private Button botOne;
        private Button botSix;
        private Button botFive;
        private Button botFour;
        private Button botNine;
        private Button botEight;
        private Button botSeven;
        private Button botZero;
        private Button button16;
    }
}
