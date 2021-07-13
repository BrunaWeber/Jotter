
namespace Jotter1
{
    partial class MainForm1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNote = new System.Windows.Forms.Label();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.TopLabel = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(38, 78);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(42, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title:";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(38, 135);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(47, 20);
            this.labelNote.TabIndex = 1;
            this.labelNote.Text = "Note:";
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Location = new System.Drawing.Point(187, 382);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(149, 39);
            this.ButtonAddNote.TabIndex = 2;
            this.ButtonAddNote.Text = "Add Note";
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            this.ButtonAddNote.Click += new System.EventHandler(this.ButtonAddNote_Click);
            // 
            // TopLabel
            // 
            this.TopLabel.AutoSize = true;
            this.TopLabel.Location = new System.Drawing.Point(183, 20);
            this.TopLabel.Name = "TopLabel";
            this.TopLabel.Size = new System.Drawing.Size(133, 20);
            this.TopLabel.TabIndex = 3;
            this.TopLabel.Text = "You have 0 notes";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(187, 71);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(218, 37);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(187, 135);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(423, 209);
            this.textBoxNote.TabIndex = 5;
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.TopLabel);
            this.Controls.Add(this.ButtonAddNote);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm1";
            this.Text = "Jotter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button ButtonAddNote;
        private System.Windows.Forms.Label TopLabel;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxNote;
    }
}

