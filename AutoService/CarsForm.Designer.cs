namespace AutoService
{
    partial class CarsForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.rdbGray = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbSilver = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbBrown = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbSchimb_Frane = new System.Windows.Forms.CheckBox();
            this.ckbSchimb_Ulei = new System.Windows.Forms.CheckBox();
            this.ckbDistributie = new System.Windows.Forms.CheckBox();
            this.ckbSchimb_Far = new System.Windows.Forms.CheckBox();
            this.ckbPolish = new System.Windows.Forms.CheckBox();
            this.ckbVulcanizare = new System.Windows.Forms.CheckBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDisplayCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.btnBackMenu1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(285, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 22);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cilindrical Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(200, 229);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(62, 20);
            this.rdbBlack.TabIndex = 9;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Location = new System.Drawing.Point(200, 255);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(62, 20);
            this.rdbWhite.TabIndex = 10;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(358, 229);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(65, 20);
            this.rdbGreen.TabIndex = 11;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            this.rdbGreen.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Location = new System.Drawing.Point(200, 307);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(54, 20);
            this.rdbRed.TabIndex = 12;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // rdbGray
            // 
            this.rdbGray.AutoSize = true;
            this.rdbGray.Location = new System.Drawing.Point(200, 281);
            this.rdbGray.Name = "rdbGray";
            this.rdbGray.Size = new System.Drawing.Size(57, 20);
            this.rdbGray.TabIndex = 13;
            this.rdbGray.TabStop = true;
            this.rdbGray.Text = "Gray";
            this.rdbGray.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Location = new System.Drawing.Point(200, 333);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(55, 20);
            this.rdbBlue.TabIndex = 14;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbSilver
            // 
            this.rdbSilver.AutoSize = true;
            this.rdbSilver.Location = new System.Drawing.Point(358, 255);
            this.rdbSilver.Name = "rdbSilver";
            this.rdbSilver.Size = new System.Drawing.Size(62, 20);
            this.rdbSilver.TabIndex = 15;
            this.rdbSilver.TabStop = true;
            this.rdbSilver.Text = "Silver";
            this.rdbSilver.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Location = new System.Drawing.Point(358, 307);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(68, 20);
            this.rdbYellow.TabIndex = 16;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbBrown
            // 
            this.rdbBrown.AutoSize = true;
            this.rdbBrown.Location = new System.Drawing.Point(358, 281);
            this.rdbBrown.Name = "rdbBrown";
            this.rdbBrown.Size = new System.Drawing.Size(65, 20);
            this.rdbBrown.TabIndex = 17;
            this.rdbBrown.TabStop = true;
            this.rdbBrown.Text = "Brown";
            this.rdbBrown.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // ckbSchimb_Frane
            // 
            this.ckbSchimb_Frane.AutoSize = true;
            this.ckbSchimb_Frane.Location = new System.Drawing.Point(200, 366);
            this.ckbSchimb_Frane.Name = "ckbSchimb_Frane";
            this.ckbSchimb_Frane.Size = new System.Drawing.Size(112, 20);
            this.ckbSchimb_Frane.TabIndex = 19;
            this.ckbSchimb_Frane.Text = "Schimb Frane";
            this.ckbSchimb_Frane.UseVisualStyleBackColor = true;
            this.ckbSchimb_Frane.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbSchimb_Ulei
            // 
            this.ckbSchimb_Ulei.AutoSize = true;
            this.ckbSchimb_Ulei.Location = new System.Drawing.Point(200, 392);
            this.ckbSchimb_Ulei.Name = "ckbSchimb_Ulei";
            this.ckbSchimb_Ulei.Size = new System.Drawing.Size(98, 20);
            this.ckbSchimb_Ulei.TabIndex = 20;
            this.ckbSchimb_Ulei.Text = "Schimb ulei";
            this.ckbSchimb_Ulei.UseVisualStyleBackColor = true;
            // 
            // ckbDistributie
            // 
            this.ckbDistributie.AutoSize = true;
            this.ckbDistributie.Location = new System.Drawing.Point(200, 418);
            this.ckbDistributie.Name = "ckbDistributie";
            this.ckbDistributie.Size = new System.Drawing.Size(88, 20);
            this.ckbDistributie.TabIndex = 21;
            this.ckbDistributie.Text = "Distributie";
            this.ckbDistributie.UseVisualStyleBackColor = true;
            this.ckbDistributie.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckbSchimb_Far
            // 
            this.ckbSchimb_Far.AutoSize = true;
            this.ckbSchimb_Far.Location = new System.Drawing.Point(358, 362);
            this.ckbSchimb_Far.Name = "ckbSchimb_Far";
            this.ckbSchimb_Far.Size = new System.Drawing.Size(131, 20);
            this.ckbSchimb_Far.TabIndex = 22;
            this.ckbSchimb_Far.Text = "Schimbare Faruri";
            this.ckbSchimb_Far.UseVisualStyleBackColor = true;
            // 
            // ckbPolish
            // 
            this.ckbPolish.AutoSize = true;
            this.ckbPolish.Location = new System.Drawing.Point(358, 418);
            this.ckbPolish.Name = "ckbPolish";
            this.ckbPolish.Size = new System.Drawing.Size(66, 20);
            this.ckbPolish.TabIndex = 23;
            this.ckbPolish.Text = "Polish";
            this.ckbPolish.UseVisualStyleBackColor = true;
            // 
            // ckbVulcanizare
            // 
            this.ckbVulcanizare.AutoSize = true;
            this.ckbVulcanizare.Location = new System.Drawing.Point(358, 392);
            this.ckbVulcanizare.Name = "ckbVulcanizare";
            this.ckbVulcanizare.Size = new System.Drawing.Size(99, 20);
            this.ckbVulcanizare.TabIndex = 24;
            this.ckbVulcanizare.Text = "Vulcanizare";
            this.ckbVulcanizare.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(119, 458);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 25;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDisplayCar
            // 
            this.btnDisplayCar.Location = new System.Drawing.Point(235, 458);
            this.btnDisplayCar.Name = "btnDisplayCar";
            this.btnDisplayCar.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayCar.TabIndex = 26;
            this.btnDisplayCar.Text = "Display";
            this.btnDisplayCar.UseVisualStyleBackColor = true;
            this.btnDisplayCar.Click += new System.EventHandler(this.btnDisplayCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(358, 458);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCar.TabIndex = 27;
            this.btnDeleteCar.Text = "Delete";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // btnBackMenu1
            // 
            this.btnBackMenu1.Location = new System.Drawing.Point(237, 503);
            this.btnBackMenu1.Name = "btnBackMenu1";
            this.btnBackMenu1.Size = new System.Drawing.Size(75, 23);
            this.btnBackMenu1.TabIndex = 29;
            this.btnBackMenu1.Text = "Back";
            this.btnBackMenu1.UseVisualStyleBackColor = true;
            this.btnBackMenu1.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(589, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(701, 458);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 538);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackMenu1);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnDisplayCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.ckbVulcanizare);
            this.Controls.Add(this.ckbPolish);
            this.Controls.Add(this.ckbSchimb_Far);
            this.Controls.Add(this.ckbDistributie);
            this.Controls.Add(this.ckbSchimb_Ulei);
            this.Controls.Add(this.ckbSchimb_Frane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbBrown);
            this.Controls.Add(this.rdbYellow);
            this.Controls.Add(this.rdbSilver);
            this.Controls.Add(this.rdbBlue);
            this.Controls.Add(this.rdbGray);
            this.Controls.Add(this.rdbRed);
            this.Controls.Add(this.rdbGreen);
            this.Controls.Add(this.rdbWhite);
            this.Controls.Add(this.rdbBlack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "CarsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbGray;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbSilver;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.RadioButton rdbBrown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCarBrand;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarYear;
        private System.Windows.Forms.TextBox txtCarCilindrical_Capacity;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.CheckBox ckbSchimb_Frane;
        private System.Windows.Forms.CheckBox ckbSchimb_Ulei;
        private System.Windows.Forms.CheckBox ckbDistributie;
        private System.Windows.Forms.CheckBox ckbSchimb_Far;
        private System.Windows.Forms.CheckBox ckbPolish;
        private System.Windows.Forms.CheckBox ckbVulcanizare;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDisplayCar;
        private System.Windows.Forms.Button btnDeleteCar;
        private System.Windows.Forms.Button btnBackMenu1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}