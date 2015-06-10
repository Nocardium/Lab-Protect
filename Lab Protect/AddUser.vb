Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic

Public Class AddUser

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles Me.Shown

        'import the relevant data into the boxes
        ReadData("C:\Users\Dave\Documents\Database\Database Files\S5Labs.txt", AccessRequested)
        ReadData("C:\Users\Dave\Documents\Database\Database Files\BSL3Labs.txt", BSL3Access)
        ReadData("C:\Users\Dave\Documents\Database\Database Files\S5PTU.txt", TrainingCompleted)
        ReadData("C:\Users\Dave\Documents\Database\Database Files\BSL3PTU.txt", BSL3Training)

    End Sub

    Public Function ReadData(ByVal Filepath As String, ByVal Box As CheckedListBox) As Boolean

        Dim ReadComplete As Boolean
        ReadComplete = False

        'check that the file exists
        If System.IO.File.Exists(Filepath) Then

            'set up the stream reader
            Dim Streamreader As New System.IO.StreamReader(Filepath)
            Dim Line As String

            'import the data from the file
            Do While Streamreader.EndOfStream = False
                Line = Streamreader.ReadLine
                With Box
                    .Items.Add(Line)
                End With
            Loop
        End If

        'return the completion value
        If ReadComplete = True Then
            ReadData = True
        Else
            ReadData = False
        End If

    End Function

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        'check for a checked item before running the writer function
        Dim WasChecked As Boolean = False
        For counter = 0 To AccessRequested.Items.Count - 1
            If AccessRequested.GetItemCheckState(counter) = CheckState.Checked Then
                WasChecked = True
                Exit For
            End If
        Next

        'run writefiles
        If WriteFiles(AccessRequested, TrainingCompleted, False, EmployeeName.Text, ManagerName.Text) = True Then

        End If

        'reset the boolean
        WasChecked = False

        'check bsl3 has a checked item
        For counter = 0 To BSL3Access.Items.Count - 1
            If BSL3Access.GetItemCheckState(counter) = CheckState.Checked Then
                WasChecked = True
                Exit For
            End If
        Next

        'run writefiles
        If WriteFiles(BSL3Access, BSL3Training, True, EmployeeName.Text, ManagerName.Text) = True Then

        End If

    End Sub

    Public Function WriteFiles(ByVal LabCListbox As CheckedListBox, ByVal PTUsCListbox As CheckedListBox, ByVal CListboxIsBSL3 As Boolean, ByVal Name As String, ByVal Manager As String) As Boolean

        'record the number the user will be
        Dim AllUsersNumber As Long = System.IO.Directory.GetFiles("C:\Users\Dave\Documents\Database\Database Files\All Users").Count + 1
        
        'interpret the room level
        If CListboxIsBSL3 = True Then
            Dim LabType As String = "BSL3"
        Else
            Dim LabType As String = "Room 2"
        End If

        'loop through all items in the box
        For counter = 0 To LabCListbox.Items.Count


            'check if the items are selected
            If LabCListbox.GetItemCheckState(counter) = CheckState.Checked Then

                'if they are create them a new file in the All Users folder
                Dim AllUsersWriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\All Users\User " & AllUsersNumber, True)
                AllUsersWriter.WriteLine(Name)
                AllUsersWriter.WriteLine(Manager)

                'write all the labs that they are requesting and mark it as such
                For counter1 = 0 To LabCListbox.SelectedItems.Count
                    AllUsersWriter.WriteLine(LabCListbox.SelectedItems(counter1).ToString & "-Q")
                Next

                AllUsersWriter.Close()

                'record what user number they are within the lab
                Dim LabUserNumber As Long = System.IO.Directory.GetFiles("C:\Users\Dave\Documents\Database\Database Files\Labs\" & LabCListbox.Items(counter).ToString).Count + 1

                'create them a new file in the lab's folder
                Dim LabFolderWriter As New System.IO.StreamWriter("C:\Users\Dave\Documents\Database\Database Files\Labs\" & LabCListbox.Items(counter).ToString & "\User " & LabUserNumber, True)
                LabFolderWriter.WriteLine(Name)
                LabFolderWriter.WriteLine(Manager)
                LabFolderWriter.WriteLine(AllUsersNumber)

                'write the relevent training
                For counter1 = 0 To PTUsCListbox.Items.Count
                    Dim TrainingComplete As Boolean
                    If PTUsCListbox.GetItemCheckState(counter1) = CheckState.Checked Then
                        TrainingComplete = True
                    Else
                        TrainingComplete = False
                    End If
                    LabFolderWriter.WriteLine(PTUsCListbox.Items(counter1).ToString & " " & TrainingComplete)
                Next

                'write the specific lab name
                LabFolderWriter.WriteLine(LabCListbox.Items(counter).ToString)

                'write todays date
                LabFolderWriter.WriteLine(DateValue(Now).ToString)

                'close the writer
                LabFolderWriter.Close()
            End If
        Next

        'wrap up
        Return True

    End Function
    Public Function Writelistboxes(ByVal Streamwriter As StreamWriter, ByVal TrainingCLB As CheckedListBox, ByVal RequestCLB As CheckedListBox) As Boolean

        Dim WasWrittenTo As String
        WasWrittenTo = False

        Streamwriter.WriteLine(EmployeeName.Text)
        Streamwriter.WriteLine(ManagerName.Text)

        Dim counter As Integer
        For counter = 0 To TrainingCLB.Items.Count - 1
            If TrainingCLB.GetItemCheckState(counter) = CheckState.Checked Then
                WasWrittenTo = True
                Streamwriter.Write(TrainingCLB.Items(counter).ToString & " True" & ControlChars.Lf)
            Else
                Streamwriter.Write(TrainingCLB.Items(counter).ToString & " False" & ControlChars.Lf)
            End If
        Next

        For counter = 0 To RequestCLB.Items.Count - 1
            If RequestCLB.GetItemCheckState(counter) = CheckState.Checked Then
                WasWrittenTo = True
                Streamwriter.Write(TrainingCLB.Items(counter).ToString & " True" & ControlChars.Lf)
            Else
                Streamwriter.Write(TrainingCLB.Items(counter).ToString & " False" & ControlChars.Lf)
            End If
        Next

        Writelistboxes = WasWrittenTo

    End Function
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class

Public Class RoomUser
    Public Name As String
    Public Manager As String
    Public OHApprove As String
    Public TrainedBy As String
    Public TrainedOn As String
    Public GrantedOn As String
    Public TrAsTr As String
    Public FinalSignOff As String
    Public Revoked As String
    Public ReInstated As String
    Public ReRevoked As String
    Public Sub SetManager(ByVal Value As String)
        Manager = Value
    End Sub
    Public Sub SetName(ByVal Value As String)
        Name = Value
    End Sub
    Public Sub SetOHApprove(ByVal Value As String)
        OHApprove = Value
    End Sub
    
    Public Sub SetTrainedBy(ByVal Value As String)
        TrainedBy = Value
    End Sub
    Public Sub SetTrainedOn(ByVal Value As String)
        TrainedOn = Value
    End Sub
    Public Sub SetGrantedOn(ByVal Value As String)
        GrantedOn = Value
    End Sub
    Public Sub SetTrAsTr(ByVal Value As Boolean)
        If Value = True Then
            TrAsTr = "Trained"
        Else
            TrAsTr = "Not trained"
        End If
    End Sub
    Public Sub SetRevoked(ByVal Value As String)
        Revoked = Value
    End Sub
    Public Sub SetReInstated(ByVal Value As String)
        ReInstated = Value
    End Sub
    Public Sub SetReRevoked(ByVal Value As String)
        ReRevoked = Value
    End Sub
    Public Sub SetfinalSignOff(ByVal Value As Boolean)
        If Value = True Then
            FinalSignOff = "Approved"
        Else
            FinalSignOff = "Not Approved"
        End If
    End Sub
End Class