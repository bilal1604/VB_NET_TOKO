<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_TambahStok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_TambahStok))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel_top_retur = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_minim_tambahstok = New System.Windows.Forms.PictureBox()
        Me.btn_close_tambahstok = New System.Windows.Forms.PictureBox()
        Me.Panel_satu_tambahstok = New System.Windows.Forms.Panel()
        Me.DGV_TAMBAH_STOK = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btn_batal_tambahstok = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_cari_nama_tambahstok = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_cari_kode_tambahstok = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cari_tambahstok = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel_dua_tambahstok = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_pcs_tambahbarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_stok_tambahbarang = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label_qty_tambahstok = New System.Windows.Forms.Label()
        Me.Label_stok_tambahstok = New System.Windows.Forms.Label()
        Me.Label_nama_tambahstok = New System.Windows.Forms.Label()
        Me.Label_kode_tambahstok = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_satuan_tambahstok = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_batal_paneldua_tambahstok = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_simpan_paneldua_tambahstok = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel_top_retur.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btn_minim_tambahstok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close_tambahstok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_satu_tambahstok.SuspendLayout()
        CType(Me.DGV_TAMBAH_STOK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_dua_tambahstok.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_top_retur
        '
        Me.Panel_top_retur.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel_top_retur.Controls.Add(Me.Panel2)
        Me.Panel_top_retur.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_top_retur.Location = New System.Drawing.Point(0, 0)
        Me.Panel_top_retur.Name = "Panel_top_retur"
        Me.Panel_top_retur.Size = New System.Drawing.Size(530, 40)
        Me.Panel_top_retur.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_minim_tambahstok)
        Me.Panel2.Controls.Add(Me.btn_close_tambahstok)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(464, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(66, 40)
        Me.Panel2.TabIndex = 0
        '
        'btn_minim_tambahstok
        '
        Me.btn_minim_tambahstok.Image = CType(resources.GetObject("btn_minim_tambahstok.Image"), System.Drawing.Image)
        Me.btn_minim_tambahstok.Location = New System.Drawing.Point(3, 7)
        Me.btn_minim_tambahstok.Name = "btn_minim_tambahstok"
        Me.btn_minim_tambahstok.Size = New System.Drawing.Size(25, 25)
        Me.btn_minim_tambahstok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minim_tambahstok.TabIndex = 2
        Me.btn_minim_tambahstok.TabStop = False
        '
        'btn_close_tambahstok
        '
        Me.btn_close_tambahstok.Image = CType(resources.GetObject("btn_close_tambahstok.Image"), System.Drawing.Image)
        Me.btn_close_tambahstok.Location = New System.Drawing.Point(33, 7)
        Me.btn_close_tambahstok.Name = "btn_close_tambahstok"
        Me.btn_close_tambahstok.Size = New System.Drawing.Size(25, 25)
        Me.btn_close_tambahstok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close_tambahstok.TabIndex = 0
        Me.btn_close_tambahstok.TabStop = False
        '
        'Panel_satu_tambahstok
        '
        Me.Panel_satu_tambahstok.Controls.Add(Me.DGV_TAMBAH_STOK)
        Me.Panel_satu_tambahstok.Controls.Add(Me.btn_batal_tambahstok)
        Me.Panel_satu_tambahstok.Controls.Add(Me.btn_cari_nama_tambahstok)
        Me.Panel_satu_tambahstok.Controls.Add(Me.btn_cari_kode_tambahstok)
        Me.Panel_satu_tambahstok.Controls.Add(Me.Label23)
        Me.Panel_satu_tambahstok.Controls.Add(Me.txt_cari_tambahstok)
        Me.Panel_satu_tambahstok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_satu_tambahstok.Location = New System.Drawing.Point(0, 40)
        Me.Panel_satu_tambahstok.Name = "Panel_satu_tambahstok"
        Me.Panel_satu_tambahstok.Size = New System.Drawing.Size(530, 410)
        Me.Panel_satu_tambahstok.TabIndex = 2
        '
        'DGV_TAMBAH_STOK
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_TAMBAH_STOK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_TAMBAH_STOK.BackgroundColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_TAMBAH_STOK.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_TAMBAH_STOK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_TAMBAH_STOK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_TAMBAH_STOK.ColumnHeadersHeight = 21
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_TAMBAH_STOK.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_TAMBAH_STOK.EnableHeadersVisualStyles = False
        Me.DGV_TAMBAH_STOK.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TAMBAH_STOK.Location = New System.Drawing.Point(12, 52)
        Me.DGV_TAMBAH_STOK.Name = "DGV_TAMBAH_STOK"
        Me.DGV_TAMBAH_STOK.RowHeadersVisible = False
        Me.DGV_TAMBAH_STOK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_TAMBAH_STOK.Size = New System.Drawing.Size(506, 333)
        Me.DGV_TAMBAH_STOK.TabIndex = 47
        Me.DGV_TAMBAH_STOK.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DGV_TAMBAH_STOK.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_TAMBAH_STOK.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_TAMBAH_STOK.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_TAMBAH_STOK.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_TAMBAH_STOK.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_TAMBAH_STOK.ThemeStyle.HeaderStyle.Height = 21
        Me.DGV_TAMBAH_STOK.ThemeStyle.ReadOnly = False
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_TAMBAH_STOK.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btn_batal_tambahstok
        '
        Me.btn_batal_tambahstok.BorderRadius = 12
        Me.btn_batal_tambahstok.CheckedState.Parent = Me.btn_batal_tambahstok
        Me.btn_batal_tambahstok.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_batal_tambahstok.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btn_batal_tambahstok.CustomImages.Parent = Me.btn_batal_tambahstok
        Me.btn_batal_tambahstok.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_batal_tambahstok.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_batal_tambahstok.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.btn_batal_tambahstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_batal_tambahstok.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btn_batal_tambahstok.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal_tambahstok.HoverState.Parent = Me.btn_batal_tambahstok
        Me.btn_batal_tambahstok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_batal_tambahstok.Location = New System.Drawing.Point(426, 6)
        Me.btn_batal_tambahstok.Name = "btn_batal_tambahstok"
        Me.btn_batal_tambahstok.ShadowDecoration.Parent = Me.btn_batal_tambahstok
        Me.btn_batal_tambahstok.Size = New System.Drawing.Size(100, 40)
        Me.btn_batal_tambahstok.TabIndex = 46
        Me.btn_batal_tambahstok.Text = "BATAL"
        '
        'btn_cari_nama_tambahstok
        '
        Me.btn_cari_nama_tambahstok.BorderRadius = 12
        Me.btn_cari_nama_tambahstok.CheckedState.Parent = Me.btn_cari_nama_tambahstok
        Me.btn_cari_nama_tambahstok.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cari_nama_tambahstok.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btn_cari_nama_tambahstok.CustomImages.Parent = Me.btn_cari_nama_tambahstok
        Me.btn_cari_nama_tambahstok.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cari_nama_tambahstok.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cari_nama_tambahstok.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_nama_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.btn_cari_nama_tambahstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cari_nama_tambahstok.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btn_cari_nama_tambahstok.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_nama_tambahstok.HoverState.Parent = Me.btn_cari_nama_tambahstok
        Me.btn_cari_nama_tambahstok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cari_nama_tambahstok.Location = New System.Drawing.Point(320, 6)
        Me.btn_cari_nama_tambahstok.Name = "btn_cari_nama_tambahstok"
        Me.btn_cari_nama_tambahstok.ShadowDecoration.Parent = Me.btn_cari_nama_tambahstok
        Me.btn_cari_nama_tambahstok.Size = New System.Drawing.Size(100, 40)
        Me.btn_cari_nama_tambahstok.TabIndex = 45
        Me.btn_cari_nama_tambahstok.Text = "CARI NAMA"
        '
        'btn_cari_kode_tambahstok
        '
        Me.btn_cari_kode_tambahstok.BorderRadius = 12
        Me.btn_cari_kode_tambahstok.CheckedState.Parent = Me.btn_cari_kode_tambahstok
        Me.btn_cari_kode_tambahstok.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cari_kode_tambahstok.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btn_cari_kode_tambahstok.CustomImages.Parent = Me.btn_cari_kode_tambahstok
        Me.btn_cari_kode_tambahstok.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_cari_kode_tambahstok.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cari_kode_tambahstok.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_kode_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.btn_cari_kode_tambahstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_cari_kode_tambahstok.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btn_cari_kode_tambahstok.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cari_kode_tambahstok.HoverState.Parent = Me.btn_cari_kode_tambahstok
        Me.btn_cari_kode_tambahstok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_cari_kode_tambahstok.Location = New System.Drawing.Point(214, 6)
        Me.btn_cari_kode_tambahstok.Name = "btn_cari_kode_tambahstok"
        Me.btn_cari_kode_tambahstok.ShadowDecoration.Parent = Me.btn_cari_kode_tambahstok
        Me.btn_cari_kode_tambahstok.Size = New System.Drawing.Size(100, 40)
        Me.btn_cari_kode_tambahstok.TabIndex = 44
        Me.btn_cari_kode_tambahstok.Text = "CARI KODE"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(7, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 14)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "cari"
        '
        'txt_cari_tambahstok
        '
        Me.txt_cari_tambahstok.BorderRadius = 6
        Me.txt_cari_tambahstok.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cari_tambahstok.DefaultText = ""
        Me.txt_cari_tambahstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cari_tambahstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cari_tambahstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cari_tambahstok.DisabledState.Parent = Me.txt_cari_tambahstok
        Me.txt_cari_tambahstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cari_tambahstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cari_tambahstok.FocusedState.Parent = Me.txt_cari_tambahstok
        Me.txt_cari_tambahstok.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cari_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.txt_cari_tambahstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cari_tambahstok.HoverState.Parent = Me.txt_cari_tambahstok
        Me.txt_cari_tambahstok.Location = New System.Drawing.Point(46, 10)
        Me.txt_cari_tambahstok.Name = "txt_cari_tambahstok"
        Me.txt_cari_tambahstok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_cari_tambahstok.PlaceholderText = ""
        Me.txt_cari_tambahstok.SelectedText = ""
        Me.txt_cari_tambahstok.ShadowDecoration.Parent = Me.txt_cari_tambahstok
        Me.txt_cari_tambahstok.Size = New System.Drawing.Size(162, 25)
        Me.txt_cari_tambahstok.TabIndex = 42
        '
        'Panel_dua_tambahstok
        '
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label24)
        Me.Panel_dua_tambahstok.Controls.Add(Me.txt_pcs_tambahbarang)
        Me.Panel_dua_tambahstok.Controls.Add(Me.txt_stok_tambahbarang)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label_qty_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label_stok_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label_nama_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label_kode_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label1)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label2)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label3)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label4)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label_satuan_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label21)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label20)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label19)
        Me.Panel_dua_tambahstok.Controls.Add(Me.Label18)
        Me.Panel_dua_tambahstok.Controls.Add(Me.btn_batal_paneldua_tambahstok)
        Me.Panel_dua_tambahstok.Controls.Add(Me.btn_simpan_paneldua_tambahstok)
        Me.Panel_dua_tambahstok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_dua_tambahstok.Location = New System.Drawing.Point(0, 40)
        Me.Panel_dua_tambahstok.Name = "Panel_dua_tambahstok"
        Me.Panel_dua_tambahstok.Size = New System.Drawing.Size(530, 410)
        Me.Panel_dua_tambahstok.TabIndex = 3
        Me.Panel_dua_tambahstok.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(368, 128)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 14)
        Me.Label24.TabIndex = 61
        Me.Label24.Text = "PCS"
        '
        'txt_pcs_tambahbarang
        '
        Me.txt_pcs_tambahbarang.BorderRadius = 6
        Me.txt_pcs_tambahbarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pcs_tambahbarang.DefaultText = ""
        Me.txt_pcs_tambahbarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pcs_tambahbarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pcs_tambahbarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pcs_tambahbarang.DisabledState.Parent = Me.txt_pcs_tambahbarang
        Me.txt_pcs_tambahbarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pcs_tambahbarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pcs_tambahbarang.FocusedState.Parent = Me.txt_pcs_tambahbarang
        Me.txt_pcs_tambahbarang.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pcs_tambahbarang.ForeColor = System.Drawing.Color.Black
        Me.txt_pcs_tambahbarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pcs_tambahbarang.HoverState.Parent = Me.txt_pcs_tambahbarang
        Me.txt_pcs_tambahbarang.Location = New System.Drawing.Point(262, 122)
        Me.txt_pcs_tambahbarang.Name = "txt_pcs_tambahbarang"
        Me.txt_pcs_tambahbarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pcs_tambahbarang.PlaceholderText = ""
        Me.txt_pcs_tambahbarang.SelectedText = ""
        Me.txt_pcs_tambahbarang.ShadowDecoration.Parent = Me.txt_pcs_tambahbarang
        Me.txt_pcs_tambahbarang.Size = New System.Drawing.Size(100, 25)
        Me.txt_pcs_tambahbarang.TabIndex = 60
        '
        'txt_stok_tambahbarang
        '
        Me.txt_stok_tambahbarang.BorderRadius = 6
        Me.txt_stok_tambahbarang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_stok_tambahbarang.DefaultText = ""
        Me.txt_stok_tambahbarang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_stok_tambahbarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_stok_tambahbarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stok_tambahbarang.DisabledState.Parent = Me.txt_stok_tambahbarang
        Me.txt_stok_tambahbarang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_stok_tambahbarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stok_tambahbarang.FocusedState.Parent = Me.txt_stok_tambahbarang
        Me.txt_stok_tambahbarang.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stok_tambahbarang.ForeColor = System.Drawing.Color.Black
        Me.txt_stok_tambahbarang.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_stok_tambahbarang.HoverState.Parent = Me.txt_stok_tambahbarang
        Me.txt_stok_tambahbarang.Location = New System.Drawing.Point(105, 122)
        Me.txt_stok_tambahbarang.Name = "txt_stok_tambahbarang"
        Me.txt_stok_tambahbarang.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_stok_tambahbarang.PlaceholderText = ""
        Me.txt_stok_tambahbarang.SelectedText = ""
        Me.txt_stok_tambahbarang.ShadowDecoration.Parent = Me.txt_stok_tambahbarang
        Me.txt_stok_tambahbarang.Size = New System.Drawing.Size(100, 25)
        Me.txt_stok_tambahbarang.TabIndex = 59
        '
        'Label_qty_tambahstok
        '
        Me.Label_qty_tambahstok.AutoSize = True
        Me.Label_qty_tambahstok.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_qty_tambahstok.Location = New System.Drawing.Point(119, 90)
        Me.Label_qty_tambahstok.Name = "Label_qty_tambahstok"
        Me.Label_qty_tambahstok.Size = New System.Drawing.Size(18, 14)
        Me.Label_qty_tambahstok.TabIndex = 58
        Me.Label_qty_tambahstok.Text = "24"
        '
        'Label_stok_tambahstok
        '
        Me.Label_stok_tambahstok.AutoSize = True
        Me.Label_stok_tambahstok.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_stok_tambahstok.Location = New System.Drawing.Point(119, 62)
        Me.Label_stok_tambahstok.Name = "Label_stok_tambahstok"
        Me.Label_stok_tambahstok.Size = New System.Drawing.Size(30, 14)
        Me.Label_stok_tambahstok.TabIndex = 57
        Me.Label_stok_tambahstok.Text = "1000"
        '
        'Label_nama_tambahstok
        '
        Me.Label_nama_tambahstok.AutoSize = True
        Me.Label_nama_tambahstok.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nama_tambahstok.Location = New System.Drawing.Point(119, 34)
        Me.Label_nama_tambahstok.Name = "Label_nama_tambahstok"
        Me.Label_nama_tambahstok.Size = New System.Drawing.Size(92, 14)
        Me.Label_nama_tambahstok.TabIndex = 56
        Me.Label_nama_tambahstok.Text = "ayam kampung"
        '
        'Label_kode_tambahstok
        '
        Me.Label_kode_tambahstok.AutoSize = True
        Me.Label_kode_tambahstok.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_kode_tambahstok.Location = New System.Drawing.Point(119, 7)
        Me.Label_kode_tambahstok.Name = "Label_kode_tambahstok"
        Me.Label_kode_tambahstok.Size = New System.Drawing.Size(46, 14)
        Me.Label_kode_tambahstok.TabIndex = 55
        Me.Label_kode_tambahstok.Text = "1001001"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 14)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 14)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(102, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 14)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(102, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 14)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = ":"
        '
        'Label_satuan_tambahstok
        '
        Me.Label_satuan_tambahstok.AutoSize = True
        Me.Label_satuan_tambahstok.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_satuan_tambahstok.Location = New System.Drawing.Point(204, 128)
        Me.Label_satuan_tambahstok.Name = "Label_satuan_tambahstok"
        Me.Label_satuan_tambahstok.Size = New System.Drawing.Size(52, 14)
        Me.Label_satuan_tambahstok.TabIndex = 50
        Me.Label_satuan_tambahstok.Text = "KARTON"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(73, 14)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "qty barang"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(12, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 14)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "stok barang"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 34)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 14)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "Nama Barang"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 14)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "KODE BARANG"
        '
        'btn_batal_paneldua_tambahstok
        '
        Me.btn_batal_paneldua_tambahstok.BorderRadius = 12
        Me.btn_batal_paneldua_tambahstok.CheckedState.Parent = Me.btn_batal_paneldua_tambahstok
        Me.btn_batal_paneldua_tambahstok.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_batal_paneldua_tambahstok.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btn_batal_paneldua_tambahstok.CustomImages.Parent = Me.btn_batal_paneldua_tambahstok
        Me.btn_batal_paneldua_tambahstok.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_batal_paneldua_tambahstok.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_batal_paneldua_tambahstok.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal_paneldua_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.btn_batal_paneldua_tambahstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_batal_paneldua_tambahstok.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btn_batal_paneldua_tambahstok.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_batal_paneldua_tambahstok.HoverState.Parent = Me.btn_batal_paneldua_tambahstok
        Me.btn_batal_paneldua_tambahstok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_batal_paneldua_tambahstok.Location = New System.Drawing.Point(262, 153)
        Me.btn_batal_paneldua_tambahstok.Name = "btn_batal_paneldua_tambahstok"
        Me.btn_batal_paneldua_tambahstok.ShadowDecoration.Parent = Me.btn_batal_paneldua_tambahstok
        Me.btn_batal_paneldua_tambahstok.Size = New System.Drawing.Size(125, 40)
        Me.btn_batal_paneldua_tambahstok.TabIndex = 45
        Me.btn_batal_paneldua_tambahstok.Text = "BATAL"
        '
        'btn_simpan_paneldua_tambahstok
        '
        Me.btn_simpan_paneldua_tambahstok.BorderRadius = 12
        Me.btn_simpan_paneldua_tambahstok.CheckedState.Parent = Me.btn_simpan_paneldua_tambahstok
        Me.btn_simpan_paneldua_tambahstok.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_simpan_paneldua_tambahstok.CustomImages.ImageOffset = New System.Drawing.Point(20, 0)
        Me.btn_simpan_paneldua_tambahstok.CustomImages.Parent = Me.btn_simpan_paneldua_tambahstok
        Me.btn_simpan_paneldua_tambahstok.FillColor = System.Drawing.Color.DarkSlateGray
        Me.btn_simpan_paneldua_tambahstok.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_simpan_paneldua_tambahstok.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_paneldua_tambahstok.ForeColor = System.Drawing.Color.Black
        Me.btn_simpan_paneldua_tambahstok.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_simpan_paneldua_tambahstok.HoverState.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.btn_simpan_paneldua_tambahstok.HoverState.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan_paneldua_tambahstok.HoverState.Parent = Me.btn_simpan_paneldua_tambahstok
        Me.btn_simpan_paneldua_tambahstok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_simpan_paneldua_tambahstok.Location = New System.Drawing.Point(105, 153)
        Me.btn_simpan_paneldua_tambahstok.Name = "btn_simpan_paneldua_tambahstok"
        Me.btn_simpan_paneldua_tambahstok.ShadowDecoration.Parent = Me.btn_simpan_paneldua_tambahstok
        Me.btn_simpan_paneldua_tambahstok.Size = New System.Drawing.Size(125, 40)
        Me.btn_simpan_paneldua_tambahstok.TabIndex = 44
        Me.btn_simpan_paneldua_tambahstok.Text = "SIMPAN"
        '
        'Form_TambahStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 450)
        Me.Controls.Add(Me.Panel_satu_tambahstok)
        Me.Controls.Add(Me.Panel_dua_tambahstok)
        Me.Controls.Add(Me.Panel_top_retur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_TambahStok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_TambahStok"
        Me.Panel_top_retur.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.btn_minim_tambahstok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close_tambahstok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_satu_tambahstok.ResumeLayout(False)
        Me.Panel_satu_tambahstok.PerformLayout()
        CType(Me.DGV_TAMBAH_STOK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_dua_tambahstok.ResumeLayout(False)
        Me.Panel_dua_tambahstok.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_top_retur As Panel
    Friend WithEvents btn_minim_tambahstok As PictureBox
    Friend WithEvents btn_close_tambahstok As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel_satu_tambahstok As Panel
    Friend WithEvents btn_batal_tambahstok As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_cari_nama_tambahstok As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_cari_kode_tambahstok As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_cari_tambahstok As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DGV_TAMBAH_STOK As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel_dua_tambahstok As Panel
    Friend WithEvents btn_batal_paneldua_tambahstok As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_simpan_paneldua_tambahstok As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label_qty_tambahstok As Label
    Friend WithEvents Label_stok_tambahstok As Label
    Friend WithEvents Label_nama_tambahstok As Label
    Friend WithEvents Label_kode_tambahstok As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_satuan_tambahstok As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_pcs_tambahbarang As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_stok_tambahbarang As Guna.UI2.WinForms.Guna2TextBox
End Class
