Class MainWindow
    Private Sub CalB_Click(sender As Object, e As RoutedEventArgs) Handles CalB.Click
        Dim d As Integer
        Dim m As Integer
        m = Cal_Won.SelectedDate.Value.Month
        d = Cal_Won.SelectedDate.Value.Day
        If m = 1 And d > 19 Then
            Label_Won.Content = "Capricorn ♑️"
        End If
        If m = 1 And d > 20 Then
            Label_Won.Content = "Aquarius ♒️"
        End If
        If m = 2 And d < 18 Then
            Label_Won.Content = "Aquarius ♒️"
        End If
        If m = 2 And d > 19 Then
            Label_Won.Content = "Pisces ♓️"
        End If
        If m = 3 And d < 20 Then
            Label_Won.Content = "Pisces ♓️"
        End If
        If m = 3 And d > 21 Then
            Label_Won.Content = "Aries ♈️"
        End If
        If m = 4 And d < 19 Then
            Label_Won.Content = "Aries ♈️"
        End If
        If m = 4 And d > 20 Then
            Label_Won.Content = "Taurus ♉️"
        End If
        If m = 5 And d < 20 Then
            Label_Won.Content = "Taurus ♉️"
        End If
        If m = 5 And d > 21 Then
            Label_Won.Content = "Gemini ♊️"
        End If
        If m = 6 And d < 20 Then
            Label_Won.Content = "Gemini ♊️"
        End If
        If m = 6 And d > 21 Then
            Label_Won.Content = "Cancer ♋️"
        End If
        If m = 7 And d < 22 Then
            Label_Won.Content = "Cancer ♋️"
        End If
        If m = 7 And d > 23 Then
            Label_Won.Content = "Leo ♌️"
        End If
        If m = 8 And d < 22 Then
            Label_Won.Content = "Leo ♌️"
        End If
        If m = 8 And d > 23 Then
            Label_Won.Content = "Virgo ♍️"
        End If
        If m = 9 And d < 22 Then
            Label_Won.Content = "Virgo ♍️"
        End If
        If m = 9 And d > 23 Then
            Label_Won.Content = "Libra ♎️"
        End If
        If m = 10 And d < 22 Then
            Label_Won.Content = "Libra ♎️"
        End If
        If m = 10 And d > 23 Then
            Label_Won.Content = "Scorpio ♏️"
        End If
        If m = 11 And d < 21 Then
            Label_Won.Content = "Scorpio ♏️"
        End If
        If m = 11 And d > 22 Then
            Label_Won.Content = "Sagittarius ♐️"
        End If
        If m = 12 And d < 21 Then
            Label_Won.Content = "Sagittarius ♐️"
        End If
        If m = 12 And d > 22 Then
            Label_Won.Content = "Capricorn ♑️"
        End If
    End Sub
End Class
