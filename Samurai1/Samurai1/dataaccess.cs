using System;
using System.Collections.Generic;

namespace Samurai1
{
    internal class dataaccess
    {
        internal static void AddOneSamurai()
        {
            var samurai = new Samurai { Name = "Zelda" };

            using (var context = new SamuraiContext())
            {
                context.Samurais.Add(samurai);
                context.SaveChanges();
            }
        }

        internal static void ClearDatabase()
        {
            using (var context = new SamuraiContext())
            {
                foreach (var samurai in context.Samurais)
                {
                   context.Remove(samurai);
                }
                foreach (var b in context.Battles)
                {
                    context.Remove(b);
                }
                foreach (var be in context.BattleEvents)
                {
                    context.Remove(be);
                }
                foreach (var bl in context.BattleLogs)
                {
                    context.Remove(bl);
                }
                foreach (var q in context.Quotes)
                {
                    context.Remove(q);
                }
                foreach (var sb in context.SamuraiBattles)
                {
                    context.Remove(sb);
                }
                foreach (var si in context.SecretIdentities)
                {
                    context.Remove(si);
                }
                context.SaveChanges();

            }
        }
        internal static void AddOneSamuraiWithRelatedData()
        {
            using (var context = new SamuraiContext())
            {
                var s = new Samurai
                {
                    Name = "Sami",
                    HairStyle = HairStyleType.Oicho,
                    SecretIdentityId = new SecretIdentity
                    {
                        RealName = "Hemliga namnet"
                    },
                   Quote=new List<Quote>
                   {
                        new Quote
                        {
                            QuoteType=QuoteType.Cheesy,
                             Text="Jag kom, jag såg, jag segrade!"
                        },
                       new Quote
                        {
                            QuoteType=QuoteType.Lame,
                             Text="Bara en mes förlorar!"
                        }
                   }       
                };

                var b = new Battle
                {
                    Name = "Slaget på Öland",
                    Description = "Ett stort slag på Ölands västra kust",
                    Brutal = true,
                    WarStart = new DateTime(2018, 09, 12),
                    WarEnd = new DateTime(2018, 09, 13),
                    BattleLog = new BattleLog
                    {
                        Title = "Första loggen",
                        BattleEvents = new List<BattleEvent>
                          {
                              new BattleEvent
                              {
                                  Summary="Vi vann nästan",
                                  Description="Det var nära vinst men än är inte kampen över",
                                  Date= DateTime.Now,
                              }
                          }
                    }
                };

                var sb = new SamuraiBattle
                {
                    Samurai = s,
                    Battle=b                  
                };

                context.AddRange(s,b, sb);                
                context.SaveChanges();
            }
        }
        internal static void AddSomeBattles()
        {
            using (var context = new SamuraiContext())
            {
                var b = new Battle
                {
                    Name = "Slaget vid Osaka",
                    Description = "Ett slag vid Osaka(såklart!)",
                    Brutal=false,
                    WarStart = DateTime.Now,
                    WarEnd = DateTime.Now.AddDays(1),
                    BattleLog = new BattleLog
                    {
                        Title = "Första dagen",
                        BattleEvents = new List<BattleEvent>
                          {
                              new BattleEvent
                              {
                                  Summary="Kalle dog",
                                  Description="Det är sorgligt",
                                  Date= DateTime.Now,
                              }
                          }
                    }
                };
                context.Battles.Add(b);
                context.SaveChanges();
            }
        }

        internal static void AddSomeSamurais()
        {
            using (var context = new SamuraiContext())
            {
                var samurai1 = new Samurai { Name = "Astrid" };
                var samurai2 = new Samurai { Name = "Rezan" };
                var samurai3 = new Samurai { Name = "Felicia" };
                context.Samurais.AddRange(samurai1, samurai2, samurai3);
                context.SaveChanges();
            }
        }
    }
}