//using System.Drawing;
namespace Lindenmayer_System
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
            this.generationAmountLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generation_textfield = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // generationAmountLabel
            // 
            this.generationAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generationAmountLabel.AutoSize = true;
            this.generationAmountLabel.Location = new System.Drawing.Point(12, 397);
            this.generationAmountLabel.Name = "generationAmountLabel";
            this.generationAmountLabel.Size = new System.Drawing.Size(135, 15);
            this.generationAmountLabel.TabIndex = 2;
            this.generationAmountLabel.Text = "How many generations?";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 0);
            this.panel1.TabIndex = 3;
            // 
            // generation_textfield
            // 
            this.generation_textfield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generation_textfield.BackColor = System.Drawing.SystemColors.Info;
            this.generation_textfield.Location = new System.Drawing.Point(12, 417);
            this.generation_textfield.Name = "generation_textfield";
            this.generation_textfield.Size = new System.Drawing.Size(50, 23);
            this.generation_textfield.TabIndex = 1;
            this.generation_textfield.TextChanged += new System.EventHandler(this.generation_textfield_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(72, 417);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 25);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Visible = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.AutoSize = true;
            this.drawPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.drawPanel.Location = new System.Drawing.Point(-4, -3);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(807, 456);
            this.drawPanel.TabIndex = 4;
            this.drawPanel.TabStop = true;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generationAmountLabel);
            this.Controls.Add(this.generation_textfield);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label generationAmountLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox generation_textfield;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Panel drawPanel;
    }
}

