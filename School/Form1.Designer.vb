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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.P2 = New System.Windows.Forms.PictureBox()
        Me.P3 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.BackColor = System.Drawing.Color.Transparent
        Me.P1.Image = CType(resources.GetObject("P1.Image"), System.Drawing.Image)
        Me.P1.Location = New System.Drawing.Point(200, 115)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(31, 31)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'P2
        '
        Me.P2.BackColor = System.Drawing.Color.Transparent
        Me.P2.Image = CType(resources.GetObject("P2.Image"), System.Drawing.Image)
        Me.P2.Location = New System.Drawing.Point(247, 115)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(31, 31)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P2.TabIndex = 0
        Me.P2.TabStop = False
        '
        'P3
        '
        Me.P3.BackColor = System.Drawing.Color.Transparent
        Me.P3.Image = CType(resources.GetObject("P3.Image"), System.Drawing.Image)
        Me.P3.Location = New System.Drawing.Point(294, 115)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(31, 31)
        Me.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.P3.TabIndex = 0
        Me.P3.TabStop = False
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Grading System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Devloped By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(377, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Suvadip Mandal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 198)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents P2 As System.Windows.Forms.PictureBox
    Friend WithEvents P3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
