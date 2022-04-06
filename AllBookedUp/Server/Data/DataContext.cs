﻿using AllBookedUp.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllBookedUp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Horror",
                        Url = "horror"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Fantasy",
                        Url = "fantasy"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Romance",
                        Url = "romance"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "The Hitchhiker's Guide to the Galaxy",
                        Description = "Seconds before the Earth is demolished to make way for a galactic freeway, Arthur Dent is plucked off the planet by his friend Ford Prefect, a researcher for the revised edition of The Hitchhiker's Guide to the Galaxy who, for the last fifteen years, has been posing as an out-of-work actor.Together this dynamic pair begin a journey through space aided by quotes from The Hitchhiker's Guide and a galaxy-full of fellow travelers: Zaphod Beeblebroxâ€”the two-headed, three-armed ex-hippie and totally out-to-lunch president of the galaxy; Trillian, Zaphod's girlfriend (formally Tricia McMillan), whom Arthur tried to pick up at a cocktail party once upon a time zone; Marvin, a paranoid, brilliant, and chronically depressed robot; Veet Voojagig, a former graduate student who is obsessed with the disappearance of all the ballpoint pens he bought over the years.",
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        Price = 9.99m,
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "The Stand ",
                        Description = "This is the way the world ends: with a nanosecond of computer error in a Defense Department laboratory and a million casual contacts that form the links in a chain letter of death. And here is the bleak new world of the day after: a world stripped of its institutions and emptied of 99 percent of its people. A world in which a handful of panicky survivors choose sides -- or are chosen.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1213131305l/149267.jpg",
                        Price = 7.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Interview with the Vampire",
                        Description = "This is the story of Louis, as told in his own words, of his journey through mortal and immortal life. Louis recounts how he became a vampire at the hands of the radiant and sinister Lestat and how he became indoctrinated, unwillingly, into the vampire way of life. His story ebbs and flows through the streets of New Orleans, defining crucial moments such as his discovery of the exquisite lost young child Claudia, wanting not to hurt but to comfort her with the last breaths of humanity he has inside. Yet, he makes Claudia a vampire, trapping her womanly passion, will, and intelligence inside the body of a small child. Louis and Claudia form a seemingly unbreakable alliance and even settle down for a while in the opulent French Quarter. Louis remembers Claudia's struggle to understand herself and the hatred they both have for Lestat that sends them halfway across the world to seek others of their kind. Louis and Claudia are desperate to find somewhere they belong, to find others who understand, and someone who knows what and why they are.Louis and Claudia travel Europe, eventually coming to Paris and the ragingly successful Theatre des Vampires--a theatre of vampires pretending to be mortals pretending to be vampires. Here they meet the magnetic and ethereal Armand, who brings them into a whole society of vampires. But Louis and Claudia find that finding others like themselves provides no easy answers and in fact presents dangers they scarcely imagined.Originally begun as a short story, the book took off as Anne wrote it, spinning the tragic and triumphant life experiences of a soul. As well as the struggles of its characters, Interview captures the political and social changes of two continents. The novel also introduces Lestat, Anne's most enduring character, a heady mixture of attraction and revulsion. The book, full of lush description, centers on the themes of immortality, change, loss, sexuality, and power.source: annerice.com",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1380631642l/43763.jpg",
                        Price = 6.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "The Shining",
                        Description = "Jack Torrance's new job at the Overlook Hotel is the perfect chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he'll have plenty of time to spend reconnecting with his family and working on his writing. But as the harsh winter weather sets in, the idyllic location feels ever more remote...and more sinister. And the only one to notice the strange and terrible forces gathering around the Overlook is Danny Torrance, a uniquely gifted five-year-old.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1353277730l/11588.jpg",
                        Price = 6.99m,
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "It",
                        Description = "Welcome to Derry, Maine ...Itâ€™s a small city, a place as hauntingly familiar as your own hometown. Only in Derry the haunting is real ...They were seven teenagers when they first stumbled upon the horror. Now they are grown-up men and women who have gone out into the big world to gain success and happiness. But none of them can withstand the force that has drawn them back to Derry to face the nightmare without an end, and the evil without a name.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1334416842l/830502.jpg",
                        Price = 6.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Harry Potter and the Order of the Phoenix",
                        Description = "There is a door at the end of a silent corridor. And items haunting Harry Pottterâ€™s dreams. Why else would he be waking in the middle of the night, screaming in terror?Harry has a lot on his mind for this, his fifth year at Hogwarts: a Defense Against the Dark Arts teacher with a personality like poisoned honey; a big surprise on the Gryffindor Quidditch team; and the looming terror of the Ordinary Wizarding Level exams. But all these things pale next to the growing threat of He-Who-Must-Not-Be-Named - a threat that neither the magical government nor the authorities at Hogwarts can stop.As the grasp of darkness tightens, Harry must discover the true depth and strength of his friends, the importance of boundless loyalty, and the shocking price of unbearable sacrifice.His fate depends on them all.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1546910265l/2.jpg",
                        Price = 9.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "J.R.R. Tolkien 4-Book Boxed Set: The Hobbit and The Lord of the Rings ",
                        Description = "This four-volume, boxed set contains J.R.R. Tolkien's epic masterworks The Hobbit and the three volumes of The Lord of the Rings (The Fellowship of the Ring, The Two Towers, and The Return of the King).In The Hobbit, Bilbo Baggins is whisked away from his comfortable, unambitious life in Hobbiton by the wizard Gandalf and a company of dwarves. He finds himself caught up in a plot to raid the treasure hoard of Smaug the Magnificent, a large and very dangerous dragon.The Lord of the Rings tells of the great quest undertaken by Frodo Baggins and the Fellowship of the Ring: Gandalf the wizard; the hobbits Merry, Pippin, and Sam; Gimli the dwarf; Legolas the elf; Boromir of Gondor; and a tall, mysterious stranger called Strider. J.R.R. Tolkien's three volume masterpiece is at once a classic myth and a modern fairy taleâ€”a story of high and heroic adventure set in the unforgettable landscape of Middle-earth",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1346072396l/30.jpg",
                        Price = 7.99m,
                        CategoryId = 2,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Harry Potter and the Sorcerer's Stone",
                        Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs. But his fortune changes when he receives a letter that tells him the truth about himself: he's a wizard. A mysterious visitor rescues him from his relatives and takes him to his new home, Hogwarts School of Witchcraft and Wizardry.After a lifetime of bottling up his magical powers, Harry finally feels like a normal kid. But even within the Wizarding community, he is special. He is the boy who lived: the only person to have ever survived a killing curse inflicted by the evil Lord Voldemort, who launched a brutal takeover of the Wizarding world, only to vanish after failing to kill Harry.Though Harry's first year at Hogwarts is the best of his life, not everything is perfect. There is a dangerous secret object hidden within the castle walls, and Harry believes it's his responsibility to prevent it from falling into evil hands. But doing so will bring him into contact with forces more terrifying than he ever could have imagined.Full of sympathetic characters, wildly imaginative situations, and countless exciting details, the first installment in the series assembles an unforgettable magical world and sets the stage for many high-stakes adventures to come.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1474154022l/3._SY475_.jpg",
                        Price = 6.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "The Golden Compass",
                        Description = "Lyra is rushing to the cold, far North, where witch clans and armored bears rule. North, where the Gobblers take the children they steal--including her friend Roger. North, where her fearsome uncle Asriel is trying to build a bridge to a parallel world.Can one small girl make a difference in such great and terrible endeavors? This is Lyra: a savage, a schemer, a liar, and as fierce and true a champion as Roger or Asriel could want--but what Lyra doesn't know is that to help one of them will be to betray the other.",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1505766203l/119322._SX318_.jpg",
                        Price = 6.99m,
                        CategoryId = 2,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "Harry Potter and the Prisoner of Azkaban",
                        Description = "Harry Potter's third year at Hogwarts is full of new dangers. A convicted murderer, Sirius Black, has broken out of Azkaban prison, and it seems he's after Harry. Now Hogwarts is being patrolled by the dementors, the Azkaban guards who are hunting Sirius. But Harry can't imagine that Sirius or, for that matter, the evil Lord Voldemort could be more frightening than the dementors themselves, who have the terrible power to fill anyone they come across with aching loneliness and despair. Meanwhile, life continues as usual at Hogwarts. A top-of-the-line broom takes Harry's success at Quidditch, the sport of the Wizarding world, to new heights. A cute fourth-year student catches his eye. And he becomes close with the new Defense of the Dark Arts teacher, who was a childhood friend of his father. Yet despite the relative safety of life at Hogwarts and the best efforts of the dementors, the threat of Sirius Black grows ever closer. But if Harry has learned anything from his education in wizardry, it is that things are often not what they seem. Tragic revelations, heartwarming surprises, and high-stakes magical adventures await the boy wizard in this funny and poignant third installment of the beloved series.--scholastic.com",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1499277281l/5.jpg",
                        Price = 6.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "The Notebook",
                        Description = "Set amid the austere beauty of the North Carolina coast begins the story of Noah Calhoun, a rural Southerner recently returned from the Second World War. Noah is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer they spent together, Noah is content to live with only memories...until she unexpectedly returns to his town to see him once again.Like a puzzle within a puzzle, the story of Noah and Allie is just the beginning. As it unfolds, their tale miraculously becomes something different, with much higher stakes. The result is a deeply moving portrait of love itself, the tender moments and the fundamental changes that affect us all. It is a story of miracles and emotions that will stay with you forever. ",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1483183484l/33648131._SY475_.jpg",
                        Price = 9.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "A Walk to Remember",
                        Description = "There was a time when the world was sweeter...when the women in Beaufort, North Carolina, wore dresses, and the men donned hats...when something happened to a seventeen-year-old boy that would change his life forever. Every April, when the wind blows in from the sea and mingles with the scent of lilacs, Landon Carter remembers his last year at Beaufort High. It was 1958, and Landon had already dated a girl or two. He even swore that he had once been in love. Certainly the last person in town he thought he'd fall for was Jamie Sullivan, the daughter of the town's Baptist minister. A quiet girl who always carried a Bible with her schoolbooks, Jamie seemed content living in a world apart from the other teens. She took care of her widowed father, rescued hurt animals, and helped out at the local orphanage. No boy had ever asked her out. Landon would never have dreamed of it. Then a twist of fate made Jamie his partner for the homecoming dance, and Landon Carter's life would never be the same. Being with Jamie would show him the depths of the human heart and lead him to a decision so stunning it would send him irrevocably on the road to manhood. No other author today touches our emotions more deeply than Nicholas Sparks.Illuminating both the strength and the gossamer fragility of our deepest emotions, his two New York Times bestsellers, The Notebook and Message in a Bottle, have established him as the leading author of today's most cherished love stories. Now, in A Walk to Remember, he tells a truly unforgettable story, one that glimmers with all of his magic, holding us spellbound-and reminding us that in life each of us may find one great love, the kind that changes everything...",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1498755310l/35545737._SY475_.jpg",
                        Price = 9.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "Fifty Shades of Grey",
                        Description = "When literature student Anastasia Steele goes to interview young entrepreneur Christian Grey, she encounters a man who is beautiful, brilliant, and intimidating. The unworldly, innocent Ana is startled to realize she wants this man and, despite his enigmatic reserve, finds she is desperate to get close to him. Unable to resist Anaâ€™s quiet beauty, wit, and independent spirit, Grey admits he wants her, tooâ€”but on his own terms.Â Shocked yet thrilled by Greyâ€™s singular erotic tastes, Ana hesitates. For all the trappings of successâ€”his multinational businesses, his vast wealth, his loving familyâ€”Grey is a man tormented by demons and consumed by the need to control. When the couple embarks on a daring, passionately physical affair, Ana discovers Christian Greyâ€™s secrets and explores her own dark desires.Erotic, amusing, and deeply moving, the Fifty Shades Trilogy is a tale that will obsess you, possess you, and stay with you forever.This book is intended for mature audiences. ",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1385207843l/10818853.jpg",
                        Price = 9.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Beautiful Disaster",
                        Description = "The new Abby Abernathy is a good girl. She doesnâ€™t drink or swear, and she has the appropriate number of cardigans in her wardrobe. Abby believes she has enough distance from the darkness of her past, but when she arrives at college with her best friend, her path to a new beginning is quickly challenged by Eastern University's Walking One-Night Stand. Travis Maddox, lean, cut, and covered in tattoos, is exactly what Abby needsâ€”and wantsâ€”to avoid. He spends his nights winning money in a floating fight ring, and his days as the ultimate college campus charmer. Intrigued by Abbyâ€™s resistance to his appeal, Travis tricks her into his daily life with a simple bet. If he loses, he must remain abstinent for a month. If Abby loses, she must live in Travisâ€™s apartment for the same amount of time. Either way, Travis has no idea that he has met his match. ",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358259032l/11505797.jpg",
                        Price = 9.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "Fifty Shades Darker",
                        Description = "Daunted by the singular sexual tastes and dark secrets of the beautiful, tormented young entrepreneur Christian Grey, Anastasia Steele has broken off their relationship to start a new career with a Seattle publishing house. But desire for Christian still dominates her every waking thought, and when he proposes a new arrangement, Anastasia cannot resist. They rekindle their searing sensual affair, and Anastasia learns more about the harrowing past of her damaged, driven, and demanding Fifty Shades. While Christian wrestles with his inner demons, Anastasia must confront her anger and envy of the women who came before her and make the most important decision of her life. Erotic, sparkling and suspenseful, Fifty Shades Darker is the irresistibly addictive second part of the Fifty Shades trilogy. ",
                        ImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1358266080l/11857408.jpg",
                        Price = 9.99m,
                        CategoryId = 3,
                        Featured = true
                    }

                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
