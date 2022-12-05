using JBU_Cinemas.Models;

namespace JBU_Cinemas.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any()) 
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                   {
                        new Cinema()
                        {
                            CinemaName = "Everyman Cinemas",
                            LogoURL = "https://en.wikipedia.org/wiki/Everyman_Cinemas#/media/File:Everyman_Cinema,_Muswell_Hill,_30_September_2016_07.jpg",
                            Description = "Everyman Media Group plc (known as Everyman Cinemas) is a cinema company based in London, England."

                        },
                        new Cinema()
                        {
                            CinemaName = "Odeon Cinemas",
                            LogoURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Cinemas/Leicester_Square_Odeon.jpg",
                            Description = "Odeon, stylised as ODEON, is a cinema brand name operating in the United Kingdom, Ireland and Norway."
                        },
                        new Cinema()
                        {
                            CinemaName = "UCI Cinemas",
                            LogoURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Cinemas/Uci_kinowelt_logo.png",
                            Description = "UCI Cinemas (United Cinemas International) is a brand of cinema, currently operating in Germany, Italy, Portugal, and Brazil, which has been owned since 2004 by Odeon Cinemas Group."
                        },
                        new Cinema()
                        {
                            CinemaName = "Ritzy Cinema",
                            LogoURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Cinemas/RitzyCinemaBrixton.jpg",
                            Description = "The Ritzy is a cinema in Brixton, London, England. It is a Grade II listed building.[1] It is managed by Picturehouse Cinemas, who were bought by Cineworld in 2012."
                        },
                        new Cinema()
                        {
                            CinemaName = "The Screen on the Green",
                            LogoURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Cinemas/Screen_on_the_green.jpg",
                            Description = "The Screen on the Green is a single-screen cinema facing Islington Green in the London Borough of Islington, London. The current building was opened in 1913 and it is one of the oldest continuously running cinemas in the UK."
                        },
                        new Cinema()
                        {
                            CinemaName = "Prince Charles Cinema",
                            LogoURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Cinemas/Prince_Charles_Cinema.jpg",
                            Description = "The Prince Charles Cinema (PCC) is a repertory cinema located in Leicester Place, 50 yards north of Leicester Square in the West End of London."
                        },
                   });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>() 
                    {
                        new Actor()
                        {
                            FullName = "Tom Cruise",
                            Bio = "Thomas Cruise Mapother IV (born July 3, 1962), known professionally as Tom Cruise, is an American actor and producer.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Tom_Cruise_by_Gage_Skidmore_2.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Miles Teller",
                            Bio = "Miles Teller (born February 20, 1987) is an American actor, known for his roles as jazz drummer Andrew Neiman in Whiplash and pilot Lt. Bradley Rooster Bradshaw in Top Gun: Maverick.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Miles_Teller.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Jennifer Connelly",
                            Bio = "Jennifer Lynn Connelly (born December 12, 1970) is an American actress. She began her career as a child model before making her acting debut in the 1984 crime film Once Upon a Time in America.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Jennifer_Connelly.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Chris Pratt",
                            Bio = "Christopher Michael Pratt (born June 21, 1979) is an American actor. He rose to prominence for playing Andy Dwyer in the NBC sitcom Parks and Recreation (2009–2015).",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Chris_Pratt.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Bryce Dallas Howard",
                            Bio = "Bryce Dallas Howard (born March 2, 1981) is an American actress and director.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Bryce_Dallas_Howard.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Benedict Cumberbatch",
                            Bio = "Benedict Timothy Carlton Cumberbatch CBE (born 19 July 1976) is an English actor.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/BCumberbatch.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Elizabeth Olsen",
                            Bio = "Elizabeth Chase Olsen (born February 16, 1989) is an American actress. Born in Sherman Oaks, California, Olsen began acting at age four.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Elizabeth_Olsen.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Steve Carell",
                            Bio = "Steven John Carell (born August 16, 1962) is an American actor and comedian.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Steve_Carell.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Pierre Coffin",
                            Bio = "Pierre-Louis Padang Coffin (born 16 March 1967) is a French animator, voice actor, director, producer, and writer.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Pierre_Coffin.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Robert Pattinson",
                            Bio = "Robert Douglas Thomas Pattinson(born 13 May 1986) is an English actor.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Robert_Pattinson.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Zoë Kravitz",
                            Bio = "Zoë Isabella Kravitz (born December 1, 1988) is an American actress, singer, and model.",
                            ProfilePictureURL = "https://github.com/Jebumon/complete-ecommerce-aspnet-mvc-application/blob/master/Images-For-Db-Initialize/Actors/Zoe_Kravitz.jpg"
                        },

                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer() 
                        { 
                            ProducerName = "Jerry Bruckheimer",
                            Bio = "Jerome Leon Bruckheimer (born September 21, 1943)[2][3] is an American film and television producer.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Jerry_Bruckheimer#/media/File:JerryBruckheimerHWOFJune2013.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Tom Cruise",
                            Bio = "Thomas Cruise Mapother IV (born July 3, 1962), known professionally as Tom Cruise, is an American actor and producer. ",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Tom_Cruise#/media/File:Tom_Cruise_by_Gage_Skidmore_2.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Frank Marshall",
                            Bio = "Frank Wilton Marshall (born September 13, 1946) is an American film producer and director.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Frank_Marshall_(filmmaker)#/media/File:Frank_Marshall_Deauville_2012.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Kevin Feige",
                            Bio = "Kevin Feige (born June 2, 1973) is an American film and television producer who has been the president of Marvel Studios and the primary producer of the Marvel Cinematic Universe franchise since 2007.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Kevin_Feige#/media/File:Kevin_Feige_(48462887397)_(cropped).jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Chris Meledandri",
                            Bio = "Christopher Meledandri (born May 15, 1959) is an American film producer and founder and CEO of Illumination. ",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Chris_Meledandri#/media/File:Chris_Meledandri_at_the_2018_Fast_Company_Innovation_Festival_1.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Janet Healy",
                            Bio = "Janet Healy is a film producer whose films include Illumination's Despicable Me animated series and other animated films by the studio.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Janet_Healy#/media/File:Janet_Healy_2015.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Chris Renaud",
                            Bio = "Chris Renaud (born December 1966) is an American film producer, director, illustrator, designer, animator, and voice actor.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Chris_Renaud#/media/File:Chris_Renaud.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Dylan Clark",
                            Bio = "Dylan Clark is known for Rise of the Planet of the Apes (2011), Dawn of the Planet of the Apes (2014) and Oblivion (2013).",
                            ProfilePictureURL = "https://planetoftheapes.fandom.com/wiki/Dylan_Clark?file=Dylan_Clark.jpg"
                        },
                        new Producer()
                        {
                            ProducerName = "Matt Reeves",
                            Bio = "Matt Reeves (born April 27, 1966) is an American film director, producer and screenwriter.",
                            ProfilePictureURL = "https://en.wikipedia.org/wiki/Matt_Reeves#/media/File:Matt_Reeves_(13948765595)_(cropped).jpg"
                        },

                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>() 
                    {
                        new Movie()
                        {
                            Title = "Top Gun: Maverick",
                            Description = "Top Gun: Maverick is a 2022 American action drama film[5] directed by Joseph Kosinski. It is the sequel to Top Gun (1986) and the second installment in the Top Gun film series.",
                            Price = 35.5,
                            ImageURL = "https://en.wikipedia.org/wiki/Top_Gun:_Maverick#/media/File:Top_Gun_Maverick_Poster.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Title = "Jurassic World Dominion",
                            Description = "Jurassic World Dominion is a 2022 American science fiction action film directed by Colin Trevorrow, who co-wrote the screenplay with Emily Carmichael from a story by Derek Connolly and Trevorrow. ",
                            Price = 35.5,
                            ImageURL = "https://en.wikipedia.org/wiki/Jurassic_World_Dominion#/media/File:JurassicWorldDominion_Poster.jpeg",
                            StartDate = DateTime.Now.AddDays(1),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Thriller
                        },
                        new Movie()
                        {
                            Title = "Doctor Strange in the Multiverse of Madness",
                            Description = "Doctor Strange in the Multiverse of Madness is a 2022 American superhero film based on Marvel Comics featuring the character Doctor Strange.",
                            Price = 35.5,
                            ImageURL = "https://en.wikipedia.org/wiki/Doctor_Strange_in_the_Multiverse_of_Madness#/media/File:Doctor_Strange_in_the_Multiverse_of_Madness_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Fiction
                        },
                        new Movie()
                        {
                            Title = "Minions: The Rise of Gru",
                            Description = "Minions: The Rise of Gru (also known as Minions 2) is a 2022 American computer-animated comedy film produced by Illumination and distributed by Universal Pictures.",
                            Price = 35.5,
                            ImageURL = "https://en.wikipedia.org/wiki/Minions:_The_Rise_of_Gru#/media/File:Minions_The_Rise_of_Gru_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(12),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Animation
                        },
                        new Movie()
                        {
                            Title = "The Batman",
                            Description = "The Batman is a 2022 American superhero film based on the DC Comics character Batman. Produced by DC Films, 6th & Idaho, and Dylan Clark Productions, and distributed by Warner Bros.",
                            Price = 35.5,
                            ImageURL = "https://en.wikipedia.org/wiki/The_Batman_(film)#/media/File:The_Batman_(film)_poster.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(8),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = Enums.MovieCategory.Fiction
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>() 
                    {
                        new Actor_Movie() 
                        {
                             ActorId = 1,
                             MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 2,
                             MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 3,
                             MovieId = 1,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 4,
                             MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 5,
                             MovieId = 2,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 6,
                             MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 7,
                             MovieId = 3,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 8,
                             MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 9,
                             MovieId = 4,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 10,
                             MovieId = 5,
                        },
                        new Actor_Movie()
                        {
                             ActorId = 11,
                             MovieId = 5,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
