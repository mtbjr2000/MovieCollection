using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCollection.Data.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Genre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 429351, "Drama", new DateTime(2018, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "12 Strong" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1452, "Adventure", new DateTime(2006, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Superman Returns" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 37686, "Thriller", new DateTime(2011, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Super 8" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 297761, "Adventure", new DateTime(2016, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Suicide Squad" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 181808, "Adventure", new DateTime(2017, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: The Last Jedi" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 140607, "Adventure", new DateTime(2015, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: The Force Awakens" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 13475, "Adventure", new DateTime(2009, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Trek" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 54138, "Adventure", new DateTime(2013, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Trek Into Darkness" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 381288, "Horror", new DateTime(2017, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Split" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 129, "Fantasy", new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 19959, "Action", new DateTime(2009, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Surrogates" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 315635, "Adventure", new DateTime(2017, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spider-Man: Homecoming" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 251519, "Adventure", new DateTime(2014, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Son of Batman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 110415, "Drama", new DateTime(2013, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Snowpiercer" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 37724, "Adventure", new DateTime(2012, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skyfall" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82507, "Horror", new DateTime(2012, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinister" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82693, "Drama", new DateTime(2012, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Linings Playbook" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 11324, "Drama", new DateTime(2010, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shutter Island" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 58574, "Adventure", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sherlock Holmes: A Game of Shadows" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 225886, "Comedy", new DateTime(2014, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sex Tape" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 27576, "Action", new DateTime(2010, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salt" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 235260, "Drama", new DateTime(2014, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Son of God" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 127533, "Drama", new DateTime(2012, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rurouni Kenshin" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 38757, "Animation", new DateTime(2010, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tangled" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 408647, "Animation", new DateTime(2017, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teen Titans: The Judas Contract" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49519, "Adventure", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Croods" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 11362, "Adventure", new DateTime(2002, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Count of Monte Cristo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 138843, "Horror", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 259693, "Horror", new DateTime(2016, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Conjuring 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399035, "Drama", new DateTime(2018, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Commuter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10140, "Adventure", new DateTime(2010, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chronicles of Narnia: The Voyage of the Dawn Treader" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 2454, "Adventure", new DateTime(2008, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Chronicles of Narnia: Prince Caspian" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 77953, "Comedy", new DateTime(2012, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Campaign" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 22970, "Horror", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Cabin in the Woods" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 72105, "Fantasy", new DateTime(2012, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ted" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 2503, "Drama", new DateTime(2007, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Bourne Ultimatum" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49040, "Action", new DateTime(2012, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Bourne Legacy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 2501, "Drama", new DateTime(2002, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Bourne Identity" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 295693, "Animation", new DateTime(2017, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Boss Baby" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 341006, "Action", new DateTime(2016, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Belko Experiment" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 24428, "Adventure", new DateTime(2012, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Avengers" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 4512, "Drama", new DateTime(2007, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Assassination of Jesse James by the Coward Robert Ford" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 209247, "Comedy", new DateTime(2013, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Art of the Steal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1930, "Adventure", new DateTime(2012, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Amazing Spider-Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 102382, "Adventure", new DateTime(2014, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Amazing Spider-Man 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 2502, "Drama", new DateTime(2004, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Bourne Supremacy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 221732, "Adventure", new DateTime(2014, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rurouni Kenshin: The Legend Ends" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 221731, "Adventure", new DateTime(2014, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rurouni Kenshin: Kyoto Inferno" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 80585, "Drama", new DateTime(2012, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock of Ages" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 166426, "Adventure", new DateTime(2017, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: Dead Men Tell No Tales" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 58, "Adventure", new DateTime(2006, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: Dead Man's Chest" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 285, "Adventure", new DateTime(2007, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: At World's End" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 32657, "Adventure", new DateTime(2010, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Percy Jackson & the Olympians: The Lightning Thief" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76285, "Adventure", new DateTime(2013, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Percy Jackson: Sea of Monsters" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 388399, "Drama", new DateTime(2016, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Patriots Day" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 274870, "Drama", new DateTime(2016, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Passengers" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 119283, "Action", new DateTime(2013, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 286565, "Drama", new DateTime(2015, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paper Towns" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1865, "Adventure", new DateTime(2011, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: On Stranger Tides" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 346648, "Adventure", new DateTime(2017, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paddington 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 242512, "Horror", new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ouija" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 395991, "Drama", new DateTime(2017, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only the Brave" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 117263, "Action", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Olympus Has Fallen" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 179826, "Thriller", new DateTime(2013, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odd Thomas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 157547, "Horror", new DateTime(2013, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oculus" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 75612, "Adventure", new DateTime(2013, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oblivion" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 75656, "Thriller", new DateTime(2013, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Now You See Me" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 225574, "Action", new DateTime(2014, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Non-Stop" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 86834, "Adventure", new DateTime(2014, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noah" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 68726, "Adventure", new DateTime(2013, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pacific Rim" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 22, "Adventure", new DateTime(2003, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pirates of the Caribbean: The Curse of the Black Pearl" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 16866, "Adventure", new DateTime(2009, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet 51" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 869, "Adventure", new DateTime(2001, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Planet of the Apes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9928, "Animation", new DateTime(2005, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robots" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 5548, "Action", new DateTime(1987, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "RoboCop" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 61791, "Drama", new DateTime(2011, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise of the Planet of the Apes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 294993, "Drama", new DateTime(2014, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise of the Legend" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 81188, "Fantasy", new DateTime(2012, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rise of the Guardians" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 46195, "Adventure", new DateTime(2011, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rio" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 87421, "Action", new DateTime(2013, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Riddick" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 173897, "Horror", new DateTime(2016, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil: The Final Chapter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 71679, "Horror", new DateTime(2012, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil: Retribution" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 39514, "Adventure", new DateTime(2010, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "RED" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 401981, "Thriller", new DateTime(2018, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Sparrow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49730, "Fantasy", new DateTime(2011, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Riding Hood" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 146216, "Action", new DateTime(2013, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "RED 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 333339, "Adventure", new DateTime(2018, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ready Player One" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 2062, "Fantasy", new DateTime(2007, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratatouille" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 427641, "Adventure", new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rampage" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 417859, "Adventure", new DateTime(2011, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Puss in Boots" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 70981, "Adventure", new DateTime(2012, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prometheus" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9543, "Adventure", new DateTime(2010, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prince of Persia: The Sands of Time" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 206487, "Thriller", new DateTime(2014, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Predestination" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76649, "Adventure", new DateTime(2014, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pompeii" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 306819, "Drama", new DateTime(2015, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Danish Girl" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 195589, "Comedy", new DateTime(2014, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Neighbors" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49026, "Drama", new DateTime(2012, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight Rises" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 353491, "Fantasy", new DateTime(2017, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Tower" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9741, "Drama", new DateTime(2000, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unbreakable" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 257785, "Drama", new DateTime(2017, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tulip Fever" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 460019, "Horror", new DateTime(2018, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Truth or Dare" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 20526, "Adventure", new DateTime(2010, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "TRON: Legacy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1858, "Adventure", new DateTime(2007, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transformers" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 335988, "Adventure", new DateTime(2017, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transformers: The Last Knight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 8373, "Adventure", new DateTime(2009, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transformers: Revenge of the Fallen" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 38356, "Adventure", new DateTime(2011, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transformers: Dark of the Moon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 91314, "Adventure", new DateTime(2014, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transformers: Age of Extinction" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 346672, "Fantasy", new DateTime(2016, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underworld: Blood Wars" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 396535, "Horror", new DateTime(2016, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Train to Busan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 861, "Adventure", new DateTime(1990, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Total Recall" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 338970, "Adventure", new DateTime(2018, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomb Raider" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1273, "Adventure", new DateTime(2007, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "TMNT" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 13179, "Adventure", new DateTime(2008, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tinker Bell" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10195, "Adventure", new DateTime(2011, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76338, "Adventure", new DateTime(2013, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor: The Dark World" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 288158, "Drama", new DateTime(2014, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Woman in Black 2: Angel of Death" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 106646, "Drama", new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wolf of Wall Street" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 310131, "Horror", new DateTime(2016, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witch" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 473149, "Horror", new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Traffik" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 293670, "Horror", new DateTime(2016, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wailing" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 834, "Fantasy", new DateTime(2006, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underworld: Evolution" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 277, "Fantasy", new DateTime(2003, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underworld" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49538, "Adventure", new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "X-Men: First Class" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82690, "Adventure", new DateTime(2012, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wreck-It Ralph" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 57165, "Adventure", new DateTime(2012, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrath of the Titans" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 72190, "Drama", new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "World War Z" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 406997, "Drama", new DateTime(2017, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 297762, "Adventure", new DateTime(2017, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonder Woman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 7978, "Fantasy", new DateTime(2010, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wolfman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 416234, "Fantasy", new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winchester" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 117251, "Drama", new DateTime(2013, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "White House Down" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 12437, "Adventure", new DateTime(2009, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Underworld: Rise of the Lycans" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 406990, "Drama", new DateTime(2017, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "What Happened to Monday" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 281338, "Drama", new DateTime(2017, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "War for the Planet of the Apes" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 301372, "Drama", new DateTime(2017, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voice from the Stone" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 423899, "Drama", new DateTime(2017, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victoria & Abdul" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 228066, "Drama", new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Victor Frankenstein" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 339964, "Adventure", new DateTime(2017, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valerian and the City of a Thousand Planets" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 752, "Fantasy", new DateTime(2006, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "V for Vendetta" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 58244, "Fantasy", new DateTime(2012, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Upside Down" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 44048, "Action", new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unstoppable" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 467660, "Horror", new DateTime(2018, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Unsane" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82654, "Horror", new DateTime(2013, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm Bodies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 476926, "Thriller", new DateTime(2018, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Titan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 365942, "Adventure", new DateTime(2017, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Space Between Us" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 15121, "Drama", new DateTime(1965, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sound of Music" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 278927, "Adventure", new DateTime(2016, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Jungle Book" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9806, "Adventure", new DateTime(2004, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Incredibles" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1724, "Adventure", new DateTime(2008, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Incredible Hulk" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 124459, "Comedy", new DateTime(2013, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Incredible Burt Wonderstone" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 80278, "Drama", new DateTime(2012, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Impossible" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 430040, "Action", new DateTime(2018, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hurricane Heist" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 70160, "Adventure", new DateTime(2012, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hunger Games" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 101299, "Adventure", new DateTime(2013, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hunger Games: Catching Fire" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 57158, "Adventure", new DateTime(2013, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit: The Desolation of Smaug" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 156700, "Drama", new DateTime(2013, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Kings of Summer" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 122917, "Adventure", new DateTime(2014, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hobbit: The Battle of the Five Armies" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 40805, "Action", new DateTime(2011, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Green Hornet" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 316029, "Drama", new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Greatest Showman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 311324, "Adventure", new DateTime(2016, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Wall" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 64682, "Drama", new DateTime(2013, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 379149, "Drama", new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Foreigner" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 222935, "Drama", new DateTime(2014, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Fault in Our Stars" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 371638, "Drama", new DateTime(2017, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Disaster Artist" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76493, "Comedy", new DateTime(2012, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dictator" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 487670, "Animation", new DateTime(2018, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Death of Superman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 390043, "Action", new DateTime(2017, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hitman's Bodyguard" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10196, "Adventure", new DateTime(2010, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Airbender" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76640, "Action", new DateTime(2013, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last Stand" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 324849, "Fantasy", new DateTime(2017, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lego Batman Movie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 27022, "Adventure", new DateTime(2010, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Sorcerer's Apprentice" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 694, "Horror", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399055, "Fantasy", new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shape of Water" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 116745, "Adventure", new DateTime(2013, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Secret Life of Walter Mitty" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 281957, "Adventure", new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Revenant" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 70436, "Thriller", new DateTime(2012, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Raven" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 316727, "Horror", new DateTime(2016, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Purge: Election Year" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 446354, "Drama", new DateTime(2018, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Post" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 97367, "Drama", new DateTime(2013, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Place Beyond the Pines" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 193610, "Comedy", new DateTime(2014, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Other Woman" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 412950, "Horror", new DateTime(2016, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Orphanage" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9479, "Fantasy", new DateTime(1993, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Nightmare Before Christmas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 64328, "Comedy", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Muppets" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 152760, "Drama", new DateTime(2014, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Monuments Men" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 198663, "Action", new DateTime(2014, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Maze Runner" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 603, "Action", new DateTime(1999, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 605, "Adventure", new DateTime(2003, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix Revolutions" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 604, "Adventure", new DateTime(2003, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix Reloaded" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 286217, "Adventure", new DateTime(2015, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Martian" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 450322, "Drama", new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Man Who Invented Christmas" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 333484, "Adventure", new DateTime(2016, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Magnificent Seven" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 155, "Drama", new DateTime(2008, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 398181, "Drama", new DateTime(2017, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "You Were Never Really Here" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 136797, "Drama", new DateTime(2014, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Need for Speed" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 27265, "Comedy", new DateTime(1996, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mother" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 293660, "Adventure", new DateTime(2016, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399404, "Drama", new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darkest Hour" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 62213, "Fantasy", new DateTime(2012, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Shadows" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 152532, "Drama", new DateTime(2013, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dallas Buyers Club" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 419680, "Comedy", new DateTime(2017, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daddy's Home 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 146, "Adventure", new DateTime(2000, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crouching Tiger, Hidden Dragon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 201085, "Fantasy", new DateTime(2015, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crimson Peak" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 312221, "Drama", new DateTime(2015, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Creed" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49849, "Action", new DateTime(2011, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cowboys & Aliens" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 395990, "Drama", new DateTime(2018, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Wish" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 14836, "Animation", new DateTime(2009, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coraline" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 37430, "Adventure", new DateTime(2011, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conan the Barbarian" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 339967, "Fantasy", new DateTime(2016, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colossal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 354912, "Animation", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coco" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 18823, "Adventure", new DateTime(2010, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clash of the Titans" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76726, "Drama", new DateTime(2012, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chronicle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 198184, "Action", new DateTime(2015, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chappie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 36557, "Adventure", new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casino Royale" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 920, "Adventure", new DateTime(2006, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cars" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49013, "Adventure", new DateTime(2011, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cars 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 39538, "Drama", new DateTime(2011, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Contagion" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 109424, "Drama", new DateTime(2013, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain Phillips" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 296524, "Drama", new DateTime(2016, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deepwater Horizon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 93456, "Animation", new DateTime(2013, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Despicable Me 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 166424, "Adventure", new DateTime(2015, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Four" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 259316, "Adventure", new DateTime(2016, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fantastic Beasts and Where to Find Them" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 264660, "Drama", new DateTime(2015, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ex Machina" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 109428, "Horror", new DateTime(2013, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evil Dead" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 253412, "Adventure", new DateTime(2015, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everest" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 107846, "Action", new DateTime(2013, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Escape Plan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 116711, "Adventure", new DateTime(2013, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Epic" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 68724, "Drama", new DateTime(2013, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elysium" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 137113, "Action", new DateTime(2014, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edge of Tomorrow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 184346, "Horror", new DateTime(2014, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deliver Us from Evil" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 387592, "Adventure", new DateTime(2018, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Early Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 11360, "Animation", new DateTime(1941, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dumbo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49049, "Action", new DateTime(2012, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dredd" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 301337, "Drama", new DateTime(2017, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Downsizing" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 284052, "Adventure", new DateTime(2016, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor Strange" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 68718, "Drama", new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django Unchained" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 157350, "Adventure", new DateTime(2014, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Divergent" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 127517, "Drama", new DateTime(2012, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disconnect" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 20352, "Animation", new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Despicable Me" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 324852, "Animation", new DateTime(2017, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Despicable Me 3" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 374720, "Drama", new DateTime(2017, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dunkirk" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 1771, "Adventure", new DateTime(2011, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain America: The First Avenger" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 271110, "Adventure", new DateTime(2016, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Captain America: Civil War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 13053, "Adventure", new DateTime(2008, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolt" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 12155, "Adventure", new DateTime(2010, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice in Wonderland" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 9772, "Action", new DateTime(1997, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Air Force One" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82700, "Adventure", new DateTime(2013, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "After Earth" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 79931, "Music", new DateTime(2011, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adele: Live at the Royal Albert Hall" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 445954, "Drama", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Acts of Vengeance" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 72331, "Fantasy", new DateTime(2012, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abraham Lincoln: Vampire Hunter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 122906, "Drama", new DateTime(2013, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "About Time" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 407451, "Adventure", new DateTime(2018, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Wrinkle in Time" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10229, "Drama", new DateTime(2002, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Walk to Remember" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 402529, "Drama", new DateTime(2017, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "All Eyez on Me" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 169917, "Drama", new DateTime(2014, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Walk Among the Tombstones" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 47964, "Action", new DateTime(2013, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Good Day to Die Hard" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 428449, "Fantasy", new DateTime(2017, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Ghost Story" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 340837, "Horror", new DateTime(2017, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Cure for Wellness" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 17979, "Animation", new DateTime(2009, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Christmas Carol" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 12244, "Adventure", new DateTime(2009, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "9" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 64686, "Adventure", new DateTime(2013, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "47 Ronin" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 403119, "Adventure", new DateTime(2017, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "47 Meters Down" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 53182, "Drama", new DateTime(2014, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "300: Rise of an Empire" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 64688, "Action", new DateTime(2012, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "21 Jump Street" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 447332, "Drama", new DateTime(2018, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Quiet Place" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 415842, "Action", new DateTime(2017, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Assassin" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 190859, "Action", new DateTime(2014, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Sniper" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 250546, "Horror", new DateTime(2014, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annabelle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 335984, "Thriller", new DateTime(2017, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blade Runner 2049" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 426284, "Drama", new DateTime(2017, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Blade of the Immortal" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 284054, "Adventure", new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Black Panther" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 177572, "Adventure", new DateTime(2014, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Big Hero 6" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399248, "Action", new DateTime(2018, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beirut" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 25979, "Music", new DateTime(1997, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bee Gees: One Night Only" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 321612, "Fantasy", new DateTime(2017, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beauty and the Beast" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 339846, "Action", new DateTime(2017, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Baywatch" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 44833, "Adventure", new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Battleship" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 485942, "Animation", new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Ninja" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 272, "Drama", new DateTime(2005, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman Begins" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 411736, "Animation", new DateTime(2016, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Return of the Caped Crusaders" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 471474, "Animation", new DateTime(2018, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Gotham by Gaslight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 366924, "Animation", new DateTime(2016, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Bad Blood" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 242643, "Animation", new DateTime(2014, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman: Assault on Arkham" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 341013, "Action", new DateTime(2017, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atomic Blonde" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 16577, "Animation", new DateTime(2009, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Astro Boy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 329865, "Drama", new DateTime(2016, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arrival" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 95, "Adventure", new DateTime(1998, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Armageddon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 68734, "Drama", new DateTime(2012, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Argo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 102899, "Adventure", new DateTime(2015, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ant-Man" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82992, "Action", new DateTime(2013, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast & Furious 6" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 392044, "Drama", new DateTime(2017, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Murder on the Orient Express" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 51497, "Action", new DateTime(2011, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fast Five" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 341174, "Drama", new DateTime(2017, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifty Shades Darker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49444, "Animation", new DateTime(2011, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kung Fu Panda 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 313297, "Adventure", new DateTime(2016, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kubo and the Two Strings" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 293167, "Adventure", new DateTime(2017, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kong: Skull Island" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 207703, "Adventure", new DateTime(2015, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kingsman: The Secret Service" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 343668, "Adventure", new DateTime(2017, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kingsman: The Golden Circle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 274857, "Fantasy", new DateTime(2017, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "King Arthur: Legend of the Sword" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 23483, "Action", new DateTime(2010, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kick-Ass" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 59859, "Adventure", new DateTime(2013, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kick-Ass 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 141052, "Adventure", new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice League" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 313369, "Drama", new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "La La Land" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 217993, "Animation", new DateTime(2014, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice League: War" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 183011, "Adventure", new DateTime(2013, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice League: The Flashpoint Paradox" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 323027, "Fantasy", new DateTime(2015, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice League: Gods and Monsters" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76757, "Adventure", new DateTime(2015, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jupiter Ascending" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 353486, "Adventure", new DateTime(2017, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jumanji: Welcome to the Jungle" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 245891, "Action", new DateTime(2014, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Wick" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 324552, "Action", new DateTime(2017, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Wick: Chapter 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49529, "Adventure", new DateTime(2012, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Carter" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 324668, "Action", new DateTime(2016, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason Bourne" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 81005, "Adventure", new DateTime(2013, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack the Giant Slayer" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 297556, "Adventure", new DateTime(2015, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Justice League: Throne of Atlantis" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 137094, "Drama", new DateTime(2014, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Ryan: Shadow Recruit" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 48750, "Drama", new DateTime(1995, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 395992, "Drama", new DateTime(2017, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 376867, "Drama", new DateTime(2016, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moonlight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 585, "Animation", new DateTime(2001, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monsters, Inc." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 62211, "Animation", new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monsters University" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 283366, "Adventure", new DateTime(2016, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miss Peregrine's Home for Peculiar Children" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 41154, "Action", new DateTime(2012, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Men in Black 3" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 336843, "Adventure", new DateTime(2018, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maze Runner: The Death Cure" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 407439, "Drama", new DateTime(2018, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mary Magdalene" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399366, "Drama", new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marrowbone" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49521, "Adventure", new DateTime(2013, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Man of Steel" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 87827, "Adventure", new DateTime(2012, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life of Pi" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 132232, "Horror", new DateTime(2013, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mama" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 80321, "Animation", new DateTime(2012, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Madagascar 3: Europe's Most Wanted" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76341, "Adventure", new DateTime(2015, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mad Max: Fury Road" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 240832, "Action", new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 59967, "Action", new DateTime(2012, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Looper" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 267860, "Action", new DateTime(2016, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "London Has Fallen" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 263115, "Drama", new DateTime(2017, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 399170, "Drama", new DateTime(2017, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan Lucky" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 81796, "Action", new DateTime(2012, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lockout" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 72976, "Drama", new DateTime(2012, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lincoln" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 102651, "Adventure", new DateTime(2014, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Maleficent" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 75780, "Drama", new DateTime(2012, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Reacher" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 343611, "Adventure", new DateTime(2016, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack Reacher: Never Go Back" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 346364, "Drama", new DateTime(2017, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "It" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 44912, "Adventure", new DateTime(2011, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green Lantern" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 17445, "Animation", new DateTime(2009, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green Lantern: First Flight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 65291, "Adventure", new DateTime(2011, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green Lantern: Emerald Knights" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49047, "Drama", new DateTime(2013, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gravity" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 124905, "Drama", new DateTime(2014, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Godzilla" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 400928, "Drama", new DateTime(2017, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gifted" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 315837, "Drama", new DateTime(2017, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost in the Shell" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 419430, "Horror", new DateTime(2017, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Get Out" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 274855, "Action", new DateTime(2017, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Geostorm" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 283995, "Adventure", new DateTime(2017, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy Vol. 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82682, "Drama", new DateTime(2013, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gangster Squad" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 72559, "Adventure", new DateTime(2013, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "G.I. Joe: Retaliation" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 109445, "Adventure", new DateTime(2013, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frozen" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 26389, "Action", new DateTime(2010, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "From Paris with Love" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 62214, "Animation", new DateTime(2012, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frankenweenie" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 87502, "Drama", new DateTime(2012, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flight" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 400710, "Drama", new DateTime(2017, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flatliners" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 127380, "Adventure", new DateTime(2016, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finding Dory" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 216015, "Drama", new DateTime(2015, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifty Shades of Grey" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 337167, "Drama", new DateTime(2018, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fifty Shades Freed" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 445571, "Comedy", new DateTime(2018, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game Night" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 118340, "Adventure", new DateTime(2014, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guardians of the Galaxy" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 324786, "Drama", new DateTime(2016, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hacksaw Ridge" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 440021, "Horror", new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Happy Death Day" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 418078, "Drama", new DateTime(2017, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "It Comes at Night" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 68721, "Adventure", new DateTime(2013, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man 3" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10138, "Adventure", new DateTime(2010, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iron Man 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 157336, "Adventure", new DateTime(2014, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 406563, "Horror", new DateTime(2018, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insidious: The Last Key" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 150540, "Animation", new DateTime(2015, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inside Out" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 47933, "Adventure", new DateTime(2016, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Independence Day: Resurgence" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 27205, "Adventure", new DateTime(2010, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 49530, "Action", new DateTime(2011, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "In Time" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 37958, "Fantasy", new DateTime(2011, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Immortals" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 57800, "Adventure", new DateTime(2012, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ice Age: Continental Drift" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 389015, "Drama", new DateTime(2017, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "I, Tonya" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 419831, "Fantasy", new DateTime(2018, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "I Kill Giants" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 44826, "Adventure", new DateTime(2011, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hugo" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 10191, "Adventure", new DateTime(2010, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to Train Your Dragon" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 82702, "Adventure", new DateTime(2014, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to Train Your Dragon 2" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 76492, "Fantasy", new DateTime(2012, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hotel Transylvania" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 12222, "Adventure", new DateTime(2008, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horton Hears a Who!" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 249070, "Action", new DateTime(2015, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hitman: Agent 47" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 184315, "Adventure", new DateTime(2014, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hercules" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 152601, "Drama", new DateTime(2013, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Her" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 364689, "Adventure", new DateTime(2017, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ferdinand" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "ReleaseDate", "Title" },
                values: new object[] { 329833, "Comedy", new DateTime(2016, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zoolander 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
