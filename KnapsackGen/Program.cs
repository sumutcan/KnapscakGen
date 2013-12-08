using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KnapsackGen
{
    static class Program
    {
        /// <summary>
        /// The main entry polong for the application.
        /// </summary>
        public static int kapasite;
        public static int[] tumElemanlar;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
