namespace TableDataProcessingTool2
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
            groupBox_Main = new GroupBox();
            label_cellSum = new Label();
            label_cellMin = new Label();
            label_cellMax = new Label();
            groupBox_Main.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Main
            // 
            groupBox_Main.Controls.Add(label_cellMax);
            groupBox_Main.Controls.Add(label_cellMin);
            groupBox_Main.Controls.Add(label_cellSum);
            groupBox_Main.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_Main.Location = new Point(12, 12);
            groupBox_Main.Name = "groupBox_Main";
            groupBox_Main.Size = new Size(776, 426);
            groupBox_Main.TabIndex = 0;
            groupBox_Main.TabStop = false;
            groupBox_Main.Text = "Selected Cells Information";
            // 
            // label_cellSum
            // 
            label_cellSum.AutoSize = true;
            label_cellSum.Location = new Point(6, 23);
            label_cellSum.Name = "label_cellSum";
            label_cellSum.Size = new Size(44, 20);
            label_cellSum.TabIndex = 0;
            label_cellSum.Text = "Sum";
            // 
            // label_cellMin
            // 
            label_cellMin.AutoSize = true;
            label_cellMin.Location = new Point(6, 43);
            label_cellMin.Name = "label_cellMin";
            label_cellMin.Size = new Size(115, 20);
            label_cellMin.TabIndex = 1;
            label_cellMin.Text = "label_cellMin";
            // 
            // label_cellMax
            // 
            label_cellMax.AutoSize = true;
            label_cellMax.Location = new Point(6, 63);
            label_cellMax.Name = "label_cellMax";
            label_cellMax.Size = new Size(119, 20);
            label_cellMax.TabIndex = 2;
            label_cellMax.Text = "label_cellMax";
            // 
            // SelectedCellsInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox_Main);
            Name = "SelectedCellsInfo";
            Text = "SelectedCellsInfo";
            groupBox_Main.ResumeLayout(false);
            groupBox_Main.PerformLayout();
            Resize += Form_Resize;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Main;
        private Label label_cellSum;
        private Label label_cellMin;
        private Label label_cellMax;
    }
}