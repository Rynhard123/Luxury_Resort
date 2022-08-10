namespace Luxury_Resort
{
    partial class frmMain
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
            this.lblDays = new System.Windows.Forms.Label();
            this.lblRestaurant = new System.Windows.Forms.Label();
            this.lblSpa = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblMedical = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstbxOutput = new System.Windows.Forms.ListBox();
            this.txtbxDays = new System.Windows.Forms.TextBox();
            this.txtbxRestaurant = new System.Windows.Forms.TextBox();
            this.txtbxSpa = new System.Windows.Forms.TextBox();
            this.txtbxCar = new System.Windows.Forms.TextBox();
            this.txtbxMedical = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(13, 30);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(90, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "No. of days spent";
            // 
            // lblRestaurant
            // 
            this.lblRestaurant.AutoSize = true;
            this.lblRestaurant.Location = new System.Drawing.Point(13, 62);
            this.lblRestaurant.Name = "lblRestaurant";
            this.lblRestaurant.Size = new System.Drawing.Size(169, 13);
            this.lblRestaurant.TabIndex = 1;
            this.lblRestaurant.Text = "Restaurant charges including VAT";
            // 
            // lblSpa
            // 
            this.lblSpa.AutoSize = true;
            this.lblSpa.Location = new System.Drawing.Point(13, 98);
            this.lblSpa.Name = "lblSpa";
            this.lblSpa.Size = new System.Drawing.Size(167, 13);
            this.lblSpa.TabIndex = 2;
            this.lblSpa.Text = "Spa and health treatment charges";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(13, 136);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(114, 13);
            this.lblCar.TabIndex = 3;
            this.lblCar.Text = "Car and rental charges";
            // 
            // lblMedical
            // 
            this.lblMedical.AutoSize = true;
            this.lblMedical.Location = new System.Drawing.Point(13, 174);
            this.lblMedical.Name = "lblMedical";
            this.lblMedical.Size = new System.Drawing.Size(127, 13);
            this.lblMedical.TabIndex = 4;
            this.lblMedical.Text = "Medical and rehabilitation";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 207);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(139, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate Total charges";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstbxOutput
            // 
            this.lstbxOutput.FormattingEnabled = true;
            this.lstbxOutput.Location = new System.Drawing.Point(16, 237);
            this.lstbxOutput.Name = "lstbxOutput";
            this.lstbxOutput.Size = new System.Drawing.Size(284, 95);
            this.lstbxOutput.TabIndex = 7;
            // 
            // txtbxDays
            // 
            this.txtbxDays.Location = new System.Drawing.Point(110, 30);
            this.txtbxDays.Name = "txtbxDays";
            this.txtbxDays.Size = new System.Drawing.Size(100, 20);
            this.txtbxDays.TabIndex = 8;
            // 
            // txtbxRestaurant
            // 
            this.txtbxRestaurant.Location = new System.Drawing.Point(188, 62);
            this.txtbxRestaurant.Name = "txtbxRestaurant";
            this.txtbxRestaurant.Size = new System.Drawing.Size(100, 20);
            this.txtbxRestaurant.TabIndex = 9;
            // 
            // txtbxSpa
            // 
            this.txtbxSpa.Location = new System.Drawing.Point(186, 98);
            this.txtbxSpa.Name = "txtbxSpa";
            this.txtbxSpa.Size = new System.Drawing.Size(100, 20);
            this.txtbxSpa.TabIndex = 10;
            // 
            // txtbxCar
            // 
            this.txtbxCar.Location = new System.Drawing.Point(133, 133);
            this.txtbxCar.Name = "txtbxCar";
            this.txtbxCar.Size = new System.Drawing.Size(100, 20);
            this.txtbxCar.TabIndex = 11;
            // 
            // txtbxMedical
            // 
            this.txtbxMedical.Location = new System.Drawing.Point(146, 174);
            this.txtbxMedical.Name = "txtbxMedical";
            this.txtbxMedical.Size = new System.Drawing.Size(100, 20);
            this.txtbxMedical.TabIndex = 12;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 351);
            this.Controls.Add(this.txtbxMedical);
            this.Controls.Add(this.txtbxCar);
            this.Controls.Add(this.txtbxSpa);
            this.Controls.Add(this.txtbxRestaurant);
            this.Controls.Add(this.txtbxDays);
            this.Controls.Add(this.lstbxOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblMedical);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblSpa);
            this.Controls.Add(this.lblRestaurant);
            this.Controls.Add(this.lblDays);
            this.Name = "frmMain";
            this.Text = "Resort charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblRestaurant;
        private System.Windows.Forms.Label lblSpa;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblMedical;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstbxOutput;
        private System.Windows.Forms.TextBox txtbxDays;
        private System.Windows.Forms.TextBox txtbxRestaurant;
        private System.Windows.Forms.TextBox txtbxSpa;
        private System.Windows.Forms.TextBox txtbxCar;
        private System.Windows.Forms.TextBox txtbxMedical;
    }
}

