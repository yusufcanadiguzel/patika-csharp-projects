using BarcodeStandard;
using IronBarCode;

namespace BarcodeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();

            SkiaSharp.SKColor skForeColor = SkiaSharp.SKColors.Black;
            SkiaSharp.SKColor skBackColor = SkiaSharp.SKColors.Transparent;

            SkiaSharp.SKImage image = barcode.Encode(BarcodeStandard.Type.UpcA, txtboxBarcode.Text, skForeColor, skBackColor, (int)(picBarcode.Width * 0.8), (int)(picBarcode.Height * 0.8));

            // SkImage -> SkBit
            SkiaSharp.SKBitmap skBitmap = SkiaSharp.SKBitmap.FromImage(image);

            // SkBit -> Image
            using (var memoryStream = new System.IO.MemoryStream())
            {
                skBitmap.Encode(memoryStream, SkiaSharp.SKEncodedImageFormat.Png, 100);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                Bitmap drawingBitmap = new Bitmap(memoryStream);

                picBarcode.Image = drawingBitmap;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picBarcode == null)
                return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "PNG|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    picBarcode.Image.Save(saveFileDialog.FileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "PNG|*.png" } )
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picBarcode.Image = Image.FromFile(openFileDialog.FileName);

                    var barcode = BarcodeReader.Read(picBarcode.Image);

                    foreach (var item in barcode)
                    {
                        txtboxBarcode.Text += item.ToString();
                    }
                }
            }
        }
    }
}
