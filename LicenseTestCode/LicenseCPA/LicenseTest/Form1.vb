Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        License.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim characterArray() As Char
        Dim iTmp As Integer
        characterArray = TextBox2.Text.ToCharArray()
        iTmp = funcChar2Int(characterArray(0))
        MessageBox.Show(iTmp.ToString)
    End Sub
    Public Function funcChar2Int(ByVal Character As Char) As Integer
        If Character = "0" Then Return 0
        If Character = "1" Then Return 1
        If Character = "2" Then Return 2
        If Character = "3" Then Return 3
        If Character = "4" Then Return 4
        If Character = "5" Then Return 5
        If Character = "6" Then Return 6
        If Character = "7" Then Return 7
        If Character = "8" Then Return 8
        If Character = "9" Then Return 9
        If Character = "a" Then Return 10
        If Character = "b" Then Return 11
        If Character = "c" Then Return 12
        If Character = "d" Then Return 13
        If Character = "e" Then Return 14
        If Character = "f" Then Return 15
        Return 15
    End Function
    Public Function funcInt2Char(ByVal iTmp As Integer) As Char
        If iTmp = 0 Then Return "0"(0)
        If iTmp = 1 Then Return "1"(0)
        If iTmp = 2 Then Return "2"(0)
        If iTmp = 3 Then Return "3"(0)
        If iTmp = 4 Then Return "4"(0)
        If iTmp = 5 Then Return "5"(0)
        If iTmp = 6 Then Return "6"(0)
        If iTmp = 7 Then Return "7"(0)
        If iTmp = 8 Then Return "8"(0)
        If iTmp = 9 Then Return "9"(0)
        If iTmp = 10 Then Return "a"(0)
        If iTmp = 11 Then Return "b"(0)
        If iTmp = 12 Then Return "c"(0)
        If iTmp = 13 Then Return "d"(0)
        If iTmp = 14 Then Return "e"(0)
        If iTmp = 15 Then Return "f"(0)
        Return "f"(0)
    End Function
    Public Function funcRegKey2EnhancedKey(ByVal KeyIn As String) As String
        ''Dim KeyOut As String = "ffff-ffff-ffff-ffff"
        Dim KeyOut() As Char
        KeyOut = "ffff-ffff-ffff-ffff".ToCharArray
        If KeyIn.Length = 19 Then
            Dim iDelta1 As Integer
            Dim iDelta2 As Integer
            Dim iTemp As Integer
            iDelta1 = funcChar2Int(KeyIn(17))
            iDelta2 = funcChar2Int(KeyIn(18))
            For i = 0 To 16 Step 2 ' adjust Delta1
                If i = 4 Then
                    MessageBox.Show("i=4")
                ElseIf i = 14 Then
                    MessageBox.Show("i=14")
                Else
                    'MessageBox.Show(i.ToString & " is not 4 or 14 ")
                    iTemp = funcChar2Int(KeyIn(i)) + iDelta1
                    If iTemp > 15 Then
                        iTemp = iTemp - 16
                    End If
                    KeyOut(i) = funcInt2Char(iTemp)
                End If
            Next
            For i = 1 To 15 Step 2 '' adjust Delta 2
                If i = 9 Then
                    MessageBox.Show("i=9")
                Else
                    'MessageBox.Show(i.ToString & " is not 9 ")
                    iTemp = funcChar2Int(KeyIn(i)) + iDelta2
                    If iTemp > 15 Then
                        iTemp = iTemp - 16
                    End If
                    KeyOut(i) = funcInt2Char(iTemp)
                End If
            Next
            KeyOut(17) = KeyIn(17)
            KeyOut(18) = KeyIn(18)
            Return KeyOut
        End If
        Return "ffff-ffff-ffff-ffff"
    End Function
    Public Function funcEnhancedKey2RegKey(ByVal KeyIn As String) As String
        ''Dim KeyOut As String = "ffff-ffff-ffff-ffff"
        Dim KeyOut() As Char
        KeyOut = "ffff-ffff-ffff-ffff".ToCharArray
        If KeyIn.Length = 19 Then
            Dim iDelta1 As Integer
            Dim iDelta2 As Integer
            Dim iTemp As Integer
            iDelta1 = funcChar2Int(KeyIn(17))
            iDelta2 = funcChar2Int(KeyIn(18))
            For i = 0 To 16 Step 2 ' adjust Delta1
                If i = 4 Then
                    MessageBox.Show("i=4")
                ElseIf i = 14 Then
                    MessageBox.Show("i=14")
                Else
                    'MessageBox.Show(i.ToString & " is not 4 or 14 ")
                    iTemp = funcChar2Int(KeyIn(i)) - iDelta1
                    If iTemp < 0 Then
                        iTemp = iTemp + 16
                    End If
                    KeyOut(i) = funcInt2Char(iTemp)
                End If
            Next
            For i = 1 To 15 Step 2 '' adjust Delta 2
                If i = 9 Then
                    MessageBox.Show("i=9")
                Else
                    'MessageBox.Show(i.ToString & " is not 9 ")
                    iTemp = funcChar2Int(KeyIn(i)) - iDelta2
                    If iTemp < 0 Then
                        iTemp = iTemp + 16
                    End If
                    KeyOut(i) = funcInt2Char(iTemp)
                End If
            Next
            KeyOut(17) = KeyIn(17)
            KeyOut(18) = KeyIn(18)
            Return KeyOut
        End If
        Return "ffff-ffff-ffff-ffff"
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim EnheancedKey As String
        Dim OldKey As String
        EnheancedKey = funcRegKey2EnhancedKey(TextBox2.Text)
        MessageBox.Show("Enhaced key = " & EnheancedKey)
        OldKey = funcEnhancedKey2RegKey(EnheancedKey)
        MessageBox.Show("OldKey = " & OldKey)
    End Sub
End Class
