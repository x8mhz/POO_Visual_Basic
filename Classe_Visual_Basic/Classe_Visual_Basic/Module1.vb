Module Module1

    Sub Main()

        Dim p1 As Personagem
        p1 = New Personagem

        Dim nome As String
        Dim num_classe As Integer
        Dim num_poder As Integer

        Console.Write("NOME: ")
        nome = Console.ReadLine()
        Console.WriteLine(Chr(10) & "1 = Guerreiro; 2 = Mago; 3 = Arqueiro")
        Console.Write("CLASSE: ")
        num_classe = Console.ReadLine()
        Console.WriteLine(Chr(10) & "1 = Fogo; 2 = Luz; 3 = Vento")
        Console.Write("PODER: ")
        num_poder = Console.ReadLine()

        p1.Nome_Personagem = nome

        Select Case num_classe
            Case 1
                p1.Classe_Perosnagem = "Guerreiro"

            Case 2
                p1.Classe_Perosnagem = "Mago"

            Case 3
                p1.Classe_Perosnagem = "Arqueiro"

            Case Else
                Console.WriteLine("Opção Inválida!")
        End Select

        Select Case num_poder
            Case 1
                p1.Poder_Personagem = "Fogo"

            Case 2
                p1.Poder_Personagem = "Água"

            Case 3
                p1.Poder_Personagem = "Ar"

            Case Else
                Console.WriteLine("Opção Inválida!")
        End Select

        Console.Clear()
        p1.Exibir()

        Console.ReadKey()

    End Sub

End Module
