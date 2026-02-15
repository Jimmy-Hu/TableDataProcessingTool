namespace TableDataProcessingTool.WinForms.SelectedCellsInfo
{
    partial class SelectedCellsInfo
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
            this.groupBox_Main = new System.Windows.Forms.GroupBox();
            this.label_cellSum = new System.Windows.Forms.Label();
            this.label_cellMin = new System.Windows.Forms.Label();
            this.label_cellMax = new System.Windows.Forms.Label();
            this.groupBox_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Main
            // 
            this.groupBox_Main.Controls.Add(this.label_cellMax);
            this.groupBox_Main.Controls.Add(this.label_cellMin);
            this.groupBox_Main.Controls.Add(this.label_cellSum);
            this.groupBox_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox_Main.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Main.Name = "groupBox_Main";
            this.groupBox_Main.Size = new System.Drawing.Size(776, 426);
            this.groupBox_Main.TabIndex = 0;
            this.groupBox_Main.TabStop = false;
            this.groupBox_Main.Text = "Selected Cells Information";
            // 
            // label_cellSum
            // 
            this.label_cellSum.AutoSize = true;
            this.label_cellSum.Location = new System.Drawing.Point(7, 26);
            this.label_cellSum.Name = "label_cellSum";
            this.label_cellSum.Size = new System.Drawing.Size(42, 20);
            this.label_cellSum.TabIndex = 0;
            this.label_cellSum.Text = "Sum";
            // 
            // label_cellMin
            // 
            this.label_cellMin.AutoSize = true;
            this.label_cellMin.Location = new System.Drawing.Point(7, 46);
            this.label_cellMin.Name = "label_cellMin";
            this.label_cellMin.Size = new System.Drawing.Size(99, 20);
            this.label_cellMin.TabIndex = 1;
            this.label_cellMin.Text = "label_cellMin";
            // 
            // label_cellMax
            // 
            this.label_cellMax.AutoSize = true;
            this.label_cellMax.Location = new System.Drawing.Point(6, 66);
            this.label_cellMax.Name = "label_cellMax";
            this.label_cellMax.Size = new System.Drawing.Size(103, 20);
            this.label_cellMax.TabIndex = 2;
            this.label_cellMax.Text = "label_cellMax";
            // 
            // SelectedCellsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Main);
            this.Name = "SelectedCellsInfo";
            this.Text = "SelectedCellsInfo";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.groupBox_Main.ResumeLayout(false);
            this.groupBox_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Main;
        private System.Windows.Forms.Label label_cellSum;
        private System.Windows.Forms.Label label_cellMax;
        private System.Windows.Forms.Label label_cellMin;
    }
}