namespace BusStation
{
    partial class PersonalInformationForm
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
            tbName = new TextBox();
            tbLastName = new TextBox();
            nudNumberOfTickets = new NumericUpDown();
            lblTotalPriceTicket = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnPrintTicket = new Button();
            label1 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTickets).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(29, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(162, 23);
            tbName.TabIndex = 0;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(29, 72);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(162, 23);
            tbLastName.TabIndex = 1;
            // 
            // nudNumberOfTickets
            // 
            nudNumberOfTickets.Location = new Point(29, 123);
            nudNumberOfTickets.Name = "nudNumberOfTickets";
            nudNumberOfTickets.Size = new Size(43, 23);
            nudNumberOfTickets.TabIndex = 2;
            nudNumberOfTickets.ValueChanged += nudNumberOfTickets_ValueChanged;
            // 
            // lblTotalPriceTicket
            // 
            lblTotalPriceTicket.AutoSize = true;
            lblTotalPriceTicket.Location = new Point(251, 28);
            lblTotalPriceTicket.Name = "lblTotalPriceTicket";
            lblTotalPriceTicket.Size = new Size(13, 15);
            lblTotalPriceTicket.TabIndex = 3;
            lblTotalPriceTicket.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 10);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Име";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 54);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Презиме";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 105);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Број на карти";
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.Location = new Point(12, 157);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(129, 23);
            btnPrintTicket.TabIndex = 7;
            btnPrintTicket.Text = "Печати карта";
            btnPrintTicket.UseVisualStyleBackColor = true;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "MKD";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(164, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PersonalInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 192);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(btnPrintTicket);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotalPriceTicket);
            Controls.Add(nudNumberOfTickets);
            Controls.Add(tbLastName);
            Controls.Add(tbName);
            Name = "PersonalInformationForm";
            Text = "PersonalInformationForm";
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbLastName;
        private NumericUpDown nudNumberOfTickets;
        private Label lblTotalPriceTicket;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnPrintTicket;
        private Label label1;
        private Button btnCancel;
    }
}