using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstiemPortal6.Models;

namespace EstiemPortal6.Controllers
{
    public class MarkovController : Controller
    {
        // GET: Markov
        public ActionResult Index()
        {
            Random rnd = new Random();
            var MarkovInitials = Markov.GetStartingWords();
            int first = rnd.Next(MarkovInitials.Count);
            string initial = MarkovInitials[first];
            string Text = "";
            Text = Text + initial + " ";
            var MarkovTable = Markov.GetMarkovTable();
            var ListofWords = MarkovTable[initial];
            

            int r = rnd.Next(ListofWords.Count);
            string next = ListofWords[r];
            Text = Text + next + " ";
            for (int i = 0;i<50; ++i)
            {
                var ListWords = MarkovTable[next];
                Random rand = new Random();
                int s = rand.Next(ListWords.Count);
                next = ListWords[s];
                string nextword = ListWords[s];
                Text = Text + next + " ";
            }
            
            
            

            return View((object)Text);
        }
    }
}