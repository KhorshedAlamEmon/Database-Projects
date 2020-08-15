namespace UPS_Delivery_Service_Database
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label delivery_RouteLabel;
            System.Windows.Forms.Label schedule_NumberLabel;
            this.database1DataSet = new UPS_Delivery_Service_Database.Database1DataSet();
            this.transportation_eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportation_eventsTableAdapter = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.transportation_eventsTableAdapter();
            this.tableAdapterManager = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager();
            this.transportation_eventsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.transportation_eventsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.delivery_RouteTextBox = new System.Windows.Forms.TextBox();
            this.schedule_NumberTextBox = new System.Windows.Forms.TextBox();
            this.transportation_eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            typeLabel = new System.Windows.Forms.Label();
            delivery_RouteLabel = new System.Windows.Forms.Label();
            schedule_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingNavigator)).BeginInit();
            this.transportation_eventsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transportation_eventsBindingSource
            // 
            this.transportation_eventsBindingSource.DataMember = "transportation_events";
            this.transportation_eventsBindingSource.DataSource = this.database1DataSet;
            // 
            // transportation_eventsTableAdapter
            // 
            this.transportation_eventsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Retail_CenterTableAdapter = null;
            this.tableAdapterManager.shipped_itemsTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.transportation_eventsTableAdapter = this.transportation_eventsTableAdapter;
            this.tableAdapterManager.UpdateOrder = UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // transportation_eventsBindingNavigator
            // 
            this.transportation_eventsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transportation_eventsBindingNavigator.BindingSource = this.transportation_eventsBindingSource;
            this.transportation_eventsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transportation_eventsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transportation_eventsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.transportation_eventsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.transportation_eventsBindingNavigatorSaveItem});
            this.transportation_eventsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transportation_eventsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transportation_eventsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transportation_eventsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transportation_eventsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transportation_eventsBindingNavigator.Name = "transportation_eventsBindingNavigator";
            this.transportation_eventsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transportation_eventsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.transportation_eventsBindingNavigator.TabIndex = 0;
            this.transportation_eventsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // transportation_eventsBindingNavigatorSaveItem
            // 
            this.transportation_eventsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transportation_eventsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transportation_eventsBindingNavigatorSaveItem.Image")));
            this.transportation_eventsBindingNavigatorSaveItem.Name = "transportation_eventsBindingNavigatorSaveItem";
            this.transportation_eventsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.transportation_eventsBindingNavigatorSaveItem.Text = "Save Data";
            this.transportation_eventsBindingNavigatorSaveItem.Click += new System.EventHandler(this.transportation_eventsBindingNavigatorSaveItem_Click);
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(136, 79);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(44, 17);
            typeLabel.TabIndex = 1;
            typeLabel.Text = "Type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportation_eventsBindingSource, "Type", true));
            this.typeTextBox.Location = new System.Drawing.Point(267, 76);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(285, 22);
            this.typeTextBox.TabIndex = 2;
            // 
            // delivery_RouteLabel
            // 
            delivery_RouteLabel.AutoSize = true;
            delivery_RouteLabel.Location = new System.Drawing.Point(136, 107);
            delivery_RouteLabel.Name = "delivery_RouteLabel";
            delivery_RouteLabel.Size = new System.Drawing.Size(105, 17);
            delivery_RouteLabel.TabIndex = 3;
            delivery_RouteLabel.Text = "Delivery Route:";
            // 
            // delivery_RouteTextBox
            // 
            this.delivery_RouteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportation_eventsBindingSource, "Delivery Route", true));
            this.delivery_RouteTextBox.Location = new System.Drawing.Point(267, 104);
            this.delivery_RouteTextBox.Name = "delivery_RouteTextBox";
            this.delivery_RouteTextBox.Size = new System.Drawing.Size(285, 22);
            this.delivery_RouteTextBox.TabIndex = 4;
            // 
            // schedule_NumberLabel
            // 
            schedule_NumberLabel.AutoSize = true;
            schedule_NumberLabel.Location = new System.Drawing.Point(136, 135);
            schedule_NumberLabel.Name = "schedule_NumberLabel";
            schedule_NumberLabel.Size = new System.Drawing.Size(125, 17);
            schedule_NumberLabel.TabIndex = 5;
            schedule_NumberLabel.Text = "Schedule Number:";
            // 
            // schedule_NumberTextBox
            // 
            this.schedule_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transportation_eventsBindingSource, "Schedule Number", true));
            this.schedule_NumberTextBox.Location = new System.Drawing.Point(267, 132);
            this.schedule_NumberTextBox.Name = "schedule_NumberTextBox";
            this.schedule_NumberTextBox.Size = new System.Drawing.Size(285, 22);
            this.schedule_NumberTextBox.TabIndex = 6;
            // 
            // transportation_eventsDataGridView
            // 
            this.transportation_eventsDataGridView.AutoGenerateColumns = false;
            this.transportation_eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transportation_eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.transportation_eventsDataGridView.DataSource = this.transportation_eventsBindingSource;
            this.transportation_eventsDataGridView.Location = new System.Drawing.Point(139, 174);
            this.transportation_eventsDataGridView.Name = "transportation_eventsDataGridView";
            this.transportation_eventsDataGridView.RowHeadersWidth = 51;
            this.transportation_eventsDataGridView.RowTemplate.Height = 24;
            this.transportation_eventsDataGridView.Size = new System.Drawing.Size(425, 220);
            this.transportation_eventsDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Delivery Route";
            this.dataGridViewTextBoxColumn2.HeaderText = "Delivery Route";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Schedule Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Schedule Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.transportation_eventsDataGridView);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(delivery_RouteLabel);
            this.Controls.Add(this.delivery_RouteTextBox);
            this.Controls.Add(schedule_NumberLabel);
            this.Controls.Add(this.schedule_NumberTextBox);
            this.Controls.Add(this.transportation_eventsBindingNavigator);
            this.Name = "Form4";
            this.Text = "Transportation Events";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingNavigator)).EndInit();
            this.transportation_eventsBindingNavigator.ResumeLayout(false);
            this.transportation_eventsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource transportation_eventsBindingSource;
        private Database1DataSetTableAdapters.transportation_eventsTableAdapter transportation_eventsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator transportation_eventsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton transportation_eventsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox delivery_RouteTextBox;
        private System.Windows.Forms.TextBox schedule_NumberTextBox;
        private System.Windows.Forms.DataGridView transportation_eventsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}