//using System.Drawing;
namespace Lindenmayer_System
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
            this.generationAmountLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generation_textfield = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.startWordLabel = new System.Windows.Forms.Label();
            this.ruleLabel = new System.Windows.Forms.Label();
            this.triggerLabel = new System.Windows.Forms.Label();
            this.startWordTextBox = new System.Windows.Forms.TextBox();
            this.triggerTextBox = new System.Windows.Forms.TextBox();
            this.ruleTextBox = new System.Windows.Forms.TextBox();
            this.angle_label = new System.Windows.Forms.Label();
            this.angle_textbox = new System.Windows.Forms.TextBox();
            this.length_label = new System.Windows.Forms.Label();
            this.length_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rulewrong_label = new System.Windows.Forms.RichTextBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // generationAmountLabel
            // 
            this.generationAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generationAmountLabel.AutoSize = true;
            this.generationAmountLabel.ForeColor = System.Drawing.SystemColors.Info;
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
            this.generation_textfield.Size = new System.Drawing.Size(26, 23);
            this.generation_textfield.TabIndex = 1;
            this.generation_textfield.TextChanged += new System.EventHandler(this.generation_textfield_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.AutoSize = true;
            this.generateButton.Location = new System.Drawing.Point(45, 417);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(102, 25);
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
            this.drawPanel.Location = new System.Drawing.Point(165, -3);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(634, 456);
            this.drawPanel.TabIndex = 4;
            this.drawPanel.TabStop = true;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // startWordLabel
            // 
            this.startWordLabel.AutoSize = true;
            this.startWordLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.startWordLabel.Location = new System.Drawing.Point(49, 19);
            this.startWordLabel.Name = "startWordLabel";
            this.startWordLabel.Size = new System.Drawing.Size(58, 15);
            this.startWordLabel.TabIndex = 5;
            this.startWordLabel.Text = "Startword";
            // 
            // ruleLabel
            // 
            this.ruleLabel.AutoSize = true;
            this.ruleLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ruleLabel.Location = new System.Drawing.Point(62, 133);
            this.ruleLabel.Name = "ruleLabel";
            this.ruleLabel.Size = new System.Drawing.Size(30, 15);
            this.ruleLabel.TabIndex = 6;
            this.ruleLabel.Text = "Rule";
            // 
            // triggerLabel
            // 
            this.triggerLabel.AutoSize = true;
            this.triggerLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.triggerLabel.Location = new System.Drawing.Point(30, 79);
            this.triggerLabel.Name = "triggerLabel";
            this.triggerLabel.Size = new System.Drawing.Size(102, 15);
            this.triggerLabel.TabIndex = 7;
            this.triggerLabel.Text = "Rule trigger (char)";
            // 
            // startWordTextBox
            // 
            this.startWordTextBox.Location = new System.Drawing.Point(22, 37);
            this.startWordTextBox.Name = "startWordTextBox";
            this.startWordTextBox.Size = new System.Drawing.Size(113, 23);
            this.startWordTextBox.TabIndex = 8;
            this.startWordTextBox.Text = "D";
            this.startWordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startWordTextBox.TextChanged += new System.EventHandler(this.startWordTextBox_TextChanged);
            // 
            // triggerTextBox
            // 
            this.triggerTextBox.Location = new System.Drawing.Point(62, 97);
            this.triggerTextBox.Name = "triggerTextBox";
            this.triggerTextBox.Size = new System.Drawing.Size(30, 23);
            this.triggerTextBox.TabIndex = 9;
            this.triggerTextBox.Text = "D";
            this.triggerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.triggerTextBox.TextChanged += new System.EventHandler(this.triggerTextBox_TextChanged);
            // 
            // ruleTextBox
            // 
            this.ruleTextBox.Location = new System.Drawing.Point(1, 151);
            this.ruleTextBox.Name = "ruleTextBox";
            this.ruleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ruleTextBox.Size = new System.Drawing.Size(160, 23);
            this.ruleTextBox.TabIndex = 10;
            this.ruleTextBox.Text = "DDR[RDLDLD]L[LDRDRDRD]";
            this.ruleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ruleTextBox.TextChanged += new System.EventHandler(this.ruleTextBox_TextChanged);
            // 
            // angle_label
            // 
            this.angle_label.AutoSize = true;
            this.angle_label.ForeColor = System.Drawing.SystemColors.Info;
            this.angle_label.Location = new System.Drawing.Point(22, 257);
            this.angle_label.Name = "angle_label";
            this.angle_label.Size = new System.Drawing.Size(113, 15);
            this.angle_label.TabIndex = 0;
            this.angle_label.Text = "Branchangle (1-128)";
            // 
            // angle_textbox
            // 
            this.angle_textbox.Location = new System.Drawing.Point(47, 275);
            this.angle_textbox.Name = "angle_textbox";
            this.angle_textbox.Size = new System.Drawing.Size(58, 23);
            this.angle_textbox.TabIndex = 11;
            this.angle_textbox.Text = "22.5";
            this.angle_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.angle_textbox.TextChanged += new System.EventHandler(this.angle_textbox_TextChanged);
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.ForeColor = System.Drawing.SystemColors.Info;
            this.length_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.length_label.Location = new System.Drawing.Point(54, 301);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(44, 15);
            this.length_label.TabIndex = 12;
            this.length_label.Text = "Length";
            // 
            // length_textbox
            // 
            this.length_textbox.Location = new System.Drawing.Point(47, 319);
            this.length_textbox.Name = "length_textbox";
            this.length_textbox.Size = new System.Drawing.Size(58, 23);
            this.length_textbox.TabIndex = 13;
            this.length_textbox.Text = "50";
            this.length_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.length_textbox.TextChanged += new System.EventHandler(this.length_textbox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rulewrong_label);
            this.panel2.Controls.Add(this.ruleTextBox);
            this.panel2.Controls.Add(this.length_textbox);
            this.panel2.Controls.Add(this.triggerTextBox);
            this.panel2.Controls.Add(this.reset_button);
            this.panel2.Controls.Add(this.startWordTextBox);
            this.panel2.Controls.Add(this.length_label);
            this.panel2.Controls.Add(this.triggerLabel);
            this.panel2.Controls.Add(this.angle_label);
            this.panel2.Controls.Add(this.ruleLabel);
            this.panel2.Controls.Add(this.angle_textbox);
            this.panel2.Controls.Add(this.startWordLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 453);
            this.panel2.TabIndex = 0;
            // 
            // rulewrong_label
            // 
            this.rulewrong_label.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rulewrong_label.ForeColor = System.Drawing.Color.Red;
            this.rulewrong_label.Location = new System.Drawing.Point(30, 180);
            this.rulewrong_label.Name = "rulewrong_label";
            this.rulewrong_label.Size = new System.Drawing.Size(100, 36);
            this.rulewrong_label.TabIndex = 14;
            this.rulewrong_label.Text = "\'[\' and \']\' must be the same amount";
            this.rulewrong_label.Visible = false;
            // 
            // reset_button
            // 
            this.reset_button.ForeColor = System.Drawing.Color.Red;
            this.reset_button.Location = new System.Drawing.Point(12, 366);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(134, 23);
            this.reset_button.TabIndex = 0;
            this.reset_button.Text = "Reset to Standard";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generationAmountLabel);
            this.Controls.Add(this.generation_textfield);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sven´s Lindenmayer-L-System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label startWordLabel;
        private System.Windows.Forms.Label ruleLabel;
        private System.Windows.Forms.Label triggerLabel;
        private System.Windows.Forms.TextBox startWordTextBox;
        private System.Windows.Forms.TextBox triggerTextBox;
        private System.Windows.Forms.TextBox ruleTextBox;
        private System.Windows.Forms.Label angle_label;
        private System.Windows.Forms.TextBox angle_textbox;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.TextBox length_textbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.RichTextBox rulewrong_label;
    }
}

