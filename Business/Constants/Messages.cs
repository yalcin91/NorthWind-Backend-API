using Core.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product succesvol toegevoegd";
        public static string ProductDeleted = "Pruduct verwijdert";
        public static string ProductUpdated = "Pruduct update is gelukt";

        public static string UserNotFound = "Gebruiker niet gevonden";
        public static string PasswordError = "Verkeerde password!";
        public static string SuccessfullLogin = "Successvol ingelogd";
        public static string UserAlreadyExists = "Deze gebruiker bestaat al";

        public static string UserRegistered = "Nieuwe gebruiker successvol aangemaakt";
        public static string AccessTokenCreated = "Access token Successvol aangemaakt";
    }
}
