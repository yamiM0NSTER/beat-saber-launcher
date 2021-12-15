namespace beat_saber_launcher.Forms
{
    partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.launchButton = new System.Windows.Forms.Button();
      this.selectedVersionComboBox = new System.Windows.Forms.ComboBox();
      this.pathTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.oculusModeCheckBox = new System.Windows.Forms.CheckBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.commandlineTextBox = new System.Windows.Forms.TextBox();
      this.propertiesButton = new System.Windows.Forms.Button();
      this.addButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // launchButton
      // 
      this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.launchButton.Location = new System.Drawing.Point(10, 150);
      this.launchButton.Name = "launchButton";
      this.launchButton.Size = new System.Drawing.Size(333, 42);
      this.launchButton.TabIndex = 0;
      this.launchButton.Text = "Launch!";
      this.launchButton.UseVisualStyleBackColor = true;
      this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
      // 
      // selectedVersionComboBox
      // 
      this.selectedVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.selectedVersionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.selectedVersionComboBox.FormattingEnabled = true;
      this.selectedVersionComboBox.Location = new System.Drawing.Point(10, 22);
      this.selectedVersionComboBox.Name = "selectedVersionComboBox";
      this.selectedVersionComboBox.Size = new System.Drawing.Size(275, 21);
      this.selectedVersionComboBox.TabIndex = 1;
      this.selectedVersionComboBox.SelectedValueChanged += new System.EventHandler(this.selectedVersionComboBox_SelectedValueChanged);
      // 
      // pathTextBox
      // 
      this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pathTextBox.Enabled = false;
      this.pathTextBox.Location = new System.Drawing.Point(10, 62);
      this.pathTextBox.Name = "pathTextBox";
      this.pathTextBox.ReadOnly = true;
      this.pathTextBox.Size = new System.Drawing.Size(333, 20);
      this.pathTextBox.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Version:";
      // 
      // oculusModeCheckBox
      // 
      this.oculusModeCheckBox.AutoSize = true;
      this.oculusModeCheckBox.Enabled = false;
      this.oculusModeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.oculusModeCheckBox.Location = new System.Drawing.Point(10, 88);
      this.oculusModeCheckBox.Name = "oculusModeCheckBox";
      this.oculusModeCheckBox.Size = new System.Drawing.Size(86, 17);
      this.oculusModeCheckBox.TabIndex = 6;
      this.oculusModeCheckBox.Text = "Oculus Mode";
      this.oculusModeCheckBox.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Path:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 108);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(173, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Additional commandline arguments:";
      // 
      // commandlineTextBox
      // 
      this.commandlineTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.commandlineTextBox.Enabled = false;
      this.commandlineTextBox.Location = new System.Drawing.Point(10, 124);
      this.commandlineTextBox.Name = "commandlineTextBox";
      this.commandlineTextBox.ReadOnly = true;
      this.commandlineTextBox.Size = new System.Drawing.Size(333, 20);
      this.commandlineTextBox.TabIndex = 8;
      // 
      // propertiesButton
      // 
      this.propertiesButton.Enabled = false;
      this.propertiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.propertiesButton.Image = global::beat_saber_launcher.Properties.Resources.Settings_16x;
      this.propertiesButton.Location = new System.Drawing.Point(291, 21);
      this.propertiesButton.Name = "propertiesButton";
      this.propertiesButton.Size = new System.Drawing.Size(24, 24);
      this.propertiesButton.TabIndex = 3;
      this.propertiesButton.UseVisualStyleBackColor = false;
      this.propertiesButton.Click += new System.EventHandler(this.propertiesButton_Click);
      // 
      // addButton
      // 
      this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addButton.Image = global::beat_saber_launcher.Properties.Resources.Add_16x;
      this.addButton.Location = new System.Drawing.Point(320, 21);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(24, 24);
      this.addButton.TabIndex = 2;
      this.addButton.UseVisualStyleBackColor = false;
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(355, 204);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.commandlineTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.oculusModeCheckBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pathTextBox);
      this.Controls.Add(this.propertiesButton);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.selectedVersionComboBox);
      this.Controls.Add(this.launchButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Beat Saber Launcher";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.ComboBox selectedVersionComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button propertiesButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox oculusModeCheckBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox commandlineTextBox;
  }
}