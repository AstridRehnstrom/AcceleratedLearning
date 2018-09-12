using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samurai1
{
    class Program
    {
        static SamuraiContext context = new SamuraiContext();

        static void Main(string[] args)
        {
            //dataaccess.AddOneSamurai();
            //dataaccess.AddSomeSamurais();
            //dataaccess.AddSomeBattles();
            //dataaccess.AddOneSamuraiWithRelatedData();
            //dataaccess.ClearDatabase();
            //ListAllSamuraiNames();
            //ListAllSamuraiNames_OrderByName();
            //ListAllSamuraiNames_OrderByIdDescending();
            //FindSamuraiWithRealName("Kalle");
            //FindSamuraiWithRealName("Hemliga namnet");
            //ListAllQuotesOfType(QuoteType.Lame);
            //ListAllQuotesOfType_WithSamurai(QuoteType.Lame); 
            //ListAllBattles(new DateTime(2018, 09, 10), new DateTime(2018, 09, 14), null);
            //List<string> namesWithAlias = AllSamuraiNameWithAlias();
            //DisplayList(namesWithAlias);
            //ListAllBattles_WithLog(new DateTime(2018, 09, 10), new DateTime(2018, 09, 14), true);
            //List<SamuraiInfo> GetSamuraiInfo();
        }

        private static void ListAllBattles_WithLog(DateTime start, DateTime end,  bool brutal)
        {
            using (var context = new SamuraiContext())
            {   
                foreach (var battle in context.Battles
                    .Where(b => b.WarStart > start && b.WarEnd < end && b.Brutal == brutal)
                    .Include(b => b.BattleLog.BattleEvents)
                    .OrderBy(b => b.Name))
                {                   
                    Console.WriteLine("Name of battle: " + battle.Name);
                    Console.WriteLine("Log name: " + battle.BattleLog.Title);

                    foreach (var battleEvent in battle.BattleLog.BattleEvents.OrderBy(ev => ev.Date))
                    {
                        Console.WriteLine("Event: " + battleEvent.Summary);
                    }
                }           
            }
        }

        private static void DisplayList(List<string> list)
        {
            list.ForEach(x => Console.WriteLine(x));
        }

        private static List<string> AllSamuraiNameWithAlias()
        {
            using (var context = new SamuraiContext())
            {
                return context.Samurais.Select(s => $"{s.SecretIdentityId.RealName} alias {s.Name}").ToList();
            }
        }

        private static void ListAllBattles(DateTime from, DateTime to, bool? brutal)
        {
            using (var context = new SamuraiContext())
            {
                var battles = context.Battles.Where(b => b.WarStart > from && b.WarEnd < to);

                if (brutal != null)
                {
                    battles = battles.Where(b => b.Brutal == brutal);
                }

                foreach (var battle in battles)
                {
                    string not = battle.Brutal ? "" : " not";

                    Console.WriteLine($"'{battle.Name}' is{not} a brutal battle within the period");
                }
            }
        }

        private static void ListAllQuotesOfType_WithSamurai(QuoteType quoteType)
        {
            Console.WriteLine("Show quotes with Type " + quoteType + " and who said it");
            using (var context = new SamuraiContext())
            {
                foreach (var quote in context.Quotes.Include(q=> q.Samurai).Where(q => q.QuoteType == quoteType))
                {
                    Console.WriteLine($"'{quote.Text}' is a {quoteType} quote by {quote.Samurai.Name}");
                }
            }
            
        }

        private static void ListAllQuotesOfType(QuoteType quoteType)
        {
            Console.WriteLine("Show quotes with Type " + quoteType);
            using (var context = new SamuraiContext())
            {
                foreach (var quote in context.Quotes.Where(q => q.QuoteType == quoteType))
                {
                    Console.WriteLine (quote.Text);
                }
            }
        }

        private static void FindSamuraiWithRealName(string realName)
        {
            using (var context = new SamuraiContext())
            {
                var sam = context.Samurais.FirstOrDefault(s => s.SecretIdentityId.RealName == realName);

                if (sam == null)
                {
                    Console.WriteLine( $"No samurai has the real name {realName}");
                }
                else
                {
                    Console.WriteLine($"The samurai {sam.Name} has the real name {realName}");
                }
            } 
        }

        private static void ListAllSamuraiNames_OrderByIdDescending()
        {
            Console.WriteLine("Oder by descending(ID): ");
            foreach (var item in context.Samurais.OrderByDescending(x => x.Id))
            {
                Console.WriteLine(item.Id + "   "+ item.Name);
            }
        }

        private static void ListAllSamuraiNames_OrderByName()
        {
            Console.WriteLine("Order by name: ");
            foreach (var item in context.Samurais.OrderBy(x=> x.Name))
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void ListAllSamuraiNames()
        {
            foreach (var item in context.Samurais)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
