namespace BusStation
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
            lbStations = new ListBox();
            label1 = new Label();
            lbDestinations = new ListBox();
            label2 = new Label();
            label3 = new Label();
            lbLines = new ListBox();
            btnBuy = new Button();
            btnAddStation = new Button();
            btnAddDestination = new Button();
            btnAddLine = new Button();
            SuspendLayout();
            // 
            // lbStations
            // 
            lbStations.FormattingEnabled = true;
            lbStations.ItemHeight = 20;
            lbStations.Location = new Point(37, 43);
            lbStations.Name = "lbStations";
            lbStations.Size = new Size(181, 344);
            lbStations.TabIndex = 0;
            lbStations.SelectedIndexChanged += lbStations_SelectedIndexChanged;
            lbStations.SelectedValueChanged += lbStations_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Станици";
            // 
            // lbDestinations
            // 
            lbDestinations.FormattingEnabled = true;
            lbDestinations.ItemHeight = 20;
            lbDestinations.Location = new Point(245, 43);
            lbDestinations.Name = "lbDestinations";
            lbDestinations.Size = new Size(377, 344);
            lbDestinations.TabIndex = 2;
            lbDestinations.SelectedIndexChanged += lbDestinations_SelectedIndexChanged;
            lbDestinations.SelectedValueChanged += lbDestinations_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 20);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 3;
            label2.Text = "Дестинации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(641, 20);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 4;
            label3.Text = "Линии";
            // 
            // lbLines
            // 
            lbLines.FormattingEnabled = true;
            lbLines.ItemHeight = 20;
            lbLines.Location = new Point(641, 43);
            lbLines.Name = "lbLines";
            lbLines.Size = new Size(516, 344);
            lbLines.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(976, 415);
            btnBuy.Margin = new Padding(3, 4, 3, 4);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(182, 99);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Резервирај";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // btnAddStation
            // 
            btnAddStation.Location = new Point(37, 415);
            btnAddStation.Name = "btnAddStation";
            btnAddStation.Size = new Size(235, 29);
            btnAddStation.TabIndex = 7;
            btnAddStation.Text = "Додади станица";
            btnAddStation.UseVisualStyleBackColor = true;
            btnAddStation.Click += btnAddStation_Click;
            // 
            // btnAddDestination
            // 
            btnAddDestination.Location = new Point(37, 450);
            btnAddDestination.Name = "btnAddDestination";
            btnAddDestination.Size = new Size(235, 29);
            btnAddDestination.TabIndex = 8;
            btnAddDestination.Text = "Додади дестинација";
            btnAddDestination.UseVisualStyleBackColor = true;
            btnAddDestination.Click += btnAddDestination_Click;
            // 
            // btnAddLine
            // 
            btnAddLine.Location = new Point(37, 485);
            btnAddLine.Name = "btnAddLine";
            btnAddLine.Size = new Size(235, 29);
            btnAddLine.TabIndex = 9;
            btnAddLine.Text = "Додади линија";
            btnAddLine.UseVisualStyleBackColor = true;
            btnAddLine.Click += btnAddLine_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 591);
            Controls.Add(btnAddLine);
            Controls.Add(btnAddDestination);
            Controls.Add(btnAddStation);
            Controls.Add(btnBuy);
            Controls.Add(lbLines);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbDestinations);
            Controls.Add(label1);
            Controls.Add(lbStations);
            Name = "Form1";
            Text = "Билетара";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbStations;
        private Label label1;
        private ListBox lbDestinations;
        private Label label2;
        private Label label3;
        private ListBox lbLines;
        private Button btnBuy;
        private Button btnAddStation;
        private Button btnAddDestination;
        private Button btnAddLine;
    }
}