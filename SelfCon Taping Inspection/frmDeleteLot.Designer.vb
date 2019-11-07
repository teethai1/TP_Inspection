<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteLot
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ltDelete = New System.Windows.Forms.ListBox
        Me.btOK = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.tbLotNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btkeyboard = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ltDelete
        '
        Me.ltDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ltDelete.FormattingEnabled = True
        Me.ltDelete.ItemHeight = 25
        Me.ltDelete.Location = New System.Drawing.Point(26, 19)
        Me.ltDelete.Name = "ltDelete"
        Me.ltDelete.Size = New System.Drawing.Size(186, 404)
        Me.ltDelete.TabIndex = 0
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.Lime
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btOK.Location = New System.Drawing.Point(262, 216)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(82, 63)
        Me.btOK.TabIndex = 1
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Crimson
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btCancel.Location = New System.Drawing.Point(468, 217)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(87, 60)
        Me.btCancel.TabIndex = 2
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'tbLotNo
        '
        Me.tbLotNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.tbLotNo.Location = New System.Drawing.Point(262, 129)
        Me.tbLotNo.Name = "tbLotNo"
        Me.tbLotNo.Size = New System.Drawing.Size(293, 38)
        Me.tbLotNo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lot Number."
        '
        'btkeyboard
        '
        Me.btkeyboard.BackgroundImage = Global.SelfCon.My.Resources.Resources.Kids_Computer_Keyboard1
        Me.btkeyboard.Location = New System.Drawing.Point(262, 312)
        Me.btkeyboard.Name = "btkeyboard"
        Me.btkeyboard.Size = New System.Drawing.Size(297, 111)
        Me.btkeyboard.TabIndex = 2
        Me.btkeyboard.UseVisualStyleBackColor = True
        '
        'frmDeleteLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(624, 443)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbLotNo)
        Me.Controls.Add(Me.btkeyboard)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.ltDelete)
        Me.Name = "frmDeleteLot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDeleteLot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ltDelete As System.Windows.Forms.ListBox
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents tbLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btkeyboard As System.Windows.Forms.Button
End Class
