using System.Windows.Forms;
using DarkUI.Controls;
using Intersect.Editor.Forms.Controls;

namespace Intersect.Editor.Forms.DockingElements
{
    partial class FrmMapList
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapList));
            toolStrip1 = new DarkToolStrip();
            btnAlphabetical = new ToolStripButton();
            toolSelectMap = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNewMap = new ToolStripButton();
            btnNewFolder = new ToolStripButton();
            btnRename = new ToolStripButton();
            btnDelete = new ToolStripButton();
            newMapToolStripMenuItem = new ToolStripMenuItem();
            renameToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            newFolderToolStripMenuItem = new ToolStripMenuItem();
            copyIdToolStripMenuItem = new ToolStripMenuItem();
            mapTreeList = new MapTreeList();
            toolStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            toolStrip1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAlphabetical, toolSelectMap, toolStripSeparator1, btnNewMap, btnNewFolder, btnRename, btnDelete });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(189, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAlphabetical
            // 
            btnAlphabetical.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAlphabetical.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnAlphabetical.Image = (Image)resources.GetObject("btnAlphabetical.Image");
            btnAlphabetical.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAlphabetical.Name = "btnAlphabetical";
            btnAlphabetical.Size = new Size(23, 22);
            btnAlphabetical.Text = "Order Chronologically";
            btnAlphabetical.Click += btnAlphabetical_Click;
            // 
            // toolSelectMap
            // 
            toolSelectMap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolSelectMap.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolSelectMap.Image = (Image)resources.GetObject("toolSelectMap.Image");
            toolSelectMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolSelectMap.Name = "toolSelectMap";
            toolSelectMap.Size = new Size(23, 22);
            toolSelectMap.Text = "Select Current Map";
            toolSelectMap.Click += toolSelectMap_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            toolStripSeparator1.Margin = new Padding(0, 0, 2, 0);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnNewMap
            // 
            btnNewMap.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewMap.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnNewMap.Image = (Image)resources.GetObject("btnNewMap.Image");
            btnNewMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNewMap.Name = "btnNewMap";
            btnNewMap.Size = new Size(23, 22);
            btnNewMap.Text = "New Map";
            btnNewMap.Click += btnNewMap_Click;
            // 
            // btnNewFolder
            // 
            btnNewFolder.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnNewFolder.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnNewFolder.Image = (Image)resources.GetObject("btnNewFolder.Image");
            btnNewFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNewFolder.Name = "btnNewFolder";
            btnNewFolder.Size = new Size(23, 22);
            btnNewFolder.Text = "New Folder";
            btnNewFolder.Click += btnNewFolder_Click;
            // 
            // btnRename
            // 
            btnRename.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRename.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnRename.Image = (Image)resources.GetObject("btnRename.Image");
            btnRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(23, 22);
            btnRename.Text = "Rename";
            btnRename.Click += btnRename_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(23, 22);
            btnDelete.Text = "Delete Map or Folder";
            btnDelete.Click += btnDelete_Click;
            // 
            // newMapToolStripMenuItem
            // 
            newMapToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            newMapToolStripMenuItem.ShortcutKeys = Keys.F1;
            newMapToolStripMenuItem.Size = new Size(180, 22);
            newMapToolStripMenuItem.Text = "New Map";
            newMapToolStripMenuItem.Click += btnNewMap_Click;
            // 
            // renameToolStripMenuItem
            // 
            renameToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            renameToolStripMenuItem.ShortcutKeys = Keys.F2;
            renameToolStripMenuItem.Size = new Size(180, 22);
            renameToolStripMenuItem.Text = "Rename";
            renameToolStripMenuItem.Click += btnRename_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.F4;
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += btnDelete_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { newMapToolStripMenuItem, newFolderToolStripMenuItem, copyIdToolStripMenuItem, deleteToolStripMenuItem, renameToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(181, 136);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // newFolderToolStripMenuItem
            // 
            newFolderToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            newFolderToolStripMenuItem.ShortcutKeys = Keys.F3;
            newFolderToolStripMenuItem.Size = new Size(180, 22);
            newFolderToolStripMenuItem.Text = "New Folder";
            newFolderToolStripMenuItem.Click += btnNewFolder_Click;
            // 
            // copyIdToolStripMenuItem
            // 
            copyIdToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            copyIdToolStripMenuItem.Name = "copyIdToolStripMenuItem";
            copyIdToolStripMenuItem.Size = new Size(180, 22);
            copyIdToolStripMenuItem.Text = "Copy Id";
            copyIdToolStripMenuItem.Click += copyIdToolStripMenuItem_Click;
            // 
            // mapTreeList
            // 
            mapTreeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mapTreeList.Location = new System.Drawing.Point(0, 25);
            mapTreeList.Margin = new Padding(4, 3, 4, 3);
            mapTreeList.Name = "mapTreeList";
            mapTreeList.Size = new Size(189, 182);
            mapTreeList.TabIndex = 5;
            // 
            // FrmMapList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 207);
            CloseButton = false;
            CloseButtonVisible = false;
            Controls.Add(mapTreeList);
            Controls.Add(toolStrip1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmMapList";
            Text = "Map List";
            Load += frmMapList_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private DarkToolStrip toolStrip1;
        private ToolStripButton btnNewFolder;
        private ToolStripButton btnRename;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAlphabetical;
        private ToolStripButton btnDelete;
        private ToolStripButton btnNewMap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem renameToolStripMenuItem;
        private ToolStripMenuItem newMapToolStripMenuItem;
        public Controls.MapTreeList mapTreeList;
        private ToolStripButton toolSelectMap;
        private ToolStripMenuItem newFolderToolStripMenuItem;
        private ToolStripMenuItem copyIdToolStripMenuItem;
    }
}