using System;
using System.Windows;
using System.Drawing;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditTransparentWpf {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void richEditControl1_Loaded(object sender, RoutedEventArgs e) {
            richEditControl1.ApplyTemplate();
            richEditControl1.Views.SimpleView.BackColor = Color.Transparent;
            richEditControl1.Views.DraftView.BackColor = Color.Transparent;
            richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden;
            richEditControl1.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden;

            Section firstSection = richEditControl1.Document.Sections[0];
            firstSection.Margins.Left = 0;
            firstSection.Margins.Top = 0;
            firstSection.Margins.Right = 0;
            firstSection.Margins.Bottom = 0;
            firstSection.Page.Width = Units.InchesToDocumentsF(2.3f);
            firstSection.Page.Height = Units.InchesToDocumentsF(3f);
        }
    }
}
