using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using taller2Razor.Models;

namespace taller2Razor.Controllers
{
    public class UsuarioController : Controller
    {
        proyectounoEntities BASEDATOS = new proyectounoEntities();
        // GET: Usuario
        public ActionResult Index()
        {
            return View(BASEDATOS.tbUsuario.ToList());
        }
        public ActionResult InsertarUsuario()
        {
            
            return View(BASEDATOS.tbUsuario.ToList());
        }
        public ActionResult NuevoUsuario()
        {
            return View(BASEDATOS.tbRol.ToList());
        }
        public ActionResult CrearNuevoUsuario()
        {
            return RedirectToAction("InsertarUsuario");
        }
        [HttpPost]
        public ActionResult CrearNuevoUsuario(FormCollection formulario)
        {
            int per = int.Parse(formulario["SeleccionarRol"]);
            String nom = formulario["NombreUsuario"];
            String Eml = formulario["Email"];
            proyectounoEntities Casa = new proyectounoEntities();
            tbUsuario usu = new tbUsuario();

            usu.IdUsuario = per;
            usu.NombreUsuario = nom;
            usu.Email = Eml;
            BASEDATOS.tbUsuario.Add(usu);
            BASEDATOS.SaveChanges();
            return RedirectToAction("InsertarUsuario");
        }
    }
}