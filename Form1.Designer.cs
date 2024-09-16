namespace WORD
{
    partial class Form1
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
            btnNew = new Button();
            btnOpen = new Button();
            btnSaveAs = new Button();
            btnBold = new Button();
            btnItalic = new Button();
            btnUnderline = new Button();
            label1 = new Label();
            cmbFont = new ComboBox();
            label2 = new Label();
            cmbFontSize = new ComboBox();
            btnColor = new Button();
            pbColor = new PictureBox();
            RTB = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbColor).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(3, 10);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "Nowy";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(84, 10);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "Otwórz";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSaveAs
            // 
            btnSaveAs.Location = new Point(165, 10);
            btnSaveAs.Name = "btnSaveAs";
            btnSaveAs.Size = new Size(75, 23);
            btnSaveAs.TabIndex = 2;
            btnSaveAs.Text = "Zapisz jako";
            btnSaveAs.UseVisualStyleBackColor = true;
            btnSaveAs.Click += btnSaveAs_Click;
            // 
            // btnBold
            // 
            btnBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBold.Location = new Point(3, 39);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(22, 23);
            btnBold.TabIndex = 3;
            btnBold.Text = "B";
            btnBold.UseVisualStyleBackColor = true;
            btnBold.Click += btnBold_Click;
            // 
            // btnItalic
            // 
            btnItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btnItalic.Location = new Point(28, 39);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(22, 23);
            btnItalic.TabIndex = 4;
            btnItalic.Text = "/";
            btnItalic.UseVisualStyleBackColor = true;
            btnItalic.Click += btnItalic_Click;
            // 
            // btnUnderline
            // 
            btnUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btnUnderline.Location = new Point(56, 39);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(22, 23);
            btnUnderline.TabIndex = 5;
            btnUnderline.Text = "\\";
            btnUnderline.UseVisualStyleBackColor = true;
            btnUnderline.Click += btnUnderline_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 43);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "Font:";
            // 
            // cmbFont
            // 
            cmbFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFont.FormattingEnabled = true;
            cmbFont.Location = new Point(124, 39);
            cmbFont.Name = "cmbFont";
            cmbFont.Size = new Size(121, 23);
            cmbFont.TabIndex = 7;
            cmbFont.SelectedIndexChanged += cmbFont_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 43);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Rozmiar fontu:";
            // 
            // cmbFontSize
            // 
            cmbFontSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFontSize.FormattingEnabled = true;
            cmbFontSize.Location = new Point(342, 39);
            cmbFontSize.Name = "cmbFontSize";
            cmbFontSize.Size = new Size(121, 23);
            cmbFontSize.TabIndex = 9;
            cmbFontSize.SelectedIndexChanged += cmbFontSize_SelectedIndexChanged;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(481, 39);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(45, 23);
            btnColor.TabIndex = 10;
            btnColor.Text = "Kolor";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // pbColor
            // 
            pbColor.Location = new Point(532, 37);
            pbColor.Name = "pbColor";
            pbColor.Size = new Size(31, 25);
            pbColor.TabIndex = 11;
            pbColor.TabStop = false;
            // 
            // RTB
            // 
            RTB.Location = new Point(3, 68);
            RTB.Name = "RTB";
            RTB.Size = new Size(778, 491);
            RTB.TabIndex = 12;
            RTB.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(RTB);
            Controls.Add(pbColor);
            Controls.Add(btnColor);
            Controls.Add(cmbFontSize);
            Controls.Add(label2);
            Controls.Add(cmbFont);
            Controls.Add(label1);
            Controls.Add(btnUnderline);
            Controls.Add(btnItalic);
            Controls.Add(btnBold);
            Controls.Add(btnSaveAs);
            Controls.Add(btnOpen);
            Controls.Add(btnNew);
            Name = "Form1";
            Text = "Prosty Word";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbColor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnOpen;
        private Button btnSaveAs;
        private Button btnBold;
        private Button btnItalic;
        private Button btnUnderline;
        private Label label1;
        private ComboBox cmbFont;
        private Label label2;
        private ComboBox cmbFontSize;
        private Button btnColor;
        private PictureBox pbColor;
        private RichTextBox RTB;
    }
}