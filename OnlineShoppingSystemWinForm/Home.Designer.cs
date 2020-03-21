namespace OnlineShoppingSystemWinForm
{
    partial class Home
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
            this.BtnAddProduct = new System.Windows.Forms.Button();
            this.BtnViewProducts = new System.Windows.Forms.Button();
            this.BtnDeleteProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAddProduct
            // 
            this.BtnAddProduct.BackColor = System.Drawing.Color.DimGray;
            this.BtnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.BtnAddProduct.Location = new System.Drawing.Point(338, 182);
            this.BtnAddProduct.Name = "BtnAddProduct";
            this.BtnAddProduct.Size = new System.Drawing.Size(468, 94);
            this.BtnAddProduct.TabIndex = 0;
            this.BtnAddProduct.Text = "ADD PRODUCT";
            this.BtnAddProduct.UseVisualStyleBackColor = false;
            this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // BtnViewProducts
            // 
            this.BtnViewProducts.BackColor = System.Drawing.Color.DimGray;
            this.BtnViewProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewProducts.ForeColor = System.Drawing.Color.White;
            this.BtnViewProducts.Location = new System.Drawing.Point(338, 356);
            this.BtnViewProducts.Name = "BtnViewProducts";
            this.BtnViewProducts.Size = new System.Drawing.Size(468, 94);
            this.BtnViewProducts.TabIndex = 1;
            this.BtnViewProducts.Text = "VIEW PRODUCTS";
            this.BtnViewProducts.UseVisualStyleBackColor = false;
            this.BtnViewProducts.Click += new System.EventHandler(this.BtnViewProducts_Click);
            // 
            // BtnDeleteProduct
            // 
            this.BtnDeleteProduct.BackColor = System.Drawing.Color.DimGray;
            this.BtnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteProduct.Location = new System.Drawing.Point(338, 531);
            this.BtnDeleteProduct.Name = "BtnDeleteProduct";
            this.BtnDeleteProduct.Size = new System.Drawing.Size(468, 94);
            this.BtnDeleteProduct.TabIndex = 2;
            this.BtnDeleteProduct.Text = "DELETE PRODUCT";
            this.BtnDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(251, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "ONLINE SHOPPING SYSTEM";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeleteProduct);
            this.Controls.Add(this.BtnViewProducts);
            this.Controls.Add(this.BtnAddProduct);
            this.Name = "Home";
            this.Text = "Online Shopping System - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnViewProducts;
        private System.Windows.Forms.Button BtnDeleteProduct;
        private System.Windows.Forms.Label label1;
    }
}

