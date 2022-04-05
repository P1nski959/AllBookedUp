using Microsoft.EntityFrameworkCore.Migrations;

namespace AllBookedUp.Server.Migrations
{
    public partial class MoreSeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Fantasy", "fantasy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 6, 2, "There is a door at the end of a silent corridor. And items haunting Harry Pottterâ€™s dreams. Why else would he be waking in the middle of the night, screaming in terror?Harry has a lot on his mind for this, his fifth year at Hogwarts: a Defense Against the Dark Arts teacher with a personality like poisoned honey; a big surprise on the Gryffindor Quidditch team; and the looming terror of the Ordinary Wizarding Level exams. But all these things pale next to the growing threat of He-Who-Must-Not-Be-Named - a threat that neither the magical government nor the authorities at Hogwarts can stop.As the grasp of darkness tightens, Harry must discover the true depth and strength of his friends, the importance of boundless loyalty, and the shocking price of unbearable sacrifice.His fate depends on them all.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1546910265l/2.jpg", 9.99m, "Harry Potter and the Order of the Phoenix" },
                    { 7, 2, "This four-volume, boxed set contains J.R.R. Tolkien's epic masterworks The Hobbit and the three volumes of The Lord of the Rings (The Fellowship of the Ring, The Two Towers, and The Return of the King).In The Hobbit, Bilbo Baggins is whisked away from his comfortable, unambitious life in Hobbiton by the wizard Gandalf and a company of dwarves. He finds himself caught up in a plot to raid the treasure hoard of Smaug the Magnificent, a large and very dangerous dragon.The Lord of the Rings tells of the great quest undertaken by Frodo Baggins and the Fellowship of the Ring: Gandalf the wizard; the hobbits Merry, Pippin, and Sam; Gimli the dwarf; Legolas the elf; Boromir of Gondor; and a tall, mysterious stranger called Strider. J.R.R. Tolkien's three volume masterpiece is at once a classic myth and a modern fairy taleâ€”a story of high and heroic adventure set in the unforgettable landscape of Middle-earth", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1346072396l/30.jpg", 7.99m, "J.R.R. Tolkien 4-Book Boxed Set: The Hobbit and The Lord of the Rings " },
                    { 8, 2, "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.After a lifetime of bottling up his magical powers, Harry finally feels like a normal kid. But even within the Wizarding community, he is special. He is the boy who lived: the only person to have ever survived a killing curse inflicted by the evil Lord Voldemort, who launched a brutal takeover of the Wizarding world, only to vanish after failing to kill Harry.Though Harry's first year at Hogwarts is the best of his life, not everything is perfect. There is a dangerous secret object hidden within the castle walls, and Harry believes it's his responsibility to prevent it from falling into evil hands. But doing so will bring him into contact with forces more terrifying than he ever could have imagined.Full of sympathetic characters, wildly imaginative situations, and countless exciting details, the first installment in the series assembles an unforgettable magical world and sets the stage for many high-stakes adventures to come.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1474154022l/3._SY475_.jpg", 6.99m, "Harry Potter and the Sorcerer's Stone" },
                    { 9, 2, "Lyra is rushing to the cold, far North, where witch clans and armored bears rule. North, where the Gobblers take the children they steal--including her friend Roger. North, where her fearsome uncle Asriel is trying to build a bridge to a parallel world.Can one small girl make a difference in such great and terrible endeavors? This is Lyra: a savage, a schemer, a liar, and as fierce and true a champion as Roger or Asriel could want--but what Lyra doesn't know is that to help one of them will be to betray the other.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1505766203l/119322._SX318_.jpg", 6.99m, "The Golden Compass" },
                    { 10, 2, "Harry Potter's third year at Hogwarts is full of new dangers. A convicted murderer, Sirius Black, has broken out of Azkaban prison, and it seems he's after Harry. Now Hogwarts is being patrolled by the dementors, the Azkaban guards who are hunting Sirius. But Harry can't imagine that Sirius or, for that matter, the evil Lord Voldemort could be more frightening than the dementors themselves, who have the terrible power to fill anyone they come across with aching loneliness and despair. Meanwhile, life continues as usual at Hogwarts. A top-of-the-line broom takes Harry's success at Quidditch, the sport of the Wizarding world, to new heights. A cute fourth-year student catches his eye. And he becomes close with the new Defense of the Dark Arts teacher, who was a childhood friend of his father. Yet despite the relative safety of life at Hogwarts and the best efforts of the dementors, the threat of Sirius Black grows ever closer. But if Harry has learned anything from his education in wizardry, it is that things are often not what they seem. Tragic revelations, heartwarming surprises, and high-stakes magical adventures await the boy wizard in this funny and poignant third installment of the beloved series.--scholastic.com", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1499277281l/5.jpg", 6.99m, "Harry Potter and the Prisoner of Azkaban" },
                    { 11, 3, "Set amid the austere beauty of the North Carolina coast begins the story of Noah Calhoun, a rural Southerner recently returned from the Second World War. Noah is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer they spent together, Noah is content to live with only memories...until she unexpectedly returns to his town to see him once again.Like a puzzle within a puzzle, the story of Noah and Allie is just the beginning. As it unfolds, their tale miraculously becomes something different, with much higher stakes. The result is a deeply moving portrait of love itself, the tender moments and the fundamental changes that affect us all. It is a story of miracles and emotions that will stay with you forever. ", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1483183484l/33648131._SY475_.jpg", 9.99m, "The Notebook" },
                    { 12, 3, "There was a time when the world was sweeter...when the women in Beaufort, North Carolina, wore dresses, and the men donned hats...when something happened to a seventeen-year-old boy that would change his life forever. Every April, when the wind blows in from the sea and mingles with the scent of lilacs, Landon Carter remembers his last year at Beaufort High. It was 1958, and Landon had already dated a girl or two. He even swore that he had once been in love. Certainly the last person in town he thought he'd fall for was Jamie Sullivan, the daughter of the town's Baptist minister. A quiet girl who always carried a Bible with her schoolbooks, Jamie seemed content living in a world apart from the other teens. She took care of her widowed father, rescued hurt animals, and helped out at the local orphanage. No boy had ever asked her out. Landon would never have dreamed of it. Then a twist of fate made Jamie his partner for the homecoming dance, and Landon Carter's life would never be the same. Being with Jamie would show him the depths of the human heart and lead him to a decision so stunning it would send him irrevocably on the road to manhood. No other author today touches our emotions more deeply than Nicholas Sparks.Illuminating both the strength and the gossamer fragility of our deepest emotions, his two New York Times bestsellers, The Notebook and Message in a Bottle, have established him as the leading author of today's most cherished love stories. Now, in A Walk to Remember, he tells a truly unforgettable story, one that glimmers with all of his magic, holding us spellbound-and reminding us that in life each of us may find one great love, the kind that changes everything...", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1498755310l/35545737._SY475_.jpg", 9.99m, "A Walk to Remember" },
                    { 13, 3, "When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him. Unable to resist Anaâ€™s quiet beauty, wit, and independent spirit, Grey admits he wants her, tooâ€”but on his own terms.Â Shocked yet thrilled by Greyâ€™s singular erotic tastes, Ana hesitates. For all the trappings of successâ€”his multinational businesses, his vast wealth, his loving familyâ€”Grey is a man tormented by demons and consumed by the need to control. When the couple embarks on a daring, passionately physical affair, Ana discovers Christian Greyâ€™s secrets and explores her own dark desires.Erotic, amusing, and deeply moving, the Fifty Shades Trilogy is a tale that will obsess you, possess you, and stay with you forever.This book is intended for mature audiences. ", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1385207843l/10818853.jpg", 9.99m, "Fifty Shades of Grey" },
                    { 14, 3, "The new Abby Abernathy is a good girl. She doesnâ€™t drink or swear, and she has the appropriate number of cardigans in her wardrobe. Abby believes she has enough distance from the darkness of her past, but when she arrives at college with her best friend, her path to a new beginning is quickly challenged by Eastern University's Walking One-Night Stand. Travis Maddox, lean, cut, and covered in tattoos, is exactly what Abby needsâ€”and wantsâ€”to avoid. He spends his nights winning money in a floating fight ring, and his days as the ultimate college campus charmer. Intrigued by Abbyâ€™s resistance to his appeal, Travis tricks her into his daily life with a simple bet. If he loses, he must remain abstinent for a month. If Abby loses, she must live in Travisâ€™s apartment for the same amount of time. Either way, Travis has no idea that he has met his match. ", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358259032l/11505797.jpg", 9.99m, "Beautiful Disaster" },
                    { 15, 3, "Daunted by the singular sexual tastes and dark secrets of the beautiful, tormented young entrepreneur Christian Grey, Anastasia Steele has broken off their relationship to start a new career with a Seattle publishing house. But desire for Christian still dominates her every waking thought, and when he proposes a new arrangement, Anastasia cannot resist. They rekindle their searing sensual affair, and Anastasia learns more about the harrowing past of her damaged, driven, and demanding Fifty Shades. While Christian wrestles with his inner demons, Anastasia must confront her anger and envy of the women who came before her and make the most important decision of her life. Erotic, sparkling and suspenseful, Fifty Shades Darker is the irresistibly addictive second part of the Fifty Shades trilogy. ", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358266080l/11857408.jpg", 9.99m, "Fifty Shades Darker" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Adventure", "adventure" });
        }
    }
}
