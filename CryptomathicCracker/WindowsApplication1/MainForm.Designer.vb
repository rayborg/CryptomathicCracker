<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CryptFileTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DictionaryAttackButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.currentPasswdTextBox = New System.Windows.Forms.TextBox
        Me.currentPasswordNumberTextBox = New System.Windows.Forms.TextBox
        Me.pwdCharactersTextBox = New System.Windows.Forms.TextBox
        Me.wordListFileTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.WaitTimeDecryptTextBox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CrackProgressGroup = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DelaysBox2 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.StartWordNumberTextBox = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.BruteButton = New System.Windows.Forms.Button
        Me.LowerCheck = New System.Windows.Forms.CheckBox
        Me.UpperCheck = New System.Windows.Forms.CheckBox
        Me.NumbersCheck = New System.Windows.Forms.CheckBox
        Me.SybolsCheck = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CrackProgressGroup.SuspendLayout()
        Me.DelaysBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CryptFileTextBox
        '
        Me.CryptFileTextBox.Location = New System.Drawing.Point(264, 12)
        Me.CryptFileTextBox.Name = "CryptFileTextBox"
        Me.CryptFileTextBox.Size = New System.Drawing.Size(461, 22)
        Me.CryptFileTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter cryptomathic filename:"
        '
        'DictionaryAttackButton
        '
        Me.DictionaryAttackButton.Location = New System.Drawing.Point(341, 162)
        Me.DictionaryAttackButton.Name = "DictionaryAttackButton"
        Me.DictionaryAttackButton.Size = New System.Drawing.Size(148, 33)
        Me.DictionaryAttackButton.TabIndex = 5
        Me.DictionaryAttackButton.Text = "Dictionary Attack!"
        Me.DictionaryAttackButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Example: C:\File2File1.txt.exe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter wordlist path/filename here: "
        '
        'currentPasswdTextBox
        '
        Me.currentPasswdTextBox.Location = New System.Drawing.Point(105, 36)
        Me.currentPasswdTextBox.Name = "currentPasswdTextBox"
        Me.currentPasswdTextBox.ReadOnly = True
        Me.currentPasswdTextBox.Size = New System.Drawing.Size(268, 22)
        Me.currentPasswdTextBox.TabIndex = 4
        '
        'currentPasswordNumberTextBox
        '
        Me.currentPasswordNumberTextBox.Location = New System.Drawing.Point(105, 69)
        Me.currentPasswordNumberTextBox.Name = "currentPasswordNumberTextBox"
        Me.currentPasswordNumberTextBox.ReadOnly = True
        Me.currentPasswordNumberTextBox.Size = New System.Drawing.Size(268, 22)
        Me.currentPasswordNumberTextBox.TabIndex = 5
        '
        'pwdCharactersTextBox
        '
        Me.pwdCharactersTextBox.Location = New System.Drawing.Point(105, 97)
        Me.pwdCharactersTextBox.Name = "pwdCharactersTextBox"
        Me.pwdCharactersTextBox.ReadOnly = True
        Me.pwdCharactersTextBox.Size = New System.Drawing.Size(268, 22)
        Me.pwdCharactersTextBox.TabIndex = 6
        '
        'wordListFileTextBox
        '
        Me.wordListFileTextBox.Location = New System.Drawing.Point(299, 84)
        Me.wordListFileTextBox.Name = "wordListFileTextBox"
        Me.wordListFileTextBox.Size = New System.Drawing.Size(426, 22)
        Me.wordListFileTextBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Example: C:\words.txt"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Trying:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Characters:"
        '
        'WaitTimeDecryptTextBox
        '
        Me.WaitTimeDecryptTextBox.Location = New System.Drawing.Point(214, 26)
        Me.WaitTimeDecryptTextBox.Name = "WaitTimeDecryptTextBox"
        Me.WaitTimeDecryptTextBox.Size = New System.Drawing.Size(56, 22)
        Me.WaitTimeDecryptTextBox.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(201, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Wait time between decryption: "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(168, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Default 1000 ms"
        '
        'CrackProgressGroup
        '
        Me.CrackProgressGroup.Controls.Add(Me.Label18)
        Me.CrackProgressGroup.Controls.Add(Me.ProgressBar1)
        Me.CrackProgressGroup.Controls.Add(Me.Label7)
        Me.CrackProgressGroup.Controls.Add(Me.Label6)
        Me.CrackProgressGroup.Controls.Add(Me.Label5)
        Me.CrackProgressGroup.Controls.Add(Me.pwdCharactersTextBox)
        Me.CrackProgressGroup.Controls.Add(Me.currentPasswordNumberTextBox)
        Me.CrackProgressGroup.Controls.Add(Me.currentPasswdTextBox)
        Me.CrackProgressGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrackProgressGroup.Location = New System.Drawing.Point(341, 263)
        Me.CrackProgressGroup.Name = "CrackProgressGroup"
        Me.CrackProgressGroup.Size = New System.Drawing.Size(388, 158)
        Me.CrackProgressGroup.TabIndex = 24
        Me.CrackProgressGroup.TabStop = False
        Me.CrackProgressGroup.Text = "Cracking progress"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 131)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Progress:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(105, 125)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(268, 23)
        Me.ProgressBar1.TabIndex = 18
        '
        'DelaysBox2
        '
        Me.DelaysBox2.Controls.Add(Me.Label13)
        Me.DelaysBox2.Controls.Add(Me.Label10)
        Me.DelaysBox2.Controls.Add(Me.Label8)
        Me.DelaysBox2.Controls.Add(Me.WaitTimeDecryptTextBox)
        Me.DelaysBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelaysBox2.Location = New System.Drawing.Point(10, 263)
        Me.DelaysBox2.Name = "DelaysBox2"
        Me.DelaysBox2.Size = New System.Drawing.Size(311, 79)
        Me.DelaysBox2.TabIndex = 25
        Me.DelaysBox2.TabStop = False
        Me.DelaysBox2.Text = "Leave blank for default delays"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(276, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "ms"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(329, 18)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "NOTE: Faster machines may wish to lower delay"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Elephant", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(588, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 33)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "STOP"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StartWordNumberTextBox
        '
        Me.StartWordNumberTextBox.Location = New System.Drawing.Point(508, 220)
        Me.StartWordNumberTextBox.Name = "StartWordNumberTextBox"
        Me.StartWordNumberTextBox.Size = New System.Drawing.Size(86, 22)
        Me.StartWordNumberTextBox.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(338, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 17)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Start from word number: "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(600, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Default start from 0"
        '
        'BruteButton
        '
        Me.BruteButton.Location = New System.Drawing.Point(10, 31)
        Me.BruteButton.Name = "BruteButton"
        Me.BruteButton.Size = New System.Drawing.Size(148, 33)
        Me.BruteButton.TabIndex = 6
        Me.BruteButton.Text = "Bruteforce!"
        Me.BruteButton.UseVisualStyleBackColor = True
        '
        'LowerCheck
        '
        Me.LowerCheck.AutoSize = True
        Me.LowerCheck.Location = New System.Drawing.Point(12, 70)
        Me.LowerCheck.Name = "LowerCheck"
        Me.LowerCheck.Size = New System.Drawing.Size(50, 21)
        Me.LowerCheck.TabIndex = 32
        Me.LowerCheck.Text = "a-z"
        Me.LowerCheck.UseVisualStyleBackColor = True
        '
        'UpperCheck
        '
        Me.UpperCheck.AutoSize = True
        Me.UpperCheck.Location = New System.Drawing.Point(68, 70)
        Me.UpperCheck.Name = "UpperCheck"
        Me.UpperCheck.Size = New System.Drawing.Size(53, 21)
        Me.UpperCheck.TabIndex = 33
        Me.UpperCheck.Text = "A-Z"
        Me.UpperCheck.UseVisualStyleBackColor = True
        '
        'NumbersCheck
        '
        Me.NumbersCheck.AutoSize = True
        Me.NumbersCheck.Location = New System.Drawing.Point(127, 70)
        Me.NumbersCheck.Name = "NumbersCheck"
        Me.NumbersCheck.Size = New System.Drawing.Size(51, 21)
        Me.NumbersCheck.TabIndex = 34
        Me.NumbersCheck.Text = "0-9"
        Me.NumbersCheck.UseVisualStyleBackColor = True
        '
        'SybolsCheck
        '
        Me.SybolsCheck.AutoSize = True
        Me.SybolsCheck.Location = New System.Drawing.Point(184, 70)
        Me.SybolsCheck.Name = "SybolsCheck"
        Me.SybolsCheck.Size = New System.Drawing.Size(83, 21)
        Me.SybolsCheck.TabIndex = 35
        Me.SybolsCheck.Text = "Symbols"
        Me.SybolsCheck.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 144)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(183, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "8 Character passwords only"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SybolsCheck)
        Me.GroupBox1.Controls.Add(Me.NumbersCheck)
        Me.GroupBox1.Controls.Add(Me.UpperCheck)
        Me.GroupBox1.Controls.Add(Me.LowerCheck)
        Me.GroupBox1.Controls.Add(Me.BruteButton)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 130)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 108)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bruteforce options"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(325, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "If lowered too much this may cause false positives."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 431)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.StartWordNumberTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DelaysBox2)
        Me.Controls.Add(Me.CrackProgressGroup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.wordListFileTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DictionaryAttackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CryptFileTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "Cryptomathic File2File Cracker"
        Me.CrackProgressGroup.ResumeLayout(False)
        Me.CrackProgressGroup.PerformLayout()
        Me.DelaysBox2.ResumeLayout(False)
        Me.DelaysBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CryptFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DictionaryAttackButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents currentPasswdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents currentPasswordNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pwdCharactersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents wordListFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WaitTimeDecryptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CrackProgressGroup As System.Windows.Forms.GroupBox
    Friend WithEvents DelaysBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StartWordNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BruteButton As System.Windows.Forms.Button
    Friend WithEvents LowerCheck As System.Windows.Forms.CheckBox
    Friend WithEvents UpperCheck As System.Windows.Forms.CheckBox
    Friend WithEvents NumbersCheck As System.Windows.Forms.CheckBox
    Friend WithEvents SybolsCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
