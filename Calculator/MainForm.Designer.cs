namespace Calculator
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonEqually = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonOpBracket = new System.Windows.Forms.Button();
            this.buttonClBracket = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEntry.Location = new System.Drawing.Point(12, 105);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.ReadOnly = true;
            this.textBoxEntry.Size = new System.Drawing.Size(280, 29);
            this.textBoxEntry.TabIndex = 0;
            this.textBoxEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(32, 351);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(45, 30);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.TabStop = false;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(83, 351);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(45, 30);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.TabStop = false;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.Location = new System.Drawing.Point(134, 351);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(45, 30);
            this.buttonThree.TabIndex = 3;
            this.buttonThree.TabStop = false;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.Location = new System.Drawing.Point(134, 315);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(45, 30);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.TabStop = false;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.Location = new System.Drawing.Point(83, 315);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(45, 30);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.TabStop = false;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.Location = new System.Drawing.Point(32, 315);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(45, 30);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.TabStop = false;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.Location = new System.Drawing.Point(134, 279);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(45, 30);
            this.buttonNine.TabIndex = 9;
            this.buttonNine.TabStop = false;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.Location = new System.Drawing.Point(83, 279);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(45, 30);
            this.buttonEight.TabIndex = 8;
            this.buttonEight.TabStop = false;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.Location = new System.Drawing.Point(32, 279);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(45, 30);
            this.buttonSeven.TabIndex = 7;
            this.buttonSeven.TabStop = false;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.Location = new System.Drawing.Point(83, 387);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(45, 30);
            this.buttonZero.TabIndex = 10;
            this.buttonZero.TabStop = false;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(134, 234);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(45, 30);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "CE";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.Location = new System.Drawing.Point(185, 234);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(45, 30);
            this.buttonBackspace.TabIndex = 12;
            this.buttonBackspace.TabStop = false;
            this.buttonBackspace.Text = "<";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(185, 388);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(45, 30);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 140);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(280, 29);
            this.textBoxResult.TabIndex = 15;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonEqually
            // 
            this.buttonEqually.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqually.Location = new System.Drawing.Point(134, 387);
            this.buttonEqually.Name = "buttonEqually";
            this.buttonEqually.Size = new System.Drawing.Size(45, 30);
            this.buttonEqually.TabIndex = 16;
            this.buttonEqually.TabStop = false;
            this.buttonEqually.Text = "=";
            this.buttonEqually.UseVisualStyleBackColor = true;
            this.buttonEqually.Click += new System.EventHandler(this.buttonEqually_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiplication.Location = new System.Drawing.Point(185, 315);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(45, 30);
            this.buttonMultiplication.TabIndex = 17;
            this.buttonMultiplication.TabStop = false;
            this.buttonMultiplication.Text = "×";
            this.buttonMultiplication.UseVisualStyleBackColor = true;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.Location = new System.Drawing.Point(185, 279);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(45, 30);
            this.buttonDivide.TabIndex = 18;
            this.buttonDivide.TabStop = false;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(185, 351);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(45, 30);
            this.buttonMinus.TabIndex = 19;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonOpBracket
            // 
            this.buttonOpBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpBracket.Location = new System.Drawing.Point(83, 235);
            this.buttonOpBracket.Name = "buttonOpBracket";
            this.buttonOpBracket.Size = new System.Drawing.Size(22, 30);
            this.buttonOpBracket.TabIndex = 20;
            this.buttonOpBracket.TabStop = false;
            this.buttonOpBracket.Text = "(";
            this.buttonOpBracket.UseVisualStyleBackColor = true;
            this.buttonOpBracket.Click += new System.EventHandler(this.buttonOpBracket_Click);
            // 
            // buttonClBracket
            // 
            this.buttonClBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClBracket.Location = new System.Drawing.Point(106, 235);
            this.buttonClBracket.Name = "buttonClBracket";
            this.buttonClBracket.Size = new System.Drawing.Size(22, 30);
            this.buttonClBracket.TabIndex = 21;
            this.buttonClBracket.TabStop = false;
            this.buttonClBracket.Text = ")";
            this.buttonClBracket.UseVisualStyleBackColor = true;
            this.buttonClBracket.Click += new System.EventHandler(this.buttonClBracket_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComma.Location = new System.Drawing.Point(32, 388);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(45, 30);
            this.buttonComma.TabIndex = 22;
            this.buttonComma.TabStop = false;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.buttonComma_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(32, 234);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(22, 30);
            this.buttonMoveLeft.TabIndex = 23;
            this.buttonMoveLeft.TabStop = false;
            this.buttonMoveLeft.Text = "<";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(55, 234);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(22, 30);
            this.buttonMoveRight.TabIndex = 24;
            this.buttonMoveRight.TabStop = false;
            this.buttonMoveRight.Text = ">";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonClBracket);
            this.Controls.Add(this.buttonOpBracket);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonEqually);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonZero);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.textBoxEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonEqually;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonOpBracket;
        private System.Windows.Forms.Button buttonClBracket;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveRight;
    }
}

