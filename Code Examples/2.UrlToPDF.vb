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
		Public Shared Sub UrlToPdfExample()

			' Create a PDF from a web page
			Dim Renderer = New HtmlToPdf()
			Dim PDF = Renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Portable_Document_Format")
			PDF.SaveAs("wikipedia.pdf")

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start("wikipedia.pdf")

		End Sub
	End Class
End Namespace
