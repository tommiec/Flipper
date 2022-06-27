using Flipper.Domain;

namespace Flipper.Database
{
    public class ProfileDatabase : IProfileDatabase
    {
        private int counter;
        private readonly List<Profile> profiles;

        public ProfileDatabase()
        {
            profiles = new List<Profile>();

            Insert(new Profile
            {
                ProfileName = "Thomas"
            });

            Insert(new Profile
            {
                ProfileName = "Lieselot"
            });

            Insert(new Profile
            {
                ProfileName = "Clara"
            });
        }

        public void Delete(int Id)
        {
            var profile = profiles.FirstOrDefault(x => x.Id == Id);
            if (profile != null)
            {
                profiles.Remove(profile);
            }
        }

        public Profile GetProfile(int Id)
        {
            return profiles.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Profile> GetProfiles()
        {
            return profiles;
        }

        public Profile Insert(Profile profile)
        {
            profile.Id = ++counter;
            profiles.Add(profile);
            return profile;
        }

        public void Update(int Id, Profile updatedProfile)
        {
            var profile = profiles.FirstOrDefault(x => x.Id == Id);
            if (profile != null)
            {
                profile.ProfileName = updatedProfile.ProfileName;
            }
        }
    }
}
