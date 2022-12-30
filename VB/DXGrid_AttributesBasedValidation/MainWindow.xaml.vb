Imports System.Windows
Imports System.Windows.Controls

Namespace DXGrid_AttributesBasedValidation

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetStuff()
        End Sub
    End Class
End Namespace
