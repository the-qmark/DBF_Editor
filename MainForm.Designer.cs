
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьdbfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВdbfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВdbfcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.infoPanel1 = new System.Windows.Forms.Panel();
            this.currentSumAndRowsLabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalRowsLabel1 = new System.Windows.Forms.Label();
            this.totalSumLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonsPanel1 = new System.Windows.Forms.Panel();
            this.deleteButton1 = new System.Windows.Forms.Button();
            this.cloneButton1 = new System.Windows.Forms.Button();
            this.editButton1 = new System.Windows.Forms.Button();
            this.moveButton1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.infoPanel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonsPanel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.infoPanel1.SuspendLayout();
            this.buttonsPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.infoPanel2.SuspendLayout();
            this.buttonsPanel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сервисToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(969, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьdbfToolStripMenuItem,
            this.сохранитьВdbfToolStripMenuItem,
            this.сохранитьВdbfcsvToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьdbfToolStripMenuItem
            // 
            this.открытьdbfToolStripMenuItem.Name = "открытьdbfToolStripMenuItem";
            this.открытьdbfToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.открытьdbfToolStripMenuItem.Text = "Открыть [dbf]";
            // 
            // сохранитьВdbfToolStripMenuItem
            // 
            this.сохранитьВdbfToolStripMenuItem.Name = "сохранитьВdbfToolStripMenuItem";
            this.сохранитьВdbfToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.сохранитьВdbfToolStripMenuItem.Text = "Сохранить в [dbf]";
            // 
            // сохранитьВdbfcsvToolStripMenuItem
            // 
            this.сохранитьВdbfcsvToolStripMenuItem.Name = "сохранитьВdbfcsvToolStripMenuItem";
            this.сохранитьВdbfcsvToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.сохранитьВdbfcsvToolStripMenuItem.Text = "Сохранить в [dbf + csv]";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 24);
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
            this.mainSplitContainer.Panel2.Controls.Add(this.buttonsPanel2);
            this.mainSplitContainer.Size = new System.Drawing.Size(969, 571);
            this.mainSplitContainer.SplitterDistance = 488;
            this.mainSplitContainer.SplitterWidth = 10;
            this.mainSplitContainer.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(488, 385);
            this.dataGridView1.TabIndex = 2;
            // 
            // infoPanel1
            // 
            this.infoPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.infoPanel1.Controls.Add(this.currentSumAndRowsLabel1);
            this.infoPanel1.Controls.Add(this.label6);
            this.infoPanel1.Controls.Add(this.totalRowsLabel1);
            this.infoPanel1.Controls.Add(this.totalSumLabel1);
            this.infoPanel1.Controls.Add(this.label3);
            this.infoPanel1.Controls.Add(this.label2);
            this.infoPanel1.Controls.Add(this.nameTextBox1);
            this.infoPanel1.Controls.Add(this.label1);
            this.infoPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel1.Location = new System.Drawing.Point(0, 79);
            this.infoPanel1.Name = "infoPanel1";
            this.infoPanel1.Size = new System.Drawing.Size(488, 107);
            this.infoPanel1.TabIndex = 1;
            // 
            // currentSumAndRowsLabel1
            // 
            this.currentSumAndRowsLabel1.AutoSize = true;
            this.currentSumAndRowsLabel1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSumAndRowsLabel1.Location = new System.Drawing.Point(119, 78);
            this.currentSumAndRowsLabel1.Name = "currentSumAndRowsLabel1";
            this.currentSumAndRowsLabel1.Size = new System.Drawing.Size(86, 23);
            this.currentSumAndRowsLabel1.TabIndex = 7;
            this.currentSumAndRowsLabel1.Text = "45684 (6)";
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
            this.totalRowsLabel1.Size = new System.Drawing.Size(40, 23);
            this.totalRowsLabel1.TabIndex = 5;
            this.totalRowsLabel1.Text = "506";
            // 
            // totalSumLabel1
            // 
            this.totalSumLabel1.AutoSize = true;
            this.totalSumLabel1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalSumLabel1.Location = new System.Drawing.Point(119, 38);
            this.totalSumLabel1.Name = "totalSumLabel1";
            this.totalSumLabel1.Size = new System.Drawing.Size(95, 23);
            this.totalSumLabel1.TabIndex = 4;
            this.totalSumLabel1.Text = "157684,04";
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
            this.nameTextBox1.Size = new System.Drawing.Size(139, 30);
            this.nameTextBox1.TabIndex = 1;
            this.nameTextBox1.Text = "123";
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
            this.buttonsPanel1.Controls.Add(this.deleteButton1);
            this.buttonsPanel1.Controls.Add(this.cloneButton1);
            this.buttonsPanel1.Controls.Add(this.editButton1);
            this.buttonsPanel1.Controls.Add(this.moveButton1);
            this.buttonsPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsPanel1.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel1.Name = "buttonsPanel1";
            this.buttonsPanel1.Size = new System.Drawing.Size(488, 79);
            this.buttonsPanel1.TabIndex = 0;
            // 
            // deleteButton1
            // 
            this.deleteButton1.AutoSize = true;
            this.deleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton1.FlatAppearance.BorderSize = 0;
            this.deleteButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton1.Image = global::DBF_Editor.Properties.Resources.delete;
            this.deleteButton1.Location = new System.Drawing.Point(237, 4);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(72, 72);
            this.deleteButton1.TabIndex = 4;
            this.deleteButton1.UseVisualStyleBackColor = false;
            // 
            // cloneButton1
            // 
            this.cloneButton1.AutoSize = true;
            this.cloneButton1.BackColor = System.Drawing.Color.Transparent;
            this.cloneButton1.FlatAppearance.BorderSize = 0;
            this.cloneButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cloneButton1.Image = global::DBF_Editor.Properties.Resources.clone;
            this.cloneButton1.Location = new System.Drawing.Point(159, 4);
            this.cloneButton1.Name = "cloneButton1";
            this.cloneButton1.Size = new System.Drawing.Size(72, 72);
            this.cloneButton1.TabIndex = 3;
            this.cloneButton1.UseVisualStyleBackColor = false;
            // 
            // editButton1
            // 
            this.editButton1.AutoSize = true;
            this.editButton1.BackColor = System.Drawing.Color.Transparent;
            this.editButton1.FlatAppearance.BorderSize = 0;
            this.editButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton1.Image = global::DBF_Editor.Properties.Resources.edit;
            this.editButton1.Location = new System.Drawing.Point(81, 4);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(72, 72);
            this.editButton1.TabIndex = 2;
            this.editButton1.UseVisualStyleBackColor = false;
            // 
            // moveButton1
            // 
            this.moveButton1.AutoSize = true;
            this.moveButton1.BackColor = System.Drawing.Color.Transparent;
            this.moveButton1.FlatAppearance.BorderSize = 0;
            this.moveButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveButton1.Image = global::DBF_Editor.Properties.Resources.moveToRight;
            this.moveButton1.Location = new System.Drawing.Point(3, 4);
            this.moveButton1.Name = "moveButton1";
            this.moveButton1.Size = new System.Drawing.Size(72, 72);
            this.moveButton1.TabIndex = 1;
            this.moveButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(471, 408);
            this.dataGridView2.TabIndex = 3;
            // 
            // infoPanel2
            // 
            this.infoPanel2.BackColor = System.Drawing.SystemColors.Info;
            this.infoPanel2.Controls.Add(this.label8);
            this.infoPanel2.Controls.Add(this.label9);
            this.infoPanel2.Controls.Add(this.label10);
            this.infoPanel2.Controls.Add(this.label11);
            this.infoPanel2.Controls.Add(this.label12);
            this.infoPanel2.Controls.Add(this.label13);
            this.infoPanel2.Controls.Add(this.textBox2);
            this.infoPanel2.Controls.Add(this.label14);
            this.infoPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPanel2.Location = new System.Drawing.Point(0, 50);
            this.infoPanel2.Name = "infoPanel2";
            this.infoPanel2.Size = new System.Drawing.Size(471, 113);
            this.infoPanel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(119, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "45684 (6)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "ВЫДЕЛЕНО:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(119, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "506";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(119, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "157684,04";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(4, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "Строк:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(4, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Сумма:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(123, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "123";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(4, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Название:";
            // 
            // buttonsPanel2
            // 
            this.buttonsPanel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonsPanel2.Controls.Add(this.button5);
            this.buttonsPanel2.Controls.Add(this.button6);
            this.buttonsPanel2.Controls.Add(this.button7);
            this.buttonsPanel2.Controls.Add(this.button8);
            this.buttonsPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonsPanel2.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel2.Name = "buttonsPanel2";
            this.buttonsPanel2.Size = new System.Drawing.Size(471, 50);
            this.buttonsPanel2.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(141, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "0";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(95, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 40);
            this.button6.TabIndex = 3;
            this.button6.Text = "0";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(49, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 40);
            this.button7.TabIndex = 2;
            this.button7.Text = "0";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 40);
            this.button8.TabIndex = 1;
            this.button8.Text = "0";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Был открыт файл \"...\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 617);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBF Editor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.infoPanel1.ResumeLayout(false);
            this.infoPanel1.PerformLayout();
            this.buttonsPanel1.ResumeLayout(false);
            this.buttonsPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.infoPanel2.ResumeLayout(false);
            this.infoPanel2.PerformLayout();
            this.buttonsPanel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьdbfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВdbfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВdbfcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel buttonsPanel1;
        private System.Windows.Forms.Button moveButton1;
        private System.Windows.Forms.Panel infoPanel1;
        private System.Windows.Forms.Label currentSumAndRowsLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalRowsLabel1;
        private System.Windows.Forms.Label totalSumLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel infoPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel buttonsPanel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button deleteButton1;
        private System.Windows.Forms.Button cloneButton1;
        private System.Windows.Forms.Button editButton1;
    }
}

