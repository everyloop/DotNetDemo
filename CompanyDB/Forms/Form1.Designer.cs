namespace CompanyDB
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxContactName = new System.Windows.Forms.TextBox();
            this.labelContactName = new System.Windows.Forms.Label();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.contextMenuStripOrders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 589);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddRow);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxPhone);
            this.splitContainer2.Panel1.Controls.Add(this.labelPhone);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxContactName);
            this.splitContainer2.Panel1.Controls.Add(this.labelContactName);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxOrderDate);
            this.splitContainer2.Panel1.Controls.Add(this.labelOrderDate);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxOrderID);
            this.splitContainer2.Panel1.Controls.Add(this.labelOrderID);
            this.splitContainer2.Size = new System.Drawing.Size(530, 589);
            this.splitContainer2.SplitterDistance = 230;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Location = new System.Drawing.Point(16, 184);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(94, 29);
            this.buttonAddRow.TabIndex = 8;
            this.buttonAddRow.Text = "Add row";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(180, 114);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(125, 27);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(180, 91);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(53, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxContactName
            // 
            this.textBoxContactName.Location = new System.Drawing.Point(180, 41);
            this.textBoxContactName.Name = "textBoxContactName";
            this.textBoxContactName.Size = new System.Drawing.Size(125, 27);
            this.textBoxContactName.TabIndex = 5;
            // 
            // labelContactName
            // 
            this.labelContactName.AutoSize = true;
            this.labelContactName.Location = new System.Drawing.Point(180, 18);
            this.labelContactName.Name = "labelContactName";
            this.labelContactName.Size = new System.Drawing.Size(104, 20);
            this.labelContactName.TabIndex = 4;
            this.labelContactName.Text = "Contact name:";
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.Location = new System.Drawing.Point(16, 114);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.Size = new System.Drawing.Size(125, 27);
            this.textBoxOrderDate.TabIndex = 3;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(16, 91);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(86, 20);
            this.labelOrderDate.TabIndex = 2;
            this.labelOrderDate.Text = "Order Date:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(16, 41);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(125, 27);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(16, 18);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(69, 20);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID:";
            // 
            // contextMenuStripOrders
            // 
            this.contextMenuStripOrders.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripOrders.Name = "contextMenuStripOrders";
            this.contextMenuStripOrders.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripMenuItemInsert
            // 
            this.toolStripMenuItemInsert.Name = "toolStripMenuItemInsert";
            this.toolStripMenuItemInsert.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxContactName;
        private System.Windows.Forms.Label labelContactName;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOrders;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInsert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
    }
}

