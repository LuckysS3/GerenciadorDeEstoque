using Gerenciamento_De_Estoque.Models;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;

namespace Gerenciador_De_Estoque.Utils;

class GeradorDePdf
{
    private readonly string _outputPath;

    public GeradorDePdf(string outputPath)
    {
        _outputPath = outputPath;
    }

    public void GenerateStockReport(List<ProductModel> products)
    {
        using (PdfWriter writer = new PdfWriter(_outputPath))
        {
            using (PdfDocument pdf = new PdfDocument(writer))
            {
                Document document = new Document(pdf);

                
                AddTitle(document, "Relatório de Estoque");

                
                AddTable(document, products);

                document.Close();
            }
        }
    }

    private void AddTitle(Document document, string title)
    {
        PdfFont font = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);

        Paragraph paragraph = new Paragraph(title)
            .SetFont(font) 
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(20);

        document.Add((IBlockElement)paragraph);
        document.Add(new Paragraph(" ").SetHeight(10));
    }


    private void AddTable(Document document, List<ProductModel> products)
    {
        Table table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 3, 2, 2, 2 }))
            .UseAllAvailableWidth();

        table.AddHeaderCell("ID");
        table.AddHeaderCell("Nome do Produto");
        table.AddHeaderCell("Categoria");
        table.AddHeaderCell("Quantidade");
        table.AddHeaderCell("Preço");

        foreach (var product in products)
        {
            table.AddCell(product.Id.ToString());
            table.AddCell(product.Nome);
            table.AddCell(product.Category.Nome);
            table.AddCell(product.Quantidade.ToString());
            table.AddCell($"R$ {product.Preco:F2}");
        }

        document.Add((IBlockElement)table);
    }
}
