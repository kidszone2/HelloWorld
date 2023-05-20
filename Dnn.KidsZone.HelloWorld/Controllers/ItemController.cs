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

using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using KidsZone.DNN.Dnn.KidsZone.HelloWorld.Components;
using KidsZone.DNN.Dnn.KidsZone.HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Xml.Linq;

namespace KidsZone.DNN.Dnn.KidsZone.HelloWorld.Controllers
{
    
    [DnnHandleError]
    public class ItemController : DnnController
    {
        
        public ActionResult Delete(int itemId)
        {
            ItemManager.Instance.DeleteItem(itemId, ModuleContext.ModuleId);
            return RedirectToDefaultRoute();
        }

        public ActionResult Edit(int itemId = -1)
        {
            DotNetNuke.Framework.JavaScriptLibraries.JavaScript.RequestRegistration(CommonJs.DnnPlugins);

            var userlist = UserController.GetUsers(PortalSettings.PortalId);
            var users = from user in userlist.Cast<UserInfo>().ToList()
                        select new SelectListItem { Text = user.DisplayName, Value = user.UserID.ToString() };

            ViewBag.Users = users;

            var item = (itemId == -1)
                 ? new Item { }
                 : ItemManager.Instance.GetItem(itemId, ModuleContext.ModuleId);

            return View(item);
        }

       

        [ModuleAction(ControlKey = "Edit", TitleKey = "AddItem")]
        public ActionResult Index()
        {
            return View();
        }

        // Hirdetések listája
        public ActionResult Hirdetesek()
        {
            var results = ItemManager.Instance.GetItems(1).ToList();
            // Példa adatok
            return View(results);
        }

        // Hirdetés létrehozása
        public ActionResult HirdetesLetrehozas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HirdetesLetrehozas(Item model)
        {
            if (ModelState.IsValid)
            {
                // Process the form data or perform any other desired actions
                // For this example, we simply display a success message
                ViewBag.Message = "Form submitted successfully!";
            }
            Item uj = new Item() {  CreatedByUserId = 12, ItemDescription = model.ItemDescription, ItemName = model.ItemName, CreatedOnDate = DateTime.Now, LastModifiedByUserId = model.LastModifiedByUserId};
            uj.ModuleId = 1;

            ItemManager.Instance.CreateItem(uj);
            return View();
        }
    }
}
