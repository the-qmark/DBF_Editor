
namespace DBF_Editor
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opendbfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTodbfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTodbfcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoPanel1 = new System.Windows.Forms.Panel();
            this.selectedSumAndRowsLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalRowsLabel1 = new System.Windows.Forms.Label();
            this.totalSumLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsPanel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moveButton1 = new System.Windows.Forms.ToolStripButton();
            this.editButton1 = new System.Windows.Forms.ToolStripButton();
            this.cloneButton1 = new System.Windows.Forms.ToolStripButton();
            this.deleteButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.infoPanel2 = new System.Windows.Forms.Panel();
            this.selectedSumAndRowsLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalRowsLabel2 = new System.Windows.Forms.Label();
            this.totalSumLabel2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nameTextBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.moveButton2 = new System.Windows.Forms.ToolStripButton();
            this.editButton2 = new System.Windows.Forms.ToolStripButton();
            this.cloneButton2 = new System.Windows.Forms.ToolStripButton();
            this.deleteButton2 = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoPanel1.SuspendLayout();
            this.buttonsPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.infoPanel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Реестр DBF |*.dbf";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Directory | directory";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 719);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1234, 27);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opendbfToolStripMenuItem,
            this.saveTodbfToolStripMenuItem,
            this.saveTodbfcsvToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // opendbfToolStripMenuItem
            // 
            this.opendbfToolStripMenuItem.Image = global::DBF_Editor.Properties.Resources.open;
            this.opendbfToolStripMenuItem.Name = "opendbfToolStripMenuItem";
            this.opendbfToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.opendbfToolStripMenuItem.Text = "Открыть [dbf]";
            this.opendbfToolStripMenuItem.Click += new System.EventHandler(this.открытьdbfToolStripMenuItem_Click);
            // 
            // saveTodbfToolStripMenuItem
            // 
            this.saveTodbfToolStripMenuItem.Enabled = false;
            this.saveTodbfToolStripMenuItem.Image = global::DBF_Editor.Properties.Resources.saveDBF;
            this.saveTodbfToolStripMenuItem.Name = "saveTodbfToolStripMenuItem";
            this.saveTodbfToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.saveTodbfToolStripMenuItem.Text = "Сохранить в [dbf]";
            this.saveTodbfToolStripMenuItem.Click += new System.EventHandler(this.saveTodbfToolStripMenuItem_Click);
            // 
            // saveTodbfcsvToolStripMenuItem
            // 
            this.saveTodbfcsvToolStripMenuItem.Enabled = false;
            this.saveTodbfcsvToolStripMenuItem.Image = global::DBF_Editor.Properties.Resources.saveCSV;
            this.saveTodbfcsvToolStripMenuItem.Name = "saveTodbfcsvToolStripMenuItem";
            this.saveTodbfcsvToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.saveTodbfcsvToolStripMenuItem.Text = "Сохранить в [dbf + csv]";
            this.saveTodbfcsvToolStripMenuItem.Click += new System.EventHandler(this.saveTodbfcsvToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(234, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidSelectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // solidSelectionToolStripMenuItem
            // 
            this.solidSelectionToolStripMenuItem.CheckOnClick = true;
            this.solidSelectionToolStripMenuItem.Name = "solidSelectionToolStripMenuItem";
            this.solidSelectionToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.solidSelectionToolStripMenuItem.Text = "\"Сплошное\" выделение";
            this.solidSelectionToolStripMenuItem.ToolTipText = "Автоматически будут выделяться все строки выше выбранной";
            this.solidSelectionToolStripMenuItem.Click += new System.EventHandler(this.solidSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Enabled = false;
            this.настройкиToolStripMenuItem.Image = global::DBF_Editor.Properties.Resources.settings;
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::DBF_Editor.Properties.Resources.about;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(919, 617);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dataGridView1);
            this.mainSplitContainer.Panel1.Controls.Add(this.infoPanel1);
            this.mainSplitContainer.Panel1.Controls.Add(this.buttonsPanel1);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dataGridView2);
            this.mainSplitContainer.Panel2.Controls.Add(this.infoPanel2);
            this.mainSplitContainer.Panel2.Controls.Add(this.toolStrip2);
            this.mainSplitContainer.Size = new System.Drawing.Size(1234, 692);
            this.mainSplitContainer.SplitterDistance = 604;
            this.mainSplitContainer.SplitterWidth = 10;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(604, 506);
            this.dataGridView1.TabIndex = 2;
            // 
            // infoPanel1
            // 
            this.infoPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.infoPanel1.Controls.Add(this.selectedSumAndRowsLabel1);
            this.infoPanel1.Controls.Add(this.label6);
            this.infoPanel1.Controls.Add(this.totalRowsLabel1);
            this.infoPanel1.Controls.Add(this.totalSumLabel1);
            this.infoPanel1.Controls.Add(this.label3);
            this.infoPanel1.Controls.Add(this.label2);
            this.infoPanel1.Controls.Add(this.nameTextBox1);
            this.infoPanel1.Controls.Add(this.label1);
            this.infoPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel1.Location = new System.Drawing.Point(0, 79);
            this.infoPanel1.Name = "infoPanel1";
            this.infoPanel1.Size = new System.Drawing.Size(604, 107);
            this.infoPanel1.TabIndex = 1;
            // 
            // selectedSumAndRowsLabel1
            // 
            this.selectedSumAndRowsLabel1.AutoSize = true;
            this.selectedSumAndRowsLabel1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedSumAndRowsLabel1.Location = new System.Drawing.Point(119, 78);
            this.selectedSumAndRowsLabel1.Name = "selectedSumAndRowsLabel1";
            this.selectedSumAndRowsLabel1.Size = new System.Drawing.Size(71, 23);
            this.selectedSumAndRowsLabel1.TabIndex = 7;
            this.selectedSumAndRowsLabel1.Text = "0.00 (0)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "ВЫДЕЛЕНО:";
            // 
            // totalRowsLabel1
            // 
            this.totalRowsLabel1.AutoSize = true;
            this.totalRowsLabel1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalRowsLabel1.Location = new System.Drawing.Point(119, 58);
            this.totalRowsLabel1.Name = "totalRowsLabel1";
            this.totalRowsLabel1.Size = new System.Drawing.Size(20, 23);
            this.totalRowsLabel1.TabIndex = 5;
            this.totalRowsLabel1.Text = "0";
            // 
            // totalSumLabel1
            // 
            this.totalSumLabel1.AutoSize = true;
            this.totalSumLabel1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSumLabel1.Location = new System.Drawing.Point(119, 38);
            this.totalSumLabel1.Name = "totalSumLabel1";
            this.totalSumLabel1.Size = new System.Drawing.Size(45, 23);
            this.totalSumLabel1.TabIndex = 4;
            this.totalSumLabel1.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Строк:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сумма:";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox1.Location = new System.Drawing.Point(123, 6);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Size = new System.Drawing.Size(116, 30);
            this.nameTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // buttonsPanel1
            // 
            this.buttonsPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonsPanel1.Controls.Add(this.toolStrip1);
            this.buttonsPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsPanel1.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel1.Name = "buttonsPanel1";
            this.buttonsPanel1.Size = new System.Drawing.Size(604, 79);
            this.buttonsPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveButton1,
            this.editButton1,
            this.cloneButton1,
            this.deleteButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(604, 79);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moveButton1
            // 
            this.moveButton1.AutoSize = false;
            this.moveButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveButton1.Enabled = false;
            this.moveButton1.Image = global::DBF_Editor.Properties.Resources.moveToRight;
            this.moveButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moveButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveButton1.Name = "moveButton1";
            this.moveButton1.Size = new System.Drawing.Size(72, 76);
            this.moveButton1.Text = "toolStripButton1";
            this.moveButton1.ToolTipText = "Переместить";
            // 
            // editButton1
            // 
            this.editButton1.AutoSize = false;
            this.editButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton1.Enabled = false;
            this.editButton1.Image = global::DBF_Editor.Properties.Resources.edit;
            this.editButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(72, 76);
            this.editButton1.Text = "toolStripButton1";
            this.editButton1.ToolTipText = "Редактировать";
            // 
            // cloneButton1
            // 
            this.cloneButton1.AutoSize = false;
            this.cloneButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cloneButton1.Enabled = false;
            this.cloneButton1.Image = global::DBF_Editor.Properties.Resources.clone;
            this.cloneButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cloneButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cloneButton1.Name = "cloneButton1";
            this.cloneButton1.Size = new System.Drawing.Size(72, 76);
            this.cloneButton1.Text = "toolStripButton1";
            this.cloneButton1.ToolTipText = "Клонировать";
            // 
            // deleteButton1
            // 
            this.deleteButton1.AutoSize = false;
            this.deleteButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton1.Enabled = false;
            this.deleteButton1.Image = global::DBF_Editor.Properties.Resources.delete;
            this.deleteButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(72, 76);
            this.deleteButton1.Text = "toolStripButton1";
            this.deleteButton1.ToolTipText = "Удалить";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(620, 506);
            this.dataGridView2.TabIndex = 3;
            // 
            // infoPanel2
            // 
            this.infoPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.infoPanel2.Controls.Add(this.selectedSumAndRowsLabel2);
            this.infoPanel2.Controls.Add(this.label5);
            this.infoPanel2.Controls.Add(this.totalRowsLabel2);
            this.infoPanel2.Controls.Add(this.totalSumLabel2);
            this.infoPanel2.Controls.Add(this.label9);
            this.infoPanel2.Controls.Add(this.label10);
            this.infoPanel2.Controls.Add(this.nameTextBox2);
            this.infoPanel2.Controls.Add(this.label11);
            this.infoPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel2.Location = new System.Drawing.Point(0, 79);
            this.infoPanel2.Name = "infoPanel2";
            this.infoPanel2.Size = new System.Drawing.Size(620, 107);
            this.infoPanel2.TabIndex = 2;
            // 
            // selectedSumAndRowsLabel2
            // 
            this.selectedSumAndRowsLabel2.AutoSize = true;
            this.selectedSumAndRowsLabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedSumAndRowsLabel2.Location = new System.Drawing.Point(119, 78);
            this.selectedSumAndRowsLabel2.Name = "selectedSumAndRowsLabel2";
            this.selectedSumAndRowsLabel2.Size = new System.Drawing.Size(71, 23);
            this.selectedSumAndRowsLabel2.TabIndex = 7;
            this.selectedSumAndRowsLabel2.Text = "0.00 (0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "ВЫДЕЛЕНО:";
            // 
            // totalRowsLabel2
            // 
            this.totalRowsLabel2.AutoSize = true;
            this.totalRowsLabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalRowsLabel2.Location = new System.Drawing.Point(119, 58);
            this.totalRowsLabel2.Name = "totalRowsLabel2";
            this.totalRowsLabel2.Size = new System.Drawing.Size(20, 23);
            this.totalRowsLabel2.TabIndex = 5;
            this.totalRowsLabel2.Text = "0";
            // 
            // totalSumLabel2
            // 
            this.totalSumLabel2.AutoSize = true;
            this.totalSumLabel2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSumLabel2.Location = new System.Drawing.Point(119, 38);
            this.totalSumLabel2.Name = "totalSumLabel2";
            this.totalSumLabel2.Size = new System.Drawing.Size(45, 23);
            this.totalSumLabel2.TabIndex = 4;
            this.totalSumLabel2.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Строк:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(4, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Сумма:";
            // 
            // nameTextBox2
            // 
            this.nameTextBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox2.Location = new System.Drawing.Point(123, 6);
            this.nameTextBox2.Name = "nameTextBox2";
            this.nameTextBox2.Size = new System.Drawing.Size(116, 30);
            this.nameTextBox2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(4, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Название:";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveButton2,
            this.editButton2,
            this.cloneButton2,
            this.deleteButton2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(620, 79);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // moveButton2
            // 
            this.moveButton2.AutoSize = false;
            this.moveButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moveButton2.Enabled = false;
            this.moveButton2.Image = global::DBF_Editor.Properties.Resources.moveToLeft;
            this.moveButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.moveButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveButton2.Name = "moveButton2";
            this.moveButton2.Size = new System.Drawing.Size(72, 76);
            this.moveButton2.Text = "toolStripButton1";
            this.moveButton2.ToolTipText = "Переместить";
            // 
            // editButton2
            // 
            this.editButton2.AutoSize = false;
            this.editButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editButton2.Enabled = false;
            this.editButton2.Image = global::DBF_Editor.Properties.Resources.edit;
            this.editButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editButton2.Name = "editButton2";
            this.editButton2.Size = new System.Drawing.Size(72, 76);
            this.editButton2.Text = "toolStripButton1";
            this.editButton2.ToolTipText = "Редактировать";
            // 
            // cloneButton2
            // 
            this.cloneButton2.AutoSize = false;
            this.cloneButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cloneButton2.Enabled = false;
            this.cloneButton2.Image = global::DBF_Editor.Properties.Resources.clone;
            this.cloneButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cloneButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cloneButton2.Name = "cloneButton2";
            this.cloneButton2.Size = new System.Drawing.Size(72, 76);
            this.cloneButton2.Text = "toolStripButton1";
            this.cloneButton2.ToolTipText = "Клонировать";
            // 
            // deleteButton2
            // 
            this.deleteButton2.AutoSize = false;
            this.deleteButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButton2.Enabled = false;
            this.deleteButton2.Image = global::DBF_Editor.Properties.Resources.delete;
            this.deleteButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(72, 76);
            this.deleteButton2.Text = "toolStripButton1";
            this.deleteButton2.ToolTipText = "Удалить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 741);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBF Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoPanel1.ResumeLayout(false);
            this.infoPanel1.PerformLayout();
            this.buttonsPanel1.ResumeLayout(false);
            this.buttonsPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.infoPanel2.ResumeLayout(false);
            this.infoPanel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opendbfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTodbfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTodbfcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel infoPanel1;
        private System.Windows.Forms.Label selectedSumAndRowsLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalRowsLabel1;
        private System.Windows.Forms.Label totalSumLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel buttonsPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton moveButton1;
        private System.Windows.Forms.ToolStripButton editButton1;
        private System.Windows.Forms.ToolStripButton cloneButton1;
        private System.Windows.Forms.ToolStripButton deleteButton1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel infoPanel2;
        private System.Windows.Forms.Label selectedSumAndRowsLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalRowsLabel2;
        private System.Windows.Forms.Label totalSumLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nameTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton moveButton2;
        private System.Windows.Forms.ToolStripButton editButton2;
        private System.Windows.Forms.ToolStripButton cloneButton2;
        private System.Windows.Forms.ToolStripButton deleteButton2;
        private System.Windows.Forms.ToolStripMenuItem solidSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

