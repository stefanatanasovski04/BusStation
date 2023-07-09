namespace BusStation
{
    partial class AddDestinationForm
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
            btnCancelAddDestination = new Button();
            btnAddDestination = new Button();
            tbPrice = new TextBox();
            tbDistance = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lbStationsInAdd = new ListBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelAddDestination
            // 
            btnCancelAddDestination.Location = new Point(206, 161);
            btnCancelAddDestination.Name = "btnCancelAddDestination";
            btnCancelAddDestination.Size = new Size(149, 29);
            btnCancelAddDestination.TabIndex = 11;
            btnCancelAddDestination.Text = "Откажи";
            btnCancelAddDestination.UseVisualStyleBackColor = true;
            btnCancelAddDestination.Click += btnCancelAddDestination_Click;
            // 
            // btnAddDestination
            // 
            btnAddDestination.Location = new Point(12, 161);
            btnAddDestination.Name = "btnAddDestination";
            btnAddDestination.Size = new Size(149, 29);
            btnAddDestination.TabIndex = 10;
            btnAddDestination.Text = "Додади";
            btnAddDestination.UseVisualStyleBackColor = true;
            btnAddDestination.Click += btnAddDestination_Click;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(12, 38);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(311, 27);
            tbPrice.TabIndex = 9;
            tbPrice.Validating += tbPrice_Validating;
            // 
            // tbDistance
            // 
            tbDistance.Location = new Point(12, 104);
            tbDistance.Name = "tbDistance";
            tbDistance.Size = new Size(311, 27);
            tbDistance.TabIndex = 8;
            tbDistance.Validating += tbDistance_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 7;
            label2.Text = "Далечина";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 6;
            label1.Text = "Цена";
            // 
            // lbStationsInAdd
            // 
            lbStationsInAdd.FormattingEnabled = true;
            lbStationsInAdd.ItemHeight = 20;
            lbStationsInAdd.Location = new Point(396, 47);
            lbStationsInAdd.Name = "lbStationsInAdd";
            lbStationsInAdd.Size = new Size(271, 164);
            lbStationsInAdd.TabIndex = 12;
            lbStationsInAdd.Validating += lbStationsInAdd_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 24);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 13;
            label3.Text = "Дестинација";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddDestinationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 226);
            Controls.Add(label3);
            Controls.Add(lbStationsInAdd);
            Controls.Add(btnCancelAddDestination);
            Controls.Add(btnAddDestination);
            Controls.Add(tbPrice);
            Controls.Add(tbDistance);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDestinationForm";
            Text = "AddDestinationForm";
            Load += AddDestinationForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelAddDestination;
        private Button btnAddDestination;
        private TextBox tbPrice;
        private TextBox tbDistance;
        private Label label2;
        private Label label1;
        private ListBox lbStationsInAdd;
        private Label label3;
        private ErrorProvider errorProvider1;
    }
}