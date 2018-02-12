using System;
using System.Collections.Generic;
using Gtk;
using MyGtk;
using System.Linq;
using System.Threading.Tasks;

public partial class MainWindow : Gtk.Window
{
    List<String> listSftp = new List<string>();
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        this.DeleteEvent += OnDeleteEvent;
        //TreeViewColumn bColumn = new TreeViewColumn
        //{
        //    Title = "Backup"
        //};
        //CellRendererText backupNameCell = new CellRendererText();
        //bColumn.PackStart(backupNameCell, true);
        //treeview1.AppendColumn(bColumn);
        //bColumn.AddAttribute(backupNameCell, "text", 0);
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        SFtpLibrary f = new SFtpLibrary();
        var arr = f.ClientSFtpBel();

        ListStore backupListStore = new ListStore(typeof(string));
        foreach (var fl in arr)
        {
            backupListStore.AppendValues(fl);

        }
        treeview1.Model = backupListStore;

    }

    protected void OnButton2Clicked(object sender, EventArgs e)
    {
        foreach (var ff in vbox2.Children)
        {
            ff.Destroy();
        }
        SFtpLibrary f = new SFtpLibrary();
        var arr = f.ClientSFtpBel();

        foreach (var fl in arr)
        {

            Button b = new Button($"Download {fl}");
            b.Clicked += OnButtonFClicked;
            vbox2.PackStart(b);
            b.Show();
        }
        listSftp.Clear();
        listSftp.AddRange(arr);




    }

    protected async void OnButtonFClicked(object sender, EventArgs e)
    {
        //MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "info");
        //var b = (sender as Button);

        //d.Text = b.Name;
        //ResponseType response = (ResponseType)d.Run();
        //if (response == ResponseType.Close)
        //{
        //    d.Destroy();
        //}
        var b = (sender as Button);
        var s = listSftp.Where(t => b.Label.Contains(t)).FirstOrDefault();
        progressbar2.Fraction = 0.0;
        entry1.Text = String.Empty;
        await Task.Run(() =>
        {
            SFtpLibrary f = new SFtpLibrary();
            f.GetFileFromBel(s, OSftp_OnTransferProgress, OSftp_OnTransferStart, OSftp_OnTransferEnd);
        });


    }

    protected async void OnButtonDBClicked(object sender, EventArgs e)
    {
        //MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "info");
        //var b = (sender as Button);

        //d.Text = b.Name;
        //ResponseType response = (ResponseType)d.Run();
        //if (response == ResponseType.Close)
        //{
        //    d.Destroy();
        //}
        var b = (sender as Button);
        var s = listSftp.Where(t => b.Label.Contains(t)).FirstOrDefault();
        progressbar2.Fraction = 0.0;
        entry1.Text = String.Empty;
        await Task.Run(() =>
        {
            SFtpLibrary f = new SFtpLibrary();
            f.GetFileBdFromBel(s, OSftp_OnTransferProgress, OSftp_OnTransferStart, OSftp_OnTransferEnd);
        });


    }

    protected void OnButton3Clicked(object sender, EventArgs e)
    {

        MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "info");
        var t = treeview1.Selection;
        var y = t.GetSelectedRows()[0];
        treeview1.Model.GetIter(out TreeIter tree, y);
        var c = treeview1.Model.GetValue(tree, 0);
        d.Text = c.ToString();
        ResponseType response = (ResponseType)d.Run();

        {
            if (response == ResponseType.Close)
            {
                d.Destroy();
            }
        }
    }

    protected void OnTreeview1RowActivated(object o, RowActivatedArgs args)
    {
        var s = o as TreeView;
        MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Close, "info");
        var t = s.Selection;
        var y = t.GetSelectedRows()[0];
        d.Text = (t.GetSelectedRows()[0]).ToString();
        ResponseType response = (ResponseType)d.Run();

        {
            if (response == ResponseType.Close)
            {
                d.Destroy();
            }
        }
    }

    void OSftp_OnTransferProgress(string src, string dst, int transferredBytes, int totalBytes, string message)
    {
        if (totalBytes < 0)
        {
            totalBytes = totalBytes * -1;
        }

        Task.Run(() =>
        {
            double d = (double)transferredBytes / totalBytes;
            if (d < 0.0)
            {
                d = 0.0;
            }
            progressbar2.Fraction = d;



        });

    }



    void OSftp_OnTransferStart(string src, string dst, int transferredBytes, int totalBytes, string message) => Button1ClickAsync(message);
    public async Task Button1ClickAsync(string message)
    {
        try
        {
            await SubMethod(message);
        }
        catch
        {

        }
    }
    async Task SubMethod(string message)
    {

        long unixTime = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        if (unixTime % 1 == 0)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (message != null)
                    {
                        entry1.Text = message;
                    }
                }
                catch
                {

                }



            });

        }

    }


    void OSftp_OnTransferEnd(string src, string dst, int transferredBytes, int totalBytes, string message)
    {

        try
        {
            if (message != null)
            {
                entry1.Text = message;
            }
        }
        catch
        {

        }

    }
    public class MyWidget : Widget
    {
        public string text;
        public MyWidget(string t)
        {
            text = t;
        }
    }

    protected void OnButton5Clicked(object sender, EventArgs e)
    {
        foreach (var ff in vbox2.Children)
        {
            ff.Destroy();
        }
        SFtpLibrary f = new SFtpLibrary();
        var arr = f.ClientSFtpBelBd();

        foreach (var fl in arr)
        {

            Button b = new Button($"Download {fl}");
            b.Clicked += OnButtonDBClicked;
            vbox2.PackStart(b);
            b.Show();
        }
        listSftp.Clear();
        listSftp.AddRange(arr);


    }

    protected void OnNetworkActionActivated(object sender, EventArgs e)
    {
        WindowSettings w = new WindowSettings();
        w.Show();
    }
}
