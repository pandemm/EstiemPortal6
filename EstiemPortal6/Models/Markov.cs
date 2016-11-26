using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstiemPortal6.Models
{
    public class Markov
    {
        public static List<string> GetStartingWords()
        {
            var db = new EstiemPortalContext();
            var applicationtexts = from m in db.EVENTS_Participants
                                   select m.MotivationText;
            var wor = new List<string>();
            foreach (var text in applicationtexts)
            {
                if(!String.IsNullOrWhiteSpace(text))
                { 
                var words = text.Split(null);
                wor.Add(words[0]);
                }
            }

            return wor;
        }

        public static Dictionary<string, List<string>> GetMarkovTable()
        {
            var db = new EstiemPortalContext();
            var applicationtexts = from m in db.EVENTS_Participants
                                   select m.MotivationText;
            var wor = new Dictionary<string, List<string>>();
            foreach (var text in applicationtexts)
            {
                if (!String.IsNullOrWhiteSpace(text))
                {
                    var text2 = text.Replace("\r\n", " ");
                    var words = text2.Split(null);
                    for (int i = 0; i < words.Length -1; ++i)
                    {
                        // IF the key already exists in the dictionary
                        if (wor.ContainsKey(words[i]))
                        {
                            if(i+1!=words.Length)
                            { 
                            wor[words[i]].Add(words[i + 1]);
                            }
                        }
                        // If key doesn't exist add the key
                        else
                        {
                            if (i < words.Length)
                            {
                                var lista = new List<string>();
                                lista.Add(words[i + 1]);
                                wor.Add(words[i], lista);
                            }

                        }
                        
                    }

                }

            }
            wor.Where(p => p.Value.Count() > 10).ToDictionary(p => p.Key, p => p.Value);
            return wor;
        }
    }
}