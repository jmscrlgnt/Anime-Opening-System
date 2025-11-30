Imports System.Threading

Public Class AnimeOpening
    Public Property VideoFilePath As String

    Private Sub AnimeOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        AxWindowsMediaPlayer1.URL = VideoFilePath
        AxWindowsMediaPlayer1.Ctlcontrols.play()


        Dim t As New Thread(Sub()
                                Thread.Sleep(500)
                                Invoke(New Action(Sub() AxWindowsMediaPlayer1.fullScreen = False))
                            End Sub)
        t.Start()
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub
End Class
