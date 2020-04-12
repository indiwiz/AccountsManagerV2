using System.Threading.Tasks;

namespace AccountsManager.Application.Commands
{
    public interface ICommand<T> where T: class
    {
        void Handle(T command);
    }
}