namespace beat_saber_launcher.Forms {
  partial class DeleteVersionConfirmationForm {
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
      this.textLabel = new System.Windows.Forms.Label();
      this.yesButton = new System.Windows.Forms.Button();
      this.noButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textLabel
      // 
      this.textLabel.Dock = System.Windows.Forms.DockStyle.Top;
      this.textLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.textLabel.Location = new System.Drawing.Point(0, 0);
      this.textLabel.Name = "textLabel";
      this.textLabel.Size = new System.Drawing.Size(350, 103);
      this.textLabel.TabIndex = 0;
      this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // yesButton
      // 
      this.yesButton.AutoSize = true;
      this.yesButton.Location = new System.Drawing.Point(3, 3);
      this.yesButton.Name = "yesButton";
      this.yesButton.Size = new System.Drawing.Size(169, 23);
      this.yesButton.TabIndex = 1;
      this.yesButton.Text = "Yes";
      this.yesButton.UseVisualStyleBackColor = true;
      this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
      // 
      // noButton
      // 
      this.noButton.AutoSize = true;
      this.noButton.Location = new System.Drawing.Point(178, 3);
      this.noButton.Name = "noButton";
      this.noButton.Size = new System.Drawing.Size(165, 23);
      this.noButton.TabIndex = 2;
      this.noButton.Text = "No";
      this.noButton.UseVisualStyleBackColor = true;
      this.noButton.Click += new System.EventHandler(this.noButton_Click);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.yesButton, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.noButton, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 35);
      this.tableLayoutPanel1.TabIndex = 3;
      // 
      // DeleteVersionConfirmationForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(350, 138);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.textLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "DeleteVersionConfirmationForm";
      this.Text = "Confirm action";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label textLabel;
    private System.Windows.Forms.Button yesButton;
    private System.Windows.Forms.Button noButton;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}