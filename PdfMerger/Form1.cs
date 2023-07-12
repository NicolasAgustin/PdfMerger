using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PdfMerger
{
    public partial class Form1 : Form
    {
        private List<string> filesToMerge = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void combinar_Click(object sender, EventArgs e)
        {
            string folder = "";
            string filename = "";

            if (this.filesToMerge == null) { return; }

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                folder = dialog.SelectedPath;
            } else
            {
                // TODO: mostrar mensaje de error
                return;
            }

            if (this.filenameCheckbox.Text == string.Empty)
            {
                filename = "output.pdf";
            } else
            {
                filename = this.filenameCheckbox.Text + ".pdf";
            }

            PdfDocument document = new PdfDocument();

            foreach(var pdf in this.filesToMerge)
            {

                FileInfo fi = new FileInfo(pdf);
                if (fi.Extension == ".pdf")
                {
                    using (var pdfReaded = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfReaded.PageCount; i++)
                        {
                            document.AddPage(pdfReaded.Pages[i]);
                        }
                    }
                } else
                {
                    try
                    {
                        // TODO: Redimensionar foto para que encaje perfectamente en A4
                        PdfPage page = document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        XImage image = XImage.FromFile(pdf);

                        page.Width = image.PixelWidth;
                        page.Height = image.PixelHeight;
                        gfx.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }


            }

            string finalpath = Path.Combine(folder, filename);

            document.Save(finalpath);

            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show("Se creo el archivo " + finalpath, "Pdf creado", buttons);

            clean_form();
        }

        private void clean_form()
        {
            this.filesToMerge = null;
            this.filenameCheckbox.Text = string.Empty;
            this.displayFiles.Items.Clear();
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*)|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               this.filesToMerge = dialog.FileNames.ToList();
               foreach(var f in this.filesToMerge)
               {
                    this.displayFiles.Items.Add(f);
               }
            }

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            int itemsCant = this.displayFiles.CheckedItems.Count;
            List<string> items = new List<string>();

            for (int i = 0; i < itemsCant; i++)
            {
                var item = this.displayFiles.CheckedItems[i];
                items.Add(item.ToString());
            }

            items.ForEach(item => {
                    this.displayFiles.Items.Remove(item);
                    this.filesToMerge.Remove(item);
                }
            );


        }
    }
}
