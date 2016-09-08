Public Class frmVintage
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblVintage As System.Windows.Forms.Label
    Friend WithEvents picVintageLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMessage As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVintage))
        Me.lblVintage = New System.Windows.Forms.Label()
        Me.picVintageLogo = New System.Windows.Forms.PictureBox()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVintage
        '
        Me.lblVintage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVintage.Location = New System.Drawing.Point(16, 16)
        Me.lblVintage.Name = "lblVintage"
        Me.lblVintage.Size = New System.Drawing.Size(200, 48)
        Me.lblVintage.TabIndex = 0
        Me.lblVintage.Text = "Vintage DVDs: Old Movies on DVD!"
        '
        'picVintageLogo
        '
        Me.picVintageLogo.Image = CType(resources.GetObject("picVintageLogo.Image"), System.Drawing.Bitmap)
        Me.picVintageLogo.Location = New System.Drawing.Point(232, 8)
        Me.picVintageLogo.Name = "picVintageLogo"
        Me.picVintageLogo.Size = New System.Drawing.Size(72, 56)
        Me.picVintageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVintageLogo.TabIndex = 1
        Me.picVintageLogo.TabStop = False
        '
        'btnMessage
        '
        Me.btnMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMessage.Location = New System.Drawing.Point(16, 80)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(192, 24)
        Me.btnMessage.TabIndex = 2
        Me.btnMessage.Text = "Click me First!"
        '
        'frmVintage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 270)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnMessage, Me.picVintageLogo, Me.lblVintage})
        Me.Name = "frmVintage"
        Me.Text = "Vintage DVDs"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lblVintage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVintage.Click

    End Sub

    Private Sub btnMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMessage.Click
        MsgBox("Welcome to Vintage DVDs!")
    End Sub
End Class
