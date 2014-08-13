Public Class Form3
    Public f1 As Single
    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        LinkLabel1.Text = "你的分數是:" + " " + Str(Form1.f1) + "秒"
        WebBrowser1.Navigate("http://funny-forum.no-ip.org/cpu102/try.html")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
End Class