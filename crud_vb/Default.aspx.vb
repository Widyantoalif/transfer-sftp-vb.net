Imports System.IO
Imports System.Data
Imports WinSCP
Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt = ""
        txt = Path.GetFileName(fileupload.FileName)
        Dim path_txt As String = "D:\crud_vb\crud_vb\upload\" & txt
        fileupload.SaveAs(path_txt)
        Try
            ' Setup session options
            Dim sessionOptions As New SessionOptions
            With sessionOptions
                .Protocol = Protocol.Sftp
                .HostName = "192.168.43.65"
                .PortNumber = 20
                .UserName = "tester"
                .Password = "password"
                .SshHostKeyFingerprint = "ssh-rsa 2048 mWmk2n93J1oCfBJVqHZTGzs4GBZFHs2U3by6vEqhf+A="
            End With

            Using session As New WinSCP.Session
                ' Connect
                session.Open(sessionOptions)

                ' Upload files
                Dim transferOptions As New TransferOptions
                transferOptions.TransferMode = TransferMode.Binary

                Dim transferResult As TransferOperationResult
                transferResult =
                    session.PutFiles("D:\crud_vb\crud_vb\upload\*" & txt, "/ddd/", False, transferOptions)

                ' Throw on any error
                transferResult.Check()

                ' Print results
                For Each transfer In transferResult.Transfers
                    Console.WriteLine("Upload of {0} succeeded", transfer.FileName)
                Next
            End Using

        Catch ex As Exception
            Console.WriteLine("Error: {0}", e)

        End Try
    End Sub
End Class