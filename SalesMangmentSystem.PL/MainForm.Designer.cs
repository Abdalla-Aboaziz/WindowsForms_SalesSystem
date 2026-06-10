namespace SalesMangmentSystem.PL
{
    partial class MainForm
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
            button1 = new Button();
            button3 = new Button();
            SaleOrder = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(220, 234);
            button1.Name = "button1";
            button1.Size = new Size(118, 70);
            button1.TabIndex = 0;
            button1.Text = "الاصناف";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(444, 234);
            button3.Name = "button3";
            button3.Size = new Size(118, 70);
            button3.TabIndex = 2;
            button3.Text = "المجموعات ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // SaleOrder
            // 
            SaleOrder.Location = new Point(147, 378);
            SaleOrder.Name = "SaleOrder";
            SaleOrder.Size = new Size(118, 70);
            SaleOrder.TabIndex = 3;
            SaleOrder.Text = "الفواتير";
            SaleOrder.UseVisualStyleBackColor = true;
            SaleOrder.Click += SaleOrder_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 423);
            button2.Name = "button2";
            button2.Size = new Size(186, 70);
            button2.TabIndex = 4;
            button2.Text = "ادارة العملاء ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 720);
            Controls.Add(button2);
            Controls.Add(SaleOrder);
            Controls.Add(button3);
            Controls.Add(button1);
            Font = new Font("Droid Arabic Kufi", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button SaleOrder;
        private Button button2;
    }
}