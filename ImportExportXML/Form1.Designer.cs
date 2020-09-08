namespace ImportExportXML
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
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbFilePath = new System.Windows.Forms.TextBox();
            this.txtbExcelFileName = new System.Windows.Forms.TextBox();
            this.chBoxName = new System.Windows.Forms.CheckBox();
            this.progressBarConvert = new System.Windows.Forms.ProgressBar();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(281, 81);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Välj fil...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(57, 68);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(62, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Välj XML-fil:";
            // 
            // txtbFilePath
            // 
            this.txtbFilePath.Location = new System.Drawing.Point(60, 84);
            this.txtbFilePath.Name = "txtbFilePath";
            this.txtbFilePath.Size = new System.Drawing.Size(215, 20);
            this.txtbFilePath.TabIndex = 3;
            // 
            // txtbExcelFileName
            // 
            this.txtbExcelFileName.Location = new System.Drawing.Point(185, 157);
            this.txtbExcelFileName.Name = "txtbExcelFileName";
            this.txtbExcelFileName.Size = new System.Drawing.Size(171, 20);
            this.txtbExcelFileName.TabIndex = 4;
            // 
            // chBoxName
            // 
            this.chBoxName.AutoSize = true;
            this.chBoxName.Location = new System.Drawing.Point(60, 157);
            this.chBoxName.Name = "chBoxName";
            this.chBoxName.Size = new System.Drawing.Size(119, 17);
            this.chBoxName.TabIndex = 5;
            this.chBoxName.Text = "Filnamn för Excel-fil:";
            this.chBoxName.UseVisualStyleBackColor = true;
            // 
            // progressBarConvert
            // 
            this.progressBarConvert.Location = new System.Drawing.Point(60, 227);
            this.progressBarConvert.Name = "progressBarConvert";
            this.progressBarConvert.Size = new System.Drawing.Size(215, 23);
            this.progressBarConvert.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(281, 227);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Konvertera";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.progressBarConvert);
            this.Controls.Add(this.chBoxName);
            this.Controls.Add(this.txtbExcelFileName);
            this.Controls.Add(this.txtbFilePath);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnChooseFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbFilePath;
        private System.Windows.Forms.TextBox txtbExcelFileName;
        private System.Windows.Forms.CheckBox chBoxName;
        private System.Windows.Forms.ProgressBar progressBarConvert;
        private System.Windows.Forms.Button btnConvert;
    }
}

