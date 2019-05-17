using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
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
                    EmailConfirmed = true
                };
                var result = await userManager.CreateAsync(user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role4);
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
                description = "We are thinking about building a new playground in the middle of central park",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                name = "Playground"
            };
            MapField mapproj1 = new MapField{latitude = 51.21248,longitude = 4.409641};
            ImageField imgproj1 = new ImageField();            
            imgproj1.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\playground-project.jpg");
            p1.mapField = mapproj1;
            p1.imageField = imgproj1;
            
            // Questionnaires
            Questionnaire questionnaire1 = new Questionnaire()
            {
                name = "Safety",
                questionAmount = 4,
                project = p1,
                questions = new List<Question>()
            };
            Questionnaire questionnaire2 = new Questionnaire()
            {
                name = "Noise",
                questionAmount = 3,
                project = p1,
                questions = new List<Question>()
            };
            p1.questionnaires = new List<Questionnaire>() { questionnaire1, questionnaire2 };
            
            // Questions
            Question q1 = new Question()
            {
                question = "Do we need to build a fence around the playground?",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o1 = new Option() {option = "Yes", question = q1};
            Option o2 = new Option() {option = "No", question = q1};
            q1.options = new List<Option>() { o1, o2 };
            Question question1 = new Question()
            {
                question = "How big should the playground be?",
                questionnaire = questionnaire1,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option option1 = new Option() {option = "50m²", question = question1};
            Option option2 = new Option() {option = "60m²", question = question1};
            Option option3 = new Option() {option = "80m²", question = question1};
            Option option4 = new Option() {option = "100m²", question = question1};
            question1.options = new List<Option>() { option1, option2, option3, option4 };
            Question q2 = new Question()
            {
                question = "Where should we build the playground",
                questionnaire = questionnaire1,
                questionType = QuestionType.DROPDOWN,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o3 = new Option() {option = "Brooklyn Street", question = q2};
            Option o4 = new Option() {option = "Second street", question = q2};
            Option o5 = new Option() {option = "New road", question = q2};
            q2.options = new List<Option>() { o3, o4, o5 };
            Question q3 = new Question()
            {
                question = "Fill in your e-mail address:",
                questionnaire = questionnaire1,
                questionType = QuestionType.MAILADDRESS,
                IotSetup = null,
                options = new List<Option>()
            };
            Question q4 = new Question()
            {
                question = "What should we do about the noise polution of the playground?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = new IotSetup(),
                options = new List<Option>()
            };
            Question q5 = new Question()
            {
                question = "Do you think a playground would be anoying if it was near your home?",
                questionnaire = questionnaire2,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                options = new List<Option>()
            };
            Question question2 = new Question()
            {
                question = "What should we add to the playground?",
                questionnaire = questionnaire2,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option option5 = new Option() {option = "Slide", question = question2};
            Option option6 = new Option() {option = "Drinking fountain", question = question2};
            Option option7 = new Option() {option = "Swing", question = question2};
            question2.options = new List<Option>() { option5, option6, option7 };
            // IoTSetups
            IotSetup iot1 = new IotSetup()
            {
                address = new Address(),
            };
            q4.IotSetup = iot1;
            
            questionnaire1.questions = new List<Question>() { q1, q2, q3, question1 };
            questionnaire2.questions = new List<Question>() { q4, q5, question2 };
            #endregion
            
            #region TestProject 2
            Project p2 = new Project()
            {
                description = "A project started by the city of antwerp with the intention to adopt street birds",
                endDate = new DateTime(2019, 3,9),
                startDate = new DateTime(2019,4,10),
                phases = new List<Phase>(),
                name = "SAFE THE BIRDS!",
                place = new Place(),
            };
            MapField mapproj2 = new MapField{latitude = 51.21248,longitude = 4.409641};
            ImageField imgproj2 = new ImageField();            
            imgproj2.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\safebird-project.jpg");
            p2.mapField = mapproj2;
            p2.imageField = imgproj2;
            
            // Questionnaires
            Questionnaire questionnaire3 = new Questionnaire()
            {
                name = "Budget",
                questionAmount = 4,
                project = p2,
                questions = new List<Question>(),
            };
            p2.questionnaires = new List<Questionnaire>() { questionnaire3 };
            
            // Questions
            Question q6 = new Question()
            {
                question = "What should we do to save the birds?",
                questionnaire = questionnaire3,
                questionType = QuestionType.OPEN_QUESTION,
                IotSetup = null,
                options = new List<Option>()
            };
            Question q7 = new Question()
            {
                question = "What do you think should be our first priority?",
                questionnaire = questionnaire3,
                questionType = QuestionType.RADIO_BUTTON,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o6 = new Option() {option = "Build birds more houses", question = q7};
            Option o7 = new Option() {option = "Give more options for birds to eat", question = q7};
            Option o8 = new Option() {option = "Give more options for birds to drink", question = q7};
            Option o9 = new Option() {option = "Plant more trees", question = q7};
            q7.options = new List<Option>() { o6, o7, o8, o9 };
            Question q8 = new Question()
            {
                question = "What should we feed the birds?",
                questionnaire = questionnaire3,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o10 = new Option() {option = "Grains", question = q8};
            Option o11 = new Option() {option = "Seeds", question = q8};
            Option o12 = new Option() {option = "Chocolat", question = q8};
            q8.options = new List<Option>() { o10, o11, o12 };
            Question q9 = new Question()
            {
                question = "How should we feed the birds",
                questionnaire = questionnaire3,
                questionType = QuestionType.CHECK_BOX,
                IotSetup = null,
                options = new List<Option>()
            };
            Option o13 = new Option() {option = "With bowls", question = q9};
            Option o14 = new Option() {option = "On the floor", question = q9};
            Option o15 = new Option() {option = "Hanging in the tree", question = q9};
            q9.options = new List<Option>() { o13, o14, o15 };
            questionnaire3.questions = new List<Question>() { q6, q7, q8, q9 };
            #endregion
            
            /*Project p3 = new Project();
            MapField map1 = new MapField{latitude = 51.21248,longitude = 4.409641};
            ImageField img1 = new ImageField();            
            img1.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\bbq.PNG");
            p3.name = "Summer bbq's";
            p3.description =
                "The city of antwerp wants to host local bbq's this summmer for the inhabitants.";
            p3.startDate = new DateTime(2019,7,1);
            p3.endDate = new DateTime(2019,8,1);
            p3.phases = new List<Phase>
            {
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,7,1),endDate =  new DateTime(2019,7,20)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,7,25),endDate =  new DateTime(2019,8,20)},

            };
            p3.mapField = map1;
            p3.imageField = img1;*/
            
            //Phases
            Phase ph1 = new Phase() { project = p1, name = "Brainstorming",description = "We are starting this project by gathering input from the community"};
            Phase ph2 = new Phase() { project = p1, name = "Construction",description = "We are building the most suggested constructions in the playground"};
            
            p1.phases = new List<Phase>(){ph1,ph2};
            
           Project p3 = new Project();
            MapField map1 = new MapField{latitude = 51.21248,longitude = 4.409641};
            ImageField img1 = new ImageField();            
            img1.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\bbq-project.jpg");
            p3.name = "Summer bbq's";
            p3.description =
                "The city of antwerp wants to host local bbq's this summmer for the inhabitants.";
            p3.startDate = new DateTime(2019,7,1);
            p3.endDate = new DateTime(2019,8,1);
            p3.phases = new List<Phase>
            {
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,7,1),endDate =  new DateTime(2019,7,20)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,7,25),endDate =  new DateTime(2019,8,20)},

            };
            p3.mapField = map1;
            p3.imageField = img1;

            // Soccer Tournament Project
            Project p4 = new Project();
            MapField map4 = new MapField { latitude = 51.19482591025128, longitude = 4.424488633272745 };
            ImageField img4 = new ImageField();
            img4.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\soccerProject.jpg");
            p4.name = "Soccer Tournament";
            p4.description = "The locals in Berchem are planning on organizing a Soccer Tournament set in June, 2019.";
            p4.startDate = new DateTime(2019, 5, 6);
            p4.endDate = new DateTime(2019, 7, 7);
            p4.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,6,6),endDate =  new DateTime(2019,6,10)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,6,10),endDate =  new DateTime(2019,6,15)},
            };
            p4.mapField = map4;
            p4.imageField = img4;

            // tug of war
            Project p5 = new Project();
            MapField map5 = new MapField { latitude = 51.19085124996951, longitude = 4.426741327814966 };
            ImageField img5 = new ImageField();
            img5.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\ropepulling-project.jpg");
            p5.name = "Tug of war!";
            p5.description = "An elementary school is organizing an event to start off the summer with a boom. People will be able to play tug of war in a huge park.";
            p5.startDate = new DateTime(2019, 6, 1);
            p5.endDate = new DateTime(2019, 6, 5);
            p5.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,5,1),endDate =  new DateTime(2019,5,15)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,5,15),endDate =  new DateTime(2019,6,1)},
            };
            p5.mapField = map5;
            p5.imageField = img5;

            // Asian/Eastern food
            Project p6 = new Project();
            MapField map6 = new MapField { latitude = 51.18963283343007, longitude = 4.420076572104449 };
            ImageField img6 = new ImageField();
            img6.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\asian-food-project.jpg");
            p6.name = "Asian Cuisine";
            p6.description = "A lovely family is organizing an Asian Cuisine evening in the park for everyone!";
            p6.startDate = new DateTime(2019, 5, 20);
            p6.endDate = new DateTime(2019, 5, 21);
            p6.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,5,5),endDate =  new DateTime(2019,5,10)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,5,15),endDate =  new DateTime(2019,5,20)},
            };
            p6.imageField = img6;
            p6.mapField = map6;

            // Flea market
            Project p7 = new Project();
            MapField map7 = new MapField { latitude = 51.1987041954414, longitude = 4.42399545204978 };
            ImageField img7 = new ImageField();
            img7.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\fleamarket-project.jpg");
            p7.name = "Flea market in Berchem";
            p7.description = "The people of Antwerp are organizing a flea market which will take place for 3 days.";
            p7.startDate = new DateTime(2019, 6, 10);
            p7.endDate = new DateTime(2019, 6, 13);
            p6.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,6,1),endDate =  new DateTime(2019,6,7)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,6,8),endDate =  new DateTime(2019,6,10)},
            };
            p7.imageField = img7;
            p7.mapField = map7;

            // Art evening
            Project p8 = new Project();
            MapField map8 = new MapField { latitude = 51.21250372160042, longitude = 4.4180404853490245 };
            ImageField img8 = new ImageField();
            img8.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\artgallery-project.jpg");
            p8.name = "Art gallery in Antwerp";
            p8.description = "From june 6 to june 11, school of art in Antwerp is organizing an art gallery";
            p8.startDate = new DateTime(2019, 6, 6);
            p8.endDate = new DateTime(2019, 6, 11);
            p8.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,5,20),endDate =  new DateTime(2019,5,25)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,6,3),endDate =  new DateTime(2019,6,6)},
            };
            p8.imageField = img8;
            p8.mapField = map8;

            // Sushi evening
            Project p9 = new Project();
            MapField map9 = new MapField { latitude = 51.21205064975499, longitude = 4.4135022509701685 };
            ImageField img9 = new ImageField();
            img9.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\sushi-project.jpg");
            p9.name = "Sushi evening";
            p9.description = "This summer the people of antwerp will organise a traditional japanese weekend.";
            p9.startDate = new DateTime(2019, 7, 5);
            p9.endDate = new DateTime(2019, 7, 7);
            p9.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,7,1),endDate =  new DateTime(2019,7,4)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,7,5),endDate =  new DateTime(2019,7,7)},
            };
            p9.imageField = img9;
            p9.mapField = map9;

            // Badminton tournament
             // Badminton tournament
            Project p10 = new Project();
            MapField map10 = new MapField { latitude = 51.21315287598253, longitude = 4.415047195504712 };
            ImageField img10 = new ImageField();
            img10.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-park-badminton.jpg");
            p10.name = " Badminton tournament";
            p10.description = "In the summer , the city will organize a badminton tournament in City park. Everybody is welcome!";
            p10.startDate = new DateTime(2019, 5, 1);
            p10.endDate = new DateTime(2019, 5, 23);
            p10.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,5,1),endDate =  new DateTime(2019,5,10)},
                new Phase{name = "Construction",description = "Creat everything we need before the event",startDate =  new DateTime(2019,5,11),endDate =  new DateTime(2019,5,16)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,5,17),endDate =  new DateTime(2019,5,20)},
                new Phase{name = "Event",description = "The badminton tournament takes place",startDate =  new DateTime(2019,5,21),endDate =  new DateTime(2019,5,23)},
            };
            Ideation id = new Ideation
            {
                ideas = new List<Idea> {
                    new Idea {
                        user = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        fields = new List<Field>
                        {
                            new TextField
                            {
                                required = true,
                                text = "test idea1 f1"
                            },
                            new TextField
                            {
                            required = true,
                            text = "test idea1 f2"
                            }
                        },
                        reactions = new List<Reaction>
                        {
                            new Reaction
                            {
                                content = "reaction 1 idea 1",
                                date = DateTime.Now,
                                user = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result
                            },
                            new Reaction
                            {
                                content = "reaction 2 idea 1",
                                date = DateTime.Now,
                                user = userManager.FindByEmailAsync("peter.smet@gmail.com").Result
                            }
                        }
                    }, 
                    new Idea {
                        user = userManager.FindByEmailAsync("super.admin@gmail.com").Result,
                        fields = new List<Field>
                        {
                            new TextField
                            {
                                required = true,
                                text = "test idea2 f1"
                            },
                            new TextField
                            {
                                required = true,
                                text = "test idea2 f2"
                            },
                            new TextField
                            {
                                required = true,
                                text = "test idea2 f3"
                            }
                        },
                        reactions = new List<Reaction>
                        {
                        new Reaction
                        {
                            content = "reaction 1 idea 2",
                            date = DateTime.Now,
                            user = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result
                        }
                    }
                    }  
                }
            };
            p10.ideations = new List<Ideation>()
            {
                id
            };
            p10.imageField = img10;
            p10.mapField = map10;
            IdeationQuestion iq10d1 = new IdeationQuestion()
            {
                ideation = id,
                question = "central question d1",
                description = "omschrijving centrale vraag d2",
                backgroundInfo = "www.google.be"
            };
            IdeationQuestion iq10d2 = new IdeationQuestion()
            {
                ideation = id,
                question = "central question d2",
                description = "omschrijving centrale vraag d2",
                backgroundInfo = "www.google.be"
            };
            ctx.ideationQuestions.Add(iq10d1);
            ctx.ideationQuestions.Add(iq10d2);
            id.questions.Add(iq10d1);
            id.questions.Add(iq10d2);


            // Parking lot movie 
            Project p11 = new Project();
            MapField map11 = new MapField { latitude = 51.21847254325475, longitude = 51.21847254325475 };
            ImageField img11 = new ImageField();
            img11.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-parking-lot.jpg");
            p11.name = "Parking lot movie";
            p11.description = "The people of the harbour will organize parking lot movies every weekend for a few months!";
            p11.startDate = new DateTime(2019, 5, 3);
            p11.endDate = new DateTime(2019, 8, 5);
            p11.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,8,1),endDate =  new DateTime(2019,6,15)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,8,20),endDate =  new DateTime(2019,6,30)},
            };
            p11.imageField = img11;
            p11.mapField = map11;

            // Renaissance faire
            Project p12 = new Project();
            MapField map12 = new MapField { latitude = 51.21215292577289, longitude = 4.414958953857422 };
            ImageField img12 = new ImageField();
            img12.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\project-renaissance-faire.jpg");
            p12.name = "Renaissance faire in Antwerp";
            p12.description = "We are very proud to announce that we are finally able to host the Renaissance faire in Antwerp, please join us for a trip back in time!";
            p12.startDate = new DateTime(2019, 7, 20);
            p12.endDate = new DateTime(2019, 7, 30);
            p12.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,6,20),endDate =  new DateTime(2019,7,5)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,7,5),endDate =  new DateTime(2019,7,20)},
            };

            p12.imageField = img12;
            p12.mapField = map12;

            Project p13 = new Project();
            MapField map13 = new MapField { latitude = 51.20595899589377, longitude = 4.383128206683523 };
            ImageField img13 = new ImageField();
            img13.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\antique-project.jpg");
            p13.name = "Antique flea market";
            p13.description = "This years Antique flea market will be hosted in Antwerp. The market will be filled with extraordinary itmes, please join us!";
            p13.startDate = new DateTime(2019, 6, 1);
            p13.endDate = new DateTime(2019, 6, 3);
            p13.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,5,20),endDate =  new DateTime(2019,5,25)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,5,26),endDate =  new DateTime(2019,6,1)},
            };

            p13.imageField = img13;
            p13.mapField = map13;

            
            // Concert evening
           
            Project p14 = new Project();
            MapField map14 = new MapField { latitude = 51.21205064975499, longitude = 4.4135022509701685 };
            ImageField img14 = new ImageField();
            img14.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\concertproject.jpg");
            p14.name = "Concert in the park";
            p14.description = "This summer the people of antwerp will organise a concert and everybody is welcome.";
            p14.startDate = new DateTime(2019, 4, 5);
            p14.endDate = new DateTime(2019, 4, 7);
            p14.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,3,1),endDate =  new DateTime(2019,3,15)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,4,1),endDate =  new DateTime(2019,4,3)},
            };
            p14.imageField = img14;
            p14.mapField = map14;
            
            
            
            // 5km marathon 
           
            Project p15 = new Project();
            MapField map15 = new MapField { latitude = 51.21205064975499, longitude = 4.4135022509701685 };
            ImageField img15 = new ImageField();
            img15.imageData = System.IO.File.ReadAllBytes(".\\wwwroot\\images\\marathon-project.jpg");
            p15.name = "marathon";
            p15.description = "A local school is organizing a marathon to support their schooltrip.";
            p15.startDate = new DateTime(2019, 4, 5);
            p15.endDate = new DateTime(2019, 4, 7);
            p15.phases = new List<Phase>{
                new Phase{name = "Brainstorming",description = "A period where we get the input of the people.",startDate =  new DateTime(2019,3,1),endDate =  new DateTime(2019,3,15)},
                new Phase{name = "Deployment",description = "Implementing the idea's we've received ",startDate =  new DateTime(2019,4,1),endDate =  new DateTime(2019,4,3)},
            };
            p15.imageField = img15;
            p15.mapField = map15;

            
            //Ideations 
            
            Ideation it1 = new Ideation(){project = p1};
            
            p1.ideations = new List<Ideation>(){it1};
            
            //IdeationQuestions 

            IdeationQuestion iq1 = new IdeationQuestion(){ideation = it1, question = "What type of constructions do you want on the playground ? "};
            it1.questions = new List<IdeationQuestion>(){iq1};
            
           
         //   fields.Add(if1);
            //Ideas 
            
            Idea i1 = new Idea(){ideation = it1 , user = userManager.FindByEmailAsync("jan.jaap@gmail.com").Result };
            Idea i2 = new Idea(){ideation = it1 , user = userManager.FindByEmailAsync("peter.smet@gmail.com").Result };

           // it1.fields = null;
            
            it1.ideas = new List<Idea>(){ i1,i2};
            //Fields
            ICollection<Field> fields = new List<Field>();
           
           
            //answers 
           // Reaction a3 = new Reaction(){content = "test",idea = null};
            
            Reaction a1 = new Reaction(){idea = i1, user = userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result,content = " Great Idea !" };
            Reaction a2 = new Reaction(){idea = i2, user = userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result,content = " Terrible Idea !" };
            
            i1.reactions = new List<Reaction>(){a1};
            i2.reactions = new List<Reaction>(){a2};
            
            userManager.FindByEmailAsync("jan.jaap@gmail.com").Result.ideas = new List<Idea>(){i1};
            userManager.FindByEmailAsync("peter.smet@gmail.com").Result.ideas = new List<Idea>(){i2};
            userManager.FindByEmailAsync("dirk.bakker@gmail.com").Result.reactions = new List<Reaction>(){a1,a2};

            ctx.projects.AddRange(p1, p2,p3,p4,p5,p6,p7,p8,p9,p10,p11,p12,p13,p14,p15);
            ctx.questionnaires.AddRange(questionnaire1, questionnaire2, questionnaire3);
            ctx.questions.AddRange(q1, question1, q2, q3, q4, q5, question2, q6, q7, q8, q9);
            ctx.iotSetups.AddRange(iot1);
            ctx.phases.AddRange(ph1,ph2);
            ctx.ideations.Add(it1);
            ctx.ideationQuestions.Add(iq1);
            ctx.ideas.AddRange(i1,i2);

            ctx.reactions.AddRange(a1,a2);
            ctx.options.AddRange(o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, option1, option2, option3, option4, option5, option6, option7);
            
            ctx.SaveChanges();
        }
    }
}