namespace EntityFrame.Forms
{
    partial class OrderDetailsForm
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
            dataGridViewOrderDetails = new DataGridView();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOrderDetails
            // 
            dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderDetails.Location = new Point(61, 90);
            dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewOrderDetails.RowHeadersWidth = 51;
            dataGridViewOrderDetails.RowTemplate.Height = 29;
            dataGridViewOrderDetails.Size = new Size(621, 230);
            dataGridViewOrderDetails.TabIndex = 0;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(572, 353);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(110, 42);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(dataGridViewOrderDetails);
            Name = "OrderDetailsForm";
            Text = "OrderDetailsForm";
            Load += OrderDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOrderDetails;
        private Button deleteButton;
    }
}