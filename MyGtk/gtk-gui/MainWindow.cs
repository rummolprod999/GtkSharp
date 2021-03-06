
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action SettingsAction;

	private global::Gtk.Action floppyAction;

	private global::Gtk.Action SettingsAction1;

	private global::Gtk.Action SettingsAction2;

	private global::Gtk.Action networkAction;

	private global::Gtk.Table table2;

	private global::Gtk.Button button2;

	private global::Gtk.Button button3;

	private global::Gtk.VBox vbox1;

	private global::Gtk.ProgressBar progressbar2;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entry1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.TreeView treeview1;

	private global::Gtk.VBox vbox3;

	private global::Gtk.MenuBar menubar2;

	private global::Gtk.Button button4;

	private global::Gtk.Button button5;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.SettingsAction = new global::Gtk.Action("SettingsAction", global::Mono.Unix.Catalog.GetString("Settings"), null, null);
		this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Settings");
		w1.Add(this.SettingsAction, null);
		this.floppyAction = new global::Gtk.Action("floppyAction", global::Mono.Unix.Catalog.GetString("_Floppy"), null, "gtk-floppy");
		this.floppyAction.ShortLabel = global::Mono.Unix.Catalog.GetString("_Floppy");
		w1.Add(this.floppyAction, null);
		this.SettingsAction1 = new global::Gtk.Action("SettingsAction1", global::Mono.Unix.Catalog.GetString("Settings"), null, null);
		this.SettingsAction1.ShortLabel = global::Mono.Unix.Catalog.GetString("Settings");
		w1.Add(this.SettingsAction1, null);
		this.SettingsAction2 = new global::Gtk.Action("SettingsAction2", global::Mono.Unix.Catalog.GetString("Settings"), null, null);
		this.SettingsAction2.ShortLabel = global::Mono.Unix.Catalog.GetString("Server settings");
		w1.Add(this.SettingsAction2, null);
		this.networkAction = new global::Gtk.Action("networkAction", global::Mono.Unix.Catalog.GetString("Server srttings"), null, "gtk-network");
		this.networkAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Server");
		w1.Add(this.networkAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
		this.table2.Name = "table2";
		this.table2.RowSpacing = ((uint)(6));
		this.table2.ColumnSpacing = ((uint)(6));
		// Container child table2.Gtk.Table+TableChild
		this.button2 = new global::Gtk.Button();
		this.button2.CanFocus = true;
		this.button2.Events = ((global::Gdk.EventMask)(256));
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString("Load files backups");
		this.table2.Add(this.button2);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2[this.button2]));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		w2.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.button3 = new global::Gtk.Button();
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString("Download");
		this.table2.Add(this.button3);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2[this.button3]));
		w3.TopAttach = ((uint)(2));
		w3.BottomAttach = ((uint)(3));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		w3.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.progressbar2 = new global::Gtk.ProgressBar();
		this.progressbar2.Name = "progressbar2";
		this.vbox1.Add(this.progressbar2);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.progressbar2]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Status download");
		this.vbox1.Add(this.label4);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.vbox1.Add(this.entry1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entry1]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.table2.Add(this.vbox1);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.vbox1]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table2.Gtk.Table+TableChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.treeview1 = new global::Gtk.TreeView();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.vbox2.Add(this.treeview1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.treeview1]));
		w8.Position = 0;
		this.table2.Add(this.vbox2);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.vbox2]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.LeftAttach = ((uint)(1));
		w9.RightAttach = ((uint)(2));
		// Container child table2.Gtk.Table+TableChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name=\'menubar2\'><menu name=\'SettingsAction2\' action=\'SettingsAction2" +
				"\'><menuitem name=\'networkAction\' action=\'networkAction\'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox3.Add(this.menubar2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.menubar2]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button();
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString("Load files");
		this.vbox3.Add(this.button4);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button4]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString("Load DB");
		this.vbox3.Add(this.button5);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button5]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.table2.Add(this.vbox3);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2[this.vbox3]));
		w13.TopAttach = ((uint)(1));
		w13.BottomAttach = ((uint)(2));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		this.Add(this.table2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 819;
		this.DefaultHeight = 572;
		this.button2.Hide();
		this.button3.Hide();
		this.treeview1.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.networkAction.Activated += new global::System.EventHandler(this.OnNetworkActionActivated);
		this.button4.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
		this.button5.Clicked += new global::System.EventHandler(this.OnButton5Clicked);
		this.treeview1.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTreeview1RowActivated);
		this.button3.Clicked += new global::System.EventHandler(this.OnButton3Clicked);
		this.button2.Clicked += new global::System.EventHandler(this.OnButton2Clicked);
	}
}
