using LightInject;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanResources.WindowsForms
{
    static class Program
    {

        public static readonly ServiceContainer ServiceContainer = new ServiceContainer();


        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = CreateForm<PersonalForm>();
            Application.ThreadException += Application_ThreadException;
            Application.Run(form);
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static void RegisterServices()
        {
            ServiceContainer.RegisterAssembly(typeof(HumanResources.DI.CompositionRoot).Assembly);
            ServiceContainer.RegisterAssembly(Assembly.GetExecutingAssembly());
        }

        public static TForm CreateForm<TForm>() where TForm: Form
        {
            var scope = ServiceContainer.BeginScope();
            var form = ServiceContainer.GetInstance<TForm>();
            form.Disposed += (sender, e) => { scope.Dispose(); };
            return form;
        }
    }
}
