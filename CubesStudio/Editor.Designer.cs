namespace CubesStudio
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.editorMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.shapeToolbar = new System.Windows.Forms.ToolStrip();
            this.removeShapeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.strokeWidthBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.strokeColorBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.fillColorBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toBackButton = new System.Windows.Forms.ToolStripButton();
            this.toFrontButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.applyButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.editorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.shapeToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // editorMenu
            // 
            this.editorMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editorMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.editorMenu.Name = "contextMenuStrip1";
            this.editorMenu.Size = new System.Drawing.Size(145, 52);
            this.editorMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.editorMenu_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem2.Text = "Rectangle";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem3.Text = "Ellipse";
            // 
            // renderBox
            // 
            this.renderBox.BackColor = System.Drawing.Color.White;
            this.renderBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renderBox.Location = new System.Drawing.Point(0, 0);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(991, 539);
            this.renderBox.TabIndex = 2;
            this.renderBox.TabStop = false;
            this.renderBox.Paint += new System.Windows.Forms.PaintEventHandler(this.renderBox_OnPaint);
            this.renderBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseDown);
            this.renderBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseMove);
            this.renderBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Editor_MouseUp);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(64, 24);
            this.toolStripSplitButton1.Text = "Color";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.shapeToolbar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.renderBox);
            this.splitContainer1.Size = new System.Drawing.Size(991, 573);
            this.splitContainer1.SplitterDistance = 30;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // shapeToolbar
            // 
            this.shapeToolbar.BackColor = System.Drawing.Color.White;
            this.shapeToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.shapeToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeShapeButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.strokeWidthBox,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.strokeColorBox,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.fillColorBox,
            this.toolStripSeparator4,
            this.toBackButton,
            this.toFrontButton,
            this.toolStripSeparator5,
            this.applyButton});
            this.shapeToolbar.Location = new System.Drawing.Point(0, 0);
            this.shapeToolbar.Name = "shapeToolbar";
            this.shapeToolbar.Size = new System.Drawing.Size(915, 28);
            this.shapeToolbar.TabIndex = 3;
            this.shapeToolbar.Text = "toolStrip1";
            this.shapeToolbar.Visible = false;
            this.shapeToolbar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // removeShapeButton
            // 
            this.removeShapeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeShapeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeShapeButton.Image")));
            this.removeShapeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeShapeButton.Name = "removeShapeButton";
            this.removeShapeButton.Size = new System.Drawing.Size(57, 25);
            this.removeShapeButton.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(92, 25);
            this.toolStripLabel1.Text = "Stroke width";
            // 
            // strokeWidthBox
            // 
            this.strokeWidthBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "4",
            "8",
            "16",
            "24"});
            this.strokeWidthBox.Name = "strokeWidthBox";
            this.strokeWidthBox.Size = new System.Drawing.Size(121, 28);
            this.strokeWidthBox.Text = "1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(89, 25);
            this.toolStripLabel2.Text = "Stroke color";
            // 
            // strokeColorBox
            // 
            this.strokeColorBox.Name = "strokeColorBox";
            this.strokeColorBox.Size = new System.Drawing.Size(121, 28);
            this.strokeColorBox.Text = "Black";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(66, 25);
            this.toolStripLabel3.Text = "Fill color";
            // 
            // fillColorBox
            // 
            this.fillColorBox.Name = "fillColorBox";
            this.fillColorBox.Size = new System.Drawing.Size(121, 28);
            this.fillColorBox.Text = "Black";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toBackButton
            // 
            this.toBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toBackButton.Image")));
            this.toBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toBackButton.Name = "toBackButton";
            this.toBackButton.Size = new System.Drawing.Size(62, 25);
            this.toBackButton.Text = "to back";
            // 
            // toFrontButton
            // 
            this.toFrontButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toFrontButton.Image = ((System.Drawing.Image)(resources.GetObject("toFrontButton.Image")));
            this.toFrontButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toFrontButton.Name = "toFrontButton";
            this.toFrontButton.Size = new System.Drawing.Size(63, 25);
            this.toFrontButton.Text = "to front";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // applyButton
            // 
            this.applyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.applyButton.Image = ((System.Drawing.Image)(resources.GetObject("applyButton.Image")));
            this.applyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(52, 25);
            this.applyButton.Text = "Apply";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "select shape to open toolbox";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 573);
            this.ContextMenuStrip = this.editorMenu;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Editor";
            this.Text = "CubeStudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.editorMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.shapeToolbar.ResumeLayout(false);
            this.shapeToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip editorMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox renderBox;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip shapeToolbar;
        private System.Windows.Forms.ToolStripButton removeShape;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox strokeWidthBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripButton removeShapeButton;
        private System.Windows.Forms.ToolStripButton applyButton;
        private System.Windows.Forms.ToolStripComboBox strokeColorBox;
        private System.Windows.Forms.ToolStripComboBox fillColorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toBackButton;
        private System.Windows.Forms.ToolStripButton toFrontButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

