Public Class frmKeyboard
    Private m_KeytextBox As TextBox
    Public Property TargetkeyboardTextbox() As TextBox
        Get
            Return m_KeytextBox
        End Get
        Set(ByVal value As TextBox)
            m_KeytextBox = value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button38.Click
        If m_KeytextBox Is Nothing Then
            Exit Sub
        End If
        Dim bt As Button = CType(sender, Button)
        m_KeytextBox.Focus()
        SendKeys.Send("{" & bt.Text & "}")
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Me.Hide()
    End Sub

    Private Sub frmKeyboard_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Position As Point = New Point(300, 450)
        Me.Location = Position
    End Sub
End Class