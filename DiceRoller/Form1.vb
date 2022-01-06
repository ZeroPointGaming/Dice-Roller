Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ArrayRolls() As String = {"1", "2", "3", "4", "5", "6"}

        Dim Random As New Random

        Dim roll As Integer = Random.Next(1, 7)

        ListBox1.Items.Add("Rolled: " + roll.ToString())

        Select Case roll
            Case "1"
                Panel1.BackgroundImage = My.Resources._1
            Case "2"
                Panel1.BackgroundImage = My.Resources._2
            Case "3"
                Panel1.BackgroundImage = My.Resources._3
            Case "4"
                Panel1.BackgroundImage = My.Resources._4
            Case "5"
                Panel1.BackgroundImage = My.Resources._5
            Case "6"
                Panel1.BackgroundImage = My.Resources._6
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
    End Sub
End Class
