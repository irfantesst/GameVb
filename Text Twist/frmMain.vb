Public Class frmMain

#Region "Declarations"

    Dim DicAll As ArrayList
    Dim Dic5L As ArrayList
    Dim Dic6L As ArrayList
    Dim Dic7L As ArrayList

    Dim PossibleWords As ArrayList
    Dim PossibleWordsCounter As Integer
    Dim ChoosenWord As String

    Dim Difficulty As Integer
    Dim FirstRun As Boolean
    Dim NowPlaying As Boolean

    Dim GameTimerSec As Integer
    Dim GameTimer As Integer

#End Region

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim ans As Microsoft.VisualBasic.MsgBoxResult

        If NowPlaying = True Or btn_Proceed.Enabled = True Then
            ans = MsgBox("Apakah kamu benar-benar ingin keluar dari game ini ?", MsgBoxStyle.YesNo)
            If ans = MsgBoxResult.No Then e.Cancel = True
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FirstRun = True
        btn_Proceed.Enabled = False
        lbl_Notes.Text = ""
    End Sub

    Private Sub mnu_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_About.Click
        AboutTextTwist.ShowDialog()
    End Sub

    Private Sub mnu_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Exit.Click
        Dim ans As Microsoft.VisualBasic.MsgBoxResult

        If NowPlaying = True Or btn_Proceed.Enabled = True Then
            ans = MsgBox("Apakah kamu ingin keluar dari game?", MsgBoxStyle.YesNo)
            If ans = MsgBoxResult.No Then Exit Sub
        End If

        End
    End Sub

    Private Sub mnu_Beginner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Beginner.Click
        mnu_Beginner.Checked = True
        mnu_Medium.Checked = False
        mnu_Expert.Checked = False
        If NowPlaying = True Then
            MsgBox("Kamu harus keluar game untuk mengganti kata ! ", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub mnu_Medium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Medium.Click
        mnu_Beginner.Checked = False
        mnu_Medium.Checked = True
        mnu_Expert.Checked = False
        If NowPlaying = True Then
            MsgBox("Kamu harus memulai game baru untuk mengganti kata !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub mnu_Expert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Expert.Click
        mnu_Beginner.Checked = False
        mnu_Medium.Checked = False
        mnu_Expert.Checked = True
        If NowPlaying = True Then
            MsgBox("You should play a new game in order to affect this change", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub mnu_NewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_NewGame.Click
        Dim ans As Microsoft.VisualBasic.MsgBoxResult

        If NowPlaying = True Or btn_Proceed.Enabled = True Then
            ans = MsgBox("Apakah kamu ingin mengakhiri game dan memulai game baru?", MsgBoxStyle.YesNo)
            If ans = MsgBoxResult.No Then Exit Sub
        End If

        If mnu_Beginner.Checked = True Then
            Difficulty = 1 'Beginner
            Button6.Visible = False
            Button7.Visible = False
        ElseIf mnu_Medium.Checked = True Then
            Difficulty = 2 'Medium
            Button6.Visible = True
            Button7.Visible = False
        Else
            Difficulty = 3 'Expert
            Button6.Visible = True
            Button7.Visible = True
        End If

        GameTimer = 240
        NewGame()
    End Sub

    Private Sub btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Submit.Click
        If NowPlaying = False Or FirstRun = True Then
            Exit Sub
        End If

        Dim str As String
        Dim i As Integer
        Dim Okay As Boolean

        str = txt_UserSubmit.Text

        If str.Length < 3 Then
            lbl_Notes.Text = "Kata harus terdiri dari minimal 3 kata"
            My.Computer.Audio.Play(My.Resources.Below3L, AudioPlayMode.Background)
            Clear()
            Exit Sub
        End If

        For i = 0 To listbox_CorrectWords.Items.Count - 1
            If StrComp(listbox_CorrectWords.Items(i), str, CompareMethod.Text) = 0 Then
                lbl_Notes.Text = "Kamu sudah memasukkan kata ini (" & str & ")"
                My.Computer.Audio.Play(My.Resources.WrongWord, AudioPlayMode.Background)
                Clear()
                Exit Sub
            End If
        Next i

        Okay = False
        For i = 0 To PossibleWords.Count - 1
            If StrComp(str, PossibleWords.Item(i).ToString, CompareMethod.Text) = 0 Then
                Okay = True
                Exit For
            End If
        Next i

        If Okay = True Then
            If str.Length = 4 + Difficulty Then
                lbl_Notes.Text = "Bagus (" & str & ")"
                My.Computer.Audio.Play(My.Resources.Excellent, AudioPlayMode.Background)
                btn_Proceed.Enabled = True
            Else
                lbl_Notes.Text = "Kata yang dimasukan benar (" & str & ")"
                My.Computer.Audio.Play(My.Resources.CorrectWord, AudioPlayMode.Background)
            End If
            listbox_CorrectWords.Items.Add(str)
            If listbox_CorrectWords.Items.Count = PossibleWords.Count Then
                lbl_Notes.Text = "Sempurna, kamu sudah memasukkan semua kata yang ada ! ! !"
                My.Computer.Audio.Play(My.Resources.Yahoo, AudioPlayMode.Background)
                NowPlaying = False
                TimerGame.Enabled = False
                PossibleWordsCounter = PossibleWordsCounter - 1
                lbl_CorrectWords.Text = "Daftar kata yang benar (" & CStr(PossibleWordsCounter) & "):"
                Exit Sub
            End If
            PossibleWordsCounter = PossibleWordsCounter - 1
            lbl_CorrectWords.Text = "Daftar Kata yang benar (" & CStr(PossibleWordsCounter) & "):"
        Else
            lbl_Notes.Text = "Maaf kata yang kamu masukan tidak terdaftar dalam program ! ! ! (" & str & ")"
            My.Computer.Audio.Play(My.Resources.WrongWord, AudioPlayMode.Background)
        End If

        Clear()
    End Sub

    Private Sub btn_Twist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Twist.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.Twist, AudioPlayMode.Background)
            Clear()
            Twist()
        End If
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        If NowPlaying = True And FirstRun = False Then
            Clear()
        End If
    End Sub

    Private Sub TimerGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGame.Tick
        Dim i As Integer

        GameTimerSec = GameTimerSec - 1
        lbl_Timer.Text = CStr(GameTimerSec)

        If GameTimerSec = 10 Or GameTimerSec = 5 Then
            My.Computer.Audio.Play(My.Resources.Timer, AudioPlayMode.Background)
        ElseIf GameTimerSec = 0 Then
            NowPlaying = False
            If btn_Proceed.Enabled = True Then
                lbl_Notes.Text = "Kamu berhasil menyelesaikan level,silahkan ke level selanjutnya"
            Else
                lbl_Notes.Text = "Game Over, Time is up"
                My.Computer.Audio.Play(My.Resources.GameOver, AudioPlayMode.Background)
            End If

            listbox_CorrectWords.Items.Clear()
            For i = 0 To PossibleWords.Count - 1
                listbox_CorrectWords.Items.Add(PossibleWords(i))
            Next i

            NowPlaying = False
            TimerGame.Enabled = False
        End If
    End Sub

    Private Sub btn_Proceed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Proceed.Click
        GameTimer = GameTimer - 25
        If GameTimer <= 10 Then GameTimer = 10
        NewGame()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button1.Text
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button2.Text
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button3.Text
            Button3.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button4.Text
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button5.Text
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button6.Text
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If NowPlaying = True And FirstRun = False Then
            My.Computer.Audio.Play(My.Resources.LetterPress, AudioPlayMode.Background)
            txt_UserSubmit.Text = txt_UserSubmit.Text & Button7.Text
            Button7.Enabled = False
        End If
    End Sub

    Private Sub lbl_Notes_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_Notes.MouseDoubleClick
        If ListBox1.Visible = False Then
            ListBox1.Visible = True
        Else
            ListBox1.Visible = False
        End If
    End Sub

#Region "Functions"

    Public Sub Startup()
        NowPlaying = False

        Dim line As String

        Dim MyReaderDicAll As System.IO.StreamReader
        Dim MyReaderDic5L As System.IO.StreamReader
        Dim MyReaderDic6L As System.IO.StreamReader
        Dim MyReaderDic7L As System.IO.StreamReader

        MyReaderDicAll = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath & "\Dic\DicAll.txt")
        MyReaderDic5L = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath & "\Dic\Dic5L.txt")
        MyReaderDic6L = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath & "\Dic\Dic6L.txt")
        MyReaderDic7L = My.Computer.FileSystem.OpenTextFileReader(My.Application.Info.DirectoryPath & "\Dic\Dic7L.txt")

        Dim infoAll As System.IO.FileInfo
        Dim info5L As System.IO.FileInfo
        Dim info6L As System.IO.FileInfo
        Dim info7L As System.IO.FileInfo

        infoAll = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath & "\Dic\DicAll.txt")
        info5L = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath & "\Dic\Dic5L.txt")
        info6L = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath & "\Dic\Dic6L.txt")
        info7L = My.Computer.FileSystem.GetFileInfo(My.Application.Info.DirectoryPath & "\Dic\Dic7L.txt")

        Dim max As Integer

        max = infoAll.Length + info5L.Length + info6L.Length + info7L.Length

        'PB_Loading.Style = ProgressBarStyle.Blocks
        'PB_Loading.Minimum = 0
        'PB_Loading.Maximum = max
        'PB_Loading.Value = 0


        DicAll = New ArrayList
        line = MyReaderDicAll.ReadLine()
        While Not line Is Nothing
            'PB_Loading.Value = PB_Loading.Value + line.Length + 2
            DicAll.Add(line.ToString)
            line = MyReaderDicAll.ReadLine()
        End While

        Dic5L = New ArrayList
        line = MyReaderDic5L.ReadLine()
        While Not line Is Nothing
            'PB_Loading.Value = PB_Loading.Value + line.Length + 2
            Dic5L.Add(line.ToString)
            line = MyReaderDic5L.ReadLine()
        End While

        Dic6L = New ArrayList
        line = MyReaderDic6L.ReadLine()
        While Not line Is Nothing
            'PB_Loading.Value = PB_Loading.Value + line.Length + 2
            Dic6L.Add(line.ToString)
            line = MyReaderDic6L.ReadLine()
        End While

        Dic7L = New ArrayList
        line = MyReaderDic7L.ReadLine()
        While Not line Is Nothing
            'PB_Loading.Value = PB_Loading.Value + line.Length + 2
            Dic7L.Add(line.ToString)
            line = MyReaderDic7L.ReadLine()
        End While

        MyReaderDicAll.Close()
        MyReaderDic5L.Close()
        MyReaderDic6L.Close()
        MyReaderDic7L.Close()

        TimerGame.Enabled = False
    End Sub

    Public Sub NewGame()
        Dim rndNo As Integer
        Dim max As Integer
        Dim i As Integer
        Dim j As Integer
        Dim ChoosenWordBackup As String
        Dim pos As Integer
        Dim word As String
        Dim letter As String
        Dim Okay As Boolean

        If FirstRun = True Then
            Startup()
            FirstRun = False
        End If

        btn_Proceed.Enabled = False
        Clear()

        Randomize()

        If Difficulty = 1 Then 'Beginner
            max = Dic5L.Count - 1
            rndNo = CInt(Int(max * Rnd()))
            ChoosenWord = Dic5L.Item(rndNo)
        ElseIf Difficulty = 2 Then 'Medium
            max = Dic6L.Count - 1
            rndNo = CInt(Int(max * Rnd()))
            ChoosenWord = Dic6L.Item(rndNo)
        Else 'Difficulty = 3 for Expert
            max = Dic7L.Count - 1
            rndNo = CInt(Int(max * Rnd()))
            ChoosenWord = Dic7L.Item(rndNo)
        End If

        max = DicAll.Count - 1

        'PB_Loading.Value = 0
        'PB_Loading.Minimum = 0
        'PB_Loading.Maximum = max
        'PB_Loading.Step = 1

        PossibleWords = New ArrayList

        listbox_CorrectWords.Items.Clear()
        ListBox1.Items.Clear()
        ListBox1.Items.Add(ChoosenWord)
        For i = 0 To DicAll.Count - 1
            'PB_Loading.PerformStep()
            word = DicAll.Item(i)
            Okay = True
            ChoosenWordBackup = ChoosenWord
            For j = 1 To word.Length
                letter = Mid(word, j, 1)
                pos = InStr(1, ChoosenWordBackup, letter, CompareMethod.Text)
                If pos = 0 Then
                    Okay = False
                    Exit For
                End If
                If pos = 1 Then
                    ChoosenWordBackup = Mid(ChoosenWordBackup, 2, ChoosenWordBackup.Length)
                Else
                    ChoosenWordBackup = Mid(ChoosenWordBackup, 1, pos - 1) & Mid(ChoosenWordBackup, pos + 1, ChoosenWordBackup.Length)
                End If
            Next j
            If Okay = True Then
                PossibleWords.Add(word)
                ListBox1.Items.Add(word)
            End If
        Next i
        PossibleWordsCounter = PossibleWords.Count
        lbl_CorrectWords.Text = "Daftar Kata (" & CStr(PossibleWordsCounter) & "):"

        'PB_Loading.Value = 0
        NowPlaying = True

        lbl_Notes.Text = "You should find the word that contains all letters listed below"

        Twist()

        GameTimerSec = GameTimer
        TimerGame.Enabled = True
    End Sub

    Public Sub Twist()
        Dim AlReadyPicked() As Integer
        Dim PickedSeq() As Integer
        Dim LetterCount As Integer
        Dim i As Integer
        Dim j As Integer
        Dim rndNo As Integer
        Dim Okay As Boolean

        LetterCount = Difficulty + 4
        ReDim AlReadyPicked(LetterCount)
        ReDim PickedSeq(LetterCount)

        For j = 0 To LetterCount - 1
            PickedSeq(j) = 0
        Next j

        Randomize()
        For i = 0 To LetterCount - 1
            Do
                rndNo = CInt(Int(LetterCount * Rnd()) + 1)
                Okay = True
                For j = 0 To LetterCount - 1
                    If rndNo = PickedSeq(j) Then
                        Okay = False
                        Exit For
                    End If
                Next j
                If Okay = True Then
                    PickedSeq(i) = rndNo
                    Exit Do
                End If
            Loop
        Next i

        Button1.Text = Mid(ChoosenWord, PickedSeq(0), 1)
        Button2.Text = Mid(ChoosenWord, PickedSeq(1), 1)
        Button3.Text = Mid(ChoosenWord, PickedSeq(2), 1)
        Button4.Text = Mid(ChoosenWord, PickedSeq(3), 1)
        Button5.Text = Mid(ChoosenWord, PickedSeq(4), 1)
        If Difficulty = 2 Then
            Button6.Text = Mid(ChoosenWord, PickedSeq(5), 1)
        ElseIf Difficulty = 3 Then
            Button6.Text = Mid(ChoosenWord, PickedSeq(5), 1)
            Button7.Text = Mid(ChoosenWord, PickedSeq(6), 1)
        End If
    End Sub

    Public Sub Clear()
        txt_UserSubmit.Text = ""
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
    End Sub

#End Region

    Private Sub listbox_CorrectWords_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listbox_CorrectWords.SelectedIndexChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub lbl_CorrectWords_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_CorrectWords.Click

    End Sub

    Private Sub lbl_Notes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Notes.Click

    End Sub
End Class
