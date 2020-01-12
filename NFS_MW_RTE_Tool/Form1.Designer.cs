namespace NFS_MW_RTE_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectConsole = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bountyValue = new MetroFramework.Controls.MetroTextBox();
            this.setBounty = new MetroFramework.Controls.MetroButton();
            this.setMoney = new MetroFramework.Controls.MetroButton();
            this.moneyValue = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectConsole
            // 
            this.connectConsole.Location = new System.Drawing.Point(28, 63);
            this.connectConsole.Name = "connectConsole";
            this.connectConsole.Size = new System.Drawing.Size(269, 23);
            this.connectConsole.TabIndex = 0;
            this.connectConsole.Text = "Connect To Console";
            this.connectConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connectConsole.UseSelectable = true;
            this.connectConsole.Click += new System.EventHandler(this.ConnectConsole_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.bountyValue);
            this.metroPanel2.Controls.Add(this.setBounty);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(24, 162);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(276, 62);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // bountyValue
            // 
            // 
            // 
            // 
            this.bountyValue.CustomButton.Image = null;
            this.bountyValue.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.bountyValue.CustomButton.Name = "";
            this.bountyValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.bountyValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bountyValue.CustomButton.TabIndex = 1;
            this.bountyValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bountyValue.CustomButton.UseSelectable = true;
            this.bountyValue.CustomButton.Visible = false;
            this.bountyValue.Enabled = false;
            this.bountyValue.Lines = new string[0];
            this.bountyValue.Location = new System.Drawing.Point(4, 34);
            this.bountyValue.MaxLength = 32767;
            this.bountyValue.Name = "bountyValue";
            this.bountyValue.PasswordChar = '\0';
            this.bountyValue.PromptText = "Bounty For Current Police Chase";
            this.bountyValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bountyValue.SelectedText = "";
            this.bountyValue.SelectionLength = 0;
            this.bountyValue.SelectionStart = 0;
            this.bountyValue.ShortcutsEnabled = true;
            this.bountyValue.Size = new System.Drawing.Size(269, 23);
            this.bountyValue.TabIndex = 3;
            this.bountyValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bountyValue.UseSelectable = true;
            this.bountyValue.WaterMark = "Bounty For Current Police Chase";
            this.bountyValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bountyValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // setBounty
            // 
            this.setBounty.Enabled = false;
            this.setBounty.Location = new System.Drawing.Point(4, 4);
            this.setBounty.Name = "setBounty";
            this.setBounty.Size = new System.Drawing.Size(269, 23);
            this.setBounty.TabIndex = 2;
            this.setBounty.Text = "Set Bounty";
            this.setBounty.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setBounty.UseSelectable = true;
            this.setBounty.Click += new System.EventHandler(this.SetBounty_Click);
            // 
            // setMoney
            // 
            this.setMoney.Enabled = false;
            this.setMoney.Location = new System.Drawing.Point(4, 4);
            this.setMoney.Name = "setMoney";
            this.setMoney.Size = new System.Drawing.Size(269, 23);
            this.setMoney.TabIndex = 2;
            this.setMoney.Text = "Set Money";
            this.setMoney.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setMoney.UseSelectable = true;
            this.setMoney.Click += new System.EventHandler(this.SetMoney_Click);
            // 
            // moneyValue
            // 
            // 
            // 
            // 
            this.moneyValue.CustomButton.Image = null;
            this.moneyValue.CustomButton.Location = new System.Drawing.Point(247, 1);
            this.moneyValue.CustomButton.Name = "";
            this.moneyValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.moneyValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.moneyValue.CustomButton.TabIndex = 1;
            this.moneyValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.moneyValue.CustomButton.UseSelectable = true;
            this.moneyValue.CustomButton.Visible = false;
            this.moneyValue.Enabled = false;
            this.moneyValue.Lines = new string[0];
            this.moneyValue.Location = new System.Drawing.Point(4, 34);
            this.moneyValue.MaxLength = 32767;
            this.moneyValue.Name = "moneyValue";
            this.moneyValue.PasswordChar = '\0';
            this.moneyValue.PromptText = "Enter Amount Of Money";
            this.moneyValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.moneyValue.SelectedText = "";
            this.moneyValue.SelectionLength = 0;
            this.moneyValue.SelectionStart = 0;
            this.moneyValue.ShortcutsEnabled = true;
            this.moneyValue.Size = new System.Drawing.Size(269, 23);
            this.moneyValue.TabIndex = 3;
            this.moneyValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.moneyValue.UseSelectable = true;
            this.moneyValue.WaterMark = "Enter Amount Of Money";
            this.moneyValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.moneyValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.moneyValue);
            this.metroPanel1.Controls.Add(this.setMoney);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 93);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(276, 62);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 255);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.connectConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "NFS Most Wanted RTE Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton connectConsole;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox bountyValue;
        private MetroFramework.Controls.MetroButton setBounty;
        private MetroFramework.Controls.MetroButton setMoney;
        private MetroFramework.Controls.MetroTextBox moneyValue;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

