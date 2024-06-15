<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PcbGambar = New System.Windows.Forms.PictureBox()
        Me.BtnBuka = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.ofdBuka = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PcbGambar
        '
        Me.PcbGambar.Location = New System.Drawing.Point(12, 36)
        Me.PcbGambar.Name = "PcbGambar"
        Me.PcbGambar.Size = New System.Drawing.Size(470, 264)
        Me.PcbGambar.TabIndex = 0
        Me.PcbGambar.TabStop = False
        '
        'BtnBuka
        '
        Me.BtnBuka.Location = New System.Drawing.Point(103, 329)
        Me.BtnBuka.Name = "BtnBuka"
        Me.BtnBuka.Size = New System.Drawing.Size(125, 37)
        Me.BtnBuka.TabIndex = 1
        Me.BtnBuka.Text = "Buka"
        Me.BtnBuka.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(258, 329)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(125, 37)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ofdBuka
        '
        Me.ofdBuka.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 459)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnBuka)
        Me.Controls.Add(Me.PcbGambar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Buka Gambar"
        CType(Me.PcbGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PcbGambar As System.Windows.Forms.PictureBox
    Friend WithEvents BtnBuka As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents ofdBuka As System.Windows.Forms.OpenFileDialog

End Class
