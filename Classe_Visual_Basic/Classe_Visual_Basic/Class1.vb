Public Class Personagem

    Private Property nome As String
    Private Property classe As String
    Private Property poder As String

    Property Nome_Personagem() As String
        Get
            Return nome
        End Get
        Set(ByVal n As String)
            nome = n
        End Set
    End Property

    Property Classe_Perosnagem() As String
        Get
            Return classe
        End Get
        Set(c As String)
            classe = c
        End Set
    End Property

    Property Poder_Personagem() As String
        Get
            Return poder
        End Get
        Set(p As String)
            poder = p
        End Set
    End Property

    Public Sub Exibir()
        Console.WriteLine("O nome do poderoso " & classe & " era " & nome & ", e seu elemento de poder era " & poder)
    End Sub

End Class
