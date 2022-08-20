﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SAISKabini
{
    public partial class MailAyarlari_MailDurumlari : Form
    {
        #region Yuvarlak Köşe DLL eklentisi
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        public MailAyarlari_MailDurumlari()
        {
            InitializeComponent();

            #region Default Form Stilleri

            tablelyp_left.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_left.Width, tablelyp_left.Height, 20, 20));
            tablelyp_right.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tablelyp_right.Width, tablelyp_right.Height, 20, 20));
            btn_Duzenle.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Duzenle.Width, btn_Duzenle.Height, 10, 10));
            btn_Kaydet.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Kaydet.Width, btn_Kaydet.Height, 10, 10));
            btn_Sil.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Sil.Width, btn_Sil.Height, 10, 10));
            btn_Yeni.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Yeni.Width, btn_Yeni.Height, 10, 10));

            #endregion
        }
    }
}
