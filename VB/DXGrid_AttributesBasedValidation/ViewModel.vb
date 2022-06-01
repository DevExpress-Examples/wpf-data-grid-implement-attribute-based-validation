Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXGrid_AttributesBasedValidation

    Public Class ViewModel
        Inherits ViewModelBase

        Public Sub New()
            Source = GetStaff()
        End Sub

        Public Property Source As ObservableCollection(Of Employee)
    End Class
End Namespace
