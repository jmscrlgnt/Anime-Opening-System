Public Class AdminControlPanel


    Private Sub AdminControlPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateListBoxes()
    End Sub

    Private Sub UpdateListBoxes()
        UpdateListBox(VotingPage.selectedOptionsGroup1, ListBox1)
        UpdateListBox(VotingPage.selectedOptionsGroup2, ListBox2)
        UpdateListBox(VotingPage.selectedOptionsGroup3, ListBox3)
        UpdateListBox(VotingPage.selectedOptionsGroup4, ListBox4)
    End Sub





    Private Function GetMaxItem(selectedOptions As List(Of String)) As String
        Dim itemCounts As New Dictionary(Of String, Integer)

        For Each item As String In selectedOptions
            If itemCounts.ContainsKey(item) Then
                itemCounts(item) += 1
            Else
                itemCounts.Add(item, 1)
            End If
        Next

        Dim maxItem As String = ""
        Dim maxCount As Integer = 0

        For Each kvp As KeyValuePair(Of String, Integer) In itemCounts
            If kvp.Value > maxCount Then
                maxCount = kvp.Value
                maxItem = kvp.Key
            End If
        Next

        Return maxItem
    End Function

    Private Function CountVotes(item As String, selectedOptions As List(Of String)) As Integer
        Return selectedOptions.Where(Function(x) x = item).Count()
    End Function

    Private Sub CountAndDisplayVotes(selectedOptions As List(Of String), listBox As ListBox)
        Dim itemCounts As New Dictionary(Of String, Integer)

        For Each item As String In selectedOptions
            If itemCounts.ContainsKey(item) Then
                itemCounts(item) += 1
            Else
                itemCounts.Add(item, 1)
            End If
        Next

        listBox.Items.Clear()
        For Each kvp As KeyValuePair(Of String, Integer) In itemCounts
            listBox.Items.Add(kvp.Key & ": " & kvp.Value.ToString())
        Next
    End Sub

    Private Sub UpdateListBox(selectedOptions As List(Of String), listBox As ListBox)
        listBox.Items.Clear()
        For Each item As String In selectedOptions
            listBox.Items.Add(item)
        Next
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Dim loginForm As New LoginForm()
            loginForm.Show()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim maxItem1 As String = GetMaxItem(VotingPage.selectedOptionsGroup1)
        Dim maxItem2 As String = GetMaxItem(VotingPage.selectedOptionsGroup2)
        Dim maxItem3 As String = GetMaxItem(VotingPage.selectedOptionsGroup3)
        Dim maxItem4 As String = GetMaxItem(VotingPage.selectedOptionsGroup4)
        Dim maxItems As New List(Of String) From {maxItem1, maxItem2, maxItem3, maxItem4}
        Dim maxVotes As Integer = CountVotes(maxItems(0), VotingPage.selectedOptionsGroup1)
        Dim tie As Boolean = False
        Dim msgbox1 As String
        Dim msgbox2 As String
        Dim msgbox3 As String
        Dim msgbox4 As String

        For Each item As String In maxItems
            If CountVotes(item, VotingPage.selectedOptionsGroup1) = maxVotes AndAlso item <> maxItem1 Then
                msgbox1 = "Best Anime is: " & maxItem1 & " with " & CountVotes(maxItem1, VotingPage.selectedOptionsGroup1) & " votes."
            Else msgbox1 = "Tie." & vbNewLine
            End If

            If CountVotes(item, VotingPage.selectedOptionsGroup2) = maxVotes AndAlso item <> maxItem2 Then
                msgbox2 = "Best Anime Opening is: " & maxItem2 & " with " & CountVotes(maxItem2, VotingPage.selectedOptionsGroup2) & " votes."
            Else msgbox2 = "Tie." & vbNewLine
            End If

            If CountVotes(item, VotingPage.selectedOptionsGroup3) = maxVotes AndAlso item <> maxItem3 Then
                msgbox3 = "Best Romance Anime is: " & maxItem3 & " with " & CountVotes(maxItem3, VotingPage.selectedOptionsGroup3) & " votes."
            Else msgbox3 = "Tie." & vbNewLine

            End If

            If CountVotes(item, VotingPage.selectedOptionsGroup4) = maxVotes AndAlso item <> maxItem4 Then
                msgbox4 = "Best Action Anime is: " & maxItem4 & " with " & CountVotes(maxItem4, VotingPage.selectedOptionsGroup4) & " votes."
            Else msgbox4 = "Tie." & vbNewLine
            End If

        Next

        MessageBox.Show(msgbox1 & msgbox2 & msgbox3 & msgbox4)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        CountAndDisplayVotes(VotingPage.selectedOptionsGroup1, ListBox1)
        CountAndDisplayVotes(VotingPage.selectedOptionsGroup2, ListBox2)
        CountAndDisplayVotes(VotingPage.selectedOptionsGroup3, ListBox3)
        CountAndDisplayVotes(VotingPage.selectedOptionsGroup4, ListBox4)
    End Sub

    Private Sub BtnCount_Click(sender As Object, e As EventArgs)

    End Sub
End Class
