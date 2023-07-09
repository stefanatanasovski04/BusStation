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
            components = new System.ComponentModel.Container();
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
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(33, 37);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Name = "tbName";
            tbName.Size = new Size(185, 27);
            tbName.TabIndex = 0;
            tbName.Validating += tbName_Validating;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(33, 96);
            tbLastName.Margin = new Padding(3, 4, 3, 4);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(185, 27);
            tbLastName.TabIndex = 1;
            tbLastName.Validating += tbLastName_Validating;
            // 
            // nudNumberOfTickets
            // 
            nudNumberOfTickets.Location = new Point(33, 164);
            nudNumberOfTickets.Margin = new Padding(3, 4, 3, 4);
            nudNumberOfTickets.Name = "nudNumberOfTickets";
            nudNumberOfTickets.Size = new Size(49, 27);
            nudNumberOfTickets.TabIndex = 2;
            nudNumberOfTickets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfTickets.ValueChanged += nudNumberOfTickets_ValueChanged;
            // 
            // lblTotalPriceTicket
            // 
            lblTotalPriceTicket.AutoSize = true;
            lblTotalPriceTicket.Location = new Point(328, 37);
            lblTotalPriceTicket.Name = "lblTotalPriceTicket";
            lblTotalPriceTicket.Size = new Size(17, 20);
            lblTotalPriceTicket.TabIndex = 3;
            lblTotalPriceTicket.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 13);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Име";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 72);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Презиме";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 140);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Број на карти";
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.Location = new Point(14, 209);
            btnPrintTicket.Margin = new Padding(3, 4, 3, 4);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(147, 31);
            btnPrintTicket.TabIndex = 7;
            btnPrintTicket.Text = "Печати карта";
            btnPrintTicket.UseVisualStyleBackColor = true;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 37);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 8;
            label1.Text = "MKD";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(261, 209);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 31);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PersonalInformationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 256);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "PersonalInformationForm";
            Text = "Информации за корисникот";
            Load += PersonalInformationForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberOfTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private ErrorProvider errorProvider1;
    }
}