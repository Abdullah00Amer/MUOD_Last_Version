using Firebase.Database;
using MUODLast.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUODLast.Services
{
    public class ProfileService
    {
        FirebaseClient client;

        //public string Username { get; private set; }

        public ProfileService()
        {
            client = new FirebaseClient("https://last-muod-default-rtdb.firebaseio.com/");

        }


        public async Task<List<User>> getProfileAsync()
        {

            var informationuser = (await client.Child("Users").OnceAsync<User>()).Select(d => new User
            {
                Username = d.Object.Username,
                Password = d.Object.Password,

            }).ToList();

            return informationuser;
        }


        public async Task<ObservableCollection<User>> Getuserinformation(string Username)
        {
            var userinformation = new ObservableCollection<User>();
            var invormation = (await getProfileAsync()).Where(a => a.Username == Username).ToList();
            foreach (var info in invormation)
            {
                userinformation.Add(info);
            }
            return userinformation;
        }
    }
}
