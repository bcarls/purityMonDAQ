Option Strict Off
Option Explicit On
Friend Class PrMF
	Inherits System.Windows.Forms.Form
	
	
	
	' Win32 exports
	Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)
	Private Declare Function GetTickCount Lib "kernel32" () As Integer
	Private Declare Function GetInputState Lib "user32" () As Integer
	
	Private Declare Function BmpToJpeg Lib "Bmp2Jpeg.dll" (ByVal BmpFilename As String, ByVal JpegFilename As String, ByVal CompressQuality As Short) As Short
	
	' Input range identifiers
	Dim InputRangeIdChA As Integer
	Dim InputRangeIdChB As Integer
	
	Private Const PI As Single = 3.14159265
	Private Const DALPHA As Single = PI / 6
	Private Const Data7On As Short = 128
	Private Const HVOn As Short = 16
	Private m_Alpha As Single


	
	Private Sub Check2_Click(ByRef Index As Short)
		'Check2(Index).Value = 1
		If Index = 0 Then Ichan1 = 4
		If Index = 1 Then Ichan2 = 5
		
	End Sub
	
	Private Sub Check3_Click(ByRef Index As Short)
		'Check3(Index).Value = 1
		If Index = 0 Then Ichan1 = 0
		If Index = 1 Then Ichan2 = 1
		
	End Sub
	

    Private Sub Combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo1.SelectedIndexChanged
        ' InputRangeIdChA = CInt(VB6.GetItemString(Combo1, Combo1.SelectedIndex))
        'InputRangeIdChA = VB6.GetItemData(Combo1, Combo1.SelectedIndex)

        InputRangeIdChA = Combo1.Items(Combo1.SelectedIndex).ItemData
        InputRangeIdChB = INPUT_RANGE_PM_50_MV

        'Dim mList As MyList
        'mList = Combo1.Items(Combo1.SelectedIndex)
        'Label1.Text = mList.ItemData & "  " & mList.Name

        Dim systemID As Object
        Dim boardID As Integer
        Dim boardHandle As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        systemID = 1
        boardID = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        boardHandle = AlazarGetBoardBySystemID(systemID, boardID)
        Dim result As Boolean
        result = ConfigureBoard(boardHandle)
        If (result <> True) Then
            Exit Sub
        End If

    End Sub

    Private Sub Combo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo2.SelectedIndexChanged
        InputRangeIdChB = Combo2.Items(Combo2.SelectedIndex).ItemData

        'Dim mList As MyList
        'mList = Combo1.Items(Combo1.SelectedIndex)
        'Label1.Text = mList.ItemData & "  " & mList.Name

        Dim systemID As Object
        Dim boardID As Integer
        Dim boardHandle As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        systemID = 1
        boardID = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        boardHandle = AlazarGetBoardBySystemID(systemID, boardID)
        Dim result As Boolean
        result = ConfigureBoard(boardHandle)
        If (result <> True) Then
            Exit Sub
        End If
    End Sub




    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        If iRunning = 1 Then Exit Sub
        If Command1.Text = "DAQ Stopped - Press to Start DAQ" Then
            Command1.Text = "DAQ Running - Press to Stop"
            StatusL.Text = "DAQ Started"
            xRate = 1 'cause to do one right now
            FileOpen(88, DataFileNameHist, OpenMode.Append)
            PrintLine(88, "+++++++" & Today & " " & TimeOfDay & " DAQ Started")
            FileClose(88)
        Else
            Command1.Text = "DAQ Stopped - Press to Start DAQ"
            StatusL.Text = "DAQ Stopped"
            FileOpen(88, DataFileNameHist, OpenMode.Append)
            PrintLine(88, "-------" & Today & " " & TimeOfDay & " DAQ Stopped")
            FileClose(88)
        End If
    End Sub


    Private Sub Command5_Click()
		' Check to see if the current device is really connected to something
		Dim systemID As Object
		Dim boardID As Integer
		Dim boardHandle As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		systemID = 1
		boardID = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		boardHandle = AlazarGetBoardBySystemID(systemID, boardID)
		If (boardHandle = 0) Then
			' Oops, the device isn't available, notify the user and exit
			MsgBox("BoardID " & boardID & " not available." & Chr(10) & "You need to select an available device" & Chr(10) & "for the Alazar boardID in the VB IDE.", MsgBoxStyle.OKOnly, "Startup Error")
			End
		End If
		
		Dim xxxx As Short
		xxxx = 1
		' declare variables
		Dim arrWF As Object 'array variable which will hold waveform values
		Dim xinc As Double ' variable which will hold the x axis increment
		Dim trigpos As Integer ' variable which hold the timing trigger position
		Dim i As Integer ' counter variable
		Dim hUnits, vUnits As String ' variables for returning unit types
		
		On Error GoTo cmdGetWFMErr
		
		
		'rudimentary error trapping
