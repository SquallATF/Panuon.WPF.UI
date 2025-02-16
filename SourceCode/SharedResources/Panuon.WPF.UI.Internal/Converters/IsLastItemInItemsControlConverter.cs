﻿using Panuon.WPF;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Panuon.WPF.UI.Internal.Converters
{
    class IsLastItemInItemsControlConverter 
        : OneWayMultiValueConverterBase
    {
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var item = values[0] as DependencyObject;
            var itemsCount = values[1];

            var itemsControl = ItemsControl.ItemsControlFromItemContainer(item);
            if(itemsControl != null)
            {
                return itemsControl.ItemContainerGenerator.IndexFromContainer(item) == itemsControl.Items.Count - 1;
            }
            return false;
        }
    }
}
