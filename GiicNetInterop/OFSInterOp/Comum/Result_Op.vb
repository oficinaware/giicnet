Public Class Result_Op(Of T)
    Public Property Status As Boolean
    Public Property Msg As String
    Public Property Valor As T


    Public Sub New()
        Status = False
        Msg = "Erro!!!"

    End Sub

End Class
