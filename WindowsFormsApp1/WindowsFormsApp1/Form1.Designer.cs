namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Logon = new System.Windows.Forms.TabPage();
            this.Drivers = new System.Windows.Forms.TabPage();
            this.Services = new System.Windows.Forms.TabPage();
            this.ScheduledTasks = new System.Windows.Forms.TabPage();
            this.KnownDLLs = new System.Windows.Forms.TabPage();
            this.InternetExplorer = new System.Windows.Forms.TabPage();
            this.About = new System.Windows.Forms.TabPage();
            this.LogonResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DriversResult = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServicesResult = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScheduledTasksResult = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KnownDLLResult = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InternetExplorerResult = new System.Windows.Forms.ListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.Logon.SuspendLayout();
            this.Drivers.SuspendLayout();
            this.Services.SuspendLayout();
            this.ScheduledTasks.SuspendLayout();
            this.KnownDLLs.SuspendLayout();
            this.InternetExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Logon);
            this.tabControl1.Controls.Add(this.Drivers);
            this.tabControl1.Controls.Add(this.Services);
            this.tabControl1.Controls.Add(this.ScheduledTasks);
            this.tabControl1.Controls.Add(this.KnownDLLs);
            this.tabControl1.Controls.Add(this.InternetExplorer);
            this.tabControl1.Controls.Add(this.About);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // Logon
            // 
            this.Logon.Controls.Add(this.LogonResult);
            this.Logon.Location = new System.Drawing.Point(4, 25);
            this.Logon.Name = "Logon";
            this.Logon.Padding = new System.Windows.Forms.Padding(3);
            this.Logon.Size = new System.Drawing.Size(774, 403);
            this.Logon.TabIndex = 0;
            this.Logon.Text = "Logon";
            this.Logon.UseVisualStyleBackColor = true;
            // 
            // Drivers
            // 
            this.Drivers.Controls.Add(this.DriversResult);
            this.Drivers.Location = new System.Drawing.Point(4, 25);
            this.Drivers.Name = "Drivers";
            this.Drivers.Padding = new System.Windows.Forms.Padding(3);
            this.Drivers.Size = new System.Drawing.Size(774, 403);
            this.Drivers.TabIndex = 1;
            this.Drivers.Text = "Drivers";
            this.Drivers.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.Controls.Add(this.ServicesResult);
            this.Services.Location = new System.Drawing.Point(4, 25);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(3);
            this.Services.Size = new System.Drawing.Size(774, 403);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // ScheduledTasks
            // 
            this.ScheduledTasks.Controls.Add(this.ScheduledTasksResult);
            this.ScheduledTasks.Location = new System.Drawing.Point(4, 25);
            this.ScheduledTasks.Name = "ScheduledTasks";
            this.ScheduledTasks.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduledTasks.Size = new System.Drawing.Size(774, 403);
            this.ScheduledTasks.TabIndex = 3;
            this.ScheduledTasks.Text = "Scheduled Tasks";
            this.ScheduledTasks.UseVisualStyleBackColor = true;
            // 
            // KnownDLLs
            // 
            this.KnownDLLs.Controls.Add(this.KnownDLLResult);
            this.KnownDLLs.Location = new System.Drawing.Point(4, 25);
            this.KnownDLLs.Name = "KnownDLLs";
            this.KnownDLLs.Padding = new System.Windows.Forms.Padding(3);
            this.KnownDLLs.Size = new System.Drawing.Size(774, 403);
            this.KnownDLLs.TabIndex = 4;
            this.KnownDLLs.Text = "Known DLLs";
            this.KnownDLLs.UseVisualStyleBackColor = true;
            // 
            // InternetExplorer
            // 
            this.InternetExplorer.Controls.Add(this.InternetExplorerResult);
            this.InternetExplorer.Location = new System.Drawing.Point(4, 25);
            this.InternetExplorer.Name = "InternetExplorer";
            this.InternetExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.InternetExplorer.Size = new System.Drawing.Size(774, 403);
            this.InternetExplorer.TabIndex = 5;
            this.InternetExplorer.Text = "Internet Explorer";
            this.InternetExplorer.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(4, 25);
            this.About.Name = "About";
            this.About.Padding = new System.Windows.Forms.Padding(3);
            this.About.Size = new System.Drawing.Size(774, 403);
            this.About.TabIndex = 6;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            // 
            // LogonResult
            // 
            this.LogonResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogonResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LogonResult.HideSelection = false;
            this.LogonResult.Location = new System.Drawing.Point(6, 6);
            this.LogonResult.Name = "LogonResult";
            this.LogonResult.Size = new System.Drawing.Size(762, 391);
            this.LogonResult.TabIndex = 0;
            this.LogonResult.UseCompatibleStateImageBehavior = false;
            this.LogonResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Autorun Entry";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publisher";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Image Path";
            this.columnHeader4.Width = 100;
            // 
            // DriversResult
            // 
            this.DriversResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DriversResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.DriversResult.HideSelection = false;
            this.DriversResult.Location = new System.Drawing.Point(6, 6);
            this.DriversResult.Name = "DriversResult";
            this.DriversResult.Size = new System.Drawing.Size(762, 391);
            this.DriversResult.TabIndex = 1;
            this.DriversResult.UseCompatibleStateImageBehavior = false;
            this.DriversResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Autorun Entry";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Publisher";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Image Path";
            this.columnHeader8.Width = 100;
            // 
            // ServicesResult
            // 
            this.ServicesResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ServicesResult.HideSelection = false;
            this.ServicesResult.Location = new System.Drawing.Point(6, 6);
            this.ServicesResult.Name = "ServicesResult";
            this.ServicesResult.Size = new System.Drawing.Size(762, 391);
            this.ServicesResult.TabIndex = 1;
            this.ServicesResult.UseCompatibleStateImageBehavior = false;
            this.ServicesResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Autorun Entry";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Description";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Publisher";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Image Path";
            this.columnHeader12.Width = 100;
            // 
            // ScheduledTasksResult
            // 
            this.ScheduledTasksResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduledTasksResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.ScheduledTasksResult.HideSelection = false;
            this.ScheduledTasksResult.Location = new System.Drawing.Point(6, 6);
            this.ScheduledTasksResult.Name = "ScheduledTasksResult";
            this.ScheduledTasksResult.Size = new System.Drawing.Size(762, 391);
            this.ScheduledTasksResult.TabIndex = 1;
            this.ScheduledTasksResult.UseCompatibleStateImageBehavior = false;
            this.ScheduledTasksResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Autorun Entry";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Description";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Publisher";
            this.columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Image Path";
            this.columnHeader16.Width = 100;
            // 
            // KnownDLLResult
            // 
            this.KnownDLLResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnownDLLResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.KnownDLLResult.HideSelection = false;
            this.KnownDLLResult.Location = new System.Drawing.Point(6, 6);
            this.KnownDLLResult.Name = "KnownDLLResult";
            this.KnownDLLResult.Size = new System.Drawing.Size(762, 391);
            this.KnownDLLResult.TabIndex = 1;
            this.KnownDLLResult.UseCompatibleStateImageBehavior = false;
            this.KnownDLLResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Autorun Entry";
            this.columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Description";
            this.columnHeader18.Width = 100;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Publisher";
            this.columnHeader19.Width = 100;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Image Path";
            this.columnHeader20.Width = 100;
            // 
            // InternetExplorerResult
            // 
            this.InternetExplorerResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InternetExplorerResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.InternetExplorerResult.HideSelection = false;
            this.InternetExplorerResult.Location = new System.Drawing.Point(6, 6);
            this.InternetExplorerResult.Name = "InternetExplorerResult";
            this.InternetExplorerResult.Size = new System.Drawing.Size(762, 391);
            this.InternetExplorerResult.TabIndex = 1;
            this.InternetExplorerResult.UseCompatibleStateImageBehavior = false;
            this.InternetExplorerResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Autorun Entry";
            this.columnHeader21.Width = 100;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Description";
            this.columnHeader22.Width = 100;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Publisher";
            this.columnHeader23.Width = 100;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Image Path";
            this.columnHeader24.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Logon.ResumeLayout(false);
            this.Drivers.ResumeLayout(false);
            this.Services.ResumeLayout(false);
            this.ScheduledTasks.ResumeLayout(false);
            this.KnownDLLs.ResumeLayout(false);
            this.InternetExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Logon;
        private System.Windows.Forms.TabPage Drivers;
        private System.Windows.Forms.ListView LogonResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.TabPage ScheduledTasks;
        private System.Windows.Forms.TabPage KnownDLLs;
        private System.Windows.Forms.TabPage InternetExplorer;
        private System.Windows.Forms.TabPage About;
        private System.Windows.Forms.ListView DriversResult;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView ServicesResult;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView ScheduledTasksResult;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ListView KnownDLLResult;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ListView InternetExplorerResult;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
    }
}

