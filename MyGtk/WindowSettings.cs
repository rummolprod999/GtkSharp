using System;
using Mono.Data.Sqlite;
using Gtk;
namespace MyGtk
{
    public partial class WindowSettings : Gtk.Window
    {
        public WindowSettings() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();

            SettingsClass.GetSettings();
            TextBuffer b = textview3.Buffer;
            b.Text = SettingsClass.user;
            textview3.Buffer = b;
            b = textview4.Buffer;
            b.Text = SettingsClass.password;
            textview4.Buffer = b;
            b = textview5.Buffer;
            b.Text = SettingsClass.server;
            textview5.Buffer = b;
        }

        protected void OnButton1Clicked(object sender, EventArgs e)
        {
            var user = textview3.Buffer.Text.Trim();
            var pass = textview4.Buffer.Text.Trim();
            var serv = textview5.Buffer.Text.Trim();
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) || String.IsNullOrEmpty(serv))
            {
                MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, "Не заполнены некоторые поля");
                ResponseType response = (ResponseType)d.Run();
                if (response == ResponseType.Close)
                {
                    d.Destroy();
                }

            }
            try
            {
                SettingsClass.SetSetting(user, pass, serv);
                SettingsClass.GetSettings();
            }
            catch
            {

            }


        }
    }
}
