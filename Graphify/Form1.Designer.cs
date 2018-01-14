namespace Graphify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCSP = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTraverse = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.configPanel = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.RichTextBox();
            this.txtStart = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnAstar = new System.Windows.Forms.Button();
            this.btnGreedy = new System.Windows.Forms.Button();
            this.btnDFStraverse = new System.Windows.Forms.Button();
            this.btnBFStraverse = new System.Windows.Forms.Button();
            this.btnCoordinates = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNodes = new System.Windows.Forms.Button();
            this.btnEdges = new System.Windows.Forms.Button();
            this.drawMenu = new System.Windows.Forms.Panel();
            this.viewMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.traverseMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.searchMenu = new System.Windows.Forms.Panel();
            this.fileMenu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelArea = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.configPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.drawPanel.SuspendLayout();
            this.drawMenu.SuspendLayout();
            this.viewMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.traverseMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.searchMenu.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.SideBar);
            this.mainPanel.Controls.Add(this.btnQuit);
            this.mainPanel.Controls.Add(this.btnCSP);
            this.mainPanel.Controls.Add(this.btnView);
            this.mainPanel.Controls.Add(this.btnSearch);
            this.mainPanel.Controls.Add(this.btnTraverse);
            this.mainPanel.Controls.Add(this.btnDraw);
            this.mainPanel.Controls.Add(this.btnMenu);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(200, 550);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "GRAPHIFY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.Maroon;
            this.SideBar.Location = new System.Drawing.Point(0, 146);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(10, 50);
            this.SideBar.TabIndex = 3;
            // 
            // btnQuit
            // 
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuit.Location = new System.Drawing.Point(35, 482);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(160, 50);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCSP
            // 
            this.btnCSP.FlatAppearance.BorderSize = 0;
            this.btnCSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSP.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSP.ForeColor = System.Drawing.Color.White;
            this.btnCSP.Image = ((System.Drawing.Image)(resources.GetObject("btnCSP.Image")));
            this.btnCSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCSP.Location = new System.Drawing.Point(35, 426);
            this.btnCSP.Name = "btnCSP";
            this.btnCSP.Size = new System.Drawing.Size(160, 50);
            this.btnCSP.TabIndex = 8;
            this.btnCSP.Text = "CSP";
            this.btnCSP.UseVisualStyleBackColor = true;
            this.btnCSP.Click += new System.EventHandler(this.btnRailFence_Click);
            // 
            // btnView
            // 
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(35, 258);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(160, 50);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnHill_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(35, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(160, 50);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnTransposition_Click);
            // 
            // btnTraverse
            // 
            this.btnTraverse.FlatAppearance.BorderSize = 0;
            this.btnTraverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraverse.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraverse.ForeColor = System.Drawing.Color.White;
            this.btnTraverse.Image = ((System.Drawing.Image)(resources.GetObject("btnTraverse.Image")));
            this.btnTraverse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraverse.Location = new System.Drawing.Point(35, 314);
            this.btnTraverse.Name = "btnTraverse";
            this.btnTraverse.Size = new System.Drawing.Size(160, 50);
            this.btnTraverse.TabIndex = 5;
            this.btnTraverse.Text = "Traverse";
            this.btnTraverse.UseVisualStyleBackColor = true;
            this.btnTraverse.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.FlatAppearance.BorderSize = 0;
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.White;
            this.btnDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDraw.Image")));
            this.btnDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraw.Location = new System.Drawing.Point(35, 202);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(160, 50);
            this.btnDraw.TabIndex = 4;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnPlayfair_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(35, 146);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(160, 50);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Home";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // configPanel
            // 
            this.configPanel.BackColor = System.Drawing.Color.Gray;
            this.configPanel.Controls.Add(this.lblSearch);
            this.configPanel.Controls.Add(this.label2);
            this.configPanel.Controls.Add(this.label1);
            this.configPanel.Controls.Add(this.txtEnd);
            this.configPanel.Controls.Add(this.txtStart);
            this.configPanel.Controls.Add(this.btnClear);
            this.configPanel.Controls.Add(this.btnProceed);
            this.configPanel.Location = new System.Drawing.Point(28, 33);
            this.configPanel.Name = "configPanel";
            this.configPanel.Size = new System.Drawing.Size(150, 200);
            this.configPanel.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(12, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 16);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "From:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "From:";
            // 
            // txtEnd
            // 
            this.txtEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnd.Location = new System.Drawing.Point(49, 73);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(90, 35);
            this.txtEnd.TabIndex = 6;
            this.txtEnd.Text = "";
            // 
            // txtStart
            // 
            this.txtStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStart.Location = new System.Drawing.Point(50, 29);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(90, 35);
            this.txtStart.TabIndex = 5;
            this.txtStart.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGray;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(0, 158);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.DarkGray;
            this.btnProceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(0, 117);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(150, 40);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.Text = "Search";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchPanel.Controls.Add(this.btnBack2);
            this.searchPanel.Controls.Add(this.btnAstar);
            this.searchPanel.Controls.Add(this.btnGreedy);
            this.searchPanel.Controls.Add(this.btnDFStraverse);
            this.searchPanel.Controls.Add(this.btnBFStraverse);
            this.searchPanel.Location = new System.Drawing.Point(28, 242);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(150, 275);
            this.searchPanel.TabIndex = 2;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(0, 225);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(150, 50);
            this.btnBack2.TabIndex = 4;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAstar
            // 
            this.btnAstar.BackColor = System.Drawing.Color.DarkGray;
            this.btnAstar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAstar.FlatAppearance.BorderSize = 0;
            this.btnAstar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAstar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAstar.ForeColor = System.Drawing.Color.White;
            this.btnAstar.Location = new System.Drawing.Point(0, 150);
            this.btnAstar.Name = "btnAstar";
            this.btnAstar.Size = new System.Drawing.Size(150, 50);
            this.btnAstar.TabIndex = 3;
            this.btnAstar.Text = "A* Search";
            this.btnAstar.UseVisualStyleBackColor = false;
            this.btnAstar.Click += new System.EventHandler(this.btnAstar_Click);
            // 
            // btnGreedy
            // 
            this.btnGreedy.BackColor = System.Drawing.Color.DarkGray;
            this.btnGreedy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGreedy.FlatAppearance.BorderSize = 0;
            this.btnGreedy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreedy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreedy.ForeColor = System.Drawing.Color.White;
            this.btnGreedy.Location = new System.Drawing.Point(0, 100);
            this.btnGreedy.Name = "btnGreedy";
            this.btnGreedy.Size = new System.Drawing.Size(150, 50);
            this.btnGreedy.TabIndex = 2;
            this.btnGreedy.Text = "Greedy Search";
            this.btnGreedy.UseVisualStyleBackColor = false;
            this.btnGreedy.Click += new System.EventHandler(this.btnGreedy_Click);
            // 
            // btnDFStraverse
            // 
            this.btnDFStraverse.BackColor = System.Drawing.Color.DarkGray;
            this.btnDFStraverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDFStraverse.FlatAppearance.BorderSize = 0;
            this.btnDFStraverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFStraverse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFStraverse.ForeColor = System.Drawing.Color.White;
            this.btnDFStraverse.Location = new System.Drawing.Point(0, 50);
            this.btnDFStraverse.Name = "btnDFStraverse";
            this.btnDFStraverse.Size = new System.Drawing.Size(150, 50);
            this.btnDFStraverse.TabIndex = 1;
            this.btnDFStraverse.Text = "DFS";
            this.btnDFStraverse.UseVisualStyleBackColor = false;
            this.btnDFStraverse.Click += new System.EventHandler(this.btnDFStraverse_Click);
            // 
            // btnBFStraverse
            // 
            this.btnBFStraverse.BackColor = System.Drawing.Color.DarkGray;
            this.btnBFStraverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBFStraverse.FlatAppearance.BorderSize = 0;
            this.btnBFStraverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFStraverse.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFStraverse.ForeColor = System.Drawing.Color.White;
            this.btnBFStraverse.Location = new System.Drawing.Point(0, 0);
            this.btnBFStraverse.Name = "btnBFStraverse";
            this.btnBFStraverse.Size = new System.Drawing.Size(150, 50);
            this.btnBFStraverse.TabIndex = 0;
            this.btnBFStraverse.Text = "BFS";
            this.btnBFStraverse.UseVisualStyleBackColor = false;
            this.btnBFStraverse.Click += new System.EventHandler(this.btnBFStraverse_Click);
            // 
            // btnCoordinates
            // 
            this.btnCoordinates.BackColor = System.Drawing.Color.DarkGray;
            this.btnCoordinates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCoordinates.FlatAppearance.BorderSize = 0;
            this.btnCoordinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoordinates.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoordinates.ForeColor = System.Drawing.Color.White;
            this.btnCoordinates.Location = new System.Drawing.Point(0, 75);
            this.btnCoordinates.Name = "btnCoordinates";
            this.btnCoordinates.Size = new System.Drawing.Size(150, 50);
            this.btnCoordinates.TabIndex = 1;
            this.btnCoordinates.Text = "Coordinates";
            this.btnCoordinates.UseVisualStyleBackColor = false;
            this.btnCoordinates.Click += new System.EventHandler(this.btnCoordinates_Click);
            // 
            // btnMatrix
            // 
            this.btnMatrix.BackColor = System.Drawing.Color.DarkGray;
            this.btnMatrix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMatrix.FlatAppearance.BorderSize = 0;
            this.btnMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatrix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatrix.ForeColor = System.Drawing.Color.White;
            this.btnMatrix.Location = new System.Drawing.Point(0, 0);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(150, 50);
            this.btnMatrix.TabIndex = 0;
            this.btnMatrix.Text = "Matrix View";
            this.btnMatrix.UseVisualStyleBackColor = false;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.DarkGray;
            this.btnDFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDFS.FlatAppearance.BorderSize = 0;
            this.btnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.ForeColor = System.Drawing.Color.White;
            this.btnDFS.Location = new System.Drawing.Point(0, 75);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(150, 50);
            this.btnDFS.TabIndex = 1;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.DarkGray;
            this.btnBFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBFS.FlatAppearance.BorderSize = 0;
            this.btnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBFS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.ForeColor = System.Drawing.Color.White;
            this.btnBFS.Location = new System.Drawing.Point(0, 0);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(150, 50);
            this.btnBFS.TabIndex = 0;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // drawPanel
            // 
            this.drawPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drawPanel.Controls.Add(this.btnBack);
            this.drawPanel.Controls.Add(this.btnNodes);
            this.drawPanel.Controls.Add(this.btnEdges);
            this.drawPanel.Location = new System.Drawing.Point(27, 170);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(150, 200);
            this.drawPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkGray;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 150);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNodes
            // 
            this.btnNodes.BackColor = System.Drawing.Color.DarkGray;
            this.btnNodes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNodes.FlatAppearance.BorderSize = 0;
            this.btnNodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodes.ForeColor = System.Drawing.Color.White;
            this.btnNodes.Location = new System.Drawing.Point(0, 0);
            this.btnNodes.Name = "btnNodes";
            this.btnNodes.Size = new System.Drawing.Size(150, 50);
            this.btnNodes.TabIndex = 0;
            this.btnNodes.Text = "Nodes";
            this.btnNodes.UseVisualStyleBackColor = false;
            this.btnNodes.Click += new System.EventHandler(this.btnNodes_Click);
            // 
            // btnEdges
            // 
            this.btnEdges.BackColor = System.Drawing.Color.DarkGray;
            this.btnEdges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdges.FlatAppearance.BorderSize = 0;
            this.btnEdges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdges.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdges.ForeColor = System.Drawing.Color.White;
            this.btnEdges.Location = new System.Drawing.Point(0, 75);
            this.btnEdges.Name = "btnEdges";
            this.btnEdges.Size = new System.Drawing.Size(150, 50);
            this.btnEdges.TabIndex = 1;
            this.btnEdges.Text = "Edges";
            this.btnEdges.UseVisualStyleBackColor = false;
            this.btnEdges.Click += new System.EventHandler(this.btnEdges_Click);
            // 
            // drawMenu
            // 
            this.drawMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drawMenu.Controls.Add(this.drawPanel);
            this.drawMenu.Location = new System.Drawing.Point(0, 0);
            this.drawMenu.Name = "drawMenu";
            this.drawMenu.Size = new System.Drawing.Size(200, 550);
            this.drawMenu.TabIndex = 5;
            // 
            // viewMenu
            // 
            this.viewMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewMenu.Controls.Add(this.panel2);
            this.viewMenu.Location = new System.Drawing.Point(0, 0);
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(200, 550);
            this.viewMenu.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnCoordinates);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnMatrix);
            this.panel2.Location = new System.Drawing.Point(27, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 200);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // traverseMenu
            // 
            this.traverseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.traverseMenu.Controls.Add(this.panel3);
            this.traverseMenu.Location = new System.Drawing.Point(0, 0);
            this.traverseMenu.Name = "traverseMenu";
            this.traverseMenu.Size = new System.Drawing.Size(200, 550);
            this.traverseMenu.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnDFS);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnBFS);
            this.panel3.Location = new System.Drawing.Point(27, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 200);
            this.panel3.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // searchMenu
            // 
            this.searchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchMenu.Controls.Add(this.searchPanel);
            this.searchMenu.Controls.Add(this.configPanel);
            this.searchMenu.Location = new System.Drawing.Point(0, 0);
            this.searchMenu.Name = "searchMenu";
            this.searchMenu.Size = new System.Drawing.Size(200, 550);
            this.searchMenu.TabIndex = 8;
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fileMenu.Controls.Add(this.txtTemp);
            this.fileMenu.Controls.Add(this.panel4);
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(200, 550);
            this.fileMenu.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnOpen);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Location = new System.Drawing.Point(27, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 275);
            this.panel4.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkGray;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(0, 75);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 50);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkGray;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(150, 50);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New File";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panelArea
            // 
            this.panelArea.BackColor = System.Drawing.Color.White;
            this.panelArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelArea.BackgroundImage")));
            this.panelArea.Controls.Add(this.lblY);
            this.panelArea.Controls.Add(this.lblX);
            this.panelArea.Location = new System.Drawing.Point(200, 0);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(750, 550);
            this.panelArea.TabIndex = 10;
            this.panelArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelArea_MouseDown);
            this.panelArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelArea_MouseMove);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(684, 524);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 16);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y:";
            this.lblY.Visible = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(684, 503);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(19, 16);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X:";
            this.lblX.Visible = false;
            // 
            // txtTemp
            // 
            this.txtTemp.AutoScroll = true;
            this.txtTemp.Location = new System.Drawing.Point(77, 42);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(43, 47);
            this.txtTemp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.panelArea);
            this.Controls.Add(this.viewMenu);
            this.Controls.Add(this.searchMenu);
            this.Controls.Add(this.traverseMenu);
            this.Controls.Add(this.drawMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.configPanel.ResumeLayout(false);
            this.configPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.drawPanel.ResumeLayout(false);
            this.drawMenu.ResumeLayout(false);
            this.viewMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.traverseMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.searchMenu.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelArea.ResumeLayout(false);
            this.panelArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnCSP;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTraverse;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Button btnNodes;
        private System.Windows.Forms.Button btnEdges;
        private System.Windows.Forms.Button btnCoordinates;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Panel configPanel;
        private System.Windows.Forms.RichTextBox txtEnd;
        private System.Windows.Forms.RichTextBox txtStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Button btnAstar;
        private System.Windows.Forms.Button btnGreedy;
        private System.Windows.Forms.Button btnDFStraverse;
        private System.Windows.Forms.Button btnBFStraverse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel drawMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel traverseMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel viewMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel searchMenu;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Panel fileMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Panel txtTemp;
    }
}

