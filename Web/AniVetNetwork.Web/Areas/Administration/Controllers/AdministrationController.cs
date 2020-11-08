namespace AniVetNetwork.Web.Areas.Administration.Controllers
{
    using AniVetNetwork.Common;
    using AniVetNetwork.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
