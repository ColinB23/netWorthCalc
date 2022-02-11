namespace PersonalProjectBrodnik
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
            this.myLiabilities = new System.Windows.Forms.Label();
            this.myAssets = new System.Windows.Forms.Label();
            this.myButton = new System.Windows.Forms.Button();
            this.myNetWorth = new System.Windows.Forms.Label();
            this.myAnsLblNetWorth = new System.Windows.Forms.Label();
            this.myLblLiabilities = new System.Windows.Forms.Label();
            this.myLblAssets = new System.Windows.Forms.Label();
            this.mySavings = new System.Windows.Forms.Label();
            this.myRetirement = new System.Windows.Forms.Label();
            this.myCar = new System.Windows.Forms.Label();
            this.myHome = new System.Windows.Forms.Label();
            this.myAssets2 = new System.Windows.Forms.Label();
            this.myLiab = new System.Windows.Forms.Label();
            this.myStudLoan = new System.Windows.Forms.Label();
            this.myTxtBoxSavings = new System.Windows.Forms.TextBox();
            this.myTxtBoxRetirement = new System.Windows.Forms.TextBox();
            this.myTxtBoxCar = new System.Windows.Forms.TextBox();
            this.myTxtBoxHome = new System.Windows.Forms.TextBox();
            this.myTxtBoxStudLoans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myTxtBoxMortgage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myTxtBoxCarLoans = new System.Windows.Forms.TextBox();
            this.myClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myLiabilities
            // 
            this.myLiabilities.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.myLiabilities.Location = new System.Drawing.Point(619, 560);
            this.myLiabilities.Name = "myLiabilities";
            this.myLiabilities.Size = new System.Drawing.Size(160, 29);
            this.myLiabilities.TabIndex = 0;
            this.myLiabilities.Text = "Total Liabilities";
            // 
            // myAssets
            // 
            this.myAssets.Location = new System.Drawing.Point(785, 558);
            this.myAssets.Name = "myAssets";
            this.myAssets.Size = new System.Drawing.Size(142, 31);
            this.myAssets.TabIndex = 2;
            this.myAssets.Text = "Total Assets";
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(349, 593);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(241, 67);
            this.myButton.TabIndex = 4;
            this.myButton.Text = "Calculate Net Worth";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // myNetWorth
            // 
            this.myNetWorth.Location = new System.Drawing.Point(619, 647);
            this.myNetWorth.Name = "myNetWorth";
            this.myNetWorth.Size = new System.Drawing.Size(115, 31);
            this.myNetWorth.TabIndex = 5;
            this.myNetWorth.Text = "Net Worth";
            // 
            // myAnsLblNetWorth
            // 
            this.myAnsLblNetWorth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myAnsLblNetWorth.Location = new System.Drawing.Point(624, 605);
            this.myAnsLblNetWorth.Name = "myAnsLblNetWorth";
            this.myAnsLblNetWorth.Size = new System.Drawing.Size(209, 42);
            this.myAnsLblNetWorth.TabIndex = 6;
            this.myAnsLblNetWorth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myLblLiabilities
            // 
            this.myLblLiabilities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLblLiabilities.Location = new System.Drawing.Point(624, 528);
            this.myLblLiabilities.Name = "myLblLiabilities";
            this.myLblLiabilities.Size = new System.Drawing.Size(140, 32);
            this.myLblLiabilities.TabIndex = 7;
            // 
            // myLblAssets
            // 
            this.myLblAssets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLblAssets.Location = new System.Drawing.Point(790, 526);
            this.myLblAssets.Name = "myLblAssets";
            this.myLblAssets.Size = new System.Drawing.Size(124, 32);
            this.myLblAssets.TabIndex = 8;
            // 
            // mySavings
            // 
            this.mySavings.AutoSize = true;
            this.mySavings.Location = new System.Drawing.Point(23, 85);
            this.mySavings.Name = "mySavings";
            this.mySavings.Size = new System.Drawing.Size(175, 26);
            this.mySavings.TabIndex = 9;
            this.mySavings.Text = "Savings Account";
            // 
            // myRetirement
            // 
            this.myRetirement.AutoSize = true;
            this.myRetirement.Location = new System.Drawing.Point(23, 165);
            this.myRetirement.Name = "myRetirement";
            this.myRetirement.Size = new System.Drawing.Size(204, 26);
            this.myRetirement.TabIndex = 10;
            this.myRetirement.Text = "Retirement Account";
            // 
            // myCar
            // 
            this.myCar.AutoSize = true;
            this.myCar.Location = new System.Drawing.Point(23, 245);
            this.myCar.Name = "myCar";
            this.myCar.Size = new System.Drawing.Size(109, 26);
            this.myCar.TabIndex = 11;
            this.myCar.Text = "Car Value";
            // 
            // myHome
            // 
            this.myHome.AutoSize = true;
            this.myHome.Location = new System.Drawing.Point(23, 321);
            this.myHome.Name = "myHome";
            this.myHome.Size = new System.Drawing.Size(133, 26);
            this.myHome.TabIndex = 12;
            this.myHome.Text = "Home Value";
            // 
            // myAssets2
            // 
            this.myAssets2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myAssets2.Location = new System.Drawing.Point(59, 9);
            this.myAssets2.Name = "myAssets2";
            this.myAssets2.Size = new System.Drawing.Size(84, 30);
            this.myAssets2.TabIndex = 13;
            this.myAssets2.Text = "Assets";
            // 
            // myLiab
            // 
            this.myLiab.AutoSize = true;
            this.myLiab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLiab.Location = new System.Drawing.Point(333, 9);
            this.myLiab.Name = "myLiab";
            this.myLiab.Size = new System.Drawing.Size(104, 28);
            this.myLiab.TabIndex = 14;
            this.myLiab.Text = "Liabilities";
            // 
            // myStudLoan
            // 
            this.myStudLoan.AutoSize = true;
            this.myStudLoan.Location = new System.Drawing.Point(333, 84);
            this.myStudLoan.Name = "myStudLoan";
            this.myStudLoan.Size = new System.Drawing.Size(163, 26);
            this.myStudLoan.TabIndex = 15;
            this.myStudLoan.Text = "Students Loans";
            // 
            // myTxtBoxSavings
            // 
            this.myTxtBoxSavings.Location = new System.Drawing.Point(28, 51);
            this.myTxtBoxSavings.Name = "myTxtBoxSavings";
            this.myTxtBoxSavings.Size = new System.Drawing.Size(170, 31);
            this.myTxtBoxSavings.TabIndex = 16;
            // 
            // myTxtBoxRetirement
            // 
            this.myTxtBoxRetirement.Location = new System.Drawing.Point(28, 131);
            this.myTxtBoxRetirement.Name = "myTxtBoxRetirement";
            this.myTxtBoxRetirement.Size = new System.Drawing.Size(170, 31);
            this.myTxtBoxRetirement.TabIndex = 17;
            // 
            // myTxtBoxCar
            // 
            this.myTxtBoxCar.Location = new System.Drawing.Point(28, 211);
            this.myTxtBoxCar.Name = "myTxtBoxCar";
            this.myTxtBoxCar.Size = new System.Drawing.Size(170, 31);
            this.myTxtBoxCar.TabIndex = 18;
            // 
            // myTxtBoxHome
            // 
            this.myTxtBoxHome.Location = new System.Drawing.Point(28, 287);
            this.myTxtBoxHome.Name = "myTxtBoxHome";
            this.myTxtBoxHome.Size = new System.Drawing.Size(170, 31);
            this.myTxtBoxHome.TabIndex = 19;
            // 
            // myTxtBoxStudLoans
            // 
            this.myTxtBoxStudLoans.Location = new System.Drawing.Point(338, 50);
            this.myTxtBoxStudLoans.Name = "myTxtBoxStudLoans";
            this.myTxtBoxStudLoans.Size = new System.Drawing.Size(158, 31);
            this.myTxtBoxStudLoans.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mortgage";
            // 
            // myTxtBoxMortgage
            // 
            this.myTxtBoxMortgage.Location = new System.Drawing.Point(333, 130);
            this.myTxtBoxMortgage.Name = "myTxtBoxMortgage";
            this.myTxtBoxMortgage.Size = new System.Drawing.Size(163, 31);
            this.myTxtBoxMortgage.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 23;
            this.label2.Text = "Car Loans";
            // 
            // myTxtBoxCarLoans
            // 
            this.myTxtBoxCarLoans.Location = new System.Drawing.Point(333, 210);
            this.myTxtBoxCarLoans.Name = "myTxtBoxCarLoans";
            this.myTxtBoxCarLoans.Size = new System.Drawing.Size(163, 31);
            this.myTxtBoxCarLoans.TabIndex = 24;
            // 
            // myClearButton
            // 
            this.myClearButton.Location = new System.Drawing.Point(59, 593);
            this.myClearButton.Name = "myClearButton";
            this.myClearButton.Size = new System.Drawing.Size(203, 67);
            this.myClearButton.TabIndex = 25;
            this.myClearButton.Text = "Clear";
            this.myClearButton.UseVisualStyleBackColor = true;
            this.myClearButton.Click += new System.EventHandler(this.myClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 705);
            this.Controls.Add(this.myClearButton);
            this.Controls.Add(this.myTxtBoxCarLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myTxtBoxMortgage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTxtBoxStudLoans);
            this.Controls.Add(this.myTxtBoxHome);
            this.Controls.Add(this.myTxtBoxCar);
            this.Controls.Add(this.myTxtBoxRetirement);
            this.Controls.Add(this.myTxtBoxSavings);
            this.Controls.Add(this.myStudLoan);
            this.Controls.Add(this.myLiab);
            this.Controls.Add(this.myAssets2);
            this.Controls.Add(this.myHome);
            this.Controls.Add(this.myCar);
            this.Controls.Add(this.myRetirement);
            this.Controls.Add(this.mySavings);
            this.Controls.Add(this.myLblAssets);
            this.Controls.Add(this.myLblLiabilities);
            this.Controls.Add(this.myAnsLblNetWorth);
            this.Controls.Add(this.myNetWorth);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myAssets);
            this.Controls.Add(this.myLiabilities);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myLiabilities;
        private System.Windows.Forms.Label myAssets;
        private System.Windows.Forms.Button myButton;
        private System.Windows.Forms.Label myNetWorth;
        private System.Windows.Forms.Label myAnsLblNetWorth;
        private System.Windows.Forms.Label myLblLiabilities;
        private System.Windows.Forms.Label myLblAssets;
        private System.Windows.Forms.Label mySavings;
        private System.Windows.Forms.Label myRetirement;
        private System.Windows.Forms.Label myCar;
        private System.Windows.Forms.Label myHome;
        private System.Windows.Forms.Label myAssets2;
        private System.Windows.Forms.Label myLiab;
        private System.Windows.Forms.Label myStudLoan;
        private System.Windows.Forms.TextBox myTxtBoxSavings;
        private System.Windows.Forms.TextBox myTxtBoxRetirement;
        private System.Windows.Forms.TextBox myTxtBoxCar;
        private System.Windows.Forms.TextBox myTxtBoxHome;
        private System.Windows.Forms.TextBox myTxtBoxStudLoans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myTxtBoxMortgage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myTxtBoxCarLoans;
        private System.Windows.Forms.Button myClearButton;
    }
}

