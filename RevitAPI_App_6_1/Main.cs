using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создайте приложение в WPF, которое создаёт воздуховод по двум введённым точкам. Тип воздуховода,
//уровень расположения должен выбираться из выпадающего списка. Смещение
//воздуховода задаётся с помощью ввода значения в окне.

namespace RevitAPI_App_6_1

{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Внимание!","Необходимо указать не менее 2 точек для построения. После окончания ввода точек нажать Esc");
            
            var mainView = new MainView(commandData);
            mainView.ShowDialog();
            return Result.Succeeded;
        }
    }
}
