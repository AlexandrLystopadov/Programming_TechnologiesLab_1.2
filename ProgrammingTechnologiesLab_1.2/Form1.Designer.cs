namespace ProgrammingTechnologiesLab_1._2
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
            this.swapSign = new System.Windows.Forms.Button();
            this.labelRange = new System.Windows.Forms.Label();
            this.minTable = new System.Windows.Forms.TextBox();
            this.maxTable = new System.Windows.Forms.TextBox();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.outLineUper = new System.Windows.Forms.TextBox();
            this.outLine = new System.Windows.Forms.TextBox();
            this.numeralZero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numeralOne = new System.Windows.Forms.Button();
            this.numeralTwo = new System.Windows.Forms.Button();
            this.numeralThree = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.numeralFour = new System.Windows.Forms.Button();
            this.numeralFive = new System.Windows.Forms.Button();
            this.numeralSix = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.numeralSeven = new System.Windows.Forms.Button();
            this.numeralEight = new System.Windows.Forms.Button();
            this.numeralNine = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.sinus = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.backSpase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // swapSign
            // 
            this.swapSign.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.swapSign.Location = new System.Drawing.Point(12, 481);
            this.swapSign.Name = "swapSign";
            this.swapSign.Size = new System.Drawing.Size(100, 60);
            this.swapSign.TabIndex = 7;
            this.swapSign.Text = "+/-";
            this.swapSign.UseVisualStyleBackColor = true;
            this.swapSign.Click += new System.EventHandler(this.swapSign_Click);
            // 
            // labelRange
            // 
            this.labelRange.BackColor = System.Drawing.SystemColors.Control;
            this.labelRange.Location = new System.Drawing.Point(12, 9);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(100, 33);
            this.labelRange.TabIndex = 1;
            this.labelRange.Text = "Range numbers";
            this.labelRange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minTable
            // 
            this.minTable.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minTable.Location = new System.Drawing.Point(12, 63);
            this.minTable.Name = "minTable";
            this.minTable.Size = new System.Drawing.Size(100, 28);
            this.minTable.TabIndex = 2;
            this.minTable.Text = "-2000000";
            this.minTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minTable.TextChanged += new System.EventHandler(this.minTable_TextChanged);
            // 
            // maxTable
            // 
            this.maxTable.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTable.Location = new System.Drawing.Point(12, 116);
            this.maxTable.Name = "maxTable";
            this.maxTable.Size = new System.Drawing.Size(100, 28);
            this.maxTable.TabIndex = 3;
            this.maxTable.Text = "4000000";
            this.maxTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxTable.TextChanged += new System.EventHandler(this.maxTable_TextChanged);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(48, 44);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(28, 16);
            this.labelMin.TabIndex = 4;
            this.labelMin.Text = "min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(48, 97);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(32, 16);
            this.labelMax.TabIndex = 5;
            this.labelMax.Text = "max";
            // 
            // outLineUper
            // 
            this.outLineUper.BackColor = System.Drawing.SystemColors.Control;
            this.outLineUper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outLineUper.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outLineUper.Enabled = false;
            this.outLineUper.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outLineUper.Location = new System.Drawing.Point(117, 12);
            this.outLineUper.Multiline = true;
            this.outLineUper.Name = "outLineUper";
            this.outLineUper.Size = new System.Drawing.Size(312, 60);
            this.outLineUper.TabIndex = 6;
            this.outLineUper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outLine
            // 
            this.outLine.BackColor = System.Drawing.SystemColors.Control;
            this.outLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.outLine.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outLine.Location = new System.Drawing.Point(117, 78);
            this.outLine.Multiline = true;
            this.outLine.Name = "outLine";
            this.outLine.Size = new System.Drawing.Size(312, 60);
            this.outLine.TabIndex = 0;
            this.outLine.Text = "0";
            this.outLine.TextChanged += new System.EventHandler(this.outLine_TextChanged);
            // 
            // numeralZero
            // 
            this.numeralZero.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralZero.Location = new System.Drawing.Point(117, 481);
            this.numeralZero.Name = "numeralZero";
            this.numeralZero.Size = new System.Drawing.Size(100, 60);
            this.numeralZero.TabIndex = 8;
            this.numeralZero.Text = "0";
            this.numeralZero.UseVisualStyleBackColor = true;
            this.numeralZero.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.Location = new System.Drawing.Point(224, 481);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(100, 60);
            this.dot.TabIndex = 9;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(331, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 60);
            this.button4.TabIndex = 10;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numeralOne
            // 
            this.numeralOne.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralOne.Location = new System.Drawing.Point(12, 415);
            this.numeralOne.Name = "numeralOne";
            this.numeralOne.Size = new System.Drawing.Size(100, 60);
            this.numeralOne.TabIndex = 11;
            this.numeralOne.Text = "1";
            this.numeralOne.UseVisualStyleBackColor = true;
            this.numeralOne.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralTwo
            // 
            this.numeralTwo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralTwo.Location = new System.Drawing.Point(117, 415);
            this.numeralTwo.Name = "numeralTwo";
            this.numeralTwo.Size = new System.Drawing.Size(100, 60);
            this.numeralTwo.TabIndex = 12;
            this.numeralTwo.Text = "2";
            this.numeralTwo.UseVisualStyleBackColor = true;
            this.numeralTwo.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralThree
            // 
            this.numeralThree.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralThree.Location = new System.Drawing.Point(224, 415);
            this.numeralThree.Name = "numeralThree";
            this.numeralThree.Size = new System.Drawing.Size(100, 60);
            this.numeralThree.TabIndex = 13;
            this.numeralThree.Text = "3";
            this.numeralThree.UseVisualStyleBackColor = true;
            this.numeralThree.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(331, 415);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(100, 60);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // numeralFour
            // 
            this.numeralFour.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralFour.Location = new System.Drawing.Point(12, 349);
            this.numeralFour.Name = "numeralFour";
            this.numeralFour.Size = new System.Drawing.Size(100, 60);
            this.numeralFour.TabIndex = 15;
            this.numeralFour.Text = "4";
            this.numeralFour.UseVisualStyleBackColor = true;
            this.numeralFour.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralFive
            // 
            this.numeralFive.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralFive.Location = new System.Drawing.Point(117, 349);
            this.numeralFive.Name = "numeralFive";
            this.numeralFive.Size = new System.Drawing.Size(100, 60);
            this.numeralFive.TabIndex = 16;
            this.numeralFive.Text = "5";
            this.numeralFive.UseVisualStyleBackColor = true;
            this.numeralFive.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralSix
            // 
            this.numeralSix.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralSix.Location = new System.Drawing.Point(224, 349);
            this.numeralSix.Name = "numeralSix";
            this.numeralSix.Size = new System.Drawing.Size(100, 60);
            this.numeralSix.TabIndex = 17;
            this.numeralSix.Text = "6";
            this.numeralSix.UseVisualStyleBackColor = true;
            this.numeralSix.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(331, 349);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(100, 60);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // numeralSeven
            // 
            this.numeralSeven.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralSeven.Location = new System.Drawing.Point(12, 283);
            this.numeralSeven.Name = "numeralSeven";
            this.numeralSeven.Size = new System.Drawing.Size(100, 60);
            this.numeralSeven.TabIndex = 19;
            this.numeralSeven.Text = "7";
            this.numeralSeven.UseVisualStyleBackColor = true;
            this.numeralSeven.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralEight
            // 
            this.numeralEight.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralEight.Location = new System.Drawing.Point(117, 283);
            this.numeralEight.Name = "numeralEight";
            this.numeralEight.Size = new System.Drawing.Size(100, 60);
            this.numeralEight.TabIndex = 20;
            this.numeralEight.Text = "8";
            this.numeralEight.UseVisualStyleBackColor = true;
            this.numeralEight.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // numeralNine
            // 
            this.numeralNine.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeralNine.Location = new System.Drawing.Point(224, 283);
            this.numeralNine.Name = "numeralNine";
            this.numeralNine.Size = new System.Drawing.Size(100, 60);
            this.numeralNine.TabIndex = 21;
            this.numeralNine.Text = "9";
            this.numeralNine.UseVisualStyleBackColor = true;
            this.numeralNine.Click += new System.EventHandler(this.numeralZero_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(331, 283);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(100, 60);
            this.multiplication.TabIndex = 22;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareRoot.Location = new System.Drawing.Point(12, 217);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(100, 60);
            this.squareRoot.TabIndex = 23;
            this.squareRoot.Text = "sqrt(x)";
            this.squareRoot.UseVisualStyleBackColor = true;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // sinus
            // 
            this.sinus.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sinus.Location = new System.Drawing.Point(117, 217);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(100, 60);
            this.sinus.TabIndex = 24;
            this.sinus.Text = "sin(x)";
            this.sinus.UseVisualStyleBackColor = true;
            this.sinus.Click += new System.EventHandler(this.sinus_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorial.Location = new System.Drawing.Point(224, 217);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(100, 60);
            this.factorial.TabIndex = 25;
            this.factorial.Text = "x!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(331, 217);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(100, 60);
            this.division.TabIndex = 26;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // clearText
            // 
            this.clearText.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearText.Location = new System.Drawing.Point(12, 151);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(205, 60);
            this.clearText.TabIndex = 27;
            this.clearText.Text = "AC";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.button21_Click);
            // 
            // backSpase
            // 
            this.backSpase.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backSpase.Location = new System.Drawing.Point(224, 151);
            this.backSpase.Name = "backSpase";
            this.backSpase.Size = new System.Drawing.Size(205, 60);
            this.backSpase.TabIndex = 28;
            this.backSpase.Text = "<-";
            this.backSpase.UseVisualStyleBackColor = true;
            this.backSpase.Click += new System.EventHandler(this.backSpase_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 553);
            this.Controls.Add(this.backSpase);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.division);
            this.Controls.Add(this.factorial);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.numeralNine);
            this.Controls.Add(this.numeralEight);
            this.Controls.Add(this.numeralSeven);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.numeralSix);
            this.Controls.Add(this.numeralFive);
            this.Controls.Add(this.numeralFour);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.numeralThree);
            this.Controls.Add(this.numeralTwo);
            this.Controls.Add(this.numeralOne);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.numeralZero);
            this.Controls.Add(this.outLine);
            this.Controls.Add(this.outLineUper);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.maxTable);
            this.Controls.Add(this.minTable);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.swapSign);
            this.Name = "Form1";
            this.Text = "My calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button swapSign;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.TextBox minTable;
        private System.Windows.Forms.TextBox maxTable;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.TextBox outLineUper;
        private System.Windows.Forms.TextBox outLine;
        private System.Windows.Forms.Button numeralZero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button numeralOne;
        private System.Windows.Forms.Button numeralTwo;
        private System.Windows.Forms.Button numeralThree;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button numeralFour;
        private System.Windows.Forms.Button numeralFive;
        private System.Windows.Forms.Button numeralSix;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button numeralSeven;
        private System.Windows.Forms.Button numeralEight;
        private System.Windows.Forms.Button numeralNine;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button sinus;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button backSpase;
    }
}

