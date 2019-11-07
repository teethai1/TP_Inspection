Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmMain

    'Private m_keyborad As FrmKeyBoard
    Private m_Numpad As NumPadForm
    Dim TotalNG As Integer
    Dim InputQty As Integer
    Dim totalGood
    Dim YLD As Double
    Dim StatusLot As String 'Input Lot , Inspection , GL Confirm , LotSet
    Dim TimeReq As String
    Dim Urgentlot As Boolean
    Dim Lotjodg As String
    Dim Remark As String
    Dim CheckOldData As Boolean   'Odd=true and New = false  
    Dim m_TpInsp As DBxDataSet.TPINSDataRow
    Public m_OfflineMode As String
    Dim HeaderMCNo As String = Environment.MachineName
    Dim _ipServer As String = "172.16.0.100"
    Dim BeginApp As Boolean = False


    Private Sub BtMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtExit2.Click
        If MessageBox.Show("คุณต้องการออกจากโปรแกรม ?", "Do you want to exit program ?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub lbsetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbsetting.Click
        ContextMenuStrip1.Show(lbsetting, New Point(0, lbsetting.Height))
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbTime.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub btInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btInput.Click

        frmInputQR.Caption = "SCAN QR CODE"
        If frmInputQR.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim QR As String = frmInputQR.QRCode.ToUpper
            Dim OPNo As String = frmInputQR.QROpNo
            Dim Package As String = Trim(QR.Substring(0, 10))
            Dim Device As String = Trim(QR.Substring(10, 20))
            Dim LotNo As String = Trim(QR.Substring(30, 10))
            Dim Rank As String = Trim(QR.Substring(82, 3))
            TimeReq = Format(Now, "yyyy/MM/dd HH:mm:ss")

            Dim CheckData As Boolean = FindDataLot(LotNo)



            If CheckData = False Then
                Dim MC As String
                If FrmSelectMC.ShowDialog = Windows.Forms.DialogResult.OK Then
                    MC = FrmSelectMC.InputMC
                Else
                    Exit Sub
                End If
                ClearAll()
                lbMC.Text = MC
                lbPackage.Text = Package
                lbDevice.Text = Device
                lbLot.Text = LotNo
                lbOP.Text = OPNo
                lbTPRank.Text = Rank
                StatusLot = "Input Lot"
                Status(StatusLot)
                CheckOldData = False
                AddComLog("InputLot:" & MC & "," & LotNo & "," & OPNo)
            Else
                lbPackage.Text = Package
                lbDevice.Text = Device
                lbTPRank.Text = Rank
                CheckOldData = True
            End If
          

        End If

    End Sub
    Private Function FindDataLot(ByVal lot As String) As Boolean
        Dim ret As Boolean = False
        Dim LotNo As String = lot
        For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
            If row.LotNo = LotNo AndAlso row.IsInspectorNoNull = True AndAlso row.IsLotJudgNull = True Then
                ClearAll()
                SetPara(row)
                lbStart.BackColor = Color.Lime
                StatusLot = "Inspection"
                Status(StatusLot)
                'MsgBox("status Start")
                AddComLog("Insp Login," & frmInputQR.QROpNo & "," & lbMC.Text & "," & lbLot.Text & "," & lbOP.Text & "," & "Req," & SelectInspDefect(True, cbbReq1.Text) & "," & SelectInspDefect(True, cbbReq2.Text) & "," & SelectInspDefect(True, cbbReq3.Text) & "," & SelectInspDefect(True, cbbReq4.Text) & "," & "Urgent," & rdYes.Checked)
                ret = True
            ElseIf row.LotNo = LotNo AndAlso row.IsInspectorNoNull = False AndAlso row.IsLotJudgNull = True Then
                'MsgBox("status Insp")
                ClearAll()
                SetPara(row)
                lbStart.BackColor = Color.Lime
                StatusLot = "GL Confirm"
                Status(StatusLot)

                Dim strlog As String
                strlog = "GL Login," & frmInputQR.QROpNo & "," & lbMC.Text & "," & lbLot.Text & "," & lbOP.Text & ",InspNo," & tbInspcNo.Text & "," _
                & tbInput.Text & "," & lbNGtotal.Text & "," & lbGood.Text & "," & lbYLD.Text & "," & "NGmode," _
                & SelectInspDefect(False, cbbNG1.Text) & " " & tbNG1.Text & "," & SelectInspDefect(False, cbbNG2.Text) & " " _
                & tbNG2.Text & "," & SelectInspDefect(False, cbbNG3.Text) & " " & tbNG3.Text & "," & SelectInspDefect(False, cbbNG4.Text) _
                & " " & tbNG4.Text & "," & SelectInspDefect(False, cbbNG5.Text) & " " & tbNG5.Text
                AddComLog(strlog)

                ret = True
            End If
        Next
        Return ret
    End Function
    Private Sub SetPara(ByVal row As DBxDataSet.TPINSDataRow)
        lbLot.Text = row.LotNo
        lbStart.Text = row.StartTime
        cbbReq1.Text = row.ReqMode1
        cbbReq2.Text = row.ReqMode2
        cbbReq3.Text = row.ReqMode3
        cbbReq4.Text = row.ReqMode4
        lbOP.Text = row.OPNo
        lbMC.Text = row.MCNo
        If row.UrgentLot = True Then
            rdYes.Checked = True
        Else
            rdNo.Checked = True
        End If

        If row.IsNGMode1Null = False Then
            Dim DataSplit() As String = row.NGMode1.Split(",")
            cbbNG1.Text = DataSplit(0)
            tbNG1.Text = DataSplit(1)
        End If
        If row.IsNGMode2Null = False Then
            Dim DataSplit() As String = row.NGMode2.Split(",")
            cbbNG2.Text = DataSplit(0)
            tbNG2.Text = DataSplit(1)
        End If
        If row.IsNGMode3Null = False Then
            Dim DataSplit() As String = row.NGMode3.Split(",")
            cbbNG3.Text = DataSplit(0)
            tbNG3.Text = DataSplit(1)
        End If
        If row.IsNGMode4Null = False Then
            Dim DataSplit() As String = row.NGMode4.Split(",")
            cbbNG4.Text = DataSplit(0)
            tbNG4.Text = DataSplit(1)
        End If

        If row.IsNGMode5Null = False Then
            Dim DataSplit() As String = row.NGMode5.Split(",")
            cbbNG5.Text = DataSplit(0)
            tbNG5.Text = DataSplit(1)
        End If
        If row.IsInspQtyNull = False Then
            tbInput.Text = row.InspQty
        End If
        If row.IsNGQtyNull = False Then
            lbNGtotal.Text = row.NGQty
        End If
        If row.IsGoodQtyNull = False Then
            lbGood.Text = row.GoodQty
        End If
        If row.IsFinalYieldNull = False Then
            lbYLD.Text = row.FinalYield
        End If
        If row.IsInspectorNoNull = False Then
            tbInspcNo.Text = row.InspectorNo
        End If
    End Sub
    Private Sub AddBeforetoTable(ByVal lotNo As String)
        If CheckOldData = False Then
            Dim newRow As DBxDataSet.TPINSDataRow = DBxDataSet.TPINSData.NewTPINSDataRow()
            m_TpInsp = newRow
            If m_TpInsp IsNot Nothing Then
                m_TpInsp.LotNo = lbLot.Text
                m_TpInsp.MCNo = lbMC.Text
                m_TpInsp.OPNo = lbOP.Text
                m_TpInsp.StartTime = lbStart.Text
                m_TpInsp.ReqDate = TimeReq
                m_TpInsp.ReqMode1 = SelectInspDefect(True, cbbReq1.Text)
                m_TpInsp.ReqMode2 = SelectInspDefect(True, cbbReq2.Text)
                m_TpInsp.ReqMode3 = SelectInspDefect(True, cbbReq3.Text)
                m_TpInsp.ReqMode4 = SelectInspDefect(True, cbbReq4.Text)
                m_TpInsp.UrgentLot = Urgentlot
            End If
            DBxDataSet.TPINSData.Rows.Add(m_TpInsp)
        Else
            For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
                If row.LotNo = lbLot.Text AndAlso row.StartTime = lbStart.Text Then
                    ClearAll()
                    FindDataLot(LotNo)
                End If
            Next
        End If
    End Sub
    Private Function SelectInspDefect(ByVal ModeBefore As Boolean, ByVal data As String) As String
        Dim DataMode As String = data
        If data = "" Then
            Return data
            Exit Function
        End If
        If ModeBefore = True Then
            Select Case data
                Case "IC Missing"
                    DataMode = "Icmissi"
                Case "Type Change"
                    DataMode = "TypeCha"
                Case "Poried Check"
                    DataMode = "Period"
                Case "Stamp NG"
                    DataMode = "Stamp"
                Case "Mold Chip"
                    DataMode = "MoldChi"
                Case "IC Miss Pocket"
                    DataMode = "Overlap"
                Case "Dubble IC"
                    DataMode = "DubbleI"
                Case "Q'ty"
                    DataMode = "Q'ty"
                Case "Lead Defect"
                    DataMode = "LeadDef"
                Case "Material NG"
                    DataMode = "Materia"
                Case "Marking NG"
                    DataMode = "Marking"
                Case "IC Gap"
                    DataMode = "IC gap"
                Case "Inspection 100%"
                    DataMode = "Ins100%"
                Case "Other"
                    DataMode = "Other"
            End Select
        Else
            Select Case data
                Case "No NG"
                    DataMode = "No NG"
                Case "Q'ty Miss(-)"
                    DataMode = "Q'ty-"
                Case "Q'ty Miss(+)"
                    DataMode = "Q'ty+"
                Case "Stamp NG"
                    DataMode = "Stamp"
                Case "Mold Chip"
                    DataMode = "MoldChi"
                Case "Mijuten"
                    DataMode = "Mijute"
                Case "IC Miss Pocket"
                    DataMode = "Overla"
                Case "Dubble IC"
                    DataMode = "Dubble"
                Case "Lead NG"
                    DataMode = "LeadNG"
                Case "Soder Bari"
                    DataMode = "SoBari"
                Case "Lead Hige"
                    DataMode = "Hige"
                Case "Emboss NG"
                    DataMode = "MatNG"
                Case "Cover Tape NG"
                    DataMode = "MatNG"
                Case "Marking NG"
                    DataMode = "Markin"
                Case "IC Gap"
                    DataMode = "IC gap"
                Case "Misorientation"
                    DataMode = "Misori"
                Case "Other"
                    DataMode = "Other"
            End Select
        End If
        Return DataMode
    End Function

    Private Sub Status(ByVal dataStatatus As String)
        Select Case dataStatatus
            Case "Input Lot"
                btStart.Enabled = True
                gbInspResult.Enabled = False
                gbGL.Enabled = False
                btEnd.Enabled = False
                gbBefore.Enabled = True
                For Each ctr As Control In gbBefore.Controls
                    If TypeOf ctr Is ComboBox Then
                        ctr.BackColor = Color.Yellow
                    ElseIf TypeOf ctr Is RadioButton Then
                        ctr.BackColor = Color.Yellow
                    End If
                Next
                If cbbNG1.BackColor = Color.Yellow Then
                    For Each ctr As Control In gbInspResult.Controls
                        If TypeOf ctr Is ComboBox Then
                            ctr.BackColor = DefaultBackColor
                        ElseIf TypeOf ctr Is TextBox Then
                            ctr.BackColor = DefaultBackColor
                        End If
                    Next
                End If
            Case "Inspection"
                For Each ctr As Control In gbBefore.Controls
                    If TypeOf ctr Is ComboBox Then
                        ctr.BackColor = DefaultBackColor
                    ElseIf TypeOf ctr Is RadioButton Then
                        ctr.BackColor = Color.Transparent
                    End If
                Next
                For Each ctr As Control In gbInspResult.Controls
                    If TypeOf ctr Is ComboBox Then
                        ctr.BackColor = Color.Yellow
                    ElseIf TypeOf ctr Is TextBox Then
                        ctr.BackColor = Color.Yellow
                    End If
                Next
                tbGL.BackColor = Color.White
                cbbLotJudge.BackColor = Color.White
                gbBefore.Enabled = False
                gbGL.Enabled = False
                btStart.Enabled = False
                btEnd.Enabled = False
                gbInspResult.Enabled = True
            Case "GL Confirm"
                For Each ctr As Control In gbInspResult.Controls
                    If TypeOf ctr Is ComboBox Then
                        ctr.BackColor = DefaultBackColor
                    ElseIf TypeOf ctr Is TextBox Then
                        ctr.BackColor = DefaultBackColor
                    End If
                Next
                cbbLotJudge.BackColor = Color.Yellow
                tbGL.BackColor = Color.Yellow
                gbInspResult.Enabled = False
                btStart.Enabled = False
                gbGL.Enabled = True
                btEnd.Enabled = True
            Case "LotSet"
                tbGL.BackColor = Color.White
                cbbLotJudge.BackColor = Color.White
                gbBefore.Enabled = False
                btStart.Enabled = False
                btEnd.Enabled = False
                gbGL.Enabled = False
                gbInspResult.Enabled = False
        End Select
    End Sub

    Private Sub tbNG1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbNG5.Enter, tbNG1.Enter, tbNG2.Enter, tbNG3.Enter, tbNG4.Enter, tbInput.Enter, tbInspcNo.Enter
        Dim tb As TextBox = CType(sender, TextBox)
        If tb.Name = "tbInspcNo" AndAlso m_Numpad.Visible = True Then
            m_Numpad.Visible = False
            Exit Sub
        ElseIf tb.Name = "tbInspcNo" Then
            Exit Sub
        End If
        m_Numpad.TargetTextBox = tb
        If Not m_Numpad.Visible Then
            m_Numpad.Show(Me)
            m_Numpad.Left = Me.Right - 500
            m_Numpad.Top = Me.Bottom - 320
        End If
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If BeginApp = True Then
            Exit Sub
        Else
            SaveDataLotBin()
        End If

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim processesSelfCon As Process() = Process.GetProcessesByName("SelfCon")
        If processesSelfCon.Length > 1 Then
            BeginApp = True
            Application.Exit()
        Else
            BeginApp = False
        End If


        Dim processes As Process() = Process.GetProcessesByName("machine")

        If processes.Length = 0 Then
            Me.m_TDCProcess = Process.Start(My.Application.Info.DirectoryPath & "\Modules\TDC\machine.exe")
            m_TDCProcess.WaitForInputIdle(My.Settings.TDCWaitTimeOut)
        Else
            m_TDCProcess = processes(0)
        End If

        m_Numpad = New NumPadForm()
        TPINSDataTableAdapter.ClearBeforeFill = False
        LoadDataLotBin()
        CountListData()
        Status("LotSet")
        StatusOnline(Config_Get(My.Application.Info.DirectoryPath & "\Mode.txt"))

    End Sub

    Private Sub StatusOnline(ByVal M As String)
        m_OfflineMode = M
        lbStatus.Text = m_OfflineMode
        If m_OfflineMode = "Online" Then
            lbStatus.BackColor = Color.Lime
        Else
            lbStatus.BackColor = Color.Red
        End If
    End Sub
    Private Sub btBefore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btStart.Click
        Dim CheckRadio As Boolean = False
        Dim CheckCombo As Boolean = False
        For Each ctl As Control In gbBefore.Controls
            If TypeOf ctl Is RadioButton Then
                Dim ctlrd As RadioButton = ctl
                If ctlrd.Checked = True Then
                    CheckRadio = True
                End If
            ElseIf TypeOf ctl Is ComboBox And ctl.Text <> "" Then
                CheckCombo = True
            End If
        Next
        If CheckCombo = True AndAlso CheckRadio = True Then
            lbStart.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
            If rdNo.Checked <> False Then
                Urgentlot = False
            Else
                Urgentlot = True
            End If
            lbStart.BackColor = Color.Lime
            ltBefore.Items.Add(lbLot.Text)
            StatusLot = "Inspection"
            Status(StatusLot)
            AddBeforetoTable(lbLot.Text)
            SaveDataLotBin()
            AddComLog("Insp:" & lbMC.Text & "," & lbLot.Text & lbOP.Text & "," & "Req," & SelectInspDefect(True, cbbReq1.Text) & "," & SelectInspDefect(True, cbbReq2.Text) & "," & SelectInspDefect(True, cbbReq3.Text) & "," & SelectInspDefect(True, cbbReq4.Text) & "," & "Urgent," & rdYes.Checked)
            If m_OfflineMode = "Online" Then
                SendPostMessage("@LOTREQ" & "|" & HeaderMCNo & "|" & lbLot.Text & "," & lbOP.Text & ",00")   'Normal
            End If
            CountListData()
        ElseIf CheckCombo = False Then
            MsgBox("กรุณาเลือก Request Inspection !")
        ElseIf CheckRadio = False Then
            MsgBox("กรุณาเลือก Urgent lot")
        End If

    End Sub
    Public Sub CountListData()
        ltBefore.Items.Clear()
        ltWaitGL.Items.Clear()
        ltUrgent.Items.Clear()
        Dim countUpdate As Integer = 0
        Dim count As Integer = 0
        For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
            If row.LotNo <> "" AndAlso row.IsInspectorNoNull = True AndAlso row.UrgentLot = False Then
                ltBefore.Items.Add(row.LotNo)
                count += 1
            ElseIf row.LotNo <> "" AndAlso row.IsInspectorNoNull = True AndAlso row.UrgentLot = True Then
                ltUrgent.Items.Add(row.LotNo)
                count += 1
            ElseIf row.LotNo <> "" AndAlso row.IsInspectorNoNull = False AndAlso row.IsLotJudgNull = True Then
                ltWaitGL.Items.Add(row.LotNo & "," & row.InspectorNo)
            ElseIf row.LotNo <> "" AndAlso row.IsLotJudgNull = False Then
                countUpdate += 1
            End If
        Next
        lbCountUpdate.Text = countUpdate
        lbcount.Text = count
    End Sub

    Private Sub cbbReqCheckData(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbReq1.SelectedIndexChanged, cbbReq3.SelectedIndexChanged, cbbReq2.SelectedIndexChanged, cbbReq4.SelectedIndexChanged
        If cbbReq1.Text = "" AndAlso cbbReq2.Text = "" AndAlso cbbReq3.Text = "" AndAlso cbbReq4.Text = "" Then
            ReqCheckData(1)
        ElseIf cbbReq1.Text <> "" AndAlso cbbReq2.Text = "" AndAlso cbbReq3.Text = "" AndAlso cbbReq4.Text = "" Then
            ReqCheckData(2)
        ElseIf cbbReq1.Text <> "" AndAlso cbbReq2.Text <> "" AndAlso cbbReq3.Text = "" AndAlso cbbReq4.Text = "" Then
            ReqCheckData(3)
        ElseIf cbbReq1.Text <> "" AndAlso cbbReq2.Text <> "" AndAlso cbbReq3.Text <> "" AndAlso cbbReq4.Text = "" Then
            ReqCheckData(4)
        End If
    End Sub
    Private Sub ReqCheckData(ByVal num As Integer)
        For Each ctr As Control In gbBefore.Controls
            If TypeOf ctr Is ComboBox Then
                If num > 0 Then
                    num -= 1
                    ctr.Enabled = True
                Else
                    ctr.Enabled = False
                End If
            End If
        Next
    End Sub
    Private Sub NGCheckData(ByVal num As Integer)
        Dim NumCombo As Integer = num
        Dim NumText As Integer = num
        For Each ctr As Control In gbInspResult.Controls
            If TypeOf ctr Is ComboBox Then
                If NumCombo > 0 Then
                    NumCombo -= 1
                    ctr.Enabled = True
                Else
                    ctr.Enabled = False
                    ctr.Text = ""
                End If
            End If

            If TypeOf ctr Is TextBox AndAlso ctr.Name <> "tbInput" AndAlso ctr.Name <> "tbInspcNo" Then
                If NumText > 0 Then
                    NumText -= 1
                    ctr.Enabled = True
                Else
                    ctr.Enabled = False
                    ctr.Text = ""
                End If
            End If
        Next
    End Sub
    Private Sub cbbNG1CheckData(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbbNG1.SelectedIndexChanged, cbbNG3.SelectedIndexChanged, cbbNG2.SelectedIndexChanged, cbbNG5.SelectedIndexChanged, cbbNG4.SelectedIndexChanged


        If cbbNG1.Text = "" AndAlso cbbNG2.Text = "" AndAlso cbbNG3.Text = "" AndAlso cbbNG4.Text = "" AndAlso cbbNG5.Text = "" Then
            NGCheckData(1)
        ElseIf cbbNG1.Text <> "" AndAlso cbbNG2.Text = "" AndAlso cbbNG3.Text = "" AndAlso cbbNG4.Text = "" AndAlso cbbNG5.Text = "" Then
            NGCheckData(2)
        ElseIf cbbNG1.Text <> "" AndAlso cbbNG2.Text <> "" AndAlso cbbNG3.Text = "" AndAlso cbbNG4.Text = "" AndAlso cbbNG5.Text = "" Then
            NGCheckData(3)
        ElseIf cbbNG1.Text <> "" AndAlso cbbNG2.Text <> "" AndAlso cbbNG3.Text <> "" AndAlso cbbNG4.Text = "" AndAlso cbbNG5.Text = "" Then
            NGCheckData(4)
        ElseIf cbbNG1.Text <> "" AndAlso cbbNG2.Text <> "" AndAlso cbbNG3.Text <> "" AndAlso cbbNG4.Text <> "" AndAlso cbbNG5.Text = "" Then
            NGCheckData(5)
        End If

        For Each Combo As Control In gbInspResult.Controls
            If Combo.Text = "No NG" Then
                If Combo.Name = "cbbNG1" Then
                    tbNG1.Text = "0"
                ElseIf Combo.Name = "cbbNG2" Then
                    tbNG2.Text = "0"
                ElseIf Combo.Name = "cbbNG3" Then
                    tbNG3.Text = "0"
                ElseIf Combo.Name = "cbbNG4" Then
                    tbNG4.Text = "0"
                ElseIf Combo.Name = "cbbNG5" Then
                    tbNG5.Text = "0"
                End If
            End If
        Next

    End Sub

    Public Sub Calculate(ByVal txtbox As TextBox)
        Dim NG As Integer = 0
        For Each ctr As Control In gbInspResult.Controls
            If TypeOf ctr Is TextBox AndAlso ctr.Name <> "tbInput" AndAlso ctr.Text <> "" Then
                NG += CInt(ctr.Text)
            ElseIf TypeOf ctr Is TextBox AndAlso ctr.Name = "tbInput" AndAlso ctr.Text <> "" Then
                InputQty = CInt(ctr.Text)
            End If
        Next
        TotalNG = NG
        lbNGtotal.Text = TotalNG
        If InputQty = 0 Then
            Exit Sub
        End If
        totalGood = InputQty - TotalNG
        lbGood.Text = totalGood
        YLD = FormatNumber((1 - (TotalNG / InputQty)) * 100, 2)
        lbYLD.Text = YLD
    End Sub

    Sub Config_Set(ByVal strConf As String, ByVal File As String)
        Dim fInfo As New IO.FileInfo(File)
        Try
            Dim StmWr As IO.StreamWriter = fInfo.CreateText
            StmWr.Write(strConf)
            StmWr.Flush()
            StmWr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Config_Get(ByVal File As String) As String
        Dim strBuff As String = ""
        Dim fInfo As New IO.FileInfo(File)
        Dim StmRe As IO.StreamReader = fInfo.OpenText
        Do While StmRe.Peek >= 0
            strBuff += StmRe.ReadLine
        Loop
        StmRe.Close()
        Return strBuff
    End Function
    Private Sub AddComLog(ByVal m As String)
        Dim logfile As String = My.Application.Info.DirectoryPath & "\LOG\ComLoG.txt"
        Try
            Dim outfile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(logfile, True)
            outfile.WriteLine(Format(Now, "yyyy/MM/dd HH:mm:ss") & " " & m)
            outfile.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim sr As StreamReader = File.OpenText(logfile)
        If sr.BaseStream.Length > 1000000 Then
            sr.Close()
            If File.Exists(My.Application.Info.DirectoryPath & "\LOG\ComLoG1.txt ") Then
                File.Delete(My.Application.Info.DirectoryPath & "\LOG\ComLoG1.txt")
            End If
            File.Copy(logfile, My.Application.Info.DirectoryPath & "\LOG\ComLoG1.txt")
            File.Delete(logfile)
        End If
        sr.Close()
    End Sub


    Private Sub tbInspcNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbInspcNo.KeyPress

        If e.KeyChar = Chr(13) AndAlso IsNumeric(tbInspcNo.Text) = True AndAlso tbInspcNo.Text.Length = 6 Then

            Dim CheckInput As Boolean = False

            Dim CountCom As Integer = 0
            Dim CountNG As Integer = 0
            For Each ctl As Control In gbInspResult.Controls
                If TypeOf ctl Is ComboBox AndAlso ctl.Text <> "" Then
                    If ctl.Name = "cbbNG1" Then
                        CountCom += 1
                    ElseIf ctl.Name = "cbbNG2" Then
                        CountCom += 2
                    ElseIf ctl.Name = "cbbNG3" Then
                        CountCom += 4
                    ElseIf ctl.Name = "cbbNG4" Then
                        CountCom += 16
                    ElseIf ctl.Name = "cbbNG5" Then
                        CountCom += 32
                    End If
                ElseIf TypeOf ctl Is TextBox AndAlso ctl.Name <> "tbInput" AndAlso ctl.Name <> "tbInspcNo" AndAlso ctl.Text <> "" Then
                    If ctl.Name = "tbNG1" Then
                        CountNG += 1
                    ElseIf ctl.Name = "tbNG2" Then
                        CountNG += 2
                    ElseIf ctl.Name = "tbNG3" Then
                        CountNG += 4
                    ElseIf ctl.Name = "tbNG4" Then
                        CountNG += 16
                    ElseIf ctl.Name = "tbNG5" Then
                        CountNG += 32
                    End If
                ElseIf TypeOf ctl Is TextBox AndAlso ctl.Name = "tbInput" AndAlso ctl.Name <> "tbInspcNo" AndAlso ctl.Text <> "" Then
                    CheckInput = True
                End If
            Next
            If CountCom <> CountNG OrElse CountCom = 0 OrElse CountNG = 0 Then
                MsgBox("กรุณาเลือก  NG Mode และ จำนวน NG ให้ถูกต้อง")
                tbInspcNo.Clear()
                tbInspcNo.Focus()
                Exit Sub

            ElseIf CheckInput = False Then
                MsgBox("กรุณาใส่จำนวน Input")
                tbInspcNo.Clear()
                tbInspcNo.Focus()
                Exit Sub
            End If
            Dim LotAndOP As String = lbLot.Text & "," & tbInspcNo.Text
            ltWaitGL.Items.Add(LotAndOP)



            AddInspToTable()
            StatusLot = "GL Confirm"
            Status(StatusLot)
            SaveDataLotBin()
            CountListData()

            Dim strlog As String
            strlog = "GL:" & lbMC.Text & "," & lbLot.Text & "," & lbOP.Text & ",InspNo," & tbInspcNo.Text & "," _
            & tbInput.Text & "," & lbNGtotal.Text & "," & lbGood.Text & "," & lbYLD.Text & "," & "NGmode," _
            & SelectInspDefect(False, cbbNG1.Text) & " " & tbNG1.Text & "," & SelectInspDefect(False, cbbNG2.Text) & " " _
            & tbNG2.Text & "," & SelectInspDefect(False, cbbNG3.Text) & " " & tbNG3.Text & "," & SelectInspDefect(False, cbbNG4.Text) _
            & " " & tbNG4.Text & "," & SelectInspDefect(False, cbbNG5.Text) & " " & tbNG5.Text

            AddComLog(strlog)

        ElseIf e.KeyChar = Chr(13) Then
            MsgBox("OP Number ไม่ถูกต้องกรุณาตรวจสอบ")
            tbInspcNo.Clear()
            tbInspcNo.Focus()
        End If
    End Sub
    Private Sub AddInspToTable()
        For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
            If row.LotNo = lbLot.Text AndAlso row.StartTime = lbStart.Text Then
                If cbbNG1.Text <> "No NG" AndAlso cbbNG1.Text <> "" Then
                    row.NGMode1 = SelectInspDefect(False, cbbNG1.Text) & "," & tbNG1.Text
                End If
                If cbbNG2.Text <> "No NG" AndAlso cbbNG2.Text <> "" Then
                    row.NGMode2 = SelectInspDefect(False, cbbNG2.Text) & "," & tbNG2.Text
                End If
                If cbbNG3.Text <> "No NG" AndAlso cbbNG3.Text <> "" Then
                    row.NGMode3 = SelectInspDefect(False, cbbNG3.Text) & "," & tbNG3.Text
                End If
                If cbbNG4.Text <> "No NG" AndAlso cbbNG4.Text <> "" Then
                    row.NGMode4 = SelectInspDefect(False, cbbNG4.Text) & "," & tbNG4.Text
                End If
                If cbbNG5.Text <> "No NG" AndAlso cbbNG5.Text <> "" Then
                    row.NGMode5 = SelectInspDefect(False, cbbNG5.Text) & "," & tbNG5.Text
                End If
                row.InspQty = tbInput.Text
                row.NGQty = lbNGtotal.Text
                row.GoodQty = lbGood.Text
                row.InspectorNo = tbInspcNo.Text
                row.FinalYield = lbYLD.Text
            End If
        Next
    End Sub
    Private Sub btEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEnd.Click

        If m_OfflineMode = "Online" Then
            If My.Computer.Network.IsAvailable Then
                If Not My.Computer.Network.Ping(_ipServer) Then
                    MsgBox("Network มีปัญหา กรุณาตรวจสอบหรือเลือก Offline")
                    Exit Sub
                End If
            Else
                MsgBox("Network มีปัญหากรุณาตรวจสอบ LAN หรือเลือก Offline")
                Exit Sub
            End If
        End If

        If cbbLotJudge.Text = "" Then
            MsgBox("กรุณาเลือก Lot Judgement")
            Exit Sub
        ElseIf tbGL.Text = "" Then
            MsgBox("กรุณาสแกน GL Code")
            Exit Sub
        End If
        Dim EndTime As String = Format(Now, "yyyy/MM/dd HH:mm:ss")

        If cbbLotJudge.Text = "Flow" Then
            Lotjodg = "OK"
        Else
            Lotjodg = "NG"
            Remark = cbbLotJudge.Text
        End If
        lbEnd.Text = EndTime
        AddComLog("END," & lbMC.Text & "," & lbLot.Text & "," & lbOP.Text & "," & cbbLotJudge.Text & ",GL," & tbGL.Text)
        AddEndtoTable()
        lbStart.BackColor = Color.White

        If m_OfflineMode = "Online" Then
            SendPostMessage("@LOTEND|" & HeaderMCNo & "|" & lbLot.Text & "," & _
    lbEnd.Text & "," & lbGood.Text & "," & lbNGtotal.Text & ",01") 'Lot End       'Normal
        End If
        SaveDatatoDBx()
        CountListData()
        StatusLot = "LotSet"
        Status(StatusLot)
        SaveDataLotBin()
    End Sub

    Private Sub SaveDatatoDBx()

        If m_OfflineMode = "Offline" Then
            Exit Sub
        End If

        Dim removeList As List(Of DataRow) = New List(Of DataRow)
        For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
            If row.LotNo = lbLot.Text AndAlso row.StartTime = lbStart.Text AndAlso row.LotJudg <> "" Then
                Try
                    Dim fillAffectedRow As Integer = TPINSDataTableAdapter.Update(row)
                    If fillAffectedRow = 1 Then
                        removeList.Add(row)
                    End If
                Catch ex As Exception
                    SaveDataError(row)
                    removeList.Add(row)
                End Try
            End If
        Next
        For Each row As DataRow In removeList
            DBxDataSet.TPINSData.Rows.Remove(row)
        Next
    End Sub

    Private Sub AddEndtoTable()
        For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
            If row.LotNo = lbLot.Text AndAlso row.StartTime = lbStart.Text Then
                row.GLCheck = tbGL.Text
                row.EndTime = lbEnd.Text
                row.LotJudg = Lotjodg
                row.Remark = Remark
                row.ComName = System.Net.Dns.GetHostName
            End If
        Next
    End Sub
    Public Sub SaveDataError(ByVal row As DBxDataSet.TPINSDataRow)
        Dim randomFileName As String = Guid.NewGuid().ToString() & ".xml"
        Dim folder As String = Path.Combine(My.Application.Info.DirectoryPath, "DataError")
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If
        Using table As DBxDataSet.TPINSDataDataTable = New SelfCon.DBxDataSet.TPINSDataDataTable

            table.ImportRow(row)
            Using sw As StreamWriter = New StreamWriter(Path.Combine(folder, randomFileName))
                table.WriteXml(sw.BaseStream)
            End Using
        End Using
    End Sub
    Private Sub OnlineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineToolStripMenuItem.Click, OfflineToolStripMenuItem.Click
        If frmpassword.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ctr As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            Dim StatusMode As String = ctr.Text
            If StatusMode = "Online" Then
                m_OfflineMode = "Online"
                Config_Set("Online", My.Application.Info.DirectoryPath & "\Mode.txt")
                MsgBox("Online Mode OK")
            Else
                Config_Set("Offline", My.Application.Info.DirectoryPath & "\Mode.txt")
                m_OfflineMode = "Offline"
                MsgBox("Offline Mode OK")
            End If
            StatusOnline(m_OfflineMode)
        End If
    End Sub
    Private Sub ClearAll()
        'Before
        lbStart.Text = ""
        cbbReq1.Text = ""
        cbbReq2.Text = ""
        cbbReq3.Text = ""
        cbbReq4.Text = ""
        rdNo.Checked = False
        rdYes.Checked = False

        'Insp
        cbbNG1.Text = ""
        cbbNG2.Text = ""
        cbbNG3.Text = ""
        cbbNG4.Text = ""
        cbbNG5.Text = ""
        tbNG1.Text = ""
        tbNG2.Text = ""
        tbNG3.Text = ""
        tbNG4.Text = ""
        tbNG5.Text = ""
        tbInput.Text = ""
        tbInspcNo.Text = ""
        lbYLD.Text = ""
        lbGood.Text = ""
        lbNGtotal.Text = ""

        'GL 
        lbEnd.Text = ""
        tbGL.Text = ""
        cbbLotJudge.Text = ""

    End Sub

    Public Sub SaveDataLotBin()
        Using sw As StreamWriter = New StreamWriter("TPINSPData.bin")
            Dim b As BinaryFormatter = New BinaryFormatter()
            b.Serialize(sw.BaseStream, DBxDataSet.TPINSData)
        End Using
    End Sub

    Private Sub LoadDataLotBin()
        If File.Exists(My.Application.Info.DirectoryPath & "\TPINSPData.bin") = False Then
            Exit Sub
        End If
        Using sw As StreamReader = New StreamReader("TPINSPData.bin")
            Dim b As BinaryFormatter = New BinaryFormatter()
            Dim dt As DBxDataSet.TPINSDataDataTable = CType(b.Deserialize(sw.BaseStream), DBxDataSet.TPINSDataDataTable)
            For Each row As DBxDataSet.TPINSDataRow In dt.Rows
                DBxDataSet.TPINSData.ImportRow(row)
            Next
        End Using
    End Sub


#Region "=== TDC (APCS DATA BASE)"

    Private strRecv As String
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
      Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Private Declare Function PostMessage Lib "user32.dll" Alias "PostMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private m_TDCProcess As Process
    Private Const WM_CUSTOMMESSAGE As Long = &H400
    Private Const WM_CUSTOMMESSAGE_END As Long = &HD
    Delegate Sub DelegateLoadSimFile(ByVal fpath As String, ByRef listControl As ListBox)
    Private dLoadSimFile As DelegateLoadSimFile

    Private Sub SendString(ByVal hWnd As Integer, ByVal strSend As String)
        'create byte array
        Dim ba() As Byte
        ba = Encoding.UTF8.GetBytes(strSend)
        For i As Integer = 0 To ba.Length - 1
            PostMessage(hWnd, WM_CUSTOMMESSAGE, 0, ba(i))
        Next
        PostMessage(hWnd, WM_CUSTOMMESSAGE, 0, WM_CUSTOMMESSAGE_END)

    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
  
        MyBase.WndProc(m)
        If m.Msg = WM_CUSTOMMESSAGE Then
            If m.LParam <> &HD Then
                Dim tmp(0) As Byte
                tmp(0) = m.LParam
                strRecv = strRecv & (Encoding.UTF8.GetString(tmp))
            Else
                Me.txtPostMSGRecv.Text = strRecv
                strRecv = ""
            End If
        End If
    End Sub
    Public Sub SendPostMessage(ByVal strSend As String)

        If m_OfflineMode = "Offline" Then
            Exit Sub
        End If

        Dim tWnd As Long
        tWnd = FindWindow(vbNullString, "TDC")
        If tWnd <> 0 And strSend <> "" Then
            Dim i As Integer
            For i = 1 To Len(strSend)
                Call PostMessage(tWnd, WM_CUSTOMMESSAGE, 0, Asc(Mid(strSend, i, 1)))
            Next
            Call PostMessage(tWnd, WM_CUSTOMMESSAGE, 0, WM_CUSTOMMESSAGE_END)       ' Send [CR] Code

        End If
    End Sub
    Private Sub txtPostMSGRecv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPostMSGRecv.TextChanged

        Dim PMSRecvData As String
        Dim SplitData() As String
        Dim HEADER As String
        Dim Content1 As String
        Dim Content() As String
        Dim ContentMCNo() As String

        PMSRecvData = txtPostMSGRecv.Text
        SplitData = Split(PMSRecvData, "|")
        If SplitData.Length > 3 Then                        'Concatenate string back block 3
            For i = 3 To SplitData.Length - 1
                SplitData(2) = SplitData(2) & "|" & SplitData(i)
            Next
        End If
        If SplitData(0) = "" Then
            Exit Sub
        End If
        Try
            HEADER = SplitData(0)
            ContentMCNo = Split(SplitData(1), "-")
            HeaderMCNo = ContentMCNo(0) & "-" & ContentMCNo(1) & "-" & ContentMCNo(2)
            Content1 = SplitData(2)

        Catch ex As Exception
            Exit Sub
        End Try
        Select Case HEADER
            Case "@CNTREQ"                                  '***  TDC Commu: Get Reply -> Lot Setup Report  ***
                If SplitData(2) = "00" Then

                ElseIf SplitData(2) = "01" Then
                    MsgBox("Not Connect To TDC", 48, "Connect TDC")
                End If


            Case "@LOTRPT"                          '***  TDC Commu: Get Reply -> Lot Information Request  ***
                Content = Split(Content1, ",")
                If UBound(Content) >= 2 Then        ' LotReport  Return OK
                    'Dim data As TPData = SelfConData.Data
                    SendPostMessage("@LOTRPT|" & HeaderMCNo & "|" & "00")   '***  TDC Commu: ACK Lot Information Request  ***
                    SendPostMessage("@LOTSET|" & HeaderMCNo & "|" & lbLot.Text & "," & lbStart.Text & ",00")   ' TDC lotstart 
                    'SelfConData.Data.LotInform = "00 : Running Normal"          '130809

                ElseIf UBound(Content) = 1 Then       'LotReport Return NG 


                    SendPostMessage("@LOTRPT|" & HeaderMCNo & "|" & "00")
                    SendPostMessage("@LOTSET|" & HeaderMCNo & "|" & lbLot.Text & "," & lbStart.Text & ",00")   ' TDC lotstart 


                    If Content(0) = "01" Then         'Error 01 Not Found


                    ElseIf Content(0) = "02" Then     'Error 02 Running


                    ElseIf Content(0) = "04" Then     'Error 04 Machine not found


                    ElseIf Content(0) = "05" Then


                    ElseIf Content(0) = "06" Then


                    ElseIf Content(0) = "70" Then


                    ElseIf Content(0) = "71" Then


                    ElseIf Content(0) = "72" Then


                    ElseIf Content(0) = "73" Then


                    ElseIf Content(0) = "99" Then
                    End If
                    'SelfConData.Data.LotInform = Content(0) & ":" & Content(1)
                    'AddComLog(SelfConData.Data.LotInform)
                End If


            Case "@LOTSET"                                  '***  TDC No Handle For Right Now


            Case "@STRRPT"                                  '***  TDC Commu: Get Reply -> Lot Setup Report  ***
                SendPostMessage("@STRRPT" & "|" & HeaderMCNo & "|" & "00")         '***  TDC Commu: ACK Start Information Request  **

            Case "@LOTEND"                                  '***  TDC No Handle For Right Now


            Case "@ENDINF"                                  '***  TDC Commu: Get Reply -> Lot END Report  ***
                Content = Split(Content1, ",")
                SendPostMessage("@ENDINF|" & HeaderMCNo & "|" & "00")          '***  TDC Commu: ACK End Information Request  ***
                'If IsNumeric(Content(0)) Then
                '    AddComLog(lbLot.Text & " , " & PMSRecvData)
                'End If
        End Select                                                                     'Show SelconM data change
        txtPostMSGRecv.Text = ""
    End Sub
#End Region

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click
        If MessageBox.Show("คุณต้องการอัพเดทข้อมูลหรือไม่?", "Do you want to update data?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim removeList As List(Of DataRow) = New List(Of DataRow)
            For Each row As DBxDataSet.TPINSDataRow In DBxDataSet.TPINSData
                If row.LotNo <> "" AndAlso row.IsLotJudgNull = False Then
                    Try
                        Dim fillAffectedRow As Integer = TPINSDataTableAdapter.Update(row)
                        If fillAffectedRow = 1 Then
                            removeList.Add(row)
                        End If
                    Catch ex As Exception
                        SaveDataError(row)
                        removeList.Add(row)
                    End Try
                End If
            Next

            For Each row As DataRow In removeList
                DBxDataSet.TPINSData.Rows.Remove(row)
            Next
        End If
        CountListData()
    End Sub

    Private Sub lbSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbSearch.Click
        frmSearch.ShowDialog()
    End Sub
 
    Private Sub lbworkrecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbworkrecord.Click

        Try
            Call Shell("C:\Program Files\Internet Explorer\iexplore.exe http://webserv/ERECORD/", AppWinStyle.NormalFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lbhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbhelp.Click
        If File.Exists(My.Application.Info.DirectoryPath & "\Manual.pdf") Then
            Process.Start(My.Application.Info.DirectoryPath & "\Manual.pdf")
        Else
            MsgBox("Find TP Manual Not Found")
        End If
    End Sub

    Private Sub ClearDataAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearDataAllToolStripMenuItem.Click
        If frmpassword.ShowDialog = Windows.Forms.DialogResult.OK Then
            DBxDataSet.TPINSData.Rows.Clear()
            CountListData()
            SaveDataLotBin()
        End If
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        frmDeleteLot.ShowDialog()
    End Sub

    Private Sub lbBMOnline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbBMOnline.Click
        Try
            Dim path As String = Config_Get(My.Application.Info.DirectoryPath & "\BM_Online.txt")
            If File.Exists(path) = True Then
                Process.Start(path)
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
