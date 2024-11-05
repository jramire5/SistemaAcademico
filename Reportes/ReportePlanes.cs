﻿using Domain.Model.Dtos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
namespace Reportes.Definicion;
public class ReportePlanes : IDocument
{
    public static Image LogoImage { get; } = Image.FromFile("UTN.png");

    List<PlanDto> ModelList;
    public ReportePlanes(object model)
    {
        ModelList = (List<PlanDto>)model;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                //   page.Margin(50);
                // Define page settings
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);
                page.PageColor(Colors.White);
                page.DefaultTextStyle(x => x.FontSize(11).FontFamily("Arial", "Calibri", "Tahoma"));

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);

                page.Footer().AlignCenter().Text(text =>
                {
                    text.CurrentPageNumber();
                    text.Span(" / ");
                    text.TotalPages();
                });
            });
    }

    void ComposeHeader(IContainer container)
    {

        container.Row(row =>
        {
            row.ConstantItem(53).Image(LogoImage);
            row.RelativeItem(0.05f);
            row.RelativeItem().Column(column =>
            {
                column
                    .Item().Text("Reporte - Planes")
                    .FontSize(19).SemiBold().FontColor(Colors.Blue.Medium);

                column.Item().Text(t => t.Span(""));
                column.Item().Text(text =>
                {
                    text.Span("Fecha: ").SemiBold();
                    text.Span($"{DateTime.Now.ToString("dd/MM/yyyy")}");
                });              
            });


        });
    }

    void ComposeContent(IContainer container)
    {
        //PaddingVertical separacin entre cabecera y body
        container.PaddingVertical(40).Column(column =>
        {
            column.Spacing(20);

            /*    column.Item().Row(row =>
                {
                    row.RelativeItem().Component(new AddressComponent("From", Model.SellerAddress));
                    row.ConstantItem(50);
                    row.RelativeItem().Component(new AddressComponent("For", Model.CustomerAddress));
                });*/

            column.Item().Element(ComposeTable);

            /*      var totalPrice = Model.Items.Sum(x => x.Price * x.Quantity);
                  column.Item().PaddingRight(5).AlignRight().Text($"Grand total: {totalPrice:C}").SemiBold();

                  if (!string.IsNullOrWhiteSpace(Model.Comments))
                      column.Item().PaddingTop(25).Element(ComposeComments);*/
        });
    }

    void ComposeTable(IContainer container)
    {
        var headerStyle = TextStyle.Default.SemiBold();

        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
   
                columns.ConstantColumn(58);
                columns.RelativeColumn(1.3f);
                columns.RelativeColumn(2f);     
            });

            table.Header(header =>
            {
                //    header.Cell().Text("#");

                header.Cell().Text("Id Plan").Style(headerStyle);
                header.Cell().AlignLeft().Text("Plan").Style(headerStyle);
                header.Cell().AlignLeft().Text("Especialidad").Style(headerStyle);

                header.Cell().ColumnSpan(3).PaddingTop(3).BorderBottom(1).BorderColor(Colors.Black);
            });

            foreach (var item in ModelList)
            {     
                //    table.Cell().Element(CellStyle).Text($"{index}");
                table.Cell().Element(CellStyle).Text(item.id_plan.ToString()).FontSize(10);
                table.Cell().Element(CellStyle).AlignLeft().Text(item.desc_plan).FontSize(10);
                table.Cell().Element(CellStyle).AlignLeft().Text(item.desc_especialidad).FontSize(10);
                 static IContainer CellStyle(IContainer container) => container.BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(3);

            }
        });
    }   
}