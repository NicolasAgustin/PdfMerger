namespace PdfMerger
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.combinar = new System.Windows.Forms.Button();
            this.displayFiles = new System.Windows.Forms.CheckedListBox();
            this.seleccionar = new System.Windows.Forms.Button();
            this.filenameCheckbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrar = new System.Windows.Forms.Button();
            this.pdfViewer = new System.Windows.Forms.Panel();
            this.previewBtn = new System.Windows.Forms.Button();
            this.previewControl = new System.Windows.Forms.PrintPreviewControl();
            this.pdfViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // combinar
            // 
            this.combinar.Location = new System.Drawing.Point(267, 437);
            this.combinar.Name = "combinar";
            this.combinar.Size = new System.Drawing.Size(280, 69);
            this.combinar.TabIndex = 0;
            this.combinar.Text = "COMBINAR";
            this.combinar.UseVisualStyleBackColor = true;
            this.combinar.Click += new System.EventHandler(this.combinar_Click);
            // 
            // displayFiles
            // 
            this.displayFiles.FormattingEnabled = true;
            this.displayFiles.Location = new System.Drawing.Point(12, 12);
            this.displayFiles.Name = "displayFiles";
            this.displayFiles.Size = new System.Drawing.Size(172, 274);
            this.displayFiles.TabIndex = 1;
            this.displayFiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.displayFiles_ControlAdded);
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(12, 292);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(172, 37);
            this.seleccionar.TabIndex = 2;
            this.seleccionar.Text = "SELECCIONAR ARCHIVOS";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // filenameCheckbox
            // 
            this.filenameCheckbox.Location = new System.Drawing.Point(267, 411);
            this.filenameCheckbox.Name = "filenameCheckbox";
            this.filenameCheckbox.Size = new System.Drawing.Size(280, 20);
            this.filenameCheckbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DEL ARCHIVO (SIN .PDF)";
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(191, 262);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(45, 24);
            this.borrar.TabIndex = 5;
            this.borrar.Text = "borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // pdfViewer
            // 
            this.pdfViewer.Controls.Add(this.previewControl);
            this.pdfViewer.Location = new System.Drawing.Point(267, 12);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(619, 364);
            this.pdfViewer.TabIndex = 6;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(565, 437);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(321, 69);
            this.previewBtn.TabIndex = 7;
            this.previewBtn.Text = "VISTA PREVIA";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // previewControl
            // 
            this.previewControl.AutoZoom = false;
            this.previewControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.previewControl.Location = new System.Drawing.Point(3, 3);
            this.previewControl.Name = "previewControl";
            this.previewControl.Size = new System.Drawing.Size(613, 358);
            this.previewControl.TabIndex = 0;
            this.previewControl.Zoom = 0.5D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 518);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filenameCheckbox);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.displayFiles);
            this.Controls.Add(this.combinar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pdfViewer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button combinar;
        private System.Windows.Forms.CheckedListBox displayFiles;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.TextBox filenameCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Panel pdfViewer;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.PrintPreviewControl previewControl;
    }
}

