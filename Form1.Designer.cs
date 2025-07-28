namespace Workshop_Selector_App
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
            lstWorkshops = new ListBox();
            lstLocations = new ListBox();
            btnCalculate = new Button();
            lblRegistration = new Label();
            lblLodging = new Label();
            lblTotal = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // lstWorkshops
            // 
            lstWorkshops.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstWorkshops.FormattingEnabled = true;
            lstWorkshops.ItemHeight = 21;
            lstWorkshops.Location = new Point(66, 199);
            lstWorkshops.Name = "lstWorkshops";
            lstWorkshops.Size = new Size(308, 214);
            lstWorkshops.TabIndex = 0;
            // 
            // lstLocations
            // 
            lstLocations.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLocations.FormattingEnabled = true;
            lstLocations.ItemHeight = 21;
            lstLocations.Location = new Point(784, 199);
            lstLocations.Name = "lstLocations";
            lstLocations.Size = new Size(308, 235);
            lstLocations.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(420, 488);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(334, 53);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate Cost";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(66, 602);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(148, 19);
            lblRegistration.TabIndex = 3;
            lblRegistration.Text = "Registration Cost:";
            // 
            // lblLodging
            // 
            lblLodging.AutoSize = true;
            lblLodging.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLodging.Location = new Point(66, 660);
            lblLodging.Name = "lblLodging";
            lblLodging.Size = new Size(119, 19);
            lblLodging.TabIndex = 4;
            lblLodging.Text = "Lodging Cost:";
            lblLodging.Click += label2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(66, 725);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 19);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Cost:";
            lblTotal.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, 159);
            label4.Name = "label4";
            label4.Size = new Size(93, 24);
            label4.TabIndex = 6;
            label4.Text = "Workshop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(908, 159);
            label5.Name = "label5";
            label5.Size = new Size(77, 24);
            label5.TabIndex = 7;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(420, 74);
            label6.Name = "label6";
            label6.Size = new Size(334, 39);
            label6.TabIndex = 8;
            label6.Text = "WORKSHOP SELECTOR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 780);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(lblLodging);
            Controls.Add(lblRegistration);
            Controls.Add(btnCalculate);
            Controls.Add(lstLocations);
            Controls.Add(lstWorkshops);
            Font = new Font("SimSun", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Workshop Selector App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstWorkshops;
        private ListBox lstLocations;
        private Button btnCalculate;
        private Label lblRegistration;
        private Label lblLodging;
        private Label lblTotal;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
