#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using FTOptix.WebUI;
using FTOptix.CODESYS;
using FTOptix.CommunicationDriver;
using FTOptix.Alarm;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.DataLogger;
using FTOptix.ODBCStore;
using FTOptix.Recipe;
#endregion

public class DesignTimeNetLogic1 : BaseNetLogic
{
    [ExportMethod]
    public void Method1()
    {
        // Insert code to be executed by the method
        for (int i = 0; i < 10; i++)
        {
            var allarme = InformationModel.Make<DigitalAlarm>("Allarme" + i);
            Project.Current.Get("Alarms").Add(allarme);
        }
    }

    [ExportMethod]
    public void AssociaLink()
    {
        var varModello = Project.Current.GetVariable("Model/Variable4");
        var varPLC = Project.Current.GetVariable("CommDrivers/CODESYSDriver1/CODESYSStation1/Tags/Application/PLC_PRG/incrementa");
        varModello.SetDynamicLink(varPLC, DynamicLinkMode.ReadWrite);
    }
}