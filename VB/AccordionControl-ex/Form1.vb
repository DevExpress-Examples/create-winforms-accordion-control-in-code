Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace AccordionControl_ex

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private acControl As AccordionControl

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            acControl = New AccordionControl()
            acControl.Dock = DockStyle.Left
            acControl.Parent = Me
            acControl.Width = 200
            InitAccordionControl()
        End Sub

        Private Sub InitAccordionControl()
            acControl.BeginUpdate()
            Dim acRootGroupHome As AccordionControlElement = New AccordionControlElement()
            Dim acItemActivity As AccordionControlElement = New AccordionControlElement()
            Dim acItemNews As AccordionControlElement = New AccordionControlElement()
            Dim acRootItemSettings As AccordionControlElement = New AccordionControlElement()
            AddHandler acControl.ElementClick, New ElementClickEventHandler(AddressOf accordionControl1_ElementClick)
            ' 
            ' Root Group 'Home'
            ' 
            acRootGroupHome.Elements.AddRange(New AccordionControlElement() {acItemActivity, acItemNews})
            acRootGroupHome.Expanded = True
            acRootGroupHome.ImageOptions.ImageUri.Uri = "Home;Office2013"
            acRootGroupHome.Name = "acRootGroupHome"
            acRootGroupHome.Text = "Home"
            ' 
            ' Child Item 'Activity'
            ' 
            acItemActivity.Name = "acItemActivity"
            acItemActivity.Style = ElementStyle.Item
            acItemActivity.Tag = "idActivity"
            acItemActivity.Text = "Activity"
            ' 
            ' Child Item 'News'
            ' 
            acItemNews.Name = "acItemNews"
            acItemNews.Style = ElementStyle.Item
            acItemNews.Tag = "idNews"
            acItemNews.Text = "News"
            ' 
            ' Root Item 'Settings' with ContentContainer
            ' 
            acRootItemSettings.ImageOptions.ImageUri.Uri = "Customization;Office2013"
            acRootItemSettings.Name = "acRootItemSettings"
            acRootItemSettings.Style = ElementStyle.Item
            acRootItemSettings.Text = "Settings"
            ' 
            ' itemSettingsControlContainer
            ' 
            Dim itemSettingsControlContainer As AccordionContentContainer = New AccordionContentContainer()
            Dim hyperlinkLabelControl1 As HyperlinkLabelControl = New HyperlinkLabelControl()
            Dim toggleSwitch1 As ToggleSwitch = New ToggleSwitch()
            acControl.Controls.Add(itemSettingsControlContainer)
            acRootItemSettings.ContentContainer = itemSettingsControlContainer
            itemSettingsControlContainer.Controls.Add(hyperlinkLabelControl1)
            itemSettingsControlContainer.Controls.Add(toggleSwitch1)
            itemSettingsControlContainer.Appearance.BackColor = System.Drawing.SystemColors.Control
            itemSettingsControlContainer.Appearance.Options.UseBackColor = True
            itemSettingsControlContainer.Height = 60
            ' 
            ' hyperlinkLabelControl1
            ' 
            hyperlinkLabelControl1.Location = New System.Drawing.Point(26, 33)
            hyperlinkLabelControl1.Size = New System.Drawing.Size(107, 13)
            hyperlinkLabelControl1.Text = "www.devexpress.com"
            AddHandler hyperlinkLabelControl1.HyperlinkClick, New DevExpress.Utils.HyperlinkClickEventHandler(AddressOf hyperlinkLabelControl1_HyperlinkClick)
            ' 
            ' toggleSwitch1
            ' 
            toggleSwitch1.EditValue = True
            toggleSwitch1.Location = New System.Drawing.Point(24, 3)
            toggleSwitch1.Properties.AllowFocused = False
            toggleSwitch1.Properties.AutoWidth = True
            toggleSwitch1.Properties.OffText = "Offline Mode"
            toggleSwitch1.Properties.OnText = "Onlne Mode"
            toggleSwitch1.Size = New System.Drawing.Size(134, 24)
            AddHandler toggleSwitch1.Toggled, New EventHandler(AddressOf toggleSwitch1_Toggled)
            acControl.Elements.AddRange(New AccordionControlElement() {acRootGroupHome, acRootItemSettings})
            acRootItemSettings.Expanded = True
            acControl.EndUpdate()
        End Sub

        Private Sub accordionControl1_ElementClick(ByVal sender As Object, ByVal e As ElementClickEventArgs)
            If e.Element.Style = ElementStyle.Group Then Return
            If e.Element.Tag Is Nothing Then Return
            Dim itemID As String = e.Element.Tag.ToString()
            If Equals(itemID, "idNews") Then
            '...
            End If

            listBoxControl1.Items.Add(itemID & " clicked")
        End Sub

        Private Sub toggleSwitch1_Toggled(ByVal sender As Object, ByVal e As EventArgs)
        '...
        End Sub

        Private Sub hyperlinkLabelControl1_HyperlinkClick(ByVal sender As Object, ByVal e As DevExpress.Utils.HyperlinkClickEventArgs)
            Call Process.Start(e.Text)
        End Sub
    End Class
End Namespace
