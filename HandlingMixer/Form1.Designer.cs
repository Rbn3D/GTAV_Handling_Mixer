namespace HnadlingMixer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFileB = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFileA = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mixGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mixPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MixBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mixGroup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFileB);
            this.panel2.Controls.Add(this.labelB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(264, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 163);
            this.panel2.TabIndex = 1;
            // 
            // btnFileB
            // 
            this.btnFileB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFileB.Location = new System.Drawing.Point(97, 62);
            this.btnFileB.Name = "btnFileB";
            this.btnFileB.Size = new System.Drawing.Size(75, 23);
            this.btnFileB.TabIndex = 3;
            this.btnFileB.Text = "Select file B";
            this.btnFileB.UseVisualStyleBackColor = true;
            this.btnFileB.Click += new System.EventHandler(this.btnFileB_Click);
            // 
            // labelB
            // 
            this.labelB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(117, 116);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(39, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "(None)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Handling file B";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFileA);
            this.panel1.Controls.Add(this.labelA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 163);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFileA
            // 
            this.btnFileA.Location = new System.Drawing.Point(79, 62);
            this.btnFileA.Name = "btnFileA";
            this.btnFileA.Size = new System.Drawing.Size(75, 23);
            this.btnFileA.TabIndex = 2;
            this.btnFileA.Text = "Select file A";
            this.btnFileA.UseVisualStyleBackColor = true;
            this.btnFileA.Click += new System.EventHandler(this.btnFileA_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(97, 116);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(39, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "(None)";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Handling file A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mixGroup
            // 
            this.mixGroup.Controls.Add(this.label4);
            this.mixGroup.Controls.Add(this.textBox1);
            this.mixGroup.Controls.Add(this.mixPanel);
            this.mixGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixGroup.Location = new System.Drawing.Point(0, 182);
            this.mixGroup.Name = "mixGroup";
            this.mixGroup.Size = new System.Drawing.Size(533, 313);
            this.mixGroup.TabIndex = 1;
            this.mixGroup.TabStop = false;
            this.mixGroup.Text = "Mix rules";
            this.mixGroup.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Filter";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(54, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // mixPanel
            // 
            this.mixPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mixPanel.Location = new System.Drawing.Point(-4, 45);
            this.mixPanel.Name = "mixPanel";
            this.mixPanel.Size = new System.Drawing.Size(533, 227);
            this.mixPanel.TabIndex = 0;
            this.mixPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MixPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MixBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 37);
            this.panel3.TabIndex = 2;
            // 
            // MixBtn
            // 
            this.MixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MixBtn.Location = new System.Drawing.Point(126, 3);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(257, 28);
            this.MixBtn.TabIndex = 0;
            this.MixBtn.Text = "Generate mixed handling!";
            this.MixBtn.UseVisualStyleBackColor = true;
            this.MixBtn.Click += new System.EventHandler(this.MixBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.mixGroup);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(533, 495);
            this.mainPanel.TabIndex = 3;
            // 
            // HandlingMixer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(533, 495);
            this.Controls.Add(this.mainPanel);
            this.MinimumSize = new System.Drawing.Size(549, 534);
            this.Name = "HandlingMixer";
            this.Text = "HandlingMixer (for GTA V)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mixGroup.ResumeLayout(false);
            this.mixGroup.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFileB;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button btnFileA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.GroupBox mixGroup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button MixBtn;
        private System.Windows.Forms.FlowLayoutPanel mixPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

