using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public class ApplicationDbInitializer
    {
        private static bool hasRunDuringApplicationExecution;
        public static ApplicationDbContext ctx = null;

        public static void Initialize(ApplicationDbContext context, UserManager<ApplicationUser> user, 
            RoleManager<ApplicationRole> role, bool forceDropCreateDatabase = false)
        {
            if (!hasRunDuringApplicationExecution)
            {
                if (forceDropCreateDatabase)
                    context.Database.EnsureDeleted();

                if (context.Database.EnsureCreated())
                {
                    ctx = context;
                    Seed(user, role);
                }

                hasRunDuringApplicationExecution = true;
            }
        }

        public static async void Seed(
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            string role1 = "SuperAdmin";
            string role2 = "Admin";
            string role3 = "Moderator";
            string role4 = "SignedInUser";
            string role5 = "SignedInUserVerified";
            string role6 = "SignedInUserOrganisation";
        
            string password = "Test-1234";

            if (await roleManager.FindByNameAsync(role1) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role1));
            }
            if (await roleManager.FindByNameAsync(role2) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role2));
            }
            if (await roleManager.FindByNameAsync(role3) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role3));
            }
            if (await roleManager.FindByNameAsync(role4) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role4));
            }
            if (await roleManager.FindByNameAsync(role5) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role5));
            }
            if (await roleManager.FindByNameAsync(role6) == null) {
                await roleManager.CreateAsync(new ApplicationRole(role6));
            }

            #region users
            if (await userManager.FindByNameAsync("super.admin@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "super.admin@gmail.com",
                    Email = "super.admin@gmail.com",
                    FirstName = "Super",
                    LastName = "Admin",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
            }
            
            if (await userManager.FindByNameAsync("admin@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    FirstName = "Administrator",
                    LastName = "Admin",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
            }
            
            if (await userManager.FindByNameAsync("mod@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "mod@gmail.com",
                    Email = "mod@gmail.com",
                    FirstName = "Moderator",
                    LastName = "Mod",
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role3);
                }
            }

            if (await userManager.FindByNameAsync("jan.jaap@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "jan.jaap@gmail.com",
                    Email = "jan.jaap@gmail.com",
                    FirstName = "Jan",
                    LastName = "Jaap",
                    Age = "25",
                    Gender = "M",
                    PostalCode = "2340",
                    EmailConfirmed = true,
                    Organisation = new Organisation
                    {
                        OrganisationName = "Jan zijn organisation",
                        OrganisationEventInput = "Jan zijn input event."
                    }
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role6);
                }
            }
            
            if (await userManager.FindByNameAsync("peter.smet@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "peter.smet@gmail.com",
                    Email = "peter.smet@gmail.com",
                    FirstName = "Peter",
                    LastName = "Smet",
                    Age = "52",
                    Gender = "M",
                    PostalCode = "2480",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            
            if (await userManager.FindByNameAsync("dirk.bakker@gmail.com") == null)
            {
                var user = new ApplicationUser {
                    UserName = "dirk.bakker@gmail.com",
                    Email = "dirk.bakker@gmail.com",
                    FirstName = "dirk",
                    LastName = "bakker",
                    Age = "62",
                    Gender = "M",
                    PostalCode = "2000",
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
                }
            }
            #endregion
            
           
            
            #region TestProject 1
            Project p1 = new Project()
            {
                Description = "We are thinking about building a new playground in the middle of central park",
                EndDate = new DateTime(2019, 3,9),
                StartDate = new DateTime(2019,4,10),
                Name = "Playground"
            };
            p1.Setting = new Setting {BackGroundColor1 = "red", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            MapField mapproj1 = new MapField{Latitude = 51.21248,Longitude = 4.409641};
            ImageField imgproj1 = new ImageField();            
            imgproj1.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\playground-project.jpg");
            p1.MapField = mapproj1;
            p1.ImageField = imgproj1;
            
            // Questionnaires
            Questionnaire questionnaire1 = new Questionnaire()
            {
                Name = "Safety",
                QuestionAmount = 4,
                Project = p1,
                Questions = new List<Question>()
            };
            Questionnaire questionnaire2 = new Questionnaire()
            {
                Name = "Noise",
                QuestionAmount = 3,
                Project = p1,
                Questions = new List<Question>()
            };
            p1.Questionnaires = new List<Questionnaire>() { questionnaire1, questionnaire2 };
            
            // Questions
            Question q1 = new Question()
            {
                TheQuestion = "Do we need to build a fence around the playground?",
                Questionnaire = questionnaire1,
                QuestionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option o1 = new Option() {TheOption = "Yes", Question = q1};
            Option o2 = new Option() {TheOption = "No", Question = q1};
            q1.Options = new List<Option>() { o1, o2 };
            Question question1 = new Question()
            {
                TheQuestion = "How big should the playground be?",
                Questionnaire = questionnaire1,
                QuestionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option option1 = new Option() {TheOption = "50m²", Question = question1};
            Option option2 = new Option() {TheOption = "60m²", Question = question1};
            Option option3 = new Option() {TheOption = "80m²", Question = question1};
            Option option4 = new Option() {TheOption = "100m²", Question = question1};
            question1.Options = new List<Option>() { option1, option2, option3, option4 };
            Question q2 = new Question()
            {
                TheQuestion = "Where should we build the playground",
                Questionnaire = questionnaire1,
                QuestionType = QuestionType.DROPDOWN,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option o3 = new Option() {TheOption = "Brooklyn Street", Question = q2};
            Option o4 = new Option() {TheOption = "Second street", Question = q2};
            Option o5 = new Option() {TheOption = "New road", Question = q2};
            q2.Options = new List<Option>() { o3, o4, o5 };
            Question q3 = new Question()
            {
                TheQuestion = "Fill in your e-mail address:",
                Questionnaire = questionnaire1,
                QuestionType = QuestionType.MAILADDRESS,
                IotSetup = null,
                Options = new List<Option>()
            };
            Question q4 = new Question()
            {
                TheQuestion = "What should we do about the noise polution of the playground?",
                Questionnaire = questionnaire2,
                QuestionType = QuestionType.OPEN_QUESTION,
                IotSetup = new IotSetup(),
                Options = new List<Option>()
            };
            Question q5 = new Question()
            {
                TheQuestion = "Do you think a playground would be anoying if it was near your home?",
                Questionnaire = questionnaire2,
                QuestionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                Options = new List<Option>()
            };
            Question question2 = new Question()
            {
                TheQuestion = "What should we add to the playground?",
                Questionnaire = questionnaire2,
                QuestionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option option5 = new Option() {TheOption = "Slide", Question = question2};
            Option option6 = new Option() {TheOption = "Drinking fountain", Question = question2};
            Option option7 = new Option() {TheOption = "Swing", Question = question2};
            question2.Options = new List<Option>() { option5, option6, option7 };
            // IoTSetups
            IotSetup iot1 = new IotSetup()
            {
                Address = new Address(),
            };
            q4.IotSetup = iot1;
            
            questionnaire1.Questions = new List<Question>() { q1, q2, q3, question1 };
            questionnaire2.Questions = new List<Question>() { q4, q5, question2 };
            #endregion
            
            #region TestProject 2
            Project p2 = new Project()
            {
                Description = "A project started by the city of antwerp with the intention to adopt street birds",
                EndDate = new DateTime(2019, 3,9),
                StartDate = new DateTime(2019,4,10),
                Phases = new List<Phase>(),
                Name = "SAFE THE BIRDS!",
                Place = new Place(),
            };
            p2.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            MapField mapproj2 = new MapField{Latitude = 51.21248,Longitude = 4.409641};
            ImageField imgproj2 = new ImageField();            
            imgproj2.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\safebird-project.jpg");
            p2.MapField = mapproj2;
            p2.ImageField = imgproj2;
            
            // Questionnaires
            Questionnaire questionnaire3 = new Questionnaire()
            {
                Name = "Budget",
                QuestionAmount = 4,
                Project = p2,
                Questions = new List<Question>(),
            };
            p2.Questionnaires = new List<Questionnaire>() { questionnaire3 };
            
            // Questions
            Question q6 = new Question()
            {
                TheQuestion = "What should we do to save the birds?",
                Questionnaire = questionnaire3,
                QuestionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                Options = new List<Option>()
            };
            Question q7 = new Question()
            {
                TheQuestion = "What do you think should be our first priority?",
                Questionnaire = questionnaire3,
                QuestionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option o6 = new Option() {TheOption = "Build birds more houses", Question = q7};
            Option o7 = new Option() {TheOption = "Give more options for birds to eat", Question = q7};
            Option o8 = new Option() {TheOption = "Give more options for birds to drink", Question = q7};
            Option o9 = new Option() {TheOption = "Plant more trees", Question = q7};
            q7.Options = new List<Option>() { o6, o7, o8, o9 };
            Question q8 = new Question()
            {
                TheQuestion = "What should we feed the birds?",
                Questionnaire = questionnaire3,
                QuestionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option o10 = new Option() {TheOption = "Grains", Question = q8};
            Option o11 = new Option() {TheOption = "Seeds", Question = q8};
            Option o12 = new Option() {TheOption = "Chocolat", Question = q8};
            q8.Options = new List<Option>() { o10, o11, o12 };
            Question q9 = new Question()
            {
                TheQuestion = "How should we feed the birds",
                Questionnaire = questionnaire3,
                QuestionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                Options = new List<Option>()
            };
            Option o13 = new Option() {TheOption = "With bowls", Question = q9};
            Option o14 = new Option() {TheOption = "On the floor", Question = q9};
            Option o15 = new Option() {TheOption = "Hanging in the tree", Question = q9};
            q9.Options = new List<Option>() { o13, o14, o15 };
            questionnaire3.Questions = new List<Question>() { q6, q7, q8, q9 };
            #endregion
            
            //Phases
            Phase ph1 = new Phase() { Project = p1, Name = "Brainstorming",Description = "We are starting this project by gathering input from the community"};
            Phase ph2 = new Phase() { Project = p1, Name = "Construction",Description = "We are building the most suggested constructions in the playground"};
            Phase ph3 = new Phase() { Project = p1, Name = "Opening",Description = "We will celebrate the opening of this park together!"};
            p1.Phases = new List<Phase>(){ph1,ph2,ph3};
            
            Project p3 = new Project();
            MapField map1 = new MapField{Latitude = 51.21248,Longitude = 4.409641};
            ImageField img1 = new ImageField();            
            img1.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\bbq-project.jpg");
            p3.Name = "Summer bbqs";
            p3.Description =
                "The city of antwerp wants to host local bbq's this summmer for the inhabitants.";
            p3.StartDate = new DateTime(2019,7,1);
            p3.EndDate = new DateTime(2019,8,1);
            p3.Setting = new Setting {BackGroundColor1 = "yellow", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p3.Phases = new List<Phase>
            {
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,7,1),EndDate =  new DateTime(2019,7,20)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,7,25),EndDate =  new DateTime(2019,8,20)},

            };
            p3.MapField = map1;
            p3.ImageField = img1;

            // Soccer Tournament Project
            Project p4 = new Project();
            MapField map4 = new MapField { Latitude = 51.19482591025128, Longitude = 4.424488633272745 };
            ImageField img4 = new ImageField();
            img4.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\soccerProject.jpg");
            p4.Name = "Soccer Tournament";
            p4.Description = "The locals in Berchem are planning on organizing a Soccer Tournament set in June, 2019.";
            p4.StartDate = new DateTime(2019, 5, 6);
            p4.EndDate = new DateTime(2019, 7, 7);
            p4.Setting = new Setting {BackGroundColor1 = "red", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p4.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,6,6),EndDate =  new DateTime(2019,6,10)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,6,10),EndDate =  new DateTime(2019,6,15)},
            };
            p4.MapField = map4;
            p4.ImageField = img4;

            // tug of war
            Project p5 = new Project();
            MapField map5 = new MapField { Latitude = 51.19085124996951, Longitude = 4.426741327814966 };
            ImageField img5 = new ImageField();
            img5.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\ropepulling-project.jpg");
            p5.Name = "Tug of war!";
            p5.Description = "An elementary school is organizing an event to start off the summer with a boom. People will be able to play tug of war in a huge park.";
            p5.StartDate = new DateTime(2019, 6, 1);
            p5.EndDate = new DateTime(2019, 6, 5);
            p5.Setting = new Setting {BackGroundColor1 = "red", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p5.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,5,1),EndDate =  new DateTime(2019,5,15)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,5,15),EndDate =  new DateTime(2019,6,1)},
            };
            p5.MapField = map5;
            p5.ImageField = img5;

            // Asian/Eastern food
            Project p6 = new Project();
            MapField map6 = new MapField { Latitude = 51.18963283343007, Longitude = 4.420076572104449 };
            ImageField img6 = new ImageField();
            img6.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\asian-food-project.jpg");
            p6.Closed = true;
            p6.Name = "Asian Cuisine";
            p6.Description = "A lovely family is organizing an Asian Cuisine evening in the park for everyone!";
            p6.StartDate = new DateTime(2019, 5, 20);
            p6.EndDate = new DateTime(2019, 5, 21);
            p6.Setting = new Setting {BackGroundColor1 = "green", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p6.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,5,5),EndDate =  new DateTime(2019,5,10)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,5,15),EndDate =  new DateTime(2019,5,20)},
            };
            p6.ImageField = img6;
            p6.MapField = map6;

            // Flea market
            Project p7 = new Project();
            MapField map7 = new MapField { Latitude = 51.1987041954414, Longitude = 4.42399545204978 };
            ImageField img7 = new ImageField();
            img7.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\fleamarket-project.jpg");
            p7.Name = "Flea market in Berchem";
            p7.Description = "The people of Antwerp are organizing a flea market which will take place for 3 days.";
            p7.StartDate = new DateTime(2019, 6, 10);
            p7.EndDate = new DateTime(2019, 6, 13);
            p7.Closed = true;
            p7.Setting = new Setting {BackGroundColor1 = "orange", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p7.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,6,1),EndDate =  new DateTime(2019,6,7)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,6,8),EndDate =  new DateTime(2019,6,10)},
            };
            p7.ImageField = img7;
            p7.MapField = map7;

            // Art evening
            Project p8 = new Project();
            MapField map8 = new MapField { Latitude = 51.21250372160042, Longitude = 4.4180404853490245 };
            ImageField img8 = new ImageField();
            img8.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\artgallery-project.jpg");
            p8.Name = "Art gallery in Antwerp";
            p8.Description = "From june 6 to june 11, school of art in Antwerp is organizing an art gallery";
            p8.Closed = true;
            p8.StartDate = new DateTime(2019, 6, 6);
            p8.EndDate = new DateTime(2019, 6, 11);
            p8.Setting = new Setting {BackGroundColor1 = "yellow", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p8.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,5,20),EndDate =  new DateTime(2019,5,25)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,6,3),EndDate =  new DateTime(2019,6,6)},
            };
            p8.ImageField = img8;
            p8.MapField = map8;

            // Sushi evening
            Project p9 = new Project();
            MapField map9 = new MapField { Latitude = 51.21205064975499, Longitude = 4.4135022509701685 };
            ImageField img9 = new ImageField();
            img9.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\sushi-project.jpg");
            p9.Name = "Sushi evening";
            p9.Description = "This summer the people of antwerp will organise a traditional japanese weekend.";
            p9.StartDate = new DateTime(2019, 7, 5);
            p9.EndDate = new DateTime(2019, 7, 7);
            p9.Closed = true;
            p9.Setting = new Setting {BackGroundColor1 = "green", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p9.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,7,1),EndDate =  new DateTime(2019,7,4)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,7,5),EndDate =  new DateTime(2019,7,7)},
            };
            p9.ImageField = img9;
            p9.MapField = map9;

            // Badminton tournament
            Project p10 = new Project();
            MapField map10 = new MapField { Latitude = 51.21315287598253, Longitude = 4.415047195504712 };
            ImageField img10 = new ImageField();
            img10.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-park-badminton.jpg");
            p10.Name = "Badminton tournament";
            p10.Description = "In the summer , the city will organize a badminton tournament in City park. Everybody is welcome!";
            p10.StartDate = new DateTime(2019, 5, 1);
            p10.EndDate = new DateTime(2019, 5, 23);
            p10.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p10.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,5,1),EndDate =  new DateTime(2019,5,10)},
                new Phase{Name = "Construction",Description = "Creat everything we need before the event",StartDate =  new DateTime(2019,5,11),EndDate =  new DateTime(2019,5,16)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,5,17),EndDate =  new DateTime(2019,5,20)},
                new Phase{Name = "Event",Description = "The badminton tournament takes place",StartDate =  new DateTime(2019,5,21),EndDate =  new DateTime(2019,5,23)},
            };
            Ideation id1 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea1 f1"
                            },
                            new TextField
                            {
                                Required = true,
                                Text = "test idea1 f2"
                            }
                        },
                        Reactions = new List<Reaction>
                        {
                            new Reaction
                            {
                                Content = "reaction 1 idea 1",
                                Date = DateTime.Now,
                                User = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result
                            },
                            new Reaction
                            {
                                Content = "reaction 2 idea 1",
                                Date = DateTime.Now,
                                User = userManager.FindByEmailAsync("peter.smet@gmail.com").Result
                            }
                        }
                    },
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            },
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f2"
                            },
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f3"
                            }
                        },
                        Reactions = new List<Reaction>
                        {
                            new Reaction
                            {
                                Content = "reaction 1 idea 2",
                                Date = DateTime.Now,
                                User = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result
                            }
                        }
                    }
                }
            };
            Ideation id2 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            }
                        },
                        Reactions = new List<Reaction>()
                    }
                }
            };
            Ideation id3 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            }
                        },
                        Reactions = new List<Reaction>()
                    }
                }
            };
            Ideation id4 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            }
                        },
                        Reactions = new List<Reaction>()
                    }
                }
            };
            Ideation id5 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            }
                        },
                        Reactions = new List<Reaction>()
                    }
                }
            };
            Ideation id6 = new Ideation
            {
                Ideas = new List<Idea>
                {
                    new Idea
                    {
                        User = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        Fields = new List<Field>
                        {
                            new TextField
                            {
                                Required = true,
                                Text = "test idea2 f1"
                            }
                        },
                        Reactions = new List<Reaction>()
                    }
                }
            };
            p10.Ideations = new List<Ideation>()
            {
                id1, id2, id3, id4, id5, id6
            };
            p10.ImageField = img10;
            p10.MapField = map10;
            IdeationQuestion iq10d1 = new IdeationQuestion()
            {
                Ideation = id1,
                Question = "central question d1",
                Description = "omschrijving centrale vraag d2",
                BackgroundInfo = "www.google.be"
            };
            IdeationQuestion iq10d2 = new IdeationQuestion()
            {
                Ideation = id1,
                Question = "central question d2",
                Description = "omschrijving centrale vraag d2",
                BackgroundInfo = "www.google.be"
            };
            ctx.IdeationQuestions.Add(iq10d1);
            ctx.IdeationQuestions.Add(iq10d2);
            id1.Questions.Add(iq10d1);
            id1.Questions.Add(iq10d2);


            // Parking lot movie 
            Project p11 = new Project();
            MapField map11 = new MapField { Latitude = 51.21847254325475, Longitude = 51.21847254325475 };
            ImageField img11 = new ImageField();
            img11.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-parking-lot.jpg");
            p11.Name = "Parking lot movie";
            p11.Description = "The people of the harbour will organize parking lot movies every weekend for a few months!";
            p11.StartDate = new DateTime(2019, 5, 3);
            p11.EndDate = new DateTime(2019, 8, 5);
            p11.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p11.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,8,1),EndDate =  new DateTime(2019,6,15)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,8,20),EndDate =  new DateTime(2019,6,30)},
            };
            p11.ImageField = img11;
            p11.MapField = map11;

            // Renaissance faire
            Project p12 = new Project();
            MapField map12 = new MapField { Latitude = 51.21215292577289, Longitude = 4.414958953857422 };
            ImageField img12 = new ImageField();
            img12.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-renaissance-faire.jpg");
            p12.Name = "Renaissance faire in Antwerp";
            p12.Description = "We are very proud to announce that we are finally able to host the Renaissance faire in Antwerp, please join us for a trip back in time!";
            p12.StartDate = new DateTime(2019, 7, 20);
            p12.EndDate = new DateTime(2019, 7, 30);
            p12.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p12.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,6,20),EndDate =  new DateTime(2019,7,5)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,7,5),EndDate =  new DateTime(2019,7,20)},
            };

            p12.ImageField = img12;
            p12.MapField = map12;

            Project p13 = new Project();
            MapField map13 = new MapField { Latitude = 51.20595899589377, Longitude = 4.383128206683523 };
            ImageField img13 = new ImageField();
            img13.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\antique-project.jpg");
            p13.Name = "Antique flea market";
            p13.Description = "This years Antique flea market will be hosted in Antwerp. The market will be filled with extraordinary itmes, please join us!";
            p13.StartDate = new DateTime(2019, 6, 1);
            p13.EndDate = new DateTime(2019, 6, 3);
            p13.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p13.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,5,20),EndDate =  new DateTime(2019,5,25)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,5,26),EndDate =  new DateTime(2019,6,1)},
            };

            p13.ImageField = img13;
            p13.MapField = map13;

            
            // Concert evening
            Project p14 = new Project();
            MapField map14 = new MapField { Latitude = 51.21205064975499, Longitude = 4.4135022509701685 };
            ImageField img14 = new ImageField();
            img14.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\concertproject.jpg");
            p14.Name = "Concert in the park";
            p14.Description = "This summer the people of antwerp will organise a concert and everybody is welcome.";
            p14.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p14.StartDate = new DateTime(2019, 4, 5);
            p14.EndDate = new DateTime(2019, 4, 7);
            p14.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,3,1),EndDate =  new DateTime(2019,3,15)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,4,1),EndDate =  new DateTime(2019,4,3)},
            };
            p14.ImageField = img14;
            p14.MapField = map14;
            
            
            
            // 5km marathon 
            Project p15 = new Project();
            MapField map15 = new MapField { Latitude = 51.21205064975499, Longitude = 4.4135022509701685 };
            ImageField img15 = new ImageField();
            img15.ImageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\marathon-project.jpg");
            p15.Name = "marathon";
            p15.Description = "A local school is organizing a marathon to support their schooltrip.";
            p15.StartDate = new DateTime(2019, 4, 5);
            p15.Setting = new Setting {BackGroundColor1 = "", BackGroundColor2 = "white", FontFamily = "Times new Roman"};
            p15.EndDate = new DateTime(2019, 4, 7);
            p15.Phases = new List<Phase>{
                new Phase{Name = "Brainstorming",Description = "A period where we get the input of the people.",StartDate =  new DateTime(2019,3,1),EndDate =  new DateTime(2019,3,15)},
                new Phase{Name = "Deployment",Description = "Implementing the idea's we've received ",StartDate =  new DateTime(2019,4,1),EndDate =  new DateTime(2019,4,3)},
            };
            p15.ImageField = img15;
            p15.MapField = map15;

            
            //Ideations 
            Ideation it1 = new Ideation(){Project = p1};
            
            p1.Ideations = new List<Ideation>(){it1};
            
            //IdeationQuestions 
            IdeationQuestion iq1 = new IdeationQuestion(){Ideation = it1, Question = "What type of constructions do you want on the playground ? "};
            it1.Questions = new List<IdeationQuestion>(){iq1};
            
            //Ideas 
            Idea i1 = new Idea(){Ideation = it1 , User = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result };
            Idea i2 = new Idea(){Ideation = it1 , User = userManager.FindByEmailAsync("peter.smet@gmail.com").Result };

           // it1.fields = null;
            it1.Ideas = new List<Idea>(){ i1,i2};
            
            //Fields
            ICollection<Field> fields = new List<Field>();
           
            Reaction a1 = new Reaction(){Idea = i1, User = userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result,Content = " Great Idea !" };
            Reaction a2 = new Reaction(){Idea = i2, User = userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result,Content = " Terrible Idea !" };
            
            i1.Reactions = new List<Reaction>(){a1};
            i2.Reactions = new List<Reaction>(){a2};
            
            userManager.FindByEmailAsync("jan.jaap@gmail.com").Result.Ideas = new List<Idea>(){i1};
            userManager.FindByEmailAsync("peter.smet@gmail.com").Result.Ideas = new List<Idea>(){i2};
            userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result.Reactions = new List<Reaction>(){a1,a2};
            
            //Faq
            Faq faq = new Faq
            {
                Question = "How do I create an account?",
                User = userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result,
                Answers = new List<FaqAnswer>
                {
                    new FaqAnswer
                    {
                        Answer = "You have to press the register button on top of the page!",
                        User = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result
                    }, new FaqAnswer
                    {
                        Answer = "Press the register button at the top and fill in your info and then klik the link in the email you received",
                        User = userManager.FindByEmailAsync("peter.smet@gmail.com").Result
                    }
                }
            };

            ctx.Faqs.Add(faq);
            ctx.Projects.AddRange(p1, p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15);
            ctx.Questionnaires.AddRange(questionnaire1, questionnaire2, questionnaire3);
            ctx.Questions.AddRange(q1, question1, q2, q3, q4, q5, question2, q6, q7, q8, q9);
            ctx.IotSetups.AddRange(iot1);
            ctx.Phases.AddRange(ph1,ph2);
            ctx.Ideations.Add(it1);
            ctx.IdeationQuestions.Add(iq1);
            ctx.Ideas.AddRange(i1,i2);

            ctx.Reactions.AddRange(a1,a2);
            ctx.Options.AddRange(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, option1, option2, option3, option4, option5, option6, option7);
            
            ctx.SaveChanges();
        }
    }
}