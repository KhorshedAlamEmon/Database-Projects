namespace UPS_Delivery_Service_Database
{
    partial class Form2
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
            System.Windows.Forms.Label item_NumberLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label destinationLabel;
            System.Windows.Forms.Label insurence_amount_Label;
            System.Windows.Forms.Label dimension_NumberLabel;
            System.Windows.Forms.Label final_Delivery_DateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.database1DataSet = new UPS_Delivery_Service_Database.Database1DataSet();
            this.shipped_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipped_itemsTableAdapter = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.shipped_itemsTableAdapter();
            this.tableAdapterManager = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager();
            this.shipped_itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.item_NumberTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.insurence_amount_TextBox = new System.Windows.Forms.TextBox();
            this.dimension_NumberTextBox = new System.Windows.Forms.TextBox();
            this.final_Delivery_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.shipped_itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shipped_itemsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            item_NumberLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            destinationLabel = new System.Windows.Forms.Label();
            insurence_amount_Label = new System.Windows.Forms.Label();
            dimension_NumberLabel = new System.Windows.Forms.Label();
            final_Delivery_DateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingNavigator)).BeginInit();
            this.shipped_itemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipped_itemsBindingSource
            // 
            this.shipped_itemsBindingSource.DataMember = "shipped_items";
            this.shipped_itemsBindingSource.DataSource = this.database1DataSet;
            // 
            // shipped_itemsTableAdapter
            // 
            this.shipped_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Retail_CenterTableAdapter = null;
            this.tableAdapterManager.shipped_itemsTableAdapter = this.shipped_itemsTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.transportation_eventsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shipped_itemsBindingNavigator
            // 
            this.shipped_itemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.shipped_itemsBindingNavigator.BindingSource = this.shipped_itemsBindingSource;
            this.shipped_itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.shipped_itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.shipped_itemsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.shipped_itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shipped_itemsBindingNavigatorSaveItem});
            this.shipped_itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.shipped_itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.shipped_itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.shipped_itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.shipped_itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.shipped_itemsBindingNavigator.Name = "shipped_itemsBindingNavigator";
            this.shipped_itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.shipped_itemsBindingNavigator.Size = new System.Drawing.Size(739, 31);
            this.shipped_itemsBindingNavigator.TabIndex = 0;
            this.shipped_itemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // item_NumberLabel
            // 
            item_NumberLabel.AutoSize = true;
            item_NumberLabel.Location = new System.Drawing.Point(15, 66);
            item_NumberLabel.Name = "item_NumberLabel";
            item_NumberLabel.Size = new System.Drawing.Size(92, 17);
            item_NumberLabel.TabIndex = 1;
            item_NumberLabel.Text = "Item Number:";
            // 
            // item_NumberTextBox
            // 
            this.item_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipped_itemsBindingSource, "Item Number", true));
            this.item_NumberTextBox.Location = new System.Drawing.Point(153, 63);
            this.item_NumberTextBox.Name = "item_NumberTextBox";
            this.item_NumberTextBox.Size = new System.Drawing.Size(537, 22);
            this.item_NumberTextBox.TabIndex = 2;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(15, 94);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(56, 17);
            weightLabel.TabIndex = 3;
            weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipped_itemsBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(153, 91);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(537, 22);
            this.weightTextBox.TabIndex = 4;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new System.Drawing.Point(15, 122);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new System.Drawing.Size(83, 17);
            destinationLabel.TabIndex = 5;
            destinationLabel.Text = "Destination:";
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipped_itemsBindingSource, "Destination", true));
            this.destinationTextBox.Location = new System.Drawing.Point(153, 119);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(537, 22);
            this.destinationTextBox.TabIndex = 6;
            // 
            // insurence_amount_Label
            // 
            insurence_amount_Label.AutoSize = true;
            insurence_amount_Label.Location = new System.Drawing.Point(15, 150);
            insurence_amount_Label.Name = "insurence_amount_Label";
            insurence_amount_Label.Size = new System.Drawing.Size(129, 17);
            insurence_amount_Label.TabIndex = 7;
            insurence_amount_Label.Text = "Insurence amount :";
            // 
            // insurence_amount_TextBox
            // 
            this.insurence_amount_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipped_itemsBindingSource, "Insurence amount ", true));
            this.insurence_amount_TextBox.Location = new System.Drawing.Point(153, 147);
            this.insurence_amount_TextBox.Name = "insurence_amount_TextBox";
            this.insurence_amount_TextBox.Size = new System.Drawing.Size(537, 22);
            this.insurence_amount_TextBox.TabIndex = 8;
            // 
            // dimension_NumberLabel
            // 
            dimension_NumberLabel.AutoSize = true;
            dimension_NumberLabel.Location = new System.Drawing.Point(15, 178);
            dimension_NumberLabel.Name = "dimension_NumberLabel";
            dimension_NumberLabel.Size = new System.Drawing.Size(132, 17);
            dimension_NumberLabel.TabIndex = 9;
            dimension_NumberLabel.Text = "Dimension Number:";
            // 
            // dimension_NumberTextBox
            // 
            this.dimension_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.shipped_itemsBindingSource, "Dimension Number", true));
            this.dimension_NumberTextBox.Location = new System.Drawing.Point(153, 175);
            this.dimension_NumberTextBox.Name = "dimension_NumberTextBox";
            this.dimension_NumberTextBox.Size = new System.Drawing.Size(537, 22);
            this.dimension_NumberTextBox.TabIndex = 10;
            // 
            // final_Delivery_DateLabel
            // 
            final_Delivery_DateLabel.AutoSize = true;
            final_Delivery_DateLabel.Location = new System.Drawing.Point(15, 207);
            final_Delivery_DateLabel.Name = "final_Delivery_DateLabel";
            final_Delivery_DateLabel.Size = new System.Drawing.Size(131, 17);
            final_Delivery_DateLabel.TabIndex = 11;
            final_Delivery_DateLabel.Text = "Final Delivery Date:";
            // 
            // final_Delivery_DateDateTimePicker
            // 
            this.final_Delivery_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.shipped_itemsBindingSource, "Final Delivery Date", true));
            this.final_Delivery_DateDateTimePicker.Location = new System.Drawing.Point(153, 203);
            this.final_Delivery_DateDateTimePicker.Name = "final_Delivery_DateDateTimePicker";
            this.final_Delivery_DateDateTimePicker.Size = new System.Drawing.Size(537, 22);
            this.final_Delivery_DateDateTimePicker.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // shipped_itemsBindingNavigatorSaveItem
            // 
            this.shipped_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipped_itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shipped_itemsBindingNavigatorSaveItem.Image")));
            this.shipped_itemsBindingNavigatorSaveItem.Name = "shipped_itemsBindingNavigatorSaveItem";
            this.shipped_itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.shipped_itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.shipped_itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.shipped_itemsBindingNavigatorSaveItem_Click);
            // 
            // shipped_itemsDataGridView
            // 
            this.shipped_itemsDataGridView.AutoGenerateColumns = false;
            this.shipped_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipped_itemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.shipped_itemsDataGridView.DataSource = this.shipped_itemsBindingSource;
            this.shipped_itemsDataGridView.Location = new System.Drawing.Point(0, 241);
            this.shipped_itemsDataGridView.Name = "shipped_itemsDataGridView";
            this.shipped_itemsDataGridView.RowHeadersWidth = 51;
            this.shipped_itemsDataGridView.RowTemplate.Height = 24;
            this.shipped_itemsDataGridView.Size = new System.Drawing.Size(721, 216);
            this.shipped_itemsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn2.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Destination";
            this.dataGridViewTextBoxColumn3.HeaderText = "Destination";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Insurence amount ";
            this.dataGridViewTextBoxColumn4.HeaderText = "Insurence amount ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Dimension Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dimension Number";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Final Delivery Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Final Delivery Date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(739, 543);
            this.Controls.Add(this.shipped_itemsDataGridView);
            this.Controls.Add(item_NumberLabel);
            this.Controls.Add(this.item_NumberTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(destinationLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(insurence_amount_Label);
            this.Controls.Add(this.insurence_amount_TextBox);
            this.Controls.Add(dimension_NumberLabel);
            this.Controls.Add(this.dimension_NumberTextBox);
            this.Controls.Add(final_Delivery_DateLabel);
            this.Controls.Add(this.final_Delivery_DateDateTimePicker);
            this.Controls.Add(this.shipped_itemsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Shipped Item Database";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingNavigator)).EndInit();
            this.shipped_itemsBindingNavigator.ResumeLayout(false);
            this.shipped_itemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource shipped_itemsBindingSource;
        private Database1DataSetTableAdapters.shipped_itemsTableAdapter shipped_itemsTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator shipped_itemsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton shipped_itemsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox item_NumberTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox insurence_amount_TextBox;
        private System.Windows.Forms.TextBox dimension_NumberTextBox;
        private System.Windows.Forms.DateTimePicker final_Delivery_DateDateTimePicker;
        private System.Windows.Forms.DataGridView shipped_itemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}