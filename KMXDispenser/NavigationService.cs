﻿using KMXDispenser.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Controls;

namespace KMXDispenser
{
    public class NavigationService :INavigationService
    {
        readonly Frame frame;

        public NavigationService(Frame frame)
        {
            this.frame = frame;
        }

        public void GoBack()
        {
            frame.GoBack();
        }

        public void GoForward()
        {
            frame.GoForward();
        }

        public bool Navigate<T>(object parameter = null)
        {
            var type = typeof(T);
            return Navigate(type, parameter);
        }

        public bool Navigate(Type source, object parameter = null)
        {
            var src = Activator.CreateInstance(source);
            return frame.Navigate(src, parameter);
        }

        public bool Navigate(string page)
        {
            var type = Assembly.GetExecutingAssembly().GetTypes().SingleOrDefault(a => a.Name.Equals(page));
            if (type == null) return false;

            var src = Activator.CreateInstance(type);
            return frame.Navigate(src);
        }
    }
}
