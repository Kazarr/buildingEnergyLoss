namespace EnergyLoss
{
    partial class MainView
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
            this.btn_LoadBuilding = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tb_Constructions = new System.Windows.Forms.TabControl();
            this.tb_Roof = new System.Windows.Forms.TabPage();
            this.lbl_RoofLenght = new System.Windows.Forms.Label();
            this.txt_RoofLenght = new System.Windows.Forms.TextBox();
            this.lbl_RoofWidth = new System.Windows.Forms.Label();
            this.txt_RoofWidth = new System.Windows.Forms.TextBox();
            this.btn_SaveRoof = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Thickness2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Thickness3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Thickness4 = new System.Windows.Forms.TextBox();
            this.cmb_RoofMaterial4 = new System.Windows.Forms.ComboBox();
            this.cmb_RoofMaterial3 = new System.Windows.Forms.ComboBox();
            this.cmb_RoofMaterial2 = new System.Windows.Forms.ComboBox();
            this.lbl_Thickness = new System.Windows.Forms.Label();
            this.txt_Thickness1 = new System.Windows.Forms.TextBox();
            this.cmb_RoofMaterial1 = new System.Windows.Forms.ComboBox();
            this.tb_Wall = new System.Windows.Forms.TabPage();
            this.lbl_WallLenght = new System.Windows.Forms.Label();
            this.txt_WallLenght = new System.Windows.Forms.TextBox();
            this.lbl_WallWidth = new System.Windows.Forms.Label();
            this.txt_WallWidth = new System.Windows.Forms.TextBox();
            this.btn_SaveWall = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.tb_Floor = new System.Windows.Forms.TabPage();
            this.lbl_FloorLenght = new System.Windows.Forms.Label();
            this.txt_FloorLenght = new System.Windows.Forms.TextBox();
            this.lbl_FloorWidth = new System.Windows.Forms.Label();
            this.txt_FloorWidth = new System.Windows.Forms.TextBox();
            this.btn_FloorSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.lbl_Constructions = new System.Windows.Forms.Label();
            this.rtb_Constructions = new System.Windows.Forms.RichTextBox();
            this.btn_CreateConstruction = new System.Windows.Forms.Button();
            this.tb_Constructions.SuspendLayout();
            this.tb_Roof.SuspendLayout();
            this.tb_Wall.SuspendLayout();
            this.tb_Floor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadBuilding
            // 
            this.btn_LoadBuilding.Location = new System.Drawing.Point(12, 296);
            this.btn_LoadBuilding.Name = "btn_LoadBuilding";
            this.btn_LoadBuilding.Size = new System.Drawing.Size(79, 23);
            this.btn_LoadBuilding.TabIndex = 1;
            this.btn_LoadBuilding.Text = "Load Building";
            this.btn_LoadBuilding.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 338);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tb_Constructions
            // 
            this.tb_Constructions.Controls.Add(this.tb_Roof);
            this.tb_Constructions.Controls.Add(this.tb_Wall);
            this.tb_Constructions.Controls.Add(this.tb_Floor);
            this.tb_Constructions.Location = new System.Drawing.Point(151, 0);
            this.tb_Constructions.Name = "tb_Constructions";
            this.tb_Constructions.SelectedIndex = 0;
            this.tb_Constructions.Size = new System.Drawing.Size(437, 262);
            this.tb_Constructions.TabIndex = 3;
            // 
            // tb_Roof
            // 
            this.tb_Roof.Controls.Add(this.lbl_RoofLenght);
            this.tb_Roof.Controls.Add(this.txt_RoofLenght);
            this.tb_Roof.Controls.Add(this.lbl_RoofWidth);
            this.tb_Roof.Controls.Add(this.txt_RoofWidth);
            this.tb_Roof.Controls.Add(this.btn_SaveRoof);
            this.tb_Roof.Controls.Add(this.label3);
            this.tb_Roof.Controls.Add(this.txt_Thickness2);
            this.tb_Roof.Controls.Add(this.label2);
            this.tb_Roof.Controls.Add(this.txt_Thickness3);
            this.tb_Roof.Controls.Add(this.label1);
            this.tb_Roof.Controls.Add(this.txt_Thickness4);
            this.tb_Roof.Controls.Add(this.cmb_RoofMaterial4);
            this.tb_Roof.Controls.Add(this.cmb_RoofMaterial3);
            this.tb_Roof.Controls.Add(this.cmb_RoofMaterial2);
            this.tb_Roof.Controls.Add(this.lbl_Thickness);
            this.tb_Roof.Controls.Add(this.txt_Thickness1);
            this.tb_Roof.Controls.Add(this.cmb_RoofMaterial1);
            this.tb_Roof.Location = new System.Drawing.Point(4, 22);
            this.tb_Roof.Name = "tb_Roof";
            this.tb_Roof.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Roof.Size = new System.Drawing.Size(429, 236);
            this.tb_Roof.TabIndex = 0;
            this.tb_Roof.Text = "Roof";
            this.tb_Roof.UseVisualStyleBackColor = true;
            // 
            // lbl_RoofLenght
            // 
            this.lbl_RoofLenght.AutoSize = true;
            this.lbl_RoofLenght.Location = new System.Drawing.Point(325, 46);
            this.lbl_RoofLenght.Name = "lbl_RoofLenght";
            this.lbl_RoofLenght.Size = new System.Drawing.Size(62, 13);
            this.lbl_RoofLenght.TabIndex = 17;
            this.lbl_RoofLenght.Text = "Roof lenght";
            // 
            // txt_RoofLenght
            // 
            this.txt_RoofLenght.Location = new System.Drawing.Point(361, 64);
            this.txt_RoofLenght.Name = "txt_RoofLenght";
            this.txt_RoofLenght.Size = new System.Drawing.Size(62, 20);
            this.txt_RoofLenght.TabIndex = 16;
            // 
            // lbl_RoofWidth
            // 
            this.lbl_RoofWidth.AutoSize = true;
            this.lbl_RoofWidth.Location = new System.Drawing.Point(329, 7);
            this.lbl_RoofWidth.Name = "lbl_RoofWidth";
            this.lbl_RoofWidth.Size = new System.Drawing.Size(58, 13);
            this.lbl_RoofWidth.TabIndex = 15;
            this.lbl_RoofWidth.Text = "Roof width";
            // 
            // txt_RoofWidth
            // 
            this.txt_RoofWidth.Location = new System.Drawing.Point(361, 23);
            this.txt_RoofWidth.Name = "txt_RoofWidth";
            this.txt_RoofWidth.Size = new System.Drawing.Size(62, 20);
            this.txt_RoofWidth.TabIndex = 14;
            // 
            // btn_SaveRoof
            // 
            this.btn_SaveRoof.Location = new System.Drawing.Point(332, 207);
            this.btn_SaveRoof.Name = "btn_SaveRoof";
            this.btn_SaveRoof.Size = new System.Drawing.Size(91, 23);
            this.btn_SaveRoof.TabIndex = 13;
            this.btn_SaveRoof.Text = "Save ";
            this.btn_SaveRoof.UseVisualStyleBackColor = true;
            this.btn_SaveRoof.Click += new System.EventHandler(this.btn_SaveRoof_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Thickness";
            // 
            // txt_Thickness2
            // 
            this.txt_Thickness2.Location = new System.Drawing.Point(157, 67);
            this.txt_Thickness2.Name = "txt_Thickness2";
            this.txt_Thickness2.Size = new System.Drawing.Size(62, 20);
            this.txt_Thickness2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thickness";
            // 
            // txt_Thickness3
            // 
            this.txt_Thickness3.Location = new System.Drawing.Point(154, 107);
            this.txt_Thickness3.Name = "txt_Thickness3";
            this.txt_Thickness3.Size = new System.Drawing.Size(62, 20);
            this.txt_Thickness3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thickness";
            // 
            // txt_Thickness4
            // 
            this.txt_Thickness4.Location = new System.Drawing.Point(154, 148);
            this.txt_Thickness4.Name = "txt_Thickness4";
            this.txt_Thickness4.Size = new System.Drawing.Size(62, 20);
            this.txt_Thickness4.TabIndex = 6;
            // 
            // cmb_RoofMaterial4
            // 
            this.cmb_RoofMaterial4.FormattingEnabled = true;
            this.cmb_RoofMaterial4.Location = new System.Drawing.Point(6, 147);
            this.cmb_RoofMaterial4.Name = "cmb_RoofMaterial4";
            this.cmb_RoofMaterial4.Size = new System.Drawing.Size(121, 21);
            this.cmb_RoofMaterial4.TabIndex = 5;
            // 
            // cmb_RoofMaterial3
            // 
            this.cmb_RoofMaterial3.FormattingEnabled = true;
            this.cmb_RoofMaterial3.Location = new System.Drawing.Point(6, 107);
            this.cmb_RoofMaterial3.Name = "cmb_RoofMaterial3";
            this.cmb_RoofMaterial3.Size = new System.Drawing.Size(121, 21);
            this.cmb_RoofMaterial3.TabIndex = 4;
            // 
            // cmb_RoofMaterial2
            // 
            this.cmb_RoofMaterial2.FormattingEnabled = true;
            this.cmb_RoofMaterial2.Location = new System.Drawing.Point(6, 66);
            this.cmb_RoofMaterial2.Name = "cmb_RoofMaterial2";
            this.cmb_RoofMaterial2.Size = new System.Drawing.Size(121, 21);
            this.cmb_RoofMaterial2.TabIndex = 3;
            // 
            // lbl_Thickness
            // 
            this.lbl_Thickness.AutoSize = true;
            this.lbl_Thickness.Location = new System.Drawing.Point(154, 10);
            this.lbl_Thickness.Name = "lbl_Thickness";
            this.lbl_Thickness.Size = new System.Drawing.Size(56, 13);
            this.lbl_Thickness.TabIndex = 2;
            this.lbl_Thickness.Text = "Thickness";
            // 
            // txt_Thickness1
            // 
            this.txt_Thickness1.Location = new System.Drawing.Point(157, 26);
            this.txt_Thickness1.Name = "txt_Thickness1";
            this.txt_Thickness1.Size = new System.Drawing.Size(62, 20);
            this.txt_Thickness1.TabIndex = 1;
            // 
            // cmb_RoofMaterial1
            // 
            this.cmb_RoofMaterial1.FormattingEnabled = true;
            this.cmb_RoofMaterial1.Location = new System.Drawing.Point(6, 25);
            this.cmb_RoofMaterial1.Name = "cmb_RoofMaterial1";
            this.cmb_RoofMaterial1.Size = new System.Drawing.Size(121, 21);
            this.cmb_RoofMaterial1.TabIndex = 0;
            // 
            // tb_Wall
            // 
            this.tb_Wall.Controls.Add(this.lbl_WallLenght);
            this.tb_Wall.Controls.Add(this.txt_WallLenght);
            this.tb_Wall.Controls.Add(this.lbl_WallWidth);
            this.tb_Wall.Controls.Add(this.txt_WallWidth);
            this.tb_Wall.Controls.Add(this.btn_SaveWall);
            this.tb_Wall.Controls.Add(this.label4);
            this.tb_Wall.Controls.Add(this.textBox4);
            this.tb_Wall.Controls.Add(this.label5);
            this.tb_Wall.Controls.Add(this.textBox5);
            this.tb_Wall.Controls.Add(this.label6);
            this.tb_Wall.Controls.Add(this.textBox6);
            this.tb_Wall.Controls.Add(this.comboBox4);
            this.tb_Wall.Controls.Add(this.comboBox5);
            this.tb_Wall.Controls.Add(this.comboBox6);
            this.tb_Wall.Controls.Add(this.label7);
            this.tb_Wall.Controls.Add(this.textBox7);
            this.tb_Wall.Controls.Add(this.comboBox7);
            this.tb_Wall.Location = new System.Drawing.Point(4, 22);
            this.tb_Wall.Name = "tb_Wall";
            this.tb_Wall.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Wall.Size = new System.Drawing.Size(429, 236);
            this.tb_Wall.TabIndex = 1;
            this.tb_Wall.Text = "Wall";
            this.tb_Wall.UseVisualStyleBackColor = true;
            // 
            // lbl_WallLenght
            // 
            this.lbl_WallLenght.AutoSize = true;
            this.lbl_WallLenght.Location = new System.Drawing.Point(325, 48);
            this.lbl_WallLenght.Name = "lbl_WallLenght";
            this.lbl_WallLenght.Size = new System.Drawing.Size(60, 13);
            this.lbl_WallLenght.TabIndex = 28;
            this.lbl_WallLenght.Text = "Wall lenght";
            // 
            // txt_WallLenght
            // 
            this.txt_WallLenght.Location = new System.Drawing.Point(361, 66);
            this.txt_WallLenght.Name = "txt_WallLenght";
            this.txt_WallLenght.Size = new System.Drawing.Size(62, 20);
            this.txt_WallLenght.TabIndex = 27;
            // 
            // lbl_WallWidth
            // 
            this.lbl_WallWidth.AutoSize = true;
            this.lbl_WallWidth.Location = new System.Drawing.Point(329, 9);
            this.lbl_WallWidth.Name = "lbl_WallWidth";
            this.lbl_WallWidth.Size = new System.Drawing.Size(56, 13);
            this.lbl_WallWidth.TabIndex = 26;
            this.lbl_WallWidth.Text = "Wall width";
            // 
            // txt_WallWidth
            // 
            this.txt_WallWidth.Location = new System.Drawing.Point(361, 25);
            this.txt_WallWidth.Name = "txt_WallWidth";
            this.txt_WallWidth.Size = new System.Drawing.Size(62, 20);
            this.txt_WallWidth.TabIndex = 25;
            // 
            // btn_SaveWall
            // 
            this.btn_SaveWall.Location = new System.Drawing.Point(332, 209);
            this.btn_SaveWall.Name = "btn_SaveWall";
            this.btn_SaveWall.Size = new System.Drawing.Size(91, 23);
            this.btn_SaveWall.TabIndex = 24;
            this.btn_SaveWall.Text = "Save ";
            this.btn_SaveWall.UseVisualStyleBackColor = true;
            this.btn_SaveWall.Click += new System.EventHandler(this.btn_SaveWall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Thickness";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(62, 20);
            this.textBox4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thickness";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 107);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(62, 20);
            this.textBox5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thickness";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 148);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(62, 20);
            this.textBox6.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(6, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 17;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 107);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 16;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(6, 66);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thickness";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(157, 26);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(62, 20);
            this.textBox7.TabIndex = 13;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(6, 25);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 12;
            // 
            // tb_Floor
            // 
            this.tb_Floor.Controls.Add(this.lbl_FloorLenght);
            this.tb_Floor.Controls.Add(this.txt_FloorLenght);
            this.tb_Floor.Controls.Add(this.lbl_FloorWidth);
            this.tb_Floor.Controls.Add(this.txt_FloorWidth);
            this.tb_Floor.Controls.Add(this.btn_FloorSave);
            this.tb_Floor.Controls.Add(this.label8);
            this.tb_Floor.Controls.Add(this.textBox8);
            this.tb_Floor.Controls.Add(this.label9);
            this.tb_Floor.Controls.Add(this.textBox9);
            this.tb_Floor.Controls.Add(this.label10);
            this.tb_Floor.Controls.Add(this.textBox10);
            this.tb_Floor.Controls.Add(this.comboBox8);
            this.tb_Floor.Controls.Add(this.comboBox9);
            this.tb_Floor.Controls.Add(this.comboBox10);
            this.tb_Floor.Controls.Add(this.label11);
            this.tb_Floor.Controls.Add(this.textBox11);
            this.tb_Floor.Controls.Add(this.comboBox11);
            this.tb_Floor.Location = new System.Drawing.Point(4, 22);
            this.tb_Floor.Name = "tb_Floor";
            this.tb_Floor.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Floor.Size = new System.Drawing.Size(429, 236);
            this.tb_Floor.TabIndex = 2;
            this.tb_Floor.Text = "Floor";
            this.tb_Floor.UseVisualStyleBackColor = true;
            // 
            // lbl_FloorLenght
            // 
            this.lbl_FloorLenght.AutoSize = true;
            this.lbl_FloorLenght.Location = new System.Drawing.Point(325, 49);
            this.lbl_FloorLenght.Name = "lbl_FloorLenght";
            this.lbl_FloorLenght.Size = new System.Drawing.Size(62, 13);
            this.lbl_FloorLenght.TabIndex = 28;
            this.lbl_FloorLenght.Text = "Floor lenght";
            // 
            // txt_FloorLenght
            // 
            this.txt_FloorLenght.Location = new System.Drawing.Point(361, 67);
            this.txt_FloorLenght.Name = "txt_FloorLenght";
            this.txt_FloorLenght.Size = new System.Drawing.Size(62, 20);
            this.txt_FloorLenght.TabIndex = 27;
            // 
            // lbl_FloorWidth
            // 
            this.lbl_FloorWidth.AutoSize = true;
            this.lbl_FloorWidth.Location = new System.Drawing.Point(329, 10);
            this.lbl_FloorWidth.Name = "lbl_FloorWidth";
            this.lbl_FloorWidth.Size = new System.Drawing.Size(58, 13);
            this.lbl_FloorWidth.TabIndex = 26;
            this.lbl_FloorWidth.Text = "Floor width";
            // 
            // txt_FloorWidth
            // 
            this.txt_FloorWidth.Location = new System.Drawing.Point(361, 26);
            this.txt_FloorWidth.Name = "txt_FloorWidth";
            this.txt_FloorWidth.Size = new System.Drawing.Size(62, 20);
            this.txt_FloorWidth.TabIndex = 25;
            // 
            // btn_FloorSave
            // 
            this.btn_FloorSave.Location = new System.Drawing.Point(332, 210);
            this.btn_FloorSave.Name = "btn_FloorSave";
            this.btn_FloorSave.Size = new System.Drawing.Size(91, 23);
            this.btn_FloorSave.TabIndex = 24;
            this.btn_FloorSave.Text = "Save ";
            this.btn_FloorSave.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thickness";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(157, 67);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(62, 20);
            this.textBox8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Thickness";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(154, 107);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(62, 20);
            this.textBox9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Thickness";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(154, 148);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(62, 20);
            this.textBox10.TabIndex = 18;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(6, 147);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 17;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(6, 107);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 16;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(6, 66);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Thickness";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(157, 26);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(62, 20);
            this.textBox11.TabIndex = 13;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(6, 25);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 12;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(594, 384);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 18;
            this.btn_Calculate.Text = "Calculate ";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            // 
            // lbl_Constructions
            // 
            this.lbl_Constructions.AutoSize = true;
            this.lbl_Constructions.Location = new System.Drawing.Point(148, 265);
            this.lbl_Constructions.Name = "lbl_Constructions";
            this.lbl_Constructions.Size = new System.Drawing.Size(71, 13);
            this.lbl_Constructions.TabIndex = 18;
            this.lbl_Constructions.Text = "Constructions";
            // 
            // rtb_Constructions
            // 
            this.rtb_Constructions.Location = new System.Drawing.Point(151, 282);
            this.rtb_Constructions.Name = "rtb_Constructions";
            this.rtb_Constructions.Size = new System.Drawing.Size(437, 96);
            this.rtb_Constructions.TabIndex = 19;
            this.rtb_Constructions.Text = "";
            // 
            // btn_CreateConstruction
            // 
            this.btn_CreateConstruction.Location = new System.Drawing.Point(594, 282);
            this.btn_CreateConstruction.Name = "btn_CreateConstruction";
            this.btn_CreateConstruction.Size = new System.Drawing.Size(75, 39);
            this.btn_CreateConstruction.TabIndex = 20;
            this.btn_CreateConstruction.Text = "Create construction";
            this.btn_CreateConstruction.UseVisualStyleBackColor = true;
            this.btn_CreateConstruction.Click += new System.EventHandler(this.btn_CreateConstruction_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 419);
            this.Controls.Add(this.btn_CreateConstruction);
            this.Controls.Add(this.rtb_Constructions);
            this.Controls.Add(this.lbl_Constructions);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.tb_Constructions);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_LoadBuilding);
            this.Name = "MainView";
            this.Text = "Form1";
            this.tb_Constructions.ResumeLayout(false);
            this.tb_Roof.ResumeLayout(false);
            this.tb_Roof.PerformLayout();
            this.tb_Wall.ResumeLayout(false);
            this.tb_Wall.PerformLayout();
            this.tb_Floor.ResumeLayout(false);
            this.tb_Floor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_LoadBuilding;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TabControl tb_Constructions;
        private System.Windows.Forms.TabPage tb_Roof;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Thickness2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Thickness3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Thickness4;
        private System.Windows.Forms.ComboBox cmb_RoofMaterial4;
        private System.Windows.Forms.ComboBox cmb_RoofMaterial3;
        private System.Windows.Forms.ComboBox cmb_RoofMaterial2;
        private System.Windows.Forms.Label lbl_Thickness;
        private System.Windows.Forms.TextBox txt_Thickness1;
        private System.Windows.Forms.ComboBox cmb_RoofMaterial1;
        private System.Windows.Forms.TabPage tb_Wall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.TabPage tb_Floor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Button btn_SaveRoof;
        private System.Windows.Forms.Label lbl_RoofLenght;
        private System.Windows.Forms.TextBox txt_RoofLenght;
        private System.Windows.Forms.Label lbl_RoofWidth;
        private System.Windows.Forms.TextBox txt_RoofWidth;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label lbl_Constructions;
        private System.Windows.Forms.RichTextBox rtb_Constructions;
        private System.Windows.Forms.Button btn_CreateConstruction;
        private System.Windows.Forms.Label lbl_WallLenght;
        private System.Windows.Forms.TextBox txt_WallLenght;
        private System.Windows.Forms.Label lbl_WallWidth;
        private System.Windows.Forms.TextBox txt_WallWidth;
        private System.Windows.Forms.Button btn_SaveWall;
        private System.Windows.Forms.Label lbl_FloorLenght;
        private System.Windows.Forms.TextBox txt_FloorLenght;
        private System.Windows.Forms.Label lbl_FloorWidth;
        private System.Windows.Forms.TextBox txt_FloorWidth;
        private System.Windows.Forms.Button btn_FloorSave;
    }
}

