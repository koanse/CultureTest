namespace CultureTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axTextBox1 = new AxMCFORMSLib.AxTextBox();
            this.axVSExcel1 = new AxVSEXCELLib.AxVSExcel();
            ((System.ComponentModel.ISupportInitialize)(this.axTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVSExcel1)).BeginInit();
            this.SuspendLayout();
            // 
            // axTextBox1
            // 
            resources.ApplyResources(this.axTextBox1, "axTextBox1");
            this.axTextBox1.Name = "axTextBox1";
            this.axTextBox1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTextBox1.OcxState")));
            // 
            // axVSExcel1
            // 
            resources.ApplyResources(this.axVSExcel1, "axVSExcel1");
            this.axVSExcel1.Name = "axVSExcel1";
            this.axVSExcel1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVSExcel1.OcxState")));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axVSExcel1);
            this.Controls.Add(this.axTextBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVSExcel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMCFORMSLib.AxTextBox axTextBox1;
        private AxVSEXCELLib.AxVSExcel axVSExcel1;

    }
}

