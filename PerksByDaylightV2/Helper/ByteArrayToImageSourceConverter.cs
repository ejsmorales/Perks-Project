﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace PerksByDaylightV2
{
    class ByteArrayToImageSourceConverter : IValueConverter
    {


        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {

            ImageSource retSource = null;
            if (value != null)
            {
                byte[] imageAsBytes = (byte[])value;
                //var stream =  new MemoryStream(imageAsBytes);
                //retSource = ImageSource.FromStream(stream);
                retSource = ImageSource.FromStream(() => new MemoryStream(imageAsBytes));

            }
            return retSource;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}