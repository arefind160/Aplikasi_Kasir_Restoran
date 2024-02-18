Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbitem.SelectedIndexChanged
        If cmbitem.Text = "Tongseng" Then
            txtharga.Text = 35000
        ElseIf cmbitem.Text = "Sate Ayam" Then
            txtharga.Text = 27000
        ElseIf cmbitem.Text = "Nasi Goreng" Then
            txtharga.Text = 20000
        ElseIf cmbitem.Text = "Ayam Geprek" Then
            txtharga.Text = 25000
        ElseIf cmbitem.Text = "Bubur Kampiun" Then
            txtharga.Text = 23000
        End If
    End Sub

    Private Sub btnsubtotal_Click(sender As Object, e As EventArgs) Handles btnsubtotal.Click
        txtsubtotal.Text = txtharga.Text * txtjumlah.Text

    End Sub

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = txtsubtotal.Text - (txtsubtotal.Text * txtdiskon.Text) / 100
        Label4.Text = txttotal.Text

    End Sub

    Private Sub txtbayar_Leave(sender As Object, e As EventArgs) Handles txtbayar.Leave
        txtkembali.Text = txtbayar.Text - txttotal.Text

    End Sub

    Private Sub cmbvoucher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbvoucher.SelectedIndexChanged
        If cmbvoucher.Text = "AKHIRPEKAN" Then
            txtdiskon.Text = 10
        ElseIf cmbvoucher.Text = "AKHIRBULAN" Then
            txtdiskon.Text = 20
        ElseIf cmbvoucher.Text = "AKHIRTAHUN" Then
            txtdiskon.Text = 30
        ElseIf cmbvoucher.Text = "TIDAK ADA" Then
            txtdiskon.Text = 0
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        cmbitem.Text = ""
        txtharga.Text = ""
        txtjumlah.Text = ""
        txtsubtotal.Text = ""
        txtdiskon.Text = ""
        txttotal.Text = ""
        txtbayar.Text = ""
        txtkembali.Text = ""
        cmbvoucher.Text = ""
        Label4.Text = ""
        cmbitem.Focus()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub
End Class
