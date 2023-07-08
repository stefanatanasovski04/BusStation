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
            SuspendLayout();
            // 
            // lbStations
            // 
            lbStations.FormattingEnabled = true;
            lbStations.ItemHeight = 15;
            lbStations.Location = new Point(32, 32);
            lbStations.Margin = new Padding(3, 2, 3, 2);
            lbStations.Name = "lbStations";
            lbStations.Size = new Size(159, 259);
            lbStations.TabIndex = 0;
            lbStations.SelectedIndexChanged += lbStations_SelectedIndexChanged;
            lbStations.SelectedValueChanged += lbStations_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 14);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Станици";
            // 
            // lbDestinations
            // 
            lbDestinations.FormattingEnabled = true;
            lbDestinations.ItemHeight = 15;
            lbDestinations.Location = new Point(214, 32);
            lbDestinations.Margin = new Padding(3, 2, 3, 2);
            lbDestinations.Name = "lbDestinations";
            lbDestinations.Size = new Size(330, 259);
            lbDestinations.TabIndex = 2;
            lbDestinations.SelectedIndexChanged += lbDestinations_SelectedIndexChanged;
            lbDestinations.SelectedValueChanged += lbDestinations_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 15);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Дестинации";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 15);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Линии";
            // 
            // lbLines
            // 
            lbLines.FormattingEnabled = true;
            lbLines.ItemHeight = 15;
            lbLines.Location = new Point(561, 32);
            lbLines.Margin = new Padding(3, 2, 3, 2);
            lbLines.Name = "lbLines";
            lbLines.Size = new Size(452, 259);
            lbLines.TabIndex = 5;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(938, 296);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(75, 23);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "Купи карта";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 443);
            Controls.Add(btnBuy);
            Controls.Add(lbLines);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbDestinations);
            Controls.Add(label1);
            Controls.Add(lbStations);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}