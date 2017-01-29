<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendChatMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendKeyStrokesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetworkAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxIP = New System.Windows.Forms.ToolStripTextBox()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SethsProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.txtRecMsg = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.DataTypeToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ProgramToolStripMenuItem.Text = "Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DataTypeToolStripMenuItem
        '
        Me.DataTypeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendChatMessageToolStripMenuItem, Me.SendKeyStrokesToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem1})
        Me.DataTypeToolStripMenuItem.Name = "DataTypeToolStripMenuItem"
        Me.DataTypeToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.DataTypeToolStripMenuItem.Text = "Send"
        '
        'SendChatMessageToolStripMenuItem
        '
        Me.SendChatMessageToolStripMenuItem.Checked = True
        Me.SendChatMessageToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SendChatMessageToolStripMenuItem.Name = "SendChatMessageToolStripMenuItem"
        Me.SendChatMessageToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SendChatMessageToolStripMenuItem.Text = "Chat Message"
        '
        'SendKeyStrokesToolStripMenuItem
        '
        Me.SendKeyStrokesToolStripMenuItem.Name = "SendKeyStrokesToolStripMenuItem"
        Me.SendKeyStrokesToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SendKeyStrokesToolStripMenuItem.Text = "Keystrokes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalHostToolStripMenuItem, Me.NetworkAddressToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "Remote Settings"
        '
        'LocalHostToolStripMenuItem
        '
        Me.LocalHostToolStripMenuItem.Checked = True
        Me.LocalHostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LocalHostToolStripMenuItem.Name = "LocalHostToolStripMenuItem"
        Me.LocalHostToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LocalHostToolStripMenuItem.Text = "Localhost"
        '
        'NetworkAddressToolStripMenuItem
        '
        Me.NetworkAddressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxIP})
        Me.NetworkAddressToolStripMenuItem.Name = "NetworkAddressToolStripMenuItem"
        Me.NetworkAddressToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NetworkAddressToolStripMenuItem.Text = "Network Address"
        '
        'ToolStripTextBoxIP
        '
        Me.ToolStripTextBoxIP.AutoToolTip = True
        Me.ToolStripTextBoxIP.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ToolStripTextBoxIP.Name = "ToolStripTextBoxIP"
        Me.ToolStripTextBoxIP.Size = New System.Drawing.Size(150, 23)
        Me.ToolStripTextBoxIP.Text = "Remote IP/Hostname"
        Me.ToolStripTextBoxIP.ToolTipText = "Enter an IP or Hostname to send data to."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SethsProgramToolStripMenuItem, Me.TutorialToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SethsProgramToolStripMenuItem
        '
        Me.SethsProgramToolStripMenuItem.Name = "SethsProgramToolStripMenuItem"
        Me.SethsProgramToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SethsProgramToolStripMenuItem.Text = "Seth's Program"
        '
        'TutorialToolStripMenuItem
        '
        Me.TutorialToolStripMenuItem.Name = "TutorialToolStripMenuItem"
        Me.TutorialToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TutorialToolStripMenuItem.Text = "Tutorial"
        '
        'lblErrors
        '
        Me.lblErrors.AutoSize = True
        Me.lblErrors.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblErrors.Location = New System.Drawing.Point(12, 294)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(0, 13)
        Me.lblErrors.TabIndex = 1
        '
        'txtRecMsg
        '
        Me.txtRecMsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRecMsg.Location = New System.Drawing.Point(0, 24)
        Me.txtRecMsg.Multiline = True
        Me.txtRecMsg.Name = "txtRecMsg"
        Me.txtRecMsg.ReadOnly = True
        Me.txtRecMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRecMsg.Size = New System.Drawing.Size(670, 267)
        Me.txtRecMsg.TabIndex = 2
        Me.txtRecMsg.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(12, 300)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(410, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(428, 298)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "&Send"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 352)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(670, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(655, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Errors to be displayed here."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 800
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(670, 374)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtRecMsg)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UDP Data Test"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendChatMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendKeyStrokesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblErrors As System.Windows.Forms.Label
    Friend WithEvents txtRecMsg As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SethsProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalHostToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxIP As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TutorialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
