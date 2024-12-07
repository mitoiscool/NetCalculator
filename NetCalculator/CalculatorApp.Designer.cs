namespace NetCalculator
{
    partial class CalculatorApp
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
            this.evalBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.mulBtn = new System.Windows.Forms.Button();
            this.divBtn = new System.Windows.Forms.Button();
            this.evalBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.lnBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.pwrBtn = new System.Windows.Forms.Button();
            this.decBtn = new System.Windows.Forms.Button();
            this.rtBtn = new System.Windows.Forms.Button();
            this.ePwrXBtn = new System.Windows.Forms.Button();
            this.lftParBtn = new System.Windows.Forms.Button();
            this.rgtParBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // evalBox
            // 
            this.evalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.evalBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.evalBox.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.evalBox.Location = new System.Drawing.Point(7, 3);
            this.evalBox.Name = "evalBox";
            this.evalBox.ReadOnly = true;
            this.evalBox.Size = new System.Drawing.Size(798, 132);
            this.evalBox.TabIndex = 0;
            this.evalBox.TabStop = false;
            this.evalBox.Text = "0.0";
            this.evalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.evalBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 126);
            this.panel1.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.addBtn.Location = new System.Drawing.Point(543, 266);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(128, 128);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.subBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.subBtn.Location = new System.Drawing.Point(543, 400);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(128, 128);
            this.subBtn.TabIndex = 6;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = false;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // mulBtn
            // 
            this.mulBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.mulBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.mulBtn.Location = new System.Drawing.Point(677, 266);
            this.mulBtn.Name = "mulBtn";
            this.mulBtn.Size = new System.Drawing.Size(128, 128);
            this.mulBtn.TabIndex = 7;
            this.mulBtn.Text = "x";
            this.mulBtn.UseVisualStyleBackColor = false;
            this.mulBtn.Click += new System.EventHandler(this.mulBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.divBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.divBtn.Location = new System.Drawing.Point(677, 400);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(128, 128);
            this.divBtn.TabIndex = 8;
            this.divBtn.Text = "÷";
            this.divBtn.UseVisualStyleBackColor = false;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // evalBtn
            // 
            this.evalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.evalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evalBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
            this.evalBtn.Location = new System.Drawing.Point(677, 534);
            this.evalBtn.Name = "evalBtn";
            this.evalBtn.Size = new System.Drawing.Size(128, 129);
            this.evalBtn.TabIndex = 9;
            this.evalBtn.Text = "=";
            this.evalBtn.UseVisualStyleBackColor = false;
            this.evalBtn.Click += new System.EventHandler(this.evalBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Courier New", 27.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
            this.clearBtn.Location = new System.Drawing.Point(677, 132);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(128, 128);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.oneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.oneBtn.Location = new System.Drawing.Point(141, 132);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(128, 128);
            this.oneBtn.TabIndex = 17;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.twoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.twoBtn.Location = new System.Drawing.Point(275, 132);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(128, 128);
            this.twoBtn.TabIndex = 18;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.threeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.threeBtn.Location = new System.Drawing.Point(409, 132);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(128, 128);
            this.threeBtn.TabIndex = 19;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.sixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.sixBtn.Location = new System.Drawing.Point(409, 266);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(128, 128);
            this.sixBtn.TabIndex = 20;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.nineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.nineBtn.Location = new System.Drawing.Point(409, 400);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(128, 128);
            this.nineBtn.TabIndex = 21;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.fiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.fiveBtn.Location = new System.Drawing.Point(275, 266);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(128, 128);
            this.fiveBtn.TabIndex = 23;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.eightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.eightBtn.Location = new System.Drawing.Point(275, 400);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(128, 128);
            this.eightBtn.TabIndex = 24;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.zeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.zeroBtn.Location = new System.Drawing.Point(275, 535);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(128, 128);
            this.zeroBtn.TabIndex = 25;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.fourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.fourBtn.Location = new System.Drawing.Point(141, 266);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(128, 128);
            this.fourBtn.TabIndex = 26;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.sevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.sevenBtn.Location = new System.Drawing.Point(141, 400);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(128, 128);
            this.sevenBtn.TabIndex = 27;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // lnBtn
            // 
            this.lnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnBtn.Font = new System.Drawing.Font("Courier New", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.lnBtn.Location = new System.Drawing.Point(7, 132);
            this.lnBtn.Name = "lnBtn";
            this.lnBtn.Size = new System.Drawing.Size(128, 128);
            this.lnBtn.TabIndex = 28;
            this.lnBtn.Text = "ln";
            this.lnBtn.UseVisualStyleBackColor = false;
            this.lnBtn.Click += new System.EventHandler(this.lnBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logBtn.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.logBtn.Location = new System.Drawing.Point(7, 266);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(128, 128);
            this.logBtn.TabIndex = 29;
            this.logBtn.Text = "log";
            this.logBtn.UseVisualStyleBackColor = false;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // pwrBtn
            // 
            this.pwrBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pwrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwrBtn.Font = new System.Drawing.Font("Courier New", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwrBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.pwrBtn.Location = new System.Drawing.Point(543, 132);
            this.pwrBtn.Name = "pwrBtn";
            this.pwrBtn.Size = new System.Drawing.Size(128, 128);
            this.pwrBtn.TabIndex = 30;
            this.pwrBtn.Text = "^";
            this.pwrBtn.UseVisualStyleBackColor = false;
            this.pwrBtn.Click += new System.EventHandler(this.pwrBtn_Click);
            // 
            // decBtn
            // 
            this.decBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.decBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decBtn.Font = new System.Drawing.Font("Courier New", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.decBtn.Location = new System.Drawing.Point(141, 534);
            this.decBtn.Name = "decBtn";
            this.decBtn.Size = new System.Drawing.Size(128, 129);
            this.decBtn.TabIndex = 31;
            this.decBtn.Text = ".";
            this.decBtn.UseVisualStyleBackColor = false;
            this.decBtn.Click += new System.EventHandler(this.decBtn_Click);
            // 
            // rtBtn
            // 
            this.rtBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rtBtn.Font = new System.Drawing.Font("Courier New", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.rtBtn.Location = new System.Drawing.Point(7, 535);
            this.rtBtn.Name = "rtBtn";
            this.rtBtn.Size = new System.Drawing.Size(128, 128);
            this.rtBtn.TabIndex = 32;
            this.rtBtn.Text = "n√";
            this.rtBtn.UseVisualStyleBackColor = false;
            this.rtBtn.Click += new System.EventHandler(this.rtBtn_Click);
            // 
            // ePwrXBtn
            // 
            this.ePwrXBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ePwrXBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ePwrXBtn.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePwrXBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ePwrXBtn.Location = new System.Drawing.Point(7, 400);
            this.ePwrXBtn.Name = "ePwrXBtn";
            this.ePwrXBtn.Size = new System.Drawing.Size(128, 128);
            this.ePwrXBtn.TabIndex = 33;
            this.ePwrXBtn.Text = "e^x";
            this.ePwrXBtn.UseVisualStyleBackColor = false;
            this.ePwrXBtn.Click += new System.EventHandler(this.ePwrXBtn_Click);
            // 
            // lftParBtn
            // 
            this.lftParBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lftParBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lftParBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lftParBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.lftParBtn.Location = new System.Drawing.Point(409, 535);
            this.lftParBtn.Name = "lftParBtn";
            this.lftParBtn.Size = new System.Drawing.Size(128, 128);
            this.lftParBtn.TabIndex = 34;
            this.lftParBtn.Text = "(";
            this.lftParBtn.UseVisualStyleBackColor = false;
            this.lftParBtn.Click += new System.EventHandler(this.lftParBtn_Click);
            // 
            // rgtParBtn
            // 
            this.rgtParBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.rgtParBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rgtParBtn.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgtParBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.rgtParBtn.Location = new System.Drawing.Point(543, 534);
            this.rgtParBtn.Name = "rgtParBtn";
            this.rgtParBtn.Size = new System.Drawing.Size(128, 129);
            this.rgtParBtn.TabIndex = 35;
            this.rgtParBtn.Text = ")";
            this.rgtParBtn.UseVisualStyleBackColor = false;
            this.rgtParBtn.Click += new System.EventHandler(this.rgtParBtn_Click);
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(814, 671);
            this.Controls.Add(this.rgtParBtn);
            this.Controls.Add(this.lftParBtn);
            this.Controls.Add(this.ePwrXBtn);
            this.Controls.Add(this.rtBtn);
            this.Controls.Add(this.decBtn);
            this.Controls.Add(this.pwrBtn);
            this.Controls.Add(this.logBtn);
            this.Controls.Add(this.lnBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.evalBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.mulBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CalculatorApp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button lftParBtn;
        private System.Windows.Forms.Button rgtParBtn;

        #endregion

        private System.Windows.Forms.TextBox evalBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Button mulBtn;
        private System.Windows.Forms.Button divBtn;
        private System.Windows.Forms.Button evalBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button lnBtn;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Button pwrBtn;
        private System.Windows.Forms.Button decBtn;
        private System.Windows.Forms.Button rtBtn;
        private System.Windows.Forms.Button ePwrXBtn;
    }
}