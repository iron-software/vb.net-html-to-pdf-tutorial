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
		Public Shared Sub PDFSettingsExample()
			' Create a PDF from a web page
			Dim Renderer = New HtmlToPdf()
			Renderer.PrintOptions.PrintHtmlBackgrounds = True
			Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4
			Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape
			Renderer.PrintOptions.Header = New SimpleHeaderFooter() With {.CenterText = "{url}"}
			Renderer.PrintOptions.Footer = New HtmlHeaderFooter() With {.HtmlFragment = "<div style='text-align:right'><em style='color:pink'>page {page} of {total-pages}</em></div>"}

			Dim PDF = Renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
			Dim OutputPath = "nuget.pdf"
			PDF.SaveAs(OutputPath)

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start(OutputPath)
		End Sub
	End Class
End Namespace