cmdGetWFMErr: 
		MsgBox("Error: " & Err.Number & ", " & Err.Description)
		
	End Sub
	
	
	
	Private Sub PrMF_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.DoubleClick
		Me.Height = VB6.TwipsToPixelsY(9630)
	End Sub
	
	Private Sub PrMF_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Text = "PRM Data Acquisition Software AEB TY BC PRM v20" '   by A Baumbaugh, T Yang, and B Carls, Fermilab"
		' v19  Now making Winsock connection to write to slow controls
		' 4.2  Now plotting the averaged and smoothed traces in the window
		' 4.1  Configuring the program for uBooNE, has Emily's correction and removes the 1.05
		' 4.0  Overhauling code to handle input from Alazar PCI digitizer model ATS310
		' 3.05 set vscale=20mV for inline PrM, save image to ifix
		' 3.04 take difference between ch2 and ch1 as cathode signal to reduce noise, save logfile to dropbox
		' 3.03 change start time for anode from 25 us to 100 us
		' 3.02 use different time scales for different monitors, save output files to dropbox
		' 3.01 add support for liquid level interlock
		' 3.00 add support for mux - T.Yang
		' 2.92 chnged defaults for runs and irate
		' 2.91 added a set focus to nullcmd to start and stop DAQ and added local data csv
		' 2.9  changed default on channel 3 to RAW and default path to E:\ and added long history file
		' 2.8  ADDED Luke.PRM_IMPURITIES.F_CV, TO OUTPUT FILE
		' 2.7  changed csv file to match desired format
		' 2.6  added .csv file writing to DAQ
		' 2.5  made 30 sec start delay
		' 2.4  fixed array too big problem
		' 2.3  added 10 sec wait on text change and print button and fixed irunning error
		' 2.2  fixed going negative problem or at least added debug to find it
		' 2.1  added variable number of data sets
		' 2.0  added changeable sense of liquid level and diode peak to condensed file
		' 1.E  Further changes in analysis to avoid /0
		' 1.D  further changes
		' 1.C  added display of results to top form in a list box
		' 1.B  fixed turning pulser on/off problem
		' 1.A  fixed saving same name snafu
		' 1.9  fixed problem caused by smaller settings form
		' 1.8  shifted search for pulses to 25 us after trig
		' 1.7  fancier argon, changed math again
		' 1.6  fixed Argon and variable color fnal
		' 1.5  modified algorithm
		' 1.4  modified smoothing and fixed .txt files etc
		' 1.3  added analysis code and printing
		' 1.1  added smoothing and columnar print out
		' 1.2  added scale divisors and changed smoothing
		'Private Sub Command1_Click()
		'Text2.Text = Str(Inp(Val("&H" + Text1.Text)))
		'End Sub
		'
		'Private Sub Command2_Click()
		'Out Val("&H" + Text1.Text), Val(Text2.Text)
		'End Sub
		Dim zztime As String
		zztime = VB6.Format(TimeOfDay, "hh:mm:ss")
        '''''''''''''''''''''''''''''''


        '''''''''''''''''''''''''''''''

        ' These variables control when to active the ScopeWait timer in PulserWait timer
        DoneTakingData = False
        ScopeWaitTakingData = False

        'OneTrueLiquid = 1
        'Label1(1).ToolTipText = "Low is good...Dbl Click to Change"
        RMSCut = 10.0#

        ' Number of captures to perform during a run
        numberOfCapturesSignal = 4
        numberOfCapturesNoise = 4

        ISmooth = 40
		IRate = 240
		xRate = IRate * 60
		Dim xinc As Short
		xinc = 1
		IPrM = 0
        NPrM = 5
        StatusL.Text = "DAQ Stopped"

        '''''''''''''''''''''''''''''''''''
        DataPrefFilePath = "C:\PrM_Data_and_Pref\"
        '''''''''''''''''''''''''''''''''''
        LogPath = DataPrefFilePath & "PrM_Log\"

        AllTracesPath = DataPrefFilePath & "All_traces\"

        DataFileNameHist = DataPrefFilePath & "PrMLongHistory.txt"
        Label2(1).BringToFront()
        DataPrefLocation.Text = DataPrefFilePath

        Dim systemID As Object
        Dim boardID As Integer
        Dim boardHandle As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        systemID = 1
        boardID = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        boardHandle = AlazarGetBoardBySystemID(systemID, boardID)

        If (boardHandle = 0) Then
            ' Oops, the device isn't available, notify the user and exit
            MsgBox("BoardID " & boardID & " not available." & Chr(10) & "You need to select an available device" & Chr(10) & "for the Alazar boardID in the VB IDE.", MsgBoxStyle.OkOnly, "Startup Error")
            End
        End If


        'Out Val("&H37a"), 0 'set output low
        Out(Val("&H378"), 8 + Data7On) ' turn off

        Ichan1 = 4 'default smoothed
        Ichan2 = 5 'default smoothed
        Ichan3 = 2 'default raw
        ' List1.Height = VB6.TwipsToPixelsY(1620)
        ' List2.Height = VB6.TwipsToPixelsY(1820)

        With Combo1
            .Items.Add(New MyList("+/- 40 mV", INPUT_RANGE_PM_40_MV))
            .Items.Add(New MyList("+/- 50 mV", INPUT_RANGE_PM_50_MV))
            .Items.Add(New MyList("+/- 80 mV", INPUT_RANGE_PM_80_MV))
            .Items.Add(New MyList("+/- 100 mV", INPUT_RANGE_PM_100_MV))
            .Items.Add(New MyList("+/- 200 mV", INPUT_RANGE_PM_200_MV))
            .Items.Add(New MyList("+/- 400 mV", INPUT_RANGE_PM_400_MV))
            .Items.Add(New MyList("+/- 500 mV", INPUT_RANGE_PM_500_MV))
            .Items.Add(New MyList("+/- 800 mV", INPUT_RANGE_PM_800_MV))
            .Items.Add(New MyList("+/- 1 V", INPUT_RANGE_PM_1_V))
            .Items.Add(New MyList("+/- 2 V", INPUT_RANGE_PM_2_V))
            .Items.Add(New MyList("+/- 4 V", INPUT_RANGE_PM_4_V))
            .Items.Add(New MyList("+/- 5 V", INPUT_RANGE_PM_5_V))
            .Items.Add(New MyList("+/- 8 V", INPUT_RANGE_PM_8_V))
            .Items.Add(New MyList("+/- 10 V", INPUT_RANGE_PM_10_V))
            .Items.Add(New MyList("+/- 20 V", INPUT_RANGE_PM_20_V))
            .SelectedIndex = 0
        End With
        InputRangeIdChA = INPUT_RANGE_PM_40_MV

        With Combo2
            .Items.Add(New MyList("+/- 40 mV", INPUT_RANGE_PM_40_MV))
            .Items.Add(New MyList("+/- 50 mV", INPUT_RANGE_PM_50_MV))
            .Items.Add(New MyList("+/- 80 mV", INPUT_RANGE_PM_80_MV))
            .Items.Add(New MyList("+/- 100 mV", INPUT_RANGE_PM_100_MV))
            .Items.Add(New MyList("+/- 200 mV", INPUT_RANGE_PM_200_MV))
            .Items.Add(New MyList("+/- 400 mV", INPUT_RANGE_PM_400_MV))
            .Items.Add(New MyList("+/- 500 mV", INPUT_RANGE_PM_500_MV))
            .Items.Add(New MyList("+/- 800 mV", INPUT_RANGE_PM_800_MV))
            .Items.Add(New MyList("+/- 1 V", INPUT_RANGE_PM_1_V))
            .Items.Add(New MyList("+/- 2 V", INPUT_RANGE_PM_2_V))
            .Items.Add(New MyList("+/- 4 V", INPUT_RANGE_PM_4_V))
            .Items.Add(New MyList("+/- 5 V", INPUT_RANGE_PM_5_V))
            .Items.Add(New MyList("+/- 8 V", INPUT_RANGE_PM_8_V))
            .Items.Add(New MyList("+/- 10 V", INPUT_RANGE_PM_10_V))
            .Items.Add(New MyList("+/- 20 V", INPUT_RANGE_PM_20_V))
            .SelectedIndex = 0
        End With
        InputRangeIdChB = INPUT_RANGE_PM_40_MV




        'Test Winsock
        'Winsock1.RemotePort = Text8.text
        'Winsock1.RemoteHost = Text7.text
        'Winsock1.Connect
        'Do While (Winsock1.state <> sckConnected)
        '    DoEvents
        'Loop
        'Winsock1.SendData Text9.text & vbCrLf
        'Winsock1.SendData "uB_ArPurity_PM01_0/LIFETIME,0"


    End Sub

    'UPGRADE_WARNING: Event PrMF.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub PrMF_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        '    StatusL.ToolTipText = PrMF.Height
    End Sub

    'UPGRADE_NOTE: Form_Terminate was upgraded to Form_Terminate_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    'UPGRADE_WARNING: PrMF event Form.Terminate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub Form_Terminate_Renamed()
        End
    End Sub

    Private Sub PrMF_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


    ' Gets called every second, all DAQ commands get called from this
    Private Sub Hz_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Hz.Tick
        Static zratesec As String
        ' Tells VB to wait a short while before updating the interval timer
        If KeyHit = 1 Then
            KeyTimer = KeyTimer + 1
            If KeyTimer > 10 Then
                KeyHit = 0
                KeyTimer = 0
                IRate = Val(TimeT.Text)
                If IRate < GetNPrM() Then IRate = GetNPrM()
                If xRate > IRate * 60 Then xRate = IRate * 60
            End If
        End If


        ' Parallel port
        Dim ixxx As Short
        ixxx = Inp(Val("&H379"))





        List3.Items.Clear()
        List3.Items.Add("xRate = " & xRate)
        List3.Items.Add(" IRate = " & IRate)
        List3.Items.Add(" IRunning = " & iRunning)
        List3.Items.Add(" LiquidWait = " & LiquidWait)
        'List3.AddItem " OneTrueLiquid = " & OneTrueLiquid
        List3.Items.Add(TimeOfDay & " " & Today)
        'List3.AddItem "check4(0) " & Check4(0)
        'List3.AddItem "check4(1) " & Check4(1)
        'List3.AddItem "check4(2) " & Check4(2)
        'List3.AddItem "check4(3) " & Check4(3)
        'List3.AddItem "check4(4) " & Check4(4)
        List3.Items.Add(IPrM & "/" & NPrM)
        'List3.AddItem "NPrM = " & GetNPrM()
        List3.Items.Add("ixxx = " & ixxx)
        List3.Items.Add("isubtrch1 = " & isubtrch1)
        If LiquidWait = 0 Then xRate = xRate - 1
        Dim zRateMin As Short
        zRateMin = Int(xRate / 60)
        zratesec = CStr(xRate Mod 60)
        If Len(zratesec) = 1 Then zratesec = "0" & zratesec
        CntDwnL.Text = zRateMin & ":" & zratesec
        ' If xRate >= 0 code exits Hz Timer and no data is taken
        If xRate >= 0 Then Exit Sub
        If iRunning = 1 Then Exit Sub
        xRate = IRate * 60
        'Command1.Enabled = False
        iRunning = 1
        Do While (IPrM < NPrM)
            If Check4(IPrM).CheckState = 1 And Check4(IPrM).Enabled = True Then Exit Do
            IPrM = IPrM + 1
        Loop
        If Command1.Text = "DAQ Running - Press to Stop" And IPrM < NPrM Then
            StatusL.Text = "Taking Data"
            iRunning = 1
            DataPrefLocation.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
            DataPrefLocation.ForeColor = System.Drawing.ColorTranslator.FromOle(0)
            '    Out Val("&H37a"), 15
            '    Out Val("&H37a"), 0
            FileOpen(3, DataPrefFilePath & "Run_num.ini", OpenMode.Input)
            Input(3, iiRun)
            iiRun = iiRun + 1
            iiFile = 1
            FileClose(3)
            FileOpen(3, DataPrefFilePath & "Run_num.ini", OpenMode.Output)
            PrintLine(3, iiRun)
            ' MsgBox xPath
            FileClose(3)
            ' This is a function call, think TakeData()
            TakeData()
            '    Out Val("&H378"), IPrM + Data7On 'turn on pulser
            '    StatusL.Caption = "Pulser Turned ON, PrM = " & IPrM
            LiquidWait = 0
        End If
        ' If Command1.Text = "DAQ Running - Press to Stop" And IPrM < NPrM Then
        'DataPrefLocation.BackColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        'DataPrefLocation.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        'DataPrefLocation.Text = "Data Not Taken yet No PrM is Selected"

        'LiquidWait = 1
        'IPrM = 0
        'OKWait.Enabled = True 'wait for liquid to be ok
        'StatusL.Text = "Please select at least one PrM"

        'End If



        FileOpen(88, DataFileNameHist, OpenMode.Append)
        PrintLine(88, Today & " " & TimeOfDay & " Run Number = " & iiRun)


        FileClose(88)


    End Sub

    ' Private Sub Label1_DblClick(Index As Integer)
    '    If Index = 1 Then
    '        If OneTrueLiquid = 1 Then
    '            OneTrueLiquid = 0
    '            Label1(1).ToolTipText = "High is good...Dbl Click to Change"
    '        Else
    '            OneTrueLiquid = 1
    '            Label1(1).ToolTipText = "Low is good...Dbl Click to Change"
    '        End If
    '    End If
    ' End Sub


    Private Sub Label2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label2.Click
        Dim Index As Short = Label2.GetIndex(eventSender)

    End Sub

    Private Sub OKWait_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OKWait.Tick
        Do While (IPrM < NPrM)
            If Check4(IPrM).CheckState = 1 And Check4(IPrM).Enabled = True Then Exit Do
            IPrM = IPrM + 1
        Loop
        If IPrM = NPrM Then
            IPrM = 0
            Exit Sub
        End If
        FileOpen(3, DataPrefFilePath & "Run_num.ini", OpenMode.Input)
        Input(3, iiRun)
        iiRun = iiRun + 1
        iiFile = 1
        FileClose(3)
        FileOpen(3, DataPrefFilePath & "Run_num.ini", OpenMode.Output)
        PrintLine(3, iiRun)
        FileClose(3)
        '    RunNumL.Caption = Format(iiRun, "#0000") & "_" & Format(IPrM, "00")
        '    DataFileName = DataFilePath & "Run_" & Format(iiRun, "000000") & "_" & Format(IPrM, "00") & ".txt"
        DataPrefLocation.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        DataPrefLocation.ForeColor = System.Drawing.ColorTranslator.FromOle(0)
        '    RunFileL.Caption = DataFileName
        '    PulserWait.Interval = 30000
        '    PulserWait.Enabled = True
        '    Out Val("&H37a"), 15 'turn on pulser
        TakeData()
        '    Out Val("&H378"), IPrM + Data7On 'turn on pulser
        StatusL.Text = "Pulser Turned ON, PrM = " & IPrM
        LiquidWait = 0
        OKWait.Enabled = False
        '    StatusL.Caption = "Taking Data"

    End Sub

    Private Sub PulserWait_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PulserWait.Tick
        PulserWait.Interval = 60000
        ' We only want to enable ScopeWait if we are not DoneTakingData and ScopeWaitTakingData isn't true
        If DoneTakingData = False And ScopeWaitTakingData = False And HVWaitTakingData = False Then
            StatusL.Text = "Taking Data PrM = " & IPrM
            ScopeWait.Enabled = True
        End If
        If DoneTakingData = True And ScopeWaitTakingData = False Then
            IPrM = IPrM + 1
            Do While (IPrM < NPrM)
                If Check4(IPrM).CheckState = 1 And Check4(IPrM).Enabled = True Then Exit Do
                IPrM = IPrM + 1
            Loop
            If IPrM = NPrM Then
                '            Out Val("&H37a"), 0 'turn off pulser
                ' 64=2^6, turns off TPC veto for bit D6
                Out(Val("&H378"), 8 + Data7On + 64) 'turn off pulse
                PulserWait.Enabled = False
                iRunning = 0
                IPrM = 0
                'Command1.Enabled = True
                StatusL.Text = "Waiting for Next Interval"
                Exit Sub
            End If
            If IPrM < NPrM Then
                TakeData()
                StatusL.Text = "Pulser Turned ON, PrM = " & IPrM
                iiFile = 1
            End If
        End If
    End Sub

    Private Sub ScopeWait_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ScopeWait.Tick
        ScopeWait.Enabled = False
        ' ScopeWait is now taking data
        ScopeWaitTakingData = True

        'read scope data here
        ' Check to see if the current device is really connected to something
        Dim systemID As Object
        Dim boardID As Integer
        Dim boardHandle As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        systemID = 1
        boardID = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        boardHandle = AlazarGetBoardBySystemID(systemID, boardID)

        If (boardHandle = 0) Then
            ' Oops, the device isn't available, notify the user and exit
            MsgBox("BoardID " & boardID & " not available." & Chr(10) & "You need to select an available device" & Chr(10) & "for the Alazar boardID in the VB IDE.", MsgBoxStyle.OkOnly, "Startup Error")
            End
        End If







        ' New code for Alazar, takes data for channels A and B
        Dim preTriggerSamples As Integer
        Dim postTriggerSamples As Integer
        Dim samplesPerRecord As Integer
        Dim captureTimeout_ms As Integer
        Dim channelMask As Integer
        Dim channelCount As Integer
        Dim channelsPerBoard As Integer
        Dim channelId As Integer
        Dim channel As Integer
        Dim bitsPerSample As Byte
        Dim bytesPerSample As Integer
        Dim bytesPerRecord As Integer
        Dim samplesPerBuffer As Integer
        Dim buffer() As Short
        Dim retCode As Integer
        Dim startTickCount As Integer
        Dim timeoutTickCount As Integer
        Dim captureDone As Boolean
        Dim captureTime_sec As Double
        Dim recordsPerSec As Double
        Dim bytesTransferred As Integer
        Dim record As Integer
        Dim transferTime_sec As Double
        Dim bytesPerSec As Double
        Dim sampleBitShift As Short
        Dim codeZero As Object
        Dim codeRange As Short
        Dim codeToValue As Double
        Dim scaleValueChA As Object
        Dim scaleValueChB As Double
        Dim offsetValue As Double
        ' These are variables needed for PrMF to run, some are redundant
        Dim xxxx As Short
        xxxx = 1
        Dim arrWF() As Double 'array variable which will hold waveform values, Ben: this will have them after converted to volts, otherwise stored in buffer()
        Dim xinc As Double ' variable which will hold the x axis increment
        Dim trigpos As Integer ' variable which hold the timing trigger position
        Dim i As Integer ' counter variable
        Dim hUnits, vUnits As String ' variables for returning unit types
        Dim samplesPerSec As Double





        ' Set the default return code to indicate failure
        Dim AcquireData As Boolean
        AcquireData = False

        Dim DrawData As Boolean
        DrawData = True

        ' TODO: Select the number of pre-trigger samples per record
        preTriggerSamples = 500

        ' TODO: Select the number of post-trigger samples per record
        postTriggerSamples = 4508

        ' The number of records taken while capturing
        recordsPerCaptureSignal = 25



        ' TODO: Select the amount of time, in milliseconds, to wait for the
        ' acquisiton to complete to on-board memory
        captureTimeout_ms = 300000

        ' TODO: Select which channels read from on-board memory (A, B, or both)
        channelMask = CHANNEL_A Or CHANNEL_B

        ' Select clock parameters as required
        ' 1, 2 want 1 MSPS
        ' 0 want 2 MSPS
        ' Note on 4/10/2014, 0 is temporarily a short purity monitor
        ' Note on 4/15/2014, the 5 MSPS rate doesn't work for 0, I don't know why
        Dim sampleRateId As Integer
        If IPrM = 1 Or IPrM = 2 Then
            sampleRateId = SAMPLE_RATE_1MSPS
            samplesPerSec = 1000000
        Else
            sampleRateId = SAMPLE_RATE_2MSPS
            samplesPerSec = 2000000
        End If

        ' Find the number of enabled channels from the channel mask
        channelsPerBoard = 2
        channelCount = 0
        For channel = 0 To channelsPerBoard - 1
            channelId = 2 ^ channel
            If (channelMask And channelId) = channelId Then
                channelCount = channelCount + 1
            End If
        Next channel

        If ((channelCount < 1) Or (channelCount > channelsPerBoard)) Then
            MsgBox("Error: Invalid channel mask " & Hex(channelMask))
            Exit Sub
        End If

        ' Calculate the size of each record in bytes
        samplesPerRecord = preTriggerSamples + postTriggerSamples

        bitsPerSample = 12
        bytesPerSample = (bitsPerSample + 7) \ 8
        bytesPerRecord = bytesPerSample * samplesPerRecord

        ' Allocate an array of 16-bit signed integers to receive one full record
        ' Note that the buffer must be at least 16 samples larger than the number of samples to transfer
        samplesPerBuffer = samplesPerRecord + 16
        ReDim buffer(samplesPerBuffer - 1)


        ' Configure the number of samples per record
        retCode = AlazarSetRecordSize(boardHandle, preTriggerSamples, postTriggerSamples)
        If (retCode <> ApiSuccess) Then
            MsgBox("Error: AlazarSetRecordSize failed -- " & AlazarErrorToText(retCode))
            Exit Sub
        End If

        ' Configure the number of records in the acquisition
        retCode = AlazarSetRecordCount(boardHandle, recordsPerCaptureSignal)
        If (retCode <> ApiSuccess) Then
            MsgBox("Error: AlazarSetRecordCount failed -- " & AlazarErrorToText(retCode))
            Exit Sub
        End If


        Dim PrMParallelID As Short
        Dim channelName As String
        Dim scaleValue As Double
        Dim sampleInRecord As Integer
        Dim sampleValue As Integer
        Dim sampleVolts As Double
        Dim zzzzzzz As Short
        Dim jj As Short ' check to be sure returned value is an array

        Try
            FileOpen(55, AllTracesFileNameSignal, OpenMode.Append)
        Catch ex As Exception
            MsgBox("File already open for 55 or " & AllTracesFileNameSignal & " and capture number " & captureCountSignal)
        End Try


        For captureCountSignal = 0 To numberOfCapturesSignal - 1


            ' Turn off the HV and Flash-lamp and turn them back on
            If captureCountSignal = 0 Or captureCountSignal = 2 Then
                Out(Val("&H378"), 8 + Data7On)
                System.Threading.Thread.Sleep(90000)
                PrMParallelID = 0
                If IPrM = 0 Then PrMParallelID = 32
                If IPrM = 1 Then PrMParallelID = 1
                If IPrM = 2 Then PrMParallelID = 2
                Out(Val("&H378"), PrMParallelID + HVOn + Data7On) 'turn on pulser and HV, no inhibit this time since there is no TPC
                System.Threading.Thread.Sleep(2000)
            End If

            ' Update status
            ' TextStatus = TextStatus & "Capturing " & recordsPerCapture & " records" & vbCrLf
            ' TextStatus.Refresh

            ' Arm the board to begin the acquisition
            retCode = AlazarStartCapture(boardHandle)
            If (retCode <> ApiSuccess) Then
                MsgBox("Error: AlazarStartCapture failed -- " & AlazarErrorToText(retCode))
                Exit Sub
            End If

            ' Wait for the board to capture all records to on-board memory
            startTickCount = GetTickCount()
            timeoutTickCount = startTickCount + captureTimeout_ms
            captureDone = False

            Do While Not captureDone
                If AlazarBusy(boardHandle) = 0 Then
                    ' All records have been captured to on-board memory
                    captureDone = True
                ElseIf (GetTickCount() > timeoutTickCount) Then
                    ' The capture timeout expired before the capture completed
                    ' The board may not be triggering, or the capture timeout is too short.
                    MsgBox("Error: Capture timeout for signal after " & captureTimeout_ms & "ms -- verify trigger")
                    Exit Do
                Else
                    ' The capture is in progress
                    If GetInputState <> 0 Then System.Windows.Forms.Application.DoEvents()
                    Sleep(10)
                End If
            Loop

            ' Abort the acquisition and exit if the acquisition did not complete
            If Not captureDone Then
                retCode = AlazarAbortCapture(boardHandle)
                If (retCode <> ApiSuccess) Then
                    MsgBox("Error: AlazarAbortCapture " & AlazarErrorToText(retCode))
                End If
                Exit Sub
            End If

            ' Report time to capture all records to on-board memory
            captureTime_sec = (GetTickCount() - startTickCount) / 1000
            If (captureTime_sec > 0) Then
                recordsPerSec = recordsPerCaptureSignal / captureTime_sec
            Else
                recordsPerSec = 0
            End If
            ' TextStatus = TextStatus & "Captured " & recordsPerCapture & " records in " & _
            ''    captureTime_sec & " sec (" & Format(recordsPerSec, "0.00e+") & " records / sec)" & vbCrLf
            ' TextStatus.Refresh

            ' Calculate scale factors to convert sample values to volts:

            ' (a) This 14-bit sample code represents a 0V input
            'UPGRADE_WARNING: Couldn't resolve default property of object codeZero. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            codeZero = 2 ^ (bitsPerSample - 1) - 0.5

            ' (b) This is the range of 14-bit sample codes with respect to 0V level
            codeRange = 2 ^ (bitsPerSample - 1) - 0.5

            ' (c) 14-bit sample codes are stored in the most signficant bits of each 16-bit sample value
            sampleBitShift = 8 * bytesPerSample - bitsPerSample

            ' (d) Mutiply a 14-bit sample code by this amount to get a 16-bit sample value
            codeToValue = 2 ^ sampleBitShift

            ' (e) Subtract this amount from a 16-bit sample value to remove the 0V offset
            'UPGRADE_WARNING: Couldn't resolve default property of object codeZero. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            offsetValue = codeZero * codeToValue

            ' (f) Multiply a 16-bit sample value by this factor to convert it to volts
            'UPGRADE_WARNING: Couldn't resolve default property of object scaleValueChA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            scaleValueChA = InputRangeIdToVolts(InputRangeIdChA) / (codeRange * codeToValue)
            scaleValueChB = InputRangeIdToVolts(InputRangeIdChB) / (codeRange * codeToValue)

            ' Transfer records from on-board memory to our buffer, one record at a time
            ' TextStatus = TextStatus & "Transferring " & recordsPerCapture & " records" & vbCrLf
            ' TextStatus.Refresh

            startTickCount = GetTickCount()
            bytesTransferred = 0


            For record = 0 To recordsPerCaptureSignal - 1


                For channel = 0 To channelsPerBoard - 1

                    ' Get channel Id from channel index
                    channelId = 2 ^ channel

                    ' Skip this channel unless it is in channel mask
                    If (channelMask And channelId) <> 0 Then

                        ' Erase the contents of the arrWF array
                        ReDim arrWF(1)

                        ' Transfer one full record from on-board memory to our buffer
                        retCode = AlazarRead(boardHandle, channelId, buffer(0), bytesPerSample, record + 1, -preTriggerSamples, samplesPerRecord)
                        If (retCode <> ApiSuccess) Then
                            MsgBox("Error: AlazarRead failed -- " & AlazarErrorToText(retCode))
                            Exit Sub
                        End If

                        ' TODO: Process record here.
                        '
                        ' Samples values are arranged contiguously in the buffer, with
                        ' 12-bit sample codes in the most significant bits of each 16-bit
                        ' sample value.
                        '
                        ' Sample codes are unsigned by default so that:
                        ' - a sample code of 0x000 represents a negative full scale input signal;
                        ' - a sample code of 0x800 represents a ~0V signal;
                        ' - a sample code of 0xFFF represents a positive full scale input signal.



                        ' Find name and scale factor of this channel
                        Select Case channelId
                            Case CHANNEL_A
                                channelName = "A"
                                'UPGRADE_WARNING: Couldn't resolve default property of object scaleValueChA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                scaleValue = scaleValueChA
                            Case CHANNEL_B
                                channelName = "B"
                                scaleValue = scaleValueChB
                            Case Else
                                MsgBox("Error: Invalid channelId " & channelId)
                                Exit Sub
                        End Select

                        ' Delimit the start of this record in the file
                        '                    Print #fileHandle, "--> CH" & channelName & " record " & record + 1 & " begin"
                        '                    Print #fileHandle, ""

                        ' Write record samples to file
                        For sampleInRecord = 0 To samplesPerRecord - 1

                            ' Get a sample value from the buffer
                            ' Note that the digitizer returns 16-bit unsigned sample values
                            ' that are stored in a 16-bit signed integer array, so convert
                            ' a signed 16-bit value to unsigned.
                            If (buffer(sampleInRecord) < 0) Then
                                sampleValue = buffer(sampleInRecord) + 65536
                            Else
                                sampleValue = buffer(sampleInRecord)
                            End If

                            ' Convert the sample value to volts
                            sampleVolts = scaleValue * (sampleValue - offsetValue)

                            ' Store new sampleVolts
                            ReDim Preserve arrWF(UBound(arrWF) + 1)
                            arrWF(sampleInRecord) = sampleVolts


                            PrintLine(55, Str(sampleInRecord / samplesPerSec) & " sec." & vbTab & VB6.Format(sampleVolts, "0.000000") & " V")


                        Next sampleInRecord

                        'retCode = AlazarGetTriggerTimestamp(boardHandle, record, timestamp_samples)
                        ' retCode = AlazarGetTriggerAddress(boardHandle, record, timestamp_address, timestamp_highpart, timestamp_lowpart)
                        'If (retCode <> ApiSuccess) Then
                        '    MsgBox ("Error: AlazarGetTriggerAddress failed -- " & AlazarErrorToText(retCode))
                        '    Exit Sub
                        'End If

                        'trigpos = timestamp_samples
                        'trigpos = timestamp_highpart
                        'trigpos = 128 * 2
                        trigpos = preTriggerSamples

                        xinc = 1.0# / samplesPerSec ' Length of time for each array element
                        vUnits = CStr(1)
                        hUnits = CStr(1)
                        xIncr = xinc
                        XTrig = trigpos ' time when trigger fired
                        If IsArray(arrWF) Then
                            zzzzzzz = UBound(arrWF) - LBound(arrWF) + 1
                            ToolTip1.SetToolTip(StatusL, "Scope Array Size = " & zzzzzzz)
                            If zzzzzzz > 100000 Then
                                MsgBox("Array too Large  size= " & zzzzzzz,  , "Fix settings on scope")
                            End If
                            IDPoints = UBound(arrWF) - LBound(arrWF) + 1
                        Else
                            MsgBox("Error not array " & channel)
                        End If
                        jj = 0
                        For i = LBound(arrWF) To UBound(arrWF)
                            If record = 0 And captureCountSignal = 0 Then
                                SignalData(channel, jj) = arrWF(i)
                            Else
                                SignalData(channel, jj) = SignalData(channel, jj) + arrWF(i)
                            End If
                            jj = jj + 1
                        Next i


                        bytesTransferred = bytesTransferred + bytesPerRecord

                    End If ' (channelMask And channelId) <> 0

                Next channel


                ' If the abort button was pressed, then stop reading records

                If GetInputState <> 0 Then System.Windows.Forms.Application.DoEvents()

            Next record

        Next captureCountSignal
        FileClose(55)



        ' All done, turn off the pulser
        Out(Val("&H378"), 8 + Data7On) 'turn off pulser









        ' Display results
        transferTime_sec = (GetTickCount() - startTickCount) / 1000
        If (transferTime_sec > 0) Then
            bytesPerSec = bytesTransferred / transferTime_sec
        Else
            bytesPerSec = 0
        End If

        '    TextStatus = TextStatus & _
        ''        "Transferred " & Format(bytesTransferred, "0.00e+") & " bytes in " & transferTime_sec & _
        ''        " sec (" & Format(bytesPerSec, "0.00e+") & " bytes per sec)" & vbCrLf
        '    TextStatus.Refresh

        ' Set the return code to indicate success
        AcquireData = True

        ' End of new code needed for Alazar digitizer







        ' Open up file for saving traces
        FileClose(33)
        Try
            FileOpen(33, DataFileName, OpenMode.Append)
        Catch ex As Exception
            MsgBox("File already open for 33 or " & DataFileName)
        End Try


        PrintLine(33, Today & "  " & TimeOfDay)

        For channel = 0 To channelsPerBoard - 1
            For i = 0 To preTriggerSamples + postTriggerSamples - 1
                'For i = LBound(xDataRef, 2) To UBound(xDataRef, 2)
                NoiseData(channel, i) = NoiseData(channel, i) / recordsPerCaptureNoise
                PrintLine(33, Str(i / samplesPerSec) & " sec." & vbTab & VB6.Format(NoiseData(channel, i), "0.000000") & " V")
            Next i
        Next channel

        ' Average out the signal samples
        For channel = 0 To channelsPerBoard - 1
            ' For i = LBound(xData, 2) To UBound(xData, 2)
            For i = 0 To preTriggerSamples + postTriggerSamples - 1
                SignalData(channel, i) = SignalData(channel, i) / (recordsPerCaptureSignal * numberOfCapturesSignal)
                PrintLine(33, Str(i / samplesPerSec) & " sec." & vbTab & VB6.Format(SignalData(channel, i), "0.000000") & " V")
                ' xData(channel, i) = xData(channel, i) - xDataRef(channel, i)
            Next i
        Next channel



        'Set SignalDataSmooth equal to SignalData and NoiseDataSmooth equal to NoiseData to then do smoothing
        For channel = 0 To channelsPerBoard - 1
            For i = 0 To preTriggerSamples + postTriggerSamples - 1
                SignalDataSmoothed(channel, i) = SignalData(channel, i)
                NoiseDataSmoothed(channel, i) = NoiseData(channel, i)
            Next i
        Next channel


        ' Do smoothing, start with signal
        Dim xsum As Double
        Dim ii As Short
        For i = 0 To 1 'now create smoothed data
            xsum = 0
            For ii = 0 To ISmooth - 1
                xsum = xsum + SignalDataSmoothed(i, ii)
            Next ii
            For ii = 0 To ISmooth / 2 - 1
                SignalDataSmoothed(i + 4, ii) = xsum / ISmooth
            Next ii
            'xData(i + 4) = xsum / ISmooth

            For ii = ISmooth / 2 To (preTriggerSamples + postTriggerSamples) - ISmooth / 2 - 1
                xsum = 0
                For jj = ii - ISmooth / 2 To ii + ISmooth / 2
                    xsum = xsum + SignalDataSmoothed(i, jj)
                Next jj
                SignalDataSmoothed(i + 4, ii) = xsum / (ISmooth + 1)
            Next ii
            For ii = (preTriggerSamples + postTriggerSamples) - ISmooth / 2 To (preTriggerSamples + postTriggerSamples)
                SignalDataSmoothed(i + 4, ii) = xsum / ISmooth
            Next ii
        Next i
        ' Move onto noise
        For i = 0 To 1 'now create smoothed data
            xsum = 0
            For ii = 0 To ISmooth - 1
                xsum = xsum + NoiseDataSmoothed(i, ii)
            Next ii
            For ii = 0 To ISmooth / 2 - 1
                NoiseDataSmoothed(i + 4, ii) = xsum / ISmooth
            Next ii
            'xData(i + 4) = xsum / ISmooth

            For ii = ISmooth / 2 To (preTriggerSamples + postTriggerSamples) - ISmooth / 2 - 1
                xsum = 0
                For jj = ii - ISmooth / 2 To ii + ISmooth / 2
                    xsum = xsum + NoiseDataSmoothed(i, jj)
                Next jj
                NoiseDataSmoothed(i + 4, ii) = xsum / (ISmooth + 1)
            Next ii
            For ii = (preTriggerSamples + postTriggerSamples) - ISmooth / 2 To (preTriggerSamples + postTriggerSamples)
                NoiseDataSmoothed(i + 4, ii) = xsum / ISmooth
            Next ii
        Next i







        ' Print out the noise samples, smoothed
        For channel = 0 To channelsPerBoard - 1
            For i = 0 To preTriggerSamples + postTriggerSamples - 1
                PrintLine(33, Str(i / samplesPerSec) & " sec." & vbTab & VB6.Format(NoiseDataSmoothed(channel + 4, i), "0.000000") & " V")
                ' xData(channel, i) = xData(channel, i) - xDataRef(channel, i)
            Next i
        Next channel

        ' Print out the signal samples, smoothed
        For channel = 0 To channelsPerBoard - 1
            ' For i = LBound(xData, 2) To UBound(xData, 2)
            For i = 0 To preTriggerSamples + postTriggerSamples - 1
                PrintLine(33, Str(i / samplesPerSec) & " sec." & vbTab & VB6.Format(SignalDataSmoothed(channel + 4, i), "0.000000") & " V")
                ' xData(channel, i) = xData(channel, i) - xDataRef(channel, i)
            Next i
        Next channel


        FileClose(33)



        captureCountSignal = 0


        Call Anal_Data()


        ' We are done taking data for this purity monitor and ScopeWait is no longer taking data
        DoneTakingData = True
        ScopeWaitTakingData = False

        Exit Sub

        'rudimentary error trapping
