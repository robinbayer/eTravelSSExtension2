using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace TCH_ODC_BF_CDriver
{
    [ComVisible(true)]
    [Guid("CB0CC018-A6FF-4DE1-9739-DA589D6A790D")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    [ProgId("eTravelSSExtension2.Controller")]
    public class Controller
    {


        readonly log4net.ILog m_objLogger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Controller()
        {

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location + ".log4net"));
            

        }

        public void SendApprovalEMailMessage()
        {




        }       // SendApprovalEMailMessage()


    
    }       // class
}       // namespace
