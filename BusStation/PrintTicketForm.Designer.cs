namespace BusStation
{
    partial class PrintTicketForm
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
            dgPrint = new DataGridView();
            dgName = new DataGridViewTextBoxColumn();
            dgPrezime = new DataGridViewTextBoxColumn();
            dbLine = new DataGridViewTextBoxColumn();
            dgNumTickets = new DataGridViewTextBoxColumn();
            dgPrice = new DataGridViewTextBoxColumn();
            btnCancelPrintTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPrint).BeginInit();
            SuspendLayout();
            // 
            // dgPrint
            // 
            dgPrint.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPrint.Columns.AddRange(new DataGridViewColumn[] { dgName, dgPrezime, dbLine, dgNumTickets, dgPrice });
            dgPrint.Location = new Point(0, 0);
            dgPrint.Margin = new Padding(3, 4, 3, 4);
            dgPrint.Name = "dgPrint";
            dgPrint.RowHeadersWidth = 51;
            dgPrint.RowTemplate.Height = 25;
            dgPrint.Size = new Size(755, 140);
            dgPrint.TabIndex = 0;
            dgPrint.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dgName
            // 
            dgName.HeaderText = "Име";
            dgName.MinimumWidth = 6;
            dgName.Name = "dgName";
            dgName.Width = 125;
            // 
            // dgPrezime
            // 
            dgPrezime.HeaderText = "Презиме";
            dgPrezime.MinimumWidth = 6;
            dgPrezime.Name = "dgPrezime";
            dgPrezime.Width = 125;
            // 
            // dbLine
            // 
            dbLine.HeaderText = "Линија";
            dbLine.MinimumWidth = 6;
            dbLine.Name = "dbLine";
            dbLine.Width = 200;
            // 
            // dgNumTickets
            // 
            dgNumTickets.HeaderText = "Број Карти";
            dgNumTickets.MinimumWidth = 6;
            dgNumTickets.Name = "dgNumTickets";
            dgNumTickets.Width = 125;
            // 
            // dgPrice
            // 
            dgPrice.HeaderText = "Цена";
            dgPrice.MinimumWidth = 6;
            dgPrice.Name = "dgPrice";
            dgPrice.Width = 125;
            // 
            // btnCancelPrintTicket
            // 
            btnCancelPrintTicket.Location = new Point(126, 167);
            btnCancelPrintTicket.Name = "btnCancelPrintTicket";
            btnCancelPrintTicket.Size = new Size(527, 29);
            btnCancelPrintTicket.TabIndex = 1;
            btnCancelPrintTicket.Text = "Продолжи";
            btnCancelPrintTicket.UseVisualStyleBackColor = true;
            btnCancelPrintTicket.Click += btnCancelPrintTicket_Click;
            // 
            // PrintTicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 208);
            Controls.Add(btnCancelPrintTicket);
            Controls.Add(dgPrint);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PrintTicketForm";
            Text = "PrintTicketForm";
            Load += PrintTicketForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPrint;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgPrezime;
        private DataGridViewTextBoxColumn dbLine;
        private DataGridViewTextBoxColumn dgNumTickets;
        private DataGridViewTextBoxColumn dgPrice;
        private Button btnCancelPrintTicket;
    }
}