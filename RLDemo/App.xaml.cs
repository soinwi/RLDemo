using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RLDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static BusinessObjects.RLController _controller;

        public App()
        {

        }

        public static BusinessObjects.RLController Controller
        {
            get
            {
                if (_controller == null)
                {
                    _controller = new BusinessObjects.RLController(
                        new DataLayer.RLDBDataContext()
                      );
                }
                return _controller;
            }
        }

    }
}
