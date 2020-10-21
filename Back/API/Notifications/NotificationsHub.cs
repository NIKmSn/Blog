using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.Notifications
{
    [Authorize]
    public class NotificationsHub : Hub { }
}