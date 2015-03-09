﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HookerClient
{
    class LayoutManager
    {
        public LayoutManager() {}

        public void listViewItem(ListViewItem i)
        {
            
        }
        public void setComputerNameLabelLayout(Label l)
        {
            System.Windows.Media.BrushConverter bc = new System.Windows.Media.BrushConverter();
            //t.Background = (System.Windows.Media.Brush)bc.ConvertFromString("Yellow");
            l.Background = Brushes.Transparent;
            l.VerticalAlignment = VerticalAlignment.Stretch;
            l.BorderBrush = Brushes.White;
            l.HorizontalContentAlignment = HorizontalAlignment.Center;
            l.Foreground = Brushes.White;
            l.HorizontalAlignment = HorizontalAlignment.Stretch;
            l.VerticalContentAlignment = VerticalAlignment.Center;
            l.FontSize = 30;
        }
        public void setPasswordTextBoxLayout(TextBox t){
            System.Windows.Media.BrushConverter bc = new System.Windows.Media.BrushConverter();
            //t.Background = (System.Windows.Media.Brush)bc.ConvertFromString("Yellow");
            t.Background = Brushes.Transparent;
            t.Height = 30;
            t.Width = 150;
            t.VerticalAlignment = VerticalAlignment.Center;
            t.BorderBrush = Brushes.White;
            t.BorderThickness = new Thickness(0, 0, 0, 3);
            t.HorizontalAlignment = HorizontalAlignment.Center;
            t.HorizontalContentAlignment = HorizontalAlignment.Center;
            t.Foreground = Brushes.White;
            t.HorizontalAlignment = HorizontalAlignment.Stretch;
            t.Margin = new Thickness(5, 0, 5, 0);
            t.CaretBrush = Brushes.White;
            t.Text = "password";
            
            
        
        }

        public void setPortTextBoxLayout(TextBox t) {
            System.Windows.Media.BrushConverter bc = new System.Windows.Media.BrushConverter();
            //t.Background = (System.Windows.Media.Brush)bc.ConvertFromString("Yellow");
            t.Background = Brushes.Transparent;
            t.Height = 30;
            t.Width = 150;
            t.VerticalAlignment = VerticalAlignment.Center;
            t.HorizontalAlignment = HorizontalAlignment.Center;
            t.BorderBrush = Brushes.White;
            t.BorderThickness = new Thickness(0, 0, 0, 3);
            t.HorizontalContentAlignment = HorizontalAlignment.Center;
            t.Foreground = Brushes.White;
            t.HorizontalAlignment = HorizontalAlignment.Stretch;
            t.Margin = new Thickness(5, 0, 5, 0);
            t.CaretBrush = Brushes.White;
            t.Text = "5143";
            
            
        }

        public void setCheckBoxLayout(CheckBox cb)
        {
            cb.VerticalAlignment = VerticalAlignment.Center;
            cb.HorizontalAlignment = HorizontalAlignment.Center;
            cb.Width = 35;
            cb.Height = 35;
            cb.BorderBrush = Brushes.White;
            cb.Background = Brushes.Blue; 
            
        }


        public void setGridLayout(Grid g)
        {
            
        }

        
        

    }
}
