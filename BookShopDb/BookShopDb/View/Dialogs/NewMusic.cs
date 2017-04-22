﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopDb.View.Dialogs
{
    partial class NewMusic : Form
    {
        private BookShopApp bookShopApp;
        public NewMusic(BookShopApp bookShopApp)
        {
            InitializeComponent();

            this.bookShopApp = bookShopApp;
        }

        private void cancelMusicButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}