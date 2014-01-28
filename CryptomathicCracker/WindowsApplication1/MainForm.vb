Imports System.IO
Imports System.Runtime.InteropServices

Public Class MainForm
    Public Shared keySpace As New ArrayList
    Public Shared keySpaceSize As Integer = keySpace.Count

    'START ESC KEY HOOK 
    Private Const user32 As String = "user32.dll"
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    ' This delegate is used to tell windows which sub we want it to call
    ' when a key is pressed.
    Private proc As LowLevelKeyboardProcDelegate = AddressOf HookCallback
    Private hookID As IntPtr
    ' Just for the demo:
    Private count As Integer = 0

    Private Delegate Function LowLevelKeyboardProcDelegate( _
     ByVal nCode As Integer, ByVal wParam As IntPtr, _
     ByVal lParam As IntPtr) As IntPtr

    ' Creates the hook.
    <DllImport("user32")> _
    Private Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProcDelegate, _
     ByVal hMod As IntPtr, ByVal dwThreadId As Integer) As IntPtr
    End Function

    ' Removes the hook.
    <DllImport("user32.dll")> _
    Private Shared Function UnhookWindowsHookEx(ByVal hhk As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    ' The hooks work in a cycle, it is our duty to call the next one after we have been notified.
    <DllImport("user32.dll")> _
    Private Shared Function CallNextHookEx(ByVal hhk As IntPtr, ByVal nCode As Integer, ByVal wParam As IntPtr, _
     ByVal lParam As IntPtr) As IntPtr
    End Function

    ' Gets a module handle for our process.
    <DllImport("kernel32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        hookID = SetHook(proc)
    End Sub

    ' You really want to be sure this is called. Abnormal program termination will leave it open
    ' I think that using a SafeHandle for the hook handle might work.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        UnhookWindowsHookEx(hookID)
    End Sub

    Private Function SetHook(ByVal proc As LowLevelKeyboardProcDelegate) As IntPtr
        Using curProcess As Process = Process.GetCurrentProcess()
            Using curModule As ProcessModule = curProcess.MainModule
                Return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0)
            End Using
        End Using
    End Function

    ' Called when a key is pressed.
    Private Function HookCallback(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        If nCode >= 0 AndAlso (wParam.ToInt32 = WM_KEYDOWN) Then
            Dim vkCode As Integer = Marshal.ReadInt32(lParam)
            If vkCode = Keys.Escape Then
                Environment.Exit(0)
                count += 1
                Me.Text = count.ToString
            End If
        End If
        Return CallNextHookEx(hookID, nCode, wParam, lParam)
    End Function
    'FINISHED ESC KEY HOOK 

    Private Sub wait(ByVal interval As Integer)
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < interval
            ' Allows your UI to remain responsive
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub

    Public Shared Function GenerateNextPassword(ByVal remainder As Integer) As String
        Dim passPlace0 As String
        Dim passPlace1 As String
        Dim passPlace2 As String
        Dim passPlace3 As String
        Dim passPlace4 As String
        Dim passPlace5 As String
        Dim passPlace6 As String
        Dim passPlace7 As String

        passPlace0 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace1 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace2 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace3 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace4 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace5 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace6 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        passPlace7 = keySpace(remainder Mod keySpaceSize)
        remainder = Math.Floor(remainder / keySpaceSize)
        Return passPlace7 & passPlace6 & passPlace5 & passPlace4 & passPlace3 & passPlace2 & passPlace1 & passPlace0
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DictionaryAttackButton.Click
        If CryptFileTextBox.Text.Length > 0 And File.Exists(CryptFileTextBox.Text) And wordListFileTextBox.Text.Length > 0 And File.Exists(wordListFileTextBox.Text) Then

            Dim wordsInList As Integer = 0
            Dim ProcID As Integer
            Dim cryptoFile As String
            Dim cryptoFileResult As String
            Dim counter As Integer
            Dim decryptDelay As Integer
            Dim words() As String = IO.File.ReadAllLines(wordListFileTextBox.Text)
            Dim processName As String

            wordsInList = words.Length
            ProgressBar1.Maximum = wordsInList
            ProgressBar1.Value = 0
            counter = 0
            cryptoFile = ""
            cryptoFileResult = ""
            decryptDelay = 1000

            cryptoFile = CryptFileTextBox.Text
            cryptoFileResult = cryptoFile
            cryptoFileResult = cryptoFileResult.Substring(0, cryptoFileResult.Length - 4)

            processName = cryptoFile.Substring(cryptoFile.LastIndexOf("\") + 1, (cryptoFile.Length - 5) - cryptoFile.LastIndexOf("\"))
            MessageBox.Show("Cracking: " & processName, "Important Message")




            If WaitTimeDecryptTextBox.Text.Length > 0 Then
                decryptDelay = Integer.Parse(WaitTimeDecryptTextBox.Text)
            End If

            If StartWordNumberTextBox.Text.Length > 0 Then
                If counter > wordsInList Then
                Else
                    counter = Integer.Parse(StartWordNumberTextBox.Text)
                End If
            End If

            If currentPasswordNumberTextBox.Text.Length > 0 Then
                counter = Integer.Parse(currentPasswordNumberTextBox.Text)
            End If


            MessageBox.Show("Cryptofile choosen is: " + cryptoFile & vbNewLine & "Wordlist choosen is: " + wordListFileTextBox.Text & vbNewLine & "Words in this list: " & wordsInList & vbNewLine & "Output file will be: " + cryptoFileResult & vbNewLine & "Time between password entry and decrypt is: " & decryptDelay & " milliseconds", "Important Message")
            MessageBox.Show("Do not click any further boxes after this one until program is done.", "Important Message")

            Try
                'add while condition while file does not exist
                While ((IO.File.Exists(cryptoFile)) And (counter < wordsInList) And Not (IO.File.Exists(cryptoFileResult)))
                    currentPasswdTextBox.Text = words(counter)
                    currentPasswordNumberTextBox.Text = counter
                    pwdCharactersTextBox.Text = words(counter).Length
                    ProgressBar1.Value += 1


                    ' If program running then send ENTER

                    ' Start the application File2File.exe, and store the process id.
                    ProcID = Shell(cryptoFile, AppWinStyle.NormalFocus)
                    AppActivate(ProcID) ' Activate the application.
                    Dim processes() As Process = Process.GetProcessesByName(processName) 'gets program by name

                    SendKeys.Send(words(counter)) 'sends current word in wordlist as password
                    SendKeys.SendWait("~") 'send enter press to decrypt
                    wait(decryptDelay) 'wait funciton allows UI to remain responsive

                    'If password was found a save window dialog will open and title = ""
                    If processes.Length > 0 Then
                        If processes(0).MainWindowTitle = "" Then
                            wait(3000)
                            If processes(0).MainWindowTitle = "" Then
                                MessageBox.Show("The password is: " + currentPasswdTextBox.Text, "Important Message")
                                MessageBox.Show("Please save result, program will now close!", "Important Message")
                                Environment.Exit(0)
                            End If
                        End If

                        Try
                            'Password not found so close error message box this time
                            processes(0).Kill()
                            processes(0).WaitForExit()
                            processes(0).Close()
                        Catch
                        End Try
                    End If

                    
                    counter += 1
                End While

            Catch
                SendKeys.SendWait("~")
                wait(2000) 'On error wait
            End Try

            wait(2000) 'Password was not found in wordlist 

            If Not (IO.File.Exists(cryptoFileResult)) Then
                MessageBox.Show("Password was not found", "Important Message")
            End If

        Else
            MessageBox.Show("Please select a file and wordlist and make sure they exist.", "Important Message")
        End If

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaitTimeDecryptTextBox.TextChanged
        Try
            Integer.Parse(WaitTimeDecryptTextBox.Text)
        Catch ex As Exception
            WaitTimeDecryptTextBox.Text = ""
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Environment.Exit(0)
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartWordNumberTextBox.TextChanged
        Try
            Integer.Parse(StartWordNumberTextBox.Text)
        Catch ex As Exception
            StartWordNumberTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BruteButton.Click
        If LowerCheck.Checked Or UpperCheck.Checked Or NumbersCheck.Checked Or SybolsCheck.Checked Then
            If CryptFileTextBox.Text.Length > 0 And File.Exists(CryptFileTextBox.Text) Then

                Dim wordsInList As Integer = 0
                Dim ProcID As Integer
                Dim cryptoFile As String
                Dim cryptoFileResult As String
                Dim wordListName As String
                Dim password As String = ""
                Dim counter As Integer
                Dim decryptDelay As Integer
                Dim processName As String

                counter = 0
                cryptoFile = ""
                wordListName = ""
                cryptoFileResult = ""
                decryptDelay = 1000
                cryptoFile = CryptFileTextBox.Text
                wordListName = wordListFileTextBox.Text
                cryptoFileResult = cryptoFile
                cryptoFileResult = cryptoFileResult.Substring(0, cryptoFileResult.Length - 4)

                processName = cryptoFile.Substring(cryptoFile.LastIndexOf("\") + 1, (cryptoFile.Length - 5) - cryptoFile.LastIndexOf("\"))
                MessageBox.Show("Cracking: " & processName, "Important Message")

                If WaitTimeDecryptTextBox.Text.Length > 0 Then
                    decryptDelay = Integer.Parse(WaitTimeDecryptTextBox.Text)
                End If

                If StartWordNumberTextBox.Text.Length > 0 Then
                    If counter > wordsInList Then
                    Else
                        counter = Integer.Parse(StartWordNumberTextBox.Text)
                    End If
                End If

                MessageBox.Show("Cryptofile choosen is: " + cryptoFile & vbNewLine & "Output file will be: " + cryptoFileResult & vbNewLine & "Time between password entry and decrypt is: " & decryptDelay & " milliseconds", "Important Message")
                MessageBox.Show("Do not click any further boxes after this one until program is done.", "Important Message")

                While ((IO.File.Exists(cryptoFile)) And Not (IO.File.Exists(cryptoFileResult)))
                    password = GenerateNextPassword(counter)
                    currentPasswdTextBox.Text = password
                    currentPasswordNumberTextBox.Text = counter
                    pwdCharactersTextBox.Text = password.Length

                    ' Start the application, and store the process id.
                    ProcID = Shell(cryptoFile, AppWinStyle.NormalFocus)
                    AppActivate(ProcID) ' Activate the application.

                    My.Computer.Keyboard.SendKeys(password, True) 'send password to program
                    SendKeys.SendWait("~") 'send enter press to decrypt
                    wait(decryptDelay) 'wait funciton allows UI to remain responsive

                    Dim processes() As Process = Process.GetProcessesByName(processName) 'gets program by name

                    If processes.Length > 0 Then
                        If processes(0).MainWindowTitle = "" Then
                            wait(3000)
                            If processes(0).MainWindowTitle = "" Then
                                MessageBox.Show("The password is: " & currentPasswdTextBox.Text, "Important Message")
                                MessageBox.Show("Please save result, program will now close!", "Important Message")
                                Environment.Exit(0)
                            End If
                        End If
                        Try
                            'Password not found so close error message box this time
                            processes(0).Kill()
                            processes(0).WaitForExit()
                            processes(0).Close()
                        Catch
                        End Try
                    End If

                    counter = 1 + counter
                End While

                wait(2000)

                If Not (IO.File.Exists(cryptoFileResult)) Then
                    MessageBox.Show("Password was not found", "Important Message")
                End If
            Else
                MessageBox.Show("Please select a file to decrypt and make sure it exists.", "Important Message")
            End If
        Else
            MessageBox.Show("Please check at least one character set to include in bruteforce.", "Important Message")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowerCheck.CheckedChanged
        keySpace.Add("a")
        keySpace.Add("b")
        keySpace.Add("c")
        keySpace.Add("d")
        keySpace.Add("e")
        keySpace.Add("f")
        keySpace.Add("g")
        keySpace.Add("h")
        keySpace.Add("i")
        keySpace.Add("j")
        keySpace.Add("k")
        keySpace.Add("l")
        keySpace.Add("m")
        keySpace.Add("n")
        keySpace.Add("o")
        keySpace.Add("p")
        keySpace.Add("q")
        keySpace.Add("r")
        keySpace.Add("s")
        keySpace.Add("t")
        keySpace.Add("u")
        keySpace.Add("v")
        keySpace.Add("w")
        keySpace.Add("x")
        keySpace.Add("y")
        keySpace.Add("z")
        MessageBox.Show("Keyspace is: " & keySpace.Count ^ 8, "Important Message")
        keySpaceSize = keySpace.Count
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpperCheck.CheckedChanged
        keySpace.Add("A")
        keySpace.Add("B")
        keySpace.Add("C")
        keySpace.Add("D")
        keySpace.Add("E")
        keySpace.Add("F")
        keySpace.Add("G")
        keySpace.Add("H")
        keySpace.Add("I")
        keySpace.Add("J")
        keySpace.Add("K")
        keySpace.Add("L")
        keySpace.Add("M")
        keySpace.Add("N")
        keySpace.Add("O")
        keySpace.Add("P")
        keySpace.Add("Q")
        keySpace.Add("R")
        keySpace.Add("S")
        keySpace.Add("T")
        keySpace.Add("U")
        keySpace.Add("V")
        keySpace.Add("W")
        keySpace.Add("X")
        keySpace.Add("Y")
        keySpace.Add("Z")
        MessageBox.Show("Keyspace is: " & keySpace.Count ^ 8, "Important Message")
        keySpaceSize = keySpace.Count
    End Sub

    Private Sub NumbersCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumbersCheck.CheckedChanged
        keySpace.Add("0")
        keySpace.Add("1")
        keySpace.Add("2")
        keySpace.Add("3")
        keySpace.Add("4")
        keySpace.Add("5")
        keySpace.Add("6")
        keySpace.Add("7")
        keySpace.Add("8")
        keySpace.Add("9")
        MessageBox.Show("Keyspace is: " & keySpace.Count ^ 8, "Important Message")
        keySpaceSize = keySpace.Count
    End Sub

    Private Sub SybolsCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SybolsCheck.CheckedChanged
        keySpace.Add("!")
        keySpace.Add("@")
        keySpace.Add("#")
        keySpace.Add("$")
        keySpace.Add("{%}")
        keySpace.Add("{^}")
        keySpace.Add("&")
        keySpace.Add("*")
        keySpace.Add("{(}")
        keySpace.Add("{)}")
        keySpace.Add("-")
        keySpace.Add("{+}")
        keySpace.Add("=")
        keySpace.Add("?")
        keySpace.Add("{~}")
        keySpace.Add("{[}")
        keySpace.Add("{]}")
        keySpace.Add("\")
        keySpace.Add("/")
        keySpace.Add(">")
        keySpace.Add("<")
        keySpace.Add(".")
        keySpace.Add("'")
        MessageBox.Show("Keyspace is: " & keySpace.Count ^ 8, "Important Message")
        keySpaceSize = keySpace.Count
    End Sub
End Class
