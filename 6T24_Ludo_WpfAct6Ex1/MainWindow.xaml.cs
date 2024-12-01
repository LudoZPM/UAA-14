﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6T24_Ludo_WpfAct6Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    {
        Button[,] btn = new Button[10,10];
        
        public MainWindow()
        {
            InitializeComponent();
            Grill();
            Damier();
            
        }
        public void Grill ()
        {
            this.Width = 660;
            this.Height = 660;
            this.FontSize = 20;
            ColumnDefinition[] colDef = new ColumnDefinition[btn.GetLength(1)];
            RowDefinition[] rowDef = new RowDefinition[btn.GetLength(0)];

            for(int i = 0; i < btn.GetLength(1); i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for(int i = 0;i < btn.GetLength(1); i++)
            {
                grdMain.ColumnDefinitions.Add(colDef[i]);
            }
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
        }
        public void Damier()
        {

        }

    }
}
