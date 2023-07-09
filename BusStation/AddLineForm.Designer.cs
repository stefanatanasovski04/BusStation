namespace BusStation
{
    partial class AddLineForm
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
            dtpDate = new DateTimePicker();
            lblTakeoffDestination = new Label();
            label2 = new Label();
            btnAddLine = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(26, 108);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(554, 27);
            dtpDate.TabIndex = 0;
            dtpDate.Value = new DateTime(2023, 7, 1, 0, 0, 0, 0);
            dtpDate.Validating += dtpDate_Validating;
            // 
            // lblTakeoffDestination
            // 
            lblTakeoffDestination.AutoSize = true;
            lblTakeoffDestination.Location = new Point(225, 20);
            lblTakeoffDestination.Name = "lblTakeoffDestination";
            lblTakeoffDestination.Size = new Size(15, 20);
            lblTakeoffDestination.TabIndex = 1;
            lblTakeoffDestination.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Датум";
            // 
            // btnAddLine
            // 
            btnAddLine.Location = new Point(12, 168);
            btnAddLine.Name = "btnAddLine";
            btnAddLine.Size = new Size(264, 29);
            btnAddLine.TabIndex = 5;
            btnAddLine.Text = "Додади";
            btnAddLine.UseVisualStyleBackColor = true;
            btnAddLine.Click += btnAddLine_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(316, 168);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(264, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddLineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAddLine);
            Controls.Add(label2);
            Controls.Add(lblTakeoffDestination);
            Controls.Add(dtpDate);
            Name = "AddLineForm";
            Text = "AddLineForm";
            Load += AddLineForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDate;
        private Label lblTakeoffDestination;
        private Label label2;
        private Button btnAddLine;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}