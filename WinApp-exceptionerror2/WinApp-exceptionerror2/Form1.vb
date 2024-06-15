Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        Try
            Dim X As Integer
            X = TxtAngka.Text
            Do
                X = X Mod 2
                If X = 0 Then
                    MessageBox.Show("Bilangan Genap", "Informasi")
                    Exit Do
                ElseIf X = 1 Then
                    MessageBox.Show("Bilangan Ganjil", "Informasi")
                    Exit Do
                End If
            Loop While Not X
        Catch ex As Exception
            MsgBox("SALAH INPUT! Masukkan Angka")
        Finally
            TxtAngka.Text = ""
            TxtAngka.Focus()
        End Try
    End Sub
End Class
