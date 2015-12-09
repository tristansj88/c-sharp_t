namespace frmPetName
{
    partial class frmPetName
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblGetName = new System.Windows.Forms.Label();
            this.txtPetsName = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(34, 230);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "&Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(143, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblGetName
            // 
            this.lblGetName.AutoSize = true;
            this.lblGetName.Location = new System.Drawing.Point(34, 49);
            this.lblGetName.Name = "lblGetName";
            this.lblGetName.Size = new System.Drawing.Size(115, 13);
            this.lblGetName.TabIndex = 3;
            this.lblGetName.Text = "Enter your Pet\'s Name:";
            // 
            // txtPetsName
            // 
            this.txtPetsName.Location = new System.Drawing.Point(155, 42);
            this.txtPetsName.Name = "txtPetsName";
            this.txtPetsName.Size = new System.Drawing.Size(100, 20);
            this.txtPetsName.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(73, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // frmPetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 297);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPetsName);
            this.Controls.Add(this.lblGetName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmPetName";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblGetName;
        private System.Windows.Forms.TextBox txtPetsName;
        private System.Windows.Forms.Label lblResult;
    }
}

