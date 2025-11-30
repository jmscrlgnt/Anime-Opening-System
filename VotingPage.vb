Public Class VotingPage
    Public Shared selectedOptionsGroup1 As New List(Of String)
    Public Shared selectedOptionsGroup2 As New List(Of String)
    Public Shared selectedOptionsGroup3 As New List(Of String)
    Public Shared selectedOptionsGroup4 As New List(Of String)

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PctbxMashle.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Mashle.mp4"
        AnimeOpening.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PctbxJujutsu.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Jujutsu.mp4"
        AnimeOpening.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PctbxAOT.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\AOT.mp4"
        AnimeOpening.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PctbxChainsaw.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Chainsaw.mp4"
        AnimeOpening.Show()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PctbxMob.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Mob.mp4"
        AnimeOpening.Show()
    End Sub
    Private Sub PctbxAkame_Click(sender As Object, e As EventArgs) Handles PctbxAkame.Click
        Dim AnimeOpening As New AnimeOpening()
        AnimeOpening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Akame-Ga-Kill.mp4"
        AnimeOpening.Show()
    End Sub
    Private Sub pctbxJuliet_click(sender As Object, e As EventArgs) Handles PctbxSAO.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Sword-Art-Online.mp4"
        animeopening.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\＜オープニング映像フル＞TVアニメ「ONE PIECE」／オープニングテーマ「あーーっす！」歌：きただにひろし.mp4"
        animeopening.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Naruto Shippuden - Opening 16 Silhouette.mp4"
        animeopening.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\TVアニメ『BLEACH 千年血戦篇』ノンクレジットオープニングムービー／２０２２年１０月１０日テレビ東京系列ほかにて放送中.mp4"
        animeopening.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\TVアニメ「陰の実力者になりたくて！ 2nd season」 ノンクレジットオープニング：OxT「grayscale dominator」.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxHealer1_Click(sender As Object, e As EventArgs) Handles PctbxHealer1.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Kaifuku Jutsushi No Yarinaoshi (Redo of Healer) Opening.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxDBS_Click(sender As Object, e As EventArgs) Handles PctbxDBS.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\DBS.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxFMA_Click(sender As Object, e As EventArgs) Handles PctbxFMA.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\FMA.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxDanger_Click(sender As Object, e As EventArgs) Handles PctbxDanger.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Heart.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbxJuliet_Click_1(sender As Object, e As EventArgs) Handles pctbxJuliet.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Juliet.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxGolden_Click(sender As Object, e As EventArgs) Handles PctbxGolden.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Golden.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxApril_Click(sender As Object, e As EventArgs) Handles PctbxApril.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\April.mp4"
        animeopening.Show()
    End Sub

    Private Sub PxtboxHorimiya_Click(sender As Object, e As EventArgs) Handles PxtboxHorimiya.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Horimiya.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxWotakoi_Click(sender As Object, e As EventArgs) Handles PctbxWotakoi.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Wotakoi.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxDarling_Click(sender As Object, e As EventArgs) Handles PctbxDarling.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Darling.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxSlayer_Click(sender As Object, e As EventArgs) Handles PctbxSlayer.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Slayer.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbxFireForce_Click(sender As Object, e As EventArgs) Handles pctbxFireForce.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\FireForce.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbxFairy_Click(sender As Object, e As EventArgs) Handles pctbxFairy.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Fairy.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbcSDS_Click(sender As Object, e As EventArgs) Handles pctbcSDS.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\SDS.mp4"
        animeopening.Show()
    End Sub

    Private Sub PctbxInu_Click(sender As Object, e As EventArgs) Handles PctbxInu.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Inuyasha.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbxHxH_Click(sender As Object, e As EventArgs) Handles pctbxHxH.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\HXH.mp4"
        animeopening.Show()
    End Sub

    Private Sub pctbxDororo_Click(sender As Object, e As EventArgs) Handles pctbxDororo.Click
        Dim animeopening As New AnimeOpening()
        animeopening.VideoFilePath = "D:\Programs\WindowsApplication1\WindowsApplication1\Project Videos\Dororo.mp4"
        animeopening.Show()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Go Back?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim LoginForm As New LoginForm()
            LoginForm.Show()
        ElseIf result = DialogResult.No Then
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MessageBox.Show("Thank you for voting!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If RdbPiece.Checked Then
            selectedOptionsGroup1.Add(RdbPiece.Text)
        ElseIf RdbNaruto.Checked Then
            selectedOptionsGroup1.Add(RdbNaruto.Text)
        ElseIf RdbBleach.Checked Then
            selectedOptionsGroup1.Add(RdbBleach.Text)
        ElseIf RdbShadow.Checked Then
            selectedOptionsGroup1.Add(RdbShadow.Text)
        ElseIf RdbHealer.Checked Then
            selectedOptionsGroup1.Add(RdbHealer.Text)
        ElseIf RdbDbs.Checked Then
            selectedOptionsGroup1.Add(RdbDbs.Text)
        ElseIf RdbFMA.Checked Then
            selectedOptionsGroup1.Add(RdbFMA.Text)
        End If
        If RadioButtonMob.Checked Then
            selectedOptionsGroup2.Add(RadioButtonMob.Text)
        ElseIf RadioButtonChainsaw.Checked Then
            selectedOptionsGroup2.Add(RadioButtonChainsaw.Text)
        ElseIf RadioButtonAOT.Checked Then
            selectedOptionsGroup2.Add(RadioButtonAOT.Text)
        ElseIf RadioButtonJujutsu.Checked Then
            selectedOptionsGroup2.Add(RadioButtonJujutsu.Text)
        ElseIf RadioButtonMashle.Checked Then
            selectedOptionsGroup2.Add(RadioButtonMashle.Text)
        ElseIf RadioButtonAkame.Checked Then
            selectedOptionsGroup2.Add(RadioButtonAkame.Text)
        ElseIf RadioButtonSAO.Checked Then
            selectedOptionsGroup2.Add(RadioButtonSAO.Text)
        End If
        If RadioButtonDanger.Checked Then
            selectedOptionsGroup3.Add(RadioButtonDanger.Text)
        ElseIf RadioButtonJuliet.Checked Then
            selectedOptionsGroup3.Add(RadioButtonJuliet.Text)
        ElseIf RadioButtonGolden.Checked Then
            selectedOptionsGroup3.Add(RadioButtonGolden.Text)
        ElseIf RadioButtonApril.Checked Then
            selectedOptionsGroup3.Add(RadioButtonApril.Text)
        ElseIf RadioButtonHorimiya.Checked Then
            selectedOptionsGroup3.Add(RadioButtonHorimiya.Text)
        ElseIf RadioButtonWotakoi.Checked Then
            selectedOptionsGroup3.Add(RadioButtonWotakoi.Text)
        ElseIf RadioButtonDarling.Checked Then
            selectedOptionsGroup3.Add(RadioButtonDarling.Text)
        End If
        If RadioButtonSlayer.Checked Then
            selectedOptionsGroup4.Add(RadioButtonSlayer.Text)
        ElseIf RadioButtonFire.Checked Then
            selectedOptionsGroup4.Add(RadioButtonFire.Text)
        ElseIf RadioButtonTail.Checked Then
            selectedOptionsGroup4.Add(RadioButtonTail.Text)
        ElseIf RadioButtonSins.Checked Then
            selectedOptionsGroup4.Add(RadioButtonSins.Text)
        ElseIf Radiobuttoninu.Checked Then
            selectedOptionsGroup4.Add(Radiobuttoninu.Text)
        ElseIf RadioButtonHunter.Checked Then
            selectedOptionsGroup4.Add(RadioButtonHunter.Text)
        ElseIf RadioButtonDororo.Checked Then
            selectedOptionsGroup4.Add(RadioButtonDororo.Text)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButtonMob_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMob.CheckedChanged

    End Sub

    Private Sub RadioButtonChainsaw_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonChainsaw.CheckedChanged

    End Sub

    Private Sub RadioButtonAOT_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAOT.CheckedChanged

    End Sub

    Private Sub RadioButtonJujutsu_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonJujutsu.CheckedChanged

    End Sub

    Private Sub RadioButtonMashle_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMashle.CheckedChanged

    End Sub

End Class