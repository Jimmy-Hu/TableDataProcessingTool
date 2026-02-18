namespace TableDataProcessingTool.WinForms.Settings
{
    partial class SettingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Setting = new System.Windows.Forms.TabControl();
            this.StylePage = new System.Windows.Forms.TabPage();
            this.fontSelectorComboBox = new TableDataProcessingTool.ExtendedComponents.FontSelectorComboBox();
            this.label_BackColor = new System.Windows.Forms.Label();
            this.colorSelectorComboBox = new TableDataProcessingTool.ExtendedComponents.ColorSelectorComboBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Setting.SuspendLayout();
            this.StylePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Setting
            // 
            this.tabControl_Setting.Controls.Add(this.StylePage);
            this.tabControl_Setting.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Setting.Name = "tabControl_Setting";
            this.tabControl_Setting.SelectedIndex = 0;
            this.tabControl_Setting.Size = new System.Drawing.Size(776, 396);
            this.tabControl_Setting.TabIndex = 0;
            // 
            // StylePage
            // 
            this.StylePage.Controls.Add(this.label1);
            this.StylePage.Controls.Add(this.fontSelectorComboBox);
            this.StylePage.Controls.Add(this.label_BackColor);
            this.StylePage.Controls.Add(this.colorSelectorComboBox);
            this.StylePage.Location = new System.Drawing.Point(4, 22);
            this.StylePage.Name = "StylePage";
            this.StylePage.Padding = new System.Windows.Forms.Padding(3);
            this.StylePage.Size = new System.Drawing.Size(768, 370);
            this.StylePage.TabIndex = 0;
            this.StylePage.Text = "Style";
            this.StylePage.UseVisualStyleBackColor = true;
            // 
            // fontSelectorComboBox
            // 
            this.fontSelectorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fontSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontSelectorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.fontSelectorComboBox.FormattingEnabled = true;
            this.fontSelectorComboBox.Items.AddRange(new object[] {
            "Adobe Arabic",
            "Adobe Caslon Pro",
            "Adobe Caslon Pro Bold",
            "Adobe Devanagari",
            "Adobe Garamond Pro",
            "Adobe Garamond Pro Bold",
            "Adobe Gothic Std B",
            "Adobe Hebrew",
            "Adobe Myungjo Std M",
            "Adobe Naskh Medium",
            "Adobe Pi Std",
            "Adobe Fangsong Std R",
            "Adobe Song Std L",
            "Adobe Ming Std L",
            "Adobe Kaiti Std R",
            "Adobe Fan Heiti Std B",
            "Adobe Heiti Std R",
            "Agency FB",
            "Algerian",
            "AniMe Matrix - MB_EN",
            "Arial",
            "Arial Black",
            "Arial Narrow",
            "Arial Rounded MT Bold",
            "Bahnschrift",
            "Bahnschrift Condensed",
            "Bahnschrift Light",
            "Bahnschrift Light Condensed",
            "Bahnschrift Light SemiCondensed",
            "Bahnschrift SemiBold",
            "Bahnschrift SemiBold Condensed",
            "Bahnschrift SemiBold SemiConden",
            "Bahnschrift SemiCondensed",
            "Bahnschrift SemiLight",
            "Bahnschrift SemiLight Condensed",
            "Bahnschrift SemiLight SemiConde",
            "Baskerville Old Face",
            "Bauhaus 93",
            "Bell MT",
            "Berlin Sans FB",
            "Berlin Sans FB Demi",
            "Bernard MT Condensed",
            "Birch Std",
            "Blackadder ITC",
            "Blackoak Std",
            "Bodoni MT",
            "Bodoni MT Black",
            "Bodoni MT Condensed",
            "Bodoni MT Poster Compressed",
            "Book Antiqua",
            "Bookman Old Style",
            "Bookshelf Symbol 7",
            "Bradley Hand ITC",
            "Britannic Bold",
            "Broadway",
            "Brush Script MT",
            "Brush Script Std",
            "Caladea",
            "Calibri",
            "Calibri Light",
            "Californian FB",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Candara Light",
            "Carlito",
            "Cascadia Code",
            "Cascadia Code ExtraLight",
            "Cascadia Code Light",
            "Cascadia Code SemiBold",
            "Cascadia Code SemiLight",
            "Cascadia Mono",
            "Cascadia Mono ExtraLight",
            "Cascadia Mono Light",
            "Cascadia Mono SemiBold",
            "Cascadia Mono SemiLight",
            "Castellar",
            "Centaur",
            "Century",
            "Century Gothic",
            "Century Schoolbook",
            "Chaparral Pro",
            "Chaparral Pro Light",
            "Charlemagne Std",
            "Chiller",
            "Colonna MT",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Cooper Black",
            "Cooper Std Black",
            "Copperplate Gothic Bold",
            "Copperplate Gothic Light",
            "Corbel",
            "Corbel Light",
            "Courier New",
            "Courier Std",
            "Curlz MT",
            "DejaVu Sans",
            "DejaVu Sans Condensed",
            "DejaVu Sans Light",
            "DejaVu Sans Mono",
            "DejaVu Serif",
            "DejaVu Serif Condensed",
            "Dubai",
            "Dubai Light",
            "Dubai Medium",
            "Ebrima",
            "Edwardian Script ITC",
            "Elephant",
            "Engravers MT",
            "Eras Bold ITC",
            "Eras Demi ITC",
            "Eras Light ITC",
            "Eras Medium ITC",
            "Felix Titling",
            "Footlight MT Light",
            "Forte",
            "Franklin Gothic Book",
            "Franklin Gothic Demi",
            "Franklin Gothic Demi Cond",
            "Franklin Gothic Heavy",
            "Franklin Gothic Medium",
            "Franklin Gothic Medium Cond",
            "Freestyle Script",
            "French Script MT",
            "Gabriola",
            "Gadugi",
            "Garamond",
            "Gentium Basic",
            "Gentium Book Basic",
            "Georgia",
            "Giddyup Std",
            "Gigi",
            "Gill Sans MT",
            "Gill Sans MT Condensed",
            "Gill Sans MT Ext Condensed Bold",
            "Gill Sans Ultra Bold",
            "Gill Sans Ultra Bold Condensed",
            "Gloucester MT Extra Condensed",
            "Goudy Old Style",
            "Goudy Stout",
            "Haettenschweiler",
            "Harlow Solid Italic",
            "Harrington",
            "High Tower Text",
            "Hobo Std",
            "HoloLens MDL2 Assets",
            "Impact",
            "Imprint MT Shadow",
            "Informal Roman",
            "Ink Free",
            "Javanese Text",
            "Jokerman",
            "Juice ITC",
            "Kozuka Gothic Pr6N B",
            "Kozuka Gothic Pr6N EL",
            "Kozuka Gothic Pr6N H",
            "Kozuka Gothic Pr6N L",
            "Kozuka Gothic Pr6N M",
            "Kozuka Gothic Pr6N R",
            "Kozuka Gothic Pro B",
            "Kozuka Gothic Pro EL",
            "Kozuka Gothic Pro H",
            "Kozuka Gothic Pro L",
            "Kozuka Gothic Pro M",
            "Kozuka Gothic Pro R",
            "Kozuka Mincho Pr6N B",
            "Kozuka Mincho Pr6N EL",
            "Kozuka Mincho Pr6N H",
            "Kozuka Mincho Pr6N L",
            "Kozuka Mincho Pr6N M",
            "Kozuka Mincho Pr6N R",
            "Kozuka Mincho Pro B",
            "Kozuka Mincho Pro EL",
            "Kozuka Mincho Pro H",
            "Kozuka Mincho Pro L",
            "Kozuka Mincho Pro M",
            "Kozuka Mincho Pro R",
            "Kristen ITC",
            "Kunstler Script",
            "Leelawadee",
            "Leelawadee UI",
            "Leelawadee UI Semilight",
            "Letter Gothic Std",
            "Lithos Pro Regular",
            "Lucida Bright",
            "Lucida Calligraphy",
            "Lucida Console",
            "Lucida Fax",
            "Lucida Handwriting",
            "Lucida Sans",
            "Lucida Sans Typewriter",
            "Lucida Sans Unicode",
            "Magneto",
            "Maiandra GD",
            "Malgun Gothic",
            "Malgun Gothic Semilight",
            "Marlett",
            "Matura MT Script Capitals",
            "Mesquite Std",
            "Microsoft Himalaya",
            "Microsoft JhengHei UI",
            "Microsoft JhengHei UI Light",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft Uighur",
            "Microsoft YaHei UI",
            "Microsoft YaHei UI Light",
            "Microsoft Yi Baiti",
            "Minion Pro",
            "Minion Pro Cond",
            "Minion Pro Med",
            "Minion Pro SmBd",
            "Mistral",
            "Modern No. 20",
            "Mongolian Baiti",
            "Monotype Corsiva",
            "MS Gothic",
            "MS Outlook",
            "MS PGothic",
            "MS Reference Sans Serif",
            "MS Reference Specialty",
            "MS UI Gothic",
            "MT Extra",
            "MV Boli",
            "Myanmar Text",
            "Myriad Arabic",
            "Myriad CAD",
            "Myriad Hebrew",
            "Myriad Pro",
            "Myriad Pro Cond",
            "Myriad Pro Light",
            "Niagara Engraved",
            "Niagara Solid",
            "Nirmala UI",
            "Nirmala UI Semilight",
            "Nueva Std",
            "Nueva Std Cond",
            "OCR A Extended",
            "OCR A Std",
            "Old English Text MT",
            "OLF SimpleSansOC",
            "Onyx",
            "OpenSymbol",
            "Orator Std",
            "Palace Script MT",
            "Palatino Linotype",
            "Papyrus",
            "Parchment",
            "Perpetua",
            "Perpetua Titling MT",
            "Playbill",
            "Poor Richard",
            "Poplar Std",
            "Prestige Elite Std",
            "Pristina",
            "Rage Italic",
            "Ravie",
            "Rockwell",
            "Rockwell Condensed",
            "Rockwell Extra Bold",
            "ROG Fonts",
            "ROG Fonts v1.6",
            "Rosewood Std Regular",
            "Sans Serif Collection",
            "Script MT Bold",
            "Segoe Fluent Icons",
            "Segoe MDL2 Assets",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI",
            "Segoe UI Black",
            "Segoe UI Emoji",
            "Segoe UI Historic",
            "Segoe UI Light",
            "Segoe UI Semibold",
            "Segoe UI Semilight",
            "Segoe UI Symbol",
            "Segoe UI Variable Display",
            "Segoe UI Variable Display Light",
            "Segoe UI Variable Display Semib",
            "Segoe UI Variable Display Semil",
            "Segoe UI Variable Small",
            "Segoe UI Variable Small Light",
            "Segoe UI Variable Small Semibol",
            "Segoe UI Variable Small Semilig",
            "Segoe UI Variable Text",
            "Segoe UI Variable Text Light",
            "Segoe UI Variable Text Semibold",
            "Segoe UI Variable Text Semiligh",
            "Showcard Gothic",
            "SimSun-ExtB",
            "SimSun-ExtG",
            "Sitka Banner",
            "Sitka Banner Semibold",
            "Sitka Display",
            "Sitka Display Semibold",
            "Sitka Heading",
            "Sitka Heading Semibold",
            "Sitka Small",
            "Sitka Small Semibold",
            "Sitka Subheading",
            "Sitka Subheading Semibold",
            "Sitka Text",
            "Sitka Text Semibold",
            "Snap ITC",
            "Stencil",
            "Stencil Std",
            "SWAstro",
            "SWComp",
            "SWGDT",
            "SWGothe",
            "SWGothg",
            "SWGothi",
            "SWGrekc",
            "SWGreks",
            "SWIsop1",
            "SWIsop2",
            "SWIsop3",
            "SWIsot1",
            "SWIsot2",
            "SWIsot3",
            "SWItal",
            "SWItalc",
            "SWItalt",
            "SWLink",
            "SWMap",
            "SWMath",
            "SWMeteo",
            "SWMono",
            "SWMusic",
            "SWRomnc",
            "SWRomnd",
            "SWRomns",
            "SWRomnt",
            "SWScrpc",
            "SWScrps",
            "SWSimp",
            "SWTxt",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Tekton Pro",
            "Tekton Pro Cond",
            "Tekton Pro Ext",
            "Tempus Sans ITC",
            "Times New Roman",
            "Trajan Pro",
            "Trebuchet MS",
            "Tw Cen MT",
            "Tw Cen MT Condensed",
            "Tw Cen MT Condensed Extra Bold",
            "Verdana",
            "Viner Hand ITC",
            "Vivaldi",
            "Vladimir Script",
            "Webdings",
            "Wide Latin",
            "Wingdings",
            "Wingdings 2",
            "Wingdings 3",
            "Yu Gothic",
            "Yu Gothic Light",
            "Yu Gothic Medium",
            "Yu Gothic UI",
            "Yu Gothic UI Light",
            "Yu Gothic UI Semibold",
            "Yu Gothic UI Semilight",
            "ZWAdobeF",
            "SimSun",
            "Microsoft JhengHei",
            "Microsoft JhengHei Light",
            "Microsoft YaHei",
            "Microsoft YaHei Light",
            "NSimSun",
            "PMingLiU",
            "PMingLiU-ExtB",
            "DFKai-SB",
            "HYSWLongFangSong",
            "MingLiU",
            "MingLiU-ExtB",
            "MingLiU_HKSCS",
            "MingLiU_HKSCS-ExtB"});
            this.fontSelectorComboBox.Location = new System.Drawing.Point(101, 34);
            this.fontSelectorComboBox.Name = "fontSelectorComboBox";
            this.fontSelectorComboBox.Size = new System.Drawing.Size(165, 30);
            this.fontSelectorComboBox.TabIndex = 2;
            // 
            // label_BackColor
            // 
            this.label_BackColor.AutoSize = true;
            this.label_BackColor.Location = new System.Drawing.Point(6, 10);
            this.label_BackColor.Name = "label_BackColor";
            this.label_BackColor.Size = new System.Drawing.Size(61, 13);
            this.label_BackColor.TabIndex = 1;
            this.label_BackColor.Text = "Back color:";
            // 
            // colorSelectorComboBox
            // 
            this.colorSelectorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSelectorComboBox.FormattingEnabled = true;
            this.colorSelectorComboBox.Location = new System.Drawing.Point(101, 7);
            this.colorSelectorComboBox.Name = "colorSelectorComboBox";
            this.colorSelectorComboBox.Size = new System.Drawing.Size(165, 21);
            this.colorSelectorComboBox.TabIndex = 0;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(709, 414);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 1;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font:";
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.tabControl_Setting);
            this.Name = "SettingWindow";
            this.Text = "SettingWindow";
            this.Resize += new System.EventHandler(this.Form_Resize);
            this.tabControl_Setting.ResumeLayout(false);
            this.StylePage.ResumeLayout(false);
            this.StylePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Setting;
        private System.Windows.Forms.TabPage StylePage;
        private System.Windows.Forms.Button button_Apply;
        private TableDataProcessingTool.ExtendedComponents.ColorSelectorComboBox colorSelectorComboBox;
        private System.Windows.Forms.Label label_BackColor;
        private TableDataProcessingTool.ExtendedComponents.FontSelectorComboBox fontSelectorComboBox;
        private System.Windows.Forms.Label label1;
    }
}