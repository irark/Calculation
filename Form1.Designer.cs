
namespace Test
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
            this.calc = new System.Windows.Forms.Button();
            this.lbN = new System.Windows.Forms.Label();
            this.lbM = new System.Windows.Forms.Label();
            this.lbSpeeds = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.dgvSpeeds = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(290, 265);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(135, 42);
            this.calc.TabIndex = 0;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(49, 44);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(169, 17);
            this.lbN.TabIndex = 1;
            this.lbN.Text = "number of team members";
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(52, 89);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(121, 17);
            this.lbM.TabIndex = 2;
            this.lbM.Text = "number of images";
            // 
            // lbSpeeds
            // 
            this.lbSpeeds.AutoSize = true;
            this.lbSpeeds.Location = new System.Drawing.Point(52, 145);
            this.lbSpeeds.Name = "lbSpeeds";
            this.lbSpeeds.Size = new System.Drawing.Size(262, 17);
            this.lbSpeeds.TabIndex = 3;
            this.lbSpeeds.Text = "speed of the team members (in minutes)";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(49, 307);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(48, 17);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "Result";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(55, 64);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(100, 22);
            this.tbN.TabIndex = 5;
            this.tbN.TextChanged += new System.EventHandler(this.tbN_TextChanged);
            // 
            // tbM
            // 
            this.tbM.Location = new System.Drawing.Point(55, 110);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(100, 22);
            this.tbM.TabIndex = 6;
            this.tbM.TextChanged += new System.EventHandler(this.tbM_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(118, 307);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 22);
            this.tbResult.TabIndex = 8;
            // 
            // dgvSpeeds
            // 
            this.dgvSpeeds.AllowDrop = true;
            this.dgvSpeeds.AllowUserToAddRows = false;
            this.dgvSpeeds.AllowUserToDeleteRows = false;
            this.dgvSpeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpeeds.Location = new System.Drawing.Point(52, 177);
            this.dgvSpeeds.MultiSelect = false;
            this.dgvSpeeds.Name = "dgvSpeeds";
            this.dgvSpeeds.RowHeadersWidth = 51;
            this.dgvSpeeds.RowTemplate.Height = 24;
            this.dgvSpeeds.Size = new System.Drawing.Size(649, 82);
            this.dgvSpeeds.TabIndex = 9;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(50, 348);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(651, 90);
            this.dgvResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvSpeeds);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbM);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbSpeeds);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.lbN);
            this.Controls.Add(this.calc);
            this.Name = "Form1";
            this.Text = "Calculation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpeeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.Label lbSpeeds;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.DataGridView dgvSpeeds;
        private System.Windows.Forms.DataGridView dgvResult;
    }
}

