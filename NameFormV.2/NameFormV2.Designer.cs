namespace StudentFormV._2
{
    partial class NameFormV2
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.displayEditBox = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.displayAllBox = new System.Windows.Forms.TextBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.countText = new System.Windows.Forms.Label();
            this.findNumberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(22, 27);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(144, 34);
            this.nameBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(303, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 34);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "ค้นหาชื่อ";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(425, 27);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(107, 34);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "ลบชื่อ";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // displayEditBox
            // 
            this.displayEditBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEditBox.Location = new System.Drawing.Point(285, 81);
            this.displayEditBox.Multiline = true;
            this.displayEditBox.Name = "displayEditBox";
            this.displayEditBox.Size = new System.Drawing.Size(153, 38);
            this.displayEditBox.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(457, 81);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 38);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "แก้ไขชื่อ";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // displayAllBox
            // 
            this.displayAllBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayAllBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAllBox.Location = new System.Drawing.Point(22, 145);
            this.displayAllBox.Multiline = true;
            this.displayAllBox.Name = "displayAllBox";
            this.displayAllBox.Size = new System.Drawing.Size(416, 135);
            this.displayAllBox.TabIndex = 7;
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showAllButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllButton.Location = new System.Drawing.Point(457, 145);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 135);
            this.showAllButton.TabIndex = 8;
            this.showAllButton.Text = "แสดงรายชื่อทั้งหมด";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(22, 81);
            this.numberBox.Multiline = true;
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(49, 38);
            this.numberBox.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(182, 27);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 34);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "เพิ่มชื่อ";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countText
            // 
            this.countText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countText.AutoSize = true;
            this.countText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countText.Location = new System.Drawing.Point(444, 297);
            this.countText.Name = "countText";
            this.countText.Size = new System.Drawing.Size(104, 25);
            this.countText.TabIndex = 11;
            this.countText.Text = "จำนวน: 0 คน";
            // 
            // findNumberButton
            // 
            this.findNumberButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findNumberButton.Location = new System.Drawing.Point(90, 81);
            this.findNumberButton.Name = "findNumberButton";
            this.findNumberButton.Size = new System.Drawing.Size(171, 38);
            this.findNumberButton.TabIndex = 12;
            this.findNumberButton.Text = "ค้นหาชื่อจากลำดับที่";
            this.findNumberButton.UseVisualStyleBackColor = true;
            this.findNumberButton.Click += new System.EventHandler(this.findNumberButton_Click);
            // 
            // NameFormV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 328);
            this.Controls.Add(this.findNumberButton);
            this.Controls.Add(this.countText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.displayAllBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.displayEditBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameBox);
            this.MaximizeBox = false;
            this.Name = "NameFormV2";
            this.Text = "NameFormV.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox displayEditBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox displayAllBox;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label countText;
        private System.Windows.Forms.Button findNumberButton;
    }
}

