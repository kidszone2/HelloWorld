/*
' Copyright (c) 2023 Beauties and the beast
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace KidsZone.DNN.Dnn.KidsZone.HelloWorld.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.KidsZone.HelloWorld
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.KidsZone.HelloWorldInfo> colDnn.KidsZone.HelloWorlds = GetDnn.KidsZone.HelloWorlds(ModuleID);
        //if (colDnn.KidsZone.HelloWorlds.Count != 0)
        //{
        //    strXML += "<Dnn.KidsZone.HelloWorlds>";

        //    foreach (Dnn.KidsZone.HelloWorldInfo objDnn.KidsZone.HelloWorld in colDnn.KidsZone.HelloWorlds)
        //    {
        //        strXML += "<Dnn.KidsZone.HelloWorld>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.KidsZone.HelloWorld.Content) + "</content>";
        //        strXML += "</Dnn.KidsZone.HelloWorld>";
        //    }
        //    strXML += "</Dnn.KidsZone.HelloWorlds>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.KidsZone.HelloWorlds = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.KidsZone.HelloWorlds");
        //foreach (XmlNode xmlDnn.KidsZone.HelloWorld in xmlDnn.KidsZone.HelloWorlds.SelectNodes("Dnn.KidsZone.HelloWorld"))
        //{
        //    Dnn.KidsZone.HelloWorldInfo objDnn.KidsZone.HelloWorld = new Dnn.KidsZone.HelloWorldInfo();
        //    objDnn.KidsZone.HelloWorld.ModuleId = ModuleID;
        //    objDnn.KidsZone.HelloWorld.Content = xmlDnn.KidsZone.HelloWorld.SelectSingleNode("content").InnerText;
        //    objDnn.KidsZone.HelloWorld.CreatedByUser = UserID;
        //    AddDnn.KidsZone.HelloWorld(objDnn.KidsZone.HelloWorld);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.KidsZone.HelloWorldInfo> colDnn.KidsZone.HelloWorlds = GetDnn.KidsZone.HelloWorlds(ModInfo.ModuleID);

        //foreach (Dnn.KidsZone.HelloWorldInfo objDnn.KidsZone.HelloWorld in colDnn.KidsZone.HelloWorlds)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.KidsZone.HelloWorld.Content, objDnn.KidsZone.HelloWorld.CreatedByUser, objDnn.KidsZone.HelloWorld.CreatedDate, ModInfo.ModuleID, objDnn.KidsZone.HelloWorld.ItemId.ToString(), objDnn.KidsZone.HelloWorld.Content, "ItemId=" + objDnn.KidsZone.HelloWorld.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
