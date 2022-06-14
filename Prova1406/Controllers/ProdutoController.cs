using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova1406.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly Contexto _contexto = new Contexto();
    
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return HttpStatusCodeResult(HttpStatusCodeResult.BadRquest);
            }
            ProdutoModel produtoModel = _contexto.Produtos.Find(id);
            if (produtoModel == null)
            {
                return HttpNotFound();
            }
            return View(produtoModel)

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(long id)
        {
            ProdutoModel produtoModel = _contexto.Produtos.Find(id);
            _contexto.Produtos.Remove(produtoModel);
            _contexto.Produtos.Add(produtoModel.Nome);
            _contexto.SaveChanges();
            returnRedirectToAction("Index");
        }
    }
}