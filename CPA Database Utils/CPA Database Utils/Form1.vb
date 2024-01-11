Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Form1
    Public strDbPasswd As String = "redhat8"
    Public strDbSrvString As String = "localhost\SQLEXPRESSEXT"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        subReadConfFile()
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        If TextBox1.Text.Length < 5 Then
            MessageBox.Show("Selecteer een valide backup van de CPA database !")
            Exit Sub
        End If
        If MessageBox.Show("Wilt U de huidige database overschrijven met " & TextBox1.Text, "Restore ?", MessageBoxButtons.OKCancel, _
                           MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        subRestoreDB(TextBox1.Text)
    End Sub
    Private Sub subRestoreDB(ByVal strFilename As String)
        Dim Cmd As New SqlCommand
        Dim DBconn As New SqlConnection _
                ("server=" & Me.strDbSrvString & ";database=MASTER;user id=sa;password=" & Me.strDbPasswd & ";")
        Cmd = New SqlCommand("restore database SPC from disk=@bckFile", DBconn)
        Cmd.Parameters.AddWithValue("@bckFile", strFilename)
        DBconn.Open()
        Cmd.ExecuteNonQuery()
        DBconn.Close()
        Cmd.Parameters.Clear()
        MessageBox.Show("CPA database overschreven met " & strFilename)
    End Sub
    Private Sub subReadConfFile()
        If My.Computer.FileSystem.FileExists("c:\spc\spc.conf") Then
            Dim str As String = My.Computer.FileSystem.ReadAllText("c:\spc\spc.conf")
            Dim strArr() As String
            Dim count As Integer
            Dim strTmp As String
            Label2.Text = ""
            '' Form1.subWriteLog(1, "spc configuratie bestand c:\spc\spc.conf gevonden")
            strArr = str.Split(vbNewLine)
            For count = 0 To strArr.Length - 1
                If strArr(count).Contains("CpaDBPasswd=") Then
                    strTmp = strArr(count).Replace("CpaDBPasswd=", "")
                    Label2.Text = "Pwd " & strTmp & Label2.Text
                    Me.strDbPasswd = strTmp
                End If
                If strArr(count).Contains("CpaDBSrvString=") Then
                    strTmp = strArr(count).Replace("CpaDBSrvString=", "")
                    Label2.Text = Label2.Text & " SrvString " & strTmp
                    Me.strDbSrvString = strTmp
                End If
            Next
        Else
            Label2.Text = "Geen configuratie bestand gevonden"
        End If
    End Sub
End Class
