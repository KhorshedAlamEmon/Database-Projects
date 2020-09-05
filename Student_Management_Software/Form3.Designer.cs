namespace Student_Manahement_Software
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.studentmanagementDataSet = new Student_Manahement_Software.studentmanagementDataSet();
            this.student_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_managementTableAdapter = new Student_Manahement_Software.studentmanagementDataSetTableAdapters.student_managementTableAdapter();
            this.tableAdapterManager = new Student_Manahement_Software.studentmanagementDataSetTableAdapters.TableAdapterManager();
            this.student_managementDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentmanagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentmanagementDataSet
            // 
            this.studentmanagementDataSet.DataSetName = "studentmanagementDataSet";
            this.studentmanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_managementBindingSource
            // 
            this.student_managementBindingSource.DataMember = "student_management";
            this.student_managementBindingSource.DataSource = this.studentmanagementDataSet;
            // 
            // student_managementTableAdapter
            // 
            this.student_managementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.student_managementTableAdapter = this.student_managementTableAdapter;
            this.tableAdapterManager.UpdateOrder = Student_Manahement_Software.studentmanagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_managementDataGridView
            // 
            this.student_managementDataGridView.AutoGenerateColumns = false;
            this.student_managementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_managementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.student_managementDataGridView.DataSource = this.student_managementBindingSource;
            this.student_managementDataGridView.Location = new System.Drawing.Point(22, 136);
            this.student_managementDataGridView.Name = "student_managementDataGridView";
            this.student_managementDataGridView.RowHeadersWidth = 51;
            this.student_managementDataGridView.RowTemplate.Height = 24;
            this.student_managementDataGridView.Size = new System.Drawing.Size(994, 302);
            this.student_managementDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "student_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "student_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "student_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "student_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "semester";
            this.dataGridViewTextBoxColumn3.HeaderText = "semester";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cgpa";
            this.dataGridViewTextBoxColumn4.HeaderText = "cgpa";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "program";
            this.dataGridViewTextBoxColumn5.HeaderText = "program";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn6.HeaderText = "department";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Updated Student Management Database ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(795, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By Khorshed Alam";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Manahement_Software.Properties.Resources.shutterstock_1373266784;
            this.ClientSize = new System.Drawing.Size(1060, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_managementDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = " Information Panel";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentmanagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_managementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentmanagementDataSet studentmanagementDataSet;
        private System.Windows.Forms.BindingSource student_managementBindingSource;
        private studentmanagementDataSetTableAdapters.student_managementTableAdapter student_managementTableAdapter;
        private studentmanagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView student_managementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}