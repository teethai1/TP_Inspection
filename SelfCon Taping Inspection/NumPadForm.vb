Public Class NumPadForm

    Private m_TargetTextBox As TextBox
    Public Property TargetTextBox() As TextBox
        Get
            Return m_TargetTextBox
        End Get
        Set(ByVal value As TextBox)
            m_TargetTextBox = value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.MouseDown, Button8.MouseDown, Button7.MouseDown, Button6.MouseDown, Button5.MouseDown, Button4.MouseDown, Button3.MouseDown, Button2.MouseDown, Button10.MouseDown, Button1.MouseDown
        If m_TargetTextBox Is Nothing Then
            Exit Sub
        End If
        Dim btn As Button = CType(sender, Button)
        If IsNumeric(btn.Text) Then
            m_TargetTextBox.AppendText(btn.Text)
            m_TargetTextBox.Text = CInt(m_TargetTextBox.Text).ToString()
        End If

        If m_TargetTextBox.Name = "tbInput" OrElse m_TargetTextBox.Name.Contains("tbNG") = True Then
            frmMain.Calculate(m_TargetTextBox)
        End If

    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.MouseDown
        Me.Hide()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.MouseDown
        If m_TargetTextBox Is Nothing Then
            Exit Sub
        End If
        m_TargetTextBox.Focus()
        SendKeys.Send("{TAB}")
        m_TargetTextBox = Nothing
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.MouseDown
        m_TargetTextBox.Focus()
        SendKeys.Send("{BS}")
    End Sub


End Class