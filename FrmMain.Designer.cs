
namespace DiffParser
{
    partial class FrmMain
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
            this.grpPaste = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.grpRAW = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.grpPaste.SuspendLayout();
            this.grpRAW.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPaste
            // 
            this.grpPaste.Controls.Add(this.txtInput);
            this.grpPaste.Location = new System.Drawing.Point(12, 12);
            this.grpPaste.Name = "grpPaste";
            this.grpPaste.Size = new System.Drawing.Size(1024, 256);
            this.grpPaste.TabIndex = 0;
            this.grpPaste.TabStop = false;
            this.grpPaste.Text = "Paste Diff";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1000, 224);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // grpRAW
            // 
            this.grpRAW.Controls.Add(this.txtOutput);
            this.grpRAW.Location = new System.Drawing.Point(12, 274);
            this.grpRAW.Name = "grpRAW";
            this.grpRAW.Size = new System.Drawing.Size(1024, 256);
            this.grpRAW.TabIndex = 1;
            this.grpRAW.TabStop = false;
            this.grpRAW.Text = "RAW";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(15, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1000, 224);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.Text = "";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.Controls.Add(this.grpRAW);
            this.Controls.Add(this.grpPaste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Git Diff Parser";
            this.grpPaste.ResumeLayout(false);
            this.grpRAW.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPaste;
        private System.Windows.Forms.GroupBox grpRAW;
        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

