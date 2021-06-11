using System;
using System.IO;
using System.IO.Packaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Xps.Packaging;

namespace ThanksCardClient.Views
{
    /// <summary>
    /// Interaction logic for Manual
    /// </summary>
    public partial class Manual : UserControl
    {
        public Manual()
        {
            InitializeComponent();
        }
        private void LoadFileToDocumentViewer(string manual)
        {
            XpsDocument document = new XpsDocument(manual, FileAccess.Read, CompressionOption.NotCompressed);

            FixedDocumentSequence sequence = document.GetFixedDocumentSequence();

            docViewer.Document = sequence as IDocumentPaginatorSource;
        }
    }
    }

