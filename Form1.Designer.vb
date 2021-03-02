<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Inizio = New System.Windows.Forms.DateTimePicker()
        Me.Fine = New System.Windows.Forms.DateTimePicker()
        Me.IYC = New System.Windows.Forms.CheckBox()
        Me.GRC = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OOH = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inizio
        '
        Me.Inizio.Location = New System.Drawing.Point(61, 22)
        Me.Inizio.MinDate = New Date(2012, 1, 1, 0, 0, 0, 0)
        Me.Inizio.Name = "Inizio"
        Me.Inizio.Size = New System.Drawing.Size(200, 20)
        Me.Inizio.TabIndex = 1
        '
        'Fine
        '
        Me.Fine.Location = New System.Drawing.Point(61, 48)
        Me.Fine.Name = "Fine"
        Me.Fine.Size = New System.Drawing.Size(200, 20)
        Me.Fine.TabIndex = 3
        '
        'IYC
        '
        Me.IYC.AutoSize = True
        Me.IYC.Location = New System.Drawing.Point(9, 28)
        Me.IYC.Name = "IYC"
        Me.IYC.Size = New System.Drawing.Size(43, 17)
        Me.IYC.TabIndex = 5
        Me.IYC.Text = "IYC"
        Me.IYC.UseVisualStyleBackColor = True
        '
        'GRC
        '
        Me.GRC.AutoSize = True
        Me.GRC.Location = New System.Drawing.Point(88, 26)
        Me.GRC.Name = "GRC"
        Me.GRC.Size = New System.Drawing.Size(49, 17)
        Me.GRC.TabIndex = 6
        Me.GRC.Text = "GRC"
        Me.GRC.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IYC)
        Me.GroupBox1.Controls.Add(Me.GRC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 55)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Environment"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 55)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SR-SI"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(9, 28)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(41, 17)
        Me.CheckBox5.TabIndex = 5
        Me.CheckBox5.Text = "SR"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(88, 28)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(36, 17)
        Me.CheckBox6.TabIndex = 6
        Me.CheckBox6.Text = "SI"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Inizio)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Fine)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(389, 74)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Start - End"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(267, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(50, 20)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Day"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(323, 47)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(50, 20)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "FY+PY"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(323, 22)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(50, 20)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Month"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(267, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(50, 20)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Year"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "End"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Start"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 100
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"MRS", "RDT", "REX", "RGU", "SED", "URE", "HAT", "OTH"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(9, 49)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(180, 109)
        Me.CheckedListBox1.TabIndex = 20
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.CheckBox3)
        Me.GroupBox4.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(206, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(195, 173)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Business Lines"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(85, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 20)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "MR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(9, 26)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "Select All"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(325, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(239, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 30)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "Annulla"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OOH
        '
        Me.OOH.AutoSize = True
        Me.OOH.Location = New System.Drawing.Point(9, 19)
        Me.OOH.Name = "OOH"
        Me.OOH.Size = New System.Drawing.Size(88, 17)
        Me.OOH.TabIndex = 18
        Me.OOH.Text = "Include OOH"
        Me.OOH.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OOH)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(188, 51)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Orders On Hand"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 314)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Control Update"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Inizio As DateTimePicker
    Friend WithEvents Fine As DateTimePicker
    Friend WithEvents IYC As CheckBox
    Friend WithEvents GRC As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Private WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents OOH As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
