
namespace DataStructuresProject3Stacks
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNputInfixDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInfixToPostfixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfixDataField = new System.Windows.Forms.ListBox();
            this.InfixExpression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostFixInputBox = new System.Windows.Forms.TextBox();
            this.InfixInputBox = new System.Windows.Forms.TextBox();
            this.GeneratePostfixButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InfixExpressionsTopLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNputInfixDataFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // iNputInfixDataFileToolStripMenuItem
            // 
            this.iNputInfixDataFileToolStripMenuItem.Name = "iNputInfixDataFileToolStripMenuItem";
            this.iNputInfixDataFileToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.iNputInfixDataFileToolStripMenuItem.Text = "Input Infix Data File";
            this.iNputInfixDataFileToolStripMenuItem.Click += new System.EventHandler(this.iNputInfixDataFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInfixToPostfixToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutInfixToPostfixToolStripMenuItem
            // 
            this.aboutInfixToPostfixToolStripMenuItem.Name = "aboutInfixToPostfixToolStripMenuItem";
            this.aboutInfixToPostfixToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.aboutInfixToPostfixToolStripMenuItem.Text = "About Infix to Postfix";
            this.aboutInfixToPostfixToolStripMenuItem.Click += new System.EventHandler(this.aboutInfixToPostfixToolStripMenuItem_Click);
            // 
            // InfixDataField
            // 
            this.InfixDataField.AccessibleName = "InfixDataField";
            this.InfixDataField.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixDataField.FormattingEnabled = true;
            this.InfixDataField.ItemHeight = 25;
            this.InfixDataField.Location = new System.Drawing.Point(50, 58);
            this.InfixDataField.Name = "InfixDataField";
            this.InfixDataField.Size = new System.Drawing.Size(680, 254);
            this.InfixDataField.TabIndex = 1;
            this.InfixDataField.Click += new System.EventHandler(this.InfixDataField_Click);
            // 
            // InfixExpression
            // 
            this.InfixExpression.AccessibleName = "InfixExpression";
            this.InfixExpression.AutoSize = true;
            this.InfixExpression.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixExpression.Location = new System.Drawing.Point(46, 356);
            this.InfixExpression.Name = "InfixExpression";
            this.InfixExpression.Size = new System.Drawing.Size(117, 21);
            this.InfixExpression.TabIndex = 2;
            this.InfixExpression.Text = "Infix Expression";
            this.InfixExpression.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AccessibleName = "InfixExpression";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Postifx Expression";
            this.label1.UseMnemonic = false;
            // 
            // PostFixInputBox
            // 
            this.PostFixInputBox.AccessibleName = "PostFixInputBox";
            this.PostFixInputBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PostFixInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostFixInputBox.Location = new System.Drawing.Point(223, 391);
            this.PostFixInputBox.Name = "PostFixInputBox";
            this.PostFixInputBox.ReadOnly = true;
            this.PostFixInputBox.Size = new System.Drawing.Size(507, 29);
            this.PostFixInputBox.TabIndex = 4;
            // 
            // InfixInputBox
            // 
            this.InfixInputBox.AccessibleName = "InfixInputBox";
            this.InfixInputBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixInputBox.Location = new System.Drawing.Point(223, 348);
            this.InfixInputBox.Name = "InfixInputBox";
            this.InfixInputBox.Size = new System.Drawing.Size(507, 29);
            this.InfixInputBox.TabIndex = 5;
            // 
            // GeneratePostfixButton
            // 
            this.GeneratePostfixButton.AccessibleName = "GeneratePostfixButton";
            this.GeneratePostfixButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePostfixButton.Location = new System.Drawing.Point(102, 447);
            this.GeneratePostfixButton.Name = "GeneratePostfixButton";
            this.GeneratePostfixButton.Size = new System.Drawing.Size(140, 39);
            this.GeneratePostfixButton.TabIndex = 6;
            this.GeneratePostfixButton.Text = "Generate Postfix";
            this.GeneratePostfixButton.UseVisualStyleBackColor = true;
            this.GeneratePostfixButton.Click += new System.EventHandler(this.GeneratePostfixButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AccessibleName = "ClearButton";
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(329, 447);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(140, 39);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleName = "ExitButton";
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(552, 447);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 39);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InfixExpressionsTopLabel
            // 
            this.InfixExpressionsTopLabel.AccessibleName = "InfixExpressionsTopLabel";
            this.InfixExpressionsTopLabel.AutoSize = true;
            this.InfixExpressionsTopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfixExpressionsTopLabel.Location = new System.Drawing.Point(46, 34);
            this.InfixExpressionsTopLabel.Name = "InfixExpressionsTopLabel";
            this.InfixExpressionsTopLabel.Size = new System.Drawing.Size(124, 21);
            this.InfixExpressionsTopLabel.TabIndex = 9;
            this.InfixExpressionsTopLabel.Text = "Infix Expressions";
            this.InfixExpressionsTopLabel.UseMnemonic = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.InfixExpressionsTopLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GeneratePostfixButton);
            this.Controls.Add(this.InfixInputBox);
            this.Controls.Add(this.PostFixInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfixExpression);
            this.Controls.Add(this.InfixDataField);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNputInfixDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInfixToPostfixToolStripMenuItem;
        private System.Windows.Forms.ListBox InfixDataField;
        private System.Windows.Forms.Label InfixExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PostFixInputBox;
        private System.Windows.Forms.TextBox InfixInputBox;
        private System.Windows.Forms.Button GeneratePostfixButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label InfixExpressionsTopLabel;
    }
}

