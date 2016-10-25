using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Microsoft.AspNet.Identity;
using EstiemPortal6.ViewModels;
using EstiemPortal6.Models;
using EstiemPortal6.Repositories;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Diagnostics;

namespace EstiemPortal6.Controllers
{
    public class CouncilMeetingController : Controller
    {
        // GET: CouncilMeeting
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Elections()
        {
            var db = new EstiemPortalContext();
            HTML_HtmlModule html = db.HTML_HtmlModule.FirstOrDefault(d => d.ModuleId == 9587);
            html.Text = HttpUtility.HtmlDecode(html.Text);
            return View(html);
        }
        public ActionResult Applicants()
        {
            var db = new EstiemPortalContext();
            HTML_HtmlModule html = db.HTML_HtmlModule.FirstOrDefault(d => d.ModuleId == 9589);
            html.Text = HttpUtility.HtmlDecode(html.Text);
            return View(html);
        }

        public ActionResult FamilyList()
        {
            return View();
        }

        public ActionResult Family(int familyid)
        {
            WebClient client = new WebClient();
            Stream data = client.OpenRead("https://sheets.googleapis.com/v4/spreadsheets/1I4-Qo1Dsoa6kQD9efwDytneDkuSSv_xqDF8zQXMrqAw/values:batchGet?majorDimension=ROWS&ranges=B2%3AK167&key=AIzaSyCr3tjdj7M-qxYlYAfvBkHOM5T42jCL8bE");
            StreamReader reader = new StreamReader(data);
            string s = reader.ReadToEnd();
            JObject j = JObject.Parse(s);
            var kat = j["valueRanges"][0]["values"];
            foreach (var item in kat)
            {
                var family = item[1];
            }
            for(int i = 0; i<1000;++i)
            {
            }
            var a = j["valueRanges"][0]["values"][1].ToString();
            var jo = JArray.Parse(a);
            var w = jo[5];
            //var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //object jsonObject = serializer.DeserializeObject(reader.ReadToEnd());
            //string json = JsonConvert.SerializeObject(jsonObject);
            //data.Close(); 
            //reader.Close();
            //var people = from asd in j["valueRanges"][0]["values"]
            //             where (int)asd[5] == familyid
            //             select new
            //             {
            //                 name = asd["valueRanges"][0]["values"][1][2]
            //             };
            foreach(var child in j["valueRanges"][0]["values"].Children())
            {
                System.Diagnostics.Debug.WriteLine(child.First().First());
            }
            return View((object)w);
        }
    }
}