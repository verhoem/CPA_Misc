Imports System.Management
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO


Public Class License
    Dim objConnection As New SqlConnection _
        ("server=localhost\SQLEXPRESSEXT;database=License;user id=sa;password=redhat8;")

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim strTmpCompanyName As String = RTrim(txtCompanyName.Text)
        If strTmpCompanyName.Length < 4 Then
            MessageBox.Show("Bedrijfsnaam maag niet leeg zijn en moet minimaal 4 karakters bevatten")
            Exit Sub
        End If
        Dim strTmpCompanyKey As String
        Dim drive As String = "C"
        Dim disk As System.Management.ManagementObject = _
               New System.Management.ManagementObject _
               ("win32_logicaldisk.deviceid=""" + drive + ":""")
        disk.Get()
        Dim SerialNumber As String = disk("VolumeSerialNumber").ToString()
        strTmpCompanyKey = SerialNumber & txtCompanyName.Text.ToLower
        txtCompanyKey.Text = MD5CalcString(strTmpCompanyKey)
        'write CompanyName to db)
        Dim objCommand As SqlCommand = New SqlCommand()
        objCommand.Connection = objConnection
        objCommand.CommandText = "UPDATE LicenseInfo " & _
            "SET [CompanyName] = @CompanyName "
        objCommand.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text)
        objConnection.Open()
        objCommand.ExecuteNonQuery()
        objConnection.Close()
        objCommand.Parameters.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    ' calculate the MD5 hash of a given string 
    ' the string is first converted to a byte array
    Public Function MD5CalcString(ByVal strData As String) As String

        Dim objMD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim arrData() As Byte
        Dim arrHash() As Byte

        ' first convert the string to bytes (using UTF8 encoding for unicode characters)
        arrData = System.Text.Encoding.UTF8.GetBytes(strData)

        ' hash contents of this byte array
        arrHash = objMD5.ComputeHash(arrData)

        ' thanks objects
        objMD5 = Nothing

        ' return formatted hash
        Return ByteArrayToKey(arrHash)

    End Function
    ' utility function to convert a byte array into a hex string
    Private Function ByteArrayToKey(ByVal arrInput() As Byte) As String
        Dim strTmpKey As String
        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)
        'format key with "-"
        For i As Integer = 0 To arrInput.Length - 1
            strOutput.Append(arrInput(i).ToString("X2"))
            If i = 1 Then
                strOutput.Append("-")
            End If
            If i = 3 Then
                strOutput.Append("-")
            End If
            If i = 5 Then
                strOutput.Append("-")
            End If
        Next
        'MessageBox.Show("array length = " & arrInput.Length.ToString)
        strTmpKey = strOutput.ToString().ToLower.Substring(0, 19)
        Return strTmpKey
    End Function


    Private Sub License_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objDataAdapter As New SqlDataAdapter()
        objDataAdapter.SelectCommand = New SqlCommand()
        objDataAdapter.SelectCommand.Connection = objConnection
        objDataAdapter.SelectCommand.CommandText = _
            "SELECT [CompanyName], [RegKey] FROM LicenseInfo"
        Dim objDataSet As DataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "general")
        txtCompanyName.Text = objDataSet.Tables(0).Rows(0).Item(0).ToString
        Dim strTmpCompanyName As String = RTrim(txtCompanyName.Text)
        Dim strTmpCompanyKey As String
        Dim drive As String = "C"
        Dim disk As System.Management.ManagementObject = _
               New System.Management.ManagementObject _
               ("win32_logicaldisk.deviceid=""" + drive + ":""")
        disk.Get()
        Dim SerialNumber As String = disk("VolumeSerialNumber").ToString()
        strTmpCompanyKey = SerialNumber & txtCompanyName.Text.ToLower
        txtCompanyKey.Text = MD5CalcString(strTmpCompanyKey)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGenereerRegistratienummer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtLicenseCode.Text.Length <> 8 Then
            MessageBox.Show("License COde moet 8 chars zijn !")
        End If
    End Sub
    Private Function XorString(ByVal targetString As String, ByVal maskValue As String) As String
        Dim Index As Integer = 0
        Dim ReturnValue As String = ""
        For Each CharValue As Char In targetString.ToCharArray
            ReturnValue = String.Concat(ReturnValue, Chr(Asc(CharValue) Xor Asc(maskValue.Substring(Index, 1))))
            Index = (Index + 1) Mod maskValue.Length
        Next
        Return ReturnValue
    End Function
    Private Function XorHexString(ByVal targetString As String, ByVal maskValue As String) As String
        Dim str1, str2 As String
        Dim chr1, chr2 As String
        Dim strOutput As String = ""
        Dim int1, int2 As Int16
        Dim intXorValue As Int16
        str1 = targetString.ToLower
        str2 = maskValue.ToLower
        Dim Index As Integer = 0
        For i = 0 To targetString.Length - 1
            chr1 = str1.Substring(i, 1)
            chr2 = str2.Substring(i, 1)
            'MessageBox.Show("chr1 , chr2 : " & chr1 & " , " & chr2)
            int1 = Convert.ToInt16(chr1, 16)
            int2 = Convert.ToInt16(chr2, 16)
            'MessageBox.Show("Decimal chr1 , chr2 " & int1.ToString & " , " & int2.ToString)
            intXorValue = int1 Xor int2
            strOutput = strOutput & intXorValue.ToString("X").ToLower
            'MessageBox.Show("XorValue = " & intXorValue.ToString("X"))
        Next
        Return strOutput
    End Function

    Private Sub btnXor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXor.Click
        Dim str1, str2 As String
        Dim bolTmp As Boolean
        str1 = funcDelMinusHexstring(txtRegNumber.Text)
        str2 = funcDelMinusHexstring(txtXorMask.Text)
        txtLicenseCode.Text = XorHexString(str1, str2)
        bolTmp = funcChkLicenseCode(txtLicenseCode.Text)
    End Sub
    Private Function funcConvertStringToHex(ByVal strInput As String) As String
        Dim arrData() As Byte
        'MessageBox.Show("Input string:" & strInput)
        arrData = System.Text.Encoding.UTF8.GetBytes(strInput)
        'MessageBox.Show("Length arrdata " & arrData.Length.ToString)
        Dim strOutput As New System.Text.StringBuilder(arrData.Length)
        For i As Integer = 0 To arrData.Length - 1
            strOutput.Append(arrData(i).ToString("X2"))
        Next
        Return strOutput.ToString().ToLower
    End Function
    Private Function funcConvertHexToString(ByVal strInputHex As String) As String
        Dim HexChar As String
        Dim AsciChar As String
        Dim itmp As Integer
        Dim strOutput As String = ""
        For y = 1 To Len(strInputHex)
            HexChar = Mid(strInputHex, y, 2)
            itmp = Convert.ToInt16(HexChar, 16)
            AsciChar = Char.ConvertFromUtf32(itmp)
            'MessageBox.Show(HexChar & " = " & AsciChar)
            'Value = Value & Chr(Val("&h" & num))
            y = y + 1
            strOutput = strOutput & AsciChar
        Next y
        Return strOutput
    End Function

    Private Sub btnStr2Hex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStr2Hex.Click
        txtHex.Text = funcConvertStringToHex(txtString.Text)
    End Sub

    Private Sub btnHex2String_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHex2String.Click
        txtString.Text = funcConvertHexToString(txtHex.Text)
    End Sub

    Private Sub btnGenIntCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenIntCode.Click
        Dim strInternalCode As String
        Dim strTmp As String
        Dim strCRC As String
        Dim itmp As Integer
        itmp = CInt(txtYear.Text)
        'MessageBox.Show(" itmp Year  = " & itmp.ToString)
        strTmp = Char.ConvertFromUtf32(itmp)
        strInternalCode = txtPrefix.Text & strTmp
        itmp = CInt(txtMonth.Text)
        'MessageBox.Show(" itmp Month  = " & itmp.ToString)
        strTmp = Char.ConvertFromUtf32(itmp)
        strInternalCode = strInternalCode & strTmp
        itmp = CInt(txtDay.Text)
        'MessageBox.Show(" itmp Day  = " & itmp.ToString)
        strTmp = Char.ConvertFromUtf32(itmp)
        strInternalCode = strInternalCode & strTmp
        'strCRC = MD5CalcString(strInternalCode).Substring(0, 2)
        'MessageBox.Show("CRC code " & strCRC)
        txtInternalCode.Text = strInternalCode
        'MessageBox.Show("so far so good ? lenght txtInternal " & txtInternalCode.Text.Length)
        strCRC = MD5CalcString(funcConvertStringToHex(strInternalCode)).Substring(0, 2)
        txtIntCodeHEx.Text = funcConvertStringToHex(txtInternalCode.Text) & strCRC
        txtRegKey2.Text = funcAddMinusHexstring(XorHexString(txtIntCodeHEx.Text, funcDelMinusHexstring(txtCompanyKey2.Text)))
    End Sub
    Private Function funcAddMinusHexstring(ByVal strInput As String) As String
        Dim strTmp As String
        strTmp = strInput.Substring(0, 4) & "-" & strInput.Substring(4, 4) & "-" & strInput.Substring(8, 4) & "-" & strInput.Substring(12, 4)
        Return strTmp
    End Function
    Private Function funcDelMinusHexstring(ByVal strInput As String) As String
        Dim strTmp As String
        strTmp = strInput.Substring(0, 4) & strInput.Substring(5, 4) & strInput.Substring(10, 4) & strInput.Substring(15, 4)
        Return strTmp
    End Function
    Private Function funcChkLicenseCode(ByVal strInput As String) As Boolean
        Dim strLicType As String
        Dim strLicYear As String
        Dim strLicMonth As String
        Dim strLicDay As String
        Dim strLicCRC As String
        Dim strLicCalcCRC As String
        Dim intLicYear As Int16
        Dim intLicMonth As Int16
        Dim intLicDay As Int16
        'ckkformat
        If strInput.Length <> 16 Then
            MessageBox.Show("Licence code lenght not right !")
            Return False
        End If
        'chk prefix
        strLicType = funcConvertHexToString(strInput.Substring(0, 8))
        If String.Compare(strLicType, "full") <> 0 Then
            MessageBox.Show("Licence type " & strLicType & " not supported")
            'Return False
        End If
        'chk year
        strLicYear = strInput.Substring(8, 2)
        intLicYear = Convert.ToInt16(strLicYear, 16)
        If (intLicYear < 0 Or intLicYear > 25) Then
            MessageBox.Show("Value Year outside scope " & intLicYear.ToString)
            'Return False
        End If
        'chk mount
        strLicMonth = strInput.Substring(10, 2)
        intLicMonth = Convert.ToInt16(strLicMonth, 16)
        If (intLicMonth < 0 Or intLicMonth > 12) Then
            MessageBox.Show("Value month outside scope " & intLicMonth.ToString)
            'Return False
        End If
        'chk day
        strLicDay = strInput.Substring(12, 2)
        intLicDay = Convert.ToInt16(strLicDay, 16)
        If (intLicDay < 0 Or intLicDay > 31) Then
            MessageBox.Show("Value day outside scope " & intLicDay.ToString)
            'Return False
        End If
        'chk CRC
        'Calculate CRC
        strLicCalcCRC = MD5CalcString(strInput.Substring(0, 14)).Substring(0, 2)
        MessageBox.Show("Input crc calc: " & strInput.Substring(0, 14))
        strLicCRC = strInput.Substring(14, 2)
        If String.Compare(strLicCRC, strLicCalcCRC) <> 0 Then
            MessageBox.Show("ERROR CRC input, calculated " & strLicCRC & " , " & strLicCalcCRC)
            'Return False
        End If
        MessageBox.Show("License code Type, Year, Month, Day, CRC " & strLicType & " " & intLicYear.ToString _
        & " " & intLicMonth.ToString & " " & intLicDay.ToString & " " & strLicCRC)
        Return True
    End Function

    Private Sub btnGenEnhancedKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenEnhancedKey.Click
        txtEnhancedKey.Text = Form1.funcRegKey2EnhancedKey(txtRegKey2.Text)
        txtEnhancedKeyCheck.Text = Form1.funcEnhancedKey2RegKey(txtEnhancedKey.Text)
    End Sub
End Class