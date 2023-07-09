namespace BusStation
{
    partial class AddStationForm
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
            label1 = new Label();
            label2 = new Label();
            tbCountry = new TextBox();
            tbCity = new TextBox();
            btnAddStation = new Button();
            btnCancelAddStation = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Град";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 1;
            label2.Text = "Држава";
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(12, 115);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(311, 27);
            tbCountry.TabIndex = 2;
            tbCountry.Validating += tbCountry_Validating;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(12, 49);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(311, 27);
            tbCity.TabIndex = 3;
            tbCity.Validating += tbCity_Validating;
            // 
            // btnAddStation
            // 
            btnAddStation.Location = new Point(12, 172);
            btnAddStation.Name = "btnAddStation";
            btnAddStation.Size = new Size(149, 29);
            btnAddStation.TabIndex = 4;
            btnAddStation.Text = "Додади";
            btnAddStation.UseVisualStyleBackColor = true;
            btnAddStation.Click += btnAddStation_Click;
            // 
            // btnCancelAddStation
            // 
            btnCancelAddStation.Location = new Point(206, 172);
            btnCancelAddStation.Name = "btnCancelAddStation";
            btnCancelAddStation.Size = new Size(149, 29);
            btnCancelAddStation.TabIndex = 5;
            btnCancelAddStation.Text = "Откажи";
            btnCancelAddStation.UseVisualStyleBackColor = true;
            btnCancelAddStation.Click += btnCancelAddStation_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddStationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 244);
            Controls.Add(btnCancelAddStation);
            Controls.Add(btnAddStation);
            Controls.Add(tbCity);
            Controls.Add(tbCountry);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddStationForm";
            Text = "AddStationForm";
            Load += AddStationForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbCountry;
        private TextBox tbCity;
        private Button btnAddStation;
        private Button btnCancelAddStation;
        private ErrorProvider errorProvider1;
    }
}