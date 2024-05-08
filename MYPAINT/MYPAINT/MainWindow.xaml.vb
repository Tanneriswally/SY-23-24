Imports Microsoft.Win32
Imports System.IO
Class MainWindow
    Dim c1 As Color
    Dim c2 As Color
    Private Sub drawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If shapeLabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthSlider.Value
            el.Height = heightSlider.Value
            el.Fill = colorRec1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
        If shapeLabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthSlider.Value
            el.Height = heightSlider.Value
            el.Fill = colorRec1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
        If shapeLabel.Content = "Polygon" Then
            Dim r As New Polygon
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            r.Fill = colorRec1.Fill
            r.Points.Add(p + New Point(0 * widthSlider.Value, -3 * widthSlider.Value))
            r.Points.Add(p + New Point(3 * widthSlider.Value, -3 * widthSlider.Value))
            r.Points.Add(p + New Point(-3 * widthSlider.Value, 3 * widthSlider.Value))
            r.Points.Add(p + New Point(0 * widthSlider.Value, 3 * widthSlider.Value))
            r.Points.Add(p + New Point(0 * widthSlider.Value, 0 * widthSlider.Value))
            r.Points.Add(p + New Point(-6 * widthSlider.Value, 0 * widthSlider.Value))
            r.Points.Add(p + New Point(-6 * widthSlider.Value, 6 * widthSlider.Value))
            r.Points.Add(p + New Point(6 * widthSlider.Value, -6 * widthSlider.Value))
            r.Points.Add(p + New Point(6 * widthSlider.Value, 0 * widthSlider.Value))
            r.Points.Add(p + New Point(0 * widthSlider.Value, 0 * widthSlider.Value))
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(r)
            End If
        End If
    End Sub
    Private Sub c1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colorRec1.MouseDown, colorRec2.MouseDown, C3.MouseDown, C4.MouseDown
        colorRec1.Fill = sender.fill
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveRange(1, DrawingCanvas.Children.Count - 1)
    End Sub
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveAt(DrawingCanvas.Children.Count - 1)
    End Sub
    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        shapeLabel.Content = sender.content
    End Sub
    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        shapeLabel.Content = sender.content
    End Sub
    Private Sub angleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleSlider.ValueChanged
        colorRec1.Fill = New LinearGradientBrush(Colors.Red, Colors.White, angleSlider.Value)
    End Sub
    Public Function setlineargradient(c1 As Color, c2 As Color)
        Return New LinearGradientBrush(c1, c2, 45)
    End Function
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using



        surface.LayoutTransform = transform

        Canvas.SetLeft(DrawingCanvas, 0)

        Canvas.SetTop(DrawingCanvas, 0)

    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        ExportToPng(DrawingCanvas)
    End Sub
    Private Sub Poly_Click(sender As Object, e As RoutedEventArgs) Handles Poly.Click

    End Sub

    Private Sub C4_MouseEnter(sender As Object, e As MouseEventArgs) Handles C4.MouseEnter

    End Sub

    Private Sub Rectangle_Click(sender As Object, e As RoutedEventArgs) Handles Rectangle.Click

    End Sub
End Class
