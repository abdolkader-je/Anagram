namespace B2B
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.FilePathTxt = new System.Windows.Forms.TextBox();
            this.WordTxt = new System.Windows.Forms.TextBox();
            this.GetWordAnagramsBtn = new System.Windows.Forms.Button();
            this.WordLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GetAnagramsBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.SelectFileBtn.Location = new System.Drawing.Point(424, 61);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(141, 23);
            this.SelectFileBtn.TabIndex = 0;
            this.SelectFileBtn.Text = "Select File";
            this.SelectFileBtn.UseVisualStyleBackColor = false;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtnClick);
            // 
            // FilePathTxt
            // 
            this.FilePathTxt.Location = new System.Drawing.Point(125, 62);
            this.FilePathTxt.Name = "FilePathTxt";
            this.FilePathTxt.Size = new System.Drawing.Size(293, 23);
            this.FilePathTxt.TabIndex = 1;
            // 
            // WordTxt
            // 
            this.WordTxt.Location = new System.Drawing.Point(125, 90);
            this.WordTxt.Name = "WordTxt";
            this.WordTxt.Size = new System.Drawing.Size(293, 23);
            this.WordTxt.TabIndex = 4;
            this.WordTxt.TextChanged += new System.EventHandler(this.WordTxt_TextChanged);
            // 
            // GetWordAnagramsBtn
            // 
            this.GetWordAnagramsBtn.BackColor = System.Drawing.Color.Transparent;
            this.GetWordAnagramsBtn.Location = new System.Drawing.Point(424, 90);
            this.GetWordAnagramsBtn.Name = "GetWordAnagramsBtn";
            this.GetWordAnagramsBtn.Size = new System.Drawing.Size(141, 23);
            this.GetWordAnagramsBtn.TabIndex = 5;
            this.GetWordAnagramsBtn.Text = "Proceed";
            this.GetWordAnagramsBtn.UseVisualStyleBackColor = false;
            this.GetWordAnagramsBtn.Click += new System.EventHandler(this.GetWordAnagramsBtnClick);
            // 
            // WordLbl
            // 
            this.WordLbl.AutoSize = true;
            this.WordLbl.Location = new System.Drawing.Point(125, 48);
            this.WordLbl.Name = "WordLbl";
            this.WordLbl.Size = new System.Drawing.Size(151, 15);
            this.WordLbl.TabIndex = 7;
            this.WordLbl.Text = "Enter A Word Or A Number";
            this.WordLbl.Click += new System.EventHandler(this.WordLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Text File Path";
            // 
            // GetAnagramsBtn
            // 
            this.GetAnagramsBtn.BackColor = System.Drawing.Color.Transparent;
            this.GetAnagramsBtn.Location = new System.Drawing.Point(125, 100);
            this.GetAnagramsBtn.Name = "GetAnagramsBtn";
            this.GetAnagramsBtn.Size = new System.Drawing.Size(440, 23);
            this.GetAnagramsBtn.TabIndex = 9;
            this.GetAnagramsBtn.Text = "Get All Anagrams OutPut";
            this.GetAnagramsBtn.UseVisualStyleBackColor = false;
            this.GetAnagramsBtn.Click += new System.EventHandler(this.GetAnagramsBtnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.WordTxt);
            this.groupBox1.Controls.Add(this.WordLbl);
            this.groupBox1.Controls.Add(this.GetWordAnagramsBtn);
            this.groupBox1.Location = new System.Drawing.Point(58, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Word/ Number";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SelectFileBtn);
            this.groupBox2.Controls.Add(this.GetAnagramsBtn);
            this.groupBox2.Controls.Add(this.FilePathTxt);
            this.groupBox2.Location = new System.Drawing.Point(58, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 147);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(310, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Anagrams Tool Demo";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Anagrams Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button SelectFileBtn;
        private TextBox FilePathTxt;
        private TextBox WordTxt;
        private Button GetWordAnagramsBtn;
        private Label WordLbl;
        private Label label1;
        private Button GetAnagramsBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
    }
}