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
        Me.lblShoppingCart = New System.Windows.Forms.Label()
        Me.panelItemCart = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblItemQty = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PanelItemCart2 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.panelItemCart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelItemCart2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblShoppingCart
        '
        Me.lblShoppingCart.AutoSize = True
        Me.lblShoppingCart.BackColor = System.Drawing.Color.Transparent
        Me.lblShoppingCart.Font = New System.Drawing.Font("Poppins", 14.8!, System.Drawing.FontStyle.Bold)
        Me.lblShoppingCart.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblShoppingCart.Location = New System.Drawing.Point(101, 68)
        Me.lblShoppingCart.Name = "lblShoppingCart"
        Me.lblShoppingCart.Size = New System.Drawing.Size(204, 44)
        Me.lblShoppingCart.TabIndex = 4
        Me.lblShoppingCart.Text = "Shopping Cart"
        '
        'panelItemCart
        '
        Me.panelItemCart.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.panelItemCart.Controls.Add(Me.CheckBox1)
        Me.panelItemCart.Controls.Add(Me.lblItemQty)
        Me.panelItemCart.Controls.Add(Me.btnAdd)
        Me.panelItemCart.Controls.Add(Me.btnMinus)
        Me.panelItemCart.Controls.Add(Me.PictureBox1)
        Me.panelItemCart.Controls.Add(Me.lblPrice)
        Me.panelItemCart.Controls.Add(Me.lblProductName)
        Me.panelItemCart.Location = New System.Drawing.Point(12, 128)
        Me.panelItemCart.Name = "panelItemCart"
        Me.panelItemCart.Size = New System.Drawing.Size(383, 130)
        Me.panelItemCart.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(301, 95)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 30)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Select"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblItemQty
        '
        Me.lblItemQty.AutoSize = True
        Me.lblItemQty.Location = New System.Drawing.Point(173, 100)
        Me.lblItemQty.Name = "lblItemQty"
        Me.lblItemQty.Size = New System.Drawing.Size(14, 16)
        Me.lblItemQty.TabIndex = 10
        Me.lblItemQty.Text = "1"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DimGray
        Me.btnAdd.Location = New System.Drawing.Point(204, 94)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(22, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "+"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.Transparent
        Me.btnMinus.FlatAppearance.BorderSize = 0
        Me.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinus.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus.ForeColor = System.Drawing.Color.DimGray
        Me.btnMinus.Location = New System.Drawing.Point(144, 93)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(22, 23)
        Me.btnMinus.TabIndex = 8
        Me.btnMinus.Text = "-"
        Me.btnMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(20, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.IndianRed
        Me.lblPrice.Location = New System.Drawing.Point(138, 45)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 31)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "RM 0.00"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.DimGray
        Me.lblProductName.Location = New System.Drawing.Point(138, 14)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(146, 31)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "Product Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Image = Global.Cart_Form.My.Resources.Resources.OMC_UFind_Element1
        Me.PictureBox4.Location = New System.Drawing.Point(12, -7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(143, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PanelItemCart2
        '
        Me.PanelItemCart2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelItemCart2.Controls.Add(Me.CheckBox2)
        Me.PanelItemCart2.Controls.Add(Me.Label1)
        Me.PanelItemCart2.Controls.Add(Me.Button1)
        Me.PanelItemCart2.Controls.Add(Me.Button2)
        Me.PanelItemCart2.Controls.Add(Me.PictureBox2)
        Me.PanelItemCart2.Controls.Add(Me.Label2)
        Me.PanelItemCart2.Controls.Add(Me.Label3)
        Me.PanelItemCart2.Location = New System.Drawing.Point(12, 264)
        Me.PanelItemCart2.Name = "PanelItemCart2"
        Me.PanelItemCart2.Size = New System.Drawing.Size(383, 130)
        Me.PanelItemCart2.TabIndex = 11
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.CheckBox2.Location = New System.Drawing.Point(301, 94)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 30)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.Text = "Select"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(204, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(22, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "+"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(144, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "-"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(20, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(138, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "RM 0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(138, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 130)
        Me.Panel1.TabIndex = 12
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Poppins", 9.0!)
        Me.CheckBox3.Location = New System.Drawing.Point(301, 97)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(79, 30)
        Me.CheckBox3.TabIndex = 16
        Me.CheckBox3.Text = "Select"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DimGray
        Me.Button3.Location = New System.Drawing.Point(204, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "+"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DimGray
        Me.Button4.Location = New System.Drawing.Point(144, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(22, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "-"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(20, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 103)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.IndianRed
        Me.Label5.Location = New System.Drawing.Point(138, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "RM 0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(138, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Product Name"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkSelectAll)
        Me.Panel2.Controls.Add(Me.btnCheckOut)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Location = New System.Drawing.Point(-55, 557)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 116)
        Me.Panel2.TabIndex = 13
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Poppins", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(67, 51)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(54, 34)
        Me.chkSelectAll.TabIndex = 13
        Me.chkSelectAll.Text = "All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCheckOut.FlatAppearance.BorderSize = 0
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.White
        Me.btnCheckOut.Location = New System.Drawing.Point(316, 51)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(112, 31)
        Me.btnCheckOut.TabIndex = 12
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.IndianRed
        Me.Label7.Location = New System.Drawing.Point(310, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "RM 0.00"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.Font = New System.Drawing.Font("Poppins", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.DimGray
        Me.lblTotalPrice.Location = New System.Drawing.Point(310, 4)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(110, 31)
        Me.lblTotalPrice.TabIndex = 11
        Me.lblTotalPrice.Text = "Total Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cart_Form.My.Resources.Resources.CartBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(407, 651)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelItemCart2)
        Me.Controls.Add(Me.panelItemCart)
        Me.Controls.Add(Me.lblShoppingCart)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelItemCart.ResumeLayout(False)
        Me.panelItemCart.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelItemCart2.ResumeLayout(False)
        Me.PanelItemCart2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblShoppingCart As Label
    Friend WithEvents panelItemCart As Panel
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblItemQty As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelItemCart2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnCheckOut As Button
    Friend WithEvents chkSelectAll As CheckBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
End Class
