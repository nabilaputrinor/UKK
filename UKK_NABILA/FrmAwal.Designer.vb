<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAwal
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
        Me.btnpenawar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnpetugas = New System.Windows.Forms.Button()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnpenawar
        '
        Me.btnpenawar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpenawar.FlatAppearance.BorderSize = 2
        Me.btnpenawar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnpenawar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpenawar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnpenawar.Location = New System.Drawing.Point(332, 44)
        Me.btnpenawar.Name = "btnpenawar"
        Me.btnpenawar.Size = New System.Drawing.Size(95, 31)
        Me.btnpenawar.TabIndex = 3
        Me.btnpenawar.Text = "Penawar"
        Me.btnpenawar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(171, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login sebagai...?"
        '
        'btnpetugas
        '
        Me.btnpetugas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpetugas.FlatAppearance.BorderSize = 2
        Me.btnpetugas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnpetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpetugas.ForeColor = System.Drawing.SystemColors.Window
        Me.btnpetugas.Location = New System.Drawing.Point(178, 44)
        Me.btnpetugas.Name = "btnpetugas"
        Me.btnpetugas.Size = New System.Drawing.Size(95, 31)
        Me.btnpetugas.TabIndex = 1
        Me.btnpetugas.Text = "Petugas"
        Me.btnpetugas.UseVisualStyleBackColor = True
        '
        'btnadmin
        '
        Me.btnadmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnadmin.FlatAppearance.BorderSize = 2
        Me.btnadmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadmin.ForeColor = System.Drawing.SystemColors.Window
        Me.btnadmin.Location = New System.Drawing.Point(14, 44)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(95, 31)
        Me.btnadmin.TabIndex = 0
        Me.btnadmin.Text = "Admin"
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("FontAwesome", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(546, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 96)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnpenawar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnpetugas)
        Me.Panel1.Controls.Add(Me.btnadmin)
        Me.Panel1.Location = New System.Drawing.Point(383, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 109)
        Me.Panel1.TabIndex = 87
        '
        'FrmAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 777)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormAwal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnpenawar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnpetugas As System.Windows.Forms.Button
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
