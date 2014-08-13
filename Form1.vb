Imports System.IO

Public Class Form1
    Dim s1 As Integer = 0
    Public f1 As Single
    Dim k1 As Integer = 0


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Button1.Enabled = False
        Button1.Text = "開始跑分"
        BackgroundWorker1.RunWorkerAsync()
        BackgroundWorker2.RunWorkerAsync()
        BackgroundWorker3.RunWorkerAsync()
        BackgroundWorker4.RunWorkerAsync()
        BackgroundWorker5.RunWorkerAsync()
        BackgroundWorker6.RunWorkerAsync()
        BackgroundWorker7.RunWorkerAsync()
        BackgroundWorker8.RunWorkerAsync()
        BackgroundWorker9.RunWorkerAsync()
        BackgroundWorker10.RunWorkerAsync()
        BackgroundWorker11.RunWorkerAsync()
        BackgroundWorker12.RunWorkerAsync()
        BackgroundWorker13.RunWorkerAsync()
        BackgroundWorker14.RunWorkerAsync()
        BackgroundWorker15.RunWorkerAsync()
        BackgroundWorker16.RunWorkerAsync()
        BackgroundWorker17.RunWorkerAsync()
        BackgroundWorker18.RunWorkerAsync()
        BackgroundWorker19.RunWorkerAsync()
        BackgroundWorker20.RunWorkerAsync()




    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        
        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i



       



    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim sum As Integer = 0
        Dim starts, endds
        starts = DateAndTime.Timer
        Do
            If Not BackgroundWorker1.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker3.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker4.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker5.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker6.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker7.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker8.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker9.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker10.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker11.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker12.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker13.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker14.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker15.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker16.IsBusy Then
                Exit Do

            End If
        Loop
        Do
            If Not BackgroundWorker17.IsBusy Then
                Exit Do

            End If
        Loop

        endds = DateAndTime.Timer
        s1 = endds - starts
       
        f1 = s1
        k1 = 1
        MsgBox("跑分完成，可按顯示結果去看結果")













    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork

        Dim isum As Integer = 0


        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i




      


       


    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
       
        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i



      
      

    End Sub

    Private Sub BackgroundWorker5_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i
       
    End Sub

    Private Sub BackgroundWorker6_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i


    End Sub

    Private Sub BackgroundWorker7_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker7.DoWork
         Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i
    End Sub

    Private Sub BackgroundWorker8_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i


    End Sub

    Private Sub BackgroundWorker9_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker9.DoWork
        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i

    End Sub

    Private Sub BackgroundWorker10_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker10.DoWork
           Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i


    End Sub

    Private Sub BackgroundWorker11_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker11.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i

    End Sub

    Private Sub BackgroundWorker12_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker12.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i
    End Sub

    Private Sub BackgroundWorker13_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker13.DoWork
       
        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i



        

    End Sub

    Private Sub BackgroundWorker14_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker14.DoWork


        Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i



        
    End Sub

    Private Sub BackgroundWorker15_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker15.DoWork
          Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i
    End Sub

    Private Sub BackgroundWorker16_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker16.DoWork
           Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i

    End Sub

    Private Sub BackgroundWorker17_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker17.DoWork
           Dim x As Integer
        Dim pi As Single
        pi = 0
        For i = 1 To 900000000
            x = ((-1) ^ (i + 1)) * (2 * i - 1)
            pi = 1 / x + pi
        Next i

    End Sub

    Private Sub BackgroundWorker18_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker18.DoWork

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If k1 = 1 Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("請等待跑分完成")
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Form2.Show()
    End Sub
End Class
