namespace TPR_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbProb = new System.Windows.Forms.RadioButton();
            this.rbOr = new System.Windows.Forms.RadioButton();
            this.rbAnd = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRootName = new System.Windows.Forms.TextBox();
            this.cbRootType = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.tbFAL = new System.Windows.Forms.TextBox();
            this.tbCalc = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOcenka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.lblProb = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(315, 29);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(746, 383);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProb);
            this.groupBox1.Controls.Add(this.rbOr);
            this.groupBox1.Controls.Add(this.rbAnd);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(22, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "События";
            // 
            // rbProb
            // 
            this.rbProb.AutoSize = true;
            this.rbProb.Checked = true;
            this.rbProb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.rbProb.Location = new System.Drawing.Point(126, 19);
            this.rbProb.Name = "rbProb";
            this.rbProb.Size = new System.Drawing.Size(126, 22);
            this.rbProb.TabIndex = 2;
            this.rbProb.TabStop = true;
            this.rbProb.Text = "Иниц. соб.";
            this.rbProb.UseVisualStyleBackColor = true;
            // 
            // rbOr
            // 
            this.rbOr.AutoSize = true;
            this.rbOr.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.rbOr.Location = new System.Drawing.Point(61, 19);
            this.rbOr.Name = "rbOr";
            this.rbOr.Size = new System.Drawing.Size(56, 22);
            this.rbOr.TabIndex = 1;
            this.rbOr.Text = "ИЛИ";
            this.rbOr.UseVisualStyleBackColor = true;
            // 
            // rbAnd
            // 
            this.rbAnd.AutoSize = true;
            this.rbAnd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.rbAnd.Location = new System.Drawing.Point(6, 19);
            this.rbAnd.Name = "rbAnd";
            this.rbAnd.Size = new System.Drawing.Size(36, 22);
            this.rbAnd.TabIndex = 0;
            this.rbAnd.Text = "И";
            this.rbAnd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(94, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(214, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(201, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название конечного события";
            // 
            // tbRootName
            // 
            this.tbRootName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRootName.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.tbRootName.Location = new System.Drawing.Point(22, 51);
            this.tbRootName.Name = "tbRootName";
            this.tbRootName.Size = new System.Drawing.Size(286, 26);
            this.tbRootName.TabIndex = 4;
            this.tbRootName.Text = "Конечное событие";
            this.tbRootName.TextChanged += new System.EventHandler(this.tbRootName_TextChanged);
            // 
            // cbRootType
            // 
            this.cbRootType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRootType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.cbRootType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRootType.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.cbRootType.FormattingEnabled = true;
            this.cbRootType.Items.AddRange(new object[] {
            "И",
            "ИЛИ"});
            this.cbRootType.Location = new System.Drawing.Point(187, 109);
            this.cbRootType.Name = "cbRootType";
            this.cbRootType.Size = new System.Drawing.Size(121, 26);
            this.cbRootType.TabIndex = 6;
            this.cbRootType.SelectedIndexChanged += new System.EventHandler(this.cbRootType_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalc.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalc.Location = new System.Drawing.Point(22, 355);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(286, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // tbFAL
            // 
            this.tbFAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFAL.Location = new System.Drawing.Point(22, 467);
            this.tbFAL.Multiline = true;
            this.tbFAL.Name = "tbFAL";
            this.tbFAL.ReadOnly = true;
            this.tbFAL.Size = new System.Drawing.Size(331, 92);
            this.tbFAL.TabIndex = 8;
            // 
            // tbCalc
            // 
            this.tbCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCalc.Location = new System.Drawing.Point(376, 465);
            this.tbCalc.Multiline = true;
            this.tbCalc.Name = "tbCalc";
            this.tbCalc.ReadOnly = true;
            this.tbCalc.Size = new System.Drawing.Size(328, 94);
            this.tbCalc.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1073, 26);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.импортToolStripMenuItem.Text = "Открыть";
            this.импортToolStripMenuItem.Click += new System.EventHandler(this.импортToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.экспортToolStripMenuItem.Text = "Сохранить";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            this.ofd.Filter = "Txt |*.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Txt |*.txt";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Функция алгебры логики";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(373, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Вероятностная функция";
            // 
            // lblOcenka
            // 
            this.lblOcenka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOcenka.AutoSize = true;
            this.lblOcenka.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblOcenka.Location = new System.Drawing.Point(728, 502);
            this.lblOcenka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcenka.Name = "lblOcenka";
            this.lblOcenka.Size = new System.Drawing.Size(158, 18);
            this.lblOcenka.TabIndex = 12;
            this.lblOcenka.Text = "Оценка риска: -";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(19, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Величина ущерба";
            // 
            // nudCost
            // 
            this.nudCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.nudCost.Location = new System.Drawing.Point(188, 165);
            this.nudCost.Margin = new System.Windows.Forms.Padding(2);
            this.nudCost.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(120, 26);
            this.nudCost.TabIndex = 13;
            this.nudCost.ThousandsSeparator = true;
            // 
            // lblProb
            // 
            this.lblProb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProb.AutoSize = true;
            this.lblProb.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblProb.Location = new System.Drawing.Point(728, 465);
            this.lblProb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProb.Name = "lblProb";
            this.lblProb.Size = new System.Drawing.Size(208, 18);
            this.lblProb.TabIndex = 12;
            this.lblProb.Text = "Вероятность риска: -";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(94, 311);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(101, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Вид условия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1073, 584);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProb);
            this.Controls.Add(this.lblOcenka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCalc);
            this.Controls.Add(this.tbFAL);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cbRootType);
            this.Controls.Add(this.tbRootName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(770, 540);
            this.Name = "Form1";
            this.Text = "Логико-вероятностный метод";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbProb;
        private System.Windows.Forms.RadioButton rbOr;
        private System.Windows.Forms.RadioButton rbAnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRootName;
        private System.Windows.Forms.ComboBox cbRootType;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox tbFAL;
        private System.Windows.Forms.TextBox tbCalc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOcenka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label lblProb;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
    }
}

