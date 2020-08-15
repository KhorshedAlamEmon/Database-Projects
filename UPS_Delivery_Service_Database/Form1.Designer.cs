namespace UPS_Delivery_Service_Database
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new UPS_Delivery_Service_Database.Database1DataSet();
            this.shipped_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipped_itemsTableAdapter = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.shipped_itemsTableAdapter();
            this.tableAdapterManager = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager();
            this.retail_CenterTableAdapter = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.Retail_CenterTableAdapter();
            this.transportation_eventsTableAdapter = new UPS_Delivery_Service_Database.Database1DataSetTableAdapters.transportation_eventsTableAdapter();
            this.shipped_itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shipped_itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.retail_CenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportation_eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingNavigator)).BeginInit();
            this.shipped_itemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retail_CenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingSource)).BeginInit();
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
            this.tableAdapterManager.Retail_CenterTableAdapter = this.retail_CenterTableAdapter;
            this.tableAdapterManager.shipped_itemsTableAdapter = this.shipped_itemsTableAdapter;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.transportation_eventsTableAdapter = this.transportation_eventsTableAdapter;
            this.tableAdapterManager.UpdateOrder = UPS_Delivery_Service_Database.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // retail_CenterTableAdapter
            // 
            this.retail_CenterTableAdapter.ClearBeforeFill = true;
            // 
            // transportation_eventsTableAdapter
            // 
            this.transportation_eventsTableAdapter.ClearBeforeFill = true;
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
            this.shipped_itemsBindingNavigator.Size = new System.Drawing.Size(728, 27);
            this.shipped_itemsBindingNavigator.TabIndex = 0;
            this.shipped_itemsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // shipped_itemsBindingNavigatorSaveItem
            // 
            this.shipped_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shipped_itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shipped_itemsBindingNavigatorSaveItem.Image")));
            this.shipped_itemsBindingNavigatorSaveItem.Name = "shipped_itemsBindingNavigatorSaveItem";
            this.shipped_itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.shipped_itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.shipped_itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.shipped_itemsBindingNavigatorSaveItem_Click);
            // 
            // retail_CenterBindingSource
            // 
            this.retail_CenterBindingSource.DataMember = "Retail_Center";
            this.retail_CenterBindingSource.DataSource = this.database1DataSet;
            // 
            // transportation_eventsBindingSource
            // 
            this.transportation_eventsBindingSource.DataMember = "transportation_events";
            this.transportation_eventsBindingSource.DataSource = this.database1DataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(253, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shipped Items ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(253, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Retail Center";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(253, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Transportation Events";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::UPS_Delivery_Service_Database.Properties.Resources.UPS_prepares_for_peak_USA_vs_UPU_are_carriers_the_winners;
            this.ClientSize = new System.Drawing.Size(728, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shipped_itemsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to the UPS Delivery Service Bangladesh Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipped_itemsBindingNavigator)).EndInit();
            this.shipped_itemsBindingNavigator.ResumeLayout(false);
            this.shipped_itemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retail_CenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportation_eventsBindingSource)).EndInit();
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
        private Database1DataSetTableAdapters.Retail_CenterTableAdapter retail_CenterTableAdapter;
        private System.Windows.Forms.BindingSource retail_CenterBindingSource;
        private Database1DataSetTableAdapters.transportation_eventsTableAdapter transportation_eventsTableAdapter;
        private System.Windows.Forms.BindingSource transportation_eventsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

