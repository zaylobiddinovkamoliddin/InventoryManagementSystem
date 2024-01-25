namespace InventoryManagementSystem
{
    partial class Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            addbtn = new Button();
            editbtn = new Button();
            deletebtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(deletebtn);
            panel1.Controls.Add(editbtn);
            panel1.Controls.Add(addbtn);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 634);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 95);
            panel1.TabIndex = 0;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(128, 255, 128);
            addbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addbtn.Location = new Point(54, 28);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(114, 44);
            addbtn.TabIndex = 0;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.FromArgb(128, 255, 128);
            editbtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbtn.Location = new Point(326, 28);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(114, 44);
            editbtn.TabIndex = 1;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.FromArgb(128, 255, 128);
            deletebtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebtn.Location = new Point(598, 28);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(114, 44);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(821, 84);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 22);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(479, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 34);
            textBox1.TabIndex = 1;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form";
            Size = new Size(821, 729);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button deletebtn;
        private Button editbtn;
        private Button addbtn;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
    }
}
