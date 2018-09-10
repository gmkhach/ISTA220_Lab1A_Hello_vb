' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

Imports Windows.UI.Popups

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub onClick(sender As Object, e As RoutedEventArgs) Handles ok.Click
        Dim msg = New MessageDialog("Hello " + userName.Text)
        msg.ShowAsync()
    End Sub
End Class
