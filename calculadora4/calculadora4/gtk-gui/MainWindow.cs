
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label calculadora;

	private global::Gtk.Entry Pantalla;

	private global::Gtk.VBox vbox3;

	private global::Gtk.HBox hbox17;

	private global::Gtk.Button reset;

	private global::Gtk.Button C;

	private global::Gtk.HBox hbox13;

	private global::Gtk.HBox hbox15;

	private global::Gtk.Button siete;

	private global::Gtk.Button ocho;

	private global::Gtk.HBox hbox14;

	private global::Gtk.Button nueve;

	private global::Gtk.Button div;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox7;

	private global::Gtk.HBox hbox9;

	private global::Gtk.Button cuatro;

	private global::Gtk.Button cinco;

	private global::Gtk.HBox hbox8;

	private global::Gtk.Button seis;

	private global::Gtk.Button mult;

	private global::Gtk.HBox hbox4;

	private global::Gtk.HBox hbox6;

	private global::Gtk.Button uno;

	private global::Gtk.Button dos;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Button tres;

	private global::Gtk.Button resta;

	private global::Gtk.HBox hbox1;

	private global::Gtk.HBox hbox3;

	private global::Gtk.Button coma;

	private global::Gtk.Button cero;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Button igual;

	private global::Gtk.Button suma;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.calculadora = new global::Gtk.Label();
		this.calculadora.Name = "calculadora";
		this.calculadora.LabelProp = global::Mono.Unix.Catalog.GetString("Mi calculadora");
		this.vbox4.Add(this.calculadora);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.calculadora]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.Pantalla = new global::Gtk.Entry();
		this.Pantalla.CanFocus = true;
		this.Pantalla.Name = "Pantalla";
		this.Pantalla.IsEditable = true;
		this.Pantalla.InvisibleChar = '•';
		this.vbox4.Add(this.Pantalla);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.Pantalla]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add(this.vbox4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox4]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox17 = new global::Gtk.HBox();
		this.hbox17.Name = "hbox17";
		this.hbox17.Spacing = 6;
		// Container child hbox17.Gtk.Box+BoxChild
		this.reset = new global::Gtk.Button();
		this.reset.WidthRequest = 290;
		this.reset.CanFocus = true;
		this.reset.Name = "reset";
		this.reset.UseUnderline = true;
		this.reset.Label = global::Mono.Unix.Catalog.GetString("Reset");
		this.hbox17.Add(this.reset);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.reset]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox17.Gtk.Box+BoxChild
		this.C = new global::Gtk.Button();
		this.C.WidthRequest = 92;
		this.C.CanFocus = true;
		this.C.Name = "C";
		this.C.UseUnderline = true;
		this.C.Label = global::Mono.Unix.Catalog.GetString("C");
		this.hbox17.Add(this.C);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox17[this.C]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox3.Add(this.hbox17);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox17]));
		w6.Position = 0;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.hbox15 = new global::Gtk.HBox();
		this.hbox15.Name = "hbox15";
		this.hbox15.Spacing = 6;
		// Container child hbox15.Gtk.Box+BoxChild
		this.siete = new global::Gtk.Button();
		this.siete.WidthRequest = 92;
		this.siete.CanFocus = true;
		this.siete.Name = "siete";
		this.siete.UseUnderline = true;
		this.siete.Label = global::Mono.Unix.Catalog.GetString("7");
		this.hbox15.Add(this.siete);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.siete]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox15.Gtk.Box+BoxChild
		this.ocho = new global::Gtk.Button();
		this.ocho.WidthRequest = 92;
		this.ocho.CanFocus = true;
		this.ocho.Name = "ocho";
		this.ocho.UseUnderline = true;
		this.ocho.Label = global::Mono.Unix.Catalog.GetString("8");
		this.hbox15.Add(this.ocho);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox15[this.ocho]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox13.Add(this.hbox15);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hbox15]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.hbox14 = new global::Gtk.HBox();
		this.hbox14.Name = "hbox14";
		this.hbox14.Spacing = 6;
		// Container child hbox14.Gtk.Box+BoxChild
		this.nueve = new global::Gtk.Button();
		this.nueve.WidthRequest = 92;
		this.nueve.CanFocus = true;
		this.nueve.Name = "nueve";
		this.nueve.UseUnderline = true;
		this.nueve.Label = global::Mono.Unix.Catalog.GetString("9");
		this.hbox14.Add(this.nueve);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.nueve]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox14.Gtk.Box+BoxChild
		this.div = new global::Gtk.Button();
		this.div.WidthRequest = 92;
		this.div.CanFocus = true;
		this.div.Name = "div";
		this.div.UseUnderline = true;
		this.div.Label = global::Mono.Unix.Catalog.GetString("/");
		this.hbox14.Add(this.div);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox14[this.div]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.hbox13.Add(this.hbox14);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox13[this.hbox14]));
		w12.Position = 1;
		w12.Expand = false;
		w12.Fill = false;
		this.vbox3.Add(this.hbox13);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox13]));
		w13.Position = 1;
		w13.Expand = false;
		w13.Fill = false;
		this.vbox1.Add(this.vbox3);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox3]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.cuatro = new global::Gtk.Button();
		this.cuatro.WidthRequest = 92;
		this.cuatro.CanFocus = true;
		this.cuatro.Name = "cuatro";
		this.cuatro.UseUnderline = true;
		this.cuatro.Label = global::Mono.Unix.Catalog.GetString("4");
		this.hbox9.Add(this.cuatro);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.cuatro]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.cinco = new global::Gtk.Button();
		this.cinco.WidthRequest = 92;
		this.cinco.CanFocus = true;
		this.cinco.Name = "cinco";
		this.cinco.UseUnderline = true;
		this.cinco.Label = global::Mono.Unix.Catalog.GetString("5");
		this.hbox9.Add(this.cinco);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.cinco]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.hbox7.Add(this.hbox9);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox9]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.hbox8 = new global::Gtk.HBox();
		this.hbox8.Name = "hbox8";
		this.hbox8.Spacing = 6;
		// Container child hbox8.Gtk.Box+BoxChild
		this.seis = new global::Gtk.Button();
		this.seis.WidthRequest = 92;
		this.seis.CanFocus = true;
		this.seis.Name = "seis";
		this.seis.UseUnderline = true;
		this.seis.Label = global::Mono.Unix.Catalog.GetString("6");
		this.hbox8.Add(this.seis);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.seis]));
		w18.Position = 0;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbox8.Gtk.Box+BoxChild
		this.mult = new global::Gtk.Button();
		this.mult.WidthRequest = 92;
		this.mult.CanFocus = true;
		this.mult.Name = "mult";
		this.mult.UseUnderline = true;
		this.mult.Label = global::Mono.Unix.Catalog.GetString("*");
		this.hbox8.Add(this.mult);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.mult]));
		w19.Position = 1;
		w19.Expand = false;
		w19.Fill = false;
		this.hbox7.Add(this.hbox8);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.hbox8]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox2.Add(this.hbox7);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox7]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.uno = new global::Gtk.Button();
		this.uno.WidthRequest = 92;
		this.uno.CanFocus = true;
		this.uno.Name = "uno";
		this.uno.UseUnderline = true;
		this.uno.Label = global::Mono.Unix.Catalog.GetString("1");
		this.hbox6.Add(this.uno);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.uno]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.dos = new global::Gtk.Button();
		this.dos.WidthRequest = 92;
		this.dos.CanFocus = true;
		this.dos.Name = "dos";
		this.dos.UseUnderline = true;
		this.dos.Label = global::Mono.Unix.Catalog.GetString("2");
		this.hbox6.Add(this.dos);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.dos]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.hbox4.Add(this.hbox6);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox6]));
		w24.Position = 0;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.tres = new global::Gtk.Button();
		this.tres.WidthRequest = 92;
		this.tres.CanFocus = true;
		this.tres.Name = "tres";
		this.tres.UseUnderline = true;
		this.tres.Label = global::Mono.Unix.Catalog.GetString("3");
		this.hbox5.Add(this.tres);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.tres]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.resta = new global::Gtk.Button();
		this.resta.WidthRequest = 92;
		this.resta.CanFocus = true;
		this.resta.Name = "resta";
		this.resta.UseUnderline = true;
		this.resta.Label = global::Mono.Unix.Catalog.GetString("-");
		this.hbox5.Add(this.resta);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.resta]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		this.hbox4.Add(this.hbox5);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.vbox2.Add(this.hbox4);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w28.Position = 1;
		w28.Expand = false;
		w28.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.coma = new global::Gtk.Button();
		this.coma.WidthRequest = 92;
		this.coma.CanFocus = true;
		this.coma.Name = "coma";
		this.coma.UseUnderline = true;
		this.coma.Label = global::Mono.Unix.Catalog.GetString(".");
		this.hbox3.Add(this.coma);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.coma]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.cero = new global::Gtk.Button();
		this.cero.WidthRequest = 92;
		this.cero.CanFocus = true;
		this.cero.Name = "cero";
		this.cero.UseUnderline = true;
		this.cero.Label = global::Mono.Unix.Catalog.GetString("0");
		this.hbox3.Add(this.cero);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.cero]));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		this.hbox1.Add(this.hbox3);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox3]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.igual = new global::Gtk.Button();
		this.igual.WidthRequest = 92;
		this.igual.CanFocus = true;
		this.igual.Name = "igual";
		this.igual.UseUnderline = true;
		this.igual.Label = global::Mono.Unix.Catalog.GetString("=");
		this.hbox2.Add(this.igual);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.igual]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.suma = new global::Gtk.Button();
		this.suma.WidthRequest = 92;
		this.suma.CanFocus = true;
		this.suma.Name = "suma";
		this.suma.UseUnderline = true;
		this.suma.Label = global::Mono.Unix.Catalog.GetString("+");
		this.hbox2.Add(this.suma);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.suma]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.hbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		this.vbox2.Add(this.hbox1);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
		w35.Position = 2;
		w35.Expand = false;
		w35.Fill = false;
		this.vbox1.Add(this.vbox2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
		w36.Position = 2;
		w36.Expand = false;
		w36.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 392;
		this.DefaultHeight = 232;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.reset.Clicked += new global::System.EventHandler(this.OnBVaciarClicked);
		this.C.Clicked += new global::System.EventHandler(this.OnBCClicked);
		this.siete.Clicked += new global::System.EventHandler(this.OnBSieteClicked);
		this.ocho.Clicked += new global::System.EventHandler(this.OnBOchoClicked);
		this.nueve.Clicked += new global::System.EventHandler(this.OnBNueveClicked);
		this.cuatro.Clicked += new global::System.EventHandler(this.OnBCuatroClicked);
		this.cinco.Clicked += new global::System.EventHandler(this.OnBCincoClicked);
		this.seis.Clicked += new global::System.EventHandler(this.OnBSeisClicked);
		this.uno.Clicked += new global::System.EventHandler(this.OnBUnoClicked);
		this.dos.Clicked += new global::System.EventHandler(this.OnBDosClicked);
		this.tres.Clicked += new global::System.EventHandler(this.OnBTresClicked);
		this.coma.Clicked += new global::System.EventHandler(this.OnBComaClicked);
		this.cero.Clicked += new global::System.EventHandler(this.OnBCeroClicked);
	}
}
