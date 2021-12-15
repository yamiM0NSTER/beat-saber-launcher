namespace beat_saber_launcher.Forms {
  partial class EditVersionForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.labelLabel = new System.Windows.Forms.Label();
      this.labelTextBox = new System.Windows.Forms.TextBox();
      this.pathLabel = new System.Windows.Forms.Label();
      this.pathTextBox = new System.Windows.Forms.TextBox();
      this.selectPathButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.oculusModeCheckBox = new System.Windows.Forms.CheckBox();
      this.commandlineTextBox = new System.Windows.Forms.TextBox();
      this.commandlineLabel = new System.Windows.Forms.Label();
      this.deleteButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelLabel
      // 
      this.labelLabel.AutoSize = true;
      this.labelLabel.Location = new System.Drawing.Point(12, 9);
      this.labelLabel.Name = "labelLabel";
      this.labelLabel.Size = new System.Drawing.Size(36, 13);
      this.labelLabel.TabIndex = 0;
      this.labelLabel.Text = "Label:";
      // 
      // labelTextBox
      // 
      this.labelTextBox.Location = new System.Drawing.Point(15, 25);
      this.labelTextBox.Name = "labelTextBox";
      this.labelTextBox.Size = new System.Drawing.Size(398, 20);
      this.labelTextBox.TabIndex = 1;
      // 
      // pathLabel
      // 
      this.pathLabel.AutoSize = true;
      this.pathLabel.Location = new System.Drawing.Point(12, 48);
      this.pathLabel.Name = "pathLabel";
      this.pathLabel.Size = new System.Drawing.Size(32, 13);
      this.pathLabel.TabIndex = 2;
      this.pathLabel.Text = "Path:";
      // 
      // pathTextBox
      // 
      this.pathTextBox.Location = new System.Drawing.Point(15, 64);
      this.pathTextBox.Name = "pathTextBox";
      this.pathTextBox.Size = new System.Drawing.Size(374, 20);
      this.pathTextBox.TabIndex = 2;
      // 
      // selectPathButton
      // 
      this.selectPathButton.Image = global::beat_saber_launcher.Properties.Resources.FolderOpened_16x;
      this.selectPathButton.Location = new System.Drawing.Point(390, 62);
      this.selectPathButton.Name = "selectPathButton";
      this.selectPathButton.Size = new System.Drawing.Size(24, 24);
      this.selectPathButton.TabIndex = 3;
      this.selectPathButton.UseVisualStyleBackColor = true;
      this.selectPathButton.Click += new System.EventHandler(this.selectPathButton_Click);
      // 
      // saveButton
      // 
      this.saveButton.Location = new System.Drawing.Point(15, 159);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(75, 23);
      this.saveButton.TabIndex = 6;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(338, 159);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 7;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // oculusModeCheckBox
      // 
      this.oculusModeCheckBox.AutoSize = true;
      this.oculusModeCheckBox.Location = new System.Drawing.Point(15, 90);
      this.oculusModeCheckBox.Name = "oculusModeCheckBox";
      this.oculusModeCheckBox.Size = new System.Drawing.Size(89, 17);
      this.oculusModeCheckBox.TabIndex = 4;
      this.oculusModeCheckBox.Text = "Oculus Mode";
      this.oculusModeCheckBox.UseVisualStyleBackColor = true;
      // 
      // commandlineTextBox
      // 
      this.commandlineTextBox.Location = new System.Drawing.Point(15, 126);
      this.commandlineTextBox.Name = "commandlineTextBox";
      this.commandlineTextBox.Size = new System.Drawing.Size(398, 20);
      this.commandlineTextBox.TabIndex = 5;
      // 
      // commandlineLabel
      // 
      this.commandlineLabel.AutoSize = true;
      this.commandlineLabel.Location = new System.Drawing.Point(12, 110);
      this.commandlineLabel.Name = "commandlineLabel";
      this.commandlineLabel.Size = new System.Drawing.Size(173, 13);
      this.commandlineLabel.TabIndex = 8;
      this.commandlineLabel.Text = "Additional commandline arguments:";
      // 
      // deleteButton
      // 
      this.deleteButton.Location = new System.Drawing.Point(186, 159);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(75, 23);
      this.deleteButton.TabIndex = 9;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // EditVersionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(425, 195);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.commandlineTextBox);
      this.Controls.Add(this.commandlineLabel);
      this.Controls.Add(this.oculusModeCheckBox);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.selectPathButton);
      this.Controls.Add(this.pathTextBox);
      this.Controls.Add(this.pathLabel);
      this.Controls.Add(this.labelTextBox);
      this.Controls.Add(this.labelLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "EditVersionForm";
      this.Text = "Edit Version";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelLabel;
    private System.Windows.Forms.TextBox labelTextBox;
    private System.Windows.Forms.Label pathLabel;
    private System.Windows.Forms.TextBox pathTextBox;
    private System.Windows.Forms.Button selectPathButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.CheckBox oculusModeCheckBox;
    private System.Windows.Forms.TextBox commandlineTextBox;
    private System.Windows.Forms.Label commandlineLabel;
    private System.Windows.Forms.Button deleteButton;
  }
}