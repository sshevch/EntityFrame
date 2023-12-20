namespace EntityFrame.Forms
{
    partial class MangaSelectionForm
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
            lblCustomerName = new Label();
            dataGridViewManga = new DataGridView();
            label1 = new Label();
            dataGridViewOrders = new DataGridView();
            label2 = new Label();
            btnViewOrderDetails = new Button();
            btnCreateOrder = new Button();
            updateOrders = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManga).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(1088, 18);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(129, 20);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "lblCustomerName";
            // 
            // dataGridViewManga
            // 
            dataGridViewManga.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManga.Location = new Point(95, 71);
            dataGridViewManga.Name = "dataGridViewManga";
            dataGridViewManga.RowHeadersWidth = 51;
            dataGridViewManga.RowTemplate.Height = 29;
            dataGridViewManga.Size = new Size(916, 343);
            dataGridViewManga.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 38);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "Усі наші манги";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(95, 497);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.RowTemplate.Height = 29;
            dataGridViewOrders.Size = new Size(916, 188);
            dataGridViewOrders.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 462);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Ваші закази";
            // 
            // btnViewOrderDetails
            // 
            btnViewOrderDetails.Location = new Point(1047, 533);
            btnViewOrderDetails.Name = "btnViewOrderDetails";
            btnViewOrderDetails.Size = new Size(157, 52);
            btnViewOrderDetails.TabIndex = 5;
            btnViewOrderDetails.Text = "Переглянути замовлення";
            btnViewOrderDetails.UseVisualStyleBackColor = true;
            btnViewOrderDetails.Click += btnViewOrderDetails_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(1097, 170);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(94, 36);
            btnCreateOrder.TabIndex = 6;
            btnCreateOrder.Text = "Замовити";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // updateOrders
            // 
            updateOrders.Location = new Point(1047, 617);
            updateOrders.Name = "updateOrders";
            updateOrders.Size = new Size(157, 45);
            updateOrders.TabIndex = 7;
            updateOrders.Text = "Оновити";
            updateOrders.UseVisualStyleBackColor = true;
            updateOrders.Click += updateOrders_Click;
            // 
            // MangaSelectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 697);
            Controls.Add(updateOrders);
            Controls.Add(btnCreateOrder);
            Controls.Add(btnViewOrderDetails);
            Controls.Add(label2);
            Controls.Add(dataGridViewOrders);
            Controls.Add(label1);
            Controls.Add(dataGridViewManga);
            Controls.Add(lblCustomerName);
            Name = "MangaSelectionForm";
            Text = "MangaSelectionForm";
            Load += MangaSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewManga).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerName;
        private DataGridView dataGridViewManga;
        private Label label1;
        private DataGridView dataGridViewOrders;
        private Label label2;
        private Button btnViewOrderDetails;
        private Button btnCreateOrder;
        private Button updateOrders;
    }
}