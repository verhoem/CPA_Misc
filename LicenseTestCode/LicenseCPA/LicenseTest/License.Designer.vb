<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class License
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(License))
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCompanyKey = New System.Windows.Forms.Label()
        Me.lblRegKey = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtCompanyKey = New System.Windows.Forms.TextBox()
        Me.txtRegNumber = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtLicenseCode = New System.Windows.Forms.TextBox()
        Me.lblLicenseCode = New System.Windows.Forms.Label()
        Me.btnXor = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtXorMask = New System.Windows.Forms.TextBox()
        Me.btnStr2Hex = New System.Windows.Forms.Button()
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.txtHex = New System.Windows.Forms.TextBox()
        Me.btnHex2String = New System.Windows.Forms.Button()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInternalCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGenIntCode = New System.Windows.Forms.Button()
        Me.lblIntCodeHex = New System.Windows.Forms.Label()
        Me.txtIntCodeHEx = New System.Windows.Forms.TextBox()
        Me.txtCompanyKey2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRegKey2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGenEnhancedKey = New System.Windows.Forms.Button()
        Me.txtEnhancedKey = New System.Windows.Forms.TextBox()
        Me.txtEnhancedKeyCheck = New System.Windows.Forms.TextBox()
        Me.lblEnhancedKey = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(32, 42)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(67, 13)
        Me.lblCompanyName.TabIndex = 0
        Me.lblCompanyName.Text = "Bedrijfsnaam"
        '
        'lblCompanyKey
        '
        Me.lblCompanyKey.AutoSize = True
        Me.lblCompanyKey.Location = New System.Drawing.Point(32, 68)
        Me.lblCompanyKey.Name = "lblCompanyKey"
        Me.lblCompanyKey.Size = New System.Drawing.Size(39, 13)
        Me.lblCompanyKey.TabIndex = 1
        Me.lblCompanyKey.Text = "Sleutel"
        '
        'lblRegKey
        '
        Me.lblRegKey.AutoSize = True
        Me.lblRegKey.Location = New System.Drawing.Point(32, 174)
        Me.lblRegKey.Name = "lblRegKey"
        Me.lblRegKey.Size = New System.Drawing.Size(99, 13)
        Me.lblRegKey.TabIndex = 2
        Me.lblRegKey.Text = "Registratie Nummer"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(158, 39)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(267, 20)
        Me.txtCompanyName.TabIndex = 4
        '
        'txtCompanyKey
        '
        Me.txtCompanyKey.Location = New System.Drawing.Point(158, 65)
        Me.txtCompanyKey.Name = "txtCompanyKey"
        Me.txtCompanyKey.ReadOnly = True
        Me.txtCompanyKey.Size = New System.Drawing.Size(267, 20)
        Me.txtCompanyKey.TabIndex = 5
        '
        'txtRegNumber
        '
        Me.txtRegNumber.Location = New System.Drawing.Point(158, 171)
        Me.txtRegNumber.Name = "txtRegNumber"
        Me.txtRegNumber.Size = New System.Drawing.Size(267, 20)
        Me.txtRegNumber.TabIndex = 6
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(158, 106)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "Registreer"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtLicenseCode
        '
        Me.txtLicenseCode.Location = New System.Drawing.Point(158, 249)
        Me.txtLicenseCode.Name = "txtLicenseCode"
        Me.txtLicenseCode.Size = New System.Drawing.Size(267, 20)
        Me.txtLicenseCode.TabIndex = 10
        '
        'lblLicenseCode
        '
        Me.lblLicenseCode.AutoSize = True
        Me.lblLicenseCode.Location = New System.Drawing.Point(35, 255)
        Me.lblLicenseCode.Name = "lblLicenseCode"
        Me.lblLicenseCode.Size = New System.Drawing.Size(69, 13)
        Me.lblLicenseCode.TabIndex = 11
        Me.lblLicenseCode.Text = "LicenseCode"
        '
        'btnXor
        '
        Me.btnXor.Location = New System.Drawing.Point(158, 306)
        Me.btnXor.Name = "btnXor"
        Me.btnXor.Size = New System.Drawing.Size(267, 23)
        Me.btnXor.TabIndex = 14
        Me.btnXor.Text = "Check Registratie Nummer geef Info "
        Me.btnXor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label1.Location = New System.Drawing.Point(35, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Sleutel"
        '
        'txtXorMask
        '
        Me.txtXorMask.Location = New System.Drawing.Point(158, 206)
        Me.txtXorMask.Name = "txtXorMask"
        Me.txtXorMask.Size = New System.Drawing.Size(267, 20)
        Me.txtXorMask.TabIndex = 16
        '
        'btnStr2Hex
        '
        Me.btnStr2Hex.Enabled = False
        Me.btnStr2Hex.Location = New System.Drawing.Point(38, 380)
        Me.btnStr2Hex.Name = "btnStr2Hex"
        Me.btnStr2Hex.Size = New System.Drawing.Size(75, 23)
        Me.btnStr2Hex.TabIndex = 17
        Me.btnStr2Hex.Text = "String2Hex"
        Me.btnStr2Hex.UseVisualStyleBackColor = True
        Me.btnStr2Hex.Visible = False
        '
        'txtString
        '
        Me.txtString.Enabled = False
        Me.txtString.Location = New System.Drawing.Point(158, 380)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(267, 20)
        Me.txtString.TabIndex = 18
        Me.txtString.Visible = False
        '
        'txtHex
        '
        Me.txtHex.Enabled = False
        Me.txtHex.Location = New System.Drawing.Point(158, 422)
        Me.txtHex.Name = "txtHex"
        Me.txtHex.Size = New System.Drawing.Size(267, 20)
        Me.txtHex.TabIndex = 19
        Me.txtHex.Visible = False
        '
        'btnHex2String
        '
        Me.btnHex2String.Enabled = False
        Me.btnHex2String.Location = New System.Drawing.Point(38, 420)
        Me.btnHex2String.Name = "btnHex2String"
        Me.btnHex2String.Size = New System.Drawing.Size(75, 23)
        Me.btnHex2String.TabIndex = 20
        Me.btnHex2String.Text = "Hex 2 string"
        Me.btnHex2String.UseVisualStyleBackColor = True
        Me.btnHex2String.Visible = False
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.Location = New System.Drawing.Point(582, 42)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(33, 13)
        Me.lblPrefix.TabIndex = 21
        Me.lblPrefix.Text = "Prefix"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(666, 42)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.ReadOnly = True
        Me.txtPrefix.Size = New System.Drawing.Size(155, 20)
        Me.txtPrefix.TabIndex = 22
        Me.txtPrefix.Text = "full"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(583, 94)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(58, 13)
        Me.lblYear.TabIndex = 23
        Me.lblYear.Text = "Jaar 20(xx)"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(666, 94)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(155, 20)
        Me.txtYear.TabIndex = 24
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(666, 145)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(155, 20)
        Me.txtMonth.TabIndex = 25
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(666, 199)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(155, 20)
        Me.txtDay.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Maand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(582, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Dag"
        '
        'txtInternalCode
        '
        Me.txtInternalCode.Location = New System.Drawing.Point(666, 354)
        Me.txtInternalCode.Name = "txtInternalCode"
        Me.txtInternalCode.Size = New System.Drawing.Size(237, 20)
        Me.txtInternalCode.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(585, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "interne Code"
        '
        'btnGenIntCode
        '
        Me.btnGenIntCode.Location = New System.Drawing.Point(666, 292)
        Me.btnGenIntCode.Name = "btnGenIntCode"
        Me.btnGenIntCode.Size = New System.Drawing.Size(237, 23)
        Me.btnGenIntCode.TabIndex = 31
        Me.btnGenIntCode.Text = "Genereer Registratie Nummer"
        Me.btnGenIntCode.UseVisualStyleBackColor = True
        '
        'lblIntCodeHex
        '
        Me.lblIntCodeHex.AutoSize = True
        Me.lblIntCodeHex.Location = New System.Drawing.Point(566, 390)
        Me.lblIntCodeHex.Name = "lblIntCodeHex"
        Me.lblIntCodeHex.Size = New System.Drawing.Size(86, 13)
        Me.lblIntCodeHex.TabIndex = 32
        Me.lblIntCodeHex.Text = "interne code hex"
        '
        'txtIntCodeHEx
        '
        Me.txtIntCodeHEx.Location = New System.Drawing.Point(666, 390)
        Me.txtIntCodeHEx.Name = "txtIntCodeHEx"
        Me.txtIntCodeHEx.Size = New System.Drawing.Size(237, 20)
        Me.txtIntCodeHEx.TabIndex = 33
        '
        'txtCompanyKey2
        '
        Me.txtCompanyKey2.Location = New System.Drawing.Point(666, 248)
        Me.txtCompanyKey2.Name = "txtCompanyKey2"
        Me.txtCompanyKey2.Size = New System.Drawing.Size(237, 20)
        Me.txtCompanyKey2.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(583, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Sleutel"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(561, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Registratie Nummer"
        '
        'txtRegKey2
        '
        Me.txtRegKey2.Location = New System.Drawing.Point(666, 426)
        Me.txtRegKey2.Name = "txtRegKey2"
        Me.txtRegKey2.Size = New System.Drawing.Size(237, 20)
        Me.txtRegKey2.TabIndex = 37
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(666, 459)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(238, 153)
        Me.TextBox1.TabIndex = 38
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'btnGenEnhancedKey
        '
        Me.btnGenEnhancedKey.Location = New System.Drawing.Point(1064, 292)
        Me.btnGenEnhancedKey.Name = "btnGenEnhancedKey"
        Me.btnGenEnhancedKey.Size = New System.Drawing.Size(237, 23)
        Me.btnGenEnhancedKey.TabIndex = 39
        Me.btnGenEnhancedKey.Text = "Genereer Enhanced Reg Key"
        Me.btnGenEnhancedKey.UseVisualStyleBackColor = True
        '
        'txtEnhancedKey
        '
        Me.txtEnhancedKey.Location = New System.Drawing.Point(1064, 354)
        Me.txtEnhancedKey.Name = "txtEnhancedKey"
        Me.txtEnhancedKey.Size = New System.Drawing.Size(237, 20)
        Me.txtEnhancedKey.TabIndex = 40
        '
        'txtEnhancedKeyCheck
        '
        Me.txtEnhancedKeyCheck.Location = New System.Drawing.Point(1064, 426)
        Me.txtEnhancedKeyCheck.Name = "txtEnhancedKeyCheck"
        Me.txtEnhancedKeyCheck.Size = New System.Drawing.Size(237, 20)
        Me.txtEnhancedKeyCheck.TabIndex = 41
        '
        'lblEnhancedKey
        '
        Me.lblEnhancedKey.AutoSize = True
        Me.lblEnhancedKey.Location = New System.Drawing.Point(970, 361)
        Me.lblEnhancedKey.Name = "lblEnhancedKey"
        Me.lblEnhancedKey.Size = New System.Drawing.Size(80, 13)
        Me.lblEnhancedKey.TabIndex = 42
        Me.lblEnhancedKey.Text = "Enhanced Key "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(970, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Check E Key"
        '
        'License
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1361, 662)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblEnhancedKey)
        Me.Controls.Add(Me.txtEnhancedKeyCheck)
        Me.Controls.Add(Me.txtEnhancedKey)
        Me.Controls.Add(Me.btnGenEnhancedKey)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtRegKey2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCompanyKey2)
        Me.Controls.Add(Me.txtIntCodeHEx)
        Me.Controls.Add(Me.lblIntCodeHex)
        Me.Controls.Add(Me.btnGenIntCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInternalCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.btnHex2String)
        Me.Controls.Add(Me.txtHex)
        Me.Controls.Add(Me.txtString)
        Me.Controls.Add(Me.btnStr2Hex)
        Me.Controls.Add(Me.txtXorMask)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnXor)
        Me.Controls.Add(Me.lblLicenseCode)
        Me.Controls.Add(Me.txtLicenseCode)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtRegNumber)
        Me.Controls.Add(Me.txtCompanyKey)
        Me.Controls.Add(Me.txtCompanyName)
        Me.Controls.Add(Me.lblRegKey)
        Me.Controls.Add(Me.lblCompanyKey)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Name = "License"
        Me.Text = "Registratie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCompanyName As System.Windows.Forms.Label
    Friend WithEvents lblCompanyKey As System.Windows.Forms.Label
    Friend WithEvents lblRegKey As System.Windows.Forms.Label
    Friend WithEvents txtCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyKey As System.Windows.Forms.TextBox
    Friend WithEvents txtRegNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtLicenseCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLicenseCode As System.Windows.Forms.Label
    Friend WithEvents btnXor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtXorMask As System.Windows.Forms.TextBox
    Friend WithEvents btnStr2Hex As System.Windows.Forms.Button
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents txtHex As System.Windows.Forms.TextBox
    Friend WithEvents btnHex2String As System.Windows.Forms.Button
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInternalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGenIntCode As System.Windows.Forms.Button
    Friend WithEvents lblIntCodeHex As System.Windows.Forms.Label
    Friend WithEvents txtIntCodeHEx As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyKey2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRegKey2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGenEnhancedKey As System.Windows.Forms.Button
    Friend WithEvents txtEnhancedKey As System.Windows.Forms.TextBox
    Friend WithEvents txtEnhancedKeyCheck As System.Windows.Forms.TextBox
    Friend WithEvents lblEnhancedKey As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
