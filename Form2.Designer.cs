namespace project12_1
{
    partial class formNotepadA1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleUnderlineTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freestyleScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lucidaHandwritingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushScriptMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edwardianScriptITCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchScriptMTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kunstlerScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eightPtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenPtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twelvePtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eightteenPtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twentytwoPtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlA1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRichTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions = new System.Windows.Forms.ToolStripTextBox();
            this.contectMenuStripRichTextBoxToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControlA1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStripRichTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.deleteTabToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // deleteTabToolStripMenuItem
            // 
            this.deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            this.deleteTabToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.deleteTabToolStripMenuItem.Text = "Delete Tab";
            this.deleteTabToolStripMenuItem.Click += new System.EventHandler(this.deleteTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.saveToolStripMenuItem.Text = "Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.toggleUnderlineTextToolStripMenuItem,
            this.fontTypeToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // toggleUnderlineTextToolStripMenuItem
            // 
            this.toggleUnderlineTextToolStripMenuItem.Name = "toggleUnderlineTextToolStripMenuItem";
            this.toggleUnderlineTextToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.toggleUnderlineTextToolStripMenuItem.Text = "Toggle Underline Text";
            this.toggleUnderlineTextToolStripMenuItem.Click += new System.EventHandler(this.toggleUnderlineTextToolStripMenuItem_Click);
            // 
            // fontTypeToolStripMenuItem
            // 
            this.fontTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timesNToolStripMenuItem,
            this.freestyleScriptToolStripMenuItem,
            this.lucidaHandwritingToolStripMenuItem,
            this.segoeScriptToolStripMenuItem,
            this.brushScriptMTToolStripMenuItem,
            this.edwardianScriptITCToolStripMenuItem,
            this.frenchScriptMTToolStripMenuItem,
            this.kunstlerScriptToolStripMenuItem});
            this.fontTypeToolStripMenuItem.Name = "fontTypeToolStripMenuItem";
            this.fontTypeToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.fontTypeToolStripMenuItem.Text = "Font Type";
            // 
            // timesNToolStripMenuItem
            // 
            this.timesNToolStripMenuItem.Name = "timesNToolStripMenuItem";
            this.timesNToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.timesNToolStripMenuItem.Text = "Times New Roman";
            this.timesNToolStripMenuItem.Click += new System.EventHandler(this.timesNewRomanToolStripMenuItem_Click);
            // 
            // freestyleScriptToolStripMenuItem
            // 
            this.freestyleScriptToolStripMenuItem.Name = "freestyleScriptToolStripMenuItem";
            this.freestyleScriptToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.freestyleScriptToolStripMenuItem.Text = "Freestyle Script";
            this.freestyleScriptToolStripMenuItem.Click += new System.EventHandler(this.freestyleScriptToolStripMenuItem_Click);
            // 
            // lucidaHandwritingToolStripMenuItem
            // 
            this.lucidaHandwritingToolStripMenuItem.Name = "lucidaHandwritingToolStripMenuItem";
            this.lucidaHandwritingToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.lucidaHandwritingToolStripMenuItem.Text = "Lucida Handwriting";
            this.lucidaHandwritingToolStripMenuItem.Click += new System.EventHandler(this.lucidaHandwritingToolStripMenuItem_Click);
            // 
            // segoeScriptToolStripMenuItem
            // 
            this.segoeScriptToolStripMenuItem.Name = "segoeScriptToolStripMenuItem";
            this.segoeScriptToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.segoeScriptToolStripMenuItem.Text = "Segoe Script";
            this.segoeScriptToolStripMenuItem.Click += new System.EventHandler(this.segoeScriptToolStripMenuItem_Click);
            // 
            // brushScriptMTToolStripMenuItem
            // 
            this.brushScriptMTToolStripMenuItem.Name = "brushScriptMTToolStripMenuItem";
            this.brushScriptMTToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.brushScriptMTToolStripMenuItem.Text = "Brush Script MT";
            this.brushScriptMTToolStripMenuItem.Click += new System.EventHandler(this.brushScriptMTToolStripMenuItem_Click);
            // 
            // edwardianScriptITCToolStripMenuItem
            // 
            this.edwardianScriptITCToolStripMenuItem.Name = "edwardianScriptITCToolStripMenuItem";
            this.edwardianScriptITCToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.edwardianScriptITCToolStripMenuItem.Text = "Edwardian Script ITC";
            this.edwardianScriptITCToolStripMenuItem.Click += new System.EventHandler(this.edwardianScriptITCToolStripMenuItem_Click);
            // 
            // frenchScriptMTToolStripMenuItem
            // 
            this.frenchScriptMTToolStripMenuItem.Name = "frenchScriptMTToolStripMenuItem";
            this.frenchScriptMTToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.frenchScriptMTToolStripMenuItem.Text = "French Script MT";
            this.frenchScriptMTToolStripMenuItem.Click += new System.EventHandler(this.frenchScriptMTToolStripMenuItem_Click);
            // 
            // kunstlerScriptToolStripMenuItem
            // 
            this.kunstlerScriptToolStripMenuItem.Name = "kunstlerScriptToolStripMenuItem";
            this.kunstlerScriptToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.kunstlerScriptToolStripMenuItem.Text = "Kunstler Script";
            this.kunstlerScriptToolStripMenuItem.Click += new System.EventHandler(this.kunstlerScriptToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eightPtToolStripMenuItem,
            this.tenPtToolStripMenuItem,
            this.twelvePtToolStripMenuItem,
            this.eightteenPtToolStripMenuItem,
            this.twentytwoPtToolStripMenuItem});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.fontSizeToolStripMenuItem.Text = "Font Size";
            // 
            // eightPtToolStripMenuItem
            // 
            this.eightPtToolStripMenuItem.Name = "eightPtToolStripMenuItem";
            this.eightPtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eightPtToolStripMenuItem.Text = "8pt";
            this.eightPtToolStripMenuItem.Click += new System.EventHandler(this.eightPtToolStripMenuItem_Click);
            // 
            // tenPtToolStripMenuItem
            // 
            this.tenPtToolStripMenuItem.Name = "tenPtToolStripMenuItem";
            this.tenPtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tenPtToolStripMenuItem.Text = "10pt";
            this.tenPtToolStripMenuItem.Click += new System.EventHandler(this.tenPtToolStripMenuItem_Click);
            // 
            // twelvePtToolStripMenuItem
            // 
            this.twelvePtToolStripMenuItem.Name = "twelvePtToolStripMenuItem";
            this.twelvePtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.twelvePtToolStripMenuItem.Text = "12pt";
            this.twelvePtToolStripMenuItem.Click += new System.EventHandler(this.twelvePtToolStripMenuItem_Click);
            // 
            // eightteenPtToolStripMenuItem
            // 
            this.eightteenPtToolStripMenuItem.Name = "eightteenPtToolStripMenuItem";
            this.eightteenPtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eightteenPtToolStripMenuItem.Text = "18pt";
            this.eightteenPtToolStripMenuItem.Click += new System.EventHandler(this.eightteenPtToolStripMenuItem_Click);
            // 
            // twentytwoPtToolStripMenuItem
            // 
            this.twentytwoPtToolStripMenuItem.Name = "twentytwoPtToolStripMenuItem";
            this.twentytwoPtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.twentytwoPtToolStripMenuItem.Text = "22pt";
            this.twentytwoPtToolStripMenuItem.Click += new System.EventHandler(this.twentytwoPtToolStripMenuItem_Click);
            // 
            // tabControlA1
            // 
            this.tabControlA1.Controls.Add(this.tabPage1);
            this.tabControlA1.Location = new System.Drawing.Point(12, 36);
            this.tabControlA1.Name = "tabControlA1";
            this.tabControlA1.SelectedIndex = 0;
            this.tabControlA1.Size = new System.Drawing.Size(1026, 603);
            this.tabControlA1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStripRichTextBox;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1006, 558);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // contextMenuStripRichTextBox
            // 
            this.contextMenuStripRichTextBox.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripRichTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions,
            this.contectMenuStripRichTextBoxToolStripSeparator,
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor});
            this.contextMenuStripRichTextBox.Name = "contextMenuStripRichTextBox";
            this.contextMenuStripRichTextBox.Size = new System.Drawing.Size(281, 77);
            // 
            // contectMenuStripRichTextBoxToolStripTextBoxInstructions
            // 
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions.Name = "contectMenuStripRichTextBoxToolStripTextBoxInstructions";
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions.ReadOnly = true;
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions.Size = new System.Drawing.Size(220, 31);
            this.contectMenuStripRichTextBoxToolStripTextBoxInstructions.Text = "Font Color Options:";
            // 
            // contectMenuStripRichTextBoxToolStripSeparator
            // 
            this.contectMenuStripRichTextBoxToolStripSeparator.Name = "contectMenuStripRichTextBoxToolStripSeparator";
            this.contectMenuStripRichTextBoxToolStripSeparator.Size = new System.Drawing.Size(175, 6);
            // 
            // contectMenuStripRichTextBoxToolStripMenuItemFontColor
            // 
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor.Name = "contectMenuStripRichTextBoxToolStripMenuItemFontColor";
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor.Size = new System.Drawing.Size(178, 32);
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor.Text = "Font Colour";
            this.contectMenuStripRichTextBoxToolStripMenuItemFontColor.Click += new System.EventHandler(this.contectMenuStripRichTextBoxToolStripMenuItemFontColor_Click);
            // 
            // formNotepadA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 644);
            this.Controls.Add(this.tabControlA1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formNotepadA1";
            this.Text = "Notepad A1";
            this.Load += new System.EventHandler(this.formNotepadA1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlA1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStripRichTextBox.ResumeLayout(false);
            this.contextMenuStripRichTextBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlA1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toggleUnderlineTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freestyleScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eightPtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenPtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twelvePtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eightteenPtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twentytwoPtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lucidaHandwritingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segoeScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushScriptMTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edwardianScriptITCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchScriptMTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kunstlerScriptToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRichTextBox;
        private System.Windows.Forms.ToolStripTextBox contectMenuStripRichTextBoxToolStripTextBoxInstructions;
        private System.Windows.Forms.ToolStripSeparator contectMenuStripRichTextBoxToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem contectMenuStripRichTextBoxToolStripMenuItemFontColor;
    }
}