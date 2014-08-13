Imports System.IO
Imports Microsoft.Win32

Public Class Form2
    Public f1 As Single
    Dim a1 = Environment.GetEnvironmentVariable("TEMP")
    Dim o1 As String
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SaveFileDialog1.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        Dim key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("HARDWARE") _
              .OpenSubKey("DESCRIPTION") _
              .OpenSubKey("SYSTEM") _
              .OpenSubKey("CENTRALPROCESSOR") _
              .OpenSubKey("0")
        If Environment.Is64BitOperatingSystem = True Then
            o1 = "64位元"
        Else
            o1 = "32位元"
        End If
        Dim a2 = Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS")
        TextBox5.Text = Environment.OSVersion.ToString
        TextBox1.Text = key.GetValue("ProcessorNameString").ToString
        TextBox2.Text = key.GetValue("~MHz").ToString
        TextBox4.Text = o1
        Label8.Text = a2
        LinkLabel1.Text = Str(Form1.f1) + "秒"
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Not TextBox3.Text = "" Then
            Dim a2 As New FileInfo(a1 + "\" + TextBox3.Text + ".txt")
            Dim a3 As StreamWriter = a2.CreateText
            a3.Write(TextBox3.Text + vbCrLf + TextBox5.Text + vbCrLf + TextBox1.Text + vbCrLf + TextBox4.Text + vbCrLf + TextBox2.Text + vbCrLf + LinkLabel1.Text)
            a3.Flush()
            a3.Close()

          
            Button1.Enabled = False


        Else
            MsgBox("請輸入暱稱")
            Return

        End If

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_Disposed(sender As Object, e As System.EventArgs) Handles SaveFileDialog1.Disposed

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim s1 As New FileInfo(SaveFileDialog1.FileName)
        Dim s2 As StreamWriter = s1.CreateText
        s2.WriteLine(Now)
        s2.WriteLine("暱稱:" + TextBox3.Text)
        s2.WriteLine("作業系統:" + TextBox5.Text)
        s2.WriteLine("系統位元:" + TextBox4.Text)
        s2.WriteLine("CPU描述:" + TextBox1.Text)
        s2.WriteLine("時脈:" + TextBox2.Text)
        s2.WriteLine("執行序數:" + Label8.Text)
        s2.WriteLine("秒數:" + LinkLabel1.Text)

        s2.Close()


    End Sub
End Class