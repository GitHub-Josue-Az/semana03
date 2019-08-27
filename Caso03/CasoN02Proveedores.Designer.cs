namespace Caso03
{
    partial class CasoN02Proveedores
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
            this.dgProveedores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProveedores
            // 
            this.dgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedores.Location = new System.Drawing.Point(21, 12);
            this.dgProveedores.Name = "dgProveedores";
            this.dgProveedores.Size = new System.Drawing.Size(548, 285);
            this.dgProveedores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de proveedore";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(173, 334);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(35, 13);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CasoN02Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProveedores);
            this.Name = "CasoN02Proveedores";
            this.Text = "CasoN02Proveedores";
            this.Load += new System.EventHandler(this.CasoN02Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Button button1;
    }
}