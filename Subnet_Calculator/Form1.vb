Public Class Form1

    Private Sub CalculateNetworkID()
        Try
            Dim ip() As String = txtIP.Text.Split(".")
            Dim numIP() As Integer
            ReDim numIP(ip.Length - 1)

            For i As Integer = 0 To ip.Length - 1
                numIP(i) = CInt(ip(i))
            Next

            Dim subnet() As String = txtSubnet.Text.Split(".")
            Dim numSN() As Integer
            ReDim numSN(subnet.Length - 1)

            For i As Integer = 0 To subnet.Length - 1
                numSN(i) = CInt(subnet(i))
            Next


            Dim netID() As Integer
            ReDim netID(subnet.Length - 1)

            For i As Integer = 0 To netID.Length - 1
                netID(i) = numIP(i) And numSN(i)
            Next

            Dim resNetID As String = netID(0) & "." & netID(1) & "." & netID(2) & "." & netID(3)
            Label1.Text = resNetID
            lblNetID.Text = CalcBinaryIP(resNetID)
        Catch ex As Exception

        End Try
    End Sub

    Private Function CalcBinaryIP(ByVal Expression As String) As String
        Try
            Dim ip() As String = Expression.Split(".")
            Dim numIP() As String
            ReDim numIP(ip.Length - 1)

            For i As Integer = 0 To ip.Length - 1
                numIP(i) = Dec2Bin(CInt(ip(i)))
            Next

            Return numIP(0) & " " & numIP(1) & " " & numIP(2) & " " & numIP(3)
        Catch ex As Exception
        End Try
    End Function

    Private Sub txtIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIP.TextChanged
        CalculateNetworkID()
        lblIP.Text = CalcBinaryIP(txtIP.Text)
    End Sub

    Private Sub txtSubnet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubnet.TextChanged
        CalculateNetworkID()
        lblSubnet.Text = CalcBinaryIP(txtSubnet.Text)
    End Sub

    Private Function Dec2Bin(ByVal Expression As Integer) As String
        Dim rtnStr As String = ""

        Do While Expression > 1
            rtnStr &= Expression Mod 2
            Expression \= 2
        Loop

        rtnStr &= Expression
        rtnStr = StrReverse(rtnStr)
        rtnStr = Format(CLng(rtnStr), "00000000")

        Return rtnStr
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
