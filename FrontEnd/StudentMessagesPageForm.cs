using System;
using System.Collections.Generic;
using System.ComponentModel; // Often needed for forms
using System.Data;           // Often needed for forms
using System.Drawing;        // Often needed for forms
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // This is crucial

namespace FrontEnd
{
    public partial class StudentMessagesPageForm : Form
    {
        // This is the constructor
        public StudentMessagesPageForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges48 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges49 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges46 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges47 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges44 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges45 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges43 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            SideBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ticketBtn = new Guna.UI2.WinForms.Guna2Button();
            announcementBtn = new Guna.UI2.WinForms.Guna2Button();
            MessagesBtn = new Guna.UI2.WinForms.Guna2Button();
            HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            convoPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            cvPanel6 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel21 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel20 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox5 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            flowLayoutContactPanel = new FlowLayoutPanel();
            SearchBoxPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ContactNameLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2CirclePictureBox4 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2HtmlLabel19 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            replyTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2HtmlLabel22 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2CirclePictureBox6 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel23 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel24 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel25 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel26 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            profileBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            SideBar.SuspendLayout();
            convoPanel.SuspendLayout();
            guna2Panel1.SuspendLayout();
            cvPanel6.SuspendLayout();
            guna2Panel6.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox5).BeginInit();
            flowLayoutContactPanel.SuspendLayout();
            SearchBoxPanel.SuspendLayout();
            guna2Panel3.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            guna2Panel2.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox2).BeginInit();
            guna2Panel4.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox3).BeginInit();
            guna2Panel5.SuspendLayout();
            ((ISupportInitialize)guna2CirclePictureBox4).BeginInit();
            ((ISupportInitialize)guna2CirclePictureBox6).BeginInit();
            guna2Panel7.SuspendLayout();
            guna2Panel8.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(profileBtn);
            guna2ShadowPanel1.Controls.Add(guna2Button10);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(2, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(1369, 103);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // guna2Button10
            // 
            guna2Button10.CustomizableEdges = customizableEdges3;
            guna2Button10.DisabledState.BorderColor = Color.DarkGray;
            guna2Button10.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button10.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button10.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button10.FillColor = Color.White;
            guna2Button10.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button10.ForeColor = Color.Black;
            guna2Button10.Image = Properties.Resources.StudentHub1;
            guna2Button10.ImageAlign = HorizontalAlignment.Left;
            guna2Button10.ImageSize = new Size(40, 40);
            guna2Button10.Location = new Point(28, 27);
            guna2Button10.Name = "guna2Button10";
            guna2Button10.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button10.Size = new Size(222, 45);
            guna2Button10.TabIndex = 0;
            guna2Button10.Text = "Student Hub";
            guna2Button10.TextAlign = HorizontalAlignment.Right;
            // 
            // SideBar
            // 
            SideBar.BorderColor = Color.FromArgb(224, 224, 224);
            SideBar.BorderRadius = 20;
            SideBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            SideBar.BorderThickness = 1;
            SideBar.Controls.Add(ticketBtn);
            SideBar.Controls.Add(announcementBtn);
            SideBar.Controls.Add(MessagesBtn);
            SideBar.Controls.Add(HomeBtn);
            SideBar.CustomizableEdges = customizableEdges13;
            SideBar.Location = new Point(12, 109);
            SideBar.Name = "SideBar";
            SideBar.ShadowDecoration.CustomizableEdges = customizableEdges14;
            SideBar.Size = new Size(352, 243);
            SideBar.TabIndex = 2;
            // 
            // ticketBtn
            // 
            ticketBtn.BackColor = Color.Transparent;
            ticketBtn.BorderColor = Color.Transparent;
            ticketBtn.BorderRadius = 10;
            ticketBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            ticketBtn.BorderThickness = 1;
            ticketBtn.CustomizableEdges = customizableEdges5;
            ticketBtn.DisabledState.BorderColor = Color.DarkGray;
            ticketBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ticketBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ticketBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ticketBtn.FillColor = Color.White;
            ticketBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ticketBtn.ForeColor = Color.DimGray;
            ticketBtn.Image = Properties.Resources.ticketicon;
            ticketBtn.ImageAlign = HorizontalAlignment.Left;
            ticketBtn.Location = new Point(16, 175);
            ticketBtn.Name = "ticketBtn";
            ticketBtn.PressedColor = SystemColors.MenuHighlight;
            ticketBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ticketBtn.Size = new Size(317, 45);
            ticketBtn.TabIndex = 3;
            ticketBtn.Text = "Ticket";
            ticketBtn.TextAlign = HorizontalAlignment.Left;
            // 
            // announcementBtn
            // 
            announcementBtn.BackColor = Color.Transparent;
            announcementBtn.BorderColor = Color.Transparent;
            announcementBtn.BorderRadius = 10;
            announcementBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            announcementBtn.BorderThickness = 1;
            announcementBtn.CustomizableEdges = customizableEdges7;
            announcementBtn.DisabledState.BorderColor = Color.DarkGray;
            announcementBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            announcementBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            announcementBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            announcementBtn.FillColor = Color.White;
            announcementBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            announcementBtn.ForeColor = Color.DimGray;
            announcementBtn.Image = Properties.Resources.annIcon;
            announcementBtn.ImageAlign = HorizontalAlignment.Left;
            announcementBtn.Location = new Point(16, 124);
            announcementBtn.Name = "announcementBtn";
            announcementBtn.PressedColor = SystemColors.MenuHighlight;
            announcementBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            announcementBtn.Size = new Size(317, 45);
            announcementBtn.TabIndex = 2;
            announcementBtn.Text = "Announcement";
            announcementBtn.TextAlign = HorizontalAlignment.Left;
            // 
            // MessagesBtn
            // 
            MessagesBtn.BackColor = Color.Transparent;
            MessagesBtn.BorderColor = Color.Transparent;
            MessagesBtn.BorderRadius = 10;
            MessagesBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            MessagesBtn.BorderThickness = 1;
            MessagesBtn.CustomizableEdges = customizableEdges9;
            MessagesBtn.DisabledState.BorderColor = Color.DarkGray;
            MessagesBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            MessagesBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            MessagesBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            MessagesBtn.FillColor = Color.White;
            MessagesBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MessagesBtn.ForeColor = Color.DimGray;
            MessagesBtn.Image = Properties.Resources.Chat_Bubble1;
            MessagesBtn.ImageAlign = HorizontalAlignment.Left;
            MessagesBtn.Location = new Point(16, 73);
            MessagesBtn.Name = "MessagesBtn";
            MessagesBtn.PressedColor = SystemColors.MenuHighlight;
            MessagesBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            MessagesBtn.Size = new Size(317, 45);
            MessagesBtn.TabIndex = 1;
            MessagesBtn.Text = "Messages";
            MessagesBtn.TextAlign = HorizontalAlignment.Left;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.BorderColor = Color.Transparent;
            HomeBtn.BorderRadius = 10;
            HomeBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            HomeBtn.BorderThickness = 1;
            HomeBtn.CustomizableEdges = customizableEdges11;
            HomeBtn.DisabledState.BorderColor = Color.DarkGray;
            HomeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            HomeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            HomeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            HomeBtn.FillColor = Color.White;
            HomeBtn.Font = new Font("Montserrat", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtn.ForeColor = Color.DimGray;
            HomeBtn.Image = Properties.Resources.homeicon;
            HomeBtn.ImageAlign = HorizontalAlignment.Left;
            HomeBtn.Location = new Point(16, 22);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.PressedColor = SystemColors.MenuHighlight;
            HomeBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            HomeBtn.Size = new Size(317, 45);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "Home";
            HomeBtn.TextAlign = HorizontalAlignment.Left;
            // 
            // convoPanel
            // 
            convoPanel.BorderColor = Color.Silver;
            convoPanel.BorderRadius = 10;
            convoPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            convoPanel.BorderThickness = 1;
            convoPanel.Controls.Add(guna2Panel1);
            convoPanel.Controls.Add(guna2HtmlLabel19);
            convoPanel.CustomizableEdges = customizableEdges48;
            convoPanel.FillColor = Color.White;
            convoPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convoPanel.Location = new Point(389, 109);
            convoPanel.Name = "convoPanel";
            convoPanel.ShadowDecoration.CustomizableEdges = customizableEdges49;
            convoPanel.Size = new Size(951, 573);
            convoPanel.TabIndex = 3;
            convoPanel.Paint += convoPanel_Paint;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(cvPanel6);
            guna2Panel1.Controls.Add(flowLayoutContactPanel);
            guna2Panel1.CustomizableEdges = customizableEdges46;
            guna2Panel1.Location = new Point(3, 70);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges47;
            guna2Panel1.Size = new Size(945, 500);
            guna2Panel1.TabIndex = 3;
            // 
            // cvPanel6
            // 
            cvPanel6.BorderColor = Color.Gray;
            cvPanel6.Controls.Add(guna2Panel8);
            cvPanel6.Controls.Add(guna2Panel7);
            cvPanel6.Controls.Add(guna2CirclePictureBox6);
            cvPanel6.Controls.Add(guna2Button1);
            cvPanel6.Controls.Add(guna2HtmlLabel22);
            cvPanel6.Controls.Add(guna2ImageButton1);
            cvPanel6.Controls.Add(replyTxtbox);
            cvPanel6.Controls.Add(guna2Panel6);
            cvPanel6.CustomizableEdges = customizableEdges28;
            cvPanel6.Dock = DockStyle.Fill;
            cvPanel6.Location = new Point(287, 0);
            cvPanel6.Name = "cvPanel6";
            cvPanel6.ShadowDecoration.CustomizableEdges = customizableEdges29;
            cvPanel6.Size = new Size(658, 500);
            cvPanel6.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            guna2Panel6.BorderColor = Color.Gray;
            guna2Panel6.Controls.Add(guna2HtmlLabel21);
            guna2Panel6.Controls.Add(guna2HtmlLabel20);
            guna2Panel6.Controls.Add(guna2CirclePictureBox5);
            guna2Panel6.CustomizableEdges = customizableEdges26;
            guna2Panel6.Dock = DockStyle.Top;
            guna2Panel6.Location = new Point(0, 0);
            guna2Panel6.Name = "guna2Panel6";
            guna2Panel6.ShadowDecoration.CustomizableEdges = customizableEdges27;
            guna2Panel6.Size = new Size(658, 73);
            guna2Panel6.TabIndex = 0;
            // 
            // guna2HtmlLabel21
            // 
            guna2HtmlLabel21.BackColor = Color.Transparent;
            guna2HtmlLabel21.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel21.ForeColor = Color.Gray;
            guna2HtmlLabel21.Location = new Point(71, 43);
            guna2HtmlLabel21.Name = "guna2HtmlLabel21";
            guna2HtmlLabel21.Size = new Size(91, 15);
            guna2HtmlLabel21.TabIndex = 2;
            guna2HtmlLabel21.Text = "Academic Adviser";
            // 
            // guna2HtmlLabel20
            // 
            guna2HtmlLabel20.BackColor = Color.Transparent;
            guna2HtmlLabel20.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel20.Location = new Point(71, 16);
            guna2HtmlLabel20.Name = "guna2HtmlLabel20";
            guna2HtmlLabel20.Size = new Size(85, 22);
            guna2HtmlLabel20.TabIndex = 1;
            guna2HtmlLabel20.Text = "Dr. Johnson";
            // 
            // guna2CirclePictureBox5
            // 
            guna2CirclePictureBox5.FillColor = Color.CornflowerBlue;
            guna2CirclePictureBox5.ImageRotate = 0F;
            guna2CirclePictureBox5.Location = new Point(16, 16);
            guna2CirclePictureBox5.Name = "guna2CirclePictureBox5";
            guna2CirclePictureBox5.ShadowDecoration.CustomizableEdges = customizableEdges25;
            guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox5.Size = new Size(40, 40);
            guna2CirclePictureBox5.TabIndex = 0;
            guna2CirclePictureBox5.TabStop = false;
            // 
            // flowLayoutContactPanel
            // 
            flowLayoutContactPanel.BackColor = Color.White;
            flowLayoutContactPanel.Controls.Add(SearchBoxPanel);
            flowLayoutContactPanel.Controls.Add(guna2Panel3);
            flowLayoutContactPanel.Controls.Add(guna2Panel2);
            flowLayoutContactPanel.Controls.Add(guna2Panel4);
            flowLayoutContactPanel.Controls.Add(guna2Panel5);
            flowLayoutContactPanel.Dock = DockStyle.Left;
            flowLayoutContactPanel.Location = new Point(0, 0);
            flowLayoutContactPanel.Name = "flowLayoutContactPanel";
            flowLayoutContactPanel.Size = new Size(287, 500);
            flowLayoutContactPanel.TabIndex = 0;
            // 
            // SearchBoxPanel
            // 
            SearchBoxPanel.BorderColor = Color.LightGray;
            SearchBoxPanel.Controls.Add(guna2TextBox1);
            SearchBoxPanel.CustomizableEdges = customizableEdges32;
            SearchBoxPanel.FillColor = Color.White;
            SearchBoxPanel.Location = new Point(3, 3);
            SearchBoxPanel.Name = "SearchBoxPanel";
            SearchBoxPanel.ShadowDecoration.CustomizableEdges = customizableEdges33;
            SearchBoxPanel.Size = new Size(279, 62);
            SearchBoxPanel.TabIndex = 0;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BackColor = Color.Transparent;
            guna2TextBox1.BorderColor = SystemColors.InactiveCaption;
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2TextBox1.BorderThickness = 2;
            guna2TextBox1.CustomizableEdges = customizableEdges30;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FillColor = SystemColors.GradientInactiveCaption;
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(12, 13);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges31;
            guna2TextBox1.Size = new Size(240, 36);
            guna2TextBox1.TabIndex = 0;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderColor = Color.Gray;
            guna2Panel3.BorderThickness = 1;
            guna2Panel3.Controls.Add(guna2HtmlLabel3);
            guna2Panel3.Controls.Add(guna2HtmlLabel1);
            guna2Panel3.Controls.Add(messageLabel1);
            guna2Panel3.Controls.Add(guna2HtmlLabel2);
            guna2Panel3.Controls.Add(ContactNameLabel1);
            guna2Panel3.Controls.Add(guna2CirclePictureBox1);
            guna2Panel3.CustomizableEdges = customizableEdges35;
            guna2Panel3.FillColor = Color.White;
            guna2Panel3.Location = new Point(3, 71);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges36;
            guna2Panel3.Size = new Size(279, 64);
            guna2Panel3.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.Gray;
            guna2HtmlLabel3.Location = new Point(203, 8);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(61, 16);
            guna2HtmlLabel3.TabIndex = 4;
            guna2HtmlLabel3.Text = "10 mins ago";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.CornflowerBlue;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(23, 19);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(17, 19);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "DJ";
            // 
            // messageLabel1
            // 
            messageLabel1.BackColor = Color.Transparent;
            messageLabel1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messageLabel1.ForeColor = Color.Gray;
            messageLabel1.Location = new Point(62, 38);
            messageLabel1.Name = "messageLabel1";
            messageLabel1.Size = new Size(120, 16);
            messageLabel1.TabIndex = 3;
            messageLabel1.Text = "Your Thesis looks great!";
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI Emoji", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.Gray;
            guna2HtmlLabel2.Location = new Point(62, 24);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(73, 14);
            guna2HtmlLabel2.TabIndex = 2;
            guna2HtmlLabel2.Text = "Academic Adviser";
            guna2HtmlLabel2.Click += guna2HtmlLabel2_Click;
            // 
            // ContactNameLabel1
            // 
            ContactNameLabel1.BackColor = Color.Transparent;
            ContactNameLabel1.Font = new Font("Segoe MDL2 Assets", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactNameLabel1.Location = new Point(62, 7);
            ContactNameLabel1.Name = "ContactNameLabel1";
            ContactNameLabel1.Size = new Size(72, 17);
            ContactNameLabel1.TabIndex = 1;
            ContactNameLabel1.Text = "Dr. Johnson";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            guna2CirclePictureBox1.FillColor = Color.CornflowerBlue;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(12, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges34;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(35, 35);
            guna2CirclePictureBox1.TabIndex = 0;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BorderColor = Color.Gray;
            guna2Panel2.BorderThickness = 1;
            guna2Panel2.Controls.Add(guna2HtmlLabel4);
            guna2Panel2.Controls.Add(guna2HtmlLabel5);
            guna2Panel2.Controls.Add(guna2HtmlLabel6);
            guna2Panel2.Controls.Add(guna2HtmlLabel7);
            guna2Panel2.Controls.Add(guna2HtmlLabel8);
            guna2Panel2.Controls.Add(guna2CirclePictureBox2);
            guna2Panel2.CustomizableEdges = customizableEdges38;
            guna2Panel2.FillColor = Color.White;
            guna2Panel2.Location = new Point(3, 141);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges39;
            guna2Panel2.Size = new Size(279, 64);
            guna2Panel2.TabIndex = 5;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel4.ForeColor = Color.Gray;
            guna2HtmlLabel4.Location = new Point(228, 8);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(36, 16);
            guna2HtmlLabel4.TabIndex = 4;
            guna2HtmlLabel4.Text = "2h ago";
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.BackColor = Color.CornflowerBlue;
            guna2HtmlLabel5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.White;
            guna2HtmlLabel5.Location = new Point(18, 19);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(22, 19);
            guna2HtmlLabel5.TabIndex = 1;
            guna2HtmlLabel5.Text = "AO";
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel6.ForeColor = Color.Gray;
            guna2HtmlLabel6.Location = new Point(62, 38);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(141, 16);
            guna2HtmlLabel6.TabIndex = 3;
            guna2HtmlLabel6.Text = "Reminder: Registration dea...\r\n";
            // 
            // guna2HtmlLabel7
            // 
            guna2HtmlLabel7.BackColor = Color.Transparent;
            guna2HtmlLabel7.Font = new Font("Segoe UI Emoji", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel7.ForeColor = Color.Gray;
            guna2HtmlLabel7.Location = new Point(62, 24);
            guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            guna2HtmlLabel7.Size = new Size(61, 14);
            guna2HtmlLabel7.TabIndex = 2;
            guna2HtmlLabel7.Text = "Administration";
            // 
            // guna2HtmlLabel8
            // 
            guna2HtmlLabel8.BackColor = Color.Transparent;
            guna2HtmlLabel8.Font = new Font("Segoe MDL2 Assets", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel8.Location = new Point(62, 7);
            guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            guna2HtmlLabel8.Size = new Size(97, 17);
            guna2HtmlLabel8.TabIndex = 1;
            guna2HtmlLabel8.Text = "Academic Office";
            // 
            // guna2CirclePictureBox2
            // 
            guna2CirclePictureBox2.FillColor = Color.CornflowerBlue;
            guna2CirclePictureBox2.ImageRotate = 0F;
            guna2CirclePictureBox2.Location = new Point(12, 12);
            guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges37;
            guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox2.Size = new Size(35, 35);
            guna2CirclePictureBox2.TabIndex = 0;
            guna2CirclePictureBox2.TabStop = false;
            // 
            // guna2Panel4
            // 
            guna2Panel4.BorderColor = Color.Gray;
            guna2Panel4.BorderThickness = 1;
            guna2Panel4.Controls.Add(guna2HtmlLabel9);
            guna2Panel4.Controls.Add(guna2HtmlLabel10);
            guna2Panel4.Controls.Add(guna2HtmlLabel11);
            guna2Panel4.Controls.Add(guna2HtmlLabel12);
            guna2Panel4.Controls.Add(guna2HtmlLabel13);
            guna2Panel4.Controls.Add(guna2CirclePictureBox3);
            guna2Panel4.CustomizableEdges = customizableEdges41;
            guna2Panel4.FillColor = Color.White;
            guna2Panel4.Location = new Point(3, 211);
            guna2Panel4.Name = "guna2Panel4";
            guna2Panel4.ShadowDecoration.CustomizableEdges = customizableEdges42;
            guna2Panel4.Size = new Size(279, 64);
            guna2Panel4.TabIndex = 6;
            // 
            // guna2HtmlLabel9
            // 
            guna2HtmlLabel9.BackColor = Color.Transparent;
            guna2HtmlLabel9.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel9.ForeColor = Color.Gray;
            guna2HtmlLabel9.Location = new Point(228, 8);
            guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            guna2HtmlLabel9.Size = new Size(36, 16);
            guna2HtmlLabel9.TabIndex = 4;
            guna2HtmlLabel9.Text = "1d ago";
            // 
            // guna2HtmlLabel10
            // 
            guna2HtmlLabel10.BackColor = Color.CornflowerBlue;
            guna2HtmlLabel10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel10.ForeColor = Color.White;
            guna2HtmlLabel10.Location = new Point(18, 19);
            guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            guna2HtmlLabel10.Size = new Size(23, 19);
            guna2HtmlLabel10.TabIndex = 1;
            guna2HtmlLabel10.Text = "PM";
            // 
            // guna2HtmlLabel11
            // 
            guna2HtmlLabel11.BackColor = Color.Transparent;
            guna2HtmlLabel11.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel11.ForeColor = Color.Gray;
            guna2HtmlLabel11.Location = new Point(62, 38);
            guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            guna2HtmlLabel11.Size = new Size(143, 16);
            guna2HtmlLabel11.TabIndex = 3;
            guna2HtmlLabel11.Text = "Thanks for your presentation";
            // 
            // guna2HtmlLabel12
            // 
            guna2HtmlLabel12.BackColor = Color.Transparent;
            guna2HtmlLabel12.Font = new Font("Segoe UI Emoji", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel12.ForeColor = Color.Gray;
            guna2HtmlLabel12.Location = new Point(62, 24);
            guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            guna2HtmlLabel12.Size = new Size(70, 14);
            guna2HtmlLabel12.TabIndex = 2;
            guna2HtmlLabel12.Text = "Course Instructor";
            // 
            // guna2HtmlLabel13
            // 
            guna2HtmlLabel13.BackColor = Color.Transparent;
            guna2HtmlLabel13.Font = new Font("Segoe MDL2 Assets", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel13.Location = new Point(62, 7);
            guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            guna2HtmlLabel13.Size = new Size(83, 17);
            guna2HtmlLabel13.TabIndex = 1;
            guna2HtmlLabel13.Text = "Prof. Martinez";
            // 
            // guna2CirclePictureBox3
            // 
            guna2CirclePictureBox3.FillColor = Color.CornflowerBlue;
            guna2CirclePictureBox3.ImageRotate = 0F;
            guna2CirclePictureBox3.Location = new Point(12, 12);
            guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = customizableEdges40;
            guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox3.Size = new Size(35, 35);
            guna2CirclePictureBox3.TabIndex = 0;
            guna2CirclePictureBox3.TabStop = false;
            // 
            // guna2Panel5
            // 
            guna2Panel5.BorderColor = Color.Gray;
            guna2Panel5.BorderThickness = 1;
            guna2Panel5.Controls.Add(guna2HtmlLabel14);
            guna2Panel5.Controls.Add(guna2HtmlLabel15);
            guna2Panel5.Controls.Add(guna2HtmlLabel16);
            guna2Panel5.Controls.Add(guna2HtmlLabel17);
            guna2Panel5.Controls.Add(guna2HtmlLabel18);
            guna2Panel5.Controls.Add(guna2CirclePictureBox4);
            guna2Panel5.CustomizableEdges = customizableEdges44;
            guna2Panel5.FillColor = Color.White;
            guna2Panel5.Location = new Point(3, 281);
            guna2Panel5.Name = "guna2Panel5";
            guna2Panel5.ShadowDecoration.CustomizableEdges = customizableEdges45;
            guna2Panel5.Size = new Size(279, 64);
            guna2Panel5.TabIndex = 7;
            // 
            // guna2HtmlLabel14
            // 
            guna2HtmlLabel14.BackColor = Color.Transparent;
            guna2HtmlLabel14.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel14.ForeColor = Color.Gray;
            guna2HtmlLabel14.Location = new Point(228, 8);
            guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            guna2HtmlLabel14.Size = new Size(36, 16);
            guna2HtmlLabel14.TabIndex = 4;
            guna2HtmlLabel14.Text = "2d ago";
            // 
            // guna2HtmlLabel15
            // 
            guna2HtmlLabel15.BackColor = Color.CornflowerBlue;
            guna2HtmlLabel15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel15.ForeColor = Color.White;
            guna2HtmlLabel15.Location = new Point(23, 19);
            guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            guna2HtmlLabel15.Size = new Size(17, 19);
            guna2HtmlLabel15.TabIndex = 1;
            guna2HtmlLabel15.Text = "DJ";
            // 
            // guna2HtmlLabel16
            // 
            guna2HtmlLabel16.BackColor = Color.Transparent;
            guna2HtmlLabel16.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel16.ForeColor = Color.Gray;
            guna2HtmlLabel16.Location = new Point(62, 38);
            guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            guna2HtmlLabel16.Size = new Size(146, 16);
            guna2HtmlLabel16.TabIndex = 3;
            guna2HtmlLabel16.Text = "Your request has been proc..";
            // 
            // guna2HtmlLabel17
            // 
            guna2HtmlLabel17.BackColor = Color.Transparent;
            guna2HtmlLabel17.Font = new Font("Segoe UI Emoji", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel17.ForeColor = Color.Gray;
            guna2HtmlLabel17.Location = new Point(62, 24);
            guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            guna2HtmlLabel17.Size = new Size(34, 14);
            guna2HtmlLabel17.TabIndex = 2;
            guna2HtmlLabel17.Text = "Support";
            // 
            // guna2HtmlLabel18
            // 
            guna2HtmlLabel18.BackColor = Color.Transparent;
            guna2HtmlLabel18.Font = new Font("Segoe MDL2 Assets", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel18.Location = new Point(62, 7);
            guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            guna2HtmlLabel18.Size = new Size(101, 17);
            guna2HtmlLabel18.TabIndex = 1;
            guna2HtmlLabel18.Text = "Student Services";
            // 
            // guna2CirclePictureBox4
            // 
            guna2CirclePictureBox4.FillColor = Color.CornflowerBlue;
            guna2CirclePictureBox4.ImageRotate = 0F;
            guna2CirclePictureBox4.Location = new Point(12, 12);
            guna2CirclePictureBox4.Name = "guna2CirclePictureBox4";
            guna2CirclePictureBox4.ShadowDecoration.CustomizableEdges = customizableEdges43;
            guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox4.Size = new Size(35, 35);
            guna2CirclePictureBox4.TabIndex = 0;
            guna2CirclePictureBox4.TabStop = false;
            // 
            // guna2HtmlLabel19
            // 
            guna2HtmlLabel19.BackColor = Color.Transparent;
            guna2HtmlLabel19.Font = new Font("Montserrat", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel19.Location = new Point(12, 22);
            guna2HtmlLabel19.Name = "guna2HtmlLabel19";
            guna2HtmlLabel19.Size = new Size(110, 31);
            guna2HtmlLabel19.TabIndex = 2;
            guna2HtmlLabel19.Text = "Messages";
            // 
            // replyTxtbox
            // 
            replyTxtbox.BackColor = Color.Transparent;
            replyTxtbox.BorderColor = Color.FromArgb(224, 224, 224);
            replyTxtbox.BorderRadius = 5;
            replyTxtbox.CustomizableEdges = customizableEdges23;
            replyTxtbox.DefaultText = "";
            replyTxtbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            replyTxtbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            replyTxtbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            replyTxtbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            replyTxtbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            replyTxtbox.Font = new Font("Segoe UI", 9F);
            replyTxtbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            replyTxtbox.Location = new Point(54, 450);
            replyTxtbox.Name = "replyTxtbox";
            replyTxtbox.PlaceholderText = "";
            replyTxtbox.SelectedText = "";
            replyTxtbox.ShadowDecoration.CustomizableEdges = customizableEdges24;
            replyTxtbox.Size = new Size(544, 36);
            replyTxtbox.TabIndex = 1;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Properties.Resources.Attach;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.ImageSize = new Size(30, 30);
            guna2ImageButton1.Location = new Point(16, 450);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges22;
            guna2ImageButton1.Size = new Size(30, 30);
            guna2ImageButton1.TabIndex = 2;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // guna2HtmlLabel22
            // 
            guna2HtmlLabel22.BackColor = Color.Transparent;
            guna2HtmlLabel22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel22.ForeColor = Color.DarkGray;
            guna2HtmlLabel22.Location = new Point(71, 463);
            guna2HtmlLabel22.Name = "guna2HtmlLabel22";
            guna2HtmlLabel22.Size = new Size(110, 17);
            guna2HtmlLabel22.TabIndex = 3;
            guna2HtmlLabel22.Text = "Type your message..";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 5;
            guna2Button1.CustomizableEdges = customizableEdges20;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.Sent1;
            guna2Button1.Location = new Point(605, 451);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges21;
            guna2Button1.Size = new Size(35, 35);
            guna2Button1.TabIndex = 4;
            // 
            // guna2CirclePictureBox6
            // 
            guna2CirclePictureBox6.BackColor = Color.Transparent;
            guna2CirclePictureBox6.FillColor = Color.FromArgb(221, 227, 238);
            guna2CirclePictureBox6.ImageRotate = 0F;
            guna2CirclePictureBox6.Location = new Point(16, 90);
            guna2CirclePictureBox6.Name = "guna2CirclePictureBox6";
            guna2CirclePictureBox6.ShadowDecoration.CustomizableEdges = customizableEdges19;
            guna2CirclePictureBox6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox6.Size = new Size(30, 30);
            guna2CirclePictureBox6.TabIndex = 5;
            guna2CirclePictureBox6.TabStop = false;
            // 
            // guna2Panel7
            // 
            guna2Panel7.BackColor = Color.Transparent;
            guna2Panel7.BorderRadius = 10;
            guna2Panel7.Controls.Add(guna2HtmlLabel24);
            guna2Panel7.Controls.Add(guna2HtmlLabel23);
            guna2Panel7.CustomizableEdges = customizableEdges17;
            guna2Panel7.FillColor = Color.FromArgb(221, 227, 238);
            guna2Panel7.Location = new Point(54, 90);
            guna2Panel7.Name = "guna2Panel7";
            guna2Panel7.ShadowDecoration.CustomizableEdges = customizableEdges18;
            guna2Panel7.Size = new Size(235, 60);
            guna2Panel7.TabIndex = 6;
            // 
            // guna2HtmlLabel23
            // 
            guna2HtmlLabel23.BackColor = Color.Transparent;
            guna2HtmlLabel23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel23.Location = new Point(17, 11);
            guna2HtmlLabel23.Name = "guna2HtmlLabel23";
            guna2HtmlLabel23.Size = new Size(196, 17);
            guna2HtmlLabel23.TabIndex = 0;
            guna2HtmlLabel23.Text = "Hi Sarah, I've review your thesis draft\r\n";
            // 
            // guna2HtmlLabel24
            // 
            guna2HtmlLabel24.BackColor = Color.Transparent;
            guna2HtmlLabel24.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel24.ForeColor = Color.DimGray;
            guna2HtmlLabel24.Location = new Point(17, 34);
            guna2HtmlLabel24.Name = "guna2HtmlLabel24";
            guna2HtmlLabel24.Size = new Size(50, 15);
            guna2HtmlLabel24.TabIndex = 1;
            guna2HtmlLabel24.Text = "10:15 AM";
            // 
            // guna2Panel8
            // 
            guna2Panel8.BackColor = Color.Transparent;
            guna2Panel8.BorderRadius = 10;
            guna2Panel8.Controls.Add(guna2HtmlLabel25);
            guna2Panel8.Controls.Add(guna2HtmlLabel26);
            guna2Panel8.CustomizableEdges = customizableEdges15;
            guna2Panel8.FillColor = SystemColors.Highlight;
            guna2Panel8.Location = new Point(395, 160);
            guna2Panel8.Name = "guna2Panel8";
            guna2Panel8.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2Panel8.Size = new Size(245, 60);
            guna2Panel8.TabIndex = 7;
            // 
            // guna2HtmlLabel25
            // 
            guna2HtmlLabel25.BackColor = Color.Transparent;
            guna2HtmlLabel25.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel25.ForeColor = Color.White;
            guna2HtmlLabel25.Location = new Point(17, 34);
            guna2HtmlLabel25.Name = "guna2HtmlLabel25";
            guna2HtmlLabel25.Size = new Size(50, 15);
            guna2HtmlLabel25.TabIndex = 1;
            guna2HtmlLabel25.Text = "10:20 AM";
            // 
            // guna2HtmlLabel26
            // 
            guna2HtmlLabel26.BackColor = Color.Transparent;
            guna2HtmlLabel26.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel26.ForeColor = Color.White;
            guna2HtmlLabel26.Location = new Point(17, 11);
            guna2HtmlLabel26.Name = "guna2HtmlLabel26";
            guna2HtmlLabel26.Size = new Size(220, 17);
            guna2HtmlLabel26.TabIndex = 0;
            guna2HtmlLabel26.Text = "Thank you! I'd love to hear your feedback";
            // 
            // profileBtn
            // 
            profileBtn.CustomizableEdges = customizableEdges1;
            profileBtn.DisabledState.BorderColor = Color.DarkGray;
            profileBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            profileBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            profileBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            profileBtn.FillColor = Color.White;
            profileBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBtn.ForeColor = Color.DimGray;
            profileBtn.Image = Properties.Resources.Customer;
            profileBtn.ImageAlign = HorizontalAlignment.Left;
            profileBtn.ImageSize = new Size(30, 30);
            profileBtn.Location = new Point(1201, 27);
            profileBtn.Name = "profileBtn";
            profileBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            profileBtn.Size = new Size(116, 45);
            profileBtn.TabIndex = 2;
            profileBtn.Text = "Profile";
            profileBtn.TextAlign = HorizontalAlignment.Right;
            // 
            // StudentMessagesPageForm
            // 
            ClientSize = new Size(1370, 749);
            Controls.Add(convoPanel);
            Controls.Add(SideBar);
            Controls.Add(guna2ShadowPanel1);
            Name = "StudentMessagesPageForm";
            Text = "Messages Form";
            Load += MessagesPageForm_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            SideBar.ResumeLayout(false);
            convoPanel.ResumeLayout(false);
            convoPanel.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            cvPanel6.ResumeLayout(false);
            cvPanel6.PerformLayout();
            guna2Panel6.ResumeLayout(false);
            guna2Panel6.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox5).EndInit();
            flowLayoutContactPanel.ResumeLayout(false);
            SearchBoxPanel.ResumeLayout(false);
            guna2Panel3.ResumeLayout(false);
            guna2Panel3.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox1).EndInit();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox2).EndInit();
            guna2Panel4.ResumeLayout(false);
            guna2Panel4.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox3).EndInit();
            guna2Panel5.ResumeLayout(false);
            guna2Panel5.PerformLayout();
            ((ISupportInitialize)guna2CirclePictureBox4).EndInit();
            ((ISupportInitialize)guna2CirclePictureBox6).EndInit();
            guna2Panel7.ResumeLayout(false);
            guna2Panel7.PerformLayout();
            guna2Panel8.ResumeLayout(false);
            guna2Panel8.PerformLayout();
            ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SideBar;
        private Guna.UI2.WinForms.Guna2Button ticketBtn;
        private Guna.UI2.WinForms.Guna2Button announcementBtn;
        private Guna.UI2.WinForms.Guna2Button MessagesBtn;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Panel convoPanel;
        private FlowLayoutPanel flowLayoutContactPanel;
        private Guna.UI2.WinForms.Guna2Panel SearchBoxPanel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel ContactNameLabel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel messageLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel19;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel cvPanel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel21;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel20;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox5;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;

        // --- New runtime-only chat UI fields ---
        private Panel messagesContainer; // holds message rows and scrolls
        private Guna.UI2.WinForms.Guna2Panel inputPanel;
        private Guna.UI2.WinForms.Guna2TextBox messageInputBox;
        private Guna.UI2.WinForms.Guna2Button sendMessageButton;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2TextBox replyTxtbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel22;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel25;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel26;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel24;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel23;
        private Guna.UI2.WinForms.Guna2Button profileBtn;
        private int messagesY = 10;

        private void MessagesPageForm_Load(object sender, EventArgs e)
        {
            // initialize the dynamic chat area and input controls
            InitializeChatUI();

            // sample messages to mirror the prototype
            AddMessage("Hi Sarah, I've reviewed your thesis draft.", false, "10:15 AM");
            AddMessage("Thank you! I'd love to hear your feedback.", true, "10:20 AM");
            AddMessage("Overall it's excellent work. Just a few minor suggestions on the methodology section.", false, "10:25 AM");
            AddMessage("Could we schedule a meeting this week to discuss?", false, "10:26 AM");
            AddMessage("Absolutely! Would Thursday afternoon work for you?", true, "10:30 AM");
        }

        private void InitializeChatUI()
        {
            // messages container
            messagesContainer = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(10)
            };

            // input panel docked to bottom
            inputPanel = new Guna.UI2.WinForms.Guna2Panel
            {
                Dock = DockStyle.Bottom,
                Height = 64,
                BackColor = Color.WhiteSmoke,
                Padding = new Padding(10)
            };

            // message input
            messageInputBox = new Guna.UI2.WinForms.Guna2TextBox
            {
                PlaceholderText = "Type your message...",
                BorderRadius = 12,
                BorderThickness = 1,
                FillColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                Dock = DockStyle.Fill
            };

            // send button
            sendMessageButton = new Guna.UI2.WinForms.Guna2Button
            {
                Text = "",
                // Image assignment removed because no sendicon resource was found in .resx
                ImageSize = new Size(20, 20),
                BorderRadius = 12,
                Width = 48,
                Dock = DockStyle.Right,
                FillColor = Color.FromArgb(0, 123, 200),
                ForeColor = Color.White
            };
            sendMessageButton.Click += SendMessageButton_Click;

            // layout: add input box and send button into inputPanel
            inputPanel.Controls.Add(messageInputBox);
            inputPanel.Controls.Add(sendMessageButton);

            // Add messagesContainer and inputPanel into cvPanel6 (cvPanel6 already has header docked top)
            cvPanel6.Controls.Add(messagesContainer);
            cvPanel6.Controls.Add(inputPanel);

            // reposition children to respect docking order
            messagesContainer.BringToFront();
            inputPanel.BringToFront();

            // handle resize to reflow aligned bubbles
            messagesContainer.Resize += (s, e) => ReflowMessages();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            var text = messageInputBox.Text.Trim();
            if (string.IsNullOrEmpty(text)) return;

            AddMessage(text, true, DateTime.Now.ToShortTimeString());
            messageInputBox.Text = "";
            messageInputBox.Focus();
        }

        /// <summary>
        /// Adds a message bubble to the messages container.
        /// outgoing=true aligns to the right using container sizing; incoming=false aligns left.
        /// </summary>
        private void AddMessage(string text, bool outgoing, string time = null)
        {
            if (messagesContainer == null) return;

            // container row - full width, holds bubble and time label
            var row = new Panel
            {
                Width = Math.Max(100, messagesContainer.ClientSize.Width - 20),
                Height = 10, // will be adjusted
                BackColor = Color.Transparent
            };

            // bubble styling
            var bubble = new Panel
            {
                BackColor = outgoing ? Color.FromArgb(0, 123, 200) : Color.FromArgb(240, 245, 250),
                Padding = new Padding(10),
                AutoSize = true,
                MaximumSize = new Size(row.Width - 80, 0),
                BorderStyle = BorderStyle.None
            };

            var lbl = new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 9F),
                ForeColor = outgoing ? Color.White : Color.Black,
                AutoSize = false,
                MaximumSize = new Size(bubble.MaximumSize.Width, 0),
                Width = bubble.MaximumSize.Width,
            };
            // Let label compute height with WordWrap by measuring
            lbl.Height = TextRenderer.MeasureText(lbl.Text, lbl.Font, new Size(lbl.Width, 0), TextFormatFlags.WordBreak).Height;

            lbl.AutoSize = false;
            lbl.Size = new Size(Math.Min(lbl.Width, lbl.PreferredWidth), lbl.Height);
            lbl.MaximumSize = new Size(bubble.MaximumSize.Width, 0);

            bubble.Controls.Add(lbl);

            // time label
            var timeLbl = new Label
            {
                Text = time ?? DateTime.Now.ToShortTimeString(),
                Font = new Font("Segoe UI", 7F),
                ForeColor = Color.Gray,
                AutoSize = true,
                BackColor = Color.Transparent
            };

            // Calculate sizes
            bubble.Width = lbl.Width + bubble.Padding.Left + bubble.Padding.Right;
            bubble.Height = lbl.Height + bubble.Padding.Top + bubble.Padding.Bottom;

            // position bubble inside row
            const int marginHorizontal = 12;
            const int marginVertical = 6;
            row.Height = bubble.Height + timeLbl.Height + (marginVertical * 2);

            if (outgoing)
            {
                bubble.Location = new Point(row.Width - bubble.Width - marginHorizontal, marginVertical);
                timeLbl.Location = new Point(row.Width - timeLbl.Width - marginHorizontal, bubble.Bottom + 2);
            }
            else
            {
                bubble.Location = new Point(marginHorizontal, marginVertical);
                timeLbl.Location = new Point(bubble.Right + 8, bubble.Bottom - timeLbl.Height); // place time to the right of the bubble or below
            }

            // Round corners for bubble (simple: use Region)
            int radius = 8;
            var r = new System.Drawing.Drawing2D.GraphicsPath();
            r.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            r.AddArc(new Rectangle(bubble.Width - radius, 0, radius, radius), -90, 90);
            r.AddArc(new Rectangle(bubble.Width - radius, bubble.Height - radius, radius, radius), 0, 90);
            r.AddArc(new Rectangle(0, bubble.Height - radius, radius, radius), 90, 90);
            r.CloseFigure();
            bubble.Region = new Region(r);

            // add to row then to messagesContainer
            row.Controls.Add(bubble);
            row.Controls.Add(timeLbl);

            // location Y
            row.Location = new Point(0, messagesY);
            messagesY += row.Height + 8;

            messagesContainer.Controls.Add(row);

            // scroll to bottom
            messagesContainer.ScrollControlIntoView(row);
        }

        /// <summary>
        /// Repositions bubbles when container resizes.
        /// </summary>
        private void ReflowMessages()
        {
            messagesY = 10;
            foreach (Control row in messagesContainer.Controls)
            {
                row.Width = Math.Max(100, messagesContainer.ClientSize.Width - 20);
                Control bubble = null;
                Control timeLbl = null;
                foreach (Control c in row.Controls)
                {
                    if (c is Panel) bubble = c;
                    else if (c is Label) timeLbl = c;
                }

                if (bubble != null)
                {
                    const int marginHorizontal = 12;
                    const int marginVertical = 6;
                    row.Height = bubble.Height + (timeLbl?.Height ?? 0) + (marginVertical * 2);

                    bool isOutgoing = bubble.BackColor == Color.FromArgb(0, 123, 200);
                    if (isOutgoing)
                    {
                        bubble.Location = new Point(row.Width - bubble.Width - marginHorizontal, marginVertical);
                        if (timeLbl != null) timeLbl.Location = new Point(row.Width - timeLbl.Width - marginHorizontal, bubble.Bottom + 2);
                    }
                    else
                    {
                        bubble.Location = new Point(marginHorizontal, marginVertical);
                        if (timeLbl != null) timeLbl.Location = new Point(bubble.Right + 8, bubble.Bottom - timeLbl.Height);
                    }
                }

                row.Location = new Point(0, messagesY);
                messagesY += row.Height + 8;
            }
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void convoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}