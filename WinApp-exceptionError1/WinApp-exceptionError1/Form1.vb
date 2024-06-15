Public Class Form1

    Private Sub BtnBuka_Click(sender As Object, e As EventArgs) Handles BtnBuka.Click
        If ofdBuka.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                PcbGambar.Image = Image.FromFile(ofdBuka.FileName)
                Me.Text = "Membuka File " + ofdBuka.FileName
            Catch ex As Exception
                MessageBox.Show("FILE GAGAL DIBUKA! Pastikan File Berbentuk Gmabar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim Tutup As String
        Tutup = MessageBox.Show("Yakin tutup form ini ?", "Konfirmasi",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Tutup = MsgBoxResult.Yes Then
            End
        Else
            Exit Sub
        End If
    End Sub
End Class
