using ClubTreasurer.Interfaces;
using SelectPdf;
using System.IO;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ClubTreasurer.Utilities
{
    public static class PdfUtils
    {
        public static async Task EmailUrlAsPdfAttachement(IEmailSender emailSender, string url, string recipient)
        {

            PdfPageSize pageSize = PdfPageSize.A4;
            PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
            int webPageWidth = 1024;
            int webPageHeight = 1000;

            // instantiate a html to pdf converter object
            HtmlToPdf converter = new HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;
            converter.Options.CssMediaType = HtmlToPdfCssMediaType.Print;

            // create a new pdf document converting an url
            PdfDocument doc = converter.ConvertUrl(url);

            // create memory stream to save PDF
            MemoryStream pdfStream = new MemoryStream();

            // save pdf document into a MemoryStream
            doc.Save(pdfStream);

            // reset stream position
            pdfStream.Position = 0;

            // create email message
            var subject = "Gym Card";
            var message = "Print in colour and have it signed by Jeremie before laminating";
            var attachment = new Attachment(pdfStream, "GymCard.pdf");
            await emailSender.SendEmailAsync(recipient, subject, message, attachment);

            // close pdf document
            doc.Close();
        }

        public static async Task CreatePdfFrumUrl(string url, string fileName) {

            PdfPageSize pageSize = PdfPageSize.A4;
            PdfPageOrientation pdfOrientation = PdfPageOrientation.Portrait;
            int webPageWidth = 1024;
            int webPageHeight = 1000;

            // instantiate a html to pdf converter object
            HtmlToPdf converter = new HtmlToPdf();

            // set converter options
            converter.Options.PdfPageSize = pageSize;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;

            // create a new pdf document converting an url
            PdfDocument doc = converter.ConvertUrl(url);

            // save pdf document
            doc.Save($@"C:\Temp\{fileName}.pdf");

            // close pdf document
            doc.Close();
        }
    }
}
