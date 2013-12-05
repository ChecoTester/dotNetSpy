namespace dotNetSpy
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbBack = new System.Windows.Forms.ToolStripButton();
            this.tbGoToRoot = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listChildren = new System.Windows.Forms.ListBox();
            this.listProperties = new System.Windows.Forms.ListView();
            this.colProperty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbBack,
            this.tbGoToRoot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(949, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbBack
            // 
            this.tbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBack.Image = ((System.Drawing.Image)(resources.GetObject("tbBack.Image")));
            this.tbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(23, 22);
            this.tbBack.Text = "toolStripButton1";
            this.tbBack.ToolTipText = "Back (to parent)";
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // tbGoToRoot
            // 
            this.tbGoToRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbGoToRoot.Image = ((System.Drawing.Image)(resources.GetObject("tbGoToRoot.Image")));
            this.tbGoToRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbGoToRoot.Name = "tbGoToRoot";
            this.tbGoToRoot.Size = new System.Drawing.Size(23, 22);
            this.tbGoToRoot.Text = "Root element (Desktop)";
            this.tbGoToRoot.Click += new System.EventHandler(this.tbGoToRoot_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 624);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listChildren);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listProperties);
            this.splitContainer1.Size = new System.Drawing.Size(949, 624);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 0;
            // 
            // listChildren
            // 
            this.listChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listChildren.FormattingEnabled = true;
            this.listChildren.Location = new System.Drawing.Point(0, 0);
            this.listChildren.Name = "listChildren";
            this.listChildren.Size = new System.Drawing.Size(316, 624);
            this.listChildren.TabIndex = 0;
            this.listChildren.SelectedIndexChanged += new System.EventHandler(this.listChildren_SelectedIndexChanged);
            this.listChildren.DoubleClick += new System.EventHandler(this.listChildren_DoubleClick);
            // 
            // listProperties
            // 
            this.listProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProperty,
            this.colValue});
            this.listProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProperties.GridLines = true;
            this.listProperties.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listProperties.Location = new System.Drawing.Point(0, 0);
            this.listProperties.Name = "listProperties";
            this.listProperties.Size = new System.Drawing.Size(629, 624);
            this.listProperties.TabIndex = 0;
            this.listProperties.UseCompatibleStateImageBehavior = false;
            this.listProperties.View = System.Windows.Forms.View.Details;
            // 
            // colProperty
            // 
            this.colProperty.Text = "Property";
            this.colProperty.Width = 200;
            // 
            // colValue
            // 
            this.colValue.Text = "Value";
            this.colValue.Width = 320;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = ".NET Object Spy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton tbBack;
        private System.Windows.Forms.ToolStripButton tbGoToRoot;
        private System.Windows.Forms.ListBox listChildren;
        private System.Windows.Forms.ListView listProperties;
        private System.Windows.Forms.ColumnHeader colProperty;
        private System.Windows.Forms.ColumnHeader colValue;

    }
}

