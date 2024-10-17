namespace Test
{
    partial class Emp_RPT
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
            this.SuspendLayout();
            // 
            // Emp_RPT
            // 
            this.ClientSize = new System.Drawing.Size(1062, 562);
            this.Name = "Emp_RPT";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Emp_DetailsBindingSource;
        private HRMS_DBDataSet HRMS_DBDataSet;
        private HRMS_DBDataSetTableAdapters.Emp_DetailsTableAdapter Emp_DetailsTableAdapter;
        private System.Windows.Forms.TextBox txtEmpid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}