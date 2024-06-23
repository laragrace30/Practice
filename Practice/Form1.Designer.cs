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
            open = new Button();
            close = new Button();
            button1 = new Button();
            decButton = new Button();
            SuspendLayout();
            // 
            // txtTest
            // 
            txtTest.Font = new Font("Segoe UI", 20F);
            txtTest.Location = new Point(12, 12);
            txtTest.Name = "txtTest";
            txtTest.ReadOnly = true;
            txtTest.Size = new Size(210, 43);
            txtTest.TabIndex = 2;
            txtTest.TextAlign = HorizontalAlignment.Right;
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 15F);
            add.ForeColor = Color.Black;
            add.ImageAlign = ContentAlignment.TopRight;
            add.Location = new Point(198, 160);
            add.Name = "add";
            add.Size = new Size(52, 44);
            add.TabIndex = 3;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.MouseClick += add_MouseClick;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 15F);
            minus.ForeColor = Color.Black;
            minus.Location = new Point(198, 210);
            minus.Name = "minus";
            minus.Size = new Size(52, 44);
            minus.TabIndex = 4;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.MouseClick += minus_MouseClick;
            // 
            // multiply
            // 
            multiply.Font = new Font("Segoe UI", 15F);
            multiply.ForeColor = Color.Black;
            multiply.Location = new Point(254, 160);
            multiply.Name = "multiply";
            multiply.Size = new Size(52, 44);
            multiply.TabIndex = 5;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.MouseClick += multiply_MouseClick;
            // 
            // divide
            // 
            divide.Font = new Font("Segoe UI", 15F);
            divide.ForeColor = Color.Black;
            divide.Location = new Point(254, 210);
            divide.Name = "divide";
            divide.Size = new Size(52, 44);
            divide.TabIndex = 6;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.MouseClick += divide_MouseClick;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(254, 260);
            button5.Name = "button5";
            button5.Size = new Size(52, 44);
            button5.TabIndex = 7;
            button5.Text = "=";
            button5.UseVisualStyleBackColor = true;
            button5.MouseClick += button5_MouseClick;
            // 
            // lblTest
            // 
            lblTest.BorderStyle = BorderStyle.FixedSingle;
            lblTest.Location = new Point(222, 12);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(84, 43);
            lblTest.TabIndex = 0;
            lblTest.Text = "..........";
            lblTest.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botThree
            // 
            botThree.Font = new Font("Segoe UI", 15F);
            botThree.ForeColor = Color.Black;
            botThree.Location = new Point(136, 210);
            botThree.Name = "botThree";
            botThree.Size = new Size(56, 44);
            botThree.TabIndex = 8;
            botThree.Text = "3";
            botThree.UseVisualStyleBackColor = true;
            botThree.MouseClick += botThree_MouseClick;
            // 
            // botTwo
            // 
            botTwo.Font = new Font("Segoe UI", 15F);
            botTwo.ForeColor = Color.Black;
            botTwo.Location = new Point(74, 210);
            botTwo.Name = "botTwo";
            botTwo.Size = new Size(56, 44);
            botTwo.TabIndex = 9;
            botTwo.Text = "2";
            botTwo.UseVisualStyleBackColor = true;
            botTwo.MouseClick += botTwo_MouseClick;
            // 
            // botOne
            // 
            botOne.Font = new Font("Segoe UI", 15F);
            botOne.ForeColor = Color.Black;
            botOne.Location = new Point(12, 210);
            botOne.Name = "botOne";
            botOne.Size = new Size(56, 44);
            botOne.TabIndex = 10;
            botOne.Text = "1";
            botOne.UseVisualStyleBackColor = true;
            botOne.MouseClick += botOne_MouseClick;
            // 
            // botSix
            // 
            botSix.Font = new Font("Segoe UI", 15F);
            botSix.ForeColor = Color.Black;
            botSix.Location = new Point(136, 160);
            botSix.Name = "botSix";
            botSix.Size = new Size(56, 44);
            botSix.TabIndex = 11;
            botSix.Text = "6";
            botSix.UseVisualStyleBackColor = true;
            botSix.MouseClick += botSix_MouseClick;
            // 
            // botFive
            // 
            botFive.Font = new Font("Segoe UI", 15F);
            botFive.ForeColor = Color.Black;
            botFive.Location = new Point(74, 160);
            botFive.Name = "botFive";
            botFive.Size = new Size(56, 44);
            botFive.TabIndex = 12;
            botFive.Text = "5";
            botFive.UseVisualStyleBackColor = true;
            botFive.MouseClick += botFive_MouseClick;
            // 
            // botFour
            // 
            botFour.Font = new Font("Segoe UI", 15F);
            botFour.Location = new Point(12, 160);
            botFour.Name = "botFour";
            botFour.Size = new Size(56, 44);
            botFour.TabIndex = 13;
            botFour.Text = "4";
            botFour.UseVisualStyleBackColor = true;
            botFour.MouseClick += botFour_MouseClick;
            // 
            // botNine
            // 
            botNine.Font = new Font("Segoe UI", 15F);
            botNine.ForeColor = Color.Black;
            botNine.Location = new Point(136, 110);
            botNine.Name = "botNine";
            botNine.Size = new Size(56, 44);
            botNine.TabIndex = 14;
            botNine.Text = "9";
            botNine.UseVisualStyleBackColor = true;
            botNine.MouseClick += botNine_MouseClick;
            // 
            // botEight
            // 
            botEight.Font = new Font("Segoe UI", 15F);
            botEight.ForeColor = Color.Black;
            botEight.Location = new Point(74, 110);
            botEight.Name = "botEight";
            botEight.Size = new Size(56, 44);
            botEight.TabIndex = 15;
            botEight.Text = "8";
            botEight.UseVisualStyleBackColor = true;
            botEight.MouseClick += botEight_MouseClick;
            // 
            // botSeven
            // 
            botSeven.Font = new Font("Segoe UI", 15F);
            botSeven.ForeColor = Color.Black;
            botSeven.Location = new Point(12, 110);
            botSeven.Name = "botSeven";
            botSeven.Size = new Size(56, 44);
            botSeven.TabIndex = 16;
            botSeven.Text = "7";
            botSeven.UseVisualStyleBackColor = true;
            botSeven.MouseClick += botSeven_MouseClick;
            // 
            // botZero
            // 
            botZero.Font = new Font("Segoe UI", 15F);
            botZero.ForeColor = Color.Black;
            botZero.Location = new Point(74, 260);
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
            button16.Location = new Point(256, 111);
            button16.Name = "button16";
            button16.Size = new Size(52, 44);
            button16.TabIndex = 18;
            button16.Text = "C";
            button16.UseVisualStyleBackColor = true;
            button16.MouseClick += button16_MouseClick;
            // 
            // open
            // 
            open.Font = new Font("Segoe UI", 15F);
            open.ForeColor = Color.Black;
            open.Location = new Point(136, 260);
            open.Name = "open";
            open.Size = new Size(56, 44);
            open.TabIndex = 19;
            open.Text = "(";
            open.UseVisualStyleBackColor = true;
            open.MouseClick += open_MouseClick;
            // 
            // close
            // 
            close.Font = new Font("Segoe UI", 15F);
            close.ForeColor = Color.Black;
            close.Location = new Point(196, 260);
            close.Name = "close";
            close.Size = new Size(52, 44);
            close.TabIndex = 20;
            close.Text = ")";
            close.UseVisualStyleBackColor = true;
            close.MouseClick += close_MouseClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(198, 110);
            button1.Name = "button1";
            button1.Size = new Size(52, 44);
            button1.TabIndex = 21;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // decButton
            // 
            decButton.Font = new Font("Segoe UI", 15F);
            decButton.ForeColor = Color.Black;
            decButton.Location = new Point(12, 260);
            decButton.Name = "decButton";
            decButton.Size = new Size(56, 44);
            decButton.TabIndex = 22;
            decButton.Text = ".";
            decButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 316);
            Controls.Add(decButton);
            Controls.Add(button1);
            Controls.Add(close);
            Controls.Add(open);
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
        private Button open;
        private Button close;
        private Button button1;
        private Button decButton;
    }
}
