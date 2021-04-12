<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLap
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
        Me.btnlaplelang = New System.Windows.Forms.Button()
        Me.btnlaphistory = New System.Windows.Forms.Button()
        Me.btnlapbrg = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnlaplelang
        '
        Me.btnlaplelang.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlaplelang.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnlaplelang.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlaplelang.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaplelang.ForeColor = System.Drawing.Color.White
        Me.btnlaplelang.Location = New System.Drawing.Point(551, 559)
        Me.btnlaplelang.Name = "btnlaplelang"
        Me.btnlaplelang.Size = New System.Drawing.Size(127, 46)
        Me.btnlaplelang.TabIndex = 82
        Me.btnlaplelang.Text = "Laporan Pelelangan"
        Me.btnlaplelang.UseVisualStyleBackColor = True
        '
        'btnlaphistory
        '
        Me.btnlaphistory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlaphistory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnlaphistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlaphistory.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaphistory.ForeColor = System.Drawing.Color.White
        Me.btnlaphistory.Location = New System.Drawing.Point(551, 405)
        Me.btnlaphistory.Name = "btnlaphistory"
        Me.btnlaphistory.Size = New System.Drawing.Size(127, 46)
        Me.btnlaphistory.TabIndex = 81
        Me.btnlaphistory.Text = "Laporan History"
        Me.btnlaphistory.UseVisualStyleBackColor = True
        '
        'btnlapbrg
        '
        Me.btnlapbrg.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnlapbrg.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnlapbrg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnlapbrg.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlapbrg.ForeColor = System.Drawing.Color.White
        Me.btnlapbrg.Location = New System.Drawing.Point(551, 251)
        Me.btnlapbrg.Name = "btnlapbrg"
        Me.btnlapbrg.Size = New System.Drawing.Size(127, 46)
        Me.btnlapbrg.TabIndex = 80
        Me.btnlapbrg.Text = "Laporan Barang"
        Me.btnlapbrg.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Candara", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(518, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 59)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Laporan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmLap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1213, 777)
        Me.Controls.Add(Me.btnlaplelang)
        Me.Controls.Add(Me.btnlaphistory)
        Me.Controls.Add(Me.btnlapbrg)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLap"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlaplelang As System.Windows.Forms.Button
    Friend WithEvents btnlaphistory As System.Windows.Forms.Button
    Friend WithEvents btnlapbrg As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
