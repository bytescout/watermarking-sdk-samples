'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'


Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections.Generic
Imports Bytescout.Watermarking
Imports Bytescout.Watermarking.Presets

Module Tutorial
    Sub Main(ByVal args As String())
        ' Create Watermarker instance
        Dim waterMarker As New Watermarker()

        ' Initialize library
        waterMarker.InitLibrary("demo", "demo")

        ' Set input file name
        Dim inputFilePath As String = "my_sample_image.jpg"
        ' Set output file title
        Dim outputFilePath As String = "my_sample_output.jpg"


        ' Add image to apply watermarks to
        waterMarker.AddInputFile(inputFilePath, outputFilePath)


        ' Allow resize
        waterMarker.OutputOptions.Resize = True

        ' Set resize type to percentage
        waterMarker.OutputOptions.ResizeType = ResizeType.Actual

        ' Set units type
        waterMarker.OutputOptions.ResizeActualUnits = ActualSizeUnits.inches

        ' Set image width
        waterMarker.OutputOptions.ResizeWidthInUnits = 1.5F

        ' Set image height
        waterMarker.OutputOptions.ResizeHeightInUnits = 2.0F

        ' Set output directory
        waterMarker.OutputOptions.OutputDirectory = "."

        ' Apply watermarks
        waterMarker.Execute()


        ' open generated image file in default image viewer installed in Windows
        Process.Start(outputFilePath)
    End Sub
End Module
