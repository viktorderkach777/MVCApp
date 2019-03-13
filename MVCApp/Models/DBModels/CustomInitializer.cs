using System.Data.Entity;

namespace MVCApp
{
    internal class CustomInitializer<T> : DropCreateDatabaseIfModelChanges<CustomContext>
    {        

        protected override void Seed(CustomContext context)
        {
            context.DALPlaces.Add(
                new DALPlace
                {
                    Name = "Рівненський обласний академічний український музично-драматичний театр",
                    LinkRef = "\"http://dramteatr.com.ua/\"",
                    LinkText = "Рівненський обласний академічний український музично-драматичний театр",
                    AboutPlace = "  — головна театральна сцена Рівненщини.",
                    OpenTime = 12,
                    CloseTime = 18,
                    Rate = 5,
                    Icon = "theatre",
                    Longitude = 26.246115,
                    Latitude = 50.620914
                });

            context.DALPlaces.Add(
               new DALPlace
               {
                   Name = "Рівненський обласний академічний ляльковий театр",
                   LinkRef = "\"http://www.teatr.rv.ua/\"",
                   LinkText = "Дитячий ляльковий театр",
                   AboutPlace = "  — обласний академічний ляльковий театр у місті Рівному.",
                   OpenTime = 8,
                   CloseTime = 11,
                   Rate = 5,
                   Icon = "theatre",
                   Longitude = 26.2484742,
                   Latitude = 50.623080
               });

            context.DALPlaces.Add(
               new DALPlace
               {
                   Name = "Молодіжний експериментальний театр Рівного \"МЕТР\"",
                   LinkRef = "\"https://metr-ua.livejournal.com/\"",
                   LinkText = "Молодіжний експериментальний театр Рівного \"МЕТР\"",
                   AboutPlace = " — займається організацією мистецьких акцій, виставок, перфомансів, фестивалів. ",
                   OpenTime = 9,
                   CloseTime = 14,
                   Rate = 3,
                   Icon = "theatre",
                   Longitude = 26.259594,
                   Latitude = 50.618328
               });

            context.DALPlaces.Add(
              new DALPlace
              {
                  Name = "Театр оригінального жанру \"Галатея\"",
                  LinkRef = "\"http://mpkrivne.com.ua/groups/7-galateja\"",
                  LinkText = "Театр оригінального жанру \"Галатея\"",
                  AboutPlace = " — народний аматорський театр живих скульптур. ",
                  OpenTime = 10,
                  CloseTime = 17,
                  Rate = 2,
                  Icon = "theatre",
                  Longitude = 26.266270,
                  Latitude = 50.626928
              });

            context.DALPlaces.Add(
             new DALPlace
             {
                 Name = "Театр музичної казки \"Диво\"",
                 LinkRef = "\"http://teatrdivo.org/\"",
                 LinkText = "Театр музичної казки \"Диво\"",
                 AboutPlace = " — приватний театр на колесах, у якому дорослі грають для дітей. ",
                 OpenTime = 12,
                 CloseTime = 18,
                 Rate = 4,
                 Icon = "theatre",
                 Longitude = 26.279442,
                 Latitude = 50.611429
             });

            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Театр-студія \"Від ліхтаря\"",
                LinkRef = "\"http://www.pdm.org.ua/special-centers/teatr-studia/teatr-pelagogy\"",
                LinkText = "Театр-студія \"Від ліхтаря\"",
                AboutPlace = " — один із найкращих молодіжних театрів міста. ",
                OpenTime = 10,
                CloseTime = 17,
                Rate = 4,
                Icon = "theatre",
                Longitude = 26.264304,
                Latitude = 50.621184
            });

            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Театр \"Сонях\"",
                LinkRef = "\"https://www.facebook.com/teatrs.com.ua\"",
                LinkText = "Театр \"Сонях\"",
                AboutPlace = " — один із самодіяльних народних театрів міста. ",
                OpenTime = 11,
                CloseTime = 16,
                Rate = 3,
                Icon = "theatre",
                Longitude = 26.268902,
                Latitude = 50.632702
            });

            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Літературний музей Уласа Самчука",
                LinkRef = "\"http://museum.rv.gov.ua/vistavka-literaturnij-muzej-ulasa-samchuka/\"",
                LinkText = "Літературний музей Уласа Самчука",
                AboutPlace = " — музей в залі будинку вчених. ",
                OpenTime = 09,
                CloseTime = 17,
                Rate = 4,
                Icon = "museum",
                Longitude = 26.248911,
                Latitude = 50.623039
            });

            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Рівненський обласний краєзнавчий музей",
                LinkRef = "\"http://museum.rv.gov.ua/\"",
                LinkText = "Рівненський обласний краєзнавчий музей",
                AboutPlace = " —  головне зібрання матеріалів і предметів матеріальної та духовної культури Рівненщини. ",
                OpenTime = 8,
                CloseTime = 18,
                Rate = 5,
                Icon = "museum",
                Longitude = 26.247997,
                Latitude = 50.615418
            });


            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Музей бурштину",
                LinkRef = "\"http://museum.rv.gov.ua/struktura-muzeyu/vistavka-muzej-burshtinu/\"",
                LinkText = "Музей бурштину",
                AboutPlace = " —  єдиний в Україні музей бурштину. ",
                OpenTime = 10,
                CloseTime = 17,
                Rate = 5,
                Icon = "museum",
                Longitude = 26.309148,
                Latitude = 50.612702
            });


            context.DALPlaces.Add(
        new DALPlace
        {
            Name = "Музей бойової слави 13-го Армійського корпусу",
            LinkRef = "\"https://geo.viaregia.org/testbed/index.pl?rm=obj&objid=12794\"",
            LinkText = "Музей бойової слави 13-го Армійського корпусу",
            AboutPlace = " — музей присвячено історії 13 армійськоого корпусу. Тут можна дізнатися про подробиці Великої Вітчизняної війни, про визволення Рівного, про партизанський рух у цьому регіоні. ",
            OpenTime = 10,
            CloseTime = 17,
            Rate = 1,
            Icon = "museum",
            Longitude = 26.228435,
            Latitude = 50.624170
        });

            context.DALPlaces.Add(
            new DALPlace
            {
                Name = "Готель \"Турист\"",
                LinkRef = "\"http://rivnetourist.com.ua/\"",
                LinkText = "Готель \"Турист\"",
                AboutPlace = " - побудовано за індивідуальним проектом і введено в експлуатацію у 1989 році. Усі номери готелю \"Турист\" вирізняються по-домашньому затишним інтер’єром. ",
                OpenTime = 10,
                CloseTime = 21,
                Rate = 3,
                Icon = "lodging",
                Longitude = 26.281428,
                Latitude = 50.615225
            });

            context.DALPlaces.Add(
             new DALPlace
             {
                 Name = "Готель \"Мир\"",
                 LinkRef = "\"http://mir-hotel.com/\"",
                 LinkText = "Готель \"Мир\"",
                 AboutPlace = " - сучасний готель з європейським обличчям, що розташований у центрі Рівного. ",
                 OpenTime = 7,
                 CloseTime = 22,
                 Rate = 4,
                 Icon = "lodging",
                 Longitude = 26.253623,
                 Latitude = 50.622340
             });

            context.SaveChanges();
        }
    }
}