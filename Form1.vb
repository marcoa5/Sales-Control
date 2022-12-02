Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports Microsoft.Office.Interop.Excel

Public Class Form1
    Private myConn As SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Diagnostics.Debugger.IsAttached Then
            Me.Text = "Sales Control Debug Mode"
        Else
            Me.Text = "Sales Control Version " & My.Application.Deployment.CurrentVersion.ToString
        End If

        'Get Field list form SQLserver
        myConn = New SqlConnection("Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=SalesControl;Data Source=IYCSITDB0001;Packet Size=4096;Workstation ID=IYCLITC2D6PQ2")
        myConn.Open()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.CommandText = "60"
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'salescontrolall'"
        cmd.Connection = myConn
        Dim dr As SqlDataReader
        Dim i As Integer
        dr = cmd.ExecuteReader(CommandBehavior.Default)
        Do While dr.Read
            i = Fields.Items.Add(dr("COLUMN_NAME"))
        Loop
        dr = Nothing
        cmd = Nothing
        myConn.Close()
        Button9.PerformClick()

        Inizio.Value = "01/01/" & Year(Now())
        Fine.Value = Now()
        CheckBox3.Checked = True
        IYC.Checked = True
        'GRC.Checked = True
        CheckBox5.Checked = True
        CheckBox6.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Testo As String = "select " & getSelection() & " from ""SalesControl"".""dbo"".""SalesControlAll"" Where TransactionDateISO >= " & Format(Inizio.Value, "yyyyMMdd") & " AND TransactionDateISO <= " & Format(Fine.Value, "yyyyMMdd")
        Dim Env As String = ""
        Dim Con As String = ""
        If IYC.Checked = True Or GRC.Checked = True Or MAP.Checked = True Or MFR.Checked = True Then
            Con = """Environment"" = ''"
            If Me.IYC.Checked = True Then Con += " or ""Environment"" = 'IYC'"
            If Me.GRC.Checked = True Then Con += " or ""Environment"" = 'GRC'"
            If Me.MFR.Checked = True Then Con += " or ""Environment"" = 'MFR'"
            If Me.MAP.Checked = True Then Con += " or ""Environment"" = 'MAP'"
        Else
            Con = """Environment"" = 'IYC'"
        End If
        If Con <> "" Then Testo = Testo & " AND (" & Con & ")"

        Dim SRSI As String = ""
        If CheckBox5.Checked = True And CheckBox6.Checked = False Then SRSI = "SR"
        If CheckBox5.Checked = False And CheckBox6.Checked = True Then SRSI = "SI"
        If SRSI <> "" Then Testo = Testo & " AND ""SR-SI"" = '" & SRSI & "'"

        Dim BL As String = " AND ("
        Dim O As Integer = 0
        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            If O = 0 Then
                BL = BL & """Business Line"" = '" & CheckedListBox1.CheckedItems(i).ToString & "'"
            Else
                BL = BL & " OR ""Business Line"" = '" & CheckedListBox1.CheckedItems(i).ToString & "'"
            End If
            O = 1
        Next
        BL &= ")"
        Testo = Testo & " " & BL

        'Excel
        Dim mEx As Excel.Application
        Dim mWb As Excel.Workbook
        Dim msWb As Excel.Workbooks
        Dim mWs As Excel.Worksheet
        Dim mWs1 As Excel.Worksheet
        mEx = CreateObject("Excel.Application")
        mEx.Visible = True
        msWb = mEx.Workbooks
        mWb = msWb.Add
        mWs = mWb.ActiveSheet
        mWs.Name = "Sales Control"

        mEx.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized
        'Add Connections
        With mWb.PivotCaches.Create(SourceType:=Microsoft.Office.Interop.Excel.XlPivotTableSourceType.xlExternal)
            .Connection = "OLEDB;Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=True;Initial Catalog=SalesControl;Data Source=IYCSITDB0001;Use Procedure for Prepare=1;Auto Translate=True;Packet Size=4096;Workstation ID=IYCLITC2D6PQ2;Use Encryption for Data=False;Tag with column collation when possible=False"
            .CommandText = Testo
            .MaintainConnection = True
            .CreatePivotTable(mWs.Range("A1"), "SC1")
        End With
        For Each Conn In mWb.Connections
            With Conn
                .OLEDBConnection.BackgroundQuery = True
                .OLEDBConnection.RefreshOnFileOpen = True
                .Name = "SalesControl"
                Exit For
            End With

        Next

        'With mWs.PivotTables("SC1").PivotFields("Business Line")
        '.Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlRowField
        '.Position = 1
        '.subtotals(1) = False
        'End With
        'With mWs.PivotTables("SC1").PivotFields("Year")
        '.Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlColumnField
        '.Position = 1
        '.subtotals(1) = False
        'End With
        'mWs.PivotTables("SC1").AddDataField(mWs.PivotTables("SC1").PivotFields("SalesPrice"), "NIS")
        'With mWs.PivotTables("SC1").PivotFields("NIS")
        '.NumberFormat = "#,##0.00 €"
        'End With
        'With mWs.PivotTables("SC1").PivotFields("SR-SI")
        '.Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlColumnField
        '.Position = 2
        '.subtotals(1) = False
        'End With
        'If (Me.IYC.Checked = True And Me.GRC.Checked = False) Or (Me.IYC.Checked = False And Me.GRC.Checked = True) Then
        'Else
        '
        'With mWs.PivotTables("SC1").PivotFields("Environment")
        '.Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlPageField
        '.Position = 1
        'End With
        'End If
        mWs.PivotTables("SC1").RowAxisLayout(Microsoft.Office.Interop.Excel.XlLayoutRowType.xlTabularRow)
        mWs.PivotTables("SC1").RepeatAllLabels(Microsoft.Office.Interop.Excel.XlPivotFieldRepeatLabels.xlRepeatLabels)



        With mWs.PivotTables("SC1")
            .ColumnGrand = True
            .RowGrand = False
        End With

        mWs.PivotTables("SC1").HasAutoFormat = False
        mWs.Cells.ColumnWidth = 15

        'OOH

        If Me.OOH.Checked = True Then
            mWs1 = mWb.Sheets.Add(, mWs)
            mWs1.Name = "OOH"
            With mWb.PivotCaches.Create(SourceType:=Microsoft.Office.Interop.Excel.XlPivotTableSourceType.xlExternal)
                .Connection = "OLEDB;DRIVER=SQL Server;SERVER=IYCSITDB0001;UID=ssccg;Trusted_Connection=Yes;APP=Microsoft Office 2016;WSID=SSILITD49GHC2;DATABASE=SalesControl"
                If IYC.Checked = True Or GRC.Checked = True Or MAP.Checked = True Or MFR.Checked = True Then
                    Con = "SELECT * FROM SalesControl.dbo.OOHAll where ""Environment"" = ''"
                    If Me.IYC.Checked = True Then Con += " or ""Environment"" = 'IYC'"
                    If Me.GRC.Checked = True Then Con += " or ""Environment"" = 'GRC'"
                    If Me.MFR.Checked = True Then Con += " or ""Environment"" = 'MFR'"
                    If Me.MAP.Checked = True Then Con += " or ""Environment"" = 'MAP'"
                Else
                    Con = "SELECT * FROM SalesControl.dbo.OOHAll where ""Environment"" = 'IYC'"
                End If


                .CommandText = Con & BL
                .MaintainConnection = True
                .CreatePivotTable(mWs1.Range("A1"), "OOH1")
            End With
            For Each Conn In mWb.Connections
                If Conn.name <> "SalesControl" Then
                    With Conn
                        .OLEDBConnection.BackgroundQuery = True
                        .OLEDBConnection.RefreshOnFileOpen = True
                        .Name = "SalesControlOOH"
                        Exit For
                    End With
                End If
            Next
            With mWs1.PivotTables("OOH1").PivotFields("Business Line")
                .Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlRowField
                .Position = 1
                .subtotals(1) = False
            End With
            mWs1.PivotTables("OOH1").AddDataField(mWs1.PivotTables("OOH1").PivotFields("TotalSalesPrice"), "NIS")
            With mWs1.PivotTables("OOH1").PivotFields("NIS")
                .NumberFormat = "#,##0.00 €"
            End With
            With mWs1.PivotTables("OOH1").PivotFields("Environment")
                .Orientation = Microsoft.Office.Interop.Excel.XlPivotFieldOrientation.xlPageField
                .Position = 1
                .subtotals(1) = False
            End With
            mWs1.PivotTables("OOH1").RowAxisLayout(Microsoft.Office.Interop.Excel.XlLayoutRowType.xlTabularRow)
            mWs1.PivotTables("OOH1").RepeatAllLabels(Microsoft.Office.Interop.Excel.XlPivotFieldRepeatLabels.xlRepeatLabels)
            With mWs1.PivotTables("OOH1")
                .ColumnGrand = True
                .RowGrand = False
            End With
            mWs1.PivotTables("OOH1").HasAutoFormat = False
            mWs1.Cells.ColumnWidth = 15
        End If

        mWs.Select()
        Me.Close()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox3.Checked = False
        For I As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.Items.Item(I) = "SED" Or CheckedListBox1.Items.Item(I) = "URE" Or CheckedListBox1.Items.Item(I) = "RDT" Or CheckedListBox1.Items.Item(I) = "REX" Or CheckedListBox1.Items.Item(I) = "RGU" Or CheckedListBox1.Items.Item(I) = "MRS" Then
                CheckedListBox1.SetItemChecked(I, True)
            Else
                CheckedListBox1.SetItemChecked(I, False)
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim I As New System.DateTime(Year(Now()), 1, 1)
        Inizio.Value = I
        Dim F As New System.DateTime(Year(Now()), 12, 31)
        Fine.Value = F
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim mese As Integer = Month(Now())
        Dim Giorno As Integer = 0
        Select Case mese
            Case 11, 4, 6, 9
                Giorno = 30
            Case 2
                Giorno = 28
            Case 1, 3, 5, 7, 8, 10, 12
                Giorno = 31
        End Select

        Dim I As New System.DateTime(Year(Now()), Month(Now()), 1)
        Inizio.Value = I
        Dim F As New System.DateTime(Year(Now()), Month(Now()), Giorno)
        Fine.Value = F
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim I As New System.DateTime(Year(Now()) - 1, 1, 1)
        Inizio.Value = I
        Dim F As New System.DateTime(Year(Now()), 12, 31)
        Fine.Value = F
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim I As New System.DateTime(Year(Now()), Month(Now()), DateAndTime.Day(Now()) - 1)
        Inizio.Value = I
        Fine.Value = I
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        For i As Integer = 0 To Fields.Items.Count - 1
            Fields.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim list = New String() {"SR-SI", "OrderNumber", "InvoiceNumber", "TransactionDate", "CustomerCode", "CustomerName", "ItemNumber", "ItemDescription", "CurrentPGC", "CurrentGAC", "Business Line", "Quantity", "SalesCost", "SalesPrice", "SAM", "SAMName", "ShipTo", "Environment", "TransactionDateISO", "CurrentGACDescription", "CurrentPGCDescription", "Country", "ActivityCode", "SalesChannel", "SalesChannelType"}
        selectItem(list)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim list = New String() {"SR-SI", "TransactionDate", "CustomerName", "ItemNumber", "ItemDescription", "CurrentGAC", "Business Line", "Quantity", "SalesCost", "SalesPrice", "Environment", "TransactionDateISO", "CurrentGACDescription", "ActivityCode"}
        selectItem(list)
    End Sub

    Private Sub selectItem(list As String())
        For i As Integer = 0 To Fields.Items.Count - 1
            If list.Contains(Fields.Items(i)) Then
                Fields.SetItemChecked(i, True)
            Else
                Fields.SetItemChecked(i, False)
            End If
        Next
    End Sub

    Private Function getSelection() As String
        Dim res1 As New List(Of String)
        For i As Integer = 0 To Fields.Items.Count - 1
            If Fields.GetItemChecked(i) = True Then res1.Add(Fields.Items(i))
        Next
        Dim str As String = ""
        If res1.Count > 0 Then
            For Each y In res1
                If str = "" Then
                    str += "[" & y & "]"
                Else
                    str += ",[" & y & "]"
                End If
            Next
        Else
            str = "*"
        End If
        Return str
    End Function

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Console.WriteLine(getSelection())
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        For i As Integer = 0 To Fields.Items.Count - 1
            Fields.SetItemChecked(i, False)
        Next
    End Sub
End Class