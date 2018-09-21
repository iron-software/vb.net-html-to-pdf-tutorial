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
		Public Shared Sub JavaScriptChartsExample()
			' Create a PDF Chart a live rendered dataset using d3.js and javascript
			Dim Renderer = New HtmlToPdf()
			Dim PDF = Renderer.RenderUrlAsPdf("https://bl.ocks.org/mbostock/4062006")
			PDF.SaveAs("chart.pdf")

			' This neat trick opens our PDF file so we can see the result
			System.Diagnostics.Process.Start("chart.pdf")
		End Sub
	End Class
End Namespace
