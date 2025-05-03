using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms;

namespace PharmacySystem.Helper
{
    public static class OrderRequestPDF
    {
        public static string GenerateContract(string orderID, string medicineID, string medicineName, string quantity, string supplier, string email, string requester)
        {
            // 1. Đường dẫn file PDF với tên chứa mã đơn + timestamp
            string startupPath = Application.StartupPath;
            string fileName = $"PhieuDatHang_{orderID}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string filePath = Path.Combine(startupPath, fileName);

            // 2. Font Arial (Windows)
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font titleFont = new Font(baseFont, 18, Font.BOLD, BaseColor.BLACK);
            Font headerFont = new Font(baseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font cellFont = new Font(baseFont, 12, Font.NORMAL, BaseColor.BLACK);

            // 3. Tạo document PDF
            Document doc = new Document(PageSize.A4, 40f, 40f, 60f, 60f);

            try
            {
                // Xoá file nếu trùng 
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // 4. Logo
                    string logoPath = Path.Combine(startupPath, "image_pharmacy", "image_pharmacy", "logopharma.png");
                    if (File.Exists(logoPath))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                        logo.ScaleToFit(100f, 100f);
                        logo.Alignment = Element.ALIGN_CENTER;
                        doc.Add(logo);
                    }

                    // 5. Tiêu đề
                    Paragraph title = new Paragraph("PHIẾU ĐẶT THUỐC", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 20f
                    };
                    doc.Add(title);

                    // 6. Bảng thông tin
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 30, 70 });
                    BaseColor bgColor = new BaseColor(230, 230, 230);

                    AddRow(table, "Mã đơn đặt hàng", orderID, headerFont, cellFont, bgColor);
                    AddRow(table, "Mã số thuốc", medicineID, headerFont, cellFont, bgColor);
                    AddRow(table, "Tên thuốc", medicineName, headerFont, cellFont, bgColor);
                    AddRow(table, "Số lượng", quantity, headerFont, cellFont, bgColor);
                    AddRow(table, "Nhà cung cấp", supplier, headerFont, cellFont, bgColor);
                    AddRow(table, "Email nhà cung cấp", email, headerFont, cellFont, bgColor);
                    AddRow(table, "Người yêu cầu", requester, headerFont, cellFont, bgColor);
                    AddRow(table, "Ngày lập phiếu", DateTime.Now.ToString("dd/MM/yyyy"), headerFont, cellFont, bgColor);

                    doc.Add(table);

                    // 7. Ký tên
                    Paragraph sign = new Paragraph("\n\nNgười đại diện bên mua:\n\n______________________________", cellFont)
                    {
                        SpacingBefore = 30f
                    };
                    doc.Add(sign);

                    doc.Close(); // đóng tài liệu
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Không thể tạo file PDF. Vui lòng đảm bảo không mở file đang tồn tại.");
                return null;
            }

            return filePath;
        }

        private static void AddRow(PdfPTable table, string label, string value, Font headerFont, Font cellFont, BaseColor bgColor)
        {
            PdfPCell cell1 = new PdfPCell(new Phrase(label, headerFont))
            {
                BackgroundColor = bgColor,
                Padding = 5
            };
            PdfPCell cell2 = new PdfPCell(new Phrase(value, cellFont))
            {
                Padding = 5
            };
            table.AddCell(cell1);
            table.AddCell(cell2);
        }
    }
}
