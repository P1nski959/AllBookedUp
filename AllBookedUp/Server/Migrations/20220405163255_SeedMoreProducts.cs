using Microsoft.EntityFrameworkCore.Migrations;

namespace AllBookedUp.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Seconds before the Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy who, for the last fifteen years, has been posing as an out-of-work actor.Together this dynamic pair begin a journey through space aided by quotes from The Hitchhiker's Guide and a galaxy-full of fellow travelers: Zaphod Beeblebroxâ€”the two-headed, three-armed ex-hippie and totally out-to-lunch president of the galaxy; Trillian, Zaphod's girlfriend (formally Tricia McMillan), whom Arthur tried to pick up at a cocktail party once upon a time zone; Marvin, a paranoid, brilliant, and chronically depressed robot; Veet Voojagig, a former graduate student who is obsessed with the disappearance of all the ballpoint pens he bought over the years.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "This is the way the world ends: with a nanosecond of computer error in a Defense Department laboratory and a million casual contacts that form the links in a chain letter of death. And here is the bleak new world of the day after: a world stripped of its institutions and emptied of 99 percent of its people. A world in which a handful of panicky survivors choose sides -- or are chosen.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1213131305l/149267.jpg", "The Stand " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "This is the story of Louis, as told in his own words, of his journey through mortal and immortal life. Louis recounts how he became a vampire at the hands of the radiant and sinister Lestat and how he became indoctrinated, unwillingly, into the vampire way of life. His story ebbs and flows through the streets of New Orleans, defining crucial moments such as his discovery of the exquisite lost young child Claudia, wanting not to hurt but to comfort her with the last breaths of humanity he has inside. Yet, he makes Claudia a vampire, trapping her womanly passion, will, and intelligence inside the body of a small child. Louis and Claudia form a seemingly unbreakable alliance and even settle down for a while in the opulent French Quarter. Louis remembers Claudia's struggle to understand herself and the hatred they both have for Lestat that sends them halfway across the world to seek others of their kind. Louis and Claudia are desperate to find somewhere they belong, to find others who understand, and someone who knows what and why they are.Louis and Claudia travel Europe, eventually coming to Paris and the ragingly successful Theatre des Vampires--a theatre of vampires pretending to be mortals pretending to be vampires. Here they meet the magnetic and ethereal Armand, who brings them into a whole society of vampires. But Louis and Claudia find that finding others like themselves provides no easy answers and in fact presents dangers they scarcely imagined.Originally begun as a short story, the book took off as Anne wrote it, spinning the tragic and triumphant life experiences of a soul. As well as the struggles of its characters, Interview captures the political and social changes of two continents. The novel also introduces Lestat, Anne's most enduring character, a heady mixture of attraction and revulsion. The book, full of lush description, centers on the themes of immortality, change, loss, sexuality, and power.source: annerice.com", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1380631642l/43763.jpg", "Interview with the Vampire" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, "Jack Torrance's new job at the Overlook Hotel is the perfect chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he'll have plenty of time to spend reconnecting with his family and working on his writing. But as the harsh winter weather sets in, the idyllic location feels ever more remote...and more sinister. And the only one to notice the strange and terrible forces gathering around the Overlook is Danny Torrance, a uniquely gifted five-year-old.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1353277730l/11588.jpg", 6.99m, "The Shining" },
                    { 5, 1, "Welcome to Derry, Maine ...Itâ€™s a small city, a place as hauntingly familiar as your own hometown. Only in Derry the haunting is real ...They were seven teenagers when they first stumbled upon the horror. Now they are grown-up men and women who have gone out into the big world to gain success and happiness. But none of them can withstand the force that has drawn them back to Derry to face the nightmare without an end, and the evil without a name.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1334416842l/830502.jpg", 6.99m, "It" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Test book for the hitch hikers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Test book for ID 2", "https://upload.wikimedia.org/wikipedia/en/c/cf/SoLongAndThanksForAllTheFish.jpg", "Test book 2 " });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Title" },
                values: new object[] { "Test book for the ID 3", "https://upload.wikimedia.org/wikipedia/en/d/d3/Life%2C_The_Universe_and_Everything_cover.jpg", "Test book 3" });
        }
    }
}
