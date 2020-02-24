using System;
using System.Collections.Generic;
using Gtk;

namespace Tabla
{
    public class Panel
    {
     /*   private static uint rows = 9;
        private static uint columns = 10;*/
        private IList<Button> buttons = new List<Button>();
        public Panel(VBox vbox1)
        {
            Table table = new Table(3, 3, true);
            int index = 0;
             for (int row = 0; row < 10; row++)
                for (int column = 0; column < 9; column++)
               
                {
                    index++;
                    Button button = new Button();
                    buttons.Add(button);
                    table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                    //button.Label = "Button";
                    button.Label = index.ToString();
                    button.Clicked += delegate
                    {
                        button.ModifyBg(StateType.Normal, new Gdk.Color(255, 00, 128));
                    };
                }
            vbox1.Add(table);
            table.ShowAll();
        }
        public void Marcar(int numero)
        {
           buttons[numero-1].ModifyBg(StateType.Normal, new Gdk.Color(0,255,0));
        }
    }
}