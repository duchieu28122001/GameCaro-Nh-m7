namespace Demo_CoCaro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScoreO = new System.Windows.Forms.TextBox();
            this.txtScoreX = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChatInput = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.grbGameMode = new System.Windows.Forms.GroupBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnComputer = new System.Windows.Forms.Button();
            this.lnkUndo = new System.Windows.Forms.LinkLabel();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pgbcooldown = new System.Windows.Forms.ProgressBar();
            this.timercooldown = new System.Windows.Forms.Timer(this.components);
            this.panelBoard.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbGameMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.White;
            this.panelBoard.Controls.Add(this.menuStrip1);
            this.panelBoard.Location = new System.Drawing.Point(293, 12);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(568, 568);
            this.panelBoard.TabIndex = 0;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            this.panelBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtScoreO);
            this.groupBox2.Controls.Add(this.txtScoreX);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tỷ số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            // 
            // txtScoreO
            // 
            this.txtScoreO.BackColor = System.Drawing.Color.White;
            this.txtScoreO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreO.Location = new System.Drawing.Point(173, 26);
            this.txtScoreO.Name = "txtScoreO";
            this.txtScoreO.ReadOnly = true;
            this.txtScoreO.Size = new System.Drawing.Size(60, 29);
            this.txtScoreO.TabIndex = 0;
            this.txtScoreO.TabStop = false;
            this.txtScoreO.Text = "0";
            this.txtScoreO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScoreX
            // 
            this.txtScoreX.BackColor = System.Drawing.Color.White;
            this.txtScoreX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreX.Location = new System.Drawing.Point(42, 26);
            this.txtScoreX.Name = "txtScoreX";
            this.txtScoreX.ReadOnly = true;
            this.txtScoreX.Size = new System.Drawing.Size(60, 29);
            this.txtScoreX.TabIndex = 0;
            this.txtScoreX.TabStop = false;
            this.txtScoreX.Text = "0";
            this.txtScoreX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo_CoCaro.Properties.Resources.o;
            this.pictureBox2.Location = new System.Drawing.Point(239, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Demo_CoCaro.Properties.Resources.x;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtChatInput);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 305);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tin nhắn:";
            // 
            // txtChatInput
            // 
            this.txtChatInput.Location = new System.Drawing.Point(6, 269);
            this.txtChatInput.MaxLength = 1000;
            this.txtChatInput.Name = "txtChatInput";
            this.txtChatInput.Size = new System.Drawing.Size(263, 26);
            this.txtChatInput.TabIndex = 11;
            this.txtChatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChatInput_KeyPress);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 25);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(263, 230);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gửi từ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nội dung tin nhắn";
            this.columnHeader3.Width = 180;
            // 
            // timerServer
            // 
            this.timerServer.Interval = 1000;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // grbGameMode
            // 
            this.grbGameMode.Controls.Add(this.txtIPAddress);
            this.grbGameMode.Controls.Add(this.btnSearch);
            this.grbGameMode.Controls.Add(this.btnNetwork);
            this.grbGameMode.Controls.Add(this.label3);
            this.grbGameMode.Controls.Add(this.label2);
            this.grbGameMode.Controls.Add(this.numPort);
            this.grbGameMode.Controls.Add(this.btnComputer);
            this.grbGameMode.Location = new System.Drawing.Point(12, 21);
            this.grbGameMode.Name = "grbGameMode";
            this.grbGameMode.Size = new System.Drawing.Size(275, 145);
            this.grbGameMode.TabIndex = 3;
            this.grbGameMode.TabStop = false;
            this.grbGameMode.Text = "Chế độ chơi:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(6, 78);
            this.txtIPAddress.MaxLength = 45;
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(128, 26);
            this.txtIPAddress.TabIndex = 32;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(140, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 28);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "S";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Location = new System.Drawing.Point(6, 110);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(263, 28);
            this.btnNetwork.TabIndex = 35;
            this.btnNetwork.Text = "Chơi qua mạng - LAN";
            this.btnNetwork.UseVisualStyleBackColor = true;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cổng (port):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Máy chủ (IP):";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(179, 78);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(96, 26);
            this.numPort.TabIndex = 34;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(6, 25);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(263, 28);
            this.btnComputer.TabIndex = 31;
            this.btnComputer.Text = "Chơi với máy - Demo";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // lnkUndo
            // 
            this.lnkUndo.AutoSize = true;
            this.lnkUndo.Location = new System.Drawing.Point(289, 584);
            this.lnkUndo.Name = "lnkUndo";
            this.lnkUndo.Size = new System.Drawing.Size(102, 19);
            this.lnkUndo.TabIndex = 41;
            this.lnkUndo.TabStop = true;
            this.lnkUndo.Text = "Đánh lại (undo)";
            this.lnkUndo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUndo_LinkClicked);
            // 
            // lnkAbout
            // 
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Location = new System.Drawing.Point(726, 584);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(135, 19);
            this.lnkAbout.TabIndex = 42;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "Thông tin - Luật chơi";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(873, 24);
            this.menuStrip2.TabIndex = 43;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pgbcooldown
            // 
            this.pgbcooldown.Location = new System.Drawing.Point(18, 256);
            this.pgbcooldown.Name = "pgbcooldown";
            this.pgbcooldown.Size = new System.Drawing.Size(263, 23);
            this.pgbcooldown.TabIndex = 44;
            this.pgbcooldown.Click += new System.EventHandler(this.pgbcooldown_Click);
            // 
            // timercooldown
            // 
            this.timercooldown.Tick += new System.EventHandler(this.timercooldown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 612);
            this.Controls.Add(this.pgbcooldown);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.lnkUndo);
            this.Controls.Add(this.grbGameMode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Caro Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBoard.ResumeLayout(false);
            this.panelBoard.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbGameMode.ResumeLayout(false);
            this.grbGameMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScoreO;
        private System.Windows.Forms.TextBox txtScoreX;
        private System.Windows.Forms.TextBox txtChatInput;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timerServer;
        private System.Windows.Forms.GroupBox grbGameMode;
        private System.Windows.Forms.Button btnNetwork;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.LinkLabel lnkUndo;
        private System.Windows.Forms.LinkLabel lnkAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pgbcooldown;
        private System.Windows.Forms.Timer timercooldown;
    }
}

