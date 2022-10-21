namespace Electre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.criteriasTab = new System.Windows.Forms.TabPage();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.criteriaLenghtLB = new System.Windows.Forms.Label();
            this.criteriaWeightLB = new System.Windows.Forms.Label();
            this.criteriaTitleLB = new System.Windows.Forms.Label();
            this.criteriaLenghtTB = new System.Windows.Forms.TextBox();
            this.criteriaWeightTB = new System.Windows.Forms.TextBox();
            this.criteriaTitleTB = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.dataGVCriteries = new System.Windows.Forms.DataGridView();
            this.criteriaTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criteriaWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criteriaLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternativesTab = new System.Windows.Forms.TabPage();
            this.dataGVOptions = new System.Windows.Forms.DataGridView();
            this.optionTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solutionTab = new System.Windows.Forms.TabPage();
            this.dataGVNoconcurrence = new System.Windows.Forms.DataGridView();
            this.dataGVConcurrence = new System.Windows.Forms.DataGridView();
            this.noconcurrenceLB = new System.Windows.Forms.Label();
            this.rangeLB = new System.Windows.Forms.Label();
            this.coresLB = new System.Windows.Forms.Label();
            this.concurrenceLB = new System.Windows.Forms.Label();
            this.solutionButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.criteriasTab.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCriteries)).BeginInit();
            this.alternativesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOptions)).BeginInit();
            this.solutionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNoconcurrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVConcurrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.criteriasTab);
            this.tabControl.Controls.Add(this.alternativesTab);
            this.tabControl.Controls.Add(this.solutionTab);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1146, 526);
            this.tabControl.TabIndex = 0;
            // 
            // criteriasTab
            // 
            this.criteriasTab.Controls.Add(this.cancelButton);
            this.criteriasTab.Controls.Add(this.applyButton);
            this.criteriasTab.Controls.Add(this.criteriaLenghtLB);
            this.criteriasTab.Controls.Add(this.criteriaWeightLB);
            this.criteriasTab.Controls.Add(this.criteriaTitleLB);
            this.criteriasTab.Controls.Add(this.criteriaLenghtTB);
            this.criteriasTab.Controls.Add(this.criteriaWeightTB);
            this.criteriasTab.Controls.Add(this.criteriaTitleTB);
            this.criteriasTab.Controls.Add(this.toolStrip1);
            this.criteriasTab.Controls.Add(this.dataGVCriteries);
            this.criteriasTab.Location = new System.Drawing.Point(4, 29);
            this.criteriasTab.Name = "criteriasTab";
            this.criteriasTab.Padding = new System.Windows.Forms.Padding(3);
            this.criteriasTab.Size = new System.Drawing.Size(1138, 493);
            this.criteriasTab.TabIndex = 0;
            this.criteriasTab.Text = "Критерии";
            this.criteriasTab.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(1025, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 29);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Enabled = false;
            this.applyButton.Location = new System.Drawing.Point(909, 151);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 29);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // criteriaLenghtLB
            // 
            this.criteriaLenghtLB.AutoSize = true;
            this.criteriaLenghtLB.Enabled = false;
            this.criteriaLenghtLB.Location = new System.Drawing.Point(776, 111);
            this.criteriaLenghtLB.Name = "criteriaLenghtLB";
            this.criteriaLenghtLB.Size = new System.Drawing.Size(117, 20);
            this.criteriaLenghtLB.TabIndex = 7;
            this.criteriaLenghtLB.Text = "Длина шкалы, L";
            // 
            // criteriaWeightLB
            // 
            this.criteriaWeightLB.AutoSize = true;
            this.criteriaWeightLB.Enabled = false;
            this.criteriaWeightLB.Location = new System.Drawing.Point(773, 76);
            this.criteriaWeightLB.Name = "criteriaWeightLB";
            this.criteriaWeightLB.Size = new System.Drawing.Size(120, 20);
            this.criteriaWeightLB.TabIndex = 6;
            this.criteriaWeightLB.Text = "Вес критерия, w";
            // 
            // criteriaTitleLB
            // 
            this.criteriaTitleLB.AutoSize = true;
            this.criteriaTitleLB.Enabled = false;
            this.criteriaTitleLB.Location = new System.Drawing.Point(747, 41);
            this.criteriaTitleLB.Name = "criteriaTitleLB";
            this.criteriaTitleLB.Size = new System.Drawing.Size(146, 20);
            this.criteriaTitleLB.TabIndex = 5;
            this.criteriaTitleLB.Text = "Название критерия";
            // 
            // criteriaLenghtTB
            // 
            this.criteriaLenghtTB.Enabled = false;
            this.criteriaLenghtTB.Location = new System.Drawing.Point(900, 108);
            this.criteriaLenghtTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.criteriaLenghtTB.Name = "criteriaLenghtTB";
            this.criteriaLenghtTB.Size = new System.Drawing.Size(225, 27);
            this.criteriaLenghtTB.TabIndex = 4;
            this.criteriaLenghtTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.criteriaLenghtTB_KeyPress);
            // 
            // criteriaWeightTB
            // 
            this.criteriaWeightTB.Enabled = false;
            this.criteriaWeightTB.Location = new System.Drawing.Point(900, 73);
            this.criteriaWeightTB.Margin = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.criteriaWeightTB.Name = "criteriaWeightTB";
            this.criteriaWeightTB.Size = new System.Drawing.Size(225, 27);
            this.criteriaWeightTB.TabIndex = 3;
            this.criteriaWeightTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.criteriaWeightTB_KeyPress);
            // 
            // criteriaTitleTB
            // 
            this.criteriaTitleTB.Enabled = false;
            this.criteriaTitleTB.Location = new System.Drawing.Point(900, 38);
            this.criteriaTitleTB.Margin = new System.Windows.Forms.Padding(4, 8, 8, 4);
            this.criteriaTitleTB.Name = "criteriaTitleTB";
            this.criteriaTitleTB.Size = new System.Drawing.Size(225, 27);
            this.criteriaTitleTB.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripSeparator1,
            this.toolStripButtonEdit,
            this.toolStripSeparator2,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1132, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAdd.Image")));
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonAdd.Text = "Добавить";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEdit.Image")));
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonEdit.Text = "Редактировать";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelete.Text = "Удалить";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // dataGVCriteries
            // 
            this.dataGVCriteries.AllowUserToAddRows = false;
            this.dataGVCriteries.AllowUserToDeleteRows = false;
            this.dataGVCriteries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCriteries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criteriaTitle,
            this.criteriaWeight,
            this.criteriaLenght});
            this.dataGVCriteries.Location = new System.Drawing.Point(3, 33);
            this.dataGVCriteries.Margin = new System.Windows.Forms.Padding(3, 3, 12, 12);
            this.dataGVCriteries.Name = "dataGVCriteries";
            this.dataGVCriteries.ReadOnly = true;
            this.dataGVCriteries.RowHeadersWidth = 51;
            this.dataGVCriteries.RowTemplate.Height = 29;
            this.dataGVCriteries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVCriteries.Size = new System.Drawing.Size(729, 445);
            this.dataGVCriteries.TabIndex = 0;
            // 
            // criteriaTitle
            // 
            this.criteriaTitle.HeaderText = "Название критерия";
            this.criteriaTitle.MinimumWidth = 6;
            this.criteriaTitle.Name = "criteriaTitle";
            this.criteriaTitle.ReadOnly = true;
            this.criteriaTitle.Width = 175;
            // 
            // criteriaWeight
            // 
            this.criteriaWeight.HeaderText = "Вес критерия";
            this.criteriaWeight.MinimumWidth = 6;
            this.criteriaWeight.Name = "criteriaWeight";
            this.criteriaWeight.ReadOnly = true;
            this.criteriaWeight.Width = 175;
            // 
            // criteriaLenght
            // 
            this.criteriaLenght.HeaderText = "Длина шкалы";
            this.criteriaLenght.MinimumWidth = 6;
            this.criteriaLenght.Name = "criteriaLenght";
            this.criteriaLenght.ReadOnly = true;
            this.criteriaLenght.Width = 175;
            // 
            // alternativesTab
            // 
            this.alternativesTab.Controls.Add(this.dataGVOptions);
            this.alternativesTab.Location = new System.Drawing.Point(4, 29);
            this.alternativesTab.Name = "alternativesTab";
            this.alternativesTab.Padding = new System.Windows.Forms.Padding(3);
            this.alternativesTab.Size = new System.Drawing.Size(1138, 493);
            this.alternativesTab.TabIndex = 1;
            this.alternativesTab.Text = "Альтернативы";
            this.alternativesTab.UseVisualStyleBackColor = true;
            // 
            // dataGVOptions
            // 
            this.dataGVOptions.AllowUserToDeleteRows = false;
            this.dataGVOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optionTitle});
            this.dataGVOptions.Location = new System.Drawing.Point(6, 6);
            this.dataGVOptions.Margin = new System.Windows.Forms.Padding(3, 3, 12, 12);
            this.dataGVOptions.Name = "dataGVOptions";
            this.dataGVOptions.RowHeadersWidth = 51;
            this.dataGVOptions.RowTemplate.Height = 29;
            this.dataGVOptions.Size = new System.Drawing.Size(729, 472);
            this.dataGVOptions.TabIndex = 0;
            // 
            // optionTitle
            // 
            this.optionTitle.HeaderText = "Альтернативы";
            this.optionTitle.MinimumWidth = 6;
            this.optionTitle.Name = "optionTitle";
            this.optionTitle.Width = 125;
            // 
            // solutionTab
            // 
            this.solutionTab.Controls.Add(this.dataGVNoconcurrence);
            this.solutionTab.Controls.Add(this.dataGVConcurrence);
            this.solutionTab.Controls.Add(this.noconcurrenceLB);
            this.solutionTab.Controls.Add(this.rangeLB);
            this.solutionTab.Controls.Add(this.coresLB);
            this.solutionTab.Controls.Add(this.concurrenceLB);
            this.solutionTab.Controls.Add(this.solutionButton);
            this.solutionTab.Location = new System.Drawing.Point(4, 29);
            this.solutionTab.Name = "solutionTab";
            this.solutionTab.Size = new System.Drawing.Size(1138, 493);
            this.solutionTab.TabIndex = 2;
            this.solutionTab.Text = "Решение";
            this.solutionTab.UseVisualStyleBackColor = true;
            // 
            // dataGVNoconcurrence
            // 
            this.dataGVNoconcurrence.AllowUserToAddRows = false;
            this.dataGVNoconcurrence.AllowUserToDeleteRows = false;
            this.dataGVNoconcurrence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVNoconcurrence.Location = new System.Drawing.Point(474, 73);
            this.dataGVNoconcurrence.Name = "dataGVNoconcurrence";
            this.dataGVNoconcurrence.ReadOnly = true;
            this.dataGVNoconcurrence.RowHeadersWidth = 51;
            this.dataGVNoconcurrence.RowTemplate.Height = 29;
            this.dataGVNoconcurrence.Size = new System.Drawing.Size(440, 300);
            this.dataGVNoconcurrence.TabIndex = 7;
            // 
            // dataGVConcurrence
            // 
            this.dataGVConcurrence.AllowUserToAddRows = false;
            this.dataGVConcurrence.AllowUserToDeleteRows = false;
            this.dataGVConcurrence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVConcurrence.Location = new System.Drawing.Point(15, 73);
            this.dataGVConcurrence.Name = "dataGVConcurrence";
            this.dataGVConcurrence.ReadOnly = true;
            this.dataGVConcurrence.RowHeadersWidth = 51;
            this.dataGVConcurrence.RowTemplate.Height = 29;
            this.dataGVConcurrence.Size = new System.Drawing.Size(440, 300);
            this.dataGVConcurrence.TabIndex = 6;
            // 
            // noconcurrenceLB
            // 
            this.noconcurrenceLB.AutoSize = true;
            this.noconcurrenceLB.Location = new System.Drawing.Point(474, 50);
            this.noconcurrenceLB.Name = "noconcurrenceLB";
            this.noconcurrenceLB.Size = new System.Drawing.Size(220, 20);
            this.noconcurrenceLB.TabIndex = 5;
            this.noconcurrenceLB.Text = "Таблица индексов несогласия";
            // 
            // rangeLB
            // 
            this.rangeLB.AutoSize = true;
            this.rangeLB.Location = new System.Drawing.Point(474, 385);
            this.rangeLB.Name = "rangeLB";
            this.rangeLB.Size = new System.Drawing.Size(205, 20);
            this.rangeLB.TabIndex = 3;
            this.rangeLB.Text = "Ранжирование альтернатив";
            // 
            // coresLB
            // 
            this.coresLB.AutoSize = true;
            this.coresLB.Location = new System.Drawing.Point(15, 385);
            this.coresLB.Name = "coresLB";
            this.coresLB.Size = new System.Drawing.Size(43, 20);
            this.coresLB.TabIndex = 2;
            this.coresLB.Text = "Ядра";
            // 
            // concurrenceLB
            // 
            this.concurrenceLB.AutoSize = true;
            this.concurrenceLB.Location = new System.Drawing.Point(15, 50);
            this.concurrenceLB.Name = "concurrenceLB";
            this.concurrenceLB.Size = new System.Drawing.Size(203, 20);
            this.concurrenceLB.TabIndex = 1;
            this.concurrenceLB.Text = "Таблица индексов согласия";
            // 
            // solutionButton
            // 
            this.solutionButton.Location = new System.Drawing.Point(15, 15);
            this.solutionButton.Name = "solutionButton";
            this.solutionButton.Size = new System.Drawing.Size(100, 29);
            this.solutionButton.TabIndex = 0;
            this.solutionButton.Text = "Рассчитать";
            this.solutionButton.UseVisualStyleBackColor = true;
            this.solutionButton.Click += new System.EventHandler(this.solutionButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 540);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "ElectreMethod";
            this.tabControl.ResumeLayout(false);
            this.criteriasTab.ResumeLayout(false);
            this.criteriasTab.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCriteries)).EndInit();
            this.alternativesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOptions)).EndInit();
            this.solutionTab.ResumeLayout(false);
            this.solutionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVNoconcurrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVConcurrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage criteriasTab;
        private TabPage alternativesTab;
        private TabPage solutionTab;
        private ToolStrip toolStrip1;
        private DataGridView dataGVCriteries;
        private ToolStripButton toolStripButtonAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonDelete;
        private Button cancelButton;
        private Button applyButton;
        private Label criteriaLenghtLB;
        private Label criteriaWeightLB;
        private Label criteriaTitleLB;
        private TextBox criteriaLenghtTB;
        private TextBox criteriaWeightTB;
        private TextBox criteriaTitleTB;
        private DataGridViewTextBoxColumn criteriaTitle;
        private DataGridViewTextBoxColumn criteriaWeight;
        private DataGridViewTextBoxColumn criteriaLenght;
        private DataGridView dataGVOptions;
        private DataGridViewTextBoxColumn optionTitle;
        private Button solutionButton;
        private Label concurrenceLB;
        private Label coresLB;
        private ErrorProvider errorProvider1;
        private Label rangeLB;
        private Label noconcurrenceLB;
        private DataGridView dataGVConcurrence;
        private DataGridView dataGVNoconcurrence;
    }
}