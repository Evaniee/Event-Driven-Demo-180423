namespace Tooltips
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
            components = new System.ComponentModel.Container();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            btnSubmit = new Button();
            cmbNames = new ComboBox();
            lbl_addName = new Label();
            lbl_selectName = new Label();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 0;
            txtName.MouseHover += txtName_MouseHover;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 72);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 23);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cmbNames
            // 
            cmbNames.FormattingEnabled = true;
            cmbNames.Location = new Point(168, 43);
            cmbNames.Name = "cmbNames";
            cmbNames.Size = new Size(150, 23);
            cmbNames.TabIndex = 2;
            // 
            // lbl_addName
            // 
            lbl_addName.AutoSize = true;
            lbl_addName.Location = new Point(12, 25);
            lbl_addName.Name = "lbl_addName";
            lbl_addName.Size = new Size(78, 15);
            lbl_addName.TabIndex = 3;
            lbl_addName.Text = "Add A Name:";
            // 
            // lbl_selectName
            // 
            lbl_selectName.AutoSize = true;
            lbl_selectName.Location = new Point(168, 25);
            lbl_selectName.Name = "lbl_selectName";
            lbl_selectName.Size = new Size(87, 15);
            lbl_selectName.TabIndex = 4;
            lbl_selectName.Text = "Select A Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_selectName);
            Controls.Add(lbl_addName);
            Controls.Add(cmbNames);
            Controls.Add(btnSubmit);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private ToolTip toolTip1;
        private Button btnSubmit;
        private ComboBox cmbNames;
        private Label lbl_addName;
        private Label lbl_selectName;
        private ColorDialog colorDialog1;
    }
}