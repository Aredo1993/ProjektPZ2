using ProjektPZ2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektPZ2.DAL
{
    public class ProjectInitializer : CreateDatabaseIfNotExists<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {

            var profile = new List<Profile>
            {

                new Profile
                {
                    ID =1,
                    Login ="test1",
                    IsBusiness =false,
                    Name ="TestName",
                    SurnName ="TestSurName",
                    Email ="test@wp.pl",
                    TelNumber ="123432545",
                    Street="testowa",
                    ApartmentNumber="11",
                    City="Siedlce",
                    PostalCode="11-111"

                },


                 new Profile
                {
                    ID =2,
                    Login ="test2",
                    IsBusiness =true,
                    Name ="TestName2",
                    SurnName ="TestSurName2",
                    Email ="test2@wp.pl",
                    TelNumber ="1234325452222",
                    Street="testowa2",
                    ApartmentNumber="22",
                    City="Siedlce2",
                    PostalCode="22-222"

                }
    };
            profile.ForEach(p => context.Profile.Add(p));
            context.SaveChanges();


            var przetargi = new List<PrzetargModels>
           {
               new PrzetargModels {ID=1,ProfileID=1,DateOfCreate=DateTime.Parse("2012-12-12"),DateOfEnd=DateTime.Parse("2014-12-12"), },
               new PrzetargModels {ID=2,ProfileID=2,DateOfCreate=DateTime.Parse("2014-12-12"),DateOfEnd=DateTime.Parse("2016-12-12"), },
               new PrzetargModels {ID=3,ProfileID=1,DateOfCreate=DateTime.Parse("2016-12-12"),DateOfEnd=DateTime.Parse("2018-12-12"), },

           };
            przetargi.ForEach(s => context.Przetargi.Add(s));
            context.SaveChanges();






            var oferty = new List<OfertaModels>
           {
               new OfertaModels {ID=1,PrzetargModelsID=1,OfferPrice=12000,ProfileModelsID=1,DateOfCreate=DateTime.Parse("2017-05-10"), },
               new OfertaModels {ID=2,PrzetargModelsID=1,OfferPrice=15000,ProfileModelsID=2,DateOfCreate=DateTime.Parse("2017-05-11"), },
               new OfertaModels {ID=2,PrzetargModelsID=2,OfferPrice=18000,ProfileModelsID=2,DateOfCreate=DateTime.Parse("2017-05-11"), },
               new OfertaModels {ID=2,PrzetargModelsID=2,OfferPrice=19000,ProfileModelsID=2,DateOfCreate=DateTime.Parse("2017-05-11"), },
               new OfertaModels {ID=2,PrzetargModelsID=1,OfferPrice=11000,ProfileModelsID=2,DateOfCreate=DateTime.Parse("2017-05-11"), },
               new OfertaModels {ID=3,PrzetargModelsID=1,OfferPrice=17000,ProfileModelsID=1,DateOfCreate=DateTime.Parse("2017-05-12"), }







    };
            oferty.ForEach(o => context.Oferty.Add(o));
            context.SaveChanges();


            var feedback = new List<Feedback>
           {
               new Feedback {ID=1,ProfileModelsID=1,OfertaModelsID=1,Rating=5 }




    };
            feedback.ForEach(f => context.Feedbacks.Add(f));
            context.SaveChanges();











        }

        }
    }