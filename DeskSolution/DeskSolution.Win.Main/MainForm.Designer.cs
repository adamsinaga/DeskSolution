namespace DeskSolution.Win.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainMenuStrip = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            municipiosToolStripMenuItem = new ToolStripMenuItem();
            uFsToolStripMenuItem = new ToolStripMenuItem();
            paisesToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem = new ToolStripMenuItem();
            MainToolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            MainStatusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            MainMenuStrip.SuspendLayout();
            MainToolStrip.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatóriosToolStripMenuItem, sobreToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(800, 28);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pessoasToolStripMenuItem, toolStripMenuItem1, municipiosToolStripMenuItem, uFsToolStripMenuItem, paisesToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(224, 26);
            pessoasToolStripMenuItem.Text = "Pessoas";
            pessoasToolStripMenuItem.Click += pessoasToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(161, 6);
            // 
            // municipiosToolStripMenuItem
            // 
            municipiosToolStripMenuItem.Name = "municipiosToolStripMenuItem";
            municipiosToolStripMenuItem.Size = new Size(164, 26);
            municipiosToolStripMenuItem.Text = "Municipios";
            // 
            // uFsToolStripMenuItem
            // 
            uFsToolStripMenuItem.Name = "uFsToolStripMenuItem";
            uFsToolStripMenuItem.Size = new Size(164, 26);
            uFsToolStripMenuItem.Text = "UFs ";
            // 
            // paisesToolStripMenuItem
            // 
            paisesToolStripMenuItem.Name = "paisesToolStripMenuItem";
            paisesToolStripMenuItem.Size = new Size(164, 26);
            paisesToolStripMenuItem.Text = "Paises";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(90, 24);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(62, 24);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem
            // 
            umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem.Name = "umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem";
            umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem.Size = new Size(548, 26);
            umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem.Text = "Uma Blank Solution com o nome DeskSolution no Visual Studio 2022";
            // 
            // MainToolStrip
            // 
            MainToolStrip.ImageScalingSize = new Size(20, 20);
            MainToolStrip.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3 });
            MainToolStrip.Location = new Point(0, 28);
            MainToolStrip.Name = "MainToolStrip";
            MainToolStrip.Size = new Size(800, 27);
            MainToolStrip.TabIndex = 1;
            MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(20, 20);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            MainStatusStrip.Location = new Point(0, 424);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(800, 26);
            MainStatusStrip.TabIndex = 3;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(106, 20);
            toolStripStatusLabel1.Text = "Usuario: Adam";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainStatusStrip);
            Controls.Add(MainToolStrip);
            Controls.Add(MainMenuStrip);
            IsMdiContainer = true;
            MainMenuStrip = MainMenuStrip;
            Name = "MainForm";
            Text = "DeskSolution - Principal";
            WindowState = FormWindowState.Maximized;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            MainToolStrip.ResumeLayout(false);
            MainToolStrip.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem municipiosToolStripMenuItem;
        private ToolStripMenuItem uFsToolStripMenuItem;
        private ToolStripMenuItem paisesToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStrip MainToolStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem umaBlankSolutionComONomeDeskSolutionNoVisualStudio2022ToolStripMenuItem;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}