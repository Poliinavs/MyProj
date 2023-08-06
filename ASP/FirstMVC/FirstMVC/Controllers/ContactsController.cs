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

        public IActionResult Telephone()
        {
            return View();
        }


        [HttpPost] //передача данных из формы по post
        public IActionResult Check(Contact contact )
        {
            if (ModelState.IsValid) //если данные валидны 
            {
                return Redirect("/");
            }
            return View("Index"); //возвращаем шаблон index
        }

    }

}
