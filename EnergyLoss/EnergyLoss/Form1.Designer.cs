namespace EnergyLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_NewBuilding = new System.Windows.Forms.Button();
            this.btn_LoadBuilding = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewBuilding
            // 
            this.btn_NewBuilding.Location = new System.Drawing.Point(34, 72);
            this.btn_NewBuilding.Name = "btn_NewBuilding";
            this.btn_NewBuilding.Size = new System.Drawing.Size(79, 23);
            this.btn_NewBuilding.TabIndex = 0;
            this.btn_NewBuilding.Text = "New Building";
            this.btn_NewBuilding.UseVisualStyleBackColor = true;
            this.btn_NewBuilding.Click += new System.EventHandler(this.btn_NewBuilding_Click);
            // 
            // btn_LoadBuilding
            // 
            this.btn_LoadBuilding.Location = new System.Drawing.Point(34, 116);
            this.btn_LoadBuilding.Name = "btn_LoadBuilding";
            this.btn_LoadBuilding.Size = new System.Drawing.Size(79, 23);
            this.btn_LoadBuilding.TabIndex = 1;
            this.btn_LoadBuilding.Text = "Load Building";
            this.btn_LoadBuilding.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(34, 187);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_LoadBuilding);
            this.Controls.Add(this.btn_NewBuilding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewBuilding;
        private System.Windows.Forms.Button btn_LoadBuilding;
        private System.Windows.Forms.Button btn_exit;
    }
}

