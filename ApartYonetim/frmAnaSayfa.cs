using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using System.Threading.Tasks;
using ApartYonetim.Fatura;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ApartYonetim
{
    public partial class frmAnaSayfa : RibbonForm
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        //public static tbl_Yoneticiler yoneticiler;
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Açık formu tekrar açmaz açık olanı aktif eder.
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmMusteriEkleme)
                {
                    ((frmMusteriEkleme)acikForm).Activate();
                    return;
                }
            }
            frmMusteriEkleme form = new frmMusteriEkleme();
            form.MdiParent = this;
            form.Show();
        }
        private void frmMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmMusteriler)
                {
                    ((frmMusteriler)acikForm).Activate();
                    return;
                }
            }
           /* tbl_GelirTuru gelirturu = new tbl_GelirTuru();
            List <tbl_GelirTuru> liste= gelirturu.Listele().ToList();*/

                frmMusteriler form = new frmMusteriler();
                form.MdiParent = this;
                form.Show();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

           yoneticiId.Caption = frmYoneticiGirisi.yoneticiler.Yonetici_adi.ToUpper();
            rpgYoneticiIslemleri.Visible = frmYoneticiGirisi.yoneticiler.Yonetici_yetki;
            rpBinalar.Visible= frmYoneticiGirisi.yoneticiler.Yonetici_yetki;


        }

        private void frmAnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // Environment.Exit(0);
        }
        private void bYoneticiler_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmYoneticiler)
                {
                    ((frmYoneticiler)acikForm).Activate();
                    return;
                }
            }
            frmYoneticiler form = new frmYoneticiler();
            form.MdiParent = this;
            form.Show();

        }

        private void tbBinalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmBinalar)
                {
                    ((frmBinalar)acikForm).Activate();
                    return;
                }
            }
            frmBinalar form = new frmBinalar();
            form.MdiParent = this;
            form.Show();
        }

        private void bbDaireler_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmDaireler)
                {
                    ((frmDaireler)acikForm).Activate();
                    return;
                }
            }
            frmDaireler form = new frmDaireler();
            form.MdiParent = this;
            form.Show();

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmFatura)
                {
                    ((frmFatura)acikForm).Activate();
                    return;
                }
            }
            frmFatura form = new frmFatura();
            form.MdiParent = this;
            form.Show();
        }

        private async void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            pttProgress.Visible = true;
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmFaturaSorgula)
                {
                    bool oturum = await Task.Run(() => ((frmFaturaSorgula)acikForm).task.oturumKontrol());
                    if (oturum)
                    {
                        pttProgress.Visible = false;
                        ((frmFaturaSorgula)acikForm).Activate();
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            frmPttLogin form = await Task.Run(()=> new frmPttLogin());
            form.Show();
            pttProgress.Visible = false;
        }

        private void bbDemirbaslar_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm is frmDemirbaslar)
                {
                    ((frmDemirbaslar)acikForm).Activate();
                    return;
                }
            }
            frmDemirbaslar form = new frmDemirbaslar();
            form.MdiParent = this;
            form.Show();
        }

        private async void inboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pttProgress.Visible = true;
            Encoding encode = Encoding.UTF8;
            string jsonData = "";
            WebClient client = new WebClient();
            client.Encoding = encode;
            jsonData = await client.DownloadStringTaskAsync(new Uri("https://fir-deneme-edc23.firebaseio.com/Sikayet.json?auth=sKP1Op3HW5oGApYlV7CIm3iKMOtPtgURnol7aZQU"));
          
            Dictionary<string,Sikayet> sikayetData = JsonConvert.DeserializeObject<Dictionary<string,Sikayet>>(jsonData);
         
            frmSikayet sk = new frmSikayet(sikayetData);
            sk.Show();
            pttProgress.Visible = false;

        }
    }
}