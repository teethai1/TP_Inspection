Public Class frmDeleteLot
    Dim keyboard As frmKeyboard = frmKeyboard

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        If tbLotNo.Text.Length <> 10 Then
            MsgBox("Lot No ไม่ถูกต้องกรุณาตรวจสอบด้วยครับ")
            Exit Sub
        End If

        If MessageBox.Show("คุณต้องการลบหรือไม่", "Do you want delete data ?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim removeList As List(Of DataRow) = New List(Of DataRow)
            Dim Checkdata As Boolean = False
            For Each row As DBxDataSet.TPINSDataRow In frmMain.DBxDataSet.TPINSData
                If row.LotNo = tbLotNo.Text Then
                    removeList.Add(row)
                    Checkdata = True
                End If
            Next
            For Each row As DataRow In removeList
                frmMain.DBxDataSet.TPINSData.Rows.Remove(row)
            Next
            If Checkdata = True Then
                frmMain.SaveDataLotBin()
                CountListData()
                tbLotNo.Clear()
            Else
                MsgBox("ไม่พบ Lot ที่ต้องการลบ")
            End If
        End If
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        tbLotNo.Clear()
    End Sub

    Private Sub frmDeleteLot_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmMain.CountListData()
        If frmKeyboard.Visible = True Then
            frmKeyboard.Hide()
        End If
    End Sub

    Private Sub frmDeleteLot_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CountListData()
        tbLotNo.Clear()
    End Sub

    Private Sub tbLotNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLotNo.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        keyboard.TargetkeyboardTextbox = tb
    End Sub

    Private Sub btkeyboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btkeyboard.Click
        frmKeyboard.Show()
    End Sub
    Private Sub CountListData()
        ltDelete.Items.Clear()
        For Each row As DBxDataSet.TPINSDataRow In frmMain.DBxDataSet.TPINSData
            ltDelete.Items.Add(row.LotNo)
        Next
    End Sub

    Private Sub ltDelete_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltDelete.SelectedIndexChanged
        Dim lt As ListBox = CType(sender, ListBox)
        tbLotNo.Text = lt.Text
    End Sub
End Class