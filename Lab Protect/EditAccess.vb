Public Class EditData
    Public Sub EditAccessShown(sender As Object, e As EventArgs) Handles Me.Shown
        ImportLabs("C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt", LabsCBox)
        ImportLabs("C:\Users\Dave\Documents\Database\Database Files\BSL3Labs.txt", LabsCBox)
        ImportPeople("C:\Users\Dave\Documents\Database\Database Files\Room 2 Users", SelectName)
        ImportPeople("C:\Users\Dave\Documents\Database\Database Files\BSL3 Users", SelectName)

    End Sub

    Public Function ImportLabs(ByVal LabsFilepath As String, ByVal LabsCombobox As ComboBox) As Boolean

        Dim Streamreader As New System.IO.StreamReader(LabsFilepath)
        Dim Line As String

        Do While Not Streamreader.EndOfStream
            Line = Streamreader.ReadLine()
            LabsCombobox.Items.Add(Line)
        Loop

        Streamreader.Close()
        ImportLabs = True

    End Function
    Public Function ImportPeople(ByVal LabDirectory As String, ByVal NameCombobox As ComboBox) As Boolean

        Dim Line As String
        For Counter = 0 To System.IO.Directory.GetFiles(LabDirectory).Count - 1
            If System.IO.Directory.GetFiles(LabDirectory).Count > 1 And System.IO.File.Exists(LabDirectory & "\User " & Counter + 1) Then
                Dim Streamreader As New System.IO.StreamReader(LabDirectory & "\User " & Counter + 1)
                Do While Not Streamreader.EndOfStream
                    Line = Streamreader.ReadLine()
                    NameCombobox.Items.Add(Line)
                Loop
                Streamreader.Close()
            End If
        Next

        ImportPeople = True

    End Function

    Public Sub LabSelected(sender As Object, e As EventArgs) Handles LabsCBox.SelectedIndexChanged

        'set up the directory path as a string to save time
        Dim LabDirectory As String = "C:\Users\Dave\Documents\Database\Database Files\Labs\" & LabsCBox.SelectedItem.ToString

        'set up for reading the user files
        Dim Line As String

        'locate the folder for the lab
        For counter = 1 To System.IO.Directory.GetFiles(LabDirectory).Count

            'open a reader for each user
            Dim UserReader As New System.IO.StreamReader(LabDirectory & "\User " & counter & ".txt")
            Line = UserReader.ReadLine

            'check the current status
            If Microsoft.VisualBasic.Right(Line, 2) = "-R" Then
                UsersRevoked.Items.Add(Line)
            ElseIf Microsoft.VisualBasic.Right(Line, 2) = "-G" Then
                UsersGranted.Items.Add(Line)
            End If

            UserReader.Close()

        Next

        ''Search for the Lab's BSL Level so that the containing directory can be located
        'Dim Lab As String
        'Dim BSLLevel As String = "0"
        'Dim RoomReader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt")
        'Do While Not RoomReader.endofstream
        '    Lab = RoomReader.ReadLine
        '    If Lab = LabsCBox.SelectedItem.ToString Then
        '        'If found, then Room 2
        '        BSLLevel = "Room 2"
        '        Exit Do
        '    End If
        'Loop
        ''If not found then BSL3
        'If BSLLevel = "0" Then
        '    BSLLevel = "BSL3"
        'End If

        ''Use a streamreader to read the names of the permitted labs.
        'Dim Line As String
        'Dim IterationCounter As Integer = 0

        'For Counter = 0 To System.IO.Directory.GetFiles("C:\Users\Dave\Documents\Database\Database Files\" & BSLLevel & " Users").Count
        '    IterationCounter = IterationCounter + 1
        '    Dim Streamreader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\" & BSLLevel & " Users" & "\User " & Counter)

        '    'Store the users name first
        '    Dim Name As String = Streamreader.ReadLine()
        '    Do While Not Streamreader.EndOfStream
        '        Line = Streamreader.ReadLine()
        '        'If selected lab is found, add to appropriate box
        '        If Line = LabsCBox.SelectedItem.ToString & " -Q-G" Then
        '            UsersGranted.Items.Add(Name)
        '        ElseIf Line = LabsCBox.SelectedItem.ToString + " -Q-G-R" Then
        '            UsersRevoked.Items.Add(Name)
        '        End If

        '    Loop
        '    Streamreader.Close()
        'Next

        'RoomReader.Close()
    End Sub

    Private Sub DoneButton_Click(sender As Object, e As EventArgs) Handles DoneButton.Click

    End Sub

    Private Sub RevokeUser_Click(sender As Object, e As EventArgs) Handles RevokeUser.Click
        Dim LabName As String = LabsCBox.SelectedItem.ToString
        Dim Line As String
        Dim LabFolder As String

        Dim RoomReader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files\S5 Labs.txt")
        Do While Not RoomReader.EndOfStream
            Line = RoomReader.ReadLine
            If Line = LabsCBox.SelectedItem.ToString Then
                LabFolder = "Room 2"
            Else
                LabFolder = "BSL3"
            End If

            For counter = 0 To System.IO.Directory.GetFiles("C:\Users\Dave\Documents\Database\Database Files\" & LabFolder & " Users").Count
                Dim NewStreamReader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files" & LabFolder & " Users\User " & counter)
                Do While Not NewStreamReader.EndOfStream
                    Line = NewStreamReader.ReadLine
                    If Line = LabName Then
                        NewStreamReader.Close()
                        Dim NewStreamWriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files" & LabFolder & " Users\User " & counter)
                        Dim EvenNewerStreamReader As New System.IO.StreamReader("C:\Users\Dave\Documents\Database\Database Files" & LabFolder & " Users\New User " & counter)
                        Do While Not EvenNewerStreamReader.EndOfStream
                            Line = EvenNewerStreamReader.ReadLine
                            If Line = LabName Then
                                NewStreamWriter.Write(Line & " -Q-G-R" & Environment.NewLine)
                            End If
                            NewStreamWriter.WriteLine(Line)
                        Loop
                        NewStreamWriter.WriteLine("Revoked " & DateValue(Now))
                        NewStreamWriter.Close()
                        EvenNewerStreamReader.Close()
                    End If
                Loop
                NewStreamReader.Close()
            Next
        Loop
        RoomReader.Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

    End Sub
End Class