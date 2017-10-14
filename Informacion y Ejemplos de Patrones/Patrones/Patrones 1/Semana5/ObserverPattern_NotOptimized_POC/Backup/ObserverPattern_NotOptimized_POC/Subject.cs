using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Observer.Common;

namespace ObserverPattern_NotOptimized_POC {
    public partial class Subject : Form  {

        private NotifyListForm vListForm = new NotifyListForm ();
        private NotifyBannerForm  vBannerForm = new NotifyBannerForm();
        private MessageSender vSender = new MessageSender (); 

        public Subject () {
            InitializeComponent ();
        }

        private void Subject_Load (object sender, EventArgs e) {
            vListForm.Show ();
            vBannerForm.Show ();
            /// aqui se suscribe el form a la lista de objetos que van a ser notificados
            vSender.Register (vListForm);
            vSender.Register (vBannerForm);
        }

        private void button1_Click (object sender, EventArgs e) {
            vSender.Message = textBox1.Text;
        }

    }
}