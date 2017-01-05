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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.setValueSelBtn = new System.Windows.Forms.Button();
            this.setTypeSelBtn = new System.Windows.Forms.Button();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.Propname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mixType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mixedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueOffsetCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueMultiplierCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customFormulaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximumValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.saveMixSetupBtn = new System.Windows.Forms.Button();
            this.loadMixSetupBtn = new System.Windows.Forms.Button();
            this.MixBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.setValuesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setMixedValue = new System.Windows.Forms.ToolStripMenuItem();
            this.setValueOffsetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setMultiplierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setCustomFormulaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setMinimumValueMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.selectAllBtn = new System.Windows.Forms.Button();
            this.SelectNoneBtn = new System.Windows.Forms.Button();
            this.showTooltipsCB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mixGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.setValuesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 182);
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
            this.panel2.Location = new System.Drawing.Point(634, 16);
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
            this.labelB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelB.Location = new System.Drawing.Point(26, 116);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(221, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "(None)";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // 
            // btnFileA
            // 
            this.btnFileA.Location = new System.Drawing.Point(90, 62);
            this.btnFileA.Name = "btnFileA";
            this.btnFileA.Size = new System.Drawing.Size(75, 23);
            this.btnFileA.TabIndex = 2;
            this.btnFileA.Text = "Select file A";
            this.btnFileA.UseVisualStyleBackColor = true;
            this.btnFileA.Click += new System.EventHandler(this.btnFileA_Click);
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(21, 116);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(212, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "(None)";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Handling file A";
            // 
            // mixGroup
            // 
            this.mixGroup.Controls.Add(this.showTooltipsCB);
            this.mixGroup.Controls.Add(this.SelectNoneBtn);
            this.mixGroup.Controls.Add(this.selectAllBtn);
            this.mixGroup.Controls.Add(this.setValueSelBtn);
            this.mixGroup.Controls.Add(this.setTypeSelBtn);
            this.mixGroup.Controls.Add(this.selectedLabel);
            this.mixGroup.Controls.Add(this.datagrid);
            this.mixGroup.Controls.Add(this.label4);
            this.mixGroup.Controls.Add(this.textBox1);
            this.mixGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mixGroup.Location = new System.Drawing.Point(0, 182);
            this.mixGroup.Name = "mixGroup";
            this.mixGroup.Size = new System.Drawing.Size(903, 354);
            this.mixGroup.TabIndex = 1;
            this.mixGroup.TabStop = false;
            this.mixGroup.Text = "Mix rules";
            // 
            // setValueSelBtn
            // 
            this.setValueSelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setValueSelBtn.Location = new System.Drawing.Point(806, 17);
            this.setValueSelBtn.Name = "setValueSelBtn";
            this.setValueSelBtn.Size = new System.Drawing.Size(91, 23);
            this.setValueSelBtn.TabIndex = 6;
            this.setValueSelBtn.Text = "Set values...";
            this.setValueSelBtn.UseVisualStyleBackColor = true;
            this.setValueSelBtn.Click += new System.EventHandler(this.setValueSelBtn_Click);
            // 
            // setTypeSelBtn
            // 
            this.setTypeSelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setTypeSelBtn.Location = new System.Drawing.Point(716, 17);
            this.setTypeSelBtn.Name = "setTypeSelBtn";
            this.setTypeSelBtn.Size = new System.Drawing.Size(84, 23);
            this.setTypeSelBtn.TabIndex = 5;
            this.setTypeSelBtn.Text = "Set mix type";
            this.setTypeSelBtn.UseVisualStyleBackColor = true;
            this.setTypeSelBtn.Click += new System.EventHandler(this.setTypeSelBtn_Click);
            // 
            // selectedLabel
            // 
            this.selectedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(622, 22);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(88, 13);
            this.selectedLabel.TabIndex = 4;
            this.selectedLabel.Text = "Selected: 0 items";
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propname,
            this.dataType,
            this.mixType,
            this.mixedValue,
            this.valueOffsetCol,
            this.ValueMultiplierCol,
            this.customFormulaCol,
            this.MinimumValueCol,
            this.MaximumValueCol});
            this.datagrid.Location = new System.Drawing.Point(0, 46);
            this.datagrid.Name = "datagrid";
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(900, 268);
            this.datagrid.TabIndex = 3;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            this.datagrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellEndEdit);
            this.datagrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellEnter);
            this.datagrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellLeave);
            this.datagrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellValueChanged);
            this.datagrid.SelectionChanged += new System.EventHandler(this.datagrid_SelectionChanged);
            this.datagrid.MouseLeave += new System.EventHandler(this.datagrid_MouseLeave);
            // 
            // Propname
            // 
            this.Propname.DataPropertyName = "propName";
            this.Propname.HeaderText = "Handling property";
            this.Propname.Name = "Propname";
            // 
            // dataType
            // 
            this.dataType.DataPropertyName = "dataType";
            this.dataType.HeaderText = "Data type";
            this.dataType.Name = "dataType";
            this.dataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // mixType
            // 
            this.mixType.DataPropertyName = "mixType";
            this.mixType.HeaderText = "Mix type";
            this.mixType.Name = "mixType";
            this.mixType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mixType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // mixedValue
            // 
            this.mixedValue.DataPropertyName = "mixedValue";
            this.mixedValue.HeaderText = "Mixed Value";
            this.mixedValue.Name = "mixedValue";
            // 
            // valueOffsetCol
            // 
            this.valueOffsetCol.DataPropertyName = "valueOffset";
            this.valueOffsetCol.HeaderText = "Value Offset";
            this.valueOffsetCol.Name = "valueOffsetCol";
            // 
            // ValueMultiplierCol
            // 
            this.ValueMultiplierCol.DataPropertyName = "ValueMultiplier";
            this.ValueMultiplierCol.HeaderText = "Value Multiplier";
            this.ValueMultiplierCol.Name = "ValueMultiplierCol";
            // 
            // customFormulaCol
            // 
            this.customFormulaCol.DataPropertyName = "customFormula";
            this.customFormulaCol.HeaderText = "Custom formula";
            this.customFormulaCol.Name = "customFormulaCol";
            // 
            // MinimumValueCol
            // 
            this.MinimumValueCol.DataPropertyName = "MinimumValue";
            this.MinimumValueCol.HeaderText = "Minimum value";
            this.MinimumValueCol.Name = "MinimumValueCol";
            // 
            // MaximumValueCol
            // 
            this.MaximumValueCol.DataPropertyName = "MaximumValue";
            this.MaximumValueCol.HeaderText = "Maximum value";
            this.MaximumValueCol.Name = "MaximumValueCol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Filter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.saveMixSetupBtn);
            this.panel3.Controls.Add(this.loadMixSetupBtn);
            this.panel3.Controls.Add(this.MixBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 499);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 37);
            this.panel3.TabIndex = 2;
            // 
            // saveMixSetupBtn
            // 
            this.saveMixSetupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveMixSetupBtn.Location = new System.Drawing.Point(759, 6);
            this.saveMixSetupBtn.Name = "saveMixSetupBtn";
            this.saveMixSetupBtn.Size = new System.Drawing.Size(132, 23);
            this.saveMixSetupBtn.TabIndex = 2;
            this.saveMixSetupBtn.Text = "Save mix setup";
            this.saveMixSetupBtn.UseVisualStyleBackColor = true;
            this.saveMixSetupBtn.Click += new System.EventHandler(this.saveMixSetupBtn_Click);
            // 
            // loadMixSetupBtn
            // 
            this.loadMixSetupBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadMixSetupBtn.Location = new System.Drawing.Point(614, 6);
            this.loadMixSetupBtn.Name = "loadMixSetupBtn";
            this.loadMixSetupBtn.Size = new System.Drawing.Size(132, 23);
            this.loadMixSetupBtn.TabIndex = 1;
            this.loadMixSetupBtn.Text = "Load mix setup";
            this.loadMixSetupBtn.UseVisualStyleBackColor = true;
            this.loadMixSetupBtn.Click += new System.EventHandler(this.loadMixSetupBtn_Click);
            // 
            // MixBtn
            // 
            this.MixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MixBtn.Location = new System.Drawing.Point(12, 3);
            this.MixBtn.Name = "MixBtn";
            this.MixBtn.Size = new System.Drawing.Size(413, 28);
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
            this.mainPanel.Size = new System.Drawing.Size(903, 536);
            this.mainPanel.TabIndex = 3;
            // 
            // setValuesMenu
            // 
            this.setValuesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMixedValue,
            this.setValueOffsetMenu,
            this.setMultiplierMenu,
            this.setCustomFormulaMenu,
            this.setMinimumValueMenu,
            this.toolStripMenuItem1});
            this.setValuesMenu.Name = "setValuesMenu";
            this.setValuesMenu.Size = new System.Drawing.Size(179, 136);
            this.setValuesMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // setMixedValue
            // 
            this.setMixedValue.Name = "setMixedValue";
            this.setMixedValue.Size = new System.Drawing.Size(178, 22);
            this.setMixedValue.Text = "Set mixed value";
            this.setMixedValue.Click += new System.EventHandler(this.setMixedValue_Click);
            // 
            // setValueOffsetMenu
            // 
            this.setValueOffsetMenu.Name = "setValueOffsetMenu";
            this.setValueOffsetMenu.Size = new System.Drawing.Size(178, 22);
            this.setValueOffsetMenu.Text = "Set Value offset";
            this.setValueOffsetMenu.Click += new System.EventHandler(this.setValueOffsetMenu_Click);
            // 
            // setMultiplierMenu
            // 
            this.setMultiplierMenu.Name = "setMultiplierMenu";
            this.setMultiplierMenu.Size = new System.Drawing.Size(178, 22);
            this.setMultiplierMenu.Text = "Set Value Multiplier";
            this.setMultiplierMenu.Click += new System.EventHandler(this.setMultiplierMenu_Click);
            // 
            // setCustomFormulaMenu
            // 
            this.setCustomFormulaMenu.Name = "setCustomFormulaMenu";
            this.setCustomFormulaMenu.Size = new System.Drawing.Size(178, 22);
            this.setCustomFormulaMenu.Text = "Set custom formula";
            this.setCustomFormulaMenu.Click += new System.EventHandler(this.setCustomFormulaMenu_Click);
            // 
            // setMinimumValueMenu
            // 
            this.setMinimumValueMenu.Name = "setMinimumValueMenu";
            this.setMinimumValueMenu.Size = new System.Drawing.Size(178, 22);
            this.setMinimumValueMenu.Text = "Set Minimum Value";
            this.setMinimumValueMenu.Click += new System.EventHandler(this.setMinimumValueMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem1.Text = "Set Maximum Value";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpTooltip
            // 
            this.helpTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.helpTooltip.ToolTipTitle = "Info";
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectAllBtn.Location = new System.Drawing.Point(417, 17);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(74, 23);
            this.selectAllBtn.TabIndex = 7;
            this.selectAllBtn.Text = "Select All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // SelectNoneBtn
            // 
            this.SelectNoneBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SelectNoneBtn.Location = new System.Drawing.Point(498, 17);
            this.SelectNoneBtn.Name = "SelectNoneBtn";
            this.SelectNoneBtn.Size = new System.Drawing.Size(74, 23);
            this.SelectNoneBtn.TabIndex = 8;
            this.SelectNoneBtn.Text = "Select None";
            this.SelectNoneBtn.UseVisualStyleBackColor = true;
            this.SelectNoneBtn.Click += new System.EventHandler(this.SelectNoneBtn_Click);
            // 
            // showTooltipsCB
            // 
            this.showTooltipsCB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.showTooltipsCB.AutoSize = true;
            this.showTooltipsCB.Checked = true;
            this.showTooltipsCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTooltipsCB.Location = new System.Drawing.Point(289, 22);
            this.showTooltipsCB.Name = "showTooltipsCB";
            this.showTooltipsCB.Size = new System.Drawing.Size(119, 17);
            this.showTooltipsCB.TabIndex = 9;
            this.showTooltipsCB.Text = "Display help tooltips";
            this.showTooltipsCB.UseVisualStyleBackColor = true;
            this.showTooltipsCB.CheckedChanged += new System.EventHandler(this.showTooltipsCB_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 575);
            this.Name = "Form1";
            this.Text = "HandlingMixer (for GTA V)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mixGroup.ResumeLayout(false);
            this.mixGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.setValuesMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Button setValueSelBtn;
        private System.Windows.Forms.Button setTypeSelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
        private System.Windows.Forms.DataGridViewComboBoxColumn mixType;
        private System.Windows.Forms.DataGridViewTextBoxColumn mixedValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOffsetCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueMultiplierCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn customFormulaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumValueCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximumValueCol;
        private System.Windows.Forms.ContextMenuStrip setValuesMenu;
        private System.Windows.Forms.ToolStripMenuItem setMixedValue;
        private System.Windows.Forms.ToolStripMenuItem setValueOffsetMenu;
        private System.Windows.Forms.ToolStripMenuItem setMultiplierMenu;
        private System.Windows.Forms.ToolStripMenuItem setCustomFormulaMenu;
        private System.Windows.Forms.ToolStripMenuItem setMinimumValueMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button saveMixSetupBtn;
        private System.Windows.Forms.Button loadMixSetupBtn;
        private System.Windows.Forms.ToolTip helpTooltip;
        private System.Windows.Forms.Button SelectNoneBtn;
        private System.Windows.Forms.Button selectAllBtn;
        private System.Windows.Forms.CheckBox showTooltipsCB;
    }
}

