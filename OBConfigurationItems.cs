using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TequaCreek.OnBaseDIPFileCommitDriver
{
    class OBConfigurationItems
    {

        Hyland.Unity.Application g_app = null;

        public List<string> GetDocumentTypes()
        {
            try
            {
                List<string> docTypes = new List<string>();

                foreach (Hyland.Unity.DocumentType objDocumentType in g_app.Core.DocumentTypes)
                {
                    docTypes.Add(objDocumentType.Name);
                }

                return docTypes;
            }
            catch (SessionNotFoundException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("The Unity API session could not be found, please reconnect.", ex);
            }
            catch (UnityAPIException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was a Unity API exception.", ex);
            }
            catch (Exception ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was an unknown exception.", ex);
            }
        }

        public List<string> GetDocumentTypeGroups()
        {
            try
            {
                List<string> docTypeGroups = new List<string>();

                return docTypeGroups;
            }
            catch (SessionNotFoundException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("The Unity API session could not be found, please reconnect.", ex);
            }
            catch (UnityAPIException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was a Unity API exception.", ex);
            }
            catch (Exception ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was an unknown exception.", ex);
            }
        }

        public List<string> GetDocumentTypeByGroups(string DocumentTypeGroupName)
        {
            try
            {
                List<string> docTypes = new List<string>();


                return docTypes;
            }
            catch (SessionNotFoundException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("The Unity API session could not be found, please reconnect.", ex);
            }
            catch (UnityAPIException ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was a Unity API exception.", ex);
            }
            catch (Exception ex)
            {
                g_app.Diagnostics.Write(ex);
                throw new Exception("There was an unknown exception.", ex);
            }
        }

        public ConfigurationItems(Hyland.Unity.Application app)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app", "The Unity application object is null, make sure to connect first.");
            }
            g_app = app;
        }

        /*
            foreach (KeywordRecord objKeywordRecord in objDocument.KeywordRecords)
            {

                foreach (Keyword objKeyword in objKeywordRecord.Keywords)
                {

                    if (objKeyword.KeywordType.Name == "Loan Amount")
                    {
                        amount = objKeyword.CurrencyValue;
                        if (amount > 10000)
                        {
                            isAmountAboveThreshold = true;
                            break;
                        }

                    }
                }

            }
         * */


    }
}
