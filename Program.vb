'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports IronPdf

Namespace HtmlToPdfTutorial
	Friend Class Program
		Shared Sub Main(ByVal args() As String)


			' Render any HTML fragment or document to HTML
			Dim Renderer = New HtmlToPdf()

			' Settings 
			Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4
			Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Portrait
			Renderer.PrintOptions.Header = New SimpleHeaderFooter() With {
				.CenterText = "Iron PDf C# Html to PDF Example",
				.FontSize=10,
				.FontFamily="Arial"
			}
			Renderer.PrintOptions.Footer = New HtmlHeaderFooter() With {.HtmlFragment = "<div style='text-align:right'><em style='color:#333'>page {page} of {total-pages}</em></div>"}

			' Render the HTML as a PDF
			Dim PDF = Renderer.RenderHtmlAsPdf("<h1 style='padding-top:150px'>This PDF is generated from HTML using C#</h1>")

			'  Editing the PDF by adding a watermark
			PDF.WatermarkAllPages("<span style='color:red; font-size:44px; font-family:Arial'>Sample</example>", PdfDocument.WaterMarkLocation.MiddleCenter, 20, -45, "http://ironpdf.com")

			'  Save the PDF to a file
			Dim OutputPath = "IronPdfExample.pdf"
			PDF.SaveAs(OutputPath)

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start(OutputPath)


			' For detailed examples please check the "Code Examples" Folder or uncomment below
			' Examples.HtmlToPdfExample();
			' Examples.UrlToPdfExample();
			' Examples.HtmlFileToPdfExample();
			' Examples.PDFSettingsExample();
			' Examples.JavaScriptChartsExample();
		End Sub
	End Class
End Namespace
