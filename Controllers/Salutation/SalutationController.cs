using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers.Salutation
{
    public class SalutationController : Controller
    {
        public ActionResult Index()
        {

            Visiteur client = new Visiteur();
            return View(client);
           
        }

        [HttpPost]
        public ActionResult Index(Visiteur visiteur)
        {
            Visiteur client = new Visiteur();
            string prenom = "";

            prenom = Request.Form["prenom_visiteur"];
            client.Prenom = prenom;
            ViewData["message"] = "Bonjour à toi, " + prenom;
            return View("Index", client);
        }

        /*
            Projet présentation de l’UFR SETs
            Vous aurez à créer une base de données ; 
            •	L’application web mvc va présenter l’UFR surtout
            •	La liste des  départements
            •	La liste des filières
            •	Les PERs
            •	L’administration
            conditions d'acces
         */
    }
}