cmdGetWFMErr1:

        Out(Val("&H378"), 8 + Data7On) 'turn off pulser
        FileClose(33)
        MsgBox("Error: " & Err.Number & ", " & Err.Description)

    End Sub

    'UPGRADE_WARNING: Event Text2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Text2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.TextChanged
        ISmooth = Val(Text2.Text)
        If ISmooth Mod 2 <> 0 Then ISmooth = ISmooth + 1
    End Sub

    'UPGRADE_WARNING: Event Text3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub Text3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text3.TextChanged
        RMSCut = Val(Text3.Text)
        If RMSCut < 3 Then RMSCut = 3.0#
    End Sub


    Private Sub HVWait_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles HVWait.Tick
        ' Function accumulates noise for later correction

        HVWait.Enabled = False
        ' HVWait is now taking data
        HVWaitTakingData = True



        ' Check to see if the current device is really connected to something
        Dim systemID As Object
        Dim boardID As Integer
        Dim boardHandle As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        systemID = 1
        boardID = 1
        'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        boardHandle = AlazarGetBoardBySystemID(systemID, boardID)

        If (boardHandle = 0) Then
            ' Oops, the device isn't available, notify the user and exit
            MsgBox("BoardID " & boardID & " not available." & Chr(10) & "You need to select an available device" & Chr(10) & "for the Alazar boardID in the VB IDE.", MsgBoxStyle.OkOnly, "Startup Error")
            End
        End If





        ' New code for Alazar, takes data for channels A and B
        Dim preTriggerSamples As Integer
        Dim postTriggerSamples As Integer
        Dim samplesPerRecord As Integer
        Dim captureTimeout_ms As Integer
        Dim channelMask As Integer
        Dim channelCount As Integer
        Dim channelsPerBoard As Integer
        Dim channelId As Integer
        Dim channel As Integer
        Dim bitsPerSample As Byte
        Dim bytesPerSample As Integer
        Dim bytesPerRecord As Integer
        Dim samplesPerBuffer As Integer
        Dim buffer() As Short
        Dim retCode As Integer
        Dim startTickCount As Integer
        Dim timeoutTickCount As Integer
        Dim captureDone As Boolean
        Dim captureTime_sec As Double
        Dim recordsPerSec As Double
        Dim bytesTransferred As Integer
        Dim record As Integer
        Dim sampleBitShift As Short
        Dim codeZero As Object
        Dim codeRange As Short
        Dim codeToValue As Double
        Dim scaleValueChA As Object
        Dim scaleValueChB As Double
        Dim offsetValue As Double
        ' These are variables needed for PrMF to run, some are redundant
        Dim xxxx As Short
        xxxx = 1
        Dim arrWF() As Double 'array variable which will hold waveform values, Ben: this will have them after converted to volts, otherwise stored in buffer()
        Dim xinc As Double ' variable which will hold the x axis increment
        Dim trigpos As Integer ' variable which hold the timing trigger position
        Dim i As Integer ' counter variable
        Dim hUnits, vUnits As String ' variables for returning unit types
        Dim samplesPerSec As Double






        ' Set the default return code to indicate failure
        Dim AcquireData As Boolean
        AcquireData = False

        Dim DrawData As Boolean
        DrawData = True

        preTriggerSamples = 500

        ' TODO: Select the number of post-trigger samples per record
        postTriggerSamples = 4508

        ' TODO: Select the number of records in the acquisition
        recordsPerCaptureNoise = 25

        ' TODO: Select the amount of time, in milliseconds, to wait for the
        ' acquisiton to complete to on-board memory
        captureTimeout_ms = 100000

        ' TODO: Select which channels read from on-board memory (A, B, or both)
        channelMask = CHANNEL_A Or CHANNEL_B

        ' Select clock parameters as required
        Dim PrMParallelID As Short
        Dim sampleRateId As Integer
        ' Note on 4/15/2014, the 5 MSPS rate doesn't work for 0, I don't know why
        If IPrM = 1 Or IPrM = 2 Then
            sampleRateId = SAMPLE_RATE_1MSPS
            samplesPerSec = 1000000
        Else
            sampleRateId = SAMPLE_RATE_2MSPS
            samplesPerSec = 2000000
        End If

        ' Find the number of enabled channels from the channel mask
        channelsPerBoard = 2
        channelCount = 0
        For channel = 0 To channelsPerBoard - 1
            channelId = 2 ^ channel
            If (channelMask And channelId) = channelId Then
                channelCount = channelCount + 1
            End If
        Next channel

        If ((channelCount < 1) Or (channelCount > channelsPerBoard)) Then
            MsgBox("Error: Invalid channel mask " & Hex(channelMask))
            Exit Sub
        End If

        ' Calculate the size of each record in bytes
        samplesPerRecord = preTriggerSamples + postTriggerSamples

        bitsPerSample = 12
        bytesPerSample = (bitsPerSample + 7) \ 8
        bytesPerRecord = bytesPerSample * samplesPerRecord

        ' Allocate an array of 16-bit signed integers to receive one full record
        ' Note that the buffer must be at least 16 samples larger than the number of samples to transfer
        samplesPerBuffer = samplesPerRecord + 16
        ReDim buffer(samplesPerBuffer - 1)

        ' Configure the number of samples per record
        retCode = AlazarSetRecordSize(boardHandle, preTriggerSamples, postTriggerSamples)
        If (retCode <> ApiSuccess) Then
            MsgBox("Error: AlazarSetRecordSize failed -- " & AlazarErrorToText(retCode))
            Exit Sub
        End If

        ' Configure the number of records in the acquisition
        retCode = AlazarSetRecordCount(boardHandle, recordsPerCaptureNoise)
        If (retCode <> ApiSuccess) Then
            MsgBox("Error: AlazarSetRecordCount failed -- " & AlazarErrorToText(retCode))
            Exit Sub
        End If

        ' Update status
        ' TextStatus = TextStatus & "Capturing " & recordsPerCapture & " records" & vbCrLf
        ' TextStatus.Refresh


        For captureCountNoise = 0 To numberOfCapturesNoise - 1


            ' If it's not the first data taking period, we turn off the HV and Flash-lamp and turn them back on
            If captureCountSignal = 2 Then
                Out(Val("&H378"), 8 + Data7On)
                System.Threading.Thread.Sleep(90000)
                PrMParallelID = 0
                If IPrM = 0 Then PrMParallelID = 32
                If IPrM = 1 Then PrMParallelID = 1
                If IPrM = 2 Then PrMParallelID = 2
                Out(Val("&H378"), PrMParallelID + Data7On) 'turn on pulser, no inhibit this time since there is no TPC
                System.Threading.Thread.Sleep(2000)
            End If


            ' Arm the board to begin the acquisition
            retCode = AlazarStartCapture(boardHandle)
            If (retCode <> ApiSuccess) Then
                MsgBox("Error: AlazarStartCapture failed -- " & AlazarErrorToText(retCode))
                Exit Sub
            End If

            ' Wait for the board to capture all records to on-board memory
            startTickCount = GetTickCount()
            timeoutTickCount = startTickCount + captureTimeout_ms
            captureDone = False

            Do While Not captureDone
                If AlazarBusy(boardHandle) = 0 Then
                    ' All records have been captured to on-board memory
                    captureDone = True
                ElseIf (GetTickCount() > timeoutTickCount) Then
                    ' The capture timeout expired before the capture completed
                    ' The board may not be triggering, or the capture timeout is too short.
                    MsgBox("Error: Capture timeout for noise data after " & captureTimeout_ms & "ms -- verify trigger")
                    Exit Do
                Else
                    ' The capture is in progress
                    If GetInputState <> 0 Then System.Windows.Forms.Application.DoEvents()
                    Sleep(10)
                End If
            Loop

            ' Abort the acquisition and exit if the acquisition did not complete
            If Not captureDone Then
                retCode = AlazarAbortCapture(boardHandle)
                If (retCode <> ApiSuccess) Then
                    MsgBox("Error: AlazarAbortCapture " & AlazarErrorToText(retCode))
                End If
                Exit Sub
            End If

            ' Report time to capture all records to on-board memory
            captureTime_sec = (GetTickCount() - startTickCount) / 1000
            If (captureTime_sec > 0) Then
                recordsPerSec = recordsPerCaptureNoise / captureTime_sec
            Else
                recordsPerSec = 0
            End If
            ' TextStatus = TextStatus & "Captured " & recordsPerCapture & " records in " & _
            ''    captureTime_sec & " sec (" & Format(recordsPerSec, "0.00e+") & " records / sec)" & vbCrLf
            ' TextStatus.Refresh

            ' Calculate scale factors to convert sample values to volts:

            ' (a) This 12-bit sample code represents a 0V input
            'UPGRADE_WARNING: Couldn't resolve default property of object codeZero. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            codeZero = 2 ^ (bitsPerSample - 1) - 0.5

            ' (b) This is the range of 14-bit sample codes with respect to 0V level
            codeRange = 2 ^ (bitsPerSample - 1) - 0.5

            ' (c) 12-bit sample codes are stored in the most signficant bits of each 16-bit sample value
            sampleBitShift = 8 * bytesPerSample - bitsPerSample

            ' (d) Mutiply a 12-bit sample code by this amount to get a 16-bit sample value
            codeToValue = 2 ^ sampleBitShift

            ' (e) Subtract this amount from a 12-bit sample value to remove the 0V offset
            'UPGRADE_WARNING: Couldn't resolve default property of object codeZero. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            offsetValue = codeZero * codeToValue

            ' (f) Multiply a 16-bit sample value by this factor to convert it to volts
            'UPGRADE_WARNING: Couldn't resolve default property of object scaleValueChA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            scaleValueChA = InputRangeIdToVolts(InputRangeIdChA) / (codeRange * codeToValue)
            scaleValueChB = InputRangeIdToVolts(InputRangeIdChB) / (codeRange * codeToValue)

            ' Transfer records from on-board memory to our buffer, one record at a time
            ' TextStatus = TextStatus & "Transferring " & recordsPerCapture & " records" & vbCrLf
            ' TextStatus.Refresh

            startTickCount = GetTickCount()
            bytesTransferred = 0
            '    PictureBox.AutoRedraw = True
            '    Picture1.AutoRedraw = True
            Dim channelName As String
            Dim scaleValue As Double
            Dim sampleInRecord As Integer
            Dim sampleValue As Integer
            Dim sampleVolts As Double
            Dim zzzzzzz As Short
            Dim jj As Short ' check to be sure returned value is an array

            FileClose(44)
            FileOpen(44, AllTracesFileNameNoise, OpenMode.Append)
            PrintLine(44, Today & "  " & TimeOfDay)

            For record = 0 To recordsPerCaptureNoise - 1

                ' Erase the previous record
                '        If DrawData = True Then
                '            PictureBox.Cls
                '            Picture1.Cls
                '        End If

                For channel = 0 To channelsPerBoard - 1

                    ' Get channel Id from channel index
                    channelId = 2 ^ channel

                    ' Skip this channel unless it is in channel mask
                    If (channelMask And channelId) <> 0 Then

                        ' Erase the contents of the arrWF array
                        ReDim arrWF(1)

                        ' Transfer one full record from on-board memory to our buffer
                        retCode = AlazarRead(boardHandle, channelId, buffer(0), bytesPerSample, record + 1, -preTriggerSamples, samplesPerRecord)
                        If (retCode <> ApiSuccess) Then
                            MsgBox("Error: AlazarRead failed -- " & AlazarErrorToText(retCode))
                            Exit Sub
                        End If

                        ' TODO: Process record here.
                        '
                        ' Samples values are arranged contiguously in the buffer, with
                        ' 12-bit sample codes in the most significant bits of each 16-bit
                        ' sample value.
                        '
                        ' Sample codes are unsigned by default so that:
                        ' - a sample code of 0x000 represents a negative full scale input signal;
                        ' - a sample code of 0x800 represents a ~0V signal;
                        ' - a sample code of 0xFFF represents a positive full scale input signal.

                        ' Save record to file
                        ' If saveData = True Then

                        ' Find name and scale factor of this channel
                        Select Case channelId
                            Case CHANNEL_A
                                channelName = "A"
                                'UPGRADE_WARNING: Couldn't resolve default property of object scaleValueChA. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                                scaleValue = scaleValueChA
                            Case CHANNEL_B
                                channelName = "B"
                                scaleValue = scaleValueChB
                            Case Else
                                MsgBox("Error: Invalid channelId " & channelId)
                                Exit Sub
                        End Select

                        ' Delimit the start of this record in the file
                        '                    Print #fileHandle, "--> CH" & channelName & " record " & record + 1 & " begin"
                        '                    Print #fileHandle, ""

                        ' Write record samples to file
                        For sampleInRecord = 0 To samplesPerRecord - 1

                            ' Get a sample value from the buffer
                            ' Note that the digitizer returns 16-bit unsigned sample values
                            ' that are stored in a 16-bit signed integer array, so convert
                            ' a signed 16-bit value to unsigned.
                            If (buffer(sampleInRecord) < 0) Then
                                sampleValue = buffer(sampleInRecord) + 65536
                            Else
                                sampleValue = buffer(sampleInRecord)
                            End If

                            ' Convert the sample value to volts
                            sampleVolts = scaleValue * (sampleValue - offsetValue)


                            ' Store new sampleVolts
                            ReDim Preserve arrWF(UBound(arrWF) + 1)
                            arrWF(sampleInRecord) = sampleVolts


                            PrintLine(44, Str(sampleInRecord / samplesPerSec) & " sec." & vbTab & VB6.Format(sampleVolts, "0.000000") & " V")

                        Next sampleInRecord

                        ' Ben: dummy placeholders
                        xinc = 0.1
                        trigpos = preTriggerSamples
                        vUnits = CStr(1)
                        hUnits = CStr(1)
                        xIncr = xinc
                        XTrig = trigpos
                        If IsArray(arrWF) Then
                            zzzzzzz = UBound(arrWF) - LBound(arrWF) + 1
                            ToolTip1.SetToolTip(StatusL, "Scope Array Size = " & zzzzzzz)
                            If zzzzzzz > 100000 Then
                                MsgBox("Array too Large  size= " & zzzzzzz,  , "Fix settings on scope")
                            End If
                            IDPoints = UBound(arrWF) - LBound(arrWF) + 1
                        Else
                            MsgBox("Error not array " & channel)
                        End If
                        jj = 0
                        For i = LBound(arrWF) To UBound(arrWF)
                            If record = 0 Then
                                NoiseData(channel, jj) = arrWF(i)
                            Else
                                NoiseData(channel, jj) = NoiseData(channel, jj) + arrWF(i)
                            End If
                            jj = jj + 1
                        Next i



                        bytesTransferred = bytesTransferred + bytesPerRecord

                    End If ' (channelMask And channelId) <> 0

                Next channel


                If GetInputState <> 0 Then System.Windows.Forms.Application.DoEvents()

            Next record
        Next captureCountNoise

        FileClose(44)









        '    Call DrawAveragedSmoothedRecord(xDataRef, preTriggerSamples + postTriggerSamples, channelsPerBoard)



        PrMParallelID = 0
        If IPrM = 0 Then PrMParallelID = 32
        If IPrM = 1 Then PrMParallelID = 1
        If IPrM = 2 Then PrMParallelID = 2
        Out(Val("&H378"), PrMParallelID + HVOn + Data7On) 'turn on pulser and HV, no inhibit this time since there is no TPC


        ' We are done taking data for this purity monitor and ScopeWait is no longer taking data
        HVWaitTakingData = False

    End Sub







    'UPGRADE_WARNING: Event TimeT.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub TimeT_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TimeT.TextChanged
        KeyHit = 1
        KeyTimer = 0
        Exit Sub
        IRate = Val(TimeT.Text)
        If IRate < GetNPrM() Then IRate = GetNPrM()
        If xRate > IRate * 60 Then xRate = IRate * 60
    End Sub

    Private Function GetNPrM() As Short
        Dim i, j As Short
        i = 0
        For j = 0 To NPrM - 1
            If Check4(j).CheckState = 1 And Check4(j).Enabled = True Then i = i + 1
        Next j
        GetNPrM = i
    End Function

    Private Sub TakeData()

        RunNumL.Text = VB6.Format(iiRun, "#0000") & "_" & VB6.Format(IPrM, "00")
        DataFileName = DataPrefFilePath & "Run_" & VB6.Format(iiRun, "000000") & "_" & VB6.Format(IPrM, "00") & ".txt"
        AllTracesFileNameNoise = AllTracesPath & "Run_" & VB6.Format(iiRun, "000000") & "_AllTracesNoise" & VB6.Format(IPrM, "00") & ".txt"
        AllTracesFileNameSignal = AllTracesPath & "Run_" & VB6.Format(iiRun, "000000") & "_AllTracesSignal" & VB6.Format(IPrM, "00") & ".txt"

        DataPrefLocation.Text = DataPrefFilePath

        PulserWait.Interval = 10000
        PulserWait.Enabled = True
		
		List3.Items.Add("Configuring board")
		
		' Provided device checks out, configure the Alazar board, Ben
		' Check first to see if the current device is really connected to something
		Dim systemID As Object
		Dim boardID As Integer
		Dim boardHandle As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		systemID = 1
		boardID = 1
		'UPGRADE_WARNING: Couldn't resolve default property of object systemID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		boardHandle = AlazarGetBoardBySystemID(systemID, boardID)
		If (boardHandle = 0) Then
			' Oops, the device isn't available, notify the user and exit
			MsgBox("BoardID " & boardID & " not available." & Chr(10) & "You need to select an available device" & Chr(10) & "for the Alazar boardID in the VB IDE.", MsgBoxStyle.OKOnly, "Startup Error")
			End
		End If
		Dim result As Boolean
		result = ConfigureBoard(boardHandle)
		If (result <> True) Then
			Exit Sub
		End If
		
		List3.Items.Add("Board configured")



        ' HVOnStall.Enabled = True

        ' Tells parallel port to turn off HV and any running flash lamps
        ' 32 = 2^5, activates veto for TCP for bit D5
        ' Out Val("&H378"), 8 + Data7On + 32 'turn on pulser

        ' Sleep 10000

        ' Tells parallel port to turn on the flash lamp for each PM
        ' 32 = 2^5, activates veto for TCP for bit D5
        ' Out Val("&H378"), IPrM + Data7On + 32 'turn on pulser

        Dim PrMParallelID As Short
		PrMParallelID = 0
		If IPrM = 0 Then PrMParallelID = 32
		If IPrM = 1 Then PrMParallelID = 1
		If IPrM = 2 Then PrMParallelID = 2
		Out(Val("&H378"), PrMParallelID + Data7On) 'turn on pulser, no longer need to worry about TPC veto

        StatusL.Text = "Pulser Turned ON, PrM = " & IPrM
        '    PassCnt = 0

        HVWait.Interval = 2000
        HVWait.Enabled = True

        DoneTakingData = False


    End Sub
	
	' Configure timebase, trigger, and input parameters
	Private Function ConfigureBoard(ByRef boardHandle As Integer) As Boolean
		Dim retCode As Integer
		Dim samplesPerSec As Double
		Dim sampleRateId As Integer
		Dim triggerDelay_sec As Double
		Dim triggerDelay_samples As Integer
		Dim triggerTimeout_sec As Double
		Dim triggerTimeout_clocks As Integer
		
		' Set default return value to indicate failure
		ConfigureBoard = False
		
		' Select clock parameters as required
		' 0, 2, 3 want 1 MSPS
		' 1 and 4 want 5 MSPS
		' Note on 4/14/2014, PrM 0 is short!
		' Note on 4/15/2014, the 5 MSPS rate doesn't work for 0, I don't know why
		If IPrM = 1 Or IPrM = 2 Then
			sampleRateId = SAMPLE_RATE_1MSPS
			samplesPerSec = 1000000
		Else
			sampleRateId = SAMPLE_RATE_2MSPS
			samplesPerSec = 2000000
		End If
		
		retCode = AlazarSetCaptureClock(boardHandle, INTERNAL_CLOCK, sampleRateId, CLOCK_EDGE_RISING, 0)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarSetCaptureClock failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Select CHA input parameters as required
		' InputRangeIdChA = INPUT_RANGE_PM_2_V, now set as combobox
		retCode = AlazarInputControl(boardHandle, CHANNEL_A, DC_COUPLING, InputRangeIdChA, IMPEDANCE_1M_OHM)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarInputControl CHA failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Select CHB input parameters as required
		' InputRangeIdChB = INPUT_RANGE_PM_2_V, now set as combobox
		retCode = AlazarInputControl(boardHandle, CHANNEL_B, DC_COUPLING, InputRangeIdChB, IMPEDANCE_1M_OHM)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarInputControl CHB failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Select trigger inputs and levels as required
		retCode = AlazarSetTriggerOperation(boardHandle, TRIG_ENGINE_OP_J, TRIG_ENGINE_J, TRIG_EXTERNAL, TRIGGER_SLOPE_POSITIVE, 200, TRIG_ENGINE_K, TRIG_DISABLE, TRIGGER_SLOPE_POSITIVE, 128)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarSetTriggerOperation failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Select external trigger parameters as required
		retCode = AlazarSetExternalTrigger(boardHandle, DC_COUPLING, ETR_5V)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarSetExternalTrigger failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Set trigger delay as required
		triggerDelay_sec = 0
		triggerDelay_samples = triggerDelay_sec * samplesPerSec + 0.5
		retCode = AlazarSetTriggerDelay(boardHandle, triggerDelay_samples)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarSetTriggerDelay failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' TODO: Set trigger timeout as required
		
		' NOTE:
		' The board will wait for a for this amount of time for a trigger event.
		' If a trigger event does not arrive, then the board will automatically
		' trigger. Set the trigger timeout value to 0 to force the board to wait
		' forever for a trigger event.
		
		' IMPORTANT:
		' The trigger timeout value should be set to zero after appropriate
		' trigger parameters have been determined, otherwise the
		' board may trigger if the timeout interval expires before a
		' hardware trigger event arrives.
		
		triggerTimeout_sec = 0
		triggerTimeout_clocks = triggerTimeout_sec / 0.00001 + 0.5
		retCode = AlazarSetTriggerTimeOut(boardHandle, triggerTimeout_clocks)
		If (retCode <> ApiSuccess) Then
			MsgBox("Error: AlazarSetTriggerTimeOut failed -- " & AlazarErrorToText(retCode))
			Exit Function
		End If
		
		' Attempt to setup board to take multiple records
		' retCode = AlazarSetRecordCount(boardHandle, 10)
		' If (retCode <> ApiSuccess) Then
		'    MsgBox ("Error: AlazarSetRecord failed -- " & AlazarErrorToText(retCode))
		'    Exit Function
		'End If
		
		' Attempt to setup board to average records
		'retCode = AlazarSetParameter(boardHandle, CHANNEL_A, ACF_RECORDS_TO_AVERAGE, 10)
		'If (retCode <> ApiSuccess) Then
		'    MsgBox ("Error: AlazarSetParameter failed -- " & AlazarErrorToText(retCode))
		'    Exit Function
		'End If
		' Attempt to setup board to average records
		'retCode = AlazarSetParameter(boardHandle, CHANNEL_B, ACF_RECORDS_TO_AVERAGE, 10)
		'If (retCode <> ApiSuccess) Then
		'    MsgBox ("Error: AlazarSetParameter failed -- " & AlazarErrorToText(retCode))
		'    Exit Function
		'End If
		
		
		' Set return code to indicate success
		ConfigureBoard = True
		
	End Function
	
	
	' Convert input range identifier to volts
	Private Function InputRangeIdToVolts(ByVal inputRangeId As Integer) As Double
		
		Select Case inputRangeId
			Case INPUT_RANGE_PM_40_MV
				InputRangeIdToVolts = 0.04
			Case INPUT_RANGE_PM_50_MV
				InputRangeIdToVolts = 0.05
			Case INPUT_RANGE_PM_80_MV
				InputRangeIdToVolts = 0.08
			Case INPUT_RANGE_PM_100_MV
				InputRangeIdToVolts = 0.1
			Case INPUT_RANGE_PM_200_MV
				InputRangeIdToVolts = 0.2
			Case INPUT_RANGE_PM_400_MV
				InputRangeIdToVolts = 0.4
			Case INPUT_RANGE_PM_500_MV
				InputRangeIdToVolts = 0.5
			Case INPUT_RANGE_PM_800_MV
				InputRangeIdToVolts = 0.8
			Case INPUT_RANGE_PM_1_V
				InputRangeIdToVolts = 1
			Case INPUT_RANGE_PM_2_V
				InputRangeIdToVolts = 2
			Case INPUT_RANGE_PM_4_V
				InputRangeIdToVolts = 4
			Case INPUT_RANGE_PM_5_V
				InputRangeIdToVolts = 5
			Case INPUT_RANGE_PM_8_V
				InputRangeIdToVolts = 8
			Case INPUT_RANGE_PM_10_V
				InputRangeIdToVolts = 10
			Case INPUT_RANGE_PM_20_V
				InputRangeIdToVolts = 20
			Case Else
				InputRangeIdToVolts = 0
		End Select
		
	End Function


End Class