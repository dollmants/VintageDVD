Public Class frmVintage
    Inherits System.Windows.Forms.Form

    ' ************************************************************************
    ' When I last left this program I was on page 90 (Chapter 3)
    '   of the Text.
    ' ************************************************************************

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
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblDVDName As System.Windows.Forms.Label
    Friend WithEvents lblDVDPrice As System.Windows.Forms.Label
    Friend WithEvents lblTaxes As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents txtDVDName As System.Windows.Forms.TextBox
    Friend WithEvents txtDVDPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxes As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountDue As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVintage))
        Me.lblVintage = New System.Windows.Forms.Label()
        Me.picVintageLogo = New System.Windows.Forms.PictureBox()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblDVDName = New System.Windows.Forms.Label()
        Me.lblDVDPrice = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtDVDName = New System.Windows.Forms.TextBox()
        Me.txtDVDPrice = New System.Windows.Forms.TextBox()
        Me.txtTaxes = New System.Windows.Forms.TextBox()
        Me.txtAmountDue = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblLine = New System.Windows.Forms.Label()
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
        Me.btnMessage.Size = New System.Drawing.Size(192, 40)
        Me.btnMessage.TabIndex = 2
        Me.btnMessage.Text = "Click me First!"
        '
        'lblCustName
        '
        Me.lblCustName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(232, 80)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(140, 20)
        Me.lblCustName.TabIndex = 3
        Me.lblCustName.Text = "Customer Name"
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDVDName
        '
        Me.lblDVDName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDVDName.Location = New System.Drawing.Point(272, 120)
        Me.lblDVDName.Name = "lblDVDName"
        Me.lblDVDName.Size = New System.Drawing.Size(100, 20)
        Me.lblDVDName.TabIndex = 4
        Me.lblDVDName.Text = "DVD Name"
        Me.lblDVDName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDVDPrice
        '
        Me.lblDVDPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDVDPrice.Location = New System.Drawing.Point(272, 160)
        Me.lblDVDPrice.Name = "lblDVDPrice"
        Me.lblDVDPrice.Size = New System.Drawing.Size(100, 20)
        Me.lblDVDPrice.TabIndex = 5
        Me.lblDVDPrice.Text = "DVD Price"
        Me.lblDVDPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTaxes
        '
        Me.lblTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(272, 200)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(100, 20)
        Me.lblTaxes.TabIndex = 6
        Me.lblTaxes.Text = "Taxes"
        Me.lblTaxes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAmountDue
        '
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.Location = New System.Drawing.Point(272, 264)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(100, 20)
        Me.lblAmountDue.TabIndex = 7
        Me.lblAmountDue.Text = "Amount Due"
        Me.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(384, 80)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(140, 20)
        Me.txtCustName.TabIndex = 8
        Me.txtCustName.Text = ""
        '
        'txtDVDName
        '
        Me.txtDVDName.Location = New System.Drawing.Point(384, 120)
        Me.txtDVDName.Name = "txtDVDName"
        Me.txtDVDName.Size = New System.Drawing.Size(140, 20)
        Me.txtDVDName.TabIndex = 9
        Me.txtDVDName.Text = ""
        '
        'txtDVDPrice
        '
        Me.txtDVDPrice.Location = New System.Drawing.Point(384, 160)
        Me.txtDVDPrice.Name = "txtDVDPrice"
        Me.txtDVDPrice.Size = New System.Drawing.Size(140, 20)
        Me.txtDVDPrice.TabIndex = 10
        Me.txtDVDPrice.Text = ""
        '
        'txtTaxes
        '
        Me.txtTaxes.Location = New System.Drawing.Point(384, 200)
        Me.txtTaxes.Name = "txtTaxes"
        Me.txtTaxes.Size = New System.Drawing.Size(140, 20)
        Me.txtTaxes.TabIndex = 11
        Me.txtTaxes.Text = ""
        '
        'txtAmountDue
        '
        Me.txtAmountDue.Location = New System.Drawing.Point(384, 264)
        Me.txtAmountDue.Name = "txtAmountDue"
        Me.txtAmountDue.Size = New System.Drawing.Size(140, 20)
        Me.txtAmountDue.TabIndex = 12
        Me.txtAmountDue.Text = ""
        '
        'btnCalc
        '
        Me.btnCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.Location = New System.Drawing.Point(24, 312)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(120, 40)
        Me.btnCalc.TabIndex = 13
        Me.btnCalc.Text = "Calculate"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(232, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(440, 312)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 40)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.Black
        Me.lblLine.Location = New System.Drawing.Point(384, 240)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(140, 2)
        Me.lblLine.TabIndex = 16
        '
        'frmVintage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblLine, Me.btnExit, Me.btnClear, Me.btnCalc, Me.txtAmountDue, Me.txtTaxes, Me.txtDVDPrice, Me.txtDVDName, Me.txtCustName, Me.lblAmountDue, Me.lblTaxes, Me.lblDVDPrice, Me.lblDVDName, Me.lblCustName, Me.btnMessage, Me.picVintageLogo, Me.lblVintage})
        Me.Name = "frmVintage"
        Me.Text = "Vintage DVDs"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lblVintage_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles lblVintage.Click

    End Sub

    Private Sub btnMessage_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnMessage.Click
        MsgBox("Welcome to Vintage DVDs!")
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles btnCalc.Click
        Const sngTaxRate As Single = 0.07 'Use local tax rate
        Dim decPrice, decAmountDue, decTaxes As Decimal  ' Declare variables as Decimal
        decPrice = CDec(txtDVDPrice.Text) ' CDec = Currency Format
        decTaxes = decPrice * sngTaxRate 'Compute taxes
        decAmountDue = decPrice + decTaxes 'Compute amount due
        txtTaxes.Text = CStr(decTaxes)
        txtAmountDue.Text = CStr(decAmountDue)
    End Sub

End Class
