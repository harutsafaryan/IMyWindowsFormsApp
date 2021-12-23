
namespace IMyWindowsFormsApp.Forms
{
    partial class AddressForm
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
            this.lblGuid = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.grdAddresses = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddresses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuid
            // 
            this.lblGuid.AutoSize = true;
            this.lblGuid.Location = new System.Drawing.Point(169, 16);
            this.lblGuid.Name = "lblGuid";
            this.lblGuid.Size = new System.Drawing.Size(39, 13);
            this.lblGuid.TabIndex = 1;
            this.lblGuid.Text = "lblGuid";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(172, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(323, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // grdAddresses
            // 
            this.grdAddresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAddresses.Location = new System.Drawing.Point(12, 142);
            this.grdAddresses.Name = "grdAddresses";
            this.grdAddresses.Size = new System.Drawing.Size(483, 150);
            this.grdAddresses.TabIndex = 4;
            this.grdAddresses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAddresses_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(526, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(526, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(526, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "StudentId";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(68, 78);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Full Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(169, 46);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(51, 13);
            this.lblFullName.TabIndex = 9;
            this.lblFullName.Text = "FullName";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 336);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grdAddresses);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblGuid);
            this.Controls.Add(this.lblId);
            this.Name = "AddressForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAddresses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGuid;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView grdAddresses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
    }
}