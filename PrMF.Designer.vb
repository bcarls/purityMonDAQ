<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class PrMF
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			Static fTerminateCalled As Boolean
			If Not fTerminateCalled Then
				Form_Terminate_renamed()
				fTerminateCalled = True
			End If
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Text8 As System.Windows.Forms.TextBox
	Public WithEvents Winsock1 As AxMSWinsockLib.AxWinsock
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents HVWait As System.Windows.Forms.Timer
    Public WithEvents _Check4_4 As System.Windows.Forms.CheckBox
    Public WithEvents _Check4_3 As System.Windows.Forms.CheckBox
    Public WithEvents _Check4_2 As System.Windows.Forms.CheckBox
    Public WithEvents _Check4_1 As System.Windows.Forms.CheckBox
    Public WithEvents _Check4_0 As System.Windows.Forms.CheckBox
    Public WithEvents List3 As System.Windows.Forms.ListBox
    Public WithEvents Text3 As System.Windows.Forms.TextBox
    Public WithEvents List2 As System.Windows.Forms.ListBox
    Public WithEvents List1 As System.Windows.Forms.ListBox
    Public WithEvents Text2 As System.Windows.Forms.TextBox
    Public WithEvents OKWait As System.Windows.Forms.Timer
    Public WithEvents PulserWait As System.Windows.Forms.Timer
    Public WithEvents ScopeWait As System.Windows.Forms.Timer
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents TimeT As System.Windows.Forms.TextBox
    Public WithEvents Hz As System.Windows.Forms.Timer
    Public WithEvents _Label1_1 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents _Label1_10 As System.Windows.Forms.Label
    Public WithEvents _Label1_9 As System.Windows.Forms.Label
    Public WithEvents _Label1_3 As System.Windows.Forms.Label
    Public WithEvents StatusL As System.Windows.Forms.Label
    Public WithEvents _Label1_2 As System.Windows.Forms.Label
    Public WithEvents _Label2_1 As System.Windows.Forms.Label
    Public WithEvents CntDwnL As System.Windows.Forms.Label
    Public WithEvents _Label1_17 As System.Windows.Forms.Label
	Public WithEvents RunNumL As System.Windows.Forms.Label
	Public WithEvents _Label1_18 As System.Windows.Forms.Label
	Public WithEvents DataPrefLocation As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Check4 As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrMF))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Text7 = New System.Windows.Forms.TextBox()
        Me.Text8 = New System.Windows.Forms.TextBox()
        Me.Winsock1 = New AxMSWinsockLib.AxWinsock()
        Me.Combo2 = New System.Windows.Forms.ComboBox()
        Me.Combo1 = New System.Windows.Forms.ComboBox()
        Me.HVWait = New System.Windows.Forms.Timer(Me.components)
        Me._Check4_4 = New System.Windows.Forms.CheckBox()
        Me._Check4_3 = New System.Windows.Forms.CheckBox()
        Me._Check4_2 = New System.Windows.Forms.CheckBox()
        Me._Check4_1 = New System.Windows.Forms.CheckBox()
        Me._Check4_0 = New System.Windows.Forms.CheckBox()
        Me.List3 = New System.Windows.Forms.ListBox()
        Me.Text3 = New System.Windows.Forms.TextBox()
        Me.List2 = New System.Windows.Forms.ListBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.OKWait = New System.Windows.Forms.Timer(Me.components)
        Me.PulserWait = New System.Windows.Forms.Timer(Me.components)
        Me.ScopeWait = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Command1 = New System.Windows.Forms.Button()
        Me.TimeT = New System.Windows.Forms.TextBox()
        Me.Hz = New System.Windows.Forms.Timer(Me.components)
        Me._Label1_1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me._Label1_10 = New System.Windows.Forms.Label()
        Me._Label1_9 = New System.Windows.Forms.Label()
        Me._Label1_3 = New System.Windows.Forms.Label()
        Me.StatusL = New System.Windows.Forms.Label()
        Me._Label1_2 = New System.Windows.Forms.Label()
        Me._Label2_1 = New System.Windows.Forms.Label()
        Me.CntDwnL = New System.Windows.Forms.Label()
        Me._Label1_17 = New System.Windows.Forms.Label()
        Me.RunNumL = New System.Windows.Forms.Label()
        Me._Label1_18 = New System.Windows.Forms.Label()
        Me.DataPrefLocation = New System.Windows.Forms.Label()
        Me._Label1_0 = New System.Windows.Forms.Label()
        Me.Check4 = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(Me.components)
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.CheckBoxDropbox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxiFix = New System.Windows.Forms.CheckBox()
        CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Text7
        '
        Me.Text7.AcceptsReturn = True
        Me.Text7.BackColor = System.Drawing.SystemColors.Window
        Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text7.Location = New System.Drawing.Point(26, 593)
        Me.Text7.MaxLength = 0
        Me.Text7.Name = "Text7"
        Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text7.Size = New System.Drawing.Size(153, 20)
        Me.Text7.TabIndex = 51
        Me.Text7.Text = "ubdaq-prod-smc"
        '
        'Text8
        '
        Me.Text8.AcceptsReturn = True
        Me.Text8.BackColor = System.Drawing.SystemColors.Window
        Me.Text8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text8.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text8.Location = New System.Drawing.Point(194, 593)
        Me.Text8.MaxLength = 0
        Me.Text8.Name = "Text8"
        Me.Text8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text8.Size = New System.Drawing.Size(113, 20)
        Me.Text8.TabIndex = 50
        Me.Text8.Text = "8088"
        '
        'Winsock1
        '
        Me.Winsock1.Enabled = True
        Me.Winsock1.Location = New System.Drawing.Point(600, 606)
        Me.Winsock1.Name = "Winsock1"
        Me.Winsock1.OcxState = CType(resources.GetObject("Winsock1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Winsock1.Size = New System.Drawing.Size(28, 28)
        Me.Winsock1.TabIndex = 52
        '
        'Combo2
        '
        Me.Combo2.BackColor = System.Drawing.SystemColors.Window
        Me.Combo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo2.Location = New System.Drawing.Point(473, 503)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo2.Size = New System.Drawing.Size(129, 22)
        Me.Combo2.TabIndex = 49
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Location = New System.Drawing.Point(473, 455)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(129, 22)
        Me.Combo1.TabIndex = 46
        '
        'HVWait
        '
        Me.HVWait.Interval = 1000
        '
        '_Check4_4
        '
        Me._Check4_4.BackColor = System.Drawing.SystemColors.Control
        Me._Check4_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check4_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check4_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check4.SetIndex(Me._Check4_4, CType(4, Short))
        Me._Check4_4.Location = New System.Drawing.Point(191, 120)
        Me._Check4_4.Name = "_Check4_4"
        Me._Check4_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check4_4.Size = New System.Drawing.Size(25, 25)
        Me._Check4_4.TabIndex = 35
        Me._Check4_4.Text = "4"
        Me._Check4_4.UseVisualStyleBackColor = False
        '
        '_Check4_3
        '
        Me._Check4_3.BackColor = System.Drawing.SystemColors.Control
        Me._Check4_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check4_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check4_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check4.SetIndex(Me._Check4_3, CType(3, Short))
        Me._Check4_3.Location = New System.Drawing.Point(151, 120)
        Me._Check4_3.Name = "_Check4_3"
        Me._Check4_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check4_3.Size = New System.Drawing.Size(25, 25)
        Me._Check4_3.TabIndex = 34
        Me._Check4_3.Text = "3"
        Me._Check4_3.UseVisualStyleBackColor = False
        '
        '_Check4_2
        '
        Me._Check4_2.BackColor = System.Drawing.SystemColors.Control
        Me._Check4_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check4_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check4_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check4.SetIndex(Me._Check4_2, CType(2, Short))
        Me._Check4_2.Location = New System.Drawing.Point(111, 120)
        Me._Check4_2.Name = "_Check4_2"
        Me._Check4_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check4_2.Size = New System.Drawing.Size(25, 25)
        Me._Check4_2.TabIndex = 33
        Me._Check4_2.Text = "2"
        Me._Check4_2.UseVisualStyleBackColor = False
        '
        '_Check4_1
        '
        Me._Check4_1.BackColor = System.Drawing.SystemColors.Control
        Me._Check4_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check4_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check4_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check4.SetIndex(Me._Check4_1, CType(1, Short))
        Me._Check4_1.Location = New System.Drawing.Point(71, 120)
        Me._Check4_1.Name = "_Check4_1"
        Me._Check4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check4_1.Size = New System.Drawing.Size(25, 25)
        Me._Check4_1.TabIndex = 32
        Me._Check4_1.Text = "1"
        Me._Check4_1.UseVisualStyleBackColor = False
        '
        '_Check4_0
        '
        Me._Check4_0.BackColor = System.Drawing.SystemColors.Control
        Me._Check4_0.Checked = True
        Me._Check4_0.CheckState = System.Windows.Forms.CheckState.Checked
        Me._Check4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Check4_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Check4_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Check4.SetIndex(Me._Check4_0, CType(0, Short))
        Me._Check4_0.Location = New System.Drawing.Point(31, 120)
        Me._Check4_0.Name = "_Check4_0"
        Me._Check4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Check4_0.Size = New System.Drawing.Size(25, 25)
        Me._Check4_0.TabIndex = 31
        Me._Check4_0.Text = "0"
        Me._Check4_0.UseVisualStyleBackColor = False
        '
        'List3
        '
        Me.List3.BackColor = System.Drawing.SystemColors.Window
        Me.List3.Cursor = System.Windows.Forms.Cursors.Default
        Me.List3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List3.ItemHeight = 14
        Me.List3.Location = New System.Drawing.Point(456, 172)
        Me.List3.Name = "List3"
        Me.List3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List3.Size = New System.Drawing.Size(161, 172)
        Me.List3.TabIndex = 25
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(324, 207)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(69, 20)
        Me.Text3.TabIndex = 22
        Me.Text3.Text = "10"
        Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'List2
        '
        Me.List2.BackColor = System.Drawing.SystemColors.Window
        Me.List2.Cursor = System.Windows.Forms.Cursors.Default
        Me.List2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List2.ItemHeight = 14
        Me.List2.Location = New System.Drawing.Point(264, 376)
        Me.List2.Name = "List2"
        Me.List2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List2.Size = New System.Drawing.Size(184, 158)
        Me.List2.TabIndex = 20
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 14
        Me.List1.Location = New System.Drawing.Point(77, 376)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(184, 158)
        Me.List1.TabIndex = 19
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(125, 207)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(69, 20)
        Me.Text2.TabIndex = 15
        Me.Text2.Text = "40"
        Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OKWait
        '
        Me.OKWait.Interval = 1000
        '
        'PulserWait
        '
        Me.PulserWait.Interval = 15000
        '
        'ScopeWait
        '
        Me.ScopeWait.Interval = 1000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(16, 243)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(415, 32)
        Me.Command1.TabIndex = 2
        Me.Command1.Text = "DAQ Stopped - Press to Start DAQ"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'TimeT
        '
        Me.TimeT.AcceptsReturn = True
        Me.TimeT.BackColor = System.Drawing.SystemColors.Window
        Me.TimeT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TimeT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TimeT.Location = New System.Drawing.Point(388, 56)
        Me.TimeT.MaxLength = 0
        Me.TimeT.Name = "TimeT"
        Me.TimeT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeT.Size = New System.Drawing.Size(60, 22)
        Me.TimeT.TabIndex = 0
        Me.TimeT.Text = "240"
        Me.TimeT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Hz
        '
        Me.Hz.Enabled = True
        Me.Hz.Interval = 1000
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(26, 561)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(249, 23)
        Me._Label1_1.TabIndex = 52
        Me._Label1_1.Text = "Slow control server and port"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(473, 479)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(153, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "CH 2 Range:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(473, 431)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(169, 17)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "CHl 1 Range:"
        '
        '_Label1_10
        '
        Me._Label1_10.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_10, CType(10, Short))
        Me._Label1_10.Location = New System.Drawing.Point(202, 209)
        Me._Label1_10.Name = "_Label1_10"
        Me._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_10.Size = New System.Drawing.Size(120, 18)
        Me._Label1_10.TabIndex = 21
        Me._Label1_10.Text = "RMS Cut = "
        Me._Label1_10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_9
        '
        Me._Label1_9.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_9, CType(9, Short))
        Me._Label1_9.Location = New System.Drawing.Point(5, 376)
        Me._Label1_9.Name = "_Label1_9"
        Me._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_9.Size = New System.Drawing.Size(66, 18)
        Me._Label1_9.TabIndex = 18
        Me._Label1_9.Text = "Results"
        Me._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(3, 209)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(120, 18)
        Me._Label1_3.TabIndex = 16
        Me._Label1_3.Text = "Smoothing = "
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'StatusL
        '
        Me.StatusL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StatusL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StatusL.Cursor = System.Windows.Forms.Cursors.Default
        Me.StatusL.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StatusL.Location = New System.Drawing.Point(16, 172)
        Me.StatusL.Name = "StatusL"
        Me.StatusL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusL.Size = New System.Drawing.Size(418, 23)
        Me.StatusL.TabIndex = 14
        Me.StatusL.Text = "Status"
        Me.StatusL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(269, 21)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(97, 23)
        Me._Label1_2.TabIndex = 10
        Me._Label1_2.Text = "Remaining"
        '
        '_Label2_1
        '
        Me._Label2_1.BackColor = System.Drawing.Color.Transparent
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label2_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(14, 9)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(234, 108)
        Me._Label2_1.TabIndex = 9
        Me._Label2_1.Text = "PrM"
        '
        'CntDwnL
        '
        Me.CntDwnL.BackColor = System.Drawing.Color.White
        Me.CntDwnL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CntDwnL.Cursor = System.Windows.Forms.Cursors.Default
        Me.CntDwnL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CntDwnL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CntDwnL.Location = New System.Drawing.Point(388, 21)
        Me.CntDwnL.Name = "CntDwnL"
        Me.CntDwnL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CntDwnL.Size = New System.Drawing.Size(60, 23)
        Me.CntDwnL.TabIndex = 7
        Me.CntDwnL.Text = "0"
        Me.CntDwnL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_17
        '
        Me._Label1_17.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_17.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_17, CType(17, Short))
        Me._Label1_17.Location = New System.Drawing.Point(65, 284)
        Me._Label1_17.Name = "_Label1_17"
        Me._Label1_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_17.Size = New System.Drawing.Size(129, 18)
        Me._Label1_17.TabIndex = 6
        Me._Label1_17.Text = "Run Number"
        Me._Label1_17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RunNumL
        '
        Me.RunNumL.BackColor = System.Drawing.Color.White
        Me.RunNumL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RunNumL.Cursor = System.Windows.Forms.Cursors.Default
        Me.RunNumL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunNumL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RunNumL.Location = New System.Drawing.Point(206, 283)
        Me.RunNumL.Name = "RunNumL"
        Me.RunNumL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RunNumL.Size = New System.Drawing.Size(154, 31)
        Me.RunNumL.TabIndex = 5
        Me.RunNumL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_18
        '
        Me._Label1_18.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_18, CType(18, Short))
        Me._Label1_18.Location = New System.Drawing.Point(-2, 326)
        Me._Label1_18.Name = "_Label1_18"
        Me._Label1_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_18.Size = New System.Drawing.Size(197, 18)
        Me._Label1_18.TabIndex = 4
        Me._Label1_18.Text = "Data and Pref. Location"
        Me._Label1_18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'DataPrefLocation
        '
        Me.DataPrefLocation.BackColor = System.Drawing.Color.White
        Me.DataPrefLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataPrefLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataPrefLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataPrefLocation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataPrefLocation.Location = New System.Drawing.Point(206, 323)
        Me.DataPrefLocation.Name = "DataPrefLocation"
        Me.DataPrefLocation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataPrefLocation.Size = New System.Drawing.Size(228, 30)
        Me.DataPrefLocation.TabIndex = 3
        Me.DataPrefLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(269, 55)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(113, 23)
        Me._Label1_0.TabIndex = 1
        Me._Label1_0.Text = "Interval (Min)"
        '
        'Label2
        '
        '
        'CheckBoxDropbox
        '
        Me.CheckBoxDropbox.AutoSize = True
        Me.CheckBoxDropbox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDropbox.Location = New System.Drawing.Point(30, 634)
        Me.CheckBoxDropbox.Name = "CheckBoxDropbox"
        Me.CheckBoxDropbox.Size = New System.Drawing.Size(159, 23)
        Me.CheckBoxDropbox.TabIndex = 53
        Me.CheckBoxDropbox.Text = "Copy to Dropbox"
        Me.CheckBoxDropbox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PurityMonDAQ.My.Resources.Resources.FNAL_Logo_NAL_Blue
        Me.PictureBox1.Location = New System.Drawing.Point(358, 606)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'CheckBoxiFix
        '
        Me.CheckBoxiFix.AutoSize = True
        Me.CheckBoxiFix.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxiFix.Location = New System.Drawing.Point(30, 680)
        Me.CheckBoxiFix.Name = "CheckBoxiFix"
        Me.CheckBoxiFix.Size = New System.Drawing.Size(118, 23)
        Me.CheckBoxiFix.TabIndex = 55
        Me.CheckBoxiFix.Text = "Send to iFix"
        Me.CheckBoxiFix.UseVisualStyleBackColor = True
        '
        'PrMF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(646, 731)
        Me.Controls.Add(Me.CheckBoxiFix)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBoxDropbox)
        Me.Controls.Add(Me.Text7)
        Me.Controls.Add(Me.Text8)
        Me.Controls.Add(Me.Winsock1)
        Me.Controls.Add(Me.Combo2)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me._Check4_4)
        Me.Controls.Add(Me._Check4_3)
        Me.Controls.Add(Me._Check4_2)
        Me.Controls.Add(Me._Check4_1)
        Me.Controls.Add(Me._Check4_0)
        Me.Controls.Add(Me.List3)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.TimeT)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me._Label1_10)
        Me.Controls.Add(Me._Label1_9)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me.StatusL)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label2_1)
        Me.Controls.Add(Me.CntDwnL)
        Me.Controls.Add(Me._Label1_17)
        Me.Controls.Add(Me.RunNumL)
        Me.Controls.Add(Me._Label1_18)
        Me.Controls.Add(Me.DataPrefLocation)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 23)
        Me.Name = "PrMF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PrM  Data Acquisition and control"
        CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxDropbox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBoxiFix As CheckBox
#End Region
End Class