using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVC.Controllers
{
    public class ContactsController:Controller
    {
        public IActionResult Index() //при переходе на Contacts срабатывает данный метод
        {
            return View();
        }

    }

}
