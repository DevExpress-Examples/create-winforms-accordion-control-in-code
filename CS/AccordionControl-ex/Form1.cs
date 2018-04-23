using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccordionControl_ex {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        AccordionControl acControl;

        private void Form1_Load(object sender, EventArgs e) {
            acControl = new AccordionControl();
            acControl.Dock = DockStyle.Left;
            acControl.Parent = this;
            acControl.Width = 200;
            InitAccordionControl();
        }

        private void InitAccordionControl() {
            acControl.BeginUpdate();
            AccordionControlElement acRootGroupHome = new AccordionControlElement();
            AccordionControlElement acItemActivity = new AccordionControlElement();
            AccordionControlElement acItemNews = new AccordionControlElement();
            AccordionControlElement acRootItemSettings = new AccordionControlElement();

            acControl.ElementClick += new ElementClickEventHandler(this.accordionControl1_ElementClick);

            // 
            // Root Group 'Home'
            // 
            acRootGroupHome.Elements.AddRange(new AccordionControlElement[] {
            acItemActivity,
            acItemNews});
            acRootGroupHome.Expanded = true;
            acRootGroupHome.ImageOptions.ImageUri.Uri = "Home;Office2013";
            acRootGroupHome.Name = "acRootGroupHome";
            acRootGroupHome.Text = "Home";
            // 
            // Child Item 'Activity'
            // 
            acItemActivity.Name = "acItemActivity";
            acItemActivity.Style = ElementStyle.Item;
            acItemActivity.Tag = "idActivity";
            acItemActivity.Text = "Activity";
            // 
            // Child Item 'News'
            // 
            acItemNews.Name = "acItemNews";
            acItemNews.Style = ElementStyle.Item;
            acItemNews.Tag = "idNews";
            acItemNews.Text = "News";
            // 
            // Root Item 'Settings' with ContentContainer
            // 
            acRootItemSettings.ImageOptions.ImageUri.Uri = "Customization;Office2013";
            acRootItemSettings.Name = "acRootItemSettings";
            acRootItemSettings.Style = ElementStyle.Item;
            acRootItemSettings.Text = "Settings";
            // 
            // itemSettingsControlContainer
            // 
            AccordionContentContainer itemSettingsControlContainer = new AccordionContentContainer();
            HyperlinkLabelControl hyperlinkLabelControl1 = new HyperlinkLabelControl();
            ToggleSwitch toggleSwitch1 = new ToggleSwitch();
            acControl.Controls.Add(itemSettingsControlContainer);
            acRootItemSettings.ContentContainer = itemSettingsControlContainer;
            itemSettingsControlContainer.Controls.Add(hyperlinkLabelControl1);
            itemSettingsControlContainer.Controls.Add(toggleSwitch1);
            itemSettingsControlContainer.Appearance.BackColor = System.Drawing.SystemColors.Control;
            itemSettingsControlContainer.Appearance.Options.UseBackColor = true;
            itemSettingsControlContainer.Height = 60;
            // 
            // hyperlinkLabelControl1
            // 
            hyperlinkLabelControl1.Location = new System.Drawing.Point(26, 33);
            hyperlinkLabelControl1.Size = new System.Drawing.Size(107, 13);
            hyperlinkLabelControl1.Text = "www.devexpress.com";
            hyperlinkLabelControl1.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.hyperlinkLabelControl1_HyperlinkClick);
            // 
            // toggleSwitch1
            // 
            toggleSwitch1.EditValue = true;
            toggleSwitch1.Location = new System.Drawing.Point(24, 3);
            toggleSwitch1.Properties.AllowFocused = false;
            toggleSwitch1.Properties.AutoWidth = true;
            toggleSwitch1.Properties.OffText = "Offline Mode";
            toggleSwitch1.Properties.OnText = "Onlne Mode";
            toggleSwitch1.Size = new System.Drawing.Size(134, 24);
            toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);

            acControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
                acRootGroupHome,
                acRootItemSettings});

            acRootItemSettings.Expanded = true;

            acControl.EndUpdate();
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e) {
            if (e.Element.Style == DevExpress.XtraBars.Navigation.ElementStyle.Group) return;
            if (e.Element.Tag == null) return;
            string itemID = e.Element.Tag.ToString();
            if (itemID == "idNews") {
                //...
            }
            listBoxControl1.Items.Add(itemID + " clicked");
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e) {
            //...
        }

        private void hyperlinkLabelControl1_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e) {
            Process.Start(e.Text);
        }



    }
}
