Imports System.Text
Public Class Setup
    Public Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Shown

        If ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt", SelectS5Lab, S5Labs, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\BSL3Labs.txt", SelectBSL3Lab, BSL3Labs, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\LabManagers.txt", ComboBox1, LabManagers, S5LabManagers, BSL3LabManagers) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\Authorisors.txt", ComboBox1, Authorisors, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\S5PTU.txt", ComboBox1, S5PTU, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\S5TU.txt", ComboBox1, S5TU, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\BSL3PTU.txt", ComboBox1, BSL3PTUs, CheckedListBox1, CheckedListBox1) = True And
            ReadFromFile("C:\Users\Dave\Documents\Database\Database Files\BSL3TU.txt", ComboBox1, BSL3TUs, CheckedListBox1, CheckedListBox1) = True Then

            If System.IO.File.Exists("C:\Users\Dave\Documents\Database\Database Files\OH.txt") Then
                Dim Streamreader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\OH.txt")
                OHName.Text = Streamreader.ReadLine
                OHEmail.Text = Streamreader.ReadLine
                Streamreader.Close()
            End If

        Else
            MsgBox("The existing data has not been imported.", vbOKOnly, "Lab Protect - Import Unsuccessful")
        End If

        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()

    End Sub
    Public Function ReadFromFile(ByVal Filepath As String, ByVal CBox As ComboBox, ByVal LBox As ListBox, ByVal CLB1 As CheckedListBox, ByVal CLB2 As CheckedListBox) As Boolean
        If System.IO.File.Exists(Filepath) Then
            Dim Streamreader As New System.IO.StreamReader(Filepath)
            Dim Line As String
            Do While Streamreader.EndOfStream <> True
                Line = Streamreader.ReadLine()

                If Line = "FALSE" Then
                    Exit Do
                End If

                With CBox
                    .Items.Add(Line)
                End With

                With LBox
                    .Items.Add(Line)
                End With

                With CLB1
                    .Items.Add(Line)
                End With

                With CLB2
                    .Items.Add(Line)
                End With
            Loop
            Streamreader.Close()
            ReadFromFile = True
        Else
            ReadFromFile = False
        End If

    End Function

    'Public Function FileSwapperAccess(ByVal File As String) As Boolean
    '    Dim OriginalFile As String
    '    Dim NewFile As String

    '    OriginalFile = File
    '    NewFile = Microsoft.VisualBasic.Left(OriginalFile, Len(OriginalFile) - 4) & ".txt"
    '    If System.IO.File.Exists(OriginalFile) Then
    '        System.IO.File.Copy(OriginalFile, NewFile)
    '        System.IO.File.Delete(OriginalFile)
    '        FileSwapperAccess = True
    '    Else
    '        FileSwapperAccess = False
    '    End If

    'End Function
    'Public Function FileSwapperPrevent(ByVal File As String) As Boolean
    '    Dim NewFile As String
    '    Dim OriginalFile As String

    '    NewFile = File
    '    OriginalFile = Microsoft.VisualBasic.Left(NewFile, Len(NewFile) - 4) & ".dat"

    '    If System.IO.File.Exists(NewFile) Then
    '        System.IO.File.Copy(NewFile, OriginalFile)
    '        System.IO.File.Delete(NewFile)
    '        FileSwapperPrevent = True
    '    Else
    '        FileSwapperPrevent = False
    '    End If

    'End Function

    Private Sub RemMan_Click(sender As Object, e As EventArgs) Handles RemMan.Click

        LabManagers.Items.Remove(LabManagers.SelectedItem)

    End Sub

    Private Sub AddMan_Click(sender As Object, e As EventArgs) Handles AddMan.Click

        Dim NewLab As String
        NewLab = InputBox("Please enter the name of the new laboratory.", "Lab Protect - Add Laboratory")
        LabManagers.Items.Add(NewLab)

    End Sub

    Private Sub AddAuth_Click(sender As Object, e As EventArgs) Handles AddAuth.Click

        Dim NewAuth As String
        NewAuth = StrConv(InputBox("Please enter the name of the new Authorisor.", "Lab Protect - Add Authorisor"), vbProperCase)
        Authorisors.Items.Add(NewAuth)

    End Sub

    Private Sub AddS5Man_Click(sender As Object, e As EventArgs)

        Dim NewS5Man As String
        NewS5Man = StrConv(InputBox("Please enter the name of the laboratory manager.", "Lab Protect - Add Laboratory Manager"), vbProperCase)
        S5LabManagers.Items.Add(NewS5Man)

    End Sub

    Private Sub AddBSL3Man_Click(sender As Object, e As EventArgs)

        Dim NewBSL3Man As String
        NewBSL3Man = StrConv(InputBox("Please enter the name of the new BSL3 laboratory manager.", "Lab Protect - Add BSL3 Laboratory Manager"), vbProperCase)
        BSL3LabManagers.Items.Add(NewBSL3Man)

    End Sub

    Private Sub AddPBSL3TU_Click(sender As Object, e As EventArgs) Handles AddPBSL3TU.Click

        Dim NewPBSL3TU As String
        NewPBSL3TU = InputBox("Please enter the name of the new training unit (eg. for example 'MLTU 09').", "Lab Protect - Add Pretraing Unit")
        BSL3PTUs.Items.Add(NewPBSL3TU)

    End Sub

    Private Sub AddBSL3TU_Click(sender As Object, e As EventArgs) Handles AddBSL3TU.Click

        Dim NewBSL3TU As String
        NewBSL3TU = InputBox("Please enter the name of the new training unit (eg. for example 'MLTU 09').", "Lab Protect - Add Training Unit")
        BSL3TUs.Items.Add(NewBSL3TU)

    End Sub

    Private Sub RemS5Labs_Click(sender As Object, e As EventArgs) Handles RemS5Labs.Click

        'confirm if the deletion is intended
        If MsgBox("Deleting this laboratory will delete the entire laboratory and all associated data. This process is not reversible. Are you sure you want to do this?", MsgBoxStyle.YesNo, "Lab Protect - Confirm Laboratory Deletion") = MsgBoxResult.Yes Then
            'remove the item from the comboboxes
            S5Labs.Items.Remove(S5Labs.SelectedItem)
            SelectS5Lab.Items.Remove(S5Labs.SelectedItem)

            'delete the lab folder
            System.IO.Directory.Delete("C:\Users\Dave\Documents\Database\Database Files\Labs\" & S5Labs.SelectedItem.ToString)

            'replace the file without the deleted value
            WriteToAnotherFileWithoutLine("C:\Users\Dave\Documents\Database\Database Files\S5Labs", S5Labs.SelectedItem.ToString)
        Else
            MsgBox("The deletion process has been aborted.", , "Lab Protect - Laboratory Deletion Aborted")
        End If

    End Sub
    Public Function WriteToAnotherFileWithoutLine(ByVal FileToReadFrom As String, ByVal StringToOmit As String) As Boolean

        'set up files and readers
        Dim OldFile As String = FileToReadFrom
        Dim Line As String
        Dim OldFileReader As New System.IO.StreamReader(OldFile & ".txt")
        Dim NewFileWriter As New System.IO.StreamWriter(OldFile & "2.txt")

        'start reading the old file
        Do While Not OldFileReader.EndOfStream
            Line = OldFileReader.ReadLine

            'write each line to a new file, as long as it is not the line-to-be-omitted
            If Not Line = StringToOmit Then
                NewFileWriter.WriteLine(Line)
            End If
        Loop

        'close the streams
        NewFileWriter.Close()
        OldFileReader.Close()

        'replace the old file with the new one
        If ReplaceFiles(OldFile & ".txt", OldFile & "2.txt") Then
        End If

        'assign a value to function
        WriteToAnotherFileWithoutLine = False

    End Function
    Public Function ReplaceFiles(ByVal OldFile As String, ByVal NewFile As String) As Boolean

        'delete the old file
        System.IO.File.Delete(OldFile)

        'copy the new file to the old file location
        System.IO.File.Copy(NewFile, OldFile)

        'delete the file in the new file location
        System.IO.File.Delete(NewFile)

        ReplaceFiles = True
    End Function
    Private Sub AddS5PTU_Click(sender As Object, e As EventArgs) Handles AddS5PTU.Click
        Dim NewS5PTU As String
        NewS5PTU = InputBox("Please enter the name of the new training unit (eg. for example 'MLTU 09').", "Lab Protect - Add Training Unit")
        S5PTU.Items.Add(NewS5PTU)
    End Sub

    Private Sub RemS5PTU_Click(sender As Object, e As EventArgs) Handles RemS5PTU.Click
        S5PTU.Items.Remove(S5PTU.SelectedItem)
    End Sub

    Private Sub AddS5TU_Click(sender As Object, e As EventArgs) Handles AddS5TU.Click
        Dim NewS5TU As String
        NewS5TU = InputBox("Please enter the name of the new training unit (eg. for example 'MLTU 09').", "Lab Protect - Add Training Unit")
        S5TU.Items.Add(NewS5TU)
    End Sub

    Private Sub RemS5TU_Click(sender As Object, e As EventArgs) Handles RemS5TU.Click
        S5TU.Items.Remove(S5TU.SelectedItem)
    End Sub

    Private Sub AddS5Labs_Click(sender As Object, e As EventArgs) Handles AddS5Labs.Click

        'enter the name of laboratory
        Dim NewLab As String
        NewLab = InputBox("Please enter the name of the new Laboratory.", "Lab Protect - Add Laboratory")

        'create a new folder for the laboratory
        System.IO.Directory.CreateDirectory("C:\Users\Dave\Documents\Database\Database Files\Labs\" & NewLab)

        'create a new file for the laboratory
        System.IO.File.Create("C:\Users\Dave\Documents\Database\Database Files\" & NewLab & ".txt")

        'write the name of the laboratory to the S5 folder
        AddLabs(NewLab, "C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt")

        'add the lab to the correct files
        S5Labs.Items.Add(NewLab)
        SelectS5Lab.Items.Add(NewLab)
    End Sub

    Public Function AddLabs(ByVal LabName As String, ByVal HazardLevelFile As String) As Boolean

        'set up the reader
        Dim WriteLab As New System.IO.StreamWriter(HazardLevelFile, True)

        'write the name of the lab
        WriteLab.WriteLine(LabName)

        'wrap up
        WriteLab.Close()

        'return a value
        AddLabs = True

    End Function

    Private Sub AddBSL3Labs_Click(sender As Object, e As EventArgs) Handles AddBSL3Labs.Click

        'enter the name of laboratory
        Dim NewLab As String
        NewLab = InputBox("Please enter the name of the new Laboratory.", "Lab Protect - Add Laboratory")

        'create a new folder for the laboratory
        System.IO.Directory.CreateDirectory("C:\Users\Dave\Documents\Database\Database Files\Labs\" & NewLab)

        'create a new file for the laboratory
        System.IO.File.Create("C:\Users\Dave\Documents\Database\Database Files\" & NewLab & ".txt")

        'write the name of the laboratory to the S5 folder
        AddLabs(NewLab, "C:\Users\Dave\Documents\Database\Database Files\BSL3Labs.txt")

        'add the text to the checked listboxes
        SelectBSL3Lab.Items.Add(NewLab)
        BSL3Labs.Items.Add(NewLab)
    End Sub

    Private Sub RemoveBSL3Lab_Click(sender As Object, e As EventArgs) Handles RemoveBSL3Lab.Click

        'confirm if the deletion is intended
        If MsgBox("Deleting this laboratory will delete the entire laboratory and all associated data. This process is not reversible. Are you sure you want to do this?", MsgBoxStyle.YesNo, "Lab Protect - Confirm Laboratory Deletion") = MsgBoxResult.Yes Then

            'remove the item from the comboboxes
            S5Labs.Items.Remove(BSL3Labs.SelectedItem)
            SelectS5Lab.Items.Remove(BSL3Labs.SelectedItem)

            'delete the lab folder
            System.IO.Directory.Delete("C:\Users\Dave\Documents\Database\Database Files\Labs\" & BSL3Labs.SelectedItem.ToString)

            'replace the file without the deleted value
            WriteToAnotherFileWithoutLine("C:\Users\Dave\Documents\Database\Database Files\BSL3Labs", BSL3Labs.SelectedItem.ToString)
        Else
            MsgBox("The deletion process has been aborted.", , "Lab Protect - Laboratory Deletion Aborted")
        End If

    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        If WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt", S5Labs) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\BSL3Labs.txt", BSL3Labs) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\LabManagers.txt", LabManagers) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\Authorisors.txt", Authorisors) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\S5PTU.txt", S5PTU) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\S5TU.txt", S5TU) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\BSL3PTU.txt", BSL3PTUs) = True And
            WriteToFiles("C:\Users\Dave\Documents\Database\Database Files\BSL3TU.txt", BSL3TUs) = True Then
            MsgBox("Thank you. The necessary files have been updated.", vbOKOnly, "Lab Protect - Setup Complete")
        Else
            MsgBox("Sorry, the files were not updated.", vbOKOnly, "Lab Protect - Setup Incomplete")
        End If

        If System.IO.File.Exists("C:\Users\Dave\Documents\Database\Database Files\OH.txt") Then
            Dim OHWriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\OH.txt", False)
            OHWriter.WriteLine(OHName.Text)
            OHWriter.WriteLine(OHEmail.Text)
            OHWriter.Close()
        Else
            Dim OHWriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\OH.txt", True)
            OHWriter.WriteLine(OHName.Text)
            OHWriter.WriteLine(OHEmail.Text)
            OHWriter.Close()
        End If

    End Sub

    Public Function WriteToFiles(ByVal Filepath As String, ByVal CBox As ListBox)
        Dim Counter As Integer
        Counter = 0

        If System.IO.File.Exists(Filepath) Then
            Dim Streamwriter As New System.IO.StreamWriter(Filepath, False)
            If Not CBox.Items.Count = 0 Then
                For Counter = 0 To CBox.Items.Count - 1
                    Streamwriter.WriteLine(CBox.Items(Counter))
                Next
            Else
                Streamwriter.WriteLine("FALSE")
            End If
            WriteToFiles = True
            Streamwriter.Close()
        Else
            Dim Streamwriter As New System.IO.StreamWriter(Filepath, True)
            If Not CBox.Items.Count - 1 Then
                For Counter = 0 To CBox.Items.Count - 1
                    Streamwriter.WriteLine(CBox.Items(Counter))
                Next
            Else
                Streamwriter.WriteLine("FALSE")
            End If
            WriteToFiles = True
            Streamwriter.Close()
        End If

    End Function

    Public Sub S5Manager_Selected(sender As Object, e As ItemCheckEventArgs) Handles S5LabManagers.ItemCheck
        If Not S5LabManagers.SelectedItem = Nothing Then
            If e.NewValue = CheckState.Checked Then
                Dim Streamwriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\" & SelectS5Lab.SelectedItem.ToString & ".txt", True)
                Streamwriter.WriteLine((S5LabManagers.Items(e.Index)).ToString)
                Streamwriter.Close()
            Else
                System.IO.File.Delete("C:\Users\Dave\Documents\Database\Database Files\" & SelectS5Lab.SelectedItem.ToString & ".txt")
                Dim ManagersArray(S5LabManagers.CheckedItems.Count) As String
                For counter = 0 To S5LabManagers.CheckedItems.Count - 1
                    ManagersArray(counter) = S5LabManagers.Items(counter)
                Next
                For counter = 0 To S5LabManagers.CheckedItems.Count - 1
                    If Not ManagersArray(counter) = S5LabManagers.Items(e.Index).ToString Then
                        Dim Streamwriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\" & SelectS5Lab.SelectedItem.ToString & ".txt", True)
                        Streamwriter.WriteLine(ManagersArray(counter))
                        Streamwriter.Close()
                    End If
                Next
            End If
        End If
    End Sub
    Public Sub BSL3Manager_Selected(sender As Object, e As ItemCheckEventArgs) Handles BSL3LabManagers.ItemCheck
        If Not BSL3LabManagers.SelectedItem = Nothing Then
            If e.NewValue = CheckState.Checked Then
                Dim Streamwriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\" & SelectBSL3Lab.SelectedItem.ToString & ".txt", True)
                Streamwriter.WriteLine((BSL3LabManagers.Items(e.Index)).ToString)
                Streamwriter.Close()
            Else
                System.IO.File.Delete("C:\Users\Dave\Documents\Database\Database Files\" & SelectBSL3Lab.SelectedItem.ToString & ".txt")
                Dim ManagersArray(BSL3LabManagers.CheckedItems.Count) As String
                For counter = 0 To BSL3LabManagers.CheckedItems.Count - 1
                    ManagersArray(counter) = BSL3LabManagers.Items(counter)
                Next
                For counter = 0 To BSL3LabManagers.CheckedItems.Count - 1
                    If Not ManagersArray(counter) = BSL3LabManagers.Items(e.Index).ToString Then
                        Dim Streamwriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\" & SelectBSL3Lab.SelectedItem.ToString & ".txt", True)
                        Streamwriter.WriteLine(ManagersArray(counter))
                        Streamwriter.Close()
                    End If
                Next
            End If
        End If

    End Sub

    Public Sub SelectS5Lab_IndexChanges(sender As Object, e As EventArgs) Handles SelectS5Lab.Click
        'If S5Labs.SelectedValue <> "" Then
        '    ReadFilesForIndiviualabs(SelectS5Lab, S5LabManagers)
        'End If

    End Sub

    Public Function ReadFilesForIndiviualabs(ByVal Labs As ComboBox, ByVal LabManagerbox As CheckedListBox) As Boolean
        'For counter = 0 To LabManagerbox.Items.Count
        '    If LabManagerbox.GetItemCheckState(counter) = True Then
        '        LabManagerbox.SetItemCheckState(counter, CheckState.Unchecked)
        '    End If
        'Next

        'Dim Line As String
        'If System.IO.File.Exists("C:\Users\Dave\Documents\Database\Database Files\" & Labs.Name.ToString & ".txt") Then
        '    Dim Streamreader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\" & Labs.Name.ToString & ".txt")
        '    For counter = 0 To LabManagerbox.Items.Count
        '        Do While Streamreader.EndOfStream <> False
        '            Line = Streamreader.ReadLine
        '            If LabManagerbox.Items.Item(counter).ToString = Line Then
        '                LabManagerbox.SetItemChecked(counter, True)
        '            End If
        '        Loop
        '    Next
        '    Streamreader.Close()
        '    ReadFilesForIndiviualabs = True

        'Else
        '    ReadFilesForIndiviualabs = False
        'End If


    End Function
    Private Sub SetupCancelButton_Click(sender As Object, e As EventArgs) Handles SetupCancelButton.Click
        Me.Close()
    End Sub

    Private Sub RemPBSL3TU_Click(sender As Object, e As EventArgs) Handles RemPBSL3TU.Click
        BSL3TUs.Items.Remove(BSL3TUs.SelectedItems)
    End Sub

    Private Sub RemBSL3TU_Click(sender As Object, e As EventArgs) Handles RemBSL3TU.Click
        BSL3TUs.Items.Remove(BSL3TUs.SelectedItems)
    End Sub

    Public Sub SelectS5Lab_Clicked(sender As Object, e As EventArgs) Handles SelectS5Lab.Click

    End Sub

    Private Sub SelectS5Lab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectS5Lab.SelectedIndexChanged

        'uncheck all managers in the managers list
        For Counter = 0 To S5LabManagers.Items.Count - 1
            S5LabManagers.SetItemCheckState(Counter, CheckState.Unchecked)
        Next

        Dim SelectedLab As String = SelectS5Lab.SelectedItem.ToString
        Dim Line As String

        'check that the lab exists and if it does, check it for the managers
        If System.IO.File.Exists("C:\Users\Dave\Documents\Database\Database Files\" & SelectedLab & ".txt") Then
            MsgBox("exists")
            Dim Streamreader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\" & SelectedLab & ".txt")
            Do While Not Streamreader.EndOfStream
                Line = Streamreader.ReadLine
                For Counter = 0 To S5LabManagers.Items.Count - 1
                    If S5LabManagers.Items(Counter).ToString = Line Then
                        S5LabManagers.SetItemCheckState(Counter, CheckState.Checked)
                    End If
                Next
            Loop
        End If

    End Sub

    Private Sub SelecBSL3Lab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectBSL3Lab.SelectedIndexChanged

        For Counter = 0 To BSL3LabManagers.Items.Count - 1
            BSL3LabManagers.SetItemCheckState(Counter, CheckState.Unchecked)
        Next

        Dim SelectedLab As String = SelectBSL3Lab.GetItemText(SelectBSL3Lab.SelectedIndex)
        Dim Line As String

        If System.IO.File.Exists("C:\Users\Dave\Documents\Database\Database Files\" & SelectedLab & ".txt") Then
            Dim Streamreader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\" & SelectedLab & ".txt")
            Do While Not Streamreader.EndOfStream
                Line = Streamreader.ReadLine
                For Counter = 0 To BSL3LabManagers.Items.Count - 1
                    If BSL3LabManagers.Items(Counter).ToString = Line Then
                        BSL3LabManagers.SetItemCheckState(Counter, CheckState.Checked)
                    End If
                Next
            Loop
        End If

    End Sub

End Class