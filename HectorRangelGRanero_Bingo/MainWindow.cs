using System;
using Tabla;
using Gtk;

public partial class MainWindow : Gtk.Window
{
   Bombo bombo = new Bombo();
    Panel panel;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        panel = new Panel(vbox1);
  
        //Button1.clicked+=delegate
    } 
     
     protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        int numero =  bombo.sacarbola();
        if (numero > 0)
        {
            panel.Marcar(numero);
        }
        else
        {
            Application.Quit();
        }

    }
}
