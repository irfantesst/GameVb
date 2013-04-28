<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MS_Main = New System.Windows.Forms.MenuStrip
        Me.mnu_File = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_NewGame = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_Difficulty = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Beginner = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Medium = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Expert = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_Exit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.PB_Loading = New System.Windows.Forms.ProgressBar
        Me.txt_UserSubmit = New System.Windows.Forms.TextBox
        Me.listbox_CorrectWords = New System.Windows.Forms.ListBox
        Me.lbl_CorrectWords = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.btn_Submit = New System.Windows.Forms.Button
        Me.btn_Twist = New System.Windows.Forms.Button
        Me.btn_Clear = New System.Windows.Forms.Button
        Me.lbl_Notes = New System.Windows.Forms.Label
        Me.btn_Proceed = New System.Windows.Forms.Button
        Me.TimerGame = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_TimeLeft = New System.Windows.Forms.Label
        Me.lbl_Timer = New System.Windows.Forms.Label
        Me.mnu_About = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Help = New System.Windows.Forms.ToolStripMenuItem
        Me.MS_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'MS_Main
        '
        Me.MS_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_File, Me.mnu_Help})
        Me.MS_Main.Location = New System.Drawing.Point(0, 0)
        Me.MS_Main.Name = "MS_Main"
        Me.MS_Main.Size = New System.Drawing.Size(567, 24)
        Me.MS_Main.TabIndex = 6
        Me.MS_Main.Text = "MS_Main"
        '
        'mnu_File
        '
        Me.mnu_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_NewGame, Me.ToolStripSeparator1, Me.mnu_Difficulty, Me.ToolStripSeparator2, Me.mnu_Exit})
        Me.mnu_File.Name = "mnu_File"
        Me.mnu_File.Size = New System.Drawing.Size(37, 20)
        Me.mnu_File.Text = "&File"
        '
        'mnu_NewGame
        '
        Me.mnu_NewGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_NewGame.Name = "mnu_NewGame"
        Me.mnu_NewGame.Size = New System.Drawing.Size(152, 22)
        Me.mnu_NewGame.Text = "&New Game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'mnu_Difficulty
        '
        Me.mnu_Difficulty.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_Difficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Beginner, Me.mnu_Medium, Me.mnu_Expert})
        Me.mnu_Difficulty.Name = "mnu_Difficulty"
        Me.mnu_Difficulty.Size = New System.Drawing.Size(152, 22)
        Me.mnu_Difficulty.Text = "&Difficulty"
        '
        'mnu_Beginner
        '
        Me.mnu_Beginner.Checked = True
        Me.mnu_Beginner.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnu_Beginner.Name = "mnu_Beginner"
        Me.mnu_Beginner.Size = New System.Drawing.Size(176, 22)
        Me.mnu_Beginner.Text = "&Beginner (5 Letters)"
        '
        'mnu_Medium
        '
        Me.mnu_Medium.Name = "mnu_Medium"
        Me.mnu_Medium.Size = New System.Drawing.Size(176, 22)
        Me.mnu_Medium.Text = "&Medium (6 Letters)"
        '
        'mnu_Expert
        '
        Me.mnu_Expert.Name = "mnu_Expert"
        Me.mnu_Expert.Size = New System.Drawing.Size(176, 22)
        Me.mnu_Expert.Text = "&Expert (7 Letters)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'mnu_Exit
        '
        Me.mnu_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_Exit.Name = "mnu_Exit"
        Me.mnu_Exit.Size = New System.Drawing.Size(152, 22)
        Me.mnu_Exit.Text = "E&xit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 19)
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(211, 226)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(179, 224)
        Me.ListBox1.TabIndex = 7
        Me.ListBox1.TabStop = False
        Me.ListBox1.Visible = False
        '
        'PB_Loading
        '
        Me.PB_Loading.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB_Loading.Location = New System.Drawing.Point(0, 461)
        Me.PB_Loading.Name = "PB_Loading"
        Me.PB_Loading.Size = New System.Drawing.Size(567, 20)
        Me.PB_Loading.TabIndex = 9
        '
        'txt_UserSubmit
        '
        Me.txt_UserSubmit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txt_UserSubmit.Location = New System.Drawing.Point(211, 160)
        Me.txt_UserSubmit.Name = "txt_UserSubmit"
        Me.txt_UserSubmit.ReadOnly = True
        Me.txt_UserSubmit.Size = New System.Drawing.Size(330, 26)
        Me.txt_UserSubmit.TabIndex = 10
        Me.txt_UserSubmit.TabStop = False
        Me.txt_UserSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listbox_CorrectWords
        '
        Me.listbox_CorrectWords.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.listbox_CorrectWords.FormattingEnabled = True
        Me.listbox_CorrectWords.ItemHeight = 20
        Me.listbox_CorrectWords.Location = New System.Drawing.Point(15, 66)
        Me.listbox_CorrectWords.Name = "listbox_CorrectWords"
        Me.listbox_CorrectWords.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.listbox_CorrectWords.Size = New System.Drawing.Size(179, 384)
        Me.listbox_CorrectWords.TabIndex = 11
        Me.listbox_CorrectWords.TabStop = False
        Me.listbox_CorrectWords.UseTabStops = False
        '
        'lbl_CorrectWords
        '
        Me.lbl_CorrectWords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CorrectWords.Location = New System.Drawing.Point(13, 41)
        Me.lbl_CorrectWords.Name = "lbl_CorrectWords"
        Me.lbl_CorrectWords.Size = New System.Drawing.Size(190, 22)
        Me.lbl_CorrectWords.TabIndex = 12
        Me.lbl_CorrectWords.Text = "Daftar kata yang benar "
        Me.lbl_CorrectWords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 25)
        Me.Button1.TabIndex = 13
        Me.Button1.TabStop = False
        Me.Button1.Text = "A"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(258, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 25)
        Me.Button2.TabIndex = 14
        Me.Button2.TabStop = False
        Me.Button2.Text = "B"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(307, 192)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 25)
        Me.Button3.TabIndex = 15
        Me.Button3.TabStop = False
        Me.Button3.Text = "C"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(358, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 25)
        Me.Button4.TabIndex = 16
        Me.Button4.TabStop = False
        Me.Button4.Text = "D"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(410, 192)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 25)
        Me.Button5.TabIndex = 17
        Me.Button5.TabStop = False
        Me.Button5.Text = "E"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(461, 192)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 25)
        Me.Button6.TabIndex = 18
        Me.Button6.TabStop = False
        Me.Button6.Text = "F"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(509, 192)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 25)
        Me.Button7.TabIndex = 19
        Me.Button7.TabStop = False
        Me.Button7.Text = "G"
        '
        'btn_Submit
        '
        Me.btn_Submit.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Submit.Location = New System.Drawing.Point(410, 117)
        Me.btn_Submit.Name = "btn_Submit"
        Me.btn_Submit.Size = New System.Drawing.Size(131, 37)
        Me.btn_Submit.TabIndex = 20
        Me.btn_Submit.TabStop = False
        Me.btn_Submit.Text = "Ok"
        '
        'btn_Twist
        '
        Me.btn_Twist.Location = New System.Drawing.Point(410, 223)
        Me.btn_Twist.Name = "btn_Twist"
        Me.btn_Twist.Size = New System.Drawing.Size(131, 36)
        Me.btn_Twist.TabIndex = 21
        Me.btn_Twist.TabStop = False
        Me.btn_Twist.Text = "Acak Huruf"
        '
        'btn_Clear
        '
        Me.btn_Clear.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Clear.Location = New System.Drawing.Point(211, 117)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(128, 37)
        Me.btn_Clear.TabIndex = 22
        Me.btn_Clear.TabStop = False
        Me.btn_Clear.Text = "Hapus Kata"
        '
        'lbl_Notes
        '
        Me.lbl_Notes.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Notes.ForeColor = System.Drawing.Color.Red
        Me.lbl_Notes.Location = New System.Drawing.Point(209, 24)
        Me.lbl_Notes.Name = "lbl_Notes"
        Me.lbl_Notes.Size = New System.Drawing.Size(328, 73)
        Me.lbl_Notes.TabIndex = 23
        Me.lbl_Notes.Text = "Notes"
        Me.lbl_Notes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Proceed
        '
        Me.btn_Proceed.Location = New System.Drawing.Point(410, 425)
        Me.btn_Proceed.Name = "btn_Proceed"
        Me.btn_Proceed.Size = New System.Drawing.Size(131, 25)
        Me.btn_Proceed.TabIndex = 24
        Me.btn_Proceed.TabStop = False
        Me.btn_Proceed.Text = "Lanjut --->"
        '
        'TimerGame
        '
        Me.TimerGame.Interval = 1000
        '
        'lbl_TimeLeft
        '
        Me.lbl_TimeLeft.AutoSize = True
        Me.lbl_TimeLeft.Location = New System.Drawing.Point(396, 402)
        Me.lbl_TimeLeft.Name = "lbl_TimeLeft"
        Me.lbl_TimeLeft.Size = New System.Drawing.Size(114, 20)
        Me.lbl_TimeLeft.TabIndex = 25
        Me.lbl_TimeLeft.Text = "Waktu Tersisa:"
        '
        'lbl_Timer
        '
        Me.lbl_Timer.AutoSize = True
        Me.lbl_Timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Timer.ForeColor = System.Drawing.Color.DarkRed
        Me.lbl_Timer.Location = New System.Drawing.Point(516, 402)
        Me.lbl_Timer.Name = "lbl_Timer"
        Me.lbl_Timer.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Timer.TabIndex = 26
        Me.lbl_Timer.Text = "240"
        '
        'mnu_About
        '
        Me.mnu_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_About.Name = "mnu_About"
        Me.mnu_About.Size = New System.Drawing.Size(197, 22)
        Me.mnu_About.Text = "&About Text Twist Game"
        '
        'mnu_Help
        '
        Me.mnu_Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnu_Help.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_About})
        Me.mnu_Help.Name = "mnu_Help"
        Me.mnu_Help.Size = New System.Drawing.Size(44, 20)
        Me.mnu_Help.Text = "&Help"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(567, 481)
        Me.Controls.Add(Me.lbl_Timer)
        Me.Controls.Add(Me.lbl_TimeLeft)
        Me.Controls.Add(Me.btn_Proceed)
        Me.Controls.Add(Me.lbl_Notes)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Twist)
        Me.Controls.Add(Me.btn_Submit)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_CorrectWords)
        Me.Controls.Add(Me.listbox_CorrectWords)
        Me.Controls.Add(Me.txt_UserSubmit)
        Me.Controls.Add(Me.PB_Loading)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MS_Main)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MS_Main
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tugas VB Text Game"
        Me.MS_Main.ResumeLayout(False)
        Me.MS_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS_Main As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_NewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Difficulty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Beginner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Medium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Expert As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PB_Loading As System.Windows.Forms.ProgressBar
    Friend WithEvents txt_UserSubmit As System.Windows.Forms.TextBox
    Friend WithEvents listbox_CorrectWords As System.Windows.Forms.ListBox
    Friend WithEvents lbl_CorrectWords As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btn_Submit As System.Windows.Forms.Button
    Friend WithEvents btn_Twist As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_Notes As System.Windows.Forms.Label
    Friend WithEvents btn_Proceed As System.Windows.Forms.Button
    Friend WithEvents TimerGame As System.Windows.Forms.Timer
    Friend WithEvents lbl_TimeLeft As System.Windows.Forms.Label
    Friend WithEvents lbl_Timer As System.Windows.Forms.Label
    Friend WithEvents mnu_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_About As System.Windows.Forms.ToolStripMenuItem

End Class
