using Todo.App.Models;

namespace Todo.App.Interfaces;

public interface IActivityService
{
    IEnumerable<Activity> GetAll();
    Activity? GetById(int id);
    Activity Create(Activity activity);
    Activity? Update(int id, Activity activity);
    bool Delete(int id);
}
