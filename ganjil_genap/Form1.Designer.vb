<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lblHasil = New System.Windows.Forms.Label
        Me.txtInputNumber = New System.Windows.Forms.TextBox
        Me.btnCek = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(243, 188)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(39, 13)
        Me.lblHasil.TabIndex = 0
        Me.lblHasil.Text = "Label1"
        '
        'txtInputNumber
        '
        Me.txtInputNumber.Location = New System.Drawing.Point(13, 32)
        Me.txtInputNumber.Name = "txtInputNumber"
        Me.txtInputNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtInputNumber.TabIndex = 1
        '
        'btnCek
        '
        Me.btnCek.Location = New System.Drawing.Point(13, 91)
        Me.btnCek.Name = "btnCek"
        Me.btnCek.Size = New System.Drawing.Size(163, 23)
        Me.btnCek.TabIndex = 2
        Me.btnCek.Text = "Cek Bilangan"
        Me.btnCek.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 261)
        Me.Controls.Add(Me.btnCek)
        Me.Controls.Add(Me.txtInputNumber)
        Me.Controls.Add(Me.lblHasil)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHasil As System.Windows.Forms.Label
    Friend WithEvents txtInputNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnCek As System.Windows.Forms.Button

End Class
