Public Class frmInputQR
    Public QRCode As String
    Public QROpNo As String
    Public QRGLNo As String
    Public InputQtyOSFT As Integer
    Public inputTPQr As Integer
    Public Caption As String
    Public InputPickUp As Integer
    Public DeviecDLot As String




    Private Sub tbRevQR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbRevQR.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.Chr(Keys.Return) Then
            If tbRevQR.Text.Length = 252 AndAlso lbCaption.Text = "SCAN QR CODE" Then
                QRCode = ""
                QRCode = tbRevQR.Text
                'Dim input As Integer
                lbCaption.Text = "SCAN OP No."
                ProgressBar1.Value = 0
                tbRevQR.Clear()


            ElseIf tbRevQR.Text.Length = 6 AndAlso lbCaption.Text = "SCAN OP No." AndAlso IsNumeric(tbRevQR.Text) = True Then
                QROpNo = ""
                QROpNo = tbRevQR.Text
                tbRevQR.Clear()
                Timer1.Stop()
                ProgressBar1.Value = 0
                Me.DialogResult = Windows.Forms.DialogResult.OK

            ElseIf tbRevQR.Text.Length = 6 AndAlso lbCaption.Text = "SCAN GL No." AndAlso IsNumeric(tbRevQR.Text) = True Then
                QRGLNo = ""
                QRGLNo = tbRevQR.Text
                QROpNo = QRGLNo
                tbRevQR.Clear()
                Timer1.Stop()
                ProgressBar1.Value = 0
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else
                ProgressBar1.Value = 0
                tbRevQR.Clear()
                MsgBox("QRCode ไม่ถูกต้องกรุณาสแกนใหม่")
            End If
        End If

    End Sub

    Private Sub frmInputQR_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        tbRevQR.Focus()
    End Sub


    Private Sub frmInputQR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbCaption.Text = Caption
        Timer1.Start()
        tbRevQR.Focus()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If lbCaption.Text = "SCAN QR CODE" Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 252) * 100
            ElseIf lbCaption.Text = "SCAN OP No." Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 6) * 100
            ElseIf lbCaption.Text = "SCAN GL No." Then
                ProgressBar1.Value = (tbRevQR.Text.Length / 6) * 100
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class