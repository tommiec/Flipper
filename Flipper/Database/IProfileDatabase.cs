using Flipper.Domain;

namespace Flipper.Database
{
    public interface IProfileDatabase
    {
        Profile Insert(Profile profile);
        IEnumerable<Profile> GetProfiles();
        Profile GetProfile(int Id);
        void Update(int Id, Profile profile);
        void Delete(int Id);
    }
}
