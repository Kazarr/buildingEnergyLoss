namespace EnergyLoss
{
    partial class NewBuilding
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
            this.btn_NewConstruction = new System.Windows.Forms.Button();
            this.btn_CreateBuilding = new System.Windows.Forms.Button();
            this.btn_Other = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NewConstruction
            // 
            this.btn_NewConstruction.Location = new System.Drawing.Point(12, 72);
            this.btn_NewConstruction.Name = "btn_NewConstruction";
            this.btn_NewConstruction.Size = new System.Drawing.Size(100, 23);
            this.btn_NewConstruction.TabIndex = 0;
            this.btn_NewConstruction.Text = "New Construction";
            this.btn_NewConstruction.UseVisualStyleBackColor = true;
            // 
            // btn_CreateBuilding
            // 
            this.btn_CreateBuilding.Location = new System.Drawing.Point(680, 415);
            this.btn_CreateBuilding.Name = "btn_CreateBuilding";
            this.btn_CreateBuilding.Size = new System.Drawing.Size(108, 23);
            this.btn_CreateBuilding.TabIndex = 1;
            this.btn_CreateBuilding.Text = "Create Construction";
            this.btn_CreateBuilding.UseVisualStyleBackColor = true;
            // 
            // btn_Other
            // 
            this.btn_Other.Location = new System.Drawing.Point(12, 158);
            this.btn_Other.Name = "btn_Other";
            this.btn_Other.Size = new System.Drawing.Size(100, 23);
            this.btn_Other.TabIndex = 2;
            this.btn_Other.Text = "Other";
            this.btn_Other.UseVisualStyleBackColor = true;
            // 
            // NewBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Other);
            this.Controls.Add(this.btn_CreateBuilding);
            this.Controls.Add(this.btn_NewConstruction);
            this.Name = "NewBuilding";
            this.Text = "NewBuilding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewConstruction;
        private System.Windows.Forms.Button btn_CreateBuilding;
        private System.Windows.Forms.Button btn_Other;
    }
}