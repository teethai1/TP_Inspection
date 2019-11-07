Public Class frmSearch

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        tbLot.Clear()
        DBxDataSet.TPINSData.Rows.Clear()
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button11.Click, Button10.Click, Button40.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button1.Click
        Dim bt As Button = CType(sender, Button)
        Dim key As String
        key = "{" & bt.Text & "}"
        tbLot.Focus()
        SendKeys.Send(key)
    End Sub

    Private Sub btSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSearch.Click
        If tbLot.Text.Length <> 10 Then
            MsgBox("กรุณาใส่ Lot No.ให้ถูกต้อง")
            Exit Sub
        ElseIf frmMain.m_OfflineMode <> "Online" Then
            MsgBox("ไม่สามารถค้นหาข้อมูลได้ในโหมด Offline")
            Exit Sub
        End If
        Dim lotNo As String = tbLot.Text
        TPINSDataTableAdapter.FillBy(DBxDataSet.TPINSData, lotNo)
        If DBxDataSet.TPINSData.Rows.Count = 0 Then
            MsgBox("ไม่พบข้อมูลในฐานข้อมูล")
        End If
    End Sub
End Class