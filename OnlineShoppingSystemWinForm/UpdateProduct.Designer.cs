namespace OnlineShoppingSystemWinForm
{
    partial class UpdateProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtProdId = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.TxtProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtProdPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProdDescription = new System.Windows.Forms.TextBox();
            this.PbProductImage = new System.Windows.Forms.PictureBox();
            this.BtnUpdateProduct = new System.Windows.Forms.Button();
            this.CmbProdCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(230, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "UPDATE PRODUCT";
            // 
            // TxtProdId
            // 
            this.TxtProdId.Enabled = false;
            this.TxtProdId.Location = new System.Drawing.Point(301, 133);
            this.TxtProdId.MaximumSize = new System.Drawing.Size(300, 21);
            this.TxtProdId.MinimumSize = new System.Drawing.Size(300, 21);
            this.TxtProdId.Name = "TxtProdId";
            this.TxtProdId.Size = new System.Drawing.Size(300, 20);
            this.TxtProdId.TabIndex = 6;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(49, 121);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(174, 37);
            this.lblProductName.TabIndex = 5;
            this.lblProductName.Text = "Product ID";
            // 
            // TxtProdName
            // 
            this.TxtProdName.Location = new System.Drawing.Point(301, 197);
            this.TxtProdName.MaximumSize = new System.Drawing.Size(300, 21);
            this.TxtProdName.MinimumSize = new System.Drawing.Size(300, 21);
            this.TxtProdName.Name = "TxtProdName";
            this.TxtProdName.Size = new System.Drawing.Size(300, 20);
            this.TxtProdName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product Description";
            // 
            // TxtProdPrice
            // 
            this.TxtProdPrice.Location = new System.Drawing.Point(301, 260);
            this.TxtProdPrice.MaximumSize = new System.Drawing.Size(300, 21);
            this.TxtProdPrice.MinimumSize = new System.Drawing.Size(300, 21);
            this.TxtProdPrice.Name = "TxtProdPrice";
            this.TxtProdPrice.Size = new System.Drawing.Size(300, 20);
            this.TxtProdPrice.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Category";
            // 
            // TxtProdDescription
            // 
            this.TxtProdDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtProdDescription.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProdDescription.Location = new System.Drawing.Point(56, 437);
            this.TxtProdDescription.MaximumSize = new System.Drawing.Size(900, 300);
            this.TxtProdDescription.MinimumSize = new System.Drawing.Size(300, 21);
            this.TxtProdDescription.Multiline = true;
            this.TxtProdDescription.Name = "TxtProdDescription";
            this.TxtProdDescription.Size = new System.Drawing.Size(813, 131);
            this.TxtProdDescription.TabIndex = 10;
            // 
            // PbProductImage
            // 
            this.PbProductImage.BackColor = System.Drawing.Color.DimGray;
            this.PbProductImage.Location = new System.Drawing.Point(637, 115);
            this.PbProductImage.Name = "PbProductImage";
            this.PbProductImage.Size = new System.Drawing.Size(232, 250);
            this.PbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbProductImage.TabIndex = 17;
            this.PbProductImage.TabStop = false;
            // 
            // BtnUpdateProduct
            // 
            this.BtnUpdateProduct.BackColor = System.Drawing.Color.DimGray;
            this.BtnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateProduct.Location = new System.Drawing.Point(574, 585);
            this.BtnUpdateProduct.Name = "BtnUpdateProduct";
            this.BtnUpdateProduct.Size = new System.Drawing.Size(295, 52);
            this.BtnUpdateProduct.TabIndex = 18;
            this.BtnUpdateProduct.Text = "UPDATE PRODUCT";
            this.BtnUpdateProduct.UseVisualStyleBackColor = false;
            // 
            // CmbProdCategory
            // 
            this.CmbProdCategory.FormattingEnabled = true;
            this.CmbProdCategory.Location = new System.Drawing.Point(301, 326);
            this.CmbProdCategory.Name = "CmbProdCategory";
            this.CmbProdCategory.Size = new System.Drawing.Size(300, 21);
            this.CmbProdCategory.TabIndex = 19;
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(930, 650);
            this.Controls.Add(this.CmbProdCategory);
            this.Controls.Add(this.BtnUpdateProduct);
            this.Controls.Add(this.PbProductImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtProdPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtProdDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtProdName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtProdId);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.label1);
            this.Name = "UpdateProduct";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.UpdateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtProdId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox TxtProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtProdPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProdDescription;
        private System.Windows.Forms.PictureBox PbProductImage;
        private System.Windows.Forms.Button BtnUpdateProduct;
        private System.Windows.Forms.ComboBox CmbProdCategory;
    }
}