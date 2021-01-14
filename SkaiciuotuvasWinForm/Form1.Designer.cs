
namespace SkaiciuotuvasWinForm
{
    partial class Calculator
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
            this.ScreenTop = new System.Windows.Forms.TextBox();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.ScreenBottom = new System.Windows.Forms.TextBox();
            this.Erase = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonComma = new System.Windows.Forms.Button();
            this.ButtonEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScreenTop
            // 
            this.ScreenTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ScreenTop.Location = new System.Drawing.Point(12, 12);
            this.ScreenTop.Name = "ScreenTop";
            this.ScreenTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScreenTop.Size = new System.Drawing.Size(350, 30);
            this.ScreenTop.TabIndex = 0;
            this.ScreenTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScreenTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonEquals_KeyPress);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CE.Location = new System.Drawing.Point(12, 126);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(70, 70);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.BackColor = System.Drawing.SystemColors.ControlDark;
            this.C.Location = new System.Drawing.Point(105, 126);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(70, 69);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // ScreenBottom
            // 
            this.ScreenBottom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ScreenBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ScreenBottom.Location = new System.Drawing.Point(12, 52);
            this.ScreenBottom.Name = "ScreenBottom";
            this.ScreenBottom.ReadOnly = true;
            this.ScreenBottom.Size = new System.Drawing.Size(350, 38);
            this.ScreenBottom.TabIndex = 3;
            this.ScreenBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScreenBottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonEquals_KeyPress);
            // 
            // Erase
            // 
            this.Erase.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Erase.Location = new System.Drawing.Point(197, 126);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(68, 70);
            this.Erase.TabIndex = 4;
            this.Erase.Text = "Erase";
            this.Erase.UseVisualStyleBackColor = false;
            this.Erase.Click += new System.EventHandler(this.Erase_Click);
            // 
            // Div
            // 
            this.Div.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Div.Location = new System.Drawing.Point(289, 126);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(68, 70);
            this.Div.TabIndex = 5;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = false;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(12, 224);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(70, 70);
            this.Button7.TabIndex = 6;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(105, 224);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(70, 70);
            this.Button8.TabIndex = 7;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(197, 224);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(70, 70);
            this.Button9.TabIndex = 8;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Mult
            // 
            this.Mult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Mult.Location = new System.Drawing.Point(287, 224);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(70, 70);
            this.Mult.TabIndex = 9;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = false;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 313);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(70, 70);
            this.Button4.TabIndex = 10;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(105, 313);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(70, 70);
            this.Button5.TabIndex = 11;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(195, 313);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(70, 70);
            this.Button6.TabIndex = 12;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Add.Location = new System.Drawing.Point(287, 412);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 70);
            this.Add.TabIndex = 13;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 412);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(70, 70);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(105, 412);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(70, 70);
            this.Button2.TabIndex = 15;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(195, 412);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(70, 70);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Sub
            // 
            this.Sub.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Sub.Location = new System.Drawing.Point(287, 313);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(70, 70);
            this.Sub.TabIndex = 17;
            this.Sub.Text = "-";
            this.Sub.UseVisualStyleBackColor = false;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonPlusMinus.Location = new System.Drawing.Point(12, 504);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(70, 70);
            this.ButtonPlusMinus.TabIndex = 18;
            this.ButtonPlusMinus.Text = "+/-";
            this.ButtonPlusMinus.UseVisualStyleBackColor = false;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.ButtonPlusMinus_Click);
            // 
            // Button0
            // 
            this.Button0.Location = new System.Drawing.Point(105, 504);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(70, 70);
            this.Button0.TabIndex = 19;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonComma
            // 
            this.ButtonComma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonComma.Location = new System.Drawing.Point(197, 504);
            this.ButtonComma.Name = "ButtonComma";
            this.ButtonComma.Size = new System.Drawing.Size(70, 70);
            this.ButtonComma.TabIndex = 20;
            this.ButtonComma.Text = ",";
            this.ButtonComma.UseVisualStyleBackColor = false;
            this.ButtonComma.Click += new System.EventHandler(this.ButtonComma_Click);
            // 
            // ButtonEquals
            // 
            this.ButtonEquals.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonEquals.Location = new System.Drawing.Point(287, 504);
            this.ButtonEquals.Name = "ButtonEquals";
            this.ButtonEquals.Size = new System.Drawing.Size(70, 70);
            this.ButtonEquals.TabIndex = 21;
            this.ButtonEquals.Text = "=";
            this.ButtonEquals.UseVisualStyleBackColor = false;
            this.ButtonEquals.Click += new System.EventHandler(this.ButtonEquals_Click);
            this.ButtonEquals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButtonEquals_KeyPress);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 593);
            this.Controls.Add(this.ButtonEquals);
            this.Controls.Add(this.ButtonComma);
            this.Controls.Add(this.Button0);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.ScreenBottom);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.ScreenTop);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScreenTop;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.TextBox ScreenBottom;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button ButtonPlusMinus;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonComma;
        private System.Windows.Forms.Button ButtonEquals;
    }
}

