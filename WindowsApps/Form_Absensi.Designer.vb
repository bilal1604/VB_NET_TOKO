﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Absensi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ABSENSI_LABEL_NAMA_KARYAWAN = New System.Windows.Forms.Label()
        Me.ABSENSI_LABEL_USERNAME = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ABSENSI_LABEL_STATUS = New System.Windows.Forms.Label()
        Me.ABSENSI_LABEL_CLASS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ABSENSI_BTN_CARI = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ABSENSI_TXT_CARI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DGV_VIEW_ABSENSI = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.ABSENSI_BTN_ABSENSI_PULANG = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ABSENSI_BTN_HADIR = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.DGV_VIEW_ABSENSI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ABSENSI_LABEL_NAMA_KARYAWAN
        '
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.AutoSize = True
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.Location = New System.Drawing.Point(180, 75)
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.Name = "ABSENSI_LABEL_NAMA_KARYAWAN"
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.Size = New System.Drawing.Size(88, 14)
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.TabIndex = 124
        Me.ABSENSI_LABEL_NAMA_KARYAWAN.Text = "BILAL ABDILAH"
        '
        'ABSENSI_LABEL_USERNAME
        '
        Me.ABSENSI_LABEL_USERNAME.AutoSize = True
        Me.ABSENSI_LABEL_USERNAME.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_LABEL_USERNAME.Location = New System.Drawing.Point(180, 53)
        Me.ABSENSI_LABEL_USERNAME.Name = "ABSENSI_LABEL_USERNAME"
        Me.ABSENSI_LABEL_USERNAME.Size = New System.Drawing.Size(46, 14)
        Me.ABSENSI_LABEL_USERNAME.TabIndex = 123
        Me.ABSENSI_LABEL_USERNAME.Text = "1001001"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(167, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 14)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(167, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 14)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(64, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 14)
        Me.Label17.TabIndex = 120
        Me.Label17.Text = "nama karyawan"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(64, 55)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(65, 14)
        Me.Label24.TabIndex = 119
        Me.Label24.Text = "username"
        '
        'ABSENSI_LABEL_STATUS
        '
        Me.ABSENSI_LABEL_STATUS.AutoSize = True
        Me.ABSENSI_LABEL_STATUS.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_LABEL_STATUS.Location = New System.Drawing.Point(180, 116)
        Me.ABSENSI_LABEL_STATUS.Name = "ABSENSI_LABEL_STATUS"
        Me.ABSENSI_LABEL_STATUS.Size = New System.Drawing.Size(80, 14)
        Me.ABSENSI_LABEL_STATUS.TabIndex = 117
        Me.ABSENSI_LABEL_STATUS.Text = "KEPALA TOKO"
        '
        'ABSENSI_LABEL_CLASS
        '
        Me.ABSENSI_LABEL_CLASS.AutoSize = True
        Me.ABSENSI_LABEL_CLASS.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_LABEL_CLASS.Location = New System.Drawing.Point(180, 94)
        Me.ABSENSI_LABEL_CLASS.Name = "ABSENSI_LABEL_CLASS"
        Me.ABSENSI_LABEL_CLASS.Size = New System.Drawing.Size(55, 14)
        Me.ABSENSI_LABEL_CLASS.TabIndex = 116
        Me.ABSENSI_LABEL_CLASS.Text = "A2 - PLUS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 14)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 14)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(64, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 14)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Status"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(64, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 14)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Class"
        '
        'ABSENSI_BTN_CARI
        '
        Me.ABSENSI_BTN_CARI.BorderRadius = 12
        Me.ABSENSI_BTN_CARI.CheckedState.Parent = Me.ABSENSI_BTN_CARI
        Me.ABSENSI_BTN_CARI.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_CARI.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.ABSENSI_BTN_CARI.CustomImages.Parent = Me.ABSENSI_BTN_CARI
        Me.ABSENSI_BTN_CARI.FillColor = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_CARI.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_CARI.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_CARI.ForeColor = System.Drawing.Color.Black
        Me.ABSENSI_BTN_CARI.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_CARI.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_CARI.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_CARI.HoverState.Parent = Me.ABSENSI_BTN_CARI
        Me.ABSENSI_BTN_CARI.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_CARI.Location = New System.Drawing.Point(369, 12)
        Me.ABSENSI_BTN_CARI.Name = "ABSENSI_BTN_CARI"
        Me.ABSENSI_BTN_CARI.ShadowDecoration.Parent = Me.ABSENSI_BTN_CARI
        Me.ABSENSI_BTN_CARI.Size = New System.Drawing.Size(60, 25)
        Me.ABSENSI_BTN_CARI.TabIndex = 127
        Me.ABSENSI_BTN_CARI.Text = "CARI"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(28, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 14)
        Me.Label23.TabIndex = 126
        Me.Label23.Text = "cari"
        '
        'ABSENSI_TXT_CARI
        '
        Me.ABSENSI_TXT_CARI.BorderRadius = 6
        Me.ABSENSI_TXT_CARI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ABSENSI_TXT_CARI.DefaultText = ""
        Me.ABSENSI_TXT_CARI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ABSENSI_TXT_CARI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ABSENSI_TXT_CARI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ABSENSI_TXT_CARI.DisabledState.Parent = Me.ABSENSI_TXT_CARI
        Me.ABSENSI_TXT_CARI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ABSENSI_TXT_CARI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_TXT_CARI.FocusedState.Parent = Me.ABSENSI_TXT_CARI
        Me.ABSENSI_TXT_CARI.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_TXT_CARI.ForeColor = System.Drawing.Color.Black
        Me.ABSENSI_TXT_CARI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_TXT_CARI.HoverState.Parent = Me.ABSENSI_TXT_CARI
        Me.ABSENSI_TXT_CARI.Location = New System.Drawing.Point(67, 12)
        Me.ABSENSI_TXT_CARI.Name = "ABSENSI_TXT_CARI"
        Me.ABSENSI_TXT_CARI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ABSENSI_TXT_CARI.PlaceholderText = ""
        Me.ABSENSI_TXT_CARI.SelectedText = ""
        Me.ABSENSI_TXT_CARI.ShadowDecoration.Parent = Me.ABSENSI_TXT_CARI
        Me.ABSENSI_TXT_CARI.Size = New System.Drawing.Size(296, 25)
        Me.ABSENSI_TXT_CARI.TabIndex = 125
        '
        'DGV_VIEW_ABSENSI
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_VIEW_ABSENSI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_VIEW_ABSENSI.BackgroundColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_VIEW_ABSENSI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_VIEW_ABSENSI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_VIEW_ABSENSI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_VIEW_ABSENSI.ColumnHeadersHeight = 21
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_VIEW_ABSENSI.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_VIEW_ABSENSI.EnableHeadersVisualStyles = False
        Me.DGV_VIEW_ABSENSI.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_VIEW_ABSENSI.Location = New System.Drawing.Point(17, 248)
        Me.DGV_VIEW_ABSENSI.Name = "DGV_VIEW_ABSENSI"
        Me.DGV_VIEW_ABSENSI.RowHeadersVisible = False
        Me.DGV_VIEW_ABSENSI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_VIEW_ABSENSI.Size = New System.Drawing.Size(702, 270)
        Me.DGV_VIEW_ABSENSI.TabIndex = 128
        Me.DGV_VIEW_ABSENSI.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGV_VIEW_ABSENSI.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_VIEW_ABSENSI.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_VIEW_ABSENSI.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_VIEW_ABSENSI.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_VIEW_ABSENSI.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_VIEW_ABSENSI.ThemeStyle.HeaderStyle.Height = 21
        Me.DGV_VIEW_ABSENSI.ThemeStyle.ReadOnly = False
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_VIEW_ABSENSI.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_BTN_ABSENSI_PULANG)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_BTN_HADIR)
        Me.Guna2Panel1.Controls.Add(Me.DGV_VIEW_ABSENSI)
        Me.Guna2Panel1.Controls.Add(Me.Label18)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_BTN_CARI)
        Me.Guna2Panel1.Controls.Add(Me.Label19)
        Me.Guna2Panel1.Controls.Add(Me.Label23)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_TXT_CARI)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_LABEL_NAMA_KARYAWAN)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_LABEL_USERNAME)
        Me.Guna2Panel1.Controls.Add(Me.Label14)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_LABEL_CLASS)
        Me.Guna2Panel1.Controls.Add(Me.Label15)
        Me.Guna2Panel1.Controls.Add(Me.ABSENSI_LABEL_STATUS)
        Me.Guna2Panel1.Controls.Add(Me.Label17)
        Me.Guna2Panel1.Controls.Add(Me.Label24)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 22)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(753, 538)
        Me.Guna2Panel1.TabIndex = 129
        '
        'ABSENSI_BTN_ABSENSI_PULANG
        '
        Me.ABSENSI_BTN_ABSENSI_PULANG.BorderRadius = 12
        Me.ABSENSI_BTN_ABSENSI_PULANG.CheckedState.Parent = Me.ABSENSI_BTN_ABSENSI_PULANG
        Me.ABSENSI_BTN_ABSENSI_PULANG.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_ABSENSI_PULANG.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.ABSENSI_BTN_ABSENSI_PULANG.CustomImages.Parent = Me.ABSENSI_BTN_ABSENSI_PULANG
        Me.ABSENSI_BTN_ABSENSI_PULANG.FillColor = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_ABSENSI_PULANG.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_ABSENSI_PULANG.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_ABSENSI_PULANG.ForeColor = System.Drawing.Color.Black
        Me.ABSENSI_BTN_ABSENSI_PULANG.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_ABSENSI_PULANG.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_ABSENSI_PULANG.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_ABSENSI_PULANG.HoverState.Parent = Me.ABSENSI_BTN_ABSENSI_PULANG
        Me.ABSENSI_BTN_ABSENSI_PULANG.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_ABSENSI_PULANG.Location = New System.Drawing.Point(309, 155)
        Me.ABSENSI_BTN_ABSENSI_PULANG.Name = "ABSENSI_BTN_ABSENSI_PULANG"
        Me.ABSENSI_BTN_ABSENSI_PULANG.ShadowDecoration.Parent = Me.ABSENSI_BTN_ABSENSI_PULANG
        Me.ABSENSI_BTN_ABSENSI_PULANG.Size = New System.Drawing.Size(120, 60)
        Me.ABSENSI_BTN_ABSENSI_PULANG.TabIndex = 130
        Me.ABSENSI_BTN_ABSENSI_PULANG.Text = "Absensi Pulang"
        '
        'ABSENSI_BTN_HADIR
        '
        Me.ABSENSI_BTN_HADIR.BorderRadius = 12
        Me.ABSENSI_BTN_HADIR.CheckedState.Parent = Me.ABSENSI_BTN_HADIR
        Me.ABSENSI_BTN_HADIR.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_HADIR.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.ABSENSI_BTN_HADIR.CustomImages.Parent = Me.ABSENSI_BTN_HADIR
        Me.ABSENSI_BTN_HADIR.FillColor = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_HADIR.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_HADIR.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_HADIR.ForeColor = System.Drawing.Color.Black
        Me.ABSENSI_BTN_HADIR.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ABSENSI_BTN_HADIR.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.ABSENSI_BTN_HADIR.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ABSENSI_BTN_HADIR.HoverState.Parent = Me.ABSENSI_BTN_HADIR
        Me.ABSENSI_BTN_HADIR.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ABSENSI_BTN_HADIR.Location = New System.Drawing.Point(183, 155)
        Me.ABSENSI_BTN_HADIR.Name = "ABSENSI_BTN_HADIR"
        Me.ABSENSI_BTN_HADIR.ShadowDecoration.Parent = Me.ABSENSI_BTN_HADIR
        Me.ABSENSI_BTN_HADIR.Size = New System.Drawing.Size(120, 60)
        Me.ABSENSI_BTN_HADIR.TabIndex = 129
        Me.ABSENSI_BTN_HADIR.Text = "Absensi Hadir"
        '
        'Form_Absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(789, 569)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "Form_Absensi"
        Me.Text = "Form_Absensi"
        CType(Me.DGV_VIEW_ABSENSI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ABSENSI_LABEL_NAMA_KARYAWAN As Label
    Friend WithEvents ABSENSI_LABEL_USERNAME As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ABSENSI_LABEL_STATUS As Label
    Friend WithEvents ABSENSI_LABEL_CLASS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ABSENSI_BTN_CARI As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label23 As Label
    Friend WithEvents ABSENSI_TXT_CARI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_VIEW_ABSENSI As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ABSENSI_BTN_ABSENSI_PULANG As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ABSENSI_BTN_HADIR As Guna.UI2.WinForms.Guna2GradientButton
End Class
