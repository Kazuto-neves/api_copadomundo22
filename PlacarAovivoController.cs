using Microsoft.AspNetCore.Mvc;
using PlacarAovivoModel;

internal class PlacarAovivoController
{
    private static void Main(string[] args)
    {
    }

    private static ActionResult Index()
    {
        IEnumerable<PlacarAovivoViewModel> contatos = null;

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:44320/api/apiv2.allsportsapi.com/football?met=Livescore");

            //HTTP GET
            var responseTask = client.GetAsync("Countryid");
            responseTask.Wait();
            var result = responseTask.Result;

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<PlacarAovivoViewModel>>();
                readTask.Wait();
                PlacarAovivoViews = readTask.Result;
            }
            else
            {
                contatos = Enumerable.Empty<PlacarAovivoViewModel>();
                ModelState.AddModelError(string.Empty, "Erro no servidor. Contate o Administrador.");
            }
            return View(PlacarAovivoViews);
        }
    }

    private static ActionResult create1(PlacarAovivoViewModel placar)
    {
        if (placar == null)
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:44320/api/apiv2.allsportsapi.com/football?met=Livescore");
            //HTTP POST
            var postTask = client.PostAsJsonAsync<ContatoEnderecoViewModel>("Placar", placar);
            postTask.Wait();
            var result = postTask.Result;

            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        ModelState.AddModelError(string.Empty, "Erro no Servidor. Contacte o Administrador.");
        return View(placar);
    }

    private static ActionResult create()
    {
        return View(PlacarAovivoViews);
    }
}