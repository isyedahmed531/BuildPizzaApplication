namespace BuildPizzaApplication
{
    partial class dialog
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.lblEating = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(114, 204);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 39);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(34, 51);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(43, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size: ";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(34, 83);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(71, 20);
            this.lblToppings.TabIndex = 2;
            this.lblToppings.Text = "Topping: ";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Location = new System.Drawing.Point(34, 117);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(45, 20);
            this.lblCrust.TabIndex = 3;
            this.lblCrust.Text = "Crust:";
            // 
            // lblEating
            // 
            this.lblEating.AutoSize = true;
            this.lblEating.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEating.Location = new System.Drawing.Point(34, 152);
            this.lblEating.Name = "lblEating";
            this.lblEating.Size = new System.Drawing.Size(134, 20);
            this.lblEating.TabIndex = 4;
            this.lblEating.Text = "Eat-In/Take-Away";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(60, 12);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(122, 28);
            this.lblOrder.TabIndex = 5;
            this.lblOrder.Text = "Your Order!";
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 255);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblEating);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "dialog";
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOK;
        private Label lblSize;
        private Label lblToppings;
        private Label lblCrust;
        private Label lblEating;
        private Label lblOrder;
    }
}