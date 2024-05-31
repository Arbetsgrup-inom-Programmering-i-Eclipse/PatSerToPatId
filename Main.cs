using System.Reflection;
using VMS.TPS.Common.Model.API;


// TODO: Replace the following version attributes by creating AssemblyInfo.cs. You can do this in the properties of the Visual Studio project.
[assembly: AssemblyVersion("1.0.0.1")]
[assembly: AssemblyFileVersion("1.0.0.1")]
[assembly: AssemblyInformationalVersion("1.0")]

// TODO: Uncomment the following line if the script requires write access.
[assembly: ESAPIScript(IsWriteable = false)]

namespace VMS.TPS
{
    public class Script
    {
        public void Execute(ScriptContext context)
        {
            Form.Form1 PopUp = new Form.Form1();
            PopUp.ShowDialog();
        }

    }
}
