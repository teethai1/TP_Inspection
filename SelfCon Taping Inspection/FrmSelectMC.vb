

Public Class FrmSelectMC
    Public InputMC As String

    'Dim Key As String
    'Private Sub ClickButtoN_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtB.Click, BtC.Click _
    '                             , BtM.Click, BtN.Click, BtV.Click, BtX.Click, BtZ.Click, BtBS.Click, BtY.MouseDown, BtW.MouseDown, BtU.MouseDown, Btt.MouseDown, BtS.MouseDown, BtR.MouseDown, BtQ.MouseDown, BtP.MouseDown, BtO.MouseDown, BtMinus.MouseDown, BtL.MouseDown, BtK.MouseDown, BtJ.MouseDown, BtI.MouseDown, BtH.MouseDown, BtG.MouseDown, BtF.MouseDown, BtE.MouseDown, BtD.MouseDown, BtA.MouseDown, Bt9.MouseDown, Bt8.MouseDown, Bt7.MouseDown, Bt6.MouseDown, Bt5.MouseDown, Bt4.MouseDown, Bt3.MouseDown, Bt2.MouseDown, Bt1.MouseDown, Bt0.MouseDown, BtZ.MouseDown, BtX.MouseDown, BtV.MouseDown, BtN.MouseDown, BtM.MouseDown, BtC.MouseDown, BtB.MouseDown

    '    Dim Btn As Button = CType(sender, Button)
    '    Key = Btn.Text
    '    If Btn.Text = "BACKSPACE" Or Btn.Text = "CLEAR" Then
    '        Key = "{" & Btn.Text & "}"
    '    End If
    '    tbMcName.Focus()
    '    My.Computer.Keyboard.SendKeys(Key, True)
    'End Sub

    'Private Sub BtClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtClear.Click
    '    tbMcName.Text = ""
    'End Sub

    'Private Sub BtEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
    '    Me.Close()
    'End Sub

    'Private Sub FrmKeyBoard_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '    tbMcName.Clear()
    '    tbMcName.Focus()
    'End Sub

    'Private Sub FrmKeyBoard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    tbMcName.Focus()
    'End Sub

    'Private Sub BtEnter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtEnter.Click
    '    If tbMcName.Text <> "" Then
    '        InputMC = tbMcName.Text
    '        Me.DialogResult = Windows.Forms.DialogResult.OK
    '        Me.Close()
    '    Else
    '        MsgBox("กรุณากรอก Machine No.")
    '    End If
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbbMC.Text <> "" Then
            InputMC = cbbMC.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("กรุณาเลือก Machine Number")
        End If
    End Sub

    Private Sub FrmSelectMC_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cbbMC.Text = ""
    End Sub
End Class