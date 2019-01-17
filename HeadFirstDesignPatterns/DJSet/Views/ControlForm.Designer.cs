namespace DJSet.Views
{
    partial class ControlForm
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
            this.menuDJControl = new System.Windows.Forms.MenuStrip();
            this.menuItemsDJControl = new System.Windows.Forms.ToolStripMenuItem();
            this.startOptionMenuDJControl = new System.Windows.Forms.ToolStripMenuItem();
            this.stopOptionMenuDJControl = new System.Windows.Forms.ToolStripMenuItem();
            this.quitOptionMenuDJControl = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.numericBPM = new System.Windows.Forms.NumericUpDown();
            this.btnSetBPM = new System.Windows.Forms.Button();
            this.menuDJControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuDJControl
            // 
            this.menuDJControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemsDJControl});
            this.menuDJControl.Location = new System.Drawing.Point(0, 0);
            this.menuDJControl.Name = "menuDJControl";
            this.menuDJControl.Size = new System.Drawing.Size(120, 24);
            this.menuDJControl.TabIndex = 0;
            this.menuDJControl.Text = "menuStrip1";
            // 
            // menuItemsDJControl
            // 
            this.menuItemsDJControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startOptionMenuDJControl,
            this.stopOptionMenuDJControl,
            this.quitOptionMenuDJControl});
            this.menuItemsDJControl.Name = "menuItemsDJControl";
            this.menuItemsDJControl.Size = new System.Drawing.Size(74, 20);
            this.menuItemsDJControl.Text = "&DJ Control";
            // 
            // startOptionMenuDJControl
            // 
            this.startOptionMenuDJControl.Name = "startOptionMenuDJControl";
            this.startOptionMenuDJControl.Size = new System.Drawing.Size(98, 22);
            this.startOptionMenuDJControl.Text = "&Start";
            this.startOptionMenuDJControl.Click += new System.EventHandler(this.startOptionMenuDJControl_Click);
            // 
            // stopOptionMenuDJControl
            // 
            this.stopOptionMenuDJControl.Name = "stopOptionMenuDJControl";
            this.stopOptionMenuDJControl.Size = new System.Drawing.Size(98, 22);
            this.stopOptionMenuDJControl.Text = "S&top";
            this.stopOptionMenuDJControl.Click += new System.EventHandler(this.stopOptionMenuDJControl_Click);
            // 
            // quitOptionMenuDJControl
            // 
            this.quitOptionMenuDJControl.Name = "quitOptionMenuDJControl";
            this.quitOptionMenuDJControl.Size = new System.Drawing.Size(98, 22);
            this.quitOptionMenuDJControl.Text = "&Quit";
            this.quitOptionMenuDJControl.Click += new System.EventHandler(this.quitOptionMenuDJControl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter BPM:";
            // 
            // numericBPM
            // 
            this.numericBPM.Location = new System.Drawing.Point(65, 32);
            this.numericBPM.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericBPM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBPM.Name = "numericBPM";
            this.numericBPM.Size = new System.Drawing.Size(50, 20);
            this.numericBPM.TabIndex = 2;
            this.numericBPM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBPM.ValueChanged += new System.EventHandler(this.numericBPM_ValueChanged);
            // 
            // btnSetBPM
            // 
            this.btnSetBPM.Location = new System.Drawing.Point(6, 58);
            this.btnSetBPM.Name = "btnSetBPM";
            this.btnSetBPM.Size = new System.Drawing.Size(109, 23);
            this.btnSetBPM.TabIndex = 3;
            this.btnSetBPM.Text = "&Set";
            this.btnSetBPM.UseVisualStyleBackColor = true;
            this.btnSetBPM.Click += new System.EventHandler(this.btnSetBPM_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 87);
            this.Controls.Add(this.btnSetBPM);
            this.Controls.Add(this.numericBPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuDJControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(136, 126);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(136, 126);
            this.Name = "ControlForm";
            this.ShowIcon = false;
            this.Text = "Control";
            this.menuDJControl.ResumeLayout(false);
            this.menuDJControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuDJControl;
        private System.Windows.Forms.ToolStripMenuItem menuItemsDJControl;
        private System.Windows.Forms.ToolStripMenuItem startOptionMenuDJControl;
        private System.Windows.Forms.ToolStripMenuItem stopOptionMenuDJControl;
        private System.Windows.Forms.ToolStripMenuItem quitOptionMenuDJControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericBPM;
        private System.Windows.Forms.Button btnSetBPM;
    }
}

