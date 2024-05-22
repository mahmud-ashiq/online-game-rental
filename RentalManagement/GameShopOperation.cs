using DbConnectionSample.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalManagement
{
    internal class GameShopOperation
    {
        public bool AddGame( string title, int year, int price, string developer)
        {
            GameLibraryData libraryData = new GameLibraryData();
            GameLibrary game = new GameLibrary();
            //game.GameID = id;
            game.GameTitle = title;
            game.ReleasedYear= year;
            game.Price = price;
            game.DeveloperName= developer;
            return libraryData.Insert(game);
        }
    }
}
