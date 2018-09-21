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
	Partial Public Class Examples
		Public Shared Sub HtmlFileToPdfExample()
			' Create a PDF from an existing HTML
			Dim Renderer = New HtmlToPdf()

			Renderer.PrintOptions.MarginTop = 50 'millimeters
			Renderer.PrintOptions.MarginBottom = 50
			Renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print

			Renderer.PrintOptions.Header = New SimpleHeaderFooter() With {
				.CenterText = "{pdf-title}",
				.DrawDividerLine = True,
				.FontSize = 16
			}

			Renderer.PrintOptions.Footer = New SimpleHeaderFooter() With {
				.LeftText = "{date} {time}",
				.RightText = "Page {page} of {total-pages}",
				.DrawDividerLine = True,
				.FontSize = 14
			}

			Dim PDF = Renderer.RenderHTMLFileAsPdf("Assets/TestInvoice1.html")
			Dim OutputPath = "Invoice.pdf"
			PDF.SaveAs(OutputPath)

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start(OutputPath)
		End Sub
	End Class
End Namespace
