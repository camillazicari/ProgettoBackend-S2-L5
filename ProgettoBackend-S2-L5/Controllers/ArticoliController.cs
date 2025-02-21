using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using Microsoft.AspNetCore.Mvc;
using ProgettoBackend_S2_L5.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgettoBackend_S2_L5.Controllers
{
    public class ArticoliController : Controller
    {
        private static List<Articolo> articoli = new List<Articolo>
        {

            new()
            {
                Id = Guid.NewGuid(),
                Nome = "Nike Air Max DN",
                Prezzo = 94.99m,
                Descrizione = "La scarpa integra il nostro sistema di unità Dynamic Air con due set di tubi a doppia pressione. Abbiamo regolato ogni set a un livello di pressione diverso, con la più ferma nel tallone e la più morbida sotto il centro del piede. L'aria si sposta all'interno con ogni tuo passo creando una transizione fluida.",
                Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/7dc5794a-ce40-4bf2-bb8f-32cb8be866ea/AIR+MAX+DN+%28GS%29.png",
                Immagine2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/e0e74245-af19-49b7-a261-a72b2cfc592d/AIR+MAX+DN+%28GS%29.png",
                Immagine3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/765d660d-d882-4115-bb58-19f54f4a8018/AIR+MAX+DN+%28GS%29.png"

            },

            new()
            {
                Id = Guid.NewGuid(),
                Nome = "Nike Air Max",
                Prezzo = 189.99m,
                Descrizione = "La tomaia in materiale sintetico, con mesh traspirante, offre comfort, leggerezza e resistenza. " +
                "Originariamente concepita per il running ad alte prestazioni, l'unità Nike Air offre leggerezza e un'ammortizzazione che dura nel tempo. " +
                "Per portare la vita da spiaggia in città, il prominente arco in TPU ricorda la coda di una balena e aggiunge struttura, mentre le iconiche dita in TPU richiamano le palme e le onde dell'oceano. " +
                 "TPU sulla punta per una maggiore resistenza e un tocco di lucentezza.",
                Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/877d30e7-4880-46f8-aa71-6704eb7d944d/AIR+MAX+PLUS.png",
                Immagine2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/94ee6b23-9c33-437a-8992-a5aa06436ada/NIKE+AIR+MAX+PLUS.png",
                Immagine3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/47b7945e-a379-4c24-b9df-98f4eef178e5/NIKE+AIR+MAX+PLUS.png"

            },

            new()
            {
                Id = Guid.NewGuid(),
                Nome = "Nike Dunk Low",
                Prezzo = 71.99m,
                Descrizione = "Tomaia in pelle dalla leggera lucentezza che offre, con il passare del tempo, una morbidezza ideale e presenta strati esterni resistenti che richiamano il basket anni Ottanta. Intersuola in schiuma per un'ammortizzazione leggera e reattiva. Collare imbottito a taglio basso per comfort ed eleganza. Vivaci blocchi di colore su alcuni modelli per rievocare i colori University della prima edizione del 1985 e darti la possibilità di scegliere una scarpa leggendaria per fare il tifo per la tua squadra. Battistrada in gomma, con classico punto di torsione per il basket, per resistenza, trazione e uno stile leggendario.",
                Copertina = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/a447e0eb-b47c-464b-91df-5387f958582d/W+NIKE+DUNK+LOW.png",
                Immagine2 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/55f3633a-8a97-4592-8418-ae94e9ae999d/W+NIKE+DUNK+LOW+NEXT+NATURE.png",
                Immagine3 = "https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,q_auto:eco/86421db8-3873-4535-82dc-764e3c5211a6/W+NIKE+DUNK+LOW.png"

            }
        };


        public IActionResult Index()
        {
            var listaArt = new ArticoliViewModel()
            {
                Articoli = articoli
            };
            return View(listaArt);
        }

        [HttpGet("/articoli/info/{id:guid}")]
        public IActionResult Info(Guid id)
        {
            var articoloEsistente = articoli.FirstOrDefault(a => a.Id == id);
            if (articoloEsistente == null)
            {
                TempData["Error"] = "Articolo non trovato!";
                return RedirectToAction("Index");
            }

            var infoArticolo = new InfoArticolo()
            {
               Id = articoloEsistente.Id,
               Nome = articoloEsistente.Nome,
               Descrizione = articoloEsistente.Descrizione,
               Prezzo = articoloEsistente.Prezzo,
               Copertina = articoloEsistente.Copertina,
               Immagine2 = articoloEsistente.Immagine2,
               Immagine3 = articoloEsistente.Immagine3
            };

            return View(infoArticolo);
        }
    }
}
