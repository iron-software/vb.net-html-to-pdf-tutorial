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
		Public Shared Sub HtmlToPdfExample()

			' Render any HTML fragment or document to HTML
			Dim Renderer = New HtmlToPdf()
			Dim PDF = Renderer.RenderHtmlAsPdf("<h1>Hello IronPdf</h1>")
			Dim OutputPath = "HtmlToPDF.pdf"
			PDF.SaveAs(OutputPath)

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start(OutputPath)
		End Sub
	End Class
End Namespace
